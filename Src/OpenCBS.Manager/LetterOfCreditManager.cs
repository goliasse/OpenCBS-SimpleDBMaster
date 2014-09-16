using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;
using OpenCBS.Manager.Currencies;

namespace OpenCBS.Manager
{
    public class LetterOfCreditManager : Manager
    {
        public LetterOfCreditManager(User pUser)
            : base(pUser)
        {

        }

        public LetterOfCreditManager(string testDB)
            : base(testDB)
        {

        }
    }
}