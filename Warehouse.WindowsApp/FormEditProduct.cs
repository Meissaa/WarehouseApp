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
    public partial class FormEditProduct : Form
    {
        private static ILog _log;
        private IWebApiClientManager _webApiClient;
        int _docId, _idProd;

        public FormEditProduct(int docId, int idProd, IWebApiClientManager webApiClient)
        {
            InitializeComponent();
            _log = LogManager.GetLogger(this.GetType().FullName);
            _webApiClient = webApiClient;
            _docId = docId;
            _idProd = idProd;
            AutocompleteFieldsProduct();
        }

        public string TitleProd { get; set; }
        public int Amount { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }

        public void AutocompleteFieldsProduct()
        {
            try
            {
                var response = JsonConvert.DeserializeObject<BaseResponse>(_webApiClient.GetDocumentDetails(_docId));

                foreach (var item in response.Data.Products)
                {
                    if (item.Id == _idProd)
                    {
                        textBoxNameProd.Text = item.Title;
                        textBoxAmount.Text = Convert.ToString(item.Amount);
                        textBoxNetPrice.Text = Convert.ToString(item.NetPrice);
                        textBoxGrossPrice.Text = Convert.ToString(item.GrossPrice);                    
                    }
                }
            }          
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                _log.Error(ex);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
    }
}
