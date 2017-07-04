
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

namespace Mozu.Api.Resources.Platform.Entitylists
{
	/// <summary>
	/// Provides settings and options for displaying associated content within a context level of site, tenant, catalog, or master catalog. ListViews can be associated with entity lists and entities.
	/// </summary>
	public partial class ListViewResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public ListViewResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public ListViewResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ListViewResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves a view for associated entities. A view provides display context levels (site, tenant, catalog, master catalog) and settings.
		/// </summary>
		/// <param name="entityId">Unique identifier for an entity, which defines the schema, rules, and formats for JSON entities within the MZDB ( Mongo DB).</param>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		/// JObject
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   var json = await listview.GetViewEntityAsync( entityListFullName,  viewName,  entityId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<JObject> GetViewEntityAsync(string entityListFullName, string viewName, string entityId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<JObject> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.GetViewEntityClient( entityListFullName,  viewName,  entityId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a collection of views for associated entities. Each view provides display context levels (site, tenant, catalog, master catalog) and settings.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   var entityCollection = await listview.GetViewEntitiesAsync( entityListFullName,  viewName,  pageSize,  startIndex,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityCollection> GetViewEntitiesAsync(string entityListFullName, string viewName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityCollection> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.GetViewEntitiesClient( entityListFullName,  viewName,  pageSize,  startIndex,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a collection of container data for creating and displaying a view of entities. 
		/// </summary>
		/// <param name="entityId">Unique identifier for an entity, which defines the schema, rules, and formats for JSON entities within the MZDB ( Mongo DB).</param>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityContainer"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   var entityContainer = await listview.GetViewEntityContainerAsync( entityListFullName,  viewName,  entityId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityContainer> GetViewEntityContainerAsync(string entityListFullName, string viewName, string entityId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityContainer> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.GetViewEntityContainerClient( entityListFullName,  viewName,  entityId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a collection of container data for creating and displaying a view of entities. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with this parameter set to 25, to get the 51st through the 75th items, set startIndex to 50.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with pageSize set to 25, to get the 51st through the 75th items, set this parameter to 50.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.EntityContainerCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   var entityContainerCollection = await listview.GetViewEntityContainersAsync( entityListFullName,  viewName,  pageSize,  startIndex,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.EntityContainerCollection> GetViewEntityContainersAsync(string entityListFullName, string viewName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.EntityContainerCollection> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.GetViewEntityContainersClient( entityListFullName,  viewName,  pageSize,  startIndex,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a specific `EntityListView`. These views provide schema, rules, and formatting for all associated entities. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.ListView"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   var listView = await listview.GetEntityListViewAsync( entityListFullName,  viewName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.ListView> GetEntityListViewAsync(string entityListFullName, string viewName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.ListView> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.GetEntityListViewClient( entityListFullName,  viewName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a collection of `EntityListViews`. These views provide schema, rules, and formatting for all associated entities. 
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.ListViewCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   var listViewCollection = await listview.GetEntityListViewsAsync( entityListFullName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.ListViewCollection> GetEntityListViewsAsync(string entityListFullName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.ListViewCollection> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.GetEntityListViewsClient( entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates an entity list view. Each view provides display context levels (site, tenant, catalog, master catalog) and settings for the list of entities.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="listView">Properties for the list view that specifies what fields and content display per page load. All associated fields in the list view correspond with object data.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.ListView"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   var listView = await listview.CreateEntityListViewAsync( listView,  entityListFullName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.ListView> CreateEntityListViewAsync(Mozu.Api.Contracts.MZDB.ListView listView, string entityListFullName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.ListView> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.CreateEntityListViewClient( listView,  entityListFullName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates an existing entity list view. Each view provides display context levels (site, tenant, catalog, master catalog) and settings for the list of entities.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <param name="listView">Properties for the list view that specifies what fields and content display per page load. All associated fields in the list view correspond with object data.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.MZDB.ListView"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   var listView = await listview.UpdateEntityListViewAsync( listView,  entityListFullName,  viewName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.MZDB.ListView> UpdateEntityListViewAsync(Mozu.Api.Contracts.MZDB.ListView listView, string entityListFullName, string viewName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.MZDB.ListView> response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.UpdateEntityListViewClient( listView,  entityListFullName,  viewName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes an entity list view. Any associated entities have the association removed.
		/// </summary>
		/// <param name="entityListFullName">The full name of the EntityList including namespace in name@nameSpace format</param>
		/// <param name="viewName">The name for a view. Views are used to render data in , such as document and entity lists. Each view includes a schema, format, name, ID, and associated data types to render.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var listview = new ListView();
		///   await listview.DeleteEntityListViewAsync( entityListFullName,  viewName);
		/// </code>
		/// </example>
		public virtual async Task DeleteEntityListViewAsync(string entityListFullName, string viewName, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.Entitylists.ListViewClient.DeleteEntityListViewClient( entityListFullName,  viewName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


