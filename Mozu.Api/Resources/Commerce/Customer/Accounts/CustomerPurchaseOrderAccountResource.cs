
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

namespace Mozu.Api.Resources.Commerce.Customer.Accounts
{
	/// <summary>
	/// commerce/customer/accounts/purchaseOrder related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class CustomerPurchaseOrderAccountResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CustomerPurchaseOrderAccountResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CustomerPurchaseOrderAccountResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CustomerPurchaseOrderAccountResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// accounts-purchaseOrder Get GetCustomerPurchaseOrderAccount description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var customerPurchaseOrderAccount = customerpurchaseorderaccount.GetCustomerPurchaseOrderAccount( accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount GetCustomerPurchaseOrderAccount(int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.GetCustomerPurchaseOrderAccountClient( accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// accounts-purchaseOrder Get GetCustomerPurchaseOrderAccount description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var customerPurchaseOrderAccount = await customerpurchaseorderaccount.GetCustomerPurchaseOrderAccountAsync( accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> GetCustomerPurchaseOrderAccountAsync(int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.GetCustomerPurchaseOrderAccountClient( accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// accounts-purchaseOrder Get GetCustomerPurchaseOrderTransactions description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter"></param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var purchaseOrderTransactionCollection = customerpurchaseorderaccount.GetCustomerPurchaseOrderTransactions( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection GetCustomerPurchaseOrderTransactions(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.GetCustomerPurchaseOrderTransactionsClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// accounts-purchaseOrder Get GetCustomerPurchaseOrderTransactions description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter"></param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional. Refer to [Sorting and Filtering](../../../../Developer/applications/sorting-filtering.htm) for more information.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var purchaseOrderTransactionCollection = await customerpurchaseorderaccount.GetCustomerPurchaseOrderTransactionsAsync( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection> GetCustomerPurchaseOrderTransactionsAsync(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransactionCollection> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.GetCustomerPurchaseOrderTransactionsClient( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// accounts-purchaseOrder Post CreateCustomerPurchaseOrderAccount description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="customerPurchaseOrderAccount">Mozu.Customer.Contracts.CustomerPurchaseOrderAccount ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var customerPurchaseOrderAccount = customerpurchaseorderaccount.CreateCustomerPurchaseOrderAccount( customerPurchaseOrderAccount,  accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount CreateCustomerPurchaseOrderAccount(Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount customerPurchaseOrderAccount, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.CreateCustomerPurchaseOrderAccountClient( customerPurchaseOrderAccount,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// accounts-purchaseOrder Post CreateCustomerPurchaseOrderAccount description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="customerPurchaseOrderAccount">Mozu.Customer.Contracts.CustomerPurchaseOrderAccount ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var customerPurchaseOrderAccount = await customerpurchaseorderaccount.CreateCustomerPurchaseOrderAccountAsync( customerPurchaseOrderAccount,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> CreateCustomerPurchaseOrderAccountAsync(Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount customerPurchaseOrderAccount, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.CreateCustomerPurchaseOrderAccountClient( customerPurchaseOrderAccount,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// accounts-purchaseOrder Post CreatePurchaseOrderTransaction description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="purchaseOrderTransaction">Mozu.Customer.Contracts.PurchaseOrderTransaction ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.PurchaseOrderTransaction"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var purchaseOrderTransaction = customerpurchaseorderaccount.CreatePurchaseOrderTransaction( purchaseOrderTransaction,  accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.PurchaseOrderTransaction CreatePurchaseOrderTransaction(Mozu.Api.Contracts.Customer.PurchaseOrderTransaction purchaseOrderTransaction, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransaction> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.CreatePurchaseOrderTransactionClient( purchaseOrderTransaction,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// accounts-purchaseOrder Post CreatePurchaseOrderTransaction description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="purchaseOrderTransaction">Mozu.Customer.Contracts.PurchaseOrderTransaction ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.PurchaseOrderTransaction"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var purchaseOrderTransaction = await customerpurchaseorderaccount.CreatePurchaseOrderTransactionAsync( purchaseOrderTransaction,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.PurchaseOrderTransaction> CreatePurchaseOrderTransactionAsync(Mozu.Api.Contracts.Customer.PurchaseOrderTransaction purchaseOrderTransaction, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.PurchaseOrderTransaction> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.CreatePurchaseOrderTransactionClient( purchaseOrderTransaction,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// accounts-purchaseOrder Put UpdateCustomerPurchaseOrderAccount description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="customerPurchaseOrderAccount">Mozu.Customer.Contracts.CustomerPurchaseOrderAccount ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var customerPurchaseOrderAccount = customerpurchaseorderaccount.UpdateCustomerPurchaseOrderAccount( customerPurchaseOrderAccount,  accountId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount UpdateCustomerPurchaseOrderAccount(Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount customerPurchaseOrderAccount, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.UpdateCustomerPurchaseOrderAccountClient( customerPurchaseOrderAccount,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// accounts-purchaseOrder Put UpdateCustomerPurchaseOrderAccount description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="customerPurchaseOrderAccount">Mozu.Customer.Contracts.CustomerPurchaseOrderAccount ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   var customerPurchaseOrderAccount = await customerpurchaseorderaccount.UpdateCustomerPurchaseOrderAccountAsync( customerPurchaseOrderAccount,  accountId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> UpdateCustomerPurchaseOrderAccountAsync(Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount customerPurchaseOrderAccount, int accountId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Customer.CustomerPurchaseOrderAccount> response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.UpdateCustomerPurchaseOrderAccountClient( customerPurchaseOrderAccount,  accountId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// accounts-purchaseOrder Delete DeleteCustomerPurchaseOrderAccount description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   customerpurchaseorderaccount.DeleteCustomerPurchaseOrderAccount( accountId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteCustomerPurchaseOrderAccount(int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.DeleteCustomerPurchaseOrderAccountClient( accountId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// accounts-purchaseOrder Delete DeleteCustomerPurchaseOrderAccount description DOCUMENT_HERE 
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var customerpurchaseorderaccount = new CustomerPurchaseOrderAccount();
		///   await customerpurchaseorderaccount.DeleteCustomerPurchaseOrderAccountAsync( accountId);
		/// </code>
		/// </example>
		public virtual async Task DeleteCustomerPurchaseOrderAccountAsync(int accountId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Customer.Accounts.CustomerPurchaseOrderAccountClient.DeleteCustomerPurchaseOrderAccountClient( accountId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


