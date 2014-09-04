using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCBS.CoreDomain;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Manager;
using OpenCBS.Manager.Products;

namespace OpenCBS.Services
{
    public class FixedAssetRegisterService
    {
        private readonly FixedAssetRegisterManager _fixedAssetRegisterManager;
        private readonly CurrentAccountTransactionManager _currentAccountTransactionManager;
        private User _user;

        public FixedAssetRegisterService(FixedAssetRegisterManager fixedAssetRegisterManager)
        {
            _fixedAssetRegisterManager = fixedAssetRegisterManager;
        }

        public FixedAssetRegisterService(User user)
        {
            _user = user;
            _fixedAssetRegisterManager = new FixedAssetRegisterManager(user);
            _currentAccountTransactionManager = new CurrentAccountTransactionManager(user);
        }

        public int UpdateFixedAssetRegister(FixedAssetRegister fixedAssetRegister)
        {
           return _fixedAssetRegisterManager.UpdateFixedAssetRegister(fixedAssetRegister);
        }

        public List<FixedAssetRegister> FetchFixedAssetRegister(string branch)
        {
            return _fixedAssetRegisterManager.FetchFixedAssetRegister(branch);
        }
        public int InsertFixedAssetRecord(FixedAssetRegister fixedAssetRegister)
        {

            ValidateProduct(fixedAssetRegister);
            return _fixedAssetRegisterManager.InsertFixedAssetRecord(fixedAssetRegister);
        }

        public FixedAssetRegister FetchFixedAssetRecord(string assetId)
        {
            return _fixedAssetRegisterManager.FetchFixedAssetRecord(assetId);
        }

        private void ValidateProduct(FixedAssetRegister fixedAsset)
        {
            


            //if (fixedAsset.Branch == null)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterBranchIsNotSelected);

            //if (string.IsNullOrEmpty(fixedAsset.Description))
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAssetDescriptionIsEmpty);

            //if (string.IsNullOrEmpty(fixedAsset.AssetType))
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAssetTypeIsNotSelected);

            //if (fixedAsset.NoOfAssets == null)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterNoOfAssetsIsEmpty);

            //if (fixedAsset.NoOfAssets <= 0)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterNoOfAssetsIsInvalid);

            //if (fixedAsset.OriginalCost == null)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterOriginalCostIsEmpty);

            //if (fixedAsset.OriginalCost <= 0)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterOriginalCostIsInvalid);

            //if (fixedAsset.AnnualDepreciationRate == null)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAnnualDepreciationRateIsEmpty);

            //Need to be removed as Depreciation rate can be negative as well
            //if (fixedAsset.AnnualDepreciationRate <= 0)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAnnualDepreciationRateIsInvalid);

            //if (fixedAsset.AcquisitionCapitalFinance == null)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAcquisitionCapitalFinanceMethodIsNotSelected);

            //if (string.IsNullOrEmpty(fixedAsset.AcquisitionCapitalTransaction))
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAcquisitionCapitalTransactionIsEmpty);

            //Validate Acquisition Capital trsnaction number
            //if (_currentAccountTransactionManager.FetchTransaction(Convert.ToInt32(fixedAsset.AcquisitionCapitalTransaction)) == null)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterAcquisitionCapitalTransactionIsInvalid);

            //if (string.IsNullOrEmpty(fixedAsset.DisposalAmountTransfer))
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterDisposalAmountTransferMethodIsNotSelected);

            //if (string.IsNullOrEmpty(fixedAsset.DisposalAmountTransaction))
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterDisposalAmountTransactionIsEmpty);

            //Validate Disposal Amount trsnaction number
            //if (_currentAccountTransactionManager.FetchTransaction(Convert.ToInt32(fixedAsset.DisposalAmountTransaction)) == null)
            //    throw new OpenCbsFixedAssetException(OpenCbsFixedAssetExceptionEnum.FixedAssetRegisterDisposalAmountTransactionIsInvalid);

            
        }
    }
}
