using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;

namespace OpenCBS.Services
{
   public class CurrentAccountProductHoldingServices
    {

       private readonly CurrentAccountProductHoldingManager _currentAccountProductHoldingManager;
        private User _user;

        public CurrentAccountProductHoldingServices(CurrentAccountProductHoldingManager currentAccountProductHoldingManager)
		{
            _currentAccountProductHoldingManager = currentAccountProductHoldingManager;
		}

        public CurrentAccountProductHoldingServices(User user)
		{
            _user = user;
            _currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(user);
		}

       public int SaveCurrentAccountPoductHolding(CurrentAccountProductHoldings productName)
       {
           return _currentAccountProductHoldingManager.SaveCurrentAccountPoductHolding(productName);
       }
        public void UpdateCurrentAccountProductHolding(CurrentAccountProductHoldings product, int productId)
        {
          _currentAccountProductHoldingManager.UpdateCurrentAccountProductHolding(product, productId);
        }
         public List<CurrentAccountProductHoldings> FetchProduct(bool showAlsoDeleted, int productId)
         {
             return _currentAccountProductHoldingManager.FetchProduct(showAlsoDeleted, productId);
         }

         public CurrentAccountProductHoldings FetchProduct(int productId)
         {
             return _currentAccountProductHoldingManager.FetchProduct(productId);
         }

    }
}
