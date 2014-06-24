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

        public void SaveFixedDepositProductHolding(FixedDepositProductHoldings fixedDepositProductHolding)
        {

            ValidateProduct(fixedDepositProductHolding);
            _fixedDepositProductHoldingManager.SaveFixedDepositProductHolding(fixedDepositProductHolding);
            

        }

        public void UpdateFixedDepositProductHolding(FixedDepositProductHoldings product, int productId)
        {
            _fixedDepositProductHoldingManager.UpdateFixedDepositProductHolding(product, productId);
        }
        public FixedDepositProductHoldings FetchProduct(int productId)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(productId);
        }
        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoDeleted)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(showAlsoDeleted);
        }

        private void ValidateProduct(FixedDepositProductHoldings fixedDepositProductHolding)
        {
        }



    }
}
