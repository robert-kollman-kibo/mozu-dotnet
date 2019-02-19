
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

namespace Mozu.Api.Urls.Commerce.Customer.Accounts
{
	public partial class CustomerAttributeUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAccountAttribute
        /// </summary>
        /// <param name="accountId">Identifier of the customer account associated with the attribute to retrieve.</param>
        /// <param name="attributeFQN"></param>
        /// <param name="responseFields"></param>
        /// <param name="userId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountAttributeUrl(int accountId, string attributeFQN, string userId =  null, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/attributes/{attributeFQN}?userId={userId}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAccountAttributes
        /// </summary>
        /// <param name="accountId">Identifier of the customer account associated with the attributes to retrieve.</param>
        /// <param name="filter"></param>
        /// <param name="pageSize"></param>
        /// <param name="responseFields"></param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <param name="userId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountAttributesUrl(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string userId =  null, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/attributes?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&userId={userId}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddAccountAttribute
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="responseFields"></param>
        /// <param name="userId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddAccountAttributeUrl(int accountId, string userId =  null, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/attributes?userId={userId}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateAccountAttribute
        /// </summary>
        /// <param name="accountId">Identifier of the customer account associated with the attribute.</param>
        /// <param name="attributeFQN"></param>
        /// <param name="responseFields"></param>
        /// <param name="userId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateAccountAttributeUrl(int accountId, string attributeFQN, string userId =  null, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/attributes/{attributeFQN}?userId={userId}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteAccountAttribute
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="attributeFQN"></param>
        /// <param name="userId"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteAccountAttributeUrl(int accountId, string attributeFQN, string userId =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/attributes/{attributeFQN}?userId={userId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "userId", userId);
			return mozuUrl;
		}

		
	}
}

