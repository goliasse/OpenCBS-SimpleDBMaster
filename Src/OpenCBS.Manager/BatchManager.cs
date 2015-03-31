using System;
using System.Collections.Generic;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Contracts.Loans;
using OpenCBS.CoreDomain.Events.Loan;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Manager.Products;

using Microsoft.Office.Interop.Word;
using OpenCBS.CoreDomain.Events;
using System.Windows.Forms;
using OpenCBS.Manager.Database;
using OpenCBS.Manager.Events;

namespace OpenCBS.Manager
{
    public class BatchManager: Manager
    {
        private User _user = new User();
        string noticePath = "";
        int officeVersion = 0;
        string bankName = "";
        string bankRepresentative = "";
        ApplicationSettingsManager _applicationSettingsManager;
        EventManager _eventManager;

        public BatchManager(User pUser) : base(pUser)
        {
            _user = pUser;
            _applicationSettingsManager = new ApplicationSettingsManager(pUser);
            _eventManager = new EventManager(pUser);
            noticePath = _applicationSettingsManager.SelectParameterValue("NOTICE_PATH").ToString();
            officeVersion = _applicationSettingsManager.GetOfficeVersion();
            bankName = _applicationSettingsManager.SelectParameterValue("BANK_NAME").ToString();
            bankRepresentative = _applicationSettingsManager.SelectParameterValue("BANK_REPRESENTATIVE").ToString();
        }

        public BatchManager(string testDB) : base(testDB) { }

        //Monthly Batch
        public int CurrentAccountInterestBatch(DateTime calculationDate)
        {
            int result = 0;
            CurrentAccountProductHoldingManager _currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(_user);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings =  _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
            _currentAccountProductHoldingManager.CurrentAccountInterestCalculation(calculationDate, _currentAccountProductHoldings);
            }
            return result;
        }

        //Monthly Batch
        public int OverdraftInterestCalculationBatch(DateTime calculationDate)
        {
            int result = 0;
            CurrentAccountProductHoldingManager _currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(_user);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (_currentAccountProductHoldings.OverdraftApplied == 1)
                _currentAccountProductHoldingManager.CurrentAccountOverdraftInterestCalculation(calculationDate, _currentAccountProductHoldings);
            }
            return result;
        }

        //Monthly Batch
        public int CommitmentFeesCalculationBatch(DateTime calculationDate)
        {
            int result = 0;
            CurrentAccountProductHoldingManager _currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(_user);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                if (_currentAccountProductHoldings.OverdraftApplied == 1)
                    _currentAccountProductHoldingManager.CurrentAccountCommitmentFeeCalculation(calculationDate, _currentAccountProductHoldings);
            }
            return result;
        }

        //Monthly Batch
        public int AccountDormantBatch(DateTime calculationDate)
        {
            int result = 0;
            CurrentAccountProductHoldingManager _currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(_user);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                _currentAccountProductHoldingManager.GetDormantAccount( _currentAccountProductHoldings.CurrentAccountContractCode);
            }
            return result;
        }

        //Monthly Batch
        public int CurrentAccountManagemntFeeBatch(DateTime calculationDate)
        {
            int result = 0;
            CurrentAccountProductHoldingManager _currentAccountProductHoldingManager = new CurrentAccountProductHoldingManager(_user);
            List<CurrentAccountProductHoldings> listCurrentAccountProductHoldings = _currentAccountProductHoldingManager.FetchProduct(false);
            foreach (CurrentAccountProductHoldings _currentAccountProductHoldings in listCurrentAccountProductHoldings)
            {
                _currentAccountProductHoldingManager.CalculateManagementFees(calculationDate,_currentAccountProductHoldings);
            }
            return result;
        }

        //Monthly Batch
        public int LoanStatementBatch()
        {
            int result = 0;

            
            
            return result;
        }

        //Monthly Batch
        public int CurrentAccountStatementBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int SavingAccountStatementBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int FixedDepositStatementBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int LoanChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int CurrentAccountChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int SavingAccountChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }

        //Monthly Batch
        public int FixedDepositChargesNoticeBatch()
        {
            int result = 0;
            return result;
        }
    }
}
