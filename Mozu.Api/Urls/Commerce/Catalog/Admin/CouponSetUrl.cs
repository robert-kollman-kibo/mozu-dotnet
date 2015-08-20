
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
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetCouponSetsUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/couponsets/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetUniqueCouponSetCode
        /// </summary>
        /// <param name="responseFields"></param>
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
        /// <param name="responseFields"></param>
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
        /// <param name="code"></param>
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

						
	}
}

