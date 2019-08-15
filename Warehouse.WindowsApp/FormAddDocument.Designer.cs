namespace Warehouse.WindowsApp
{
    partial class FormAddDocument
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelNameDoc = new System.Windows.Forms.Label();
            this.textBoxNameDoc = new System.Windows.Forms.TextBox();
            this.labelClientNum = new System.Windows.Forms.Label();
            this.textBoxClientNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(193, 164);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 30);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(328, 164);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(101, 30);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelNameDoc
            // 
            this.labelNameDoc.AutoSize = true;
            this.labelNameDoc.Location = new System.Drawing.Point(44, 42);
            this.labelNameDoc.Name = "labelNameDoc";
            this.labelNameDoc.Size = new System.Drawing.Size(53, 17);
            this.labelNameDoc.TabIndex = 9;
            this.labelNameDoc.Text = "Name :";
            // 
            // textBoxNameDoc
            // 
            this.textBoxNameDoc.Location = new System.Drawing.Point(116, 40);
            this.textBoxNameDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameDoc.Name = "textBoxNameDoc";
            this.textBoxNameDoc.Size = new System.Drawing.Size(313, 22);
            this.textBoxNameDoc.TabIndex = 8;
            // 
            // labelClientNum
            // 
            this.labelClientNum.AutoSize = true;
            this.labelClientNum.Location = new System.Drawing.Point(5, 88);
            this.labelClientNum.Name = "labelClientNum";
            this.labelClientNum.Size = new System.Drawing.Size(105, 17);
            this.labelClientNum.TabIndex = 13;
            this.labelClientNum.Text = "Client Number :";
            // 
            // textBoxClientNum
            // 
            this.textBoxClientNum.Location = new System.Drawing.Point(116, 85);
            this.textBoxClientNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClientNum.Name = "textBoxClientNum";
            this.textBoxClientNum.Size = new System.Drawing.Size(313, 22);
            this.textBoxClientNum.TabIndex = 12;
            // 
            // FormAddDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 217);
            this.Controls.Add(this.labelClientNum);
            this.Controls.Add(this.textBoxClientNum);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelNameDoc);
            this.Controls.Add(this.textBoxNameDoc);
            this.Name = "FormAddDocument";
            this.Text = "Add Document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelNameDoc;
        private System.Windows.Forms.TextBox textBoxNameDoc;
        private System.Windows.Forms.Label labelClientNum;
        private System.Windows.Forms.TextBox textBoxClientNum;
    }
}