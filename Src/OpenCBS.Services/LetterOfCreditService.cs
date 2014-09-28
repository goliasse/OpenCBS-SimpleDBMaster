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
    public class LetterOfCreditService
    {
        private readonly LetterOfCreditManager _LetterOfCreditManager;
        private User _user;

        public LetterOfCreditService(LetterOfCreditManager LetterOfCreditManager)
        {
            _LetterOfCreditManager = LetterOfCreditManager;
        }

        public LetterOfCreditService(User user)
        {
            _user = user;
            _LetterOfCreditManager = new LetterOfCreditManager(user);
        }

        public void UpdateLetterOfCredit(LetterOfCredit letterOfCredit)
        {
            _LetterOfCreditManager.UpdateLetterOfCredit(letterOfCredit);
        }

        public LetterOfCredit FetchLetterOfCredit(string letterOfCreditCode)
        {
            return _LetterOfCreditManager.FetchLetterOfCredit(letterOfCreditCode);
        }

        public List<LetterOfCredit> FetchAllLetterOfCredit()
        {
            return _LetterOfCreditManager.FetchAllLetterOfCredit();
        }

        public string SaveLetterOfCredit(LetterOfCredit letterOfCredit)
        {
            return _LetterOfCreditManager.SaveLetterOfCredit(letterOfCredit);
        }

       
    }
}