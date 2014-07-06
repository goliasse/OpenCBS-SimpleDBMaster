﻿// Octopus MFS is an integrated suite for managing a Micro Finance Institution: 
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

using OpenCBS.CoreDomain.Contracts.Loans.Installments;
using OpenCBS.Enums;
using OpenCBS.Shared;
using OpenCBS.CoreDomain.Accounting;

namespace OpenCBS.CoreDomain.Products
{
    public interface IFixedDepositProduct
    {

       int Id { get; set; }
        int Delete { get; set; }
        string Name { get; set; }
        string Code { get; set; }
        string ClientType { get; set; }
        string Currency { get; set; }
        decimal? InitialAmountMin { get; set; }
        decimal? InitialAmountMax { get; set; }
        string InterestCalculationFrequency { get; set; }
        string PenalityType { get; set; }

        double? InterestRateMin { get; set; }
        double? InterestRateMax { get; set; }
        double? PenalityRateMin { get; set; }
        double? PenalityRateMax { get; set; }
        int? MaturityPeriodMin { get; set; }
        int? MaturityPeriodMax { get; set; }
        double? PenalityValue { get; set; }
    }
}
