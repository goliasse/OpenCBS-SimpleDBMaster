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

        public int SaveCurrentAccountProduct(ICurrentAccountProduct currentAccountProduct)
        {

            ValidateProduct(currentAccountProduct);
            return _currentAccountProductManager.SaveCurrentAccountProduct(currentAccountProduct);


        }

        public void UpdateCurrentAccountProduct(CurrentAccountProduct product, int productId)
        {
            _currentAccountProductManager.UpdateCurrentAccountProduct(product, productId);
        }
          public CurrentAccountProduct FetchProduct(int currentAccountProductId)
          {
              return _currentAccountProductManager.FetchProduct(currentAccountProductId);
          }
          public List<ICurrentAccountProduct> FetchProduct(bool showAlsoDeleted)
          {
              return _currentAccountProductManager.FetchProduct(showAlsoDeleted);
          }

          

        public CurrentAccountProduct FetchProduct(string productName, string productCode)
        {
            return _currentAccountProductManager.FetchProduct(productName, productCode);
        }

        private void ValidateProduct(ICurrentAccountProduct fixedDepositProduct)
        {
        }
    }
}
