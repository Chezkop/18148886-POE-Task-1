using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _18148886_POE_Task_1
{
    class User
    {
        String username;
        String password;
        String firstName;
        String secondName;
        static List<User> logins = new List<User>();
        static string path = @"LoginDetails.txt";

       public string Username { get => username; set => username = value; }
       public string Password { get => password; set => password = value; }

       public string FirstName { get => firstName; set => firstName = value; }

       public string SecondName { get => secondName; set => secondName = value; }

        public User(string username, string password,string firstName,string secondName) {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.secondName = secondName;
        }


        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
           
            
        }

        public static void addUserToFile(User user) {
            logins.Add(user);


        }

        public static User getUserFromFile(int index) {

            return logins[index];
        }

        public static void deleteUserFromFile(User user) {

            logins.Remove(user);
        }

        

        public static void importLoginDetails() {
            
            string line;


            if (File.Exists(path))
            {

                StreamReader reader = new StreamReader(path);
                while (reader.Peek() >= 0)
                {
                    line = reader.ReadLine();
                    String[] split = line.Split(',');

                    logins.Add(new User(split[0], split[1],split[2],split[3]));



                }



            }
            else
            {
                MessageBox.Show("Text file containting logins not found, creating new text file");
                StreamWriter writer = new StreamWriter(path);

            }
        }
       public bool checkLogin(User userLogin) {
            bool flag = false;
            foreach (User  login in logins)
            {
                if (userLogin.Username.Equals(login.Username) && userLogin.Password.Equals(login.Password))
                {
                    flag = true;
                   
                }
            }

            return flag;
        }

    }
}
