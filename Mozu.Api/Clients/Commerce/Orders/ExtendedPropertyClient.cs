
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

namespace Mozu.Api.Clients.Commerce.Orders
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ExtendedPropertyClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="draft"></param>
		/// <param name="orderId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetExtendedProperties( orderId,  draft);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> GetExtendedPropertiesClient(string orderId, bool? draft =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ExtendedPropertyUrl.GetExtendedPropertiesUrl(orderId, draft);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <param name="extendedProperties"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddExtendedProperties( extendedProperties,  orderId,  updateMode,  version);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> AddExtendedPropertiesClient(List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> extendedProperties, string orderId, string updateMode =  null, string version =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ExtendedPropertyUrl.AddExtendedPropertiesUrl(orderId, updateMode, version);
			const string verb = "POST";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>(extendedProperties);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		/// <param name="orderId"></param>
		/// <param name="responseFields"></param>
		/// <param name="updateMode"></param>
		/// <param name="upsert"></param>
		/// <param name="version"></param>
		/// <param name="extendedProperty"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtendedProperty( extendedProperty,  orderId,  key,  updateMode,  version,  upsert,  responseFields);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> UpdateExtendedPropertyClient(Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty extendedProperty, string orderId, string key, string updateMode =  null, string version =  null, bool? upsert =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ExtendedPropertyUrl.UpdateExtendedPropertyUrl(orderId, key, updateMode, version, upsert, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>(extendedProperty);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="updateMode"></param>
		/// <param name="upsert"></param>
		/// <param name="version"></param>
		/// <param name="extendedProperties"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateExtendedProperties( extendedProperties,  orderId,  updateMode,  version,  upsert);
		///   var extendedPropertyClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>> UpdateExtendedPropertiesClient(List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty> extendedProperties, string orderId, string updateMode =  null, string version =  null, bool? upsert =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ExtendedPropertyUrl.UpdateExtendedPropertiesUrl(orderId, updateMode, version, upsert);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.CommerceRuntime.Commerce.ExtendedProperty>>(extendedProperties);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key"></param>
		/// <param name="orderId"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteExtendedProperty( orderId,  key,  updateMode,  version);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteExtendedPropertyClient(string orderId, string key, string updateMode =  null, string version =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ExtendedPropertyUrl.DeleteExtendedPropertyUrl(orderId, key, updateMode, version);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="updateMode"></param>
		/// <param name="version"></param>
		/// <param name="keys"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteExtendedProperties( keys,  orderId,  updateMode,  version);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteExtendedPropertiesClient(List<string> keys, string orderId, string updateMode =  null, string version =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.ExtendedPropertyUrl.DeleteExtendedPropertiesUrl(orderId, updateMode, version);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(keys);
			return mozuClient;

		}


	}

}

