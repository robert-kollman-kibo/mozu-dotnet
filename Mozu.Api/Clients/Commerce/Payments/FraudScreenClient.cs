
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

namespace Mozu.Api.Clients.Commerce.Payments
{
	/// <summary>
	/// commerce/payments/fraudscreen related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class FraudScreenClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="request"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.PaymentService.Response.FraudScreen"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=Screen( request,  responseFields);
		///   var fraudScreenClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.PaymentService.Response.FraudScreen> ScreenClient(Mozu.Api.Contracts.PaymentService.Request.FraudScreenRequest request, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Payments.FraudScreenUrl.ScreenUrl(responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.PaymentService.Response.FraudScreen>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.PaymentService.Request.FraudScreenRequest>(request);
			return mozuClient;

		}


	}

}


