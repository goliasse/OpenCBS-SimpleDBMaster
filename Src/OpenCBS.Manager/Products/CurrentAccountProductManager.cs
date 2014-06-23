using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.CoreDomain.Contracts.Loans.Installments;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Enums;
using System.Data.SqlClient;


namespace OpenCBS.Manager.Products
{
    public class CurrentAccountProductManager : Manager
    {

        public CurrentAccountProductManager(User pUser) : base(pUser)
        {
        }

        public CurrentAccountProductManager(string testDB) : base(testDB)
        {
        }


        public void SaveCurrentAccountProduct(ICurrentAccountProduct CurrentAccountProduct)
        {
        }

    }
}
