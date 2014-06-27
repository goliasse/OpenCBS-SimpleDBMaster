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

        public string SaveFixedDepositProductHolding(FixedDepositProductHoldings fixedDepositProductHolding)
        {

            ValidateProduct(fixedDepositProductHolding);
            return _fixedDepositProductHoldingManager.SaveFixedDepositProductHolding(fixedDepositProductHolding);
            

        }

        public void UpdateFixedDepositProductHolding(FixedDepositProductHoldings product, int productId)
        {
            _fixedDepositProductHoldingManager.UpdateFixedDepositProductHolding(product, productId);
        }
        public FixedDepositProductHoldings FetchProduct(int productId)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(productId);
        }
        
        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoClosed)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(showAlsoClosed);
        }

        public List<FixedDepositProductHoldings> FetchProduct(bool showAlsoClosed,int clientId,string clientType)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(showAlsoClosed,clientId,clientType);
        }

        public FixedDepositProductHoldings FetchProduct(string productContractCode)
        {
            return _fixedDepositProductHoldingManager.FetchProduct(productContractCode);
        }

        public void UpdateFixedDepositProductHolding(FixedDepositProductHoldings product, string productContractCode)
        {
            _fixedDepositProductHoldingManager.UpdateFixedDepositProductHolding(product, productContractCode);
        }

        public FixedDepositInterest CalculateFinalAmount(string fdContractCode)
        {
            return _fixedDepositProductHoldingManager.CalculateFinalAmount(fdContractCode);
        }

        private void ValidateProduct(FixedDepositProductHoldings fixedDepositProductHolding)
        {
        }



    }
}
