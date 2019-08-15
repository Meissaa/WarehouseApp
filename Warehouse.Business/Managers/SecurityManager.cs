using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Common.Entities;
using Warehouse.Common.Managers;
using log4net;
using Warehouse.Data;
using Warehouse.Common.Exceptions.Security;

namespace Warehouse.Business.Managers
{
    public class SecurityManager : ISecurityManager
    {
        private static ILog _log;
        private static User _loggedUser;
        private WarehouseDbContext _db = new WarehouseDbContext();

        public SecurityManager() {
            _log = LogManager.GetLogger(this.GetType().FullName);
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _log.Debug("Release resources");
                _db.Dispose();
            }
        }

        public User GetLoggedUser()
        {
            if (_loggedUser == null)
            {
                _log.Error("No user currently logged in");
                throw new SecurityException("No user currently logged in");
            }
            return _loggedUser;
        }

        public bool IsUserLogged()
        {
            return _loggedUser != null;
        }

        public void Login(string username, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                throw new LoginFailedException("Invalid username or password");
            }
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                throw new LoginFailedException("Invalid username or password");
            }

            _loggedUser = user;
        }

        public void Logout()
        {
            if (!IsUserLogged())
            {
                throw new SecurityException("No user currently logged in");
            }

            _loggedUser = null;

        }
    }
}
