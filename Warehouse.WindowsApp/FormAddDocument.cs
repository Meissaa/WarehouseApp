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
    public partial class FormAddDocument : Form
    {
        private static ILog _log;

        public FormAddDocument()
        {
            InitializeComponent();
            _log = LogManager.GetLogger(this.GetType().FullName);
        }

        public string TitleDocument { get; set;}
        public int ClientNumber { get; set;}

        private void buttonOk_Click(object sender, EventArgs e)
        {
            TitleDocument = textBoxNameDoc.Text;
            ClientNumber = Convert.ToInt32(textBoxClientNum.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
