using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.CoreDomain.Contracts.Loans.Installments;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Enums;
using System.Data.SqlClient;

namespace OpenCBS.Manager.Products
{
    public class FixedDepositProductHoldingManager : Manager
    {
        public FixedDepositProductHoldingManager(User pUser) : base(pUser)
        {
        }

        public FixedDepositProductHoldingManager(string testDB)
            : base(testDB)
        {
        }


    }
}
