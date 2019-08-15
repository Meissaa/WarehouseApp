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
    public partial class FormProduct : Form
    {
        private static ILog _log;
        private IWebApiClientManager _webApiClient;
        private FormAddProduct _formAddProduct;
        private FormEditProduct _formEditProduct;
        private Product _productItem;
        private int _prodId, _docId, _idProdSelect;

        public FormProduct(int docId, IWebApiClientManager webApiClient)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this._docId = docId;
            _webApiClient = webApiClient;
            GetProducts(_docId);
        }

        private void GetProducts(int docId)
        {
            dataGridViewAllProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAllProduct.Rows.Clear();
            dataGridViewAllProduct.ColumnCount = 5;
            dataGridViewAllProduct.Columns[0].Name = "Id";
            dataGridViewAllProduct.Columns[0].Visible = false;
            dataGridViewAllProduct.Columns[1].Name = "Tytuł";
            dataGridViewAllProduct.Columns[2].Name = "Ilość";
            dataGridViewAllProduct.Columns[3].Name = "Cena netto";
            dataGridViewAllProduct.Columns[4].Name = "Cena brutto";

            try
            {
                var response = JsonConvert.DeserializeObject<BaseResponse>(_webApiClient.GetDocumentDetails(_docId));

                foreach (var item in response.Data.Products)
                {
                    dataGridViewAllProduct.Rows.Add(item.Id, item.Title, item.Amount, item.NetPrice, item.GrossPrice);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);


                dataGridViewAllProduct.Refresh();
            }
        }

            private void buttonAddProduct_Click(object sender, EventArgs e)
            {
                _formAddProduct = new FormAddProduct();
                DialogResult dialogresult = _formAddProduct.ShowDialog(this);

                if (dialogresult == DialogResult.Cancel)
                {
                    _formAddProduct.Close();
                }
                else if (dialogresult == DialogResult.OK)
                {
                    try
                    {
                        var titleTask = _formAddProduct.TitleProd;
                        var amount = _formAddProduct.Amount;
                        var netPrice = _formAddProduct.NetPrice;
                        var grossPrice = _formAddProduct.GrossPrice;

                        _productItem = new Product { Title = titleTask, Amount = amount, NetPrice = netPrice, GrossPrice = grossPrice };
                        _webApiClient.AddProduct(_docId, _productItem);
                        GetProducts(_docId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" " + ex);
                        _log.Error(ex);
                    }
                }
            }

            private void buttonUpdateProduct_Click(object sender, EventArgs e)
            {
                try
                {

                    if (dataGridViewAllProduct.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("Select one product");
                        return;
                    }

                    _idProdSelect = Convert.ToInt32(dataGridViewAllProduct.SelectedRows[0].Cells[0].Value);
                    _formEditProduct = new FormEditProduct(_docId, _idProdSelect, DependencyInjector.Retrieve<IWebApiClientManager>());
                    DialogResult dialogresult = _formEditProduct.ShowDialog(this);

                    if (dialogresult == DialogResult.Cancel)
                    {
                        _formEditProduct.Close();
                    }
                    else if (dialogresult == DialogResult.OK)
                    {

                        var titleTask = _formEditProduct.TitleProd;
                        var amount = _formEditProduct.Amount;
                        var netPrice = _formEditProduct.NetPrice;
                        var grossPrice = _formEditProduct.GrossPrice;

                        _productItem = new Product { Id = _idProdSelect, Title = titleTask, Amount = amount, NetPrice = netPrice, GrossPrice = grossPrice };
                        _webApiClient.UpdateProduct(_docId, _productItem);
                        GetProducts(_docId);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                    _log.Error(ex);
                }

            }

            private void checkedListBoxDetailsProducts_SelectedIndexChanged(object sender, EventArgs e)
            {
            }

            private void buttonRemoveProduct_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridViewAllProduct.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("Select one product");
                        return;
                    }

                    _idProdSelect = Convert.ToInt32(dataGridViewAllProduct.SelectedRows[0].Cells[0].Value);
                    _webApiClient.RemoveProduct(_docId, _idProdSelect);
                    GetProducts(_docId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                    _log.Error(ex);
                }
            }

            private void buttonBack_Click(object sender, EventArgs e)
            {
                this.Close();
            }


        }
    }
