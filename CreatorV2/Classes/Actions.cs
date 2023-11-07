using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System.DirectoryServices.AccountManagement;
using System.Globalization;

namespace CreatorV2.Classes
{
    public class UserPrincipalEx : UserPrincipal
    {
        public UserPrincipalEx(PrincipalContext context) : base(context) { }

        public UserPrincipalEx(PrincipalContext context, string samAccountName, string password, bool enabled) :
            base(context, samAccountName, password, enabled)
        { }

        // Add a method to set extensionAttribute1
        public void SetExtensionAttribute(string? valueName, string? valueLastName, string? valueMiddleName, string? valueISUID)
        {
            valueName = string.IsNullOrEmpty(valueName) ? null : valueName;
            valueLastName = string.IsNullOrEmpty(valueLastName) ? null : valueLastName;
            valueMiddleName = string.IsNullOrEmpty(valueMiddleName) ? null : valueMiddleName;
            valueISUID = string.IsNullOrEmpty(valueISUID) ? null : valueISUID;

            ExtensionSet("extensionAttribute2", valueLastName);
            ExtensionSet("extensionAttribute3", valueName);
            ExtensionSet("extensionAttribute4", valueMiddleName);
            ExtensionSet("extensionAttribute5", valueISUID);
        }
    }

    public class Actions
    {
        public Variables _Variables;
        private const int KeySize = 256;
        private const int BlockSize = 128;
        private const string Key = "061392458A955AFCD99FFA56EC851A0C"; //  Base128 encoded string

        public Actions(Variables Variable)
        {
            _Variables = Variable;
        }


