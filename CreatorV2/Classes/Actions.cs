﻿using System;
using System.Net.Mail;
using System.Net;
using System.DirectoryServices.AccountManagement;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CreatorV2.Classes
{
    [DirectoryObjectClass("user")] // Set the object class for user accounts
    [DirectoryRdnPrefix("CN")] // Set the RDN prefix (Common Name)
    public class UserPrincipalEx : UserPrincipal
    {
        public UserPrincipalEx(PrincipalContext context) : base(context) { }

        public UserPrincipalEx(PrincipalContext context, string samAccountName, string password, bool enabled) :
            base(context, samAccountName, password, enabled)
        { }

        // Add a method to set extensionAttribute1
        public void SetExtensionAttribute(string? valueLastName, string? valueName, string? valueMiddleName, string? valueISUID)
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

            for (int i = 0; i < countLineInFile; i++)
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

            _Variables._PasswordForSendEmail = LoadSettings2("AdminPassword") == string.Empty ? string.Empty : Decrypt(LoadSettings2("AdminPassword"));

            _Variables.NetBios = LoadSettings2("netbios");
            _Variables._PasswordInAD = LoadSettings2("DefPasswordUser");
            _Variables.OU = LoadSettings2("OU");

            LoadText("RUS");
            LoadText("ENG");

            //string listgroupforEmpliyees = LoadSetting(4)
            string[] lineEmployeer = LoadSettings2("ListGroupForEmplyees").Split(";");
            foreach (string line2 in lineEmployeer)
            {
                if (!string.IsNullOrEmpty(line2))
                {
                    _Variables._ListGroupForAddEmployeer.Add(line2);
                }
            }

            string[] lineStudent = LoadSettings2("ListGroupForStudent").Split(";");
            foreach (string line2 in lineStudent)
            {
                if (!string.IsNullOrEmpty(line2))
                {
                    _Variables._ListGroupForAddStudent.Add(line2);
                }
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

            if (File.Exists(filePath))
            {
                var settings = File
                    .ReadLines(filePath)
                    .Select(line => line.Split('|'))
                    .Where(parts => parts.Length == 2)
                    .ToDictionary(parts => parts[0].Trim(), parts => parts[1].Trim());

                if (settings.TryGetValue(WhatNeed, out var value))
                {
                    return value;
                }
            }
            return string.Empty;
        }


        /// <summary>
        /// метод которые получает список всех групп из АД
        /// </summary>
        public void GetGroups() // метод который получает из АД список всех групп
        {
            string allGroups = string.Empty;
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, _Variables.NetBios))
            {
                // Создаем объект группы
                GroupPrincipal group = new GroupPrincipal(principalContext);

                // Создаем объект для поиска групп
                PrincipalSearcher searcher = new PrincipalSearcher(group);

                // Получаем коллекцию найденных групп
                PrincipalSearchResult<Principal> groups = searcher.FindAll();

                // Проходимся по каждой группе и выводим ее имя
                foreach (Principal result in groups)
                {
                    allGroups = result.Name;
                    _Variables.ListAllGroups.Add(allGroups);
                }
            }
        }

        /// <summary>
        /// метод получает список групп пользователя 
        /// </summary>
        /// <param name="userName">имя пользователя список групп которого нужно получить </param>
        public ListBox GetListGroupUsers(string username)
        {
            ListBox listgroup = new ListBox();
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            username = GetSamAccountNameByDisplayName(username);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                {
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);

                    if (user != null)
                    {
                        // Получение объекта DirectoryEntry для пользователя
                        DirectoryEntry directoryEntry = (DirectoryEntry)user.GetUnderlyingObject();

                        // Получение списка групп пользователя
                        foreach (object group in directoryEntry.Properties["memberOf"])
                        {
                            string groupName = new DirectoryEntry($"LDAP://{group}").Name;
                            listgroup.Items.Add(groupName);
                            //Console.WriteLine(groupName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден в Active Directory.");
                        //Console.WriteLine("Пользователь не найден в Active Directory.");
                    }
                }
                return listgroup;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
                //Console.WriteLine($"Произошла ошибка: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// метод для удаления пользователя из группы
        /// </summary>
        /// <param name="username"></param>
        /// <param name="groupName"></param>
        public void RemoveUserFroumGroup(string username, string groupName)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                {
                    username = GetSamAccountNameByDisplayName(username);
                    // Получаем пользователя и группу по их именам
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, username);
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupName);

                    if (user != null && group != null)
                    {
                        // Проверяем, является ли пользователь членом группы перед удалением
                        if (group.Members.Contains(user))
                        {
                            group.Members.Remove(user);
                            group.Save();
                            _Variables.Log.Add($"Пользователь {username} успешно удален из группы {groupName}.");
                        }
                        else
                        {
                            MessageBox.Show($"Пользователь {username} не является членом этой группы.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь или группа не найдены.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }


        /// <summary>
        /// Метод служит для переноса пользователя в другую OU 
        /// </summary>
        /// <param name="username">Имя пользователя который будет перенесен в другой OU</param>
        /// <param name="targetOU">OU в которую будет перенесен пользователь </param>
        public void MoveUsersToOU(string username, string oldOU, string targetOU)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            // Создаем объект контекста PrincipalContext для подключения к Active Directory
            // Указываем путь к целевой OU
            string targetPath = $"LDAP://OU={targetOU},{_Variables.splitNetBios}";

            // Создаем объект контекста PrincipalContext для подключения к Active Directory
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={oldOU}, {_Variables.splitNetBios}"))
            {
                //username = GetSamAccountNameByDisplayName(username);
                // Находим пользователя по его имени
                UserPrincipal user = UserPrincipal.FindByIdentity(context, username);

                if (user != null)
                {
                    try
                    {
                        // Создаем объект DirectoryEntry для пользователя
                        using (DirectoryEntry entry = (DirectoryEntry)user.GetUnderlyingObject())
                        {
                            // Перемещаем пользователя в новую OU
                            entry.MoveTo(new DirectoryEntry(targetPath));
                            entry.CommitChanges();
                            _Variables.Log.Add($"Пользователь {username} успешно перемещен в OU= {targetOU}.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден.");
                }
            }
        }



        /// <summary>
        /// Метод который получает SamAccountName
        /// </summary>
        /// <param name="displayName"></param>
        /// <returns></returns>
        public string GetSamAccountNameByDisplayName(string displayName)
        {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal userPrincipal = new UserPrincipal(context);
                userPrincipal.DisplayName = displayName;

                PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal);
                UserPrincipal foundUser = searcher.FindOne() as UserPrincipal;

                if (foundUser != null)
                {
                    DirectoryEntry directoryEntry = foundUser.GetUnderlyingObject() as DirectoryEntry;
                    if (directoryEntry != null)
                    {
                        // Получить значение samaccountname
                        return directoryEntry.Properties["samaccountname"].Value.ToString();
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// метод для создания временной группы для доступа в группу
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="targetGroupName"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public string CreateTempGroup(string userName, string targetGroupName, DateTime endDate)
        {
            userName = GetSamAccountNameByDisplayName(userName);
            string entryTTL = getTime(endDate).ToString();
            string groupCommonName = $"temp_access_{userName}_{targetGroupName}";

            string ldapPath = "LDAP://OU=Technical accounts,DC=metalab,DC=ifmo,DC=ru";
            string newGroupName = "temp_access_" + userName + "_" + targetGroupName;
            string newGroupPath = "CN=" + newGroupName + ",OU=Technical accounts,DC=metalab,DC=ifmo,DC=ru";

            using (DirectoryEntry ouEntry = new DirectoryEntry(ldapPath))
            {
                using (DirectoryEntry group = ouEntry.Children.Add("CN=" + newGroupName, "group"))
                {
                    group.Properties["objectClass"].Value = new string[] { "dynamicObject", "group" };
                    group.Properties["entryTTL"].Value = entryTTL;
                    group.CommitChanges();

                    // Получение пользователя из OU Accounts
                    using (DirectoryEntry accounts = new DirectoryEntry("LDAP://OU=Accounts,DC=metalab,DC=ifmo,DC=ru"))
                    {

                        DirectorySearcher searcher = new DirectorySearcher(accounts);
                        searcher.Filter = "(sAMAccountName=" + userName + ")";
                        SearchResult result = searcher.FindOne();

                        if (result != null)
                        {
                            DirectoryEntry userEntry = result.GetDirectoryEntry();

                            // Добавление пользователя в новую группу
                            group.Invoke("Add", new object[] { userEntry.Path });
                            group.CommitChanges();
                        }
                    }

                    // Add new group to target group
                    string targetGroupPath = "CN=" + targetGroupName + ",OU=Accounts,DC=metalab,DC=ifmo,DC=ru";
                    AddMemberToGroup(newGroupPath, targetGroupPath);
                }
            }
            _Variables.Log.Add($"Временная группа для пользователя {userName} создана. Группа {newGroupName} ");
            return "done";
        }

        public int getTime(DateTime futTime)
        {
            DateTime currentTime = DateTime.Now;
            DateTime date1 = futTime;
            DateTime date2 = DateTime.Now;

            TimeSpan difference = date1 - date2;
            int secondsDifference = (int)difference.TotalSeconds;

            string qwe = "Разница в секундах: " + secondsDifference;
            string asd = qwe;
            return secondsDifference;
        }
        static void AddMemberToGroup(string memberDn, string groupDn)//добавление пользоватлея в группу 
        {
            using (DirectoryEntry group = new DirectoryEntry("LDAP://" + groupDn))
            {
                group.Properties["member"].Add(memberDn);
                group.CommitChanges();
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
        /// метод для блокировки пользователя методом установки истечения 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="expirateDate"></param>
        public void SetExpirateDate(string userName, string expirateDate)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                {
                    userName = GetSamAccountNameByDisplayName(userName);
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, userName);

                    if (user != null)
                    {
                        // Задаем дату истечения срока действия учетной записи
                        user.AccountExpirationDate = Convert.ToDateTime(expirateDate);
                        user.Save();
                        string Log = $"Пользователь {userName} будет заблокирован {expirateDate}";

                        _Variables.Log.Add(Log);
                        //MessageBox.Show(Log);
                    }
                    else
                    {
                        _Variables.Log.Add($"Пользователь {userName} не найден");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }


        /// <summary>
        /// метод предназначенный для создания группы
        /// </summary>
        /// <param name="groupName">принимает нахвание группы</param>
        /// <param name="description">принимает описание группы</param>
        public void CreateGroup(string groupName, string description)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                {
                    // Create a new group principal object
                    GroupPrincipal group = new GroupPrincipal(context, groupName);

                    // Set group properties (optional)
                    group.Description = string.IsNullOrEmpty(description) ? null : description;

                    // Save the group to Active Directory
                    group.Save();

                    _Variables.Log.Add($"Создана группа {groupName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }


        /// <summary>
        /// метод предназначен для удаления группы
        /// </summary>
        /// <param name="groupName">название группы для удаления </param>
        public void DeleteGroup(string groupName)
        {
            StringBuilder rootPath = new StringBuilder();
            foreach (string net in _Variables.NetBios.Split('.'))
            {
                rootPath.Append($"DC={net}, ");
            }

            // Remove the trailing comma and space
            rootPath.Remove(rootPath.Length - 2, 2);

            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {rootPath}"))
                {
                    // Search for the group
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupName);

                    if (group != null)
                    {
                        // Delete the group
                        group.Delete();
                        _Variables.Log.Add($"Группа {groupName} удалена.");
                    }
                    else
                    {
                        MessageBox.Show("Group not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex}");
            }
        }


        public List<string> GetUserInformationAD(string username)
        {
            List<string> attributesList = new List<string> ();
            
            StringBuilder rootPath = new StringBuilder();
            foreach (string net in _Variables.NetBios.Split('.'))
            {
                rootPath.Append($"DC={net}, ");
            }

            // Remove the trailing comma and space
            rootPath.Remove(rootPath.Length - 2, 2);

            // Specify the username of the user you want to retrieve information for
            username = GetSamAccountNameByDisplayName(username);

            // Specify the domain name
            string domain = "metalab.ifmo.ru";

            try
            {
                // Create a DirectoryEntry object to connect to the Active Directory
                using (DirectoryEntry entry = new DirectoryEntry($"LDAP://{domain}"))
                {
                    // Create a DirectorySearcher object to search for the user
                    using (DirectorySearcher searcher = new DirectorySearcher(entry))
                    {
                        // Set the filter to search for the specified username
                        searcher.Filter = $"(&(objectClass=user)(samAccountName={username}))";

                        // Perform the search
                        SearchResult result = searcher.FindOne();

                        if (result != null)
                        {
                            // Get the DirectoryEntry object for the user
                            DirectoryEntry userEntry = result.GetDirectoryEntry();

                            // Output all attributes of the user
                            foreach (string attributeName in userEntry.Properties.PropertyNames)
                            {
                                attributesList.Add($"{attributeName} - {userEntry.Properties[attributeName].Value}");
                                //Console.WriteLine($"{attributeName}: {userEntry.Properties[attributeName].Value}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                            //Console.WriteLine("User not found.");
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                //Console.WriteLine($"Error: {ex.Message}");
                //return attributesList;
            }
            return attributesList;


        }




        /// <summary>
        /// Метод предназначени для проверки существования группы 
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public bool DoesADGroupExist(string groupName)
        {
            StringBuilder rootPath = new StringBuilder();
            foreach (string net in _Variables.NetBios.Split('.'))
            {
                rootPath.Append($"DC={net}, ");
            }

            // Remove the trailing comma and space
            rootPath.Remove(rootPath.Length - 2, 2);

            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {rootPath}"))
                {
                    // Search for group by name using a GroupPrincipal with null name
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupName);

                    // If found, group object will have a value
                    return group != null;
                }
            }
            catch (Exception ex)
            {
                // Expected exception if group doesn't exist
                return false;
            }
        }



        /// <summary>
        /// метод выгружает пользователей из группы
        /// </summary>
        /// <param name="groupName">получает имя группы</param>
        /// <returns></returns>
        public List<string> showUsersInGroup(string groupName)
        {
            List<string> result = new List<string>();
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                {
                    // Получаем группу по ее имени
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(context, groupName);

                    if (group != null)
                    {
                        // Получаем список пользователей в группе
                        PrincipalSearchResult<Principal> members = group.GetMembers();

                        foreach (Principal member in members)
                        {
                            // Проверяем, является ли член группы пользователем
                            if (member is UserPrincipal user)
                            {
                                if (user.EmailAddress == null)
                                {
                                    continue;
                                }
                                else result.Add($"{user.DisplayName} ({user.EmailAddress})"); //вывод электронных почт 
                            }
                        }
                        return result;
                    }
                    else
                    {
                        result.Add("Группа не найдена или пуста.");
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Add("Произошла ошибка: " + ex.Message);
                return result;
            }
        }

        /// <summary>
        /// заблокировать\разблокировать учетную запись пользователя 
        /// </summary>
        /// <param name="username">передать имя пользователя (dysplayName)</param>
        /// <param name="LockUnlock">Передать значение, lock - заюлокировал, unlock - разблокирован </param>
        public void LockUnlockUser(string username, string LockUnlock)
        {
            //string username = "ИмяПользователя"; // Замените на имя пользователя, учетную запись которого вы хотите разблокировать
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            username = GetSamAccountNameByDisplayName(username);
            try
            {
                PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}");

                UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(context, username);

                if (LockUnlock == "unlock")
                {
                    userPrincipal.Enabled = true;
                    _Variables.Log.Add($"Учетная запись пользователя {username} успешно разблокирована.");
                    userPrincipal.Save();
                }
                else
                {
                    userPrincipal.Enabled = false;
                    _Variables.Log.Add($"Учетная запись пользователя {username} успешно заблокирована.");
                    userPrincipal.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
                _Variables.Log.Add("Произошла ошибка: " + ex.Message);
            }
        }

        /// <summary>
        /// метод для проверки заблокирован пользователь или нет. возвращает true - если пользователь активен, и false - если учетная запись заблокирована.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool checkLockOrUnLockUser(string username)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            username = GetSamAccountNameByDisplayName(username);
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                {
                    // Получаем пользователя по его имени
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, username);

                    if (user != null)
                    {
                        string displayName = user.DisplayName;

                        if ((bool)user.Enabled)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// метод проверяет, создана ли учетная запись или нет
        /// </summary>
        /// <returns></returns>
        public bool CheckCreateUser()
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);

            PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}");
            bool userExists = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, $"{_Variables._SamAccountInAD.ToLower()}") != null;
            if (userExists)
            {
                return true;
            }
            else return false;
        }


        /// <summary>
        /// метод проверяет, создана ли учетная запись или нет
        /// </summary>
        /// <returns></returns>
        public bool CheckCreateUser(string _SamAccountInAD)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);

            PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}");
            bool userExists = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, $"{_SamAccountInAD.ToLower()}") != null;
            if (userExists)
            {
                return true;
            }
            else return false;
        }







        /// <summary>
        /// метод для отправки писем на электронный почту
        /// </summary>
        public void SendMessage(string textMessage, string subject)//метод по отрпавке письма на личную почту пользователя
        {
            var fromAddress = new MailAddress(_Variables._EmailForSendEmail, _Variables._FIOForSendEmail);
            var toAddress = new MailAddress(_Variables._UsersEmail, $"{_Variables._nameInAD} {_Variables._lastNameInAD}");

            string fromAppPassword = _Variables._PasswordForSendEmail;




            var smtpClient = new SmtpClient
            {
                Host = "smtp.mail.ru",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromAppPassword)
            };


            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = textMessage
            })
            {
                smtpClient.Send(message);
                message.Headers.Add("Disposition-Notification-To", fromAddress.Address);
            }
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
        /// <param name="name">Эта переменная получает имя на русском Языке а возвращает уже на английском</param>
        /// <returns></returns>
        public string Transliteration(string name)
        {
            StringBuilder newName = new StringBuilder();
            foreach (char c in name.ToLower())
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
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                //using (PrincipalContext context = new PrincipalContext(ContextType.Domain, "metalab.ifmo.ru", "OU=Accounts,DC=metalab,DC=ifmo,DC=ru"))
                {
                    UserPrincipalEx up = new UserPrincipalEx(context);
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

        public void AddUserToDefGroups()
        {
            switch (_Variables._TypePost)
            {
                case "Сотрудник":
                    foreach (var item in _Variables._ListGroupForAddEmployeer)
                    {
                        AddUserToGroup(_Variables._SamAccountInAD, item);
                    }
                    break;

                case "Студент":
                    foreach (var item in _Variables._ListGroupForAddStudent)
                    {
                        AddUserToGroup(_Variables._SamAccountInAD, item);
                    }
                    break;

                case "Произвольный":
                    foreach (var item in _Variables._ListGroupForAddArbitrary)
                    {
                        AddUserToGroup(_Variables._SamAccountInAD, item);
                    }
                    break;

                case "СУЗсПФ":
                    foreach (var item in _Variables._ListGroupForAddSUZsPF)
                    {
                        AddUserToGroup(_Variables._SamAccountInAD, item);
                    }
                    break;
            }

        }


        /// <summary>
        /// метод для выгрузки в списка групп или пользователей в comboBox
        /// </summary>
        /// <param name="comboBox"> передаем объект combobox</param>
        /// <param name="getDataAction"> передает метод для получения всех пользоватлелей или групп</param>
        /// <param name="dataSource"></param>
        public ComboBox ConfigureComboBox(ComboBox comboBox, Action getDataAction, IEnumerable<string> dataSource)
        {
            getDataAction();
            string[] items = dataSource.ToArray();
            Array.Sort(items);
            comboBox.Items.AddRange(items);

            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(items);
            comboBox.AutoCompleteCustomSource = autoCompleteCollection;

            return comboBox;
        }





        /// <summary>
        /// метод для добавления пользователя в группу
        /// </summary>
        /// <param name="username">получаем имя пользователя</param>
        /// <param name="choosedGroup">получает группу в которую будет добавлен пользователь</param>
        public void AddUserToGroup(string username, string choosedGroup)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            //username = GetSamAccountNameByDisplayName(username);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                {
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);
                    GroupPrincipal group = GroupPrincipal.FindByIdentity(context, IdentityType.SamAccountName, choosedGroup);

                    if (user != null && group != null)
                    {
                        if (!group.Members.Contains(user))
                        {
                            group.Members.Add(user);
                            group.Save();
                            _Variables.Log.Add($"Пользователь {username} добавлен в группу {choosedGroup}.");
                            //MessageBox.Show($"Пользователь {username} добавлен в группу {choosedGroup}.");
                        }
                        else
                        {
                            _Variables.Log.Add($"Пользователь {username} уже состоит в группе {choosedGroup}.");
                            //MessageBox.Show($"Пользователь {username} уже состоит в группе {choosedGroup}.");
                            //Console.WriteLine($"Пользователь {data.NameUser + "." + data.SurnameUser} уже состоит в группе {item}.");
                        }
                    }
                    else
                    {
                        _Variables.Log.Add($"Пользователь {username} или группа {choosedGroup} не найдены.");
                        //MessageBox.Show($"Пользователь {username}  или группа  {choosedGroup} не найдены.");
                        //Console.WriteLine($"Пользователь {data.NameUser + "." + data.SurnameUser} или группа {item} не найдены.");
                    }
                }
            }
            catch (Exception ex)
            {
                _Variables.Log.Add("Ошибка во время добавления пользователя в группу.\n" + ex.ToString());
            }
        }


        /// <summary>
        /// метод который получает из АД список всех пользоватлелей 
        /// </summary>
        public void GetAllUser()
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                //"metalab.ifmo.ru", "OU=Accounts,DC=metalab,DC=ifmo,DC=ru"))
                {
                    UserPrincipal userPrincipal = new UserPrincipal(context);
                    using (PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal))
                    {
                        foreach (Principal result in searcher.FindAll())
                        {
                            // Получение свойства "SamAccountName" (логина пользователя)
                            //string username = result.SamAccountName;
                            string username = result.DisplayName == null ? result.SamAccountName : result.DisplayName;
                            _Variables.AllUsersInAD.Add(username);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка пользователей: " + ex.Message);
            }
        }

        public void GetAllUser(string ou)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = _ = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={ou}, {_Variables.splitNetBios}"))
                //"metalab.ifmo.ru", "OU=Accounts,DC=metalab,DC=ifmo,DC=ru"))
                {
                    UserPrincipal userPrincipal = new UserPrincipal(context);
                    using (PrincipalSearcher searcher = new PrincipalSearcher(userPrincipal))
                    {
                        foreach (Principal result in searcher.FindAll())
                        {
                            // Получение свойства "SamAccountName" (логина пользователя)
                            //string username = result.SamAccountName;
                            string username = result.DisplayName == null ? result.SamAccountName : result.DisplayName;
                            _Variables.AllUsersInAD.Add(username);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка пользователей: " + ex.Message);
            }
        }



        /// <summary>
        /// метод для смены пароля пользователя
        /// </summary>
        /// <param name="username">получает имя пользователя которому нужно поменять пароль</param>
        /// <param name="newPassword">новый пароль</param>
        public void ChangePasswordUser(string username, string newPassword)
        {
            string rootPath = string.Empty;
            string[] splitNetBios = _Variables.NetBios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net}, ";
            }
            _Variables.splitNetBios = rootPath = rootPath.Remove(rootPath.Length - 2);
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain, _Variables.NetBios, $"OU={_Variables.OU}, {_Variables.splitNetBios}"))
                {
                    username = GetSamAccountNameByDisplayName(username);
                    UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);

                    if (user != null)
                    {
                        // Изменение пароля
                        user.SetPassword(newPassword);
                        user.Save();
                        _Variables.Log.Add($"Пароль пользователя {username} успешно изменен.");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден в Active Directory.");
                    }
                }
            }
            catch (Exception ex)
            {
                _Variables.Log.Add($"Произошла ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// метод для вывода всех OU из AD 
        /// </summary>
        /// <param name="netbios"></param>
        /// <returns></returns>
        public List<string> ListOU(string netbios)  //List<string>
        {
            List<string> listou = new List<string>();
            // Установите путь к корневому OU вашего домена
            string rootPath = "LDAP://";
            string[] splitNetBios = netbios.Split(".");
            foreach (string net in splitNetBios)
            {
                rootPath += $"DC={net},";
            }
            _Variables.splitNetBios = rootPath = rootPath.Remove(rootPath.Length - 1);

            // Установите путь к корневому OU вашего домена
            //string rootPath = "LDAP://DC=example,DC=com";

            // Создайте объект DirectoryEntry с указанием пути к корневому OU
            using (DirectoryEntry entry = new DirectoryEntry(rootPath))
            {
                // Создайте объект DirectorySearcher для поиска OU
                using (DirectorySearcher searcher = new DirectorySearcher(entry))
                {
                    // Установите фильтр для поиска объектов OU
                    searcher.Filter = "(objectClass=organizationalUnit)";

                    // Выполните поиск
                    SearchResultCollection results = searcher.FindAll();

                    // Выведите информацию о каждом найденном OU
                    foreach (SearchResult result in results)
                    {
                        DirectoryEntry directoryEntry = result.GetDirectoryEntry();
                        listou.Add(directoryEntry.Name.Replace("OU=", ""));
                        // Console.WriteLine("OU Name: " + directoryEntry.Name);
                    }
                }
            }
            _Variables._ListOU = listou;
            return listou;
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
            try
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
            catch (Exception ex)
            {
                _Variables.Log.Add($"Ошибка {ex}");
                return string.Empty;
            }
        }
    }
}
