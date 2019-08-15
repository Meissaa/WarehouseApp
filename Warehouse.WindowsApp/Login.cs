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
    public partial class Login : Form
    {
        private static ILog _log;
        private IWebApiClientManager _webApiClient;
        private HomeWarehouse _homeWarehouse;

        public Login(IWebApiClientManager webApiClient)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _log = LogManager.GetLogger(this.GetType().FullName);
            _webApiClient = webApiClient;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var username = textBoxUsername.Text;
                var password = textBoxPassword.Text;

                var response = JsonConvert.DeserializeObject<BaseResponse>(_webApiClient.Login(username, password));

                if ((int)response.Code == 200)
                {
                    _homeWarehouse = new HomeWarehouse(this,DependencyInjector.Retrieve<IWebApiClientManager>());
                    this.Visible = false;
                    _homeWarehouse.Show();
                }
                else
                {

                    MessageBox.Show("Login failed");
                }

                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
            catch (Exception ex) {

                MessageBox.Show(" " + ex);
                _log.Error(ex);
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
