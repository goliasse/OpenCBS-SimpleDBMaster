using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenCBS.CoreDomain;
using OpenCBS.Services;

namespace OpenCBS.GUI.BankGuarantee
{
    public partial class IssuedBankGuarantee : Form
    {
        public IssuedBankGuarantee()
        {
            InitializeComponent();
        }

        private void InitializeBankGuaranteeList()
        {
            lvBankGuarantee.Items.Clear();
            BankGuaranteeService _bankGuaranteeService = ServicesProvider.GetInstance().GetBankGuaranteeService();
            List<BankGuarantees> bankGuaranteeList = _bankGuaranteeService.FetchBankGuarantee("Default");
            if (bankGuaranteeList != null)
            {
                foreach (BankGuarantees bankGuarantee in bankGuaranteeList)
                {

                    var item = new ListViewItem(new[] {
                    bankGuarantee.BankGuaranteeCode,
                    bankGuarantee.Branch,
                    bankGuarantee.IssuingDate.ToShortDateString(),
                    bankGuarantee.ExpiryDate.ToShortDateString(),
                    bankGuarantee.BeneficiaryParty,
                    bankGuarantee.GuarnteeType,
                    bankGuarantee.Status,
                    bankGuarantee.Value.GetFormatedValue(false),
                    bankGuarantee.Currency
                    });
                    lvBankGuarantee.Items.Add(item);
                }

            }
        }
    }
}
