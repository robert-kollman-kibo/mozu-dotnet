
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// Use the Channels resource to manage the channels a company uses to create logical commercial business divisions based on region or types of sales, such as "US Online," "Amazon," or "EMEA Retail." All orders include a channel association that enables the company to perform financial reporting for each defined channel. Because channels are managed at the tenant level, you must associate all the tenant's sites with a channel. Sites that do not have a defined channel association cannot successfully submit orders.
	/// </summary>
	public partial class ChannelResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ChannelResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ChannelResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ChannelResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves a list of channels defined for a tenant according to any filter or sort criteria specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var channel = new Channel();
		///   var channelCollection = await channel.GetChannelsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelCollection> GetChannelsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelCollection> response;
			var client = Mozu.Api.Clients.Commerce.ChannelClient.GetChannelsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of the channel specified in the request.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.Channel"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var channel = new Channel();
		///   var channel = await channel.GetChannelAsync( code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Channels.Channel> GetChannelAsync(string code, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.Channel> response;
			var client = Mozu.Api.Clients.Commerce.ChannelClient.GetChannelClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates a new channel that defines a new logical business division to use for financial reporting.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="channel">Properties of a channel used to divide a company into logical business divisions, such as "US Retail," "US Online," or "Amazon." All sites and orders are associated with a channel.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.Channel"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var channel = new Channel();
		///   var channel = await channel.CreateChannelAsync( channel,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Channels.Channel> CreateChannelAsync(Mozu.Api.Contracts.CommerceRuntime.Channels.Channel channel, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.Channel> response;
			var client = Mozu.Api.Clients.Commerce.ChannelClient.CreateChannelClient( channel,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates one or more details of a defined channel, including the associated sites.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="channel">Properties of a channel used to divide a company into logical business divisions, such as "US Retail," "US Online," or "Amazon." All sites and orders are associated with a channel.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.Channel"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var channel = new Channel();
		///   var channel = await channel.UpdateChannelAsync( channel,  code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Channels.Channel> UpdateChannelAsync(Mozu.Api.Contracts.CommerceRuntime.Channels.Channel channel, string code, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.Channel> response;
			var client = Mozu.Api.Clients.Commerce.ChannelClient.UpdateChannelClient( channel,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes a defined channel for the tenant and removes the defined site associations. After deleting this channel, assign its associated sites to another channel.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var channel = new Channel();
		///   await channel.DeleteChannelAsync( code);
		/// </code>
		/// </example>
		public virtual async Task DeleteChannelAsync(string code, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.ChannelClient.DeleteChannelClient( code);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


