using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler.Exceptions.LetterOfCreditExceptions
{
    public class OpenCbsLetterOfCreditException : OpenCbsException
    {

        private readonly string _message;
        private OpenCbsLetterOfCreditExceptionEnum _code;
        public OpenCbsLetterOfCreditExceptionEnum Code { get { return _code; } }

        protected OpenCbsLetterOfCreditException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsLetterOfCreditExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsLetterOfCreditException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsLetterOfCreditExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsLetterOfCreditException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsLetterOfCreditException(OpenCbsLetterOfCreditExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsLetterOfCreditException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsLetterOfCreditExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {
                case OpenCbsLetterOfCreditExceptionEnum.LOCBeneficiaryPartyIsBlank:
                    returned = "LOCBeneficiaryPartyIsBlank";
                    break;
                case OpenCbsLetterOfCreditExceptionEnum.LOCInstrumentTypeIsInvalid:
                    returned = "LOCInstrumentTypeIsInvalid";
                    break;

                case OpenCbsLetterOfCreditExceptionEnum.LOCValidityIsBlank:
                    returned = "LOCValidityIsBlank";
                    break;
                case OpenCbsLetterOfCreditExceptionEnum.LOCValidityIsInvalid:
                    returned = "LOCValidityIsInvalid";
                    break;


                case OpenCbsLetterOfCreditExceptionEnum.LOCFeePerPeriodIsBlank:
                    returned = "LOCFeePerPeriodIsBlank";
                    break;
                case OpenCbsLetterOfCreditExceptionEnum.LOCFeePerPeriodIsInvalid:
                    returned = "LOCFeePerPeriodIsInvalid";
                    break;



                case OpenCbsLetterOfCreditExceptionEnum.LOCInstrumentDescriptionIsBlank:
                    returned = "LOCInstrumentDescriptionIsBlank";
                    break;


                case OpenCbsLetterOfCreditExceptionEnum.LOCValueIsBlank:
                    returned = "LOCValueIsBlank";
                    break;
                case OpenCbsLetterOfCreditExceptionEnum.LOCValueIsInvalid:
                    returned = "LOCValueIsInvalid";
                    break;

                case OpenCbsLetterOfCreditExceptionEnum.LOCCurrencyIsInvalid:
                    returned = "LOCCurrencyIsInvalid";
                    break;


                case OpenCbsLetterOfCreditExceptionEnum.LOCAccountNumberIsBlank:
                    returned = "LOCAccountNumberIsBlank";
                    break;
                case OpenCbsLetterOfCreditExceptionEnum.LOCAccountNumberIsInvalid:
                    returned = "LOCAccountNumberIsInvalid";
                    break;


            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsLetterOfCreditExceptionEnum
    {
        LOCBeneficiaryPartyIsBlank,
        LOCInstrumentTypeIsInvalid,
        LOCValidityIsBlank,
        LOCValidityIsInvalid,
        LOCFeePerPeriodIsBlank,
        LOCFeePerPeriodIsInvalid,
        LOCInstrumentDescriptionIsBlank,
        LOCValueIsBlank,
        LOCValueIsInvalid,
        LOCCurrencyIsInvalid,
        LOCAccountNumberIsBlank,
        LOCAccountNumberIsInvalid

    }

}
