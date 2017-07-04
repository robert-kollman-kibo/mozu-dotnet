
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

namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class CouponSetUrl 
	{

		/// <summary>
        /// Get Resource Url for GetCouponSets
        /// </summary>
        /// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
        /// <param name="includeCounts">Specifies whether to include the number of redeemed coupons, existing coupon codes, and assigned discounts in the response body.</param>
        /// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for more information.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCouponSetsUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, bool? includeCounts =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&includeCounts={includeCounts}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "includeCounts", includeCounts);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetCouponSet
        /// </summary>
        /// <param name="couponSetCode">The unique identifier of the coupon set.</param>
        /// <param name="includeCounts">Specifies whether to include the number of redeemed coupons, existing coupon codes, and assigned discounts in the response body.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCouponSetUrl(string couponSetCode, bool? includeCounts =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}?includeCounts={includeCounts}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			mozuUrl.FormatUrl( "includeCounts", includeCounts);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetUniqueCouponSetCode
        /// </summary>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetUniqueCouponSetCodeUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/unique-code?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddCouponSet
        /// </summary>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddCouponSetUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ValidateUniqueCouponSetCode
        /// </summary>
        /// <param name="code">User-defined code that uniqely identifies the channel group.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ValidateUniqueCouponSetCodeUrl(string code)
		{
			var url = "/api/commerce/catalog/admin/couponsets/validate-unique-code";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "code", code);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateCouponSet
        /// </summary>
        /// <param name="couponSetCode">The unique identifier of the coupon set.</param>
        /// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateCouponSetUrl(string couponSetCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteCouponSet
        /// </summary>
        /// <param name="couponSetCode">The unique identifier of the coupon set.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteCouponSetUrl(string couponSetCode)
		{
			var url = "/api/commerce/catalog/admin/couponsets/{couponSetCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "couponSetCode", couponSetCode);
			return mozuUrl;
		}

		
	}
}

