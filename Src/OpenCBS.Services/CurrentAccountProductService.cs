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

        public void SaveCurrentAccountProduct(ICurrentAccountProduct currentAccountProduct)
        {

            ValidateProduct(currentAccountProduct);
            _currentAccountProductManager.SaveCurrentAccountProduct(currentAccountProduct);


        }

        public void UpdateCurrentAccountProduct(CurrentAccountProduct product, int productId)
        {
            _currentAccountProductManager.UpdateCurrentAccountProduct(product, productId);
        }
          public CurrentAccountProduct FetchProduct(int currentAccountProductId)
          {
              return _currentAccountProductManager.FetchProduct(currentAccountProductId);
          }
          public List<CurrentAccountProduct> FetchProduct(bool showAlsoDeleted, int currentAccountProductId)
          {
              return _currentAccountProductManager.FetchProduct(showAlsoDeleted, currentAccountProductId);
          }

        private void ValidateProduct(ICurrentAccountProduct fixedDepositProduct)
        {
        }
    }
}
