
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce
{
	public partial class WishlistUrl 
	{

		/// <summary>
        /// Get Resource Url for GetWishlists
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="q">A list of search terms to use in the query when searching across wish list name. Separate multiple search terms with a space character.</param>
        /// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetWishlistsUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string q =  null, int? qLimit =  null, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&q={q}&qLimit={qLimit}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "q", q);
			mozuUrl.FormatUrl( "qLimit", qLimit);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetWishlist
        /// </summary>
        /// <param name="responseFields"></param>
        /// <param name="wishlistId">Unique identifier of the shopper wish list to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetWishlistUrl(string wishlistId, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/{wishlistId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetWishlistByName
        /// </summary>
        /// <param name="customerAccountId">The unique identifier of the customer account for which to retrieve wish lists.</param>
        /// <param name="responseFields"></param>
        /// <param name="wishlistName">The name of the wish list to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetWishlistByNameUrl(int customerAccountId, string wishlistName, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/customers/{customerAccountId}/{wishlistName}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "customerAccountId", customerAccountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "wishlistName", wishlistName);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for CreateWishlist
        /// </summary>
        /// <param name="responseFields"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl CreateWishlistUrl(string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateWishlist
        /// </summary>
        /// <param name="responseFields"></param>
        /// <param name="wishlistId">Unique identifier of the shopper wish list to update.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateWishlistUrl(string wishlistId, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/{wishlistId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteWishlist
        /// </summary>
        /// <param name="wishlistId">Unique identifier of the wish list to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteWishlistUrl(string wishlistId)
		{
			var url = "/api/commerce/wishlists/{wishlistId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			return mozuUrl;
		}

		
	}
}

