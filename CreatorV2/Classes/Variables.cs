namespace CreatorV2.Classes
{
    public class Variables
    {
        // настройки учетной записи для отправки писем на электронную почту
        private string FIOForSendEMail;
        public string _FIOForSendEmail
        {
            get { return FIOForSendEMail; }
            set { FIOForSendEMail = value; }
        }
        
        private string EmailForSendEMail;
        public string _EmailForSendEmail
        {
            get { return EmailForSendEMail; }
            set { EmailForSendEMail = value; }
        }
        private string PasswordForSendEmail;
        public string _PasswordForSendEmail
        {
            get { return PasswordForSendEmail; }
            set { PasswordForSendEmail = value; }
        }

        //поля для текста который будет отправлен пользователю 
        public string SubjectTextMessageForSendEmail_RUS { get; set; }
        public string TextMessageForSendEMAIL_RUS { get;set; }

        public string SubjectTextMessageForSendEmail_ENG { get; set; }
        public string TextMessageForSendEMAIL_ENG { get; set; }
        


        // поле для переменной netbios
        public string NetBios { get; set; }

    }
}
