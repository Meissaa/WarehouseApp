namespace Warehouse.WindowsApp
{
    partial class FormProduct
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
            this.buttonRemoveProduct = new System.Windows.Forms.Button();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewAllProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemoveProduct
            // 
            this.buttonRemoveProduct.Location = new System.Drawing.Point(244, 24);
            this.buttonRemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveProduct.Name = "buttonRemoveProduct";
            this.buttonRemoveProduct.Size = new System.Drawing.Size(125, 38);
            this.buttonRemoveProduct.TabIndex = 21;
            this.buttonRemoveProduct.Text = "Remove Product";
            this.buttonRemoveProduct.UseVisualStyleBackColor = true;
            this.buttonRemoveProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Location = new System.Drawing.Point(467, 24);
            this.buttonUpdateProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(125, 38);
            this.buttonUpdateProduct.TabIndex = 20;
            this.buttonUpdateProduct.Text = "Update Product";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(32, 24);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(125, 38);
            this.buttonAddProduct.TabIndex = 19;
            this.buttonAddProduct.Text = "Add  Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(31, 397);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(91, 34);
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewAllProduct
            // 
            this.dataGridViewAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllProduct.Location = new System.Drawing.Point(13, 83);
            this.dataGridViewAllProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            this.dataGridViewAllProduct.Size = new System.Drawing.Size(603, 269);
            this.dataGridViewAllProduct.TabIndex = 22;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.dataGridViewAllProduct);
            this.Controls.Add(this.buttonRemoveProduct);
            this.Controls.Add(this.buttonUpdateProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewAllProduct;
    }
}