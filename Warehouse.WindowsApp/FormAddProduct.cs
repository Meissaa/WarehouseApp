using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.WindowsApp
{
    public partial class FormAddProduct : Form
    {
        private static ILog _log;

        public FormAddProduct()
        {
            InitializeComponent();
            _log = LogManager.GetLogger(this.GetType().FullName);
        }

        public string TitleProd { get; set; }
        public int Amount { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }

        private void labelGrossPrice_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            TitleProd = textBoxNameProd.Text;
            Amount = Convert.ToInt32(textBoxAmount.Text);
            NetPrice = Convert.ToDecimal(textBoxNetPrice.Text);
            GrossPrice = Convert.ToDecimal(textBoxGrossPrice.Text);
            this.Close();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
