
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

namespace Mozu.Api.Resources.Commerce.Shipping.Admin.Profiles
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ShippingStatesResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ShippingStatesResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ShippingStatesResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ShippingStatesResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// 
		/// </summary>
		/// <param name="profileCode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var shippingstates = new ShippingStates();
		///   var shippingStates = shippingstates.GetStates( profileCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates> GetStates(string profileCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates>> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingStatesClient.GetStatesClient( profileCode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="profileCode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var shippingstates = new ShippingStates();
		///   var shippingStates = await shippingstates.GetStatesAsync( profileCode);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates>> GetStatesAsync(string profileCode)
		{
			MozuClient<List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates>> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingStatesClient.GetStatesClient( profileCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="profilecode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="states"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var shippingstates = new ShippingStates();
		///   var shippingStates = shippingstates.UpdateStates( states,  profilecode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates> UpdateStates(List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates> states, string profilecode)
		{
			MozuClient<List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates>> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingStatesClient.UpdateStatesClient( states,  profilecode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="profilecode"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="states"></param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var shippingstates = new ShippingStates();
		///   var shippingStates = await shippingstates.UpdateStatesAsync( states,  profilecode);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates>> UpdateStatesAsync(List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates> states, string profilecode)
		{
			MozuClient<List<Mozu.Api.Contracts.ShippingAdmin.Profile.ShippingStates>> response;
			var client = Mozu.Api.Clients.Commerce.Shipping.Admin.Profiles.ShippingStatesClient.UpdateStatesClient( states,  profilecode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}

