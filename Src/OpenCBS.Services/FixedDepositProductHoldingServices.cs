using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.Manager.Products;
using OpenCBS.CoreDomain;
using OpenCBS.CoreDomain.Products;

namespace OpenCBS.Services
{
    public class FixedDepositProductHoldingServices
    {

        private readonly FixedDepositProductHoldingManager _fixedDepositProductHoldingManager;
        private User _user;

        public FixedDepositProductHoldingServices(FixedDepositProductHoldingManager fixedDepositProductManager)
		{
            _fixedDepositProductHoldingManager = fixedDepositProductManager;
		}

        public FixedDepositProductHoldingServices(User user)
		{
            _user = user;
            _fixedDepositProductHoldingManager = new FixedDepositProductHoldingManager(user);
		}

        public void SaveFixedDepositProduct(FixedDepositProductHoldingManager fixedDepositProductHolding)
        {

            ValidateProduct(fixedDepositProductHolding);
            _fixedDepositProductHoldingManager.SaveFixedDepositProductHolding(fixedDepositProductHolding);
            

        }

        private void ValidateProduct(FixedDepositProductHoldingManager fixedDepositProduct)
        {
        }

    }
}
