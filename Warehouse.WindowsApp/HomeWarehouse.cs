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
using Warehouse.WindowsApp.UnityConfig;

namespace Warehouse.WindowsApp
{
    public partial class HomeWarehouse : Form
    {
        private static ILog _log;
        private IWebApiClientManager _webApiClient;
        private Login _loginFrom;
        private FormAddDocument _formAddDocument;
        private FormEditDocument _formEditDocument;
        private DocumentItem _documentItem;
        private FormProduct _formProduct;
        private int _docId;
        decimal _netPrice, _grossPrice;

        public HomeWarehouse(Login loginForm, IWebApiClientManager webApiClient)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _log = LogManager.GetLogger(this.GetType().FullName);
            _loginFrom = loginForm;
            _webApiClient = webApiClient;
            GetAllDocuments();
        }

        private void GetAllDocuments()
        {
           
            dataGridViewAllLists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAllLists.Rows.Clear();
            dataGridViewAllLists.ColumnCount = 6;
            dataGridViewAllLists.Columns[0].Name = "Id";
            dataGridViewAllLists.Columns[0].Visible = false;
            dataGridViewAllLists.Columns[1].Name = "Tytuł";
            dataGridViewAllLists.Columns[2].Name = "Data";
            dataGridViewAllLists.Columns[3].Name = "Numer Klienta";
            dataGridViewAllLists.Columns[4].Name = "Cena netto";
            dataGridViewAllLists.Columns[5].Name = "Cena brutto";
 
            try
            {
                var response = JsonConvert.DeserializeObject<BaseResponse>(_webApiClient.GetDocuments());

                if ((int)response.Code == 200) {

                    foreach (var item in response.Data)
                    {
                        foreach (var prod in item.Products) {

                            _netPrice =+ CalculateTotalGrossPrice((int)prod.Amount, (decimal)prod.NetPrice);
                            _grossPrice =+ CalculateTotalGrossPrice((int)prod.Amount, (decimal)prod.GrossPrice);
                        }

                        dataGridViewAllLists.Rows.Add(item.Id, item.Title, item.Date, item.ClientNumber, _netPrice, _grossPrice);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                _log.Error(ex);
            }

            dataGridViewAllLists.Refresh();
            _netPrice = 0;
            _grossPrice = 0;
        }

        public decimal CalculateTotalNetPrice(int amount, decimal netPrice)
        {
            return amount * netPrice;
        }

        public decimal CalculateTotalGrossPrice(int amount, decimal grossPrice)
        {
            return amount * grossPrice;
        }

        private void buttonAddDocument_Click(object sender, EventArgs e)
        {
            _formAddDocument = new FormAddDocument();
            DialogResult dialogresult = _formAddDocument.ShowDialog(this);

            if (dialogresult == DialogResult.Cancel)
            {
                _formAddDocument.Close();
            }
            else if (dialogresult == DialogResult.OK)
            {
                try
                {
                    var titleDocument = _formAddDocument.TitleDocument;
                    var createdate = DateTime.Now;
                    var clientNumber = _formAddDocument.ClientNumber;
                    _documentItem = new DocumentItem { Title = titleDocument, Date = createdate, ClientNumber = clientNumber };
                    _webApiClient.CreateDocument(_documentItem);
                    GetAllDocuments();
                }          
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                    _log.Error(ex);
                }
            }
            _formAddDocument.Dispose();
        }

        private void buttonRemoveDocument_Click(object sender, EventArgs e)
        {
            _docId = Convert.ToInt32(dataGridViewAllLists.SelectedRows[0].Cells[0].Value);

            try
            {
                _webApiClient.RemoveDocument(_docId);
                GetAllDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                _log.Error(ex);
            }
        }

        private void buttonUpdateDocument_Click(object sender, EventArgs e)
        {

            if (dataGridViewAllLists.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select one document");
                return;
            }

            _docId = Convert.ToInt32(dataGridViewAllLists.SelectedRows[0].Cells[0].Value);

            _formEditDocument = new FormEditDocument(_docId, DependencyInjector.Retrieve<IWebApiClientManager>());
            DialogResult dialogresult = _formEditDocument.ShowDialog(this);

            if (dialogresult == DialogResult.Cancel)
            {
                _formEditDocument.Close();
            }
            else if (dialogresult == DialogResult.OK)
            {
                try
                {
                    var titleDocument = _formEditDocument.TitleDocument;
                    var createdate = DateTime.Now;
                    var clientNumber = _formEditDocument.ClientNumber;
                    _documentItem = new DocumentItem { Id =_docId, Title = titleDocument, Date = createdate, ClientNumber = clientNumber };
                    _webApiClient.UpdateDocument(_documentItem);
                    GetAllDocuments();

                }              
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                    _log.Error(ex);
                }
            }
        }

        private void HomeWarehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginFrom.Visible = true;
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllLists.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select one document");
                return;
            }

            _docId = Convert.ToInt32(dataGridViewAllLists.SelectedRows[0].Cells[0].Value);

            try
            {
                _formProduct = new FormProduct(_docId, DependencyInjector.Retrieve<IWebApiClientManager>());
                _formProduct.ShowDialog();
                GetAllDocuments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                _log.Error(ex);
            }
        }
    }
}
