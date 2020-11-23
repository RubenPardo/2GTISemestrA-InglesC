namespace PardoCasanova_BenitezEstruch
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.holaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProductsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtStock = new System.Windows.Forms.TextBox();
            this.radioSensor = new System.Windows.Forms.RadioButton();
            this.radioMicrocontroller = new System.Windows.Forms.RadioButton();
            this.groupProductType = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxListBox = new System.Windows.Forms.GroupBox();
            this.groupBoxNoProductSelected = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.groupProductType.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.groupBoxListBox.SuspendLayout();
            this.groupBoxNoProductSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 22;
            this.listBoxProducts.Location = new System.Drawing.Point(30, 113);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(331, 290);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem1,
            this.productsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(897, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // holaToolStripMenuItem1
            // 
            this.holaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportProductsAsToolStripMenuItem});
            this.holaToolStripMenuItem1.Name = "holaToolStripMenuItem1";
            this.holaToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.holaToolStripMenuItem1.Text = "File";
            // 
            // exportProductsAsToolStripMenuItem
            // 
            this.exportProductsAsToolStripMenuItem.Name = "exportProductsAsToolStripMenuItem";
            this.exportProductsAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportProductsAsToolStripMenuItem.Text = "Export products as...";
            this.exportProductsAsToolStripMenuItem.Click += new System.EventHandler(this.exportProductsAsToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product List";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.textBoxSearch.Location = new System.Drawing.Point(30, 65);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(233, 27);
            this.textBoxSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.button1.Location = new System.Drawing.Point(278, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Manufacturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price (€)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Stock";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Firebrick;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(331, 49);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ADD NEW PRODUCT";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(199, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 42);
            this.button4.TabIndex = 16;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtName.Location = new System.Drawing.Point(170, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 28);
            this.txtName.TabIndex = 17;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtManufacturer.Location = new System.Drawing.Point(170, 121);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(297, 28);
            this.txtManufacturer.TabIndex = 18;
            // 
            // txtDescript
            // 
            this.txtDescript.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtDescript.Location = new System.Drawing.Point(170, 219);
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(297, 173);
            this.txtDescript.TabIndex = 19;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtPrice.Location = new System.Drawing.Point(386, 409);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(81, 28);
            this.txtPrice.TabIndex = 20;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtStock.Location = new System.Drawing.Point(170, 169);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(81, 28);
            this.txtStock.TabIndex = 22;
            // 
            // radioSensor
            // 
            this.radioSensor.AutoSize = true;
            this.radioSensor.Location = new System.Drawing.Point(21, 15);
            this.radioSensor.Name = "radioSensor";
            this.radioSensor.Size = new System.Drawing.Size(74, 21);
            this.radioSensor.TabIndex = 23;
            this.radioSensor.TabStop = true;
            this.radioSensor.Tag = "sensor";
            this.radioSensor.Text = "Sensor";
            this.radioSensor.UseVisualStyleBackColor = true;
            // 
            // radioMicrocontroller
            // 
            this.radioMicrocontroller.AutoSize = true;
            this.radioMicrocontroller.Location = new System.Drawing.Point(112, 15);
            this.radioMicrocontroller.Name = "radioMicrocontroller";
            this.radioMicrocontroller.Size = new System.Drawing.Size(122, 21);
            this.radioMicrocontroller.TabIndex = 24;
            this.radioMicrocontroller.TabStop = true;
            this.radioMicrocontroller.Tag = "micro";
            this.radioMicrocontroller.Text = "Microcontroller";
            this.radioMicrocontroller.UseVisualStyleBackColor = true;
            // 
            // groupProductType
            // 
            this.groupProductType.Controls.Add(this.radioMicrocontroller);
            this.groupProductType.Controls.Add(this.radioSensor);
            this.groupProductType.Location = new System.Drawing.Point(197, 58);
            this.groupProductType.Name = "groupProductType";
            this.groupProductType.Size = new System.Drawing.Size(245, 45);
            this.groupProductType.TabIndex = 25;
            this.groupProductType.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(173, 75);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 20);
            this.lblType.TabIndex = 25;
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.lblType);
            this.groupBoxInformation.Controls.Add(this.btnCancel);
            this.groupBoxInformation.Controls.Add(this.btnSave);
            this.groupBoxInformation.Controls.Add(this.txtName);
            this.groupBoxInformation.Controls.Add(this.label3);
            this.groupBoxInformation.Controls.Add(this.groupProductType);
            this.groupBoxInformation.Controls.Add(this.label4);
            this.groupBoxInformation.Controls.Add(this.txtStock);
            this.groupBoxInformation.Controls.Add(this.label5);
            this.groupBoxInformation.Controls.Add(this.txtPrice);
            this.groupBoxInformation.Controls.Add(this.label6);
            this.groupBoxInformation.Controls.Add(this.txtDescript);
            this.groupBoxInformation.Controls.Add(this.label7);
            this.groupBoxInformation.Controls.Add(this.txtManufacturer);
            this.groupBoxInformation.Controls.Add(this.label8);
            this.groupBoxInformation.Location = new System.Drawing.Point(395, 94);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(487, 509);
            this.groupBoxInformation.TabIndex = 26;
            this.groupBoxInformation.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(142, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 49);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(6, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 49);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(395, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 36);
            this.label9.TabIndex = 27;
            this.label9.Text = "Product Information";
            // 
            // groupBoxListBox
            // 
            this.groupBoxListBox.BackColor = System.Drawing.Color.White;
            this.groupBoxListBox.Controls.Add(this.textBoxSearch);
            this.groupBoxListBox.Controls.Add(this.listBoxProducts);
            this.groupBoxListBox.Controls.Add(this.button1);
            this.groupBoxListBox.Controls.Add(this.btnAdd);
            this.groupBoxListBox.Controls.Add(this.button4);
            this.groupBoxListBox.Controls.Add(this.label1);
            this.groupBoxListBox.Controls.Add(this.button3);
            this.groupBoxListBox.Location = new System.Drawing.Point(0, 39);
            this.groupBoxListBox.Name = "groupBoxListBox";
            this.groupBoxListBox.Size = new System.Drawing.Size(389, 570);
            this.groupBoxListBox.TabIndex = 28;
            this.groupBoxListBox.TabStop = false;
            // 
            // groupBoxNoProductSelected
            // 
            this.groupBoxNoProductSelected.Controls.Add(this.label11);
            this.groupBoxNoProductSelected.Controls.Add(this.label10);
            this.groupBoxNoProductSelected.Location = new System.Drawing.Point(395, 89);
            this.groupBoxNoProductSelected.Name = "groupBoxNoProductSelected";
            this.groupBoxNoProductSelected.Size = new System.Drawing.Size(487, 514);
            this.groupBoxNoProductSelected.TabIndex = 29;
            this.groupBoxNoProductSelected.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "SELECT A PRODUCT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(99, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(310, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "TO SHOW IT IS DETAILS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 609);
            this.Controls.Add(this.groupBoxNoProductSelected);
            this.Controls.Add(this.groupBoxListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupProductType.ResumeLayout(false);
            this.groupProductType.PerformLayout();
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.groupBoxListBox.ResumeLayout(false);
            this.groupBoxListBox.PerformLayout();
            this.groupBoxNoProductSelected.ResumeLayout(false);
            this.groupBoxNoProductSelected.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.RadioButton radioSensor;
        private System.Windows.Forms.RadioButton radioMicrocontroller;
        private System.Windows.Forms.GroupBox groupProductType;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxListBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem exportProductsAsToolStripMenuItem;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox groupBoxNoProductSelected;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}