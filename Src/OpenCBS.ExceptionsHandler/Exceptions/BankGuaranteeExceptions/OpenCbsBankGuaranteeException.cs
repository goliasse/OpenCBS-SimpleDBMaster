using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler.Exceptions.BankGuaranteeExceptions
{
    public class OpenCbsBankGuaranteeException : OpenCbsException
    {

        private readonly string _message;
        private OpenCbsBankGuaranteesExceptionEnum _code;
        public OpenCbsBankGuaranteesExceptionEnum Code { get { return _code; } }

        protected OpenCbsBankGuaranteeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsBankGuaranteesExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsBankGuaranteeException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsBankGuaranteesExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsBankGuaranteeException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsBankGuaranteeException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsBankGuaranteesExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {
                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesIssuingDateIsEmpty:
                    returned = "BankGuaranteesIssuingDateIsEmpty";
                    break;
                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesIssuingDateIsInvalid:
                    returned = "BankGuaranteesIssuingDateIsInvalid";
                    break;


                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesExpiryDateIsEmpty:
                    returned = "BankGuaranteesExpiryDateIsEmpty";
                    break;
                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesBeneficiaryPartyIsEmpty:
                    returned = "BankGuaranteesBeneficiaryPartyIsEmpty";
                    break;
                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesInstrumentDetailsIsEmpty:
                    returned = "BankGuaranteesInstrumentDetailsIsEmpty";
                    break;


                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesValueIsEmpty:
                    returned = "BankGuaranteesValueIsEmpty";
                    break;
                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesValueIsInvalid:
                    returned = "BankGuaranteesValueIsInvalid";
                    break;

                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesCurrencyIsEmpty:
                    returned = "BankGuaranteesCurrencyIsEmpty";
                    break;


                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesStatusIsDefault:
                    returned = "BankGuaranteesStatusIsDefault";
                    break;

                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesGuarnteeTypeIsDefault:
                    returned = "BankGuaranteesGuarnteeTypeIsDefault";
                    break;


                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesFeePerPeriodIsEmpty:
                    returned = "BankGuaranteesFeePerPeriodIsEmpty";
                    break;
                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesFeePerPeriodIsInvalid:
                    returned = "BankGuaranteesFeePerPeriodIsInvalid";
                    break;

                case OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesFeePeriodIsDefault:
                    returned = "BankGuaranteesFeePeriodIsDefault";
                    break;

            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsBankGuaranteesExceptionEnum
    {
        BankGuaranteesIssuingDateIsEmpty,
        BankGuaranteesIssuingDateIsInvalid
        BankGuaranteesExpiryDateIsEmpty,
        BankGuaranteesBeneficiaryPartyIsEmpty,
        BankGuaranteesInstrumentDetailsIsEmpty,
        BankGuaranteesValueIsEmpty,
        BankGuaranteesValueIsInvalid,
        BankGuaranteesCurrencyIsEmpty,
        BankGuaranteesStatusIsDefault,
        BankGuaranteesGuarnteeTypeIsDefault,
        BankGuaranteesFeePerPeriodIsEmpty,
        BankGuaranteesFeePerPeriodIsInvalid,
        BankGuaranteesFeePeriodIsDefault

    }
    
}
