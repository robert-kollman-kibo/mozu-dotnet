
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

namespace Mozu.Api.Urls.Commerce.Wishlists
{
	public partial class WishlistItemUrl 
	{

		/// <summary>
        /// Get Resource Url for GetWishlistItem
        /// </summary>
        /// <param name="responseFields"></param>
        /// <param name="wishlistId">Unique identifier of the wish list item to retrieve.</param>
        /// <param name="wishlistItemId">Unique identifier of the wish list associated with the item to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetWishlistItemUrl(string wishlistId, string wishlistItemId, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/{wishlistId}/items/{wishlistItemId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			mozuUrl.FormatUrl( "wishlistItemId", wishlistItemId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetWishlistItems
        /// </summary>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
        /// <param name="wishlistId">Unique identifier of the wish list associated with the items to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetWishlistItemsUrl(string wishlistId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/{wishlistId}/items?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetWishlistItemsByWishlistName
        /// </summary>
        /// <param name="customerAccountId"></param>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <param name="wishlistName"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetWishlistItemsByWishlistNameUrl(int customerAccountId, string wishlistName, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/customers/{customerAccountId}/{wishlistName}/items?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "customerAccountId", customerAccountId);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			mozuUrl.FormatUrl( "wishlistName", wishlistName);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddItemToWishlist
        /// </summary>
        /// <param name="responseFields"></param>
        /// <param name="wishlistId">Unique identifier of the wish list associated with the item to add.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddItemToWishlistUrl(string wishlistId, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/{wishlistId}/items?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateWishlistItemQuantity
        /// </summary>
        /// <param name="quantity">The quantity of the item in the wish list.</param>
        /// <param name="responseFields"></param>
        /// <param name="wishlistId">Unique identifier of the wish list associated with the item quantity to update.</param>
        /// <param name="wishlistItemId">Unique identifier of the item in the wish list to update quantity.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateWishlistItemQuantityUrl(string wishlistId, string wishlistItemId, int quantity, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/{wishlistId}/items/{wishlistItemId}/{quantity}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "quantity", quantity);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			mozuUrl.FormatUrl( "wishlistItemId", wishlistItemId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateWishlistItem
        /// </summary>
        /// <param name="responseFields"></param>
        /// <param name="wishlistId">Unique identifier of the wish list associated with the item to update.</param>
        /// <param name="wishlistItemId">Unique identifier of the item in the shopper wish list to update.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateWishlistItemUrl(string wishlistId, string wishlistItemId, string responseFields =  null)
		{
			var url = "/api/commerce/wishlists/{wishlistId}/items/{wishlistItemId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			mozuUrl.FormatUrl( "wishlistItemId", wishlistItemId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for RemoveAllWishlistItems
        /// </summary>
        /// <param name="wishlistId">Unique identifier of the wish list associated with the items to remove.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RemoveAllWishlistItemsUrl(string wishlistId)
		{
			var url = "/api/commerce/wishlists/{wishlistId}/items";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteWishlistItem
        /// </summary>
        /// <param name="wishlistId">Unique identifier of the wish list associated with the item to remove.</param>
        /// <param name="wishlistItemId">Unique identifier of the item to remove from the shopper wish list.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteWishlistItemUrl(string wishlistId, string wishlistItemId)
		{
			var url = "/api/commerce/wishlists/{wishlistId}/items/{wishlistItemId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "wishlistId", wishlistId);
			mozuUrl.FormatUrl( "wishlistItemId", wishlistItemId);
			return mozuUrl;
		}

		
	}
}

