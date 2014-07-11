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
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CodeIsLessThanThree);

            if (currentAccountProduct.ClientType == "")
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OneCheckBoxMustBeSeleted);

            if (currentAccountProduct.Currency.Name == "" && currentAccountProduct.Currency.Name == OCurrentAccount.SelectCurrencyDefault)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.SelectCurrencySelected);

            if (currentAccountProduct.InitialAmountMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InitialAmountMinIsInvalid);
           
            if (currentAccountProduct.InitialAmountMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InitialAmountMaxIsInvalid);

            if (currentAccountProduct.InitialAmountMax <= currentAccountProduct.InitialAmountMin)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InitialAmountMinMaxIsInvalid);

            //Initial amount min and max not be blank
            if (!currentAccountProduct.InitialAmountMin.HasValue)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InitialAmountMinIsEmpty);


            if (!currentAccountProduct.InitialAmountMax.HasValue)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InitialAmountMaxIsEmpty);

            

            if (currentAccountProduct.BalanceMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.BalanceMinIsInvalid);

            if (currentAccountProduct.BalanceMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.BalanceMaxIsInvalid);

            if (currentAccountProduct.BalanceMax <= currentAccountProduct.BalanceMin)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.BalanceMinMaxIsInvalid);

            //Balance amount min and max not be blank

            if (!currentAccountProduct.BalanceMax.HasValue)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.BalanceMaxIsEmpty);

            if (!currentAccountProduct.BalanceMin.HasValue)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.BalanceMinIsEmpty);

            //Initial amount min can not be less than balance min
            //Initial amount max can not be greater than balance max

            if (currentAccountProduct.InitialAmountMin < currentAccountProduct.BalanceMin)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPInitialAmountMinLessThanBalanceMin);

            if (currentAccountProduct.InitialAmountMax > currentAccountProduct.BalanceMax)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPInitialAmountMaxLessThanBalanceMax);

            if (currentAccountProduct.InterestMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestMinIsInvalid);

            if (currentAccountProduct.InterestMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestMaxIsInvalid);

            if (currentAccountProduct.InterestMax <= currentAccountProduct.InterestMin)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestMinMaxIsInvalid);


            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.InterestMin, currentAccountProduct.InterestMax, currentAccountProduct.InterestValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestMinMaxIsInvalid);


            if (currentAccountProduct.OverdraftMin.HasValue && currentAccountProduct.OverdraftMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMinIsInvalid);

            if (currentAccountProduct.OverdraftMax.HasValue && currentAccountProduct.OverdraftMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMaxIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.OverdraftMin, currentAccountProduct.OverdraftMax, currentAccountProduct.OverdraftValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMinMaxIsInvalid);
            
            //InterestCalculationFrequency can not be blank

            if (!currentAccountProduct.InterestFrequency.HasValue)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestCalculationFrequencyIsEmpty);

            if (currentAccountProduct.InterestFrequency.HasValue && currentAccountProduct.InterestFrequency <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestCalculationFrequencyIsInvalid);


            

            if (currentAccountProduct.EntryFeesMin.HasValue && currentAccountProduct.EntryFeesMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.EntryFeesMinIsInvalid);

            if (currentAccountProduct.EntryFeesMax.HasValue && currentAccountProduct.EntryFeesMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.EntryFeesMaxIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.EntryFeesMin, currentAccountProduct.EntryFeesMax, currentAccountProduct.EntryFeesValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.EntryFeesMinMaxIsInvalid);


            if (currentAccountProduct.ReopenFeesMin.HasValue && currentAccountProduct.ReopenFeesMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.ReopenFeesMinIsInvalid);

            if (currentAccountProduct.ReopenFeesMax.HasValue && currentAccountProduct.ReopenFeesMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.ReopenFeesMaxIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.ReopenFeesMin, currentAccountProduct.ReopenFeesMax, currentAccountProduct.ReopenFeesValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.ReopenFeesMinMaxIsInvalid);


            if (currentAccountProduct.ClosingFeesMin.HasValue && currentAccountProduct.ClosingFeesMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CloseFeesMinIsInvalid);

            if (currentAccountProduct.ClosingFeesMax.HasValue && currentAccountProduct.ClosingFeesMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CloseFeesMaxIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.ClosingFeesMin, currentAccountProduct.ClosingFeesMax, currentAccountProduct.ClosingFeesValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CloseFeesMinMaxIsInvalid);


            if (currentAccountProduct.ManagementFeesMin.HasValue && currentAccountProduct.ManagementFeesMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.ManagementFeesMinIsInvalid);

            if (currentAccountProduct.ManagementFeesMax.HasValue && currentAccountProduct.ManagementFeesMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.ManagementFeesMaxIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.ManagementFeesMin, currentAccountProduct.ManagementFeesMax, currentAccountProduct.ManagementFeesValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.ManagementFeesMinMaxIsInvalid);

            if (currentAccountProduct.ManagementFeesFrequency == "" && currentAccountProduct.ManagementFeesFrequency == OCurrentAccount.SelectFrequencyDefault)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.ManagementFeeFrequencyIsEmpty);


            if (currentAccountProduct.OverdraftInterestMin.HasValue && currentAccountProduct.OverdraftInterestMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftInterestRateMinIsInvalid);

            if (currentAccountProduct.OverdraftInterestMax.HasValue && currentAccountProduct.OverdraftInterestMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftInterestRateMaxIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.OverdraftInterestMin, currentAccountProduct.OverdraftInterestMax, currentAccountProduct.OverdraftInterestValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftInterestRateMinMaxIsInvalid);

            if (currentAccountProduct.CommitmentFeeMin.HasValue && currentAccountProduct.CommitmentFeeMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CommitmentFeesMinIsInvalid);

            if (currentAccountProduct.CommitmentFeeMax.HasValue && currentAccountProduct.CommitmentFeeMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CommitmentFeesMaxIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.CommitmentFeeMin, currentAccountProduct.CommitmentFeeMax, currentAccountProduct.CommitmentFeeValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CommitmentFeesMinMaxIsInvalid);


            if (currentAccountProduct.OverdraftLimitMin.HasValue && currentAccountProduct.OverdraftLimitMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftLimitMinIsInvalid);

            if (currentAccountProduct.OverdraftLimitMax.HasValue && currentAccountProduct.OverdraftLimitMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftLimitMaxIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(currentAccountProduct.OverdraftLimitMin, currentAccountProduct.OverdraftLimitMax, currentAccountProduct.OverdraftValue))
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.OverdraftLimitMinMaxIsInvalid);



        }



        void ValidateCurrentAccountTransactionFee(CurrentAccountTransactionFees currentAccountTransactionFees)
        {

            if (currentAccountTransactionFees.TransactionFeesType == "" && currentAccountTransactionFees.TransactionFeesType == OCurrentAccount.SelectPaymentMethodDefault)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.TransactionTypeIsEmpty);

            if (currentAccountTransactionFees.TransactionFeeMin.HasValue && currentAccountTransactionFees.TransactionFeeMin < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.TransactionMinIsInvalid);

            if (currentAccountTransactionFees.TransactionFeeMax.HasValue && currentAccountTransactionFees.TransactionFeeMax <= 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.TransactionMaxIsInvalid);

            if (currentAccountTransactionFees.TransactionFees.HasValue && currentAccountTransactionFees.TransactionFees < 0)
                throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.TransactionValueIsLessThanZero);

            //Tramsaction Value can not be blank
            //Transaction max can not be less than Transaction min

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
