
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		public class CurrencyExchangeRate
		{
			public AuditInfo AuditInfo { get; set; }

			public string FromCurrencyCode { get; set; }

			public decimal? Multiplier { get; set; }

			public decimal? Rate { get; set; }

			public string ReferenceData { get; set; }

			public string ToCurrencyCode { get; set; }

		}

}