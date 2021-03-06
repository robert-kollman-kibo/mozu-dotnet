
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

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of a product associated with a specific catalog.
		///
		public class ProductInCatalogInfo
		{
			///
			///If true, the product is marked as available for sale in the catalog. Setting a product to IsActive = false will prevent it from being shown on the customer facing storefront.
			///
			public ActiveDateRange ActiveDateRange { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public int CatalogId { get; set; }

			public ProductLocalizedContent Content { get; set; }

			///
			///Date this product was first Available for sale in the catalog. This is utilized in expressions that refrence DaysInCatloag.
			///
			public DateTime? DateFirstAvailableInCatalog { get; set; }

			public bool? IsActive { get; set; }

			public bool? IsContentOverridden { get; set; }

			public bool? IsPriceOverridden { get; set; }

			public bool? IsseoContentOverridden { get; set; }

			public ProductPrice Price { get; set; }

			///
			///Specifies which static category to use in the navigation breadcrumb, regardless of how shoppers navigate to the product. If not set, or if the product belongs only to dynamic categories, the default is to use the category with the smallest ID.
			///
			public ProductCategory PrimaryProductCategory { get; set; }

			public List<ProductCategory> ProductCategories { get; set; }

			public ProductLocalizedSEOContent SeoContent { get; set; }

		}

}