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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDiscount.Text.Length == 0)
                {
                    Utility.showDialogError("Discount field is empty.", "Please, put a percentage to discount.");
                }
                else
                {
                    double discount = Convert.ToDouble(txtDiscount.Text);
                    if(discount> 100 || discount < 0)
                    {
                        Utility.showDialogError("Discount range is over", "The range of the discount must be greater than 0 and less than 100.");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Do you want to apply the discount?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            Form2 main = (Form2)this.Owner;
                            this.Hide();
                            main.discount(discount);
                            this.Close(); 
                        }
                            
                    }
                }
            }
            catch (Exception)
            {
                Utility.showDialogError("Error", "Error.");
            }
        }
    }
}
