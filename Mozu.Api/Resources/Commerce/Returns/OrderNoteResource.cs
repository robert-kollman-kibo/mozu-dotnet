
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

namespace Mozu.Api.Resources.Commerce.Returns
{
	/// <summary>
	/// Use the Return Notes resource to access and modify internal notes associated with returns. These notes can be useful to customer service representatives viewing them in .
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
		/// Retrieves all internal notes associated with a return.
		/// </summary>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = await ordernote.GetReturnNotesAsync( returnId);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> GetReturnNotesAsync(string returnId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote>> response;
			var client = Mozu.Api.Clients.Commerce.Returns.OrderNoteClient.GetReturnNotesClient( returnId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a specific internal note from a return.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = await ordernote.GetReturnNoteAsync( returnId,  noteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> GetReturnNoteAsync(string returnId, string noteId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Returns.OrderNoteClient.GetReturnNoteClient( returnId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates an internal note on a given return. This note is visible in  for customer service representatives to see.
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="returnNote"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = await ordernote.CreateReturnNoteAsync( returnNote,  returnId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> CreateReturnNoteAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote returnNote, string returnId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Returns.OrderNoteClient.CreateReturnNoteClient( returnNote,  returnId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates an internal note on a given return. This note is visible in  for customer service representatives to see.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <param name="returnNote"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   var orderNote = await ordernote.UpdateReturnNoteAsync( returnNote,  returnId,  noteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> UpdateReturnNoteAsync(Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote returnNote, string returnId, string noteId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Orders.OrderNote> response;
			var client = Mozu.Api.Clients.Commerce.Returns.OrderNoteClient.UpdateReturnNoteClient( returnNote,  returnId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes an internal note from a given return.
		/// </summary>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="returnId">Unique identifier of the return whose items you want to get.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var ordernote = new OrderNote();
		///   await ordernote.DeleteReturnNoteAsync( returnId,  noteId);
		/// </code>
		/// </example>
		public virtual async Task DeleteReturnNoteAsync(string returnId, string noteId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Returns.OrderNoteClient.DeleteReturnNoteClient( returnId,  noteId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


