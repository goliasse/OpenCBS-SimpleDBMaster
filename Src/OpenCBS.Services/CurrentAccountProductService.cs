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
            bool name = _currentAccountProductManager.CheckForDuplicateValue("CurrentAccountProduct", "current_account_product_name", currentAccountProduct.CurrentAccountProductName);
            bool code = _currentAccountProductManager.CheckForDuplicateValue("CurrentAccountProduct", "current_account_product_code", currentAccountProduct.CurrentAccountProductCode);
            ValidateProduct(currentAccountProduct);
            return _currentAccountProductManager.SaveCurrentAccountProduct(currentAccountProduct);


        }

        public void UpdateCurrentAccountProduct(ICurrentAccountProduct product, int productId)
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

        public void DeleteCurrentAccountProduct(int pProductId)
        {
            _currentAccountProductManager.DeleteCurrentAccountProduct(pProductId);
        }


        private void ValidateProduct(ICurrentAccountProduct fixedDepositProduct)
        {
        }


        public CurrentAccountTransactionFees FetchTransaction(string transactionType, string transactionMode, int productId)
        {
            return _currentAccountProductManager.FetchTransaction(transactionType, transactionMode, productId);
        }


        public int SaveCurrentAccountTransactionFees(CurrentAccountTransactionFees currentAccountTransactionFees)
        {
            return _currentAccountProductManager.SaveCurrentAccountTransactionFees(currentAccountTransactionFees);
        }
            public List<CurrentAccountTransactionFees> FetchTransactionFee(int productId)
            {
               return _currentAccountProductManager.FetchTransactionFee(productId);
            }

            public CurrentAccountTransactionFees FetchTransaction(int transactionId)
            {
                return _currentAccountProductManager.FetchTransaction(transactionId);
            }


        public void UpdateCurrentAccountTransactionFees(CurrentAccountTransactionFees transactionFees, string transactionType, string transactionMode, int productId)
        {
            _currentAccountProductManager.UpdateCurrentAccountTransactionFees(transactionFees, transactionType, transactionMode, productId);
        }

    }
}
