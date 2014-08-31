using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.Manager;

namespace OpenCBS.Services
{
    public class FixedAssetRegisterService
    {
        private readonly FixedAssetRegisterManager _fixedAssetRegisterManager;
        private User _user;

        public FixedAssetRegisterService(FixedAssetRegisterManager fixedAssetRegisterManager)
        {
            _fixedAssetRegisterManager = fixedAssetRegisterManager;
        }

        public FixedAssetRegisterService(User user)
        {
            _user = user;
            _fixedAssetRegisterManager = new FixedAssetRegisterManager(user);
        }
    }
}
