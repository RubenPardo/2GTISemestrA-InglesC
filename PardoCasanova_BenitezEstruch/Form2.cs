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
using Newtonsoft.Json;

namespace PardoCasanova_BenitezEstruch
{


    public partial class Form2 : Form
    {


        private ProductList productList;
        // El path directory name pilla la ruta del .exe que esta donde el directory data
        private readonly string productsFileName = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\data\products.json";

        public Form2()
        {
            InitializeComponent();
            enableInfoGroup(false);
            initListBox();


        }


        // carga del json los productos
        private void initListBox()
        {
            Console.WriteLine("path: " + productsFileName);
            try
            {
                String jsonPlainContent = readFile(productsFileName);
                productList = JsonConvert.DeserializeObject<ProductList>(jsonPlainContent);
                
                foreach (Product product in productList.products)
                {
                    listBoxProducts.Items.Add(product);
                   
                }
            }
            catch (IOException)
            {
               Utility.showDialogError("Error when initializing", "Data to read was not found. The app are going to close");
               this.Close();


            }
            catch(ArgumentException error)
            {
                Utility.showDialogError("Error when initializing", "Some values from the data are invalids: "+error.Message);
                this.Close();
            }
            catch (Exception)
            {
                Utility.showDialogError("Error", "Unexpected error");
                this.Close();
            }


        }
        // read the content from the file 
        private String readFile(String fileName)
        {
            String line;// used to read from the file
            StringBuilder sb = new StringBuilder();// where the text read it are going to be stored

            
            using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("utf-8")))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.AppendLine(line);
                    }
                }
            }

            
            
            return sb.ToString();
        }



        private void enableInfoGroup(bool enable)
        {
           
            txtName.BackColor = enable ? SystemColors.Window : SystemColors.Control;
            txtName.BorderStyle = enable ?  BorderStyle.Fixed3D : BorderStyle.None;
            txtName.ReadOnly = !enable;

            txtManufacturer.BackColor = enable ? SystemColors.Window : SystemColors.Control;
            txtManufacturer.BorderStyle = enable ? BorderStyle.Fixed3D : BorderStyle.None;
            txtManufacturer.ReadOnly = !enable;

            txtDescript.BackColor = enable ? SystemColors.Window : SystemColors.Control;
            txtDescript.BorderStyle = enable ? BorderStyle.Fixed3D : BorderStyle.None;
            txtDescript.ReadOnly = !enable;

            txtPrice.BackColor = enable ? SystemColors.Window : SystemColors.Control;
            txtPrice.BorderStyle = enable ? BorderStyle.Fixed3D : BorderStyle.None;
            txtPrice.ReadOnly = !enable;

            txtStock.BackColor = enable ? SystemColors.Window : SystemColors.Control;
            txtStock.BorderStyle = enable ? BorderStyle.Fixed3D : BorderStyle.None;
            txtStock.ReadOnly = !enable;

            groupTipoProducto.Enabled = enable;

        }


        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = (Product) listBoxProducts.SelectedItem;
            itemToInfoGroup(item);
        }
        private void itemToInfoGroup(Product item)
        {
            txtName.Text = item.NAME;
            txtManufacturer.Text = item.MANUFACTURER;
            txtDescript.Text = item.DESCRIPTION;
            txtPrice.Text = item.PRICE;
            txtStock.Text = item.STOCK;
            if (item.TYPE.Equals("MICRO"))
            {
                radioMicrocontroller.Checked = true;
                radioSensor.Checked = false;
            }
            else
            {
                radioSensor.Checked = true;
                radioMicrocontroller.Checked = false;
            }
        }

    }


}