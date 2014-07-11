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
    public class FixedDepositProductService
    {
        private readonly FixedDepositProductManager _fixedDepositProductManager;
        private User _user;

        public FixedDepositProductService(FixedDepositProductManager fixedDepositProductManager)
		{
            _fixedDepositProductManager = fixedDepositProductManager;
		}

        public FixedDepositProductService(User user)
		{
            _user = user;
            _fixedDepositProductManager = new FixedDepositProductManager(user);
		}

        public int SaveFixedDepositProduct(IFixedDepositProduct fixedDepositProduct)
        {

            ValidateProduct(fixedDepositProduct);

            bool name = _fixedDepositProductManager.CheckForDuplicateValue("FixedDepositProducts", "product_name", fixedDepositProduct.Name);
            bool code =_fixedDepositProductManager.CheckForDuplicateValue("FixedDepositProducts", "product_code", fixedDepositProduct.Code);
           return  _fixedDepositProductManager.SaveFixedDepositProduct(fixedDepositProduct);
            

        }

        public int GetProductId(string productName, string productCode)
        {
            return _fixedDepositProductManager.GetProductId(productName, productCode);
        }

        public IFixedDepositProduct FetchProduct(int productId)
        {
            return _fixedDepositProductManager.FetchProduct(productId);
        }
         public void UpdateFixedDepositProduct(IFixedDepositProduct product,int productId)
         {
             _fixedDepositProductManager.UpdateFixedDepositProduct(product, productId);
         }
         public List<IFixedDepositProduct> FetchProduct(bool showAlsoDeleted)
         {
             return _fixedDepositProductManager.FetchProduct(showAlsoDeleted);
         }

         public IFixedDepositProduct FetchProduct(string productName, string productCode)
         {
             return _fixedDepositProductManager.FetchProduct( productName, productCode);
         }

        public void DeleteFixedDepositProduct(int pProductId)
        {
            _fixedDepositProductManager.DeleteFixedDepositProduct(pProductId);
        }

        private void ValidateProduct(IFixedDepositProduct fixedDepositProduct)
        {

            if (string.IsNullOrEmpty(fixedDepositProduct.Name))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductNameIsBlank);

            if (fixedDepositProduct.Name.Length < 3)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductNameIsLessThanThree);

            if (string.IsNullOrEmpty(fixedDepositProduct.Code))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductCodeIsBlank);

            if (fixedDepositProduct.Code.Length < 6)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductCodeLessThanThree);

            if (fixedDepositProduct.ClientType == "")
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHClientTypeIsEmpty);

            if (fixedDepositProduct.Currency.Name == "" && fixedDepositProduct.Currency.Name == OCurrentAccount.SelectCurrencyDefault)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHCurrencyIsBlank);

            if (!fixedDepositProduct.InitialAmountMin.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMinIsEmpty);


            if (!fixedDepositProduct.InitialAmountMax.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMaxIsEmpty);

            if (fixedDepositProduct.InitialAmountMin < 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountIsInvalid);

            if (fixedDepositProduct.InitialAmountMax <= 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMaxIsInvalid);

            if (fixedDepositProduct.InitialAmountMax <= fixedDepositProduct.InitialAmountMin)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMinMaxIsInvalid);

            if (!fixedDepositProduct.InterestRateMin.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMinIsEmpty);

            if (!fixedDepositProduct.InterestRateMax.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMaxIsEmpty);

            if (fixedDepositProduct.InterestRateMin < 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMinIsInvalid);

            if (fixedDepositProduct.InterestRateMax <= 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMaxIsInvalid);

            if (fixedDepositProduct.InterestRateMax <= fixedDepositProduct.InterestRateMin)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMinMaxIsInvalid);
         
   
            if (!fixedDepositProduct.MaturityPeriodMin.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMinIsEmpty);

            if (!fixedDepositProduct.MaturityPeriodMax.HasValue)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMaxIsEmpty);

            if (fixedDepositProduct.MaturityPeriodMin < 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMinIsInvalid);

            if (fixedDepositProduct.MaturityPeriodMax <= 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMaxIsInvalid);

            //if (fixedDepositProduct.MaturityPeriodMax <= fixedDepositProduct.MaturityPeriodMin)
            //    throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMinMaxIsInvalid);


            if (string.IsNullOrEmpty(fixedDepositProduct.InterestCalculationFrequency))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestCalculationFrequencyIsEmpty);

            if (Convert.ToInt32(fixedDepositProduct.InterestCalculationFrequency) <= 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHInterestCalculationFrequencyIsInvalid);


            if (fixedDepositProduct.PenalityRateMin.HasValue && fixedDepositProduct.PenalityRateMin < 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHPenaltyIsInvalid);

            if (fixedDepositProduct.PenalityRateMax.HasValue && fixedDepositProduct.PenalityRateMax <= 0)
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHPenaltyIsInvalid);

            if (!ServicesHelper.CheckMinMaxAndValueCorrectlyFilled(fixedDepositProduct.PenalityRateMin, fixedDepositProduct.PenalityRateMax, fixedDepositProduct.PenalityValue))
                throw new OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum.FDPHPenaltyMinMaxIsInvalid);
        }

    }
}
