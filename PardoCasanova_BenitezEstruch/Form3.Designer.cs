namespace PardoCasanova_BenitezEstruch
{
    partial class Form3
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
            this.btnCancelExport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCSV = new System.Windows.Forms.RadioButton();
            this.radioXML = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelExport
            // 
            this.btnCancelExport.Location = new System.Drawing.Point(467, 370);
            this.btnCancelExport.Name = "btnCancelExport";
            this.btnCancelExport.Size = new System.Drawing.Size(127, 42);
            this.btnCancelExport.TabIndex = 14;
            this.btnCancelExport.Text = "Cancel";
            this.btnCancelExport.UseVisualStyleBackColor = true;
            this.btnCancelExport.Click += new System.EventHandler(this.btnCancelExport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(467, 307);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 42);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Preview content file";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(412, 376);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCSV);
            this.groupBox1.Controls.Add(this.radioXML);
            this.groupBox1.Location = new System.Drawing.Point(467, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 134);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File format";
            // 
            // radioCSV
            // 
            this.radioCSV.AutoSize = true;
            this.radioCSV.Location = new System.Drawing.Point(22, 85);
            this.radioCSV.Name = "radioCSV";
            this.radioCSV.Size = new System.Drawing.Size(84, 21);
            this.radioCSV.TabIndex = 3;
            this.radioCSV.TabStop = true;
            this.radioCSV.Text = "...to CSV";
            this.radioCSV.UseVisualStyleBackColor = true;
            this.radioCSV.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioXML
            // 
            this.radioXML.AutoSize = true;
            this.radioXML.Location = new System.Drawing.Point(21, 34);
            this.radioXML.Name = "radioXML";
            this.radioXML.Size = new System.Drawing.Size(85, 21);
            this.radioXML.TabIndex = 2;
            this.radioXML.TabStop = true;
            this.radioXML.Text = "...to XML";
            this.radioXML.UseVisualStyleBackColor = true;
            this.radioXML.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.btnCancelExport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCSV;
        private System.Windows.Forms.RadioButton radioXML;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}