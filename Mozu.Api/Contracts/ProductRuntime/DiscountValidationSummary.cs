
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


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	List of discounts the shopper can redeem for a product in its current state.
		///
		public class DiscountValidationSummary
		{
			///
			///List of discounts available per configured conditions and criteria. These discounts are associated with products, orders, and shipping costs. Shoppers can view these discounts per order, per product in an order, or for their shipping depending on the configuration.
			///
			public List<Discount> ApplicableDiscounts { get; set; }

		}

}