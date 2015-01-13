// Octopus MFS is an integrated suite for managing a Micro Finance Institution: 
// clients, contracts, accounting, reporting and risk
// Copyright © 2006,2007 OCTO Technology & OXUS Development Network
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OpenCBS.Enums;
using OpenCBS.MultiLanguageRessources;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Services;
using OpenCBS.CoreDomain;

namespace OpenCBS.GUI.Accounting
{
    public partial class FrmAccount : Form
    {
        public FrmAccount()
        {
           Mode = 0;
           InitializeComponent();
           Initialize();
           
        }

        private void InitializeComboBoxBranches()
        {
            cbBranch.Items.Clear();
            List<Branch> branches = ServicesProvider.GetInstance().GetBranchService().FindAllNonDeleted();
            cbBranch.ValueMember = "Code";
            cbBranch.DisplayMember = "Code";
            cbBranch.DataSource = branches;
        }

        public FrmAccount(bool showBothTabs)
        {
            Mode = 0;
            ShowBothTabs = showBothTabs;
            InitializeComponent();
            Initialize();
        }

        public bool ShowBothTabs { get; set; }       

        public Account Account
        {
            get { return GetAccount(); }
            set { SetAccount(value); }
        }

        public AccountCategory AccountCategory
        {
            get { return GetAccountCategory(); }
            set { SetAccountCategory(value); }
        }

        // 0 - Account adding mode
        // 1 - Account category adding mode
        public int Mode { get; set; }

        private AccountCategory GetAccountCategory()
        {
            return new AccountCategory { Name = tbAccountCategory.Text};
        }

        private void SetAccountCategory(AccountCategory accountCategory)
        {
            tbAccountCategory.Text = accountCategory.Name;
        }

        private void SetAccount(Account pAccount)
        {
            if (!pAccount.ParentAccountId.HasValue)
            {
                string name = "";
                List<AccountCategory> accountCategories =
                    ServicesProvider.GetInstance().GetChartOfAccountsServices().SelectAccountCategories();

                foreach (var accountCategory in
                    accountCategories.Where(accountCategory => accountCategory.Id == (int) pAccount.AccountCategory))
                {
                    name = accountCategory.Name;
                }
                treeViewAccounts.SelectedNode = treeViewAccounts.Nodes.Find(name, false)[0];
            }
            else
            {
                treeViewAccounts.SelectedNode = treeViewAccounts.Nodes.Find(pAccount.ParentAccountId.ToString(), true)[0];
            }

            textNumericNumber.Text = pAccount.Number;
            textBoxLabel.Text = pAccount.Label;

            if (pAccount.Type)
            {
                textNumericNumber.Enabled = false;
            }

            rbCredit.Checked = !pAccount.DebitPlus;
            rbDebit.Checked = pAccount.DebitPlus;
        }

        private Account GetAccount()
        {
            var account = new Account
            {
                Number = textNumericNumber.Text,
                Label = textBoxLabel.Text,
                Balance = 0,
                StockBalance = 0
            };

            if (treeViewAccounts.SelectedNode.Tag is OAccountCategories)
            {
                account.AccountCategory = (OAccountCategories)treeViewAccounts.SelectedNode.Tag;
            }
            else
            {
                account.ParentAccountId = ((Account)treeViewAccounts.SelectedNode.Tag).Id;
                account.ParentAccountId = account.ParentAccountId.Value == -1 ? null : account.ParentAccountId;
                account.AccountCategory = ((Account)treeViewAccounts.SelectedNode.Tag).AccountCategory;
            }
            account.TypeCode = account.Label.ToUpper();
            account.DebitPlus = rbDebit.Checked;

            return account;
        }

        private void Initialize()
        {
            List<Account> accounts = ServicesProvider.GetInstance().GetChartOfAccountsServices().FindAllAccounts();
            List<AccountCategory> accountCategories = ServicesProvider.GetInstance().GetChartOfAccountsServices().SelectAccountCategories();

            foreach (AccountCategory accountCategory in accountCategories)
            {
                string name = MultiLanguageStrings.GetString(
                    Ressource.ChartOfAccountsForm, accountCategory.Name + ".Text");
                name = name ?? accountCategory.Name;

                Account accountCat = new Account
                {
                    Label = name,
                    AccountCategory = (OAccountCategories)accountCategory.Id,
                    Id = -1
                };

                TreeNode nodeAssets =
                new TreeNode(name)
                {
                    Tag = accountCat,
                    Name = accountCategory.Name
                };
                treeViewAccounts.Nodes.Add(nodeAssets);

                foreach (Account account in accounts.Where(item => item.AccountCategory == accountCat.AccountCategory && !item.ParentAccountId.HasValue))
                    AddAccountInTree(nodeAssets, account, accounts);
                
            }
            
            if(!ShowBothTabs)
                tabControlData.TabPages.Remove(tabPageCategory);
            if (accountCategories.Count == 0)
            {
                tabControlData.TabPages.Remove(tabPageAccount);
                Mode = 1;
            }
            else
                treeViewAccounts.SelectedNode = treeViewAccounts.Nodes[0];

            cbCategory.ValueMember = "name";
            cbCategory.DisplayMember = "name";
            cbCategory.DataSource = accountCategories;


            InitializeComboBoxBranches();
            
        }


        void KeyPressControl(KeyPressEventArgs e)
        {
            int keyCode = e.KeyChar;

            if (
                (keyCode >= 48 && keyCode <= 57) ||
                (keyCode == 8) ||
                (Char.IsControl(e.KeyChar) && e.KeyChar != ((char)Keys.V | (char)Keys.ControlKey))
                ||
                (Char.IsControl(e.KeyChar) && e.KeyChar != ((char)Keys.C | (char)Keys.ControlKey))
                ||
                (e.KeyChar.ToString() == System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private static void AddAccountInTree(TreeNode pParent, Account pAccount, List<Account> pListAccount)
        {
            TreeNode node = new TreeNode(pAccount.ToString()) { Tag = pAccount, Name = pAccount.Id.ToString() };
            pParent.Nodes.Add(node);
            foreach (Account account in pListAccount.Where(item => item.ParentAccountId == pAccount.Id))
                AddAccountInTree(node, account, pListAccount);
        }

        private void treeViewAccounts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            labelParentValue.Text = treeViewAccounts.SelectedNode.FullPath;
        }

        private void tabControlData_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mode = tabControlData.SelectedIndex;
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            string categoryName = cbCategory.SelectedValue.ToString();
            string subCategory = tbSubCategory.Text.ToString();
            decimal balance = Convert.ToDecimal(tbBalance.Text);
            string branch = cbBranch.SelectedValue.ToString();
            
            int ret = ServicesProvider.GetInstance().GetChartOfAccountsServices().AddChartOfAccount(categoryName, subCategory, balance, branch);

            if (ret >= 1)
            {
                MessageBox.Show("Chart Of Account added successfully.");
            }
            else
                MessageBox.Show("Some error ocurred.");
        }

        private void tbBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
KeyPressControl(e);
        }
    }
}
