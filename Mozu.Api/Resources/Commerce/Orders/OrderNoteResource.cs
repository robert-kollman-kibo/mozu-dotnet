
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
	/// Use the Order Notes subresource to manage merchant-level notes associated with an active order.
	/// </summary>
	public partial class OrderNoteResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public OrderNoteResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public OrderNoteResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new OrderNoteResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves a list of all notes for an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = await ordernote.GetOrderNotesAsync( orderId);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> GetOrderNotesAsync(string orderId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNotesClient( orderId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of a specific order note.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = await ordernote.GetOrderNoteAsync( orderId,  noteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> GetOrderNoteAsync(string orderId, string noteId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.GetOrderNoteClient( orderId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates a new merchant note for the specified order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="orderNote">Properties of an order note for a merchant, which is internal only for administrative purposes and not available to the shopper.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = await ordernote.CreateOrderNoteAsync( orderNote,  orderId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> CreateOrderNoteAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, string orderId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.CreateOrderNoteClient( orderNote,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates a specific note for an order.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="orderNote">Properties of an order note for a merchant, which is internal only for administrative purposes and not available to the shopper.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = await ordernote.UpdateOrderNoteAsync( orderNote,  orderId,  noteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> UpdateOrderNoteAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote orderNote, string orderId, string noteId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.UpdateOrderNoteClient( orderNote,  orderId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes the specified order note.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   await ordernote.DeleteOrderNoteAsync( orderId,  noteId);
		/// </code>
		/// </example>
		public virtual async Task DeleteOrderNoteAsync(string orderId, string noteId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.OrderNoteClient.DeleteOrderNoteClient( orderId,  noteId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


