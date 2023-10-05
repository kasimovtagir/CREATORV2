

using static System.Runtime.InteropServices.JavaScript.JSType;

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
        /// метод для сохранения текста для отправки письма на почту новому пользователю
        /// </summary>
        /// <param name="language">переменная принимает RUS или ENG</param>
        public void SavingTextForSendEmail(string language)
        {
            string path = string.Empty;
            if (language=="RUS")
            {
                path = @"textMessageRU.txt";
            }
            else if (language=="ENG")
            {
                path = @"textMessageENG.txt";
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                try
                {
                    if(language=="RUS")
                    {
                        sw.WriteLine(_Variables.SubjectTextMessageForSendEmail_RUS);
                        sw.WriteLine(_Variables.TextMessageForSendEMAIL_RUS);
                    }
                    else if (language=="ENG")
                    {
                        sw.WriteLine(_Variables.SubjectTextMessageForSendEmail_ENG);
                        sw.WriteLine(_Variables.TextMessageForSendEMAIL_ENG);
                    }
                }
                catch (Exception ex) { MessageBox.Show($"error {ex}"); }
            }
        }



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
                using (StreamReader sr = new StreamReader(path))
                {
                    if (language == "ENG")
                    {
                        _Variables.SubjectTextMessageForSendEmail_ENG = sr.ReadLine();
                        _Variables.TextMessageForSendEMAIL_ENG = sr.ReadToEnd();
                    }
                    else if(language =="RUS")
                    {
                        _Variables.SubjectTextMessageForSendEmail_RUS = sr.ReadLine();
                        _Variables.TextMessageForSendEMAIL_RUS = sr.ReadToEnd();
                    }
                    
                }
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
