using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace PardoCasanova_BenitezEstruch
{
    public partial class Form3 : Form
    {

        private readonly string productsFileName = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\data\products.json";
        ProductList productList;
        String jsonPlainContent;
        public Form3()
        {
            InitializeComponent();
            jsonPlainContent = Utility.readFile(productsFileName);
            productList = JsonConvert.DeserializeObject<ProductList>(jsonPlainContent);
        }

        

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioCSV.Checked)
                {
                    saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 1;
                    saveFileDialog1.AddExtension = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        
                        string text = saveFileDialog1.FileName;
                        StreamWriter saveText = File.CreateText(text);
                        saveText.Write(richTextBox1.Text);
                        saveText.Close();
                        this.Close();
                        
                    }
                }
                else if(radioXML.Checked)
                {
                    saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 1;
                    saveFileDialog1.AddExtension = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {

                        string text = saveFileDialog1.FileName;
                        StreamWriter saveText = File.CreateText(text);
                        saveText.Write(richTextBox1.Text);
                        saveText.Close();
                        this.Close();

                    }
                }
                else
                {
                    Utility.showDialogWarning("Select a file format", "Please, select the format to export.");
                }


            }
            catch (Exception)
            {
                Utility.showDialogError("Impossible to export", "An error has occured.");
            }

        }



        private void radioButtonToXML(object sender, EventArgs e)
        {
            XNode node = JsonConvert.DeserializeXNode(jsonPlainContent, "products");
            StringBuilder write = new StringBuilder();
            write.Append(node);
            richTextBox1.Text = write.ToString();
        }



        private void radioButtonToCSV(object sender, EventArgs e)
        {
            StringBuilder write = new StringBuilder();
            foreach (Product product in productList.product)
            {
                write.AppendLine("Id: " + product.ID);
                write.AppendLine("Name: " + product.NAME);
                write.AppendLine("Manufacturer: " + product.MANUFACTURER);
                write.AppendLine("Description: " + product.DESCRIPTION);
                write.AppendLine("Stock: " + product.STOCK);
                write.AppendLine("Price (€): " + product.PRICE);
                write.AppendLine();
            }

            richTextBox1.Text = write.ToString();
        }


        private void btnCancelExport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
