//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// 
	/// </summary>
	public partial class FraudScreenFactory : BaseDataFactory
	{

		/// <summary> 
		/// 
		/// <example> 
		///  <code> 
		/// var result = FraudScreenFactory.Screen(handler : handler,  request :  request,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<FraudScreen/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.PaymentService.Response.FraudScreen Screen(ServiceClientMessageHandler handler, 
 		 Mozu.Api.Contracts.PaymentService.Request.FraudScreenRequest request, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Payments.FraudScreenClient.ScreenClient(
				 request :  request		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

