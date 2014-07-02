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

            bool name = _fixedDepositProductManager.CheckForDuplicateValue("FixedDepositProducts", "product_name", fixedDepositProduct.Name);
            bool code =_fixedDepositProductManager.CheckForDuplicateValue("FixedDepositProducts", "product_code", fixedDepositProduct.Code);
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
         public void UpdateFixedDepositProduct(IFixedDepositProduct product,int productId)
         {
             _fixedDepositProductManager.UpdateFixedDepositProduct(product, productId);
         }
         public List<IFixedDepositProduct> FetchProduct(bool showAlsoDeleted)
         {
             return _fixedDepositProductManager.FetchProduct(showAlsoDeleted);
         }

         public IFixedDepositProduct FetchProduct(string productName, string productCode)
         {
             return _fixedDepositProductManager.FetchProduct( productName, productCode);
         }

        public void DeleteFixedDepositProduct(int pProductId)
        {
            _fixedDepositProductManager.DeleteFixedDepositProduct(pProductId);
        }

        private void ValidateProduct(IFixedDepositProduct fixedDepositProduct)
        {
        }

    }
}
