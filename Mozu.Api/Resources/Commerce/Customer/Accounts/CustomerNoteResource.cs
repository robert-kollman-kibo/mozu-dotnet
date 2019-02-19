
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

namespace Mozu.Api.Resources.Commerce.Customer.Accounts
{
	/// <summary>
	/// This resources manages notes for a customer account. For example, a client can track a shopper's interests or complaints. Only clients can add and view notes. Shoppers cannot view these notes from the My Account page.
	/// </summary>
	public partial class CustomerNoteResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerNoteResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerNoteResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerNoteResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account that contains the note being retrieved.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = await customernote.GetAccountNoteAsync( accountId,  noteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerNote> GetAccountNoteAsync(int accountId, int noteId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.GetAccountNoteClient( accountId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNoteCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNoteCollection = await customernote.GetAccountNotesAsync( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerNoteCollection> GetAccountNotesAsync(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNoteCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.GetAccountNotesClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account for which to create the note.</param>
		/// <param name="responseFields"></param>
		/// <param name="note">Properties of the customer account note to create.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = await customernote.AddAccountNoteAsync( note,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerNote> AddAccountNoteAsync(Mozu.Api.Contracts.Customer.CustomerNote note, int accountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.AddAccountNoteClient( note,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account note to modify.</param>
		/// <param name="noteId">Unique identifier of the note to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="note">The new content to replace the existing note.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   var customerNote = await customernote.UpdateAccountNoteAsync( note,  accountId,  noteId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerNote> UpdateAccountNoteAsync(Mozu.Api.Contracts.Customer.CustomerNote note, int accountId, int noteId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.UpdateAccountNoteClient( note,  accountId,  noteId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account that contains the note being deleted.</param>
		/// <param name="noteId">Unique identifier of the customer account note being deleted.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customernote = new CustomerNote();
		///   await customernote.DeleteAccountNoteAsync( accountId,  noteId);
		/// </code>
		/// </example>
		public virtual async Task DeleteAccountNoteAsync(int accountId, int noteId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerNoteClient.DeleteAccountNoteClient( accountId,  noteId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


