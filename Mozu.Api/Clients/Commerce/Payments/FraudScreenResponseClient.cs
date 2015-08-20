
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

namespace Mozu.Api.Clients.Commerce.Payments
{
	/// <summary>
	/// 
	/// </summary>
	public partial class FraudScreenResponseClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="request"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.PaymentService.Response.FraudScreenResponse"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=Screen( request);
		///   var fraudScreenResponseClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.PaymentService.Response.FraudScreenResponse> ScreenClient(Mozu.Api.Contracts.PaymentService.Request.FraudScreenRequest request)
		{
			var url = Mozu.Api.Urls.Commerce.Payments.FraudScreenResponseUrl.ScreenUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.PaymentService.Response.FraudScreenResponse>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.PaymentService.Request.FraudScreenRequest>(request);
			return mozuClient;

		}


	}

}


