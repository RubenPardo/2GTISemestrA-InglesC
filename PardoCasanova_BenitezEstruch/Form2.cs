﻿using System;
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

        private bool isEdit = false;

        private ProductList productList;
        private readonly string productsFileName = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\data\products.json";

        public Form2()
        {
            InitializeComponent();
            enableDisableInfoGroupListBox(false);
            initListBox();


        }


        private void initListBox()
        {
            try
            {
                String jsonPlainContent = Utility.readFile(productsFileName);
                productList = JsonConvert.DeserializeObject<ProductList>(jsonPlainContent);

                foreach (Product product in productList.product)
                {
                    listBoxProducts.Items.Add(product); 

                }
            }
            catch (IOException)
            {
                Utility.showDialogError("Error when initializing", "Data to read was not found. The app are going to close");
                this.Close();
            }
            catch (ArgumentException error)
            {
                Utility.showDialogError("Error when initializing", "Some values from the data are invalids: " + error.Message);
                this.Close();
            }
            catch (Exception)
            {
                Utility.showDialogError("Error", "Unexpected error");
                this.Close();
            }


        }


        private void enableDisableInfoGroupListBox(bool enableInfoGroup)
        {
 
            labelInfoTitulo.Text = enableInfoGroup ? "Add new Product" : "Product Information";

            txtName.BackColor = enableInfoGroup ? SystemColors.Window : SystemColors.Control;
            txtName.BorderStyle = enableInfoGroup ? BorderStyle.Fixed3D : BorderStyle.None;
            txtName.ReadOnly = !enableInfoGroup;
            txtName.TabStop = enableInfoGroup;

            txtManufacturer.BackColor = enableInfoGroup ? SystemColors.Window : SystemColors.Control;
            txtManufacturer.BorderStyle = enableInfoGroup ? BorderStyle.Fixed3D : BorderStyle.None;
            txtManufacturer.ReadOnly = !enableInfoGroup;
            txtManufacturer.TabStop = enableInfoGroup;

            txtDescript.BackColor = enableInfoGroup ? SystemColors.Window : SystemColors.Control;
            txtDescript.BorderStyle = enableInfoGroup ? BorderStyle.Fixed3D : BorderStyle.None;
            txtDescript.ReadOnly = !enableInfoGroup;
            txtDescript.TabStop = enableInfoGroup;

            txtPrice.BackColor = enableInfoGroup ? SystemColors.Window : SystemColors.Control;
            txtPrice.BorderStyle = enableInfoGroup ? BorderStyle.Fixed3D : BorderStyle.None;
            txtPrice.ReadOnly = !enableInfoGroup;
            txtPrice.TabStop = enableInfoGroup;

            txtStock.BackColor = enableInfoGroup ? SystemColors.Window : SystemColors.Control;
            txtStock.BorderStyle = enableInfoGroup ? BorderStyle.Fixed3D : BorderStyle.None;
            txtStock.ReadOnly = !enableInfoGroup;
            txtStock.TabStop = enableInfoGroup;

            lblType.Visible = !enableInfoGroup;
            groupProductType.Visible = enableInfoGroup;

            btnSave.Visible = enableInfoGroup;
            btnCancel.Visible = enableInfoGroup;

            groupBoxListBox.Enabled = !enableInfoGroup;
            

        }


        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product item = (Product)listBoxProducts.SelectedItem;
            itemToInfoGroup(item);
        }


        private void itemToInfoGroup(Product item)
        {

            if (item != null)
            {
                groupBoxNoProductSelected.Visible = false;
                txtName.Text = item.NAME;
                txtManufacturer.Text = item.MANUFACTURER;
                txtDescript.Text = item.DESCRIPTION;
                txtPrice.Text = item.PRICE;
                txtStock.Text = item.STOCK;
                
                if (item.TYPE.Equals("MICRO"))
                {
                    lblType.Text = "Microprocessor";
                    radioMicrocontroller.Checked = true;
                    radioSensor.Checked = false;
                }
                else
                {
                    lblType.Text = "Sensor";
                    radioSensor.Checked = true;
                    radioMicrocontroller.Checked = false;
                }
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            isEdit = false;
            clearFormProduct();
            groupBoxNoProductSelected.Visible = false;
            enableDisableInfoGroupListBox(true);

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Product item = (Product)listBoxProducts.SelectedItem;
            if (item != null)
            {
                itemToInfoGroup(item);
            }
            else
            {
                clearFormProduct();
                groupBoxNoProductSelected.Visible = true;
            }
            enableDisableInfoGroupListBox(false);


        }     
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string manufacturer = txtManufacturer.Text;
            string desc = txtDescript.Text;
            string price = txtPrice.Text;
            string stock = txtStock.Text;

            RadioButton checkedButton = groupProductType.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                try
                {

                    Product product;

                    if (!isEdit)
                    {
                        product = new Product(name, checkedButton.Tag.ToString(), manufacturer, desc, price, stock);
                        saveNewProduct(product); 
                    }
                    else
                    {

                        product = (Product)listBoxProducts.SelectedItem;
                        productList.product.Remove((Product)listBoxProducts.SelectedItem);


                        product.STOCK = stock;
                        product.NAME = name;
                        product.DESCRIPTION = desc;
                        product.MANUFACTURER = manufacturer;
                        product.TYPE = checkedButton.Tag.ToString();
                        product.PRICE = price;

                        editProduct(product);

                        listBoxProducts.Items.Remove((Product)listBoxProducts.SelectedItem);


                    }

                    listBoxProducts.SelectedItem = product;

                    itemToInfoGroup(product);
                    enableDisableInfoGroupListBox(false);

                }
                catch (ArgumentException error)
                {
                    Utility.showDialogError("Error creating a product", error.Message);
                }
                catch (IOException error)
                {
                    Utility.showDialogError("Error creating a product", "Can not save the product because the json file does not exist");
                }

            }
            else
            {
                Utility.showDialogError("Error creating a product", "The product needs a type");
            }


        }

        private void saveNewProduct(Product product)
        {
            productList.product.Add(product);
            string jsonData = JsonConvert.SerializeObject(productList);
            File.WriteAllText(productsFileName, jsonData);
            listBoxProducts.Items.Add(product);
        }
     
        private void clearFormProduct()
        {
            txtName.Text = "";
            txtManufacturer.Text = "";
            txtDescript.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            lblType.Text = "";
            radioSensor.Checked = false;
            radioMicrocontroller.Checked = false;

            

        }



        private void editButton(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                isEdit = true;
                enableDisableInfoGroupListBox(true);
            }
            else
            {
                Utility.showDialogWarning("Warning", "You must select a product");
            }
        }
        private void editProduct(Product product)
        {

            productList.product.Add(product);

            string jsonData = JsonConvert.SerializeObject(productList);
            File.WriteAllText(productsFileName, jsonData);

            listBoxProducts.Items.Add(product);
        }


        private void removeButton(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Do you want to delete the file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Product item = (Product)listBoxProducts.SelectedItem;
               
                    removeProduct(item);
                }
            }
            else
            {
                Utility.showDialogWarning("Warning", "You must select a product");
            }
        }
        private void removeProduct(Product product)
        {
            productList.product.Remove(product);
            string jsonData = JsonConvert.SerializeObject(productList);
            File.WriteAllText(productsFileName, jsonData);
            listBoxProducts.Items.Remove(product);
            clearFormProduct();
            groupBoxNoProductSelected.Visible = true;
        }

 
        private void searchButton(object sender, EventArgs e)
        {
            string txtSerch = textBoxSearch.Text;
            txtSerch = txtSerch.ToLower();
            
            if (!Utility.isTextEmpty(txtSerch))
            {
                Product p = getProductByName(txtSerch);
                if (p != null)
                {
                    listBoxProducts.SelectedItem = p; 
                    itemToInfoGroup(p);
                }
                else
                {
                    Utility.showDialogWarning("No product found", "A product with that name does not exist");
                }
            }
            else { 
            
                Utility.showDialogWarning("No product found", "A name is needed to search a product");
            }
            
            
        }


        private Product getProductByName(string name)
        {
            Product pRes = null;
            foreach(Product p in productList.product)
            {
                if (p.NAME.ToLower().StartsWith(name.ToLower()))
                {
                    pRes = p;
                    break;
                }
            }
            return pRes;
        }



        private void applyDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 applyDiscount = new Form4();

            applyDiscount.ShowDialog(this);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 about = new Form5();

            about.ShowDialog(this);
        }

        private void exportProductsAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 exportFileWindows = new Form3();
            exportFileWindows.ShowDialog();

        }



        public void discount(double discount)
        {

            foreach (Product product in productList.product)
            {

                double price = Convert.ToDouble(product.PRICE);
                double discountValue = (price * discount) / 100;
                double finalPrice = price - discountValue;

                product.PRICE = finalPrice.ToString();
                listBoxProducts.Items.Remove(product);

            }
            clearFormProduct();
            string jsonData = JsonConvert.SerializeObject(productList);
            File.WriteAllText(productsFileName, jsonData);
            initListBox();
            groupBoxNoProductSelected.Visible = true;
        }


    }


}