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

        public int SaveFixedDepositProduct(IFixedDepositProduct fixedDepositProduct)
        {

            ValidateProduct(fixedDepositProduct);
           return  _fixedDepositProductManager.SaveFixedDepositProduct(fixedDepositProduct);
            

        }

        public int GetProductId(string productName, string productCode)
        {
            return _fixedDepositProductManager.GetProductId(productName, productCode);
        }

        public IFixedDepositProduct FetchProduct(int productId)
        {
            return _fixedDepositProductManager.FetchProduct(productId);
        }
         public void UpdateFixedDepositProduct(FixedDepositProduct product,int productId)
         {
             _fixedDepositProductManager.UpdateFixedDepositProduct(product, productId);
         }
         public List<IFixedDepositProduct> FetchProduct(bool showAlsoDeleted)
         {
             return _fixedDepositProductManager.FetchProduct(showAlsoDeleted);
         }

        private void ValidateProduct(IFixedDepositProduct fixedDepositProduct)
        {
        }

    }
}
