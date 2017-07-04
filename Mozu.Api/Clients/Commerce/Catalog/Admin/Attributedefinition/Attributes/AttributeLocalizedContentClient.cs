
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
using System.Threading;

namespace Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes
{
	/// <summary>
	/// Properties of localized content for attributes, based on a `localeCode` at a site/tenant level. This content supports translated text for product, product options, and additional objects. 
	/// </summary>
	public partial class AttributeLocalizedContentClient 	{
		
		/// <summary>
		/// Retrieves a collection of localized content for attributes based on a `localeCode`.
		/// </summary>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeLocalizedContents( attributeFQN);
		///   var attributeLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>> GetAttributeLocalizedContentsClient(string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentUrl.GetAttributeLocalizedContentsUrl(attributeFQN);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the localized content for an attribute based on a `localeCode`.
		/// </summary>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeLocalizedContent( attributeFQN,  localeCode,  responseFields);
		///   var attributeLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> GetAttributeLocalizedContentClient(string attributeFQN, string localeCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentUrl.GetAttributeLocalizedContentUrl(attributeFQN, localeCode, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Adds new localized content for an attribute based on a `localeCode`.
		/// </summary>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent">The localized name and description of the attribute, displayed in the locale defined for the master catalog.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddLocalizedContent( localizedContent,  attributeFQN,  responseFields);
		///   var attributeLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> AddLocalizedContentClient(Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent localizedContent, string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentUrl.AddLocalizedContentUrl(attributeFQN, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>(localizedContent);
			return mozuClient;

		}

		/// <summary>
		/// Updates the localized content for a collection of existing attributes based on a `localeCode`.
		/// </summary>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent">The localized name and description of the attribute, displayed in the locale defined for the master catalog.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateLocalizedContents( localizedContent,  attributeFQN);
		///   var attributeLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>> UpdateLocalizedContentsClient(List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> localizedContent, string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentUrl.UpdateLocalizedContentsUrl(attributeFQN);
			const string verb = "PUT";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>>(localizedContent);
			return mozuClient;

		}

		/// <summary>
		/// Updates the localized content for an existing attribute based on a `localeCode`.
		/// </summary>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="localizedContent">The localized name and description of the attribute, displayed in the locale defined for the master catalog.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateLocalizedContent( localizedContent,  attributeFQN,  localeCode,  responseFields);
		///   var attributeLocalizedContentClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent> UpdateLocalizedContentClient(Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent localizedContent, string attributeFQN, string localeCode, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentUrl.UpdateLocalizedContentUrl(attributeFQN, localeCode, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.AttributeLocalizedContent>(localizedContent);
			return mozuClient;

		}

		/// <summary>
		/// Removes all localized content. Localized content is translated text information and data based on a `localeCode`. 
		/// </summary>
		/// <param name="attributeFQN">Fully qualified name for an attribute.</param>
		/// <param name="localeCode">Language used for the entity. Currently, only "en-US" is supported.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteLocalizedContent( attributeFQN,  localeCode);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteLocalizedContentClient(string attributeFQN, string localeCode)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeLocalizedContentUrl.DeleteLocalizedContentUrl(attributeFQN, localeCode);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


