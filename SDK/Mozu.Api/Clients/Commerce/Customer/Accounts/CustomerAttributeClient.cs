
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Clients.Commerce.Customer.Accounts
{
	/// <summary>
	/// Use the Attributes subresource to manage the attributes used to uniquely identify shopper accounts, such as gender or age.
	/// </summary>
	public partial class CustomerAttributeClient 	{
		
		/// <summary>
		/// Retrieves the contents of an attribute associated with the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountAttribute( accountId,  attributeFQN,  responseFields);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> GetAccountAttributeClient(int accountId, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.GetAccountAttributeUrl(accountId, attributeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the list of customer account attributes.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttributeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountAttributes( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var customerAttributeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection> GetAccountAttributesClient(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.GetAccountAttributesUrl(accountId, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttributeCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Applies a defined attribute to the customer account specified in the request and assigns a value to the customer attribute.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="attribute">Properties of an attribute associated with a customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountAttribute( attribute,  accountId,  responseFields);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> AddAccountAttributeClient(Mozu.Api.Contracts.Customer.CustomerAttribute attribute, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.AddAccountAttributeUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAttribute>(attribute);
			return mozuClient;

		}

		/// <summary>
		/// Updates one or more details of a customer account attribute.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="attribute">Properties of an attribute associated with a customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAttribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccountAttribute( attribute,  accountId,  attributeFQN,  responseFields);
		///   var customerAttributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute> UpdateAccountAttributeClient(Mozu.Api.Contracts.Customer.CustomerAttribute attribute, int accountId, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.UpdateAccountAttributeUrl(accountId, attributeFQN, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAttribute>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAttribute>(attribute);
			return mozuClient;

		}

		/// <summary>
		/// Removes the attribute specified in the request from the customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAccountAttribute( accountId,  attributeFQN);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAccountAttributeClient(int accountId, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerAttributeUrl.DeleteAccountAttributeUrl(accountId, attributeFQN);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


