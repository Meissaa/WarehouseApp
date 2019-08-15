namespace Warehouse.WindowsApp
{
    partial class HomeWarehouse
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
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonUpdateDocument = new System.Windows.Forms.Button();
            this.buttonRemoveDocument = new System.Windows.Forms.Button();
            this.dataGridViewAllLists = new System.Windows.Forms.DataGridView();
            this.buttonAddDocument = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllLists)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(648, 84);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(100, 34);
            this.buttonProduct.TabIndex = 21;
            this.buttonProduct.Text = "Product";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonUpdateDocument
            // 
            this.buttonUpdateDocument.Location = new System.Drawing.Point(224, 84);
            this.buttonUpdateDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateDocument.Name = "buttonUpdateDocument";
            this.buttonUpdateDocument.Size = new System.Drawing.Size(139, 34);
            this.buttonUpdateDocument.TabIndex = 20;
            this.buttonUpdateDocument.Text = "Update Document";
            this.buttonUpdateDocument.UseVisualStyleBackColor = true;
            this.buttonUpdateDocument.Click += new System.EventHandler(this.buttonUpdateDocument_Click);
            // 
            // buttonRemoveDocument
            // 
            this.buttonRemoveDocument.Location = new System.Drawing.Point(439, 84);
            this.buttonRemoveDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemoveDocument.Name = "buttonRemoveDocument";
            this.buttonRemoveDocument.Size = new System.Drawing.Size(143, 34);
            this.buttonRemoveDocument.TabIndex = 19;
            this.buttonRemoveDocument.Text = "Remove Document";
            this.buttonRemoveDocument.UseVisualStyleBackColor = true;
            this.buttonRemoveDocument.Click += new System.EventHandler(this.buttonRemoveDocument_Click);
            // 
            // dataGridViewAllLists
            // 
            this.dataGridViewAllLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllLists.Location = new System.Drawing.Point(26, 135);
            this.dataGridViewAllLists.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAllLists.Name = "dataGridViewAllLists";
            this.dataGridViewAllLists.Size = new System.Drawing.Size(757, 358);
            this.dataGridViewAllLists.TabIndex = 18;
            // 
            // buttonAddDocument
            // 
            this.buttonAddDocument.Location = new System.Drawing.Point(40, 84);
            this.buttonAddDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddDocument.Name = "buttonAddDocument";
            this.buttonAddDocument.Size = new System.Drawing.Size(115, 34);
            this.buttonAddDocument.TabIndex = 17;
            this.buttonAddDocument.Text = "Add Document";
            this.buttonAddDocument.UseVisualStyleBackColor = true;
            this.buttonAddDocument.Click += new System.EventHandler(this.buttonAddDocument_Click);
            // 
            // HomeWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 533);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonUpdateDocument);
            this.Controls.Add(this.buttonRemoveDocument);
            this.Controls.Add(this.dataGridViewAllLists);
            this.Controls.Add(this.buttonAddDocument);
            this.Name = "HomeWarehouse";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeWarehouse_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonUpdateDocument;
        private System.Windows.Forms.Button buttonRemoveDocument;
        private System.Windows.Forms.DataGridView dataGridViewAllLists;
        private System.Windows.Forms.Button buttonAddDocument;
    }
}