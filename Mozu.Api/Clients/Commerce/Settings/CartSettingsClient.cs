
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

namespace Mozu.Api.Clients.Commerce.Settings
{
	/// <summary>
	/// Use the cart subresource to manage settings for the cart, such as whether to include handling fees in the cost calculations.
	/// </summary>
	public partial class CartSettingsClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCartSettings( responseFields);
		///   var cartSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> GetCartSettingsClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.CartSettingsUrl.GetCartSettingsUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartSettings"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateCartSettings( cartSettings,  responseFields);
		///   var cartSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> CreateCartSettingsClient(Mozu.Api.Contracts.SiteSettings.Order.CartSettings cartSettings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.CartSettingsUrl.CreateCartSettingsUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.Order.CartSettings>(cartSettings);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="cartSettings"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.SiteSettings.Order.CartSettings"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCartSettings( cartSettings,  responseFields);
		///   var cartSettingsClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings> UpdateCartSettingsClient(Mozu.Api.Contracts.SiteSettings.Order.CartSettings cartSettings, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Settings.CartSettingsUrl.UpdateCartSettingsUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.SiteSettings.Order.CartSettings>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.SiteSettings.Order.CartSettings>(cartSettings);
			return mozuClient;

		}


	}

}

