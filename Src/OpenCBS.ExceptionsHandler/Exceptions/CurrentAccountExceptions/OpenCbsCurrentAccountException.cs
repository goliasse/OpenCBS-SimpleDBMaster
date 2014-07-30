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

                case OpenCbsCurrentAccountExceptionEnum.EntryFeesMinIsInvalid:
                    returned = "EntryFeesMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.EntryFeesMaxIsInvalid:
                    returned = "EntryFeesMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.EntryFeesMinMaxIsInvalid:
                    returned = "EntryFeesMinMaxIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.ReopenFeesMinIsInvalid:
                    returned = "ReopenFeesMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.ReopenFeesMaxIsInvalid:
                    returned = "ReopenFeesMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.ReopenFeesMinMaxIsInvalid:
                    returned = "ReopenFeesMinMaxIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CloseFeesMinIsInvalid:
                    returned = "CloseFeesMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CloseFeesMaxIsInvalid:
                    returned = "CloseFeesMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CloseFeesMinMaxIsInvalid:
                    returned = "CloseFeesMinMaxIsInvalid";
                    break;


                case OpenCbsCurrentAccountExceptionEnum.ManagementFeesMinIsInvalid:
                    returned = "ManagementFeesMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.ManagementFeesMaxIsInvalid:
                    returned = "ManagementFeesMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.ManagementFeesMinMaxIsInvalid:
                    returned = "ManagementFeesMinMaxIsInvalid";
                    break;


                case OpenCbsCurrentAccountExceptionEnum.ManagementFeeFrequencyIsEmpty:
                    returned = "ManagementFeeFrequencyIsEmpty";
                    break;


                case OpenCbsCurrentAccountExceptionEnum.OverdraftInterestRateMinIsInvalid:
                    returned = "OverdraftInterestRateIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.OverdraftInterestRateMaxIsInvalid:
                    returned = "OverdraftInterestRateMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.OverdraftInterestRateMinMaxIsInvalid:
                    returned = "OverdraftInterestRateMinMaxIsInvalid";
                    break;


                case OpenCbsCurrentAccountExceptionEnum.CommitmentFeesMinIsInvalid:
                    returned = "CommitmentFeesMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CommitmentFeesMaxIsInvalid:
                    returned = "CommitmentFeesMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CommitmentFeesMinMaxIsInvalid:
                    returned = "CommitmentFeesMinMaxIsInvalid";
                    break;


                case OpenCbsCurrentAccountExceptionEnum.OverdraftLimitMinIsInvalid:
                    returned = "OverdraftLimitMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.OverdraftLimitMaxIsInvalid:
                    returned = "OverdraftLimitMaxIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.OverdraftLimitMinMaxIsInvalid:
                    returned = "OverdraftLimitMinMaxIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.TransactionTypeIsEmpty:
                    returned = "CurrentAccountProductTransactionTypeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.TransactionValueIsLessThanZero:
                    returned = "CurrentAccountProductTransactionValueIsLessThanZero";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.TransactionMinIsInvalid:
                    returned = "CurrentAccountProductTransactionMinIsInvalid";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.TransactionMaxIsInvalid:
                    returned = "CurrentAccountProductTransactionMaxIsInvalid";
                    break;



                case OpenCbsCurrentAccountExceptionEnum.InitialAmountIsEmpty:
                    returned = "InitialAmountIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.InterestRateIsEmpty:
                    returned = "InterestRateIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.MaturityPeriodIsEmpty:
                    returned = "MaturityPeriodIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.PenaltyIsEmpty:
                    returned = "PenaltyIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.ICFIsEmpty:
                    returned = "ICFIsEmpty";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.InitialAmountMinIsEmpty:
                    returned = "InitialAmountMinIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.InitialAmountMaxIsEmpty:
                    returned = "InitialAmountMaxIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.BalanceMinIsEmpty:
                    returned = "BalanceMinIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.BalanceMaxIsEmpty:
                    returned = "BalanceMaxIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.InterestCalculationFrequencyIsEmpty:
                    returned = "InterestCalculationFrequencyIsEmpty";
                    break;



                case OpenCbsCurrentAccountExceptionEnum.CAPHCurrentAccountProductIsBlank:
                    returned = "CAPHCurrentAccountProductIsBlank";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHInitialAmountIsEmpty:
                    returned = "CAPHInitialAmountIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHInitialAmountIsInvalid:
                    returned = "CAPHInitialAmountIsInvalid";
                    break;


                case OpenCbsCurrentAccountExceptionEnum.CAPHEntryFeeIsEmpty:
                    returned = "CAPHEntryFeeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHEntryFeeIsInvalid:
                    returned = "CAPHEntryFeeIsInvalid";
                    break;


                case OpenCbsCurrentAccountExceptionEnum.CAPHReopenFeeIsEmpty:
                    returned = "CAPHReopenFeeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHReopenFeeIsInvalid:
                    returned = "CAPHReopenFeeIsInvalid";
                    break;


                case OpenCbsCurrentAccountExceptionEnum.CAPHCloseFeeIsEmpty:
                    returned = "CAPHCloseFeeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHCloseFeeIsInvalid:
                    returned = "CAPHCloseFeeIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHManagementFeeIsEmpty:
                    returned = "CAPHManagementFeeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHManagementFeeIsInvalid:
                    returned = "CAPHManagementFeeIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHProductCodeIsEmpty:
                    returned = "CAPHProductCodeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHAccountingOfficerIsBlank:
                    returned = "CAPHAccountingOfficerIsBlank";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHCommentIsEmpty:
                    returned = "CAPHCommentIsEmpty";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHFixedOverdraftFeeIsEmpty:
                    returned = "CAPHFixedOverdraftFeeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHFixedOverdraftFeeIsInvalid:
                    returned = "CAPHFixedOverdraftFeeIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftInterestRateIsEmpty:
                    returned = "CAPHOverdraftInterestRateIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftInterestRateIsInvalid:
                    returned = "CAPHOverdraftInterestRateIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftLimitIsEmpty:
                    returned = "CAPHOverdraftLimitIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftLimitIsInvalid:
                    returned = "CAPHOverdraftLimitIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftCommitmentFeeIsEmpty:
                    returned = "CAPHOverdraftCommitmentFeeIsEmpty";
                    break;
                case OpenCbsCurrentAccountExceptionEnum.CAPHOverdraftCommitmentFeeIsInvalid:
                    returned = "CAPHOverdraftCommitmentFeeIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPInitialAmountMinLessThanBalanceMin:
                    returned = "CAPInitialAmountMinLessThanBalanceMin";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPInitialAmountMaxLessThanBalanceMax:
                    returned = "CAPInitialAmountMaxLessThanBalanceMax";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHInitialAmountAccountNumberIsBlank:
                    returned = "CAPHInitialAmountAccountNumberIsBlank";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHFinalAmountAccountNumberIsBlank:
                    returned = "CAPHFinalAmountAccountNumberIsBlank";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHFinalAmountPaymentMethodIsBlank:
                    returned = "CAPHFinalAmountPaymentMethodIsBlank";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHInitialAmountPaymentMethodIsBlank:
                    returned = "CAPHInitialAmountPaymentMethodIsBlank";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CurrentAccountProductCodeAlreadyExist:
                    returned = "CurrentAccountProductCodeAlreadyExist";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CurrentAccountProductNameAlreadyExist:
                    returned = "CurrentAccountProductNameAlreadyExist";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHInterestRateIsInvalid:
                    returned = "CAPHInterestRateIsInvalid";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CurrentAccountProductSelectAProduct:
                    returned = "CurrentAccountProductSelectAProduct";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CAPHSelectAContract:
                    returned = "CAPHSelectAContract";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CurrentAccountTransactionSelectATransaction:
                    returned = "CurrentAccountTransactionSelectATransaction";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.InterestMinMaxValue:
                    returned = "InterestMinMaxValue";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.EntryFeesMinMaxValue:
                    returned = "EntryFeesMinMaxValue";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.ReopenFeesMinMaxValue:
                    returned = "ReopenFeesMinMaxValue";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CloseFeesMinMaxValue:
                    returned = "CloseFeesMinMaxValue";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.ManagementFeesMinMaxValue:
                    returned = "ManagementFeesMinMaxValue";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.OverdraftFeesMinMaxValue:
                    returned = "OverdraftFeesMinMaxValue";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.OverdraftInterestRateMinMaxValue:
                    returned = "OverdraftInterestRateMinMaxValue";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.CommitmentFeesMinMaxValue:
                    returned = "CommitmentFeesMinMaxValue";
                    break;

                case OpenCbsCurrentAccountExceptionEnum.OverdraftLimitMinMaxValue:
                    returned = "OverdraftLimitMinMaxValue";
                    break;


            }
            return returned;
        }

    }


    [Serializable]
    public enum OpenCbsCurrentAccountExceptionEnum
    {
        InterestMinMaxValue,
        EntryFeesMinMaxValue,
        ReopenFeesMinMaxValue,
        CloseFeesMinMaxValue,
        ManagementFeesMinMaxValue,
        OverdraftFeesMinMaxValue,
        OverdraftInterestRateMinMaxValue,
        CommitmentFeesMinMaxValue,
        OverdraftLimitMinMaxValue,
        CurrentAccountTransactionSelectATransaction,
        CAPHSelectAContract,
        CurrentAccountProductSelectAProduct,
        CAPHInterestRateIsInvalid,
        CurrentAccountProductCodeAlreadyExist,
        CurrentAccountProductNameAlreadyExist,
        CAPHInitialAmountPaymentMethodIsBlank,
        CAPHFinalAmountPaymentMethodIsBlank,
        CAPHFinalAmountAccountNumberIsBlank,
        CAPHInitialAmountAccountNumberIsBlank,
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
        InterestCalculationFrequencyIsInvalid,
        EntryFeesMinIsInvalid,
        EntryFeesMaxIsInvalid,
        EntryFeesMinMaxIsInvalid,
        ReopenFeesMinIsInvalid,
        ReopenFeesMaxIsInvalid,
        ReopenFeesMinMaxIsInvalid,
        CloseFeesMinIsInvalid,
        CloseFeesMaxIsInvalid,
        CloseFeesMinMaxIsInvalid,
        ManagementFeesMinIsInvalid,
        ManagementFeesMaxIsInvalid,
        ManagementFeesMinMaxIsInvalid,
        ManagementFeeFrequencyIsEmpty,
        FixedOverdraftFeesMinIsInvalid,
        FixedOverdraftFeesMaxIsInvalid,
        FixedOverdraftFeesMinMaxIsInvalid,
        OverdraftInterestRateMinIsInvalid,
        OverdraftInterestRateMaxIsInvalid,
        OverdraftInterestRateMinMaxIsInvalid,
        CommitmentFeesMinIsInvalid,
        CommitmentFeesMaxIsInvalid,
        CommitmentFeesMinMaxIsInvalid,
        OverdraftLimitMinIsInvalid,
        OverdraftLimitMaxIsInvalid,
        OverdraftLimitMinMaxIsInvalid,
        TransactionTypeIsEmpty,
        TransactionValueIsLessThanZero,
        TransactionMinIsInvalid,
        TransactionMaxIsInvalid,
        InitialAmountIsEmpty,
        InterestRateIsEmpty,
        MaturityPeriodIsEmpty,
        PenaltyIsEmpty,
        ICFIsEmpty,
        InitialAmountMinIsEmpty,
        InitialAmountMaxIsEmpty,
        BalanceMinIsEmpty,
        BalanceMaxIsEmpty,
        InterestCalculationFrequencyIsEmpty,
        CAPHCurrentAccountProductIsBlank,
        CAPHInitialAmountIsEmpty,
        CAPHInitialAmountIsInvalid,
        CAPHEntryFeeIsEmpty,
        CAPHEntryFeeIsInvalid,
        CAPHReopenFeeIsEmpty,
        CAPHReopenFeeIsInvalid,
        CAPHCloseFeeIsEmpty,
        CAPHCloseFeeIsInvalid,
        CAPHManagementFeeIsEmpty,
        CAPHManagementFeeIsInvalid,
        CAPHProductCodeIsEmpty,
        CAPHAccountingOfficerIsBlank,
        CAPHCommentIsEmpty,
        CAPHFixedOverdraftFeeIsEmpty,
        CAPHFixedOverdraftFeeIsInvalid,
        CAPHOverdraftInterestRateIsEmpty,
        CAPHOverdraftInterestRateIsInvalid,
        CAPHOverdraftLimitIsEmpty,
        CAPHOverdraftLimitIsInvalid,
        CAPHOverdraftCommitmentFeeIsEmpty,
        CAPHOverdraftCommitmentFeeIsInvalid,
        CAPInitialAmountMaxLessThanBalanceMax,
        CAPInitialAmountMinLessThanBalanceMin

    }

}