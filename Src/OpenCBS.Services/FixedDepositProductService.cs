using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;

namespace OpenCBS.Services
{
    public class FixedDepositProductService
    {
        private readonly FixedDepositProductManager _fixedDepositProductManager;
        private User _user;

        public FixedDepositProductService(FixedDepositProductManager fixedDepositProductManager)
		{
            _fixedDepositProductManager = fixedDepositProductManager;
		}

        public FixedDepositProductService(User user)
		{
            _user = user;
            _fixedDepositProductManager = new FixedDepositProductManager(user);
		}

        public void SaveFixedDepositProduct(IFixedDepositProduct fixedDepositProduct)
        {

            ValidateProduct(fixedDepositProduct);
            _fixedDepositProductManager.SaveFixedDepositProduct(fixedDepositProduct);
            

        }

        private void ValidateProduct(IFixedDepositProduct fixedDepositProduct)
        {
        }

    }
}