        /// <summary>
        /// метод для сохранения всех настроек, один метод для всех настроек. 
        /// </summary>
        /// <param name="newValue"> переменная в которой будет записано новое значение</param>
        /// <param name="targetLineIndex"> переменная в которой написан индекс строки которая будет перезаписана новым значением</param>
        public void SaveSettingsV2(string whatNeedSave, string newLine)
        {
            string filePath = @"Settings.txt";
            string[] lines = File.ReadAllLines(filePath); // Читаем все строки из файла
            int countLineInFile = File.ReadAllLines(filePath).Count();
            bool found = false;

            for (int i = 0; i < countLineInFile - 1; i++)
            {
                string[] line = lines[i].Split("|");
                string qwe = line[0].ToString().Trim();
                if (qwe == whatNeedSave)
                {
                    lines[i] = $"{whatNeedSave} | {newLine}";
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                // Если переменной не было в файле, добавляем новую строку
                string newEntry = $"{whatNeedSave} | {newLine}";
                Array.Resize(ref lines, lines.Length + 1);
                lines[lines.Length - 1] = newEntry;
            }

            File.WriteAllLines(filePath, lines);
        }


        /// <summary>
        /// метод для выгрузки всей информации из файла 
        /// </summary>
        public void UploadAllSettings()
        {
            //string[] upload = { "AdminUserName", "AdminEmail", "AdminPassword", "netbios", "ListGroupForEmplyees", "ListGroupForStudent" };
            _Variables._FIOForSendEmail = LoadSettings2("AdminUserName");
            _Variables._EmailForSendEmail = LoadSettings2("AdminEmail");
            _Variables._PasswordForSendEmail = Encrypt(LoadSettings2("AdminPassword"));
            _Variables.NetBios = LoadSettings2("netbios");
            _Variables._PasswordInAD = LoadSettings2("DefPasswordUser");


            LoadText("RUS");
            LoadText("ENG");

            //string listgroupforEmpliyees = LoadSetting(4)
            string[] lineEmployeer = LoadSettings2("ListGroupForEmplyees").Split(";");
            foreach (string line2 in lineEmployeer)
            {
                _Variables._ListGroupForAddEmployeer.Add(line2);
            }

            string[] lineStudent = LoadSettings2("ListGroupForStudent").Split(";");
            foreach (string line2 in lineStudent)
            {
                _Variables._ListGroupForAddStudent.Add(line2);
            }
        }


        /// <summary>
        /// метод для выгрузки настроек из текстового файла 
        /// </summary>
        /// <param name="WhatNeed">что нужно выгрузить? </param>
        /// <returns></returns>
        public string LoadSettings2(string WhatNeed)
        {
            string filePath = @"Settings.txt";

            var settings = File
                .ReadLines(filePath)
                .Select(line => line.Split('|'))
                .Where(parts => parts.Length == 2)
                .ToDictionary(parts => parts[0].Trim(), parts => parts[1].Trim());

            if (settings.TryGetValue(WhatNeed, out var value))
            {
                return value;
            }

            return string.Empty;
        }


        /// <summary>
        /// метод которые получает список всех групп из АД
        /// </summary>
        public void GetGroups() // метод который получает из АД список всех групп
        {
            //string allGroups = string.Empty;
            //using (_Variables.principalContext)
            {
                // Создаем объект для поиска групп
                PrincipalSearcher searcher = new(_Variables.group);

                // Получаем коллекцию найденных групп
                PrincipalSearchResult<Principal> groups = searcher.FindAll();

                // Проходимся по каждой группе и выводим ее имя
                foreach (Principal result in groups)
                {
                    string allGroups = result.Name;
                    _Variables.ListAllGroups.Add(allGroups);
                }
            }
        }


        /// <summary>
        /// метод которые получает главные из АД
        /// </summary>
        public void GetSettings()
        {
            _Variables.principalContext = new PrincipalContext(ContextType.Domain, _Variables.NetBios);
            _Variables.group = new GroupPrincipal(_Variables.principalContext);
        }


        /// <summary>
        /// метод для сохранения текста для отправки письма на почту новому пользователю
        /// </summary>
        /// <param name="language">переменная принимает RUS или ENG</param>
        public void SavingTextForSendEmail(string language)
        {
            string path = string.Empty;
            if (language == "RUS")
            {
                path = @"textMessageRU.txt";
            }
            else if (language == "ENG")
            {
                path = @"textMessageENG.txt";
            }

            using (StreamWriter sw = new(path))
            {
                try
                {
                    if (language == "RUS")
                    {
                        sw.WriteLine(_Variables.SubjectTextMessageForSendEmail_RUS);
                        sw.WriteLine(_Variables.TextMessageForSendEMAIL_RUS);
                    }
                    else if (language == "ENG")
                    {
                        sw.WriteLine(_Variables.SubjectTextMessageForSendEmail_ENG);
                        sw.WriteLine(_Variables.TextMessageForSendEMAIL_ENG);
                    }
                }
                catch (Exception ex) { MessageBox.Show($"error {ex}"); }
            }
        }


        /// <summary>
        /// метод для выгрузки информации из файла textMessage.txt
        /// </summary>
        /// <param name="language">RUS или ENG</param>
        public void LoadText(string language)
        {
            string path = string.Empty;
            if (language == "RUS")
            {
                path = @"textMessageRU.txt";
            }
            else if (language == "ENG")
            {
                path = @"textMessageENG.txt";
            }


            if (File.Exists(path))
            {
                using (StreamReader sr = new(path))
                {
                    if (language == "ENG")
                    {
                        _Variables.SubjectTextMessageForSendEmail_ENG = sr.ReadLine();
                        _Variables.TextMessageForSendEMAIL_ENG = sr.ReadToEnd();
                    }
                    else if (language == "RUS")
                    {
                        _Variables.SubjectTextMessageForSendEmail_RUS = sr.ReadLine();
                        _Variables.TextMessageForSendEMAIL_RUS = sr.ReadToEnd();
                    }
                }
            }
        }


        /// <summary>
        /// Метод для транслитерации строки
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string Transliteration(string name)
        {
            StringBuilder newName = new StringBuilder();
            foreach (char c in name)
            {
                switch (c)
                {
                    case '-':
                    case ' ':
                        newName.Append(c);
                        break;

                    case 'а':
                        newName.Append("a");
                        break;

                    case 'б':
                        newName.Append("b");
                        break;

                    case 'в':
                        newName.Append("v");
                        break;

                    case 'г':
                        newName.Append("g");
                        break;

                    case 'д':
                        newName.Append("d");
                        break;

                    case 'е':
                    case 'ё':
                        newName.Append("e");
                        break;

                    case 'ж':
                        newName.Append("zh");
                        break;

                    case 'з':
                        newName.Append("z");
                        break;

                    case 'и':
                    case 'й':
                        newName.Append("i");
                        break;

                    case 'к':
                        newName.Append("k");
                        break;

                    case 'л':
                        newName.Append("l");
                        break;

                    case 'м':
                        newName.Append("m");
                        break;

                    case 'н':
                        newName.Append("n");
                        break;

                    case 'о':
                        newName.Append("o");
                        break;

                    case 'п':
                        newName.Append("p");
                        break;

                    case 'р':
                        newName.Append("r");
                        break;

                    case 'с':
                        newName.Append("s");
                        break;

                    case 'т':
                        newName.Append("t");
                        break;

                    case 'у':
                        newName.Append("u");
                        break;

                    case 'ф':
                        newName.Append("f");
                        break;

                    case 'х':
                        newName.Append("kh");
                        break;

                    case 'ц':
                        newName.Append("ts");
                        break;

                    case 'ч':
                        newName.Append("ch");
                        break;

                    case 'ш':
                        newName.Append("sh");
                        break;

                    case 'щ':
                        newName.Append("shch");
                        break;

                    case 'ы':
                        newName.Append("y");
                        break;

                    case 'э':
                        newName.Append("e");
                        break;

                    case 'ь':
                    case 'ъ':
                        // do nothing
                        break;

                    case 'ю':
                        newName.Append("iu");
                        break;

                    case 'я':
                        newName.Append("ia");
                        break;

                    default:
                        // handle any other characters as needed
                        break;
                }
            }
            return newName.ToString();
        }


        /// <summary>
        ///  Метод для изменения текста и добавления в него логина и пароль нового сотрудника
        /// </summary>
        public string ChangeText(string language)
        {
            string adName = "ADName";
            string adPassword = "ADPassword";
            string? full_text_rus = string.Empty;
            string full_text_eng = string.Empty;

            full_text_rus = _Variables.TextMessageForSendEMAIL_RUS;
            full_text_rus = Regex.Replace(full_text_rus, adName, _Variables._SamAccountInAD.ToLower());
            full_text_rus = Regex.Replace(full_text_rus, adPassword, _Variables._PasswordInAD);

            full_text_eng = _Variables.TextMessageForSendEMAIL_ENG;
            full_text_eng = Regex.Replace(full_text_eng, adName, _Variables._SamAccountInAD.ToLower());
            full_text_eng = Regex.Replace(full_text_eng, adPassword, _Variables._PasswordInAD);


            if (language == "RUS")
            {
                return full_text_rus;
            }
            else return full_text_eng;
        }


        /// <summary>
        /// Метод для создания учетной записи 
        /// </summary>
        public void CreateADAccount() //метод по созданию корп учетной записи в АД
        {
            try
            {
                using (_Variables.principalContext)
                {
                    UserPrincipalEx up = new(_Variables.principalContext);
                    up.SamAccountName = _Variables._SamAccountInAD.ToLower();
                    up.Surname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_Variables._lastNameInAD);
                    up.DisplayName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_Variables._nameInAD + " " + _Variables._lastNameInAD);
                    up.EmailAddress = _Variables._SamAccountInAD.ToLower() + "@metalab.ifmo.ru";
                    up.GivenName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_Variables._nameInAD);
                    up.Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_Variables._nameInAD + " " + _Variables._lastNameInAD);
                    if (_Variables._UserDescription == string.Empty)
                    {
                        up.Description = null;
                    }
                    else
                    {
                        up.Description = _Variables._UserDescription;
                    }

