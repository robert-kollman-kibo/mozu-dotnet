
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Attribute search settings are a container for all of the search and indexing settings of an attribute.
		///
		public class AttributeSearchSettings
		{
			///
			///Indicates whether the attribute should be able to be used in filters, facets, and sorting on the public storefront.
			///
			public bool? AllowFilteringAndSortingInStorefront { get; set; }

			///
			///Specifies whether to create a case-sensitive Solr search index. The default is .
			///
			public bool? IndexValueWithCase { get; set; }

			///
			///Indicates whether the attribute value is searchable in the merchant catalog admin.
			///
			public bool SearchableInAdmin { get; set; }

			///
			///Indicates if the attribute value is searchable on the public storefront.
			///
			public bool SearchableInStorefront { get; set; }

			///
			///Indicates what kind of values search queries and returns. If true, the system indexes the display value of string attributes instead of the canonical value for searching. Always use the canonical value for filtering. This does not apply for non-string attributes.
			///
			public bool SearchDisplayValue { get; set; }

		}

}