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
        String userType;
        static List<User> logins = new List<User>();
        static string path = @"LoginDetails.txt";

       public string Username { get => username; set => username = value; }
       public string Password { get => password; set => password = value; }

       public string FirstName { get => firstName; set => firstName = value; }

       public string SecondName { get => secondName; set => secondName = value; }
       public string UserType {get => userType; set => userType = value;  }
       

        public User(string username, string password,string firstName,string secondName,String userType) {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.secondName = secondName;
            this.userType = userType;
        }


        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
           
            
        }
        public static int getSizeOfFile() {

            return logins.Count;
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


        public static void saveLogins() {
            StreamWriter writer = new StreamWriter(path);

            foreach (User user in logins) {
 
               
                writer.WriteLine("{0},{1},{2},{3},{4}", user.Username, user.Password, user.FirstName, user.SecondName, user.UserType);
            }
            writer.Close();
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

                    logins.Add(new User(split[0], split[1],split[2],split[3],split[4]));



                }


                reader.Close();
            }
            else
            {
                MessageBox.Show("Text file containting logins not found, creating new text file");
                StreamWriter writer = new StreamWriter(path);
                writer.Close();
            }
           
        }
       public bool checkLogin(User userLogin, out User userFound ) {
            bool flag = false;
            userFound = null;
            foreach (User  login in logins)
            {
                if (userLogin.Username.Equals(login.Username) && userLogin.Password.Equals(login.Password))
                {
                    flag = true;
                    userFound = login;
                   
                }
            }

            return flag;
        }

    }
}
