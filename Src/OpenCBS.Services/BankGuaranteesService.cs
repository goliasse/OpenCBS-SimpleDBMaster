using System.Text;
using OpenCBS.Manager;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Enums;
using OpenCBS.Shared;
using System;
using OpenCBS.ExceptionsHandler.Exceptions.BankGuaranteeExceptions;
using System.Collections.Generic;

namespace OpenCBS.Services
{
    public class BankGuaranteesService
    {
        private readonly BankGuaranteesManager _bankGuaranteesManager;
        private User _user;

        public BankGuaranteesService(BankGuaranteesManager bankGuaranteesManager)
        {
            _bankGuaranteesManager = bankGuaranteesManager;
        }

        public BankGuaranteesService(User user)
        {
            _user = user;
            _bankGuaranteesManager = new BankGuaranteesManager(user);
        }

        public void UpdateBankGuarantee(BankGuarantees bankGuarantee)
        {
            _bankGuaranteesManager.UpdateBankGuarantee(bankGuarantee);
        }

        public BankGuarantees FetchBankGuarantee(string bankGuaranteeCode)
        {
            return _bankGuaranteesManager.FetchBankGuarantee(bankGuaranteeCode);
        }

        public List<BankGuarantees> FetchBranchAllBankGuarantee(int clientID)
        {
            return _bankGuaranteesManager.FetchBranchAllBankGuarantee(clientID);
        }

        public string SaveBankGuarantee(BankGuarantees bankGuarantee)
        {
            return _bankGuaranteesManager.SaveBankGuarantee(bankGuarantee);
        }

        private void ValidateBankGuarantee(BankGuarantees bankGuarantee)
        {

            if (bankGuarantee.IssuingDate == null)
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesIssuingDateIsEmpty);
            if (bankGuarantee.IssuingDate.Date < DateTime.Now.Date)
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesIssuingDateIsInvalid);


            if (bankGuarantee.ExpiryDate == null)
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesExpiryDateIsEmpty);

            if (string.IsNullOrEmpty(bankGuarantee.BeneficiaryParty))
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesBeneficiaryPartyIsEmpty);

            if (string.IsNullOrEmpty(bankGuarantee.InstrumentDetails))
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesInstrumentDetailsIsEmpty);

            if (!bankGuarantee.Value.HasValue)
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesValueIsEmpty);

            if (Convert.ToDecimal(bankGuarantee.Value) < 0)
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesValueIsInvalid);

            if (bankGuarantee.Currency=="Select currency...")
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesCurrencyIsEmpty);

            if (string.IsNullOrEmpty(bankGuarantee.Status)) //or if (bankGuarantee.Status=="Default")
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesStatusIsDefault);

            if (bankGuarantee.GuarnteeType=="Select guarantee type..")//Same as above
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesGuarnteeTypeIsDefault);

            if (!bankGuarantee.FeePerPeriod.HasValue)
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesFeePerPeriodIsEmpty);

            if (bankGuarantee.FeePerPeriod < 0) //check
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesFeePerPeriodIsInvalid);

            if (string.IsNullOrEmpty(bankGuarantee.FeePeriod))//Default
                throw new OpenCbsBankGuaranteeException(OpenCbsBankGuaranteesExceptionEnum.BankGuaranteesFeePeriodIsDefault);

        }
    }
}