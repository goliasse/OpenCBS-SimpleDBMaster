using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsFixedDepositException : OpenCbsException
    {

        private readonly string _message;
        private OpenCbsFixedDepositExceptionEnum _code;
        public OpenCbsFixedDepositExceptionEnum Code { get { return _code; } }

        protected OpenCbsFixedDepositException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsFixedDepositExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsFixedDepositException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsFixedDepositExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsFixedDepositException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsFixedDepositException(OpenCbsFixedDepositExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsFixedDepositException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsFixedDepositExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {
                case OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductNameIsBlank:
                    returned = "FDPHFixedDepositProductNameIsBlank";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductNameIsLessThanThree:
                    returned = "FDPHFixedDepositProductNameIsLessThanThree";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductCodeIsBlank:
                    returned = "FDPHFixedDepositProductCodeIsBlank";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductCodeLessThanThree:
                    returned = "FDPHFixedDepositProductCodeLessThanThree";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHClientTypeIsEmpty:
                    returned = "FDPHClientTypeIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHCurrencyIsBlank:
                    returned = "FDPHCurrencyIsBlank";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMinIsEmpty:
                    returned = "FDPHInitialAmountMinIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMinIsInvalid:
                    returned = "FDPHInitialAmountMinIsInvalid";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMaxIsEmpty:
                    returned = "FDPHInitialAmountMaxIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMaxIsInvalid:
                    returned = "FDPHInitialAmountMaxIsInvalid";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountMinMaxIsInvalid:
                    returned = "FDPHInitialAmountMinMaxIsInvalid";
                    break;






                case OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMinIsEmpty:
                    returned = "FDPHInterestRateMinIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMinIsInvalid:
                    returned = "FDPHInterestRateMinIsInvalid";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMaxIsEmpty:
                    returned = "FDPHInterestRateMaxIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMaxIsInvalid:
                    returned = "FDPHInterestRateMaxIsInvalid";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInterestRateMinMaxIsInvalid:
                    returned = "FDPHInterestRateMinMaxIsInvalid";
                    break;


                case OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMinIsEmpty:
                    returned = "FDPHMaturityPeriodMinIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMinIsInvalid:
                    returned = "FDPHMaturityPeriodMinIsInvalid";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMaxIsEmpty:
                    returned = "FDPHMaturityPeriodMaxIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodMaxIsInvalid:
                    returned = "FDPHMaturityPeriodMaxIsInvalid";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHInterestCalculationFrequencyIsEmpty:
                    returned = "FDPHInterestCalculationFrequencyIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInterestCalculationFrequencyIsInvalid:
                    returned = "FDPHInterestCalculationFrequencyIsInvalid";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHPenaltyMinMaxIsInvalid:
                    returned = "FDPHPenaltyMinMaxIsInvalid";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHFixedDepositProductIsBlank:
                    returned = "FDPHFixedDepositProductIsBlank";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountIsEmpty:
                    returned = "FDPHInitialAmountIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountIsInvalid:
                    returned = "FDPHInitialAmountIsInvalid";
                    break;


                case OpenCbsFixedDepositExceptionEnum.FDPHInterestRateIsEmpty:
                    returned = "FDPHInterestRateIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHInterestRateIsInvalid:
                    returned = "FDPHInterestRateIsInvalid";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodIsEmpty:
                    returned = "FDPHMaturityPeriodIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHMaturityPeriodIsInvalid:
                    returned = "FDPHMaturityPeriodIsInvalid";
                    break;


                
                case OpenCbsFixedDepositExceptionEnum.FDPHPenaltyIsEmpty:
                    returned = "FDPHPenaltyIsEmpty";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHPenaltyIsInvalid:
                    returned = "FDPHPenaltyIsInvalid";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHProductCodeIsBlank:
                    returned = "FDPHProductCodeIsBlank";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHAccountingOfficerIsBlank:
                    returned = "FDPHAccountingOfficerIsBlank";
                    break;
                case OpenCbsFixedDepositExceptionEnum.FDPHCommentIsBlank:
                    returned = "FDPHCommentIsBlank";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountAccountNumberIsBlank:
                    returned = "FDPHInitialAmountAccountNumberIsBlank";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHFinalAmountAccountNumberIsBlank:
                    returned = "FDPHFinalAmountAccountNumberIsBlank";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHInitialAmountPaymentMethodIsBlank:
                    returned = "FDPHInitialAmountPaymentMethodIsBlank";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FDPHFinalAmountPaymentMethodIsBlank:
                    returned = "FDPHFinalAmountPaymentMethodIsBlank";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FixedDepositProductNameAlreadyExist:
                    returned = "FixedDepositProductNameAlreadyExist";
                    break;

                case OpenCbsFixedDepositExceptionEnum.FixedDepositProductCodeAlreadyExist:
                    returned = "FixedDepositProductCodeAlreadyExist";
                    break;
            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsFixedDepositExceptionEnum
    {
        FixedDepositProductNameAlreadyExist,
        FixedDepositProductCodeAlreadyExist,
        FDPHFinalAmountPaymentMethodIsBlank,
        FDPHInitialAmountPaymentMethodIsBlank,
        FDPHFinalAmountAccountNumberIsBlank,
        FDPHInitialAmountAccountNumberIsBlank,
        FDPHFixedDepositProductNameIsBlank,
        FDPHFixedDepositProductNameIsLessThanThree,
        FDPHFixedDepositProductCodeIsBlank,
        FDPHFixedDepositProductCodeLessThanThree,
        FDPHClientTypeIsEmpty,
        FDPHCurrencyIsBlank,
        FDPHInitialAmountMinIsEmpty,
        FDPHInitialAmountMinIsInvalid,
        FDPHInitialAmountMaxIsEmpty,
        FDPHInitialAmountMaxIsInvalid,
        FDPHInitialAmountMinMaxIsInvalid,
        FDPHInterestRateMinIsEmpty,
        FDPHInterestRateMinIsInvalid,
        FDPHInterestRateMaxIsEmpty,
        FDPHInterestRateMaxIsInvalid,
        FDPHInterestRateMinMaxIsInvalid,
        FDPHMaturityPeriodMinIsEmpty,
        FDPHMaturityPeriodMinIsInvalid,
        FDPHMaturityPeriodMaxIsEmpty,
        FDPHMaturityPeriodMaxIsInvalid,
        FDPHInterestCalculationFrequencyIsEmpty,
        FDPHInterestCalculationFrequencyIsInvalid,
        FDPHPenaltyMinMaxIsInvalid,
        FDPHFixedDepositProductIsBlank,
        FDPHInitialAmountIsEmpty,
        FDPHInitialAmountIsInvalid,
        FDPHInterestRateIsEmpty,
        FDPHInterestRateIsInvalid,
        FDPHMaturityPeriodIsEmpty,
        FDPHMaturityPeriodIsInvalid,
       
        FDPHPenaltyIsEmpty,
        FDPHPenaltyIsInvalid,
        FDPHProductCodeIsBlank,
        FDPHAccountingOfficerIsBlank,
        FDPHCommentIsBlank

    }
}
