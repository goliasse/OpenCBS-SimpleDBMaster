using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsCurrentAcccountTransactionException : OpenCbsException
    {
         private readonly string _message;
        private OpenCbsCurrentAcccountTransactionExceptionEnum _code;
        public OpenCbsCurrentAcccountTransactionExceptionEnum Code { get { return _code; } }

        protected OpenCbsCurrentAcccountTransactionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsCurrentAcccountTransactionExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsCurrentAcccountTransactionException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsCurrentAcccountTransactionExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsCurrentAcccountTransactionException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsCurrentAcccountTransactionException(OpenCbsCurrentAcccountTransactionExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsCurrentAcccountTransactionException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsCurrentAcccountTransactionExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {
                case OpenCbsCurrentAcccountTransactionExceptionEnum.AmountTransferMethodNotSelected:
                    returned = "AmountTransferMethodNotSelected";
                    break;
                case OpenCbsCurrentAcccountTransactionExceptionEnum.FromAccountNotSelected:
                    returned = "SelectFromAccountNotSelected";
                    break;
                case OpenCbsCurrentAcccountTransactionExceptionEnum.ToAccountNotSelected:
                    returned = "SelectToAccountNotSelected";
                    break;
                case OpenCbsCurrentAcccountTransactionExceptionEnum.TransactionMakerNotSelected:
                    returned = "TransactionMakerNotSelected";
                    break;
                case OpenCbsCurrentAcccountTransactionExceptionEnum.TransactionCheckerNotSelected:
                    returned = "TransactionCheckerNotSelected";
                    break;
                case OpenCbsCurrentAcccountTransactionExceptionEnum.ToAndFromAccountIsInvalid:
                    returned = "ToAndFromAccountIsInvalid";
                    break;

                case OpenCbsCurrentAcccountTransactionExceptionEnum.AmountIsInvalid:
                    returned = "AmountIsInvalid";
                    break;

                case OpenCbsCurrentAcccountTransactionExceptionEnum.PurposeOfTransferIsBlank:
                    returned = "PurposeOfTransferIsBlank";
                    break;

                case OpenCbsCurrentAcccountTransactionExceptionEnum.FromAndToAccountIsSame:
                    returned = "FromAndToAccountIsSame";
                    break;

                case OpenCbsCurrentAcccountTransactionExceptionEnum.CATAmountIsBlank:
                    returned = "CATAmountIsBlank";
                    break;

                case OpenCbsCurrentAcccountTransactionExceptionEnum.CATSelectATransactionType:
                    returned = "CATSelectATransactionType";
                    break;

                case OpenCbsCurrentAcccountTransactionExceptionEnum.CATPurposeOfTransferIsBlank:
                    returned = "CATPurposeOfTransferIsBlank";
                    break;

                case OpenCbsCurrentAcccountTransactionExceptionEnum.CATBalanceLessThanMinBalance:
                    returned = "CATBalanceLessThanMinBalance";
                    break;
            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsCurrentAcccountTransactionExceptionEnum
    {
        AmountTransferMethodNotSelected,
        FromAccountNotSelected,
        ToAccountNotSelected,
        TransactionMakerNotSelected,
        TransactionCheckerNotSelected,
        ToAndFromAccountIsInvalid,
        AmountIsInvalid,
        PurposeOfTransferIsBlank,
        FromAndToAccountIsSame,
        CATAmountIsBlank,
        CATSelectATransactionType,
        CATPurposeOfTransferIsBlank,
        CATBalanceLessThanMinBalance

    }
    
}