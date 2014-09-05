using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsRWAPercentageException : OpenCbsException
    {
        private readonly string _message;
        private OpenCbsRWAPercentageExceptionEnum _code;
        public OpenCbsRWAPercentageExceptionEnum Code { get { return _code; } }

        protected OpenCbsRWAPercentageException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsRWAPercentageExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsRWAPercentageException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsRWAPercentageExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsRWAPercentageException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsRWAPercentageException(OpenCbsRWAPercentageExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsRWAPercentageException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsRWAPercentageExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAContractRelatedTransactionIsEmpty:
                    returned = "DefineRWAContractRelatedTransactionIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAContractRelatedTransactionIsLessThanZero:
                    returned = "DefineRWAContractRelatedTransactionIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAContractRelatedTransactionIsGreaterThanHundred:
                    returned = "DefineRWAContractRelatedTransactionIsGreaterThanHundred";
                    break;



                case OpenCbsRWAPercentageExceptionEnum.DefineRWABidBondIsEmpty:
                    returned = "DefineRWABidBondIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWABidBondIsLessThanZero:
                    returned = "DefineRWABidBondIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWABidBondIsGreaterThanHundred:
                    returned = "DefineRWABidBondIsGreaterThanHundred";
                    break;



                case OpenCbsRWAPercentageExceptionEnum.DefineRWAPerformanceBondIsEmpty:
                    returned = "DefineRWAPerformanceBondIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAPerformanceBondIsLessThanZero:
                    returned = "DefineRWAPerformanceBondIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAPerformanceBondIsGreaterThanHundred:
                    returned = "DefineRWAPerformanceBondIsGreaterThanHundred";
                    break;



                case OpenCbsRWAPercentageExceptionEnum.DefineRWAFinancialGuaranteeIsEmpty:
                    returned = "DefineRWAFinancialGuaranteeIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAFinancialGuaranteeIsLessThanZero:
                    returned = "DefineRWAFinancialGuaranteeIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAFinancialGuaranteeIsGreaterThanHundred:
                    returned = "DefineRWAFinancialGuaranteeIsGreaterThanHundred";
                    break;



                case OpenCbsRWAPercentageExceptionEnum.DefineRWALetterOfCreditIsEmpty:
                    returned = "DefineRWALetterOfCreditIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWALetterOfCreditIsLessThanZero:
                    returned = "DefineRWALetterOfCreditIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWALetterOfCreditIsGreaterThanHundred:
                    returned = "DefineRWALetterOfCreditIsGreaterThanHundred";
                    break;


                case OpenCbsRWAPercentageExceptionEnum.DefineRWAMortgageLoanIsEmpty:
                    returned = "DefineRWAMortgageLoanIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAMortgageLoanIsLessThanZero:
                    returned = "DefineRWAMortgageLoanIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAMortgageLoanIsGreaterThanHundred:
                    returned = "DefineRWAMortgageLoanIsGreaterThanHundred";
                    break;



                case OpenCbsRWAPercentageExceptionEnum.DefineRWAOtherLoansIsEmpty:
                    returned = "DefineRWAOtherLoansIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAOtherLoansIsLessThanZero:
                    returned = "DefineRWAOtherLoansIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAOtherLoansIsGreaterThanHundred:
                    returned = "DefineRWAOtherLoansIsGreaterThanHundred";
                    break;




                case OpenCbsRWAPercentageExceptionEnum.DefineRWAGovernmentLoansIsEmpty:
                    returned = "DefineRWAGovernmentLoansIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAGovernmentLoansIsLessThanZero:
                    returned = "DefineRWAGovernmentLoansIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWAGovernmentLoansIsGreaterThanHundred:
                    returned = "DefineRWAGovernmentLoansIsGreaterThanHundred";
                    break;



                case OpenCbsRWAPercentageExceptionEnum.DefineRWACashIsEmpty:
                    returned = "DefineRWACashIsEmpty";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWACashIsLessThanZero:
                    returned = "DefineRWACashIsLessThanZero";
                    break;
                case OpenCbsRWAPercentageExceptionEnum.DefineRWACashIsGreaterThanHundred:
                    returned = "DefineRWACashIsGreaterThanHundred";
                    break; 
            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsRWAPercentageExceptionEnum
    {

        DefineRWAContractRelatedTransactionIsEmpty,
        DefineRWAContractRelatedTransactionIsLessThanZero,
        DefineRWAContractRelatedTransactionIsGreaterThanHundred,
        DefineRWABidBondIsEmpty,
        DefineRWABidBondIsLessThanZero,
        DefineRWABidBondIsGreaterThanHundred,
        DefineRWAPerformanceBondIsEmpty,
        DefineRWAPerformanceBondIsLessThanZero,
        DefineRWAPerformanceBondIsGreaterThanHundred,
        DefineRWAFinancialGuaranteeIsEmpty,
        DefineRWAFinancialGuaranteeIsLessThanZero,
        DefineRWAFinancialGuaranteeIsGreaterThanHundred,
        DefineRWALetterOfCreditIsEmpty,
        DefineRWALetterOfCreditIsLessThanZero,
        DefineRWALetterOfCreditIsGreaterThanHundred,
        DefineRWAMortgageLoanIsEmpty,
        DefineRWAMortgageLoanIsLessThanZero,
        DefineRWAMortgageLoanIsGreaterThanHundred,
        DefineRWAOtherLoansIsEmpty,
        DefineRWAOtherLoansIsLessThanZero,
        DefineRWAOtherLoansIsGreaterThanHundred,
        DefineRWAGovernmentLoansIsEmpty,
        DefineRWAGovernmentLoansIsLessThanZero,
        DefineRWAGovernmentLoansIsGreaterThanHundred,
        DefineRWACashIsEmpty,
        DefineRWACashIsLessThanZero,
        DefineRWACashIsGreaterThanHundred


    }
}
