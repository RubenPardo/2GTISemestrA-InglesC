using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            string password = txtPassword.Text;

            if (password.Equals("12345")){
                Form2 secondaryWindow = new Form2();
                this.Hide();
                secondaryWindow.ShowDialog();
                this.Close();
            }
            else if(password.Length == 0){
                MessageBox.Show("Please, insert a password");
            }
            else
            {
                count++;
                int attempts = 3 - count;
                if (attempts == 0)
                {
                    MessageBox.Show("You are not authorized to enter the application. ");
                    this.Close();
                }
                MessageBox.Show("The password is not correct.\n" + attempts.ToString() + " attempts.");
            }
        }
    }
}
