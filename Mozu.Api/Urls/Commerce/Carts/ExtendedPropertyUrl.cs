
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

namespace Mozu.Api.Urls.Commerce.Carts
{
	public partial class ExtendedPropertyUrl 
	{

		/// <summary>
        /// Get Resource Url for GetExtendedProperties
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetExtendedPropertiesUrl()
		{
			var url = "/api/commerce/carts/current/extendedproperties";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddExtendedProperties
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddExtendedPropertiesUrl()
		{
			var url = "/api/commerce/carts/current/extendedproperties";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateExtendedProperty
        /// </summary>
        /// <param name="key"></param>
        /// <param name="responseFields"></param>
        /// <param name="upsert"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateExtendedPropertyUrl(string key, bool? upsert =  null, string responseFields =  null)
		{
			var url = "/api/commerce/carts/current/extendedproperties/{key}?upsert={upsert}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "key", key);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "upsert", upsert);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateExtendedProperties
        /// </summary>
        /// <param name="upsert"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateExtendedPropertiesUrl(bool? upsert =  null)
		{
			var url = "/api/commerce/carts/current/extendedproperties?upsert={upsert}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "upsert", upsert);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteExtendedProperties
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteExtendedPropertiesUrl()
		{
			var url = "/api/commerce/carts/current/extendedproperties";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteExtendedProperty
        /// </summary>
        /// <param name="key"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteExtendedPropertyUrl(string key)
		{
			var url = "/api/commerce/carts/current/extendedproperties/{key}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "key", key);
			return mozuUrl;
		}

		
	}
}
