using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;

namespace OpenCBS.Manager
{
    public class RWAPercentageManager : Manager
    {
        User _user;
        public RWAPercentageManager(User pUser) : base(pUser)
        {
            _user = pUser;
        }

        public RWAPercentageManager(string testDB)
            : base(testDB)
        {

        }

    }
}
