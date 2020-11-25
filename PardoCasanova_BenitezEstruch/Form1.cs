using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PardoCasanova_BenitezEstruch
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {


          

            string password = txtPassword.Text;
            string user = txtUser.Text;

            Match matchUser = Regex.Match(user, @"\b\w*@micros.com\b");

            if (password.Equals("123") && matchUser.Success)
            {
                Form2 secondaryWindow = new Form2();
                this.Hide();
                secondaryWindow.ShowDialog();
                this.Close();
            }
            else if(password.Length == 0 || user.Length == 0)
            {
                Utility.showDialogWarning("Empty fields.", "Please, insert an username and a password.");
            }
            else
            {
                count++;
                int attempts = 3 - count;
                if (attempts == 0)
                {
                    Utility.showDialogError("Login Error", "You exceeded the maximum login tries.");
                    this.Close();
                }
                Utility.showDialogError("Error log in","The credentials are not correct.\n" + attempts.ToString() + " attempts.");
            }
        }
    }
}
