using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Common.Entities;
using Warehouse.Common.Managers;

namespace Warehouse.WindowsApp
{
    public partial class FormEditDocument : Form
    {
        private static ILog _log;
        private int _docId;
        private IWebApiClientManager _webApiClient;

        public FormEditDocument(int docId, IWebApiClientManager webApiClient)
        {
            InitializeComponent();
            _log = LogManager.GetLogger(this.GetType().FullName);
            _docId = docId;
            _webApiClient = webApiClient;
            AutocompleteDetailDocument();
        }

        public string TitleDocument { get; set; }
        public int ClientNumber { get; set; }

        private void AutocompleteDetailDocument()
        {
            try
            {
                var response = JsonConvert.DeserializeObject<BaseResponse>(_webApiClient.GetDocuments());
                if ((int)response.Code == 200)
                {
                    foreach (var item in response.Data)
                    {
                        if (item.Id == _docId)
                        {
                            textBoxNameDoc.Text = item.Title;
                            textBoxClientNum.Text = Convert.ToString(item.ClientNumber);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                _log.Error(ex);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNameDoc.Text) && !string.IsNullOrEmpty(textBoxClientNum.Text))
            {
                this.DialogResult = DialogResult.OK;
                TitleDocument = textBoxNameDoc.Text;
                ClientNumber = Convert.ToInt32(textBoxClientNum.Text);
            }
            else
            {
                MessageBox.Show("Fields are empty");
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
