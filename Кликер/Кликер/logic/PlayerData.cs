using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Кликер
{
    internal class PlayerData
    {
        private const string FilePath = "E:\\учёба\\3 семестр\\ООП\\Кликер\\credentials.xml";
        private static List<UserData> userCredentials;
        private static string userNameWhenLogin;

        public PlayerData()
        {
            LoadUserCredentials();
        }
        //для работы с уникальным пользователем
        public void SaveUserNameWhenLogin(string userName)
        {
            userNameWhenLogin = userName;
        }
        public static string GetUserNameWhenLogin()
        {
            return userNameWhenLogin;
        }

        private void LoadUserCredentials()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    using (var stream = new StreamReader(FilePath))
                    {
                        var serializer = new XmlSerializer(typeof(List<UserData>));
                        userCredentials = (List<UserData>)serializer.Deserialize(stream);
                    }
                }
                else
                {
                    userCredentials = new List<UserData>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading user credentials: {ex.Message}");
            }
        }
        private void SaveUserCredentials()
        {
            try
            {
                using (var stream = new StreamWriter(FilePath))
                {
                    var serializer = new XmlSerializer(typeof(List<UserData>));
                    serializer.Serialize(stream, userCredentials);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving user credentials: {ex.Message}");
            }
        }
        public bool RegisterUser(string username, string password)
        {
            if (username != "" && password != "" && !UserExists(username))
            {
                var newUser = new UserData
                {
                    Username = username,
                    Password = password,
                    BoolAchievement1 = true,
                    BoolAchievement2 = false,
                    BoolAchievement3 = false,
                    BoolAchievement4 = false
                };

                userCredentials.Add(newUser);
                SaveUserCredentials();
                return true;
            }
            return false; // пользователь с таким именем уже существует
        }
        public bool AuthenticateUser(string username, string password)
        {
            var user = userCredentials.Find(u => u.Username == username);

            if (user != null && user.Password == password)
            {
                Console.WriteLine("Authentication successful.");
                return true;
            }
            else
            {
                Console.WriteLine("Authentication failed.. Incorrect username or password.");
                return false;
            }
        }
        public bool UserExists(string username)
        {
            return userCredentials.Exists(u => u.Username == username);
        }
        public static UserData GetCurrentUserData(string username)
        {
            return userCredentials.Find(u => u.Username == username);
        }
        public static void SwitchBoolProperty(string userName, int number)
        {       //обращаться к существующей записи в файле и менять там значение
            UserData user = GetCurrentUserData(userName);
            if (user != null)
            {
                if (number == 2)
                {
                    user.BoolAchievement2 = true;
                }
                else if (number == 3)
                {
                    user.BoolAchievement3 = true;
                }
                else if (number == 4)
                {
                    user.BoolAchievement4 = true;
                }
            }
        }

    }
}
