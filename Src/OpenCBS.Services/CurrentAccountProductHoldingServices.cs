using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.ExceptionsHandler;

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

       public string SaveCurrentAccountPoductHolding(CurrentAccountProductHoldings currentAccountProductHoldings)
       {
           ValidateProduct(currentAccountProductHoldings, currentAccountProductHoldings.CurrentAccountProduct);
           return _currentAccountProductHoldingManager.SaveCurrentAccountPoductHolding(currentAccountProductHoldings);
       }


       void ValidateProduct(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (productHolding.CurrentAccountProduct == null)
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHCurrentAccountProductIsBlank);

           if (productHolding.CurrentAccountProduct.Id == 0)
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHCurrentAccountProductIsBlank);

           if (!productHolding.InitialAmount.HasValue)
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHInitialAmountIsEmpty);

           if (!ServicesHelper.CheckIfValueBetweenMinAndMax(product.InitialAmountMin,
                                                                  product.InitialAmountMax,
                                                                  productHolding.InitialAmount))
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHInitialAmountIsInvalid);

           if (!productHolding.InterestRate.HasValue)
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestRateIsEmpty);


           if (!IsInterestRateCorrect(productHolding, product))
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHInterestRateIsInvalid);

           if (!productHolding.InterestCalculationFrequency.HasValue)
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestCalculationFrequencyIsEmpty);

           if (productHolding.InterestCalculationFrequency <= 0)
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.InterestCalculationFrequencyIsInvalid);

           if (string.IsNullOrEmpty(productHolding.Comment))
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHCommentIsEmpty);


           if (productHolding.InitialAmountPaymentMethod != "Cash")
           {
               if (string.IsNullOrEmpty(productHolding.InitialAmountAccountNumber))
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHInitialAmountAccountNumberIsBlank);
           }

           if (!productHolding.EntryFees.HasValue)
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHEntryFeeIsEmpty);

           if(!IsEntryFessCorrect(productHolding, product))
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHEntryFeeIsInvalid);

           if (!productHolding.ManagementFees.HasValue)
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHManagementFeeIsEmpty);

           if (!IsManagementFessCorrect(productHolding, product))
               throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHManagementFeeIsInvalid);

           if (productHolding.Status == "Closed")
           {
               if (!productHolding.ClosingFees.HasValue)
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHCloseFeeIsEmpty);

               if (!IsManagementFessCorrect(productHolding, product))
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHCloseFeeIsInvalid);

               if (string.IsNullOrEmpty(productHolding.FinalAmountPaymentMethod))
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHFinalAmountPaymentMethodIsBlank);

               if (productHolding.FinalAmountPaymentMethod != "Cash")
               {
                   if (string.IsNullOrEmpty(productHolding.FinalAmountAccountNumber))
                       throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHFinalAmountAccountNumberIsBlank);
               }
           }

           if (productHolding.Status == "Reopened")
           {
               if (!productHolding.ReopenFees.HasValue)
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHReopenFeeIsEmpty);

               if (!IsReopenFessCorrect(productHolding, product))
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHReopenFeeIsInvalid);
           }

           if (productHolding.OverdraftApplied == 1)
           {
               if (!productHolding.OverdraftLimit.HasValue)
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftLimitIsEmpty);

               if (productHolding.OverdraftLimit <= 0)
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftLimitIsInvalid);

               if (!productHolding.OverdraftFees.HasValue)
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHFixedOverdraftFeeIsEmpty);

               if (!IsOverdraftFixedFessCorrect(productHolding, product))
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHFixedOverdraftFeeIsInvalid);

               if (!productHolding.OverdraftInterest.HasValue)
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftInterestRateIsEmpty);

               if (!IsOverdraftInterestRateCorrect(productHolding, product))
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftInterestRateIsInvalid);

               if (!productHolding.OverdraftCommitmentFee.HasValue)
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftCommitmentFeeIsEmpty);

               if (!IsOverdraftCommitmentFeesCorrect(productHolding, product))
                   throw new OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftCommitmentFeeIsInvalid);

             }


       }


       private static bool IsInterestRateCorrect(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (product.InterestValue.HasValue)
           {
               return productHolding.InterestRate == product.InterestValue;
           }
           else
           {
               return ServicesHelper.CheckIfValueBetweenMinAndMax(product.InterestMin,
                                                                   product.InterestMax,
                                                                   productHolding.InterestRate);
           }

       }


       private static bool IsEntryFessCorrect(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (product.EntryFeesValue.HasValue)
           {
               return productHolding.EntryFees == product.EntryFeesValue;
           }
           else
           {
               return ServicesHelper.CheckIfValueBetweenMinAndMax(product.EntryFeesMin,
                                                                   product.EntryFeesMax,
                                                                   productHolding.EntryFees);
           }

       }

       private static bool IsManagementFessCorrect(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (product.ManagementFeesValue.HasValue)
           {
               return productHolding.ManagementFees == product.ManagementFeesValue;
           }
           else
           {
               return ServicesHelper.CheckIfValueBetweenMinAndMax(product.ManagementFeesMin,
                                                                   product.ManagementFeesMax,
                                                                   productHolding.ManagementFees);
           }

       }

       private static bool IsCloseFessCorrect(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (product.ClosingFeesValue.HasValue)
           {
               return productHolding.ClosingFees == product.ClosingFeesValue;
           }
           else
           {
               return ServicesHelper.CheckIfValueBetweenMinAndMax(product.ClosingFeesMin,
                                                                   product.ClosingFeesMax,
                                                                   productHolding.ClosingFees);
           }

       }

       private static bool IsReopenFessCorrect(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (product.ReopenFeesValue.HasValue)
           {
               return productHolding.ReopenFees == product.ReopenFeesValue;
           }
           else
           {
               return ServicesHelper.CheckIfValueBetweenMinAndMax(product.ReopenFeesMin,
                                                                   product.ReopenFeesMax,
                                                                   productHolding.ReopenFees);
           }

       }

       private static bool IsOverdraftFixedFessCorrect(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (product.OverdraftValue.HasValue)
           {
               return productHolding.OverdraftFees == product.OverdraftValue;
           }
           else
           {
               return ServicesHelper.CheckIfValueBetweenMinAndMax(product.OverdraftMin,
                                                                   product.OverdraftMax,
                                                                   productHolding.OverdraftFees);
           }

       }


       private static bool IsOverdraftInterestRateCorrect(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (product.OverdraftInterestValue.HasValue)
           {
               return productHolding.OverdraftInterest == product.OverdraftInterestValue;
           }
           else
           {
               return ServicesHelper.CheckIfValueBetweenMinAndMax(product.OverdraftInterestMin,
                                                                   product.OverdraftInterestMax,
                                                                   productHolding.OverdraftInterest);
           }

       }

       private static bool IsOverdraftCommitmentFeesCorrect(CurrentAccountProductHoldings productHolding, CurrentAccountProduct product)
       {
           if (product.CommitmentFeeValue.HasValue)
           {
               return productHolding.OverdraftCommitmentFee == product.CommitmentFeeValue;
           }
           else
           {
               return ServicesHelper.CheckIfValueBetweenMinAndMax(product.CommitmentFeeMin,
                                                                   product.CommitmentFeeMax,
                                                                   productHolding.OverdraftCommitmentFee);
           }

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
            ValidateProduct(product, product.CurrentAccountProduct);
          _currentAccountProductHoldingManager.UpdateCurrentAccountProductHolding(product, productId);
        }

        public void UpdateCurrentAccountProductHolding(CurrentAccountProductHoldings product, string contractCode)
        {
            ValidateProduct(product, product.CurrentAccountProduct);
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
