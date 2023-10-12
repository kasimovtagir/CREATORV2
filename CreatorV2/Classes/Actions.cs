




namespace CreatorV2.Classes
{
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
        public void SaveSetting(string newValue, int targetLineIndex)
        {
            string filePath = @"Settings.txt";

            string[] lines = File.ReadAllLines(filePath); // Читаем все строки из файла

            if (targetLineIndex >= 0 && targetLineIndex < lines.Length)
            {
                lines[targetLineIndex] = newValue; // Записываем новое значение в целевую строку
            }
            else if (targetLineIndex == lines.Length)
            {
                Array.Resize(ref lines, lines.Length + 1); // Увеличиваем размер массива строк
                lines[targetLineIndex] = newValue; // Добавляем новую строку
            }
            else
            {
                MessageBox.Show("Недопустимый индекс строки.");
            }

            File.WriteAllLines(filePath, lines); // Записываем все строки обратно в файл
        }


        /// <summary>
        /// метод для выгрузки настроек
        /// </summary>
        /// <param name="intex">переменная которая будет выгружена</param>
        /// <returns></returns>
        public string LoadSetting(int intex)
        {
            string filePath = @"Settings.txt";
            int targetLineIndex = intex; // Индекс 4-й строки (индексы начинаются с 0)

            string line = string.Empty;
            int currentLineIndex = 0;

            using (StreamReader sr = new StreamReader(filePath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (currentLineIndex == targetLineIndex)
                    {
                        break;
                    }
                    currentLineIndex++;
                }
            }
            return line;
        }

        /// <summary>
        /// метод которые получает список всех групп из АД
        /// </summary>
        public void GetGroups() // метод который получает из АД список всех групп
        {
            //string allGroups = string.Empty;
            using (_Variables.principalContext)
            {
                // Создаем объект для поиска групп
                PrincipalSearcher searcher = new PrincipalSearcher(_Variables.group);

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

            using (StreamWriter sw = new StreamWriter(path))
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
        /// <param name="language"></param>
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
