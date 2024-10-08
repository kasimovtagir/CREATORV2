﻿namespace CreatorV2.Classes
{
    public class Variables
    {
        // настройки учетной записи для отправки писем на электронную почту
        private string? FIOForSendEMail;
        public string? _FIOForSendEmail
        {
            get { return FIOForSendEMail; }
            set { FIOForSendEMail = value; }
        }

        private string? EmailForSendEMail;
        public string? _EmailForSendEmail
        {
            get { return EmailForSendEMail; }
            set { EmailForSendEMail = value; }
        }

        private string? PasswordForSendEmail;
        public string? _PasswordForSendEmail
        {
            get { return PasswordForSendEmail; }
            set { PasswordForSendEmail = value; }
        }

        //поля для текста который будет отправлен пользователю 
        public string? SubjectTextMessageForSendEmail_RUS { get; set; }
        public string? TextMessageForSendEMAIL_RUS { get; set; }

        public string? SubjectTextMessageForSendEmail_ENG { get; set; }
        public string? TextMessageForSendEMAIL_ENG { get; set; }

        //переменные для списка групп в которые будет добавлен новый пользователь 
        private List<string>? ListGroupForAddEmployeer = new List<string>();
        public List<string>? _ListGroupForAddEmployeer
        {
            get { return ListGroupForAddEmployeer; }
            set { ListGroupForAddEmployeer = value; }
        }

        private List<string> ListGroupForAddStudent = new List<string>();
        public List<string> _ListGroupForAddStudent
        {
            get { return ListGroupForAddStudent; }
            set { ListGroupForAddStudent = value; }
        }

        private List<string>? ListGroupForAddSUZsPF = new List<string>();
        public List<string>? _ListGroupForAddSUZsPF
        {
            get { return ListGroupForAddSUZsPF; }
            set { ListGroupForAddSUZsPF = value; }
        }

        private List<string>? ListGroupForAddArbitrary = new List<string>();
        public List<string>? _ListGroupForAddArbitrary
        {
            get { return ListGroupForAddArbitrary; }
            set { ListGroupForAddArbitrary = value; }
        }



        //Список всех групп
        public List<string>? ListAllGroups = new();


        // поле для переменной netbios
        public string? NetBios;// { get; set; }
        public string? splitNetBios;
        public string? OU;
        public List<string>? _ListOU;

        //паля для подключения к АД
        public PrincipalContext? principalContext;
        public GroupPrincipal? group { get; set; }



        //паля для заполнения информации об новом сотруднике
        public string? _nameInAD { get; set; }
        public string? _lastNameInAD { get; set; }
        public string? _SamAccountInAD { get; set; }
        public string? _PasswordInAD { get; set; }

        public string? _UserlastName { get; set; }
        public string?  _UserName { get; set; }
        public string? _UserThistName { get; set; }
        public string? _UserISU_ID { get; set; }
        public string? _UserDescription { get; set; }
        public string? _UsersEmail { get; set; }
        public string? _TypePost { get; set; }

        public bool _WithEmail;


        public List<string>? Log = new();

        // Список всех пользователей в AD
        private List<string> listAllUsers = new List<string>();
        public List<string> AllUsersInAD //{ get; set; }
        {
            get { return listAllUsers; }
            set { listAllUsers = value; }
        }
    }
}
