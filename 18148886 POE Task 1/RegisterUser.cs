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
    public partial class RegisterUser : Form
    {

        public string FirstName { get => txtFirstName.Text; set => txtFirstName.Text = value; }
        public string SecondName { get => txtSecondName.Text; set => txtSecondName.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }

        public bool Student { get => rdoStudent.Checked; set => rdoStudent.Checked = value; }
        public bool Lecturer { get => rdoLecturer.Checked; set => rdoLecturer.Checked = value; }

        public RegisterUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            rdoLecturer.Checked = false;
            rdoStudent.Checked = false;
            txtFirstName.Text = "";
            txtPassword.Text = "";
            txtSecondName.Text = "";
            Close();
        }
    }
}
