using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Shared;

namespace OpenCBS.Services
{
    public class FixedDepositProductHoldingServices
    {

        private readonly FixedDepositProductHoldingManager _fixedDepositProductHoldingManager;
        private User _user;

        public FixedDepositProductHoldingServices(FixedDepositProductHoldingManager fixedDepositProductManager)
		{
            _fixedDepositProductHoldingManager = fixedDepositProductManager;
		}

        public FixedDepositProductHoldingServices(User user)
		{
            _user = user;
            _fixedDepositProductHoldingManager = new FixedDepositProductHoldingManager(user);
		}

        public string SaveFixedDepositProductHolding(FixedDepositProductHoldings fixedDepositProductHolding)
        {

           

            ValidateProduct(fixedDepositProductHolding, fixedDepositProductHolding.FixedDepositProduct);
            return _fixedDepositProductHoldingManager.SaveFixedDepositProductHolding(fixedDepositProductHolding);
            

        }

        public void UpdateFixedDepositProductHolding(FixedDepositProductHoldings product, int productId)
        {
            ValidateProduct(product, product.FixedDepositProduct);
            _fixedDepositProductHoldingManager.UpdateFixedDepositProductHolding(product, productId);
        }
        public FixedDepositProductHoldings FetchProduct(int productId)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(productId);
        }
        
        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoClosed)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(showAlsoClosed);
        }

        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoClosed,int clientId,string clientType)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(showAlsoClosed,clientId,clientType);
        }

        public FixedDepositProductHoldings FetchProduct(string productContractCode)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(productContractCode);
        }

        public void UpdateFixedDepositProductHolding(FixedDepositProductHoldings product, string productContractCode)
        {
            ValidateProduct(product, product.FixedDepositProduct);
            _fixedDepositProductHoldingManager.UpdateFixedDepositProductHolding(product, productContractCode);
        }

        public FixedDepositInterest CalculateFinalAmount(string fdContractCode)
        {
            return _fixedDepositProductHoldingManager.CalculateFinalAmount(fdContractCode);
        }

        private void ValidateProduct(FixedDepositProductHoldings productHolding, IFixedDepositProduct product)
        {

            if (productHolding.FixedDepositProduct == null)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductIsBlank);

            if (productHolding.FixedDepositProduct.Id == 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductIsBlank);

            if (!productHolding.InitialAmount.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountIsEmpty);

            if (!ServicesHelper.CheckIfValueBetweenMinAndMax(product.InitialAmountMin,
                                                                   product.InitialAmountMax,
                                                                   productHolding.InitialAmount))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountIsInvalid);

            if (!productHolding.InterestRate.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateIsEmpty);


            if (!ServicesHelper.CheckIfValueBetweenMinAndMax(product.InterestRateMin,
                                                                   product.InterestRateMax,
                                                                   productHolding.InterestRate))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateIsInvalid);

            if (!productHolding.MaturityPeriod.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodIsEmpty);

            if (!CheckIfValueBetweenMinAndMax(product.MaturityPeriodMin,
                                                                   product.MaturityPeriodMax,
                                                                   productHolding.MaturityPeriod))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodIsInvalid);


            if (string.IsNullOrEmpty(productHolding.InterestCalculationFrequency))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestCalculationFrequencyIsEmpty);

            if (Convert.ToInt32(productHolding.InterestCalculationFrequency) <= 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestCalculationFrequencyIsInvalid);

            if (!IsPenaltyCorrect(productHolding, product))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHPenaltyIsInvalid);


            if(!IsPenaltyCorrect(productHolding, product))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHPenaltyIsInvalid);
            

            if (string.IsNullOrEmpty(productHolding.Comment))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHCommentIsBlank);

            if (string.IsNullOrEmpty(productHolding.InitialAmountPaymentMethod))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountPaymentMethodIsBlank);

            if (productHolding.InitialAmountPaymentMethod != "Cash")
            {
                if (string.IsNullOrEmpty(productHolding.InitialAmountChequeAccount))
                    throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountAccountNumberIsBlank);
            }

            if (productHolding.Status == "Closed")
            {

                if (string.IsNullOrEmpty(productHolding.FinalAmountPaymentMethod))
                    throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFinalAmountPaymentMethodIsBlank);

                if (productHolding.FinalAmountPaymentMethod != "Cash")
                {
                    if (string.IsNullOrEmpty(productHolding.FinalAmountChequeAccount))
                        throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFinalAmountAccountNumberIsBlank);
                }

            }

        }

        public static bool CheckIfValueBetweenMinAndMax(OCurrency min, OCurrency max, OCurrency number)
        {
            bool result = false;
            if (number <= max && number >= min) result = true;
            return result;
        }

        private static bool IsPenaltyCorrect(FixedDepositProductHoldings fixedDepositProductHolding, IFixedDepositProduct fixedDepositProduct)
        {
            if (fixedDepositProduct.PenalityValue.HasValue)
            {
                return fixedDepositProduct.PenalityValue == fixedDepositProductHolding.Penality;
            }
            else
            {
                return ServicesHelper.CheckIfValueBetweenMinAndMax(fixedDepositProduct.PenalityRateMin,
                                                                    fixedDepositProduct.PenalityRateMax,
                                                                    fixedDepositProductHolding.Penality);
            }
            
        }


        private static bool ValidateMinMaxValue(OCurrency min, OCurrency max, OCurrency value)
        {
            if (((min.HasValue) && (max.HasValue)) || (!value.HasValue))
                return false;
            else if (((!min.HasValue) && (!max.HasValue)) || (value.HasValue))
                return false;

            return true;

        }


        public void TransferFinalAmount(FixedDepositProductHoldings productHolding)
        {
            _fixedDepositProductHoldingManager.TransferFinalAmount(productHolding);
        }



    }
}
