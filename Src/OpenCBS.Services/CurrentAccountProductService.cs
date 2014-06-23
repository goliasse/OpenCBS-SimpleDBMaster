using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;

namespace OpenCBS.Services
{
    public class CurrentAccountProductService
    {
        private readonly CurrentAccountProductManager _currentAccountProductManager;
        private User _user;

        public CurrentAccountProductService(CurrentAccountProductManager currentAccountProductManager)
		{
            _currentAccountProductManager = currentAccountProductManager;
		}

        public CurrentAccountProductService(User user)
		{
            _user = user;
            _currentAccountProductManager = new CurrentAccountProductManager(user);
		}

        public void SaveFixedDepositProduct(ICurrentAccountProduct currentAccountProduct)
        {

            ValidateProduct(currentAccountProduct);
            _currentAccountProductManager.SaveCurrentAccountProduct(currentAccountProduct);


        }

        private void ValidateProduct(ICurrentAccountProduct fixedDepositProduct)
        {
        }
    }
}
