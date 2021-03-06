
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

namespace Mozu.Api.Clients.Commerce.Catalog.Storefront
{
	/// <summary>
	/// 
	/// </summary>
	public partial class AutoAddDiscountTargetClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="discountId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.PricingRuntime.AutoAddDiscountTarget"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAutoAddTarget( discountId,  responseFields);
		///   var autoAddDiscountTargetClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.PricingRuntime.AutoAddDiscountTarget> GetAutoAddTargetClient(int discountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Storefront.AutoAddDiscountTargetUrl.GetAutoAddTargetUrl(discountId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.PricingRuntime.AutoAddDiscountTarget>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


