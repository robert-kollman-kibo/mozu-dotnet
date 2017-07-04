
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
	/// Use the Channel Groups resource to manage groups of channels with common information.
	/// </summary>
	public partial class ChannelGroupResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ChannelGroupResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ChannelGroupResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ChannelGroupResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves a list of defined channel groups according to any filter and sort criteria specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroupCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var channelgroup = new ChannelGroup();
		///   var channelGroupCollection = await channelgroup.GetChannelGroupsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroupCollection> GetChannelGroupsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroupCollection> response;
			var client = Mozu.Api.Clients.Commerce.ChannelGroupClient.GetChannelGroupsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves the details of a defined channel group.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var channelgroup = new ChannelGroup();
		///   var channelGroup = await channelgroup.GetChannelGroupAsync( code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> GetChannelGroupAsync(string code, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> response;
			var client = Mozu.Api.Clients.Commerce.ChannelGroupClient.GetChannelGroupClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates a new group of channels with common information.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="channelGroup">Properties of a group of channels that share common information.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var channelgroup = new ChannelGroup();
		///   var channelGroup = await channelgroup.CreateChannelGroupAsync( channelGroup,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> CreateChannelGroupAsync(Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup channelGroup, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> response;
			var client = Mozu.Api.Clients.Commerce.ChannelGroupClient.CreateChannelGroupClient( channelGroup,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates one or more properties of a defined channel group.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="channelGroup">Properties of a group of channels that share common information.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var channelgroup = new ChannelGroup();
		///   var channelGroup = await channelgroup.UpdateChannelGroupAsync( channelGroup,  code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> UpdateChannelGroupAsync(Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup channelGroup, string code, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Channels.ChannelGroup> response;
			var client = Mozu.Api.Clients.Commerce.ChannelGroupClient.UpdateChannelGroupClient( channelGroup,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes a defined group of channels, which removes the group association with each channel in the group but does not delete the channel definitions themselves.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var channelgroup = new ChannelGroup();
		///   await channelgroup.DeleteChannelGroupAsync( code);
		/// </code>
		/// </example>
		public virtual async Task DeleteChannelGroupAsync(string code, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.ChannelGroupClient.DeleteChannelGroupClient( code);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


