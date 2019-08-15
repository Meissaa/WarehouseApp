namespace Warehouse.WindowsApp
{
    partial class FormEditProduct
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelGrossPrice = new System.Windows.Forms.Label();
            this.textBoxGrossPrice = new System.Windows.Forms.TextBox();
            this.labelNetPrice = new System.Windows.Forms.Label();
            this.textBoxNetPrice = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelNameProd = new System.Windows.Forms.Label();
            this.textBoxNameProd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(238, 253);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 35;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(363, 253);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 34;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelGrossPrice
            // 
            this.labelGrossPrice.AutoSize = true;
            this.labelGrossPrice.Location = new System.Drawing.Point(39, 181);
            this.labelGrossPrice.Name = "labelGrossPrice";
            this.labelGrossPrice.Size = new System.Drawing.Size(90, 17);
            this.labelGrossPrice.TabIndex = 33;
            this.labelGrossPrice.Text = "Gross Price :";
            // 
            // textBoxGrossPrice
            // 
            this.textBoxGrossPrice.Location = new System.Drawing.Point(150, 178);
            this.textBoxGrossPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGrossPrice.Name = "textBoxGrossPrice";
            this.textBoxGrossPrice.Size = new System.Drawing.Size(313, 22);
            this.textBoxGrossPrice.TabIndex = 32;
            // 
            // labelNetPrice
            // 
            this.labelNetPrice.AutoSize = true;
            this.labelNetPrice.Location = new System.Drawing.Point(55, 133);
            this.labelNetPrice.Name = "labelNetPrice";
            this.labelNetPrice.Size = new System.Drawing.Size(74, 17);
            this.labelNetPrice.TabIndex = 31;
            this.labelNetPrice.Text = "Net Price :";
            // 
            // textBoxNetPrice
            // 
            this.textBoxNetPrice.Location = new System.Drawing.Point(150, 133);
            this.textBoxNetPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNetPrice.Name = "textBoxNetPrice";
            this.textBoxNetPrice.Size = new System.Drawing.Size(313, 22);
            this.textBoxNetPrice.TabIndex = 30;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(65, 89);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(64, 17);
            this.labelAmount.TabIndex = 29;
            this.labelAmount.Text = "Amount :";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(150, 89);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(313, 22);
            this.textBoxAmount.TabIndex = 28;
            // 
            // labelNameProd
            // 
            this.labelNameProd.AutoSize = true;
            this.labelNameProd.Location = new System.Drawing.Point(78, 46);
            this.labelNameProd.Name = "labelNameProd";
            this.labelNameProd.Size = new System.Drawing.Size(53, 17);
            this.labelNameProd.TabIndex = 27;
            this.labelNameProd.Text = "Name :";
            // 
            // textBoxNameProd
            // 
            this.textBoxNameProd.Location = new System.Drawing.Point(150, 44);
            this.textBoxNameProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameProd.Name = "textBoxNameProd";
            this.textBoxNameProd.Size = new System.Drawing.Size(313, 22);
            this.textBoxNameProd.TabIndex = 26;
            // 
            // FormEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 316);
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
            this.Name = "FormEditProduct";
            this.Text = "FormEditProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelGrossPrice;
        private System.Windows.Forms.TextBox textBoxGrossPrice;
        private System.Windows.Forms.Label labelNetPrice;
        private System.Windows.Forms.TextBox textBoxNetPrice;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelNameProd;
        private System.Windows.Forms.TextBox textBoxNameProd;
    }
}