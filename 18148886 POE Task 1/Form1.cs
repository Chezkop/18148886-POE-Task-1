using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18148886_POE_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            User.importLoginDetails();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            User userLogin = new User(txtUsername.Text, txtPassword.Text);
            if (userLogin.checkLogin(userLogin))
            {

                if (userLogin.Username.StartsWith("L"))
                {
                    TeacherForm teacher = new TeacherForm();
                    teacher.Show();
                    this.Hide();

                }
                else {
                    StudentForm student = new StudentForm();
                    student.Show();
                    this.Hide();
                }
                
            }
            else {
                MessageBox.Show("Incorrect Login Details");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser();
            register.ShowDialog();

            if (register.Lecturer || register.Student) {
                User newUser = new User(tx)
                
            }
            
        }
    }
}
