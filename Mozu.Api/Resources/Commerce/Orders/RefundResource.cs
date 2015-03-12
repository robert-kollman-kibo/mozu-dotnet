
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

namespace Mozu.Api.Resources.Commerce.Orders
{
	/// <summary>
	/// commerce/orders/orderrefunds related resources. DOCUMENT_HERE 
	/// </summary>
	public partial class RefundResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public RefundResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public RefundResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new RefundResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// orders-orderrefunds Post CreateRefund description DOCUMENT_HERE 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="refund">Mozu.CommerceRuntime.Contracts.Refunds.Refund ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var refund = new Refund();
		///   var refund = refund.CreateRefund( refund,  orderId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund CreateRefund(Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund refund, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund> response;
			var client = Mozu.Api.Clients.Commerce.Orders.RefundClient.CreateRefundClient( refund,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// orders-orderrefunds Post CreateRefund description DOCUMENT_HERE 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="refund">Mozu.CommerceRuntime.Contracts.Refunds.Refund ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var refund = new Refund();
		///   var refund = await refund.CreateRefundAsync( refund,  orderId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund> CreateRefundAsync(Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund refund, string orderId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Refunds.Refund> response;
			var client = Mozu.Api.Clients.Commerce.Orders.RefundClient.CreateRefundClient( refund,  orderId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// orders-orderrefunds Put ResendRefundEmail description DOCUMENT_HERE 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="refundId"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var refund = new Refund();
		///   refund.ResendRefundEmail( orderId,  refundId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void ResendRefundEmail(string orderId, string refundId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.RefundClient.ResendRefundEmailClient( orderId,  refundId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// orders-orderrefunds Put ResendRefundEmail description DOCUMENT_HERE 
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="refundId"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var refund = new Refund();
		///   await refund.ResendRefundEmailAsync( orderId,  refundId);
		/// </code>
		/// </example>
		public virtual async Task ResendRefundEmailAsync(string orderId, string refundId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Orders.RefundClient.ResendRefundEmailClient( orderId,  refundId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


