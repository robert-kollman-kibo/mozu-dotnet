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
using System.Threading;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Use the ShippingStates sub-resource to manage the states your shipping profile supports. For example, you can specify one of your shipping profiles to only support Texas, Oklahoma, Arkansas, Louisiana, and New Mexico.Each shipping state is composed of a user-definied code and name.
	/// </summary>
	public partial class ShippingStatesFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves a list of shipping states and their details.
		/// <example> 
		///  <code> 
		/// var result = ShippingStatesFactory.GetStates(handler : handler,  profileCode :  profileCode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<ShippingStates>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates> GetStates(ServiceClientMessageHandler handler, 
 		 string profileCode, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingStatesClient.GetStatesClient(
				 profileCode :  profileCode		);
			try
			{
				apiClient.WithContext(handler.ApiContext).ExecuteAsync(default(CancellationToken)).Wait();
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
  
		/// <summary> 
		/// Updates the details of the shipping states.
		/// <example> 
		///  <code> 
		/// var result = ShippingStatesFactory.UpdateStates(handler : handler,  states :  states,  profilecode :  profilecode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<List<ShippingStates>/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates> UpdateStates(ServiceClientMessageHandler handler, 
 		 List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates> states, string profilecode, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingStatesClient.UpdateStatesClient(
				 states :  states,  profilecode :  profilecode		);
			try
			{
				apiClient.WithContext(handler.ApiContext).ExecuteAsync(default(CancellationToken)).Wait();
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


