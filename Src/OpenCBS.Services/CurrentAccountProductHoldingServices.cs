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

       public string SaveCurrentAccountPoductHolding(CurrentAccountProductHoldings productName)
       {
           return _currentAccountProductHoldingManager.SaveCurrentAccountPoductHolding(productName);
       }


       public CurrentAccountProductHoldings FetchProduct(string contractCode)
       {
           return _currentAccountProductHoldingManager.FetchProduct(contractCode);
       }

       public List<CurrentAccountProductHoldings> FetchProduct(int clientid, string clientType)
       {

           return _currentAccountProductHoldingManager.FetchProduct(clientid, clientType);
       }
        public void UpdateCurrentAccountProductHolding(CurrentAccountProductHoldings product, int productId)
        {
          _currentAccountProductHoldingManager.UpdateCurrentAccountProductHolding(product, productId);
        }

        public void UpdateCurrentAccountProductHolding(CurrentAccountProductHoldings product, string contractCode)
        {
            _currentAccountProductHoldingManager.UpdateCurrentAccountProductHolding(product, contractCode);
        }

         public List<CurrentAccountProductHoldings> FetchProduct(bool showAlsoDeleted)
         {
             return _currentAccountProductHoldingManager.FetchProduct(showAlsoDeleted);
         }

         public CurrentAccountProductHoldings FetchProduct(int productId)
         {
             return _currentAccountProductHoldingManager.FetchProduct(productId);
         }

    }
}
