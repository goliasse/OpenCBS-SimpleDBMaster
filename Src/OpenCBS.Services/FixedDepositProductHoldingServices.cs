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
            _fixedDepositProductHoldingManager.UpdateFixedDepositProductHolding(product, productContractCode);
        }

        public FixedDepositInterest CalculateFinalAmount(string fdContractCode)
        {
            return _fixedDepositProductHoldingManager.CalculateFinalAmount(fdContractCode);
        }

        private void ValidateProduct(FixedDepositProductHoldings fixedDepositProductHolding, IFixedDepositProduct fixedDepositProduct)
        {

            if (fixedDepositProductHolding.FixedDepositProduct == null)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductIsBlank);

            if (fixedDepositProductHolding.FixedDepositProduct.Id == 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductIsBlank);

            if (!fixedDepositProductHolding.InitialAmount.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountIsEmpty);

            if (ServicesHelper.CheckIfValueBetweenMinAndMax(fixedDepositProduct.InitialAmountMin,
                                                                   fixedDepositProduct.InitialAmountMax,
                                                                   fixedDepositProductHolding.InitialAmount))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMinMaxIsInvalid);

            if (!fixedDepositProductHolding.InterestRate.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateIsEmpty);


            if (ServicesHelper.CheckIfValueBetweenMinAndMax(fixedDepositProduct.InterestRateMin,
                                                                   fixedDepositProduct.InterestRateMax,
                                                                   fixedDepositProductHolding.InterestRate))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMinMaxIsInvalid);

            if (!fixedDepositProductHolding.MaturityPeriod.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodIsEmpty);

            if (CheckIfValueBetweenMinAndMax(fixedDepositProduct.MaturityPeriodMin,
                                                                   fixedDepositProduct.MaturityPeriodMax,
                                                                   fixedDepositProductHolding.MaturityPeriod))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodIsInvalid);

            
            if(IsPenaltyCorrect(fixedDepositProductHolding, fixedDepositProduct))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHPenaltyMinMaxIsInvalid);
            



            

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



    }
}
