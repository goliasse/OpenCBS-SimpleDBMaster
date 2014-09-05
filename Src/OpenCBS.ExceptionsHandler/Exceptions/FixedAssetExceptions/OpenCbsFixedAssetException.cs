using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsFixedAssetException : OpenCbsException
    {
        private readonly string _message;
        private OpenCbsFixedAssetExceptionEnum _code;
        public OpenCbsFixedAssetExceptionEnum Code { get { return _code; } }

        protected OpenCbsFixedAssetException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsFixedAssetExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsFixedAssetException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsFixedAssetExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsFixedAssetException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsFixedAssetException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsFixedAssetExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterBranchIsNotSelected:
                    returned = "FixedAssetRegisterBranchIsNotSelected";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAssetDescriptionIsEmpty:
                    returned = "FixedAssetRegisterAssetDescriptionIsEmpty";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAssetTypeIsNotSelected:
                    returned = "FixedAssetRegisterAssetTypeIsNotSelected";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterNoOfAssetsIsEmpty:
                    returned = "FixedAssetRegisterNoOfAssetsIsEmpty";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterNoOfAssetsIsInvalid:
                    returned = "FixedAssetRegisterNoOfAssetsIsInvalid";
                    break;

                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterOriginalCostIsEmpty:
                    returned = "FixedAssetRegisterOriginalCostIsEmpty";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterOriginalCostIsInvalid:
                    returned = "FixedAssetRegisterOriginalCostIsInvalid";
                    break;

                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAnnualDepreciationRateIsEmpty:
                    returned = "FixedAssetRegisterAnnualDepreciationRateIsEmpty";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAnnualDepreciationRateIsInvalid:
                    returned = "FixedAssetRegisterAnnualDepreciationRateIsInvalid";
                    break;



                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAcquisitionCapitalFinanceMethodIsNotSelected:
                    returned = "FixedAssetRegisterAcquisitionCapitalFinanceMethodIsNotSelected";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAcquisitionCapitalTransactionIsEmpty:
                    returned = "FixedAssetRegisterAcquisitionCapitalTransactionIsEmpty";
                    break;

                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAcquisitionCapitalTransactionIsInvalid:
                    returned = "FixedAssetRegisterAcquisitionCapitalTransactionIsInvalid";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterDisposalAmountTransferMethodIsNotSelected:
                    returned = "FixedAssetRegisterDisposalAmountTransferMethodIsNotSelected";
                    break;

                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterDisposalAmountTransactionIsEmpty:
                    returned = "FixedAssetRegisterDisposalAmountTransactionIsEmpty";
                    break;
                case OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterDisposalAmountTransactionIsInvalid:
                    returned = "FixedAssetRegisterDisposalAmountTransactionIsInvalid";
                    break;


            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsFixedAssetExceptionEnum
    {

        FixedAssetRegisterBranchIsNotSelected,
        FixedAssetRegisterAssetDescriptionIsEmpty,
        FixedAssetRegisterAssetTypeIsNotSelected,
        FixedAssetRegisterNoOfAssetsIsEmpty,
        FixedAssetRegisterNoOfAssetsIsInvalid,
        FixedAssetRegisterOriginalCostIsEmpty,
        FixedAssetRegisterOriginalCostIsInvalid,
        FixedAssetRegisterAnnualDepreciationRateIsEmpty,
        FixedAssetRegisterAnnualDepreciationRateIsInvalid,
        FixedAssetRegisterAcquisitionCapitalFinanceMethodIsNotSelected,
        FixedAssetRegisterAcquisitionCapitalTransactionIsEmpty,
        FixedAssetRegisterAcquisitionCapitalTransactionIsInvalid,
        FixedAssetRegisterDisposalAmountTransferMethodIsNotSelected,
        FixedAssetRegisterDisposalAmountTransactionIsEmpty,
        FixedAssetRegisterDisposalAmountTransactionIsInvalid

    }
}