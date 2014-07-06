using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Enums;
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


        private void ValidateProduct(ICurrentAccountProduct currentAccountProduct)
        {

            if (string.IsNullOrEmpty(currentAccountProduct.CurrentAccountProductName))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.NameIsEmpty);

            if (currentAccountProduct.CurrentAccountProductName.Length < 3)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.NameIsLessThanThree);

            if (string.IsNullOrEmpty(currentAccountProduct.CurrentAccountProductCode))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CodeIsEmpty);

            if (currentAccountProduct.CurrentAccountProductCode.Length < 6)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.NameIsLessThanThree);

            if (currentAccountProduct.ClientType == "")
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OneCheckBoxMustBeSeleted);

            if (currentAccountProduct.Currency == "" && currentAccountProduct.Currency == OCurrentAccount.SelectCurrencyDefault)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.SelectCurrencySelected);

            if (currentAccountProduct.InitialAmountMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InitialAmountMinIsInvalid);

            if (currentAccountProduct.InitialAmountMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InitialAmountMaxIsInvalid);

            if (currentAccountProduct.InitialAmountMax <= currentAccountProduct.InitialAmountMin)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InitialAmountMinMaxIsInvalid);

            if (currentAccountProduct.BalanceMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.BalanceMinIsInvalid);

            if (currentAccountProduct.BalanceMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.BalanceMaxIsInvalid);

            if (currentAccountProduct.BalanceMax <= currentAccountProduct.BalanceMin)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.BalanceMinMaxIsInvalid);

            if (currentAccountProduct.InterestMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestMinIsInvalid);

            if (currentAccountProduct.InterestMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestMaxIsInvalid);

            if (currentAccountProduct.InterestMax <= currentAccountProduct.InterestMin)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestMinMaxIsInvalid);

            if (currentAccountProduct.OverdraftMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMinIsInvalid);

            if (currentAccountProduct.OverdraftMax < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMaxIsInvalid);

            if (currentAccountProduct.OverdraftMax <= currentAccountProduct.OverdraftMin)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMinMaxIsInvalid);

            if (currentAccountProduct.InterestFrequency <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestCalculationFrequencyIsInvalid);
         
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
