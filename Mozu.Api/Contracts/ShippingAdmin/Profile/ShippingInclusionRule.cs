
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.ShippingAdmin;

namespace Mozu.Api.Contracts.ShippingAdmin.Profile
{
		public class ShippingInclusionRule
		{
			public AuditInfo AuditInfo { get; set; }

			public string Id { get; set; }

			public List<string> ProductTargetRuleCodes { get; set; }

			public int Sequence { get; set; }

			public List<ServiceType> ServiceTypes { get; set; }

			public List<string> ShippingTargetRuleCodes { get; set; }

		}

}