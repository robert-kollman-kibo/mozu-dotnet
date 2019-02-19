
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
	/// Use the Cards subresource to manage stored credit cards for customer accounts.  stores limited card data in the Customer service for expedited ordering purposes; however, the complete card data is stored in the Payment service.
	/// </summary>
	public partial class CardResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CardResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CardResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CardResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="cardId">Unique identifier of the card associated with the customer account billing contact.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Card"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   var card = await card.GetAccountCardAsync( accountId,  cardId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Card> GetAccountCardAsync(int accountId, string cardId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.Card> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.GetAccountCardClient( accountId,  cardId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CardCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   var cardCollection = await card.GetAccountCardsAsync( accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CardCollection> GetAccountCardsAsync(int accountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.CardCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.GetAccountCardsClient( accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields"></param>
		/// <param name="card">Properties of the customer credit card to add to the account.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Card"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   var card = await card.AddAccountCardAsync( card,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Card> AddAccountCardAsync(Mozu.Api.Contracts.Customer.Card card, int accountId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.Card> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.AddAccountCardClient( card,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="cardId">Unique identifier of the credit card.</param>
		/// <param name="responseFields"></param>
		/// <param name="card">Properties of the customer account credit card to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.Card"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   var card = await card.UpdateAccountCardAsync( card,  accountId,  cardId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.Card> UpdateAccountCardAsync(Mozu.Api.Contracts.Customer.Card card, int accountId, string cardId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Customer.Card> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.UpdateAccountCardClient( card,  accountId,  cardId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="cardId">Unique identifier of the credit card to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var card = new Card();
		///   await card.DeleteAccountCardAsync( accountId,  cardId);
		/// </code>
		/// </example>
		public virtual async Task DeleteAccountCardAsync(int accountId, string cardId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CardClient.DeleteAccountCardClient( accountId,  cardId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


