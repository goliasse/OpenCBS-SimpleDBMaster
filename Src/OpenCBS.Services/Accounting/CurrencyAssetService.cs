// Octopus MFS is an integrated suite for managing a Micro Finance Institution: 
// clients, contracts, accounting, reporting and risk
// Copyright © 2006,2007 OCTO Technology & OXUS Development Network
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//
// Website: http://www.opencbs.com
// Contact: contact@opencbs.com

using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using OpenCBS.DatabaseConnection;
using OpenCBS.ExceptionsHandler.Exceptions.AccountExceptions;
using OpenCBS.Manager.Accounting;
using OpenCBS.CoreDomain;
using OpenCBS.ExceptionsHandler;
using OpenCBS.Reports;
using OpenCBS.Shared;
using OpenCBS.CoreDomain.Accounting;
using OpenCBS.Services.Currencies;
using OpenCBS.Enums;
using OpenCBS.Manager;
namespace OpenCBS.Services.Accounting
{
    public class CurrencyAssetService
    {
        private readonly CurrencyAssetManager _currencyAssetsManager;

        private readonly User _user;


        public CurrencyAssetService(CurrencyAssetManager CurrencyAssetManager)
        {
            _currencyAssetsManager = CurrencyAssetManager;
        }

        public CurrencyAssetService(User pUser)
        {
            _user = pUser;

            _currencyAssetsManager = new CurrencyAssetManager(pUser);
        }

        public CurrencyAssetService(string testDb)
        {
           

            _currencyAssetsManager = new CurrencyAssetManager(testDb);

        }

        public CurrencyAssets FetchCurrencyAssets(int id)
        {
            return _currencyAssetsManager.FetchCurrencyAssets(id);
        }

        public List<CurrencyAssets> FetchAll()
        {
            return _currencyAssetsManager.FetchAll();
        }

        public int SaveCurrencyAssets(CurrencyAssets currencyAssets)
        {
            ValidateCurrencyAssets(currencyAssets);
            return _currencyAssetsManager.SaveCurrencyAssets(currencyAssets);
        }
        public int DeleteCurrencyAssets(int id)
        {
            return _currencyAssetsManager.DeleteCurrencyAssets(id);
            
        }
        private void ValidateCurrencyAssets(CurrencyAssets currencyAssets)
        {

            if (currencyAssets.AssetDate == null)
                throw new OpenCbsCurrencyAssetException(OpenCbsCurrencyAssetExceptionEnum.AssetDateIsEmpty);
            //if (currencyAssets.AssetDate.Date < DateTime.Now.Date)
            //    throw new OpenCbsCurrencyAssetException(OpenCbsCurrencyAssetExceptionEnum.AssetDateIsInvalid);

            if (string.IsNullOrEmpty(currencyAssets.AssetCategory))
                throw new OpenCbsCurrencyAssetException(OpenCbsCurrencyAssetExceptionEnum.AssetCategoryIsEmpty);

            if (string.IsNullOrEmpty(currencyAssets.AssetDescription))
                throw new OpenCbsCurrencyAssetException(OpenCbsCurrencyAssetExceptionEnum.AssetDescriptionIsEmpty);

            if (!currencyAssets.AssetAmount.HasValue)
                throw new OpenCbsCurrencyAssetException(OpenCbsCurrencyAssetExceptionEnum.AssetAmountIsEmpty);

            if (Convert.ToDecimal(currencyAssets.AssetAmount.Value) < 0)
                throw new OpenCbsCurrencyAssetException(OpenCbsCurrencyAssetExceptionEnum.AssetAmountIsInvalid);

            if (string.IsNullOrEmpty(currencyAssets.Reference))
                throw new OpenCbsCurrencyAssetException(OpenCbsCurrencyAssetExceptionEnum.ReferenceIsEmpty);
        }

    }
}