                    up.Enabled = true;
                    up.SetPassword(_Variables._PasswordInAD);
                    up.UserPrincipalName = _Variables._SamAccountInAD.ToLower() + "@metalab.ifmo.ru";

                    //up.ExtensionSet("extensionAttribute1", data.LastNameRUS); // не работате 
                    up.SetExtensionAttribute(_Variables._UserName, _Variables._UserlastName, _Variables._UserThistName, _Variables._UserISU_ID);

                    up.Enabled = true;

                    up.Save();
                }
                _Variables.Log.Add($"Пользователь {_Variables._nameInAD} {_Variables._lastNameInAD} создан");
            }
            catch (Exception ex)
            {
                _Variables.Log.Add($"Error\n{ex.Message}");
            }

        }








        /// <summary>
        /// Метод для шифрования пароля
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public string Encrypt(string plainText)//метод зашифрования пароля пользоватлея
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = Convert.FromBase64String(Key);
            byte[] iv = new byte[BlockSize / 8];

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.BlockSize = BlockSize;
                aes.Key = keyBytes;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    ICryptoTransform encryptor = aes.CreateEncryptor();
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                    cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                    cryptoStream.FlushFinalBlock();

                    byte[] cipherBytes = memoryStream.ToArray();
                    return Convert.ToBase64String(cipherBytes);
                }
            }
        }

        /// <summary>
        /// Метод для дешифровки пароля
        /// </summary>
        /// <param name="cipherText"></param>
        /// <returns></returns>
        public string Decrypt(string cipherText)//метод дешифровки пароля пользователя
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Convert.FromBase64String(Key);
            byte[] iv = new byte[BlockSize / 8];

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KeySize;
                aes.BlockSize = BlockSize;
                aes.Key = keyBytes;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream memoryStream = new MemoryStream(cipherBytes))
                {
                    ICryptoTransform decryptor = aes.CreateDecryptor();
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                    byte[] plainBytes = new byte[cipherBytes.Length];

                    int decryptedByteCount = cryptoStream.Read(plainBytes, 0, plainBytes.Length);
                    return Encoding.UTF8.GetString(plainBytes, 0, decryptedByteCount);
                }
            }
        }

    }
}
