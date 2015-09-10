
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
		///	The result of a product search.
		///
		public class ProductSearchResult
		{
			///
			///The facets applied to index products in the product search result.
			///
			public List<Facet> Facets { get; set; }

			///
			///An array list of objects in the returned collection.
			///
			public List<Product> Items { get; set; }

			///
			///The number of pages returned based on the startIndex and pageSize values specified. This value is system-supplied and read-only.
			///
			public int PageCount { get; set; }

			///
			///The number of results to display on each page when creating paged results from a query. The maximum value is 200.
			///
			public int PageSize { get; set; }

			///
			///Mozu.ProductRuntime.Contracts.ProductSearchResult solrDebugInfo ApiTypeMember DOCUMENT_HERE 
			///
			public SolrDebugInfo SolrDebugInfo { get; set; }

			public int StartIndex { get; set; }

			///
			///The number of results listed in the query collection, represented by a signed 64-bit (8-byte) integer. This value is system-supplied and read-only.
			///
			public int TotalCount { get; set; }

		}

}