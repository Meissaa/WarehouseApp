namespace Warehouse.WindowsApp
{
    partial class FormAddProduct
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelNameProd = new System.Windows.Forms.Label();
            this.textBoxNameProd = new System.Windows.Forms.TextBox();
            this.labelGrossPrice = new System.Windows.Forms.Label();
            this.textBoxGrossPrice = new System.Windows.Forms.TextBox();
            this.labelNetPrice = new System.Windows.Forms.Label();
            this.textBoxNetPrice = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(81, 99);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(64, 17);
            this.labelAmount.TabIndex = 19;
            this.labelAmount.Text = "Amount :";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(166, 99);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(313, 22);
            this.textBoxAmount.TabIndex = 18;
            // 
            // labelNameProd
            // 
            this.labelNameProd.AutoSize = true;
            this.labelNameProd.Location = new System.Drawing.Point(94, 56);
            this.labelNameProd.Name = "labelNameProd";
            this.labelNameProd.Size = new System.Drawing.Size(53, 17);
            this.labelNameProd.TabIndex = 15;
            this.labelNameProd.Text = "Name :";
            // 
            // textBoxNameProd
            // 
            this.textBoxNameProd.Location = new System.Drawing.Point(166, 54);
            this.textBoxNameProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameProd.Name = "textBoxNameProd";
            this.textBoxNameProd.Size = new System.Drawing.Size(313, 22);
            this.textBoxNameProd.TabIndex = 14;
            // 
            // labelGrossPrice
            // 
            this.labelGrossPrice.AutoSize = true;
            this.labelGrossPrice.Location = new System.Drawing.Point(55, 191);
            this.labelGrossPrice.Name = "labelGrossPrice";
            this.labelGrossPrice.Size = new System.Drawing.Size(90, 17);
            this.labelGrossPrice.TabIndex = 23;
            this.labelGrossPrice.Text = "Gross Price :";
            // 
            // textBoxGrossPrice
            // 
            this.textBoxGrossPrice.Location = new System.Drawing.Point(166, 188);
            this.textBoxGrossPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGrossPrice.Name = "textBoxGrossPrice";
            this.textBoxGrossPrice.Size = new System.Drawing.Size(313, 22);
            this.textBoxGrossPrice.TabIndex = 22;
            // 
            // labelNetPrice
            // 
            this.labelNetPrice.AutoSize = true;
            this.labelNetPrice.Location = new System.Drawing.Point(71, 143);
            this.labelNetPrice.Name = "labelNetPrice";
            this.labelNetPrice.Size = new System.Drawing.Size(74, 17);
            this.labelNetPrice.TabIndex = 21;
            this.labelNetPrice.Text = "Net Price :";
            // 
            // textBoxNetPrice
            // 
            this.textBoxNetPrice.Location = new System.Drawing.Point(166, 143);
            this.textBoxNetPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNetPrice.Name = "textBoxNetPrice";
            this.textBoxNetPrice.Size = new System.Drawing.Size(313, 22);
            this.textBoxNetPrice.TabIndex = 20;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(254, 263);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(379, 263);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 24;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 329);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelGrossPrice);
            this.Controls.Add(this.textBoxGrossPrice);
            this.Controls.Add(this.labelNetPrice);
            this.Controls.Add(this.textBoxNetPrice);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelNameProd);
            this.Controls.Add(this.textBoxNameProd);
            this.Name = "FormAddProduct";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelNameProd;
        private System.Windows.Forms.TextBox textBoxNameProd;
        private System.Windows.Forms.Label labelGrossPrice;
        private System.Windows.Forms.TextBox textBoxGrossPrice;
        private System.Windows.Forms.Label labelNetPrice;
        private System.Windows.Forms.TextBox textBoxNetPrice;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOk;
    }
}