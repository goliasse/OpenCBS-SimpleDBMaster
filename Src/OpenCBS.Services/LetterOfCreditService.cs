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

       
    }
}