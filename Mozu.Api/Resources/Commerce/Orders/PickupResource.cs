
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// Use the Pickups resource to organize items submitted in an order into pickups that enable the shopper to fulfill the order items using the in-store pickup method.
	/// </summary>
	public partial class PickupResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public PickupResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public PickupResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PickupResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves a list of the actions available to perform for the pickup specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="pickupId">Unique identifier of the pickup to remove.</param>
		/// <returns>
		/// List{string}
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   var string = await pickup.GetAvailablePickupFulfillmentActionsAsync( orderId,  pickupId);
		/// </code>
		/// </example>
		public virtual async Task<List<string>> GetAvailablePickupFulfillmentActionsAsync(string orderId, string pickupId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<string>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.GetAvailablePickupFulfillmentActionsClient( orderId,  pickupId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of the in-store pickup specified in the request.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="pickupId">Unique identifier of the pickup to remove.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   var pickup = await pickup.GetPickupAsync( orderId,  pickupId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> GetPickupAsync(string orderId, string pickupId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.GetPickupClient( orderId,  pickupId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Create a new pickup for the order specified in the request for in-store fufillment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="pickup">Properties of an in-store pickup defined to fulfill items in an order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   var pickup = await pickup.CreatePickupAsync( pickup,  orderId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> CreatePickupAsync(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup pickup, string orderId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.CreatePickupClient( pickup,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates one or more details of a defined in-store pickup.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="pickupId">Unique identifier of the pickup to remove.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="pickup">Properties of an in-store pickup defined to fulfill items in an order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   var pickup = await pickup.UpdatePickupAsync( pickup,  orderId,  pickupId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> UpdatePickupAsync(Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup pickup, string orderId, string pickupId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Pickup> response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.UpdatePickupClient( pickup,  orderId,  pickupId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Removes a pickup previously defined for order item in-store pickup fulfillment.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="pickupId">Unique identifier of the pickup to remove.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var pickup = new Pickup();
		///   await pickup.DeletePickupAsync( orderId,  pickupId);
		/// </code>
		/// </example>
		public virtual async Task DeletePickupAsync(string orderId, string pickupId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.PickupClient.DeletePickupClient( orderId,  pickupId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


