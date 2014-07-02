using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;

namespace OpenCBS.Services
{
    public class CurrentAccountTransactionService
    {

        private readonly CurrentAccountTransactionManager _currentAccountProductManager;
        private User _user;

        public CurrentAccountTransactionService(CurrentAccountTransactionManager currentAccountProductManager)
		{
            _currentAccountProductManager = currentAccountProductManager;
		}

        public CurrentAccountTransactionService(User user)
		{
            _user = user;
            _currentAccountProductManager = new CurrentAccountTransactionManager(user);
		}



    }
}
