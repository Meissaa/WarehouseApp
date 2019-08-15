using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Common.Entities;

namespace Warehouse.Common.Managers
{
    public interface ISecurityManager : IDisposable
    {
        void Login(string username, string password);
        User GetLoggedUser();
        bool IsUserLogged();
        void Logout();
    }
}
