using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Manager;

namespace OpenCBS.Services
{
    public class RWAPercentageService
    {
        private readonly  RWAPercentageManager _RWAPercentageManager;
        private User _user;

        public RWAPercentageService(RWAPercentageManager RWAPercentageManager)
		{
            _RWAPercentageManager = RWAPercentageManager;
		}

        public RWAPercentageService(User user)
		{
            _user = user;
            _RWAPercentageManager = new RWAPercentageManager(user);
		}

        public double FetchRWAPercentage(string RWA)
        {
            return _RWAPercentageManager.FetchRWAPercentage(RWA);
        }

        public int SaveRWAPercentage(RWAPercentage RWAPercentage)
        {
            return _RWAPercentageManager.SaveRWAPercentage(RWAPercentage);
        }

        public int UpdateRWAPercentage(RWAPercentage RWAPercentage)
        {
            ValidateProduct(RWAPercentage);
            return _RWAPercentageManager.UpdateRWAPercentage(RWAPercentage);
        }

        private void ValidateProduct(RWAPercentage rwaPercentage)
        {

            if (!rwaPercentage.Contractrelatedtransaction.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAContractRelatedTransactionIsEmpty);


            if (rwaPercentage.Contractrelatedtransaction < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAContractRelatedTransactionIsLessThanZero);


            if (rwaPercentage.Contractrelatedtransaction > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAContractRelatedTransactionIsGreaterThanHundred);



            if (!rwaPercentage.Bidbond.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWABidBondIsEmpty);


            if (rwaPercentage.Bidbond < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWABidBondIsLessThanZero);


            if (rwaPercentage.Bidbond > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWABidBondIsGreaterThanHundred);





            if (!rwaPercentage.Performancebond.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAPerformanceBondIsEmpty);


            if (rwaPercentage.Performancebond < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAPerformanceBondIsLessThanZero);


            if (rwaPercentage.Performancebond > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAPerformanceBondIsGreaterThanHundred);




            if (!rwaPercentage.Financialguarantee.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAFinancialGuaranteeIsEmpty);


            if (rwaPercentage.Financialguarantee < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAFinancialGuaranteeIsLessThanZero);


            if (rwaPercentage.Financialguarantee > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAFinancialGuaranteeIsGreaterThanHundred);



            if (!rwaPercentage.Letterofcredit.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWALetterOfCreditIsEmpty);


            if (rwaPercentage.Letterofcredit < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWALetterOfCreditIsLessThanZero);


            if (rwaPercentage.Letterofcredit > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWALetterOfCreditIsGreaterThanHundred);



            if (!rwaPercentage.Mortgageloan.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAMortgageLoanIsEmpty);


            if (rwaPercentage.Mortgageloan < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAMortgageLoanIsLessThanZero);


            if (rwaPercentage.Mortgageloan > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAMortgageLoanIsGreaterThanHundred);


            if (!rwaPercentage.Otherloans.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAOtherLoansIsEmpty);


            if (rwaPercentage.Otherloans < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAOtherLoansIsLessThanZero);


            if (rwaPercentage.Otherloans > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAOtherLoansIsGreaterThanHundred);


            if (!rwaPercentage.GovernmentLoans.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAGovernmentLoansIsEmpty);


            if (rwaPercentage.GovernmentLoans < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAGovernmentLoansIsLessThanZero);


            if (rwaPercentage.GovernmentLoans > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWAGovernmentLoansIsGreaterThanHundred);




            if (!rwaPercentage.Cash.HasValue)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWACashIsEmpty);


            if (rwaPercentage.Cash < 0)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWACashIsLessThanZero);


            if (rwaPercentage.Cash > 100)
                throw new OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum.DefineRWACashIsGreaterThanHundred);
        }
    }
}
