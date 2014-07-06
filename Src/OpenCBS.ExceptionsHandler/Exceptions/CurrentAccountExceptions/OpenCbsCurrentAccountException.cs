using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenCBS.ExceptionsHandler
{
    [Serializable]
    public class OpenCbsCurrentAccountException : OpenCbsException
    {

         private readonly string _message;
        private OpenCbsCurrentAccountExceptionEnum _code;
        public OpenCbsCurrentAccountExceptionEnum Code { get { return _code; } }

        protected OpenCbsCurrentAccountException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            _code = (OpenCbsCurrentAccountExceptionEnum)info.GetInt32("Code");
        }

        protected OpenCbsCurrentAccountException(SerializationInfo info, StreamingContext context, List<string> options)
            : base(info, context)
        {
            _code = (OpenCbsCurrentAccountExceptionEnum)info.GetInt32("Code");
            AdditionalOptions = options;
        }


        public OpenCbsCurrentAccountException()
        {
            _message = string.Empty;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Code", _code);
            base.GetObjectData(info, context);
        }

        public OpenCbsCurrentAccountException(OpenCbsCurrentAccountExceptionEnum exceptionCode)
        {
            _code = exceptionCode;
            _message = FindException(exceptionCode);
        }

        public OpenCbsCurrentAccountException(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }

        private static string FindException(OpenCbsCurrentAccountExceptionEnum exceptionId)
        {
            string returned = String.Empty;
            switch (exceptionId)
            {

                case OpenCbsCurrentAccountExceptionEnum.NameIsEmpty:
                    returned = "CurrentAccountProductNameIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.NameIsLessThanThree:
                    returned = "CurrentAccountProductNameIsLessThanThree";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CodeIsEmpty:
                    returned = "CurrentAccountProductCodeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CodeIsLessThanThree:
                    returned = "CurrentAccountProductCodeIsLessThanThree";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.OneCheckBoxMustBeSeleted:
                    returned = "ClientTypeAtleastOneClientTypeMustBeSeleted";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.SelectCurrencySelected:
                    returned = "SelectCurrencyIsSelected";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.InitialAmountMinIsInvalid:
                    returned = "InitialAmountMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.InitialAmountMaxIsInvalid:
                    returned = "InitialAmountMaxIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.InitialAmountMinMaxIsInvalid:
                    returned = "InitialAmountMinMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.BalanceMinIsInvalid:
                    returned = "BalanceMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.BalanceMaxIsInvalid:
                    returned = "BalanceMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.BalanceMinMaxIsInvalid:
                    returned = "BalanceMinMaxIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.InterestMinIsInvalid:
                    returned = "InterestMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.InterestMaxIsInvalid:
                    returned = "InterestMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.InterestMinMaxIsInvalid:
                    returned = "InterestMinMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMinIsInvalid:
                    returned = "OverdraftFeesMinIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMaxIsInvalid:
                    returned = "OverdraftFeesMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMinMaxIsInvalid:
                    returned = "OverdraftFeesMinMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.InterestCalculationFrequencyIsInvalid:
                    returned = "InterestCalculationFrequencyIsInvalid";
                    break;

            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsCurrentAccountExceptionEnum
    {
        NameIsEmpty,
        NameIsLessThanThree,
        CodeIsEmpty,
        CodeIsLessThanThree,
        OneCheckBoxMustBeSeleted,
        SelectCurrencySelected,
        InitialAmountMinIsInvalid,
        InitialAmountMaxIsInvalid,
        InitialAmountMinMaxIsInvalid,
        BalanceMinIsInvalid,
        BalanceMaxIsInvalid,
        BalanceMinMaxIsInvalid,
        InterestMinIsInvalid,
        InterestMaxIsInvalid,
        InterestMinMaxIsInvalid,
        OverdraftFeesMinIsInvalid,
        OverdraftFeesMaxIsInvalid,
        OverdraftFeesMinMaxIsInvalid,
        InterestCalculationFrequencyIsInvalid

    }

}