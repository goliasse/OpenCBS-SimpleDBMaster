using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.Manager;

namespace OpenCBS.Services
{
    public class RWAPercentageService
    {
        private readonly  RWAPercentageManager _RWAPercentageManager;
        private User _user;

        public RWAPercentageService(RWAPercentageManager RWAPercentageManager)
		{
            _RWAPercentageManager = RWAPercentageManager;
		}

        public RWAPercentageService(User user)
		{
            _user = user;
            _RWAPercentageManager = new RWAPercentageManager(user);
		}
    }
}
