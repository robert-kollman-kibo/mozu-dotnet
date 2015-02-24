
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductRuntime
{
		///
		///	System-supplied and read only information for component products in a product bundle.
		///
		public class BundledProductSummary
		{
			///
			///The credit value of the product or bundled product. When the `goodsType `is `DigitalCredit`, this value is populated to indicate the value of the credit. This is used to create store credit in the fulfillment of gift cards.
			///
			public decimal? CreditValue { get; set; }

			///
			///The type of goods in a bundled product. A bundled product is composed of products associated to sell together. Possible values include “Physical” and “DigitalCredit”. This comes from the `productType `of the product. Products are defaulted to a Physical `goodsType`. Gift cards have a `goodsType `of DigitalCredit.
			///
			public string GoodsType { get; set; }

			///
			///Properties and data of inventory information for configured and bundled products. If product stock is managed, the data specifies out of stock behavior.
			///
			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///Indicates if the product must be shipped alone in a container. This is used for products and products within a bundle. If true, this product cannot be shipped in a package with other items and must ship in a package by itself.
			///
			public bool? IsPackagedStandAlone { get; set; }

			///
			///Dimensions of the packaged product.
			///
			public PackageMeasurements Measurements { get; set; }

			///
			///Fully qualified name of the selected option's attribute. Bundledproducts result from a static bundle or are dynamically added as a result of the shopper selecting products as extras. When the bundled item is dynamic, it includes the attribute's fully qualified name of the extra that it came from. When `optionAttributeFQN `is null, the bundled item was statically defined. When not null, the item came from an extra selection.
			///
			public string OptionAttributeFQN { get; set; }

			///
			///The value of the option attribute. These values are associated and used by product bundles and options.
			///
			public object OptionValue { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
			public string ProductCode { get; set; }

			///
			///The name of the product that represents a line item in a taxable order or product bundle.
			///
			public string ProductName { get; set; }

			///
			///Brief text description of the product or component in a product bundle, typically used when the product is displayed in a list or in search results.
			///
			public string ProductShortDescription { get; set; }

			///
			///The product type template associated with the product on the storefront.
			///
			public string ProductType { get; set; }

			///
			///The specified quantity of objects and items. This property is used for numerous object types including products, options, components within a product bundle, cart and order items, returned items, shipping line items, items in a digital product. and items associated with types and reservations.
			///
			public int Quantity { get; set; }

		}

}