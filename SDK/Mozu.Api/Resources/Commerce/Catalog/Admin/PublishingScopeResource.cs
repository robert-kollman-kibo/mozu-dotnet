
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// Use the Product Publishing resource to publish or discard pending changes to product definitions in the master catalog.
	/// </summary>
	public partial class PublishingScopeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public PublishingScopeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public PublishingScopeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new PublishingScopeResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public PublishingScopeResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Deletes the draft version of product changes for each product code specified in the request.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Describes the scope of the product publishing update, which can include individual product codes or all pending changes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.DiscardDrafts(_dataViewMode,  publishScope);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DiscardDrafts(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.DiscardDraftsClient(_dataViewMode,  publishScope);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the draft version of product changes for each product code specified in the request.
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Describes the scope of the product publishing update, which can include individual product codes or all pending changes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   await publishingscope.DiscardDraftsAsync(_dataViewMode,  publishScope);
		/// </code>
		/// </example>
		public virtual async Task DiscardDraftsAsync(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.DiscardDraftsClient(_dataViewMode,  publishScope);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// Publishes the draft version of product changes for each product code specified in the request, and changes the product publish state to "live".
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Describes the scope of the product publishing update, which can include individual product codes or all pending changes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   publishingscope.PublishDrafts(_dataViewMode,  publishScope);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void PublishDrafts(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.PublishDraftsClient(_dataViewMode,  publishScope);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Publishes the draft version of product changes for each product code specified in the request, and changes the product publish state to "live".
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="publishScope">Describes the scope of the product publishing update, which can include individual product codes or all pending changes.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var publishingscope = new PublishingScope();
		///   await publishingscope.PublishDraftsAsync(_dataViewMode,  publishScope);
		/// </code>
		/// </example>
		public virtual async Task PublishDraftsAsync(Mozu.Api.Contracts.ProductAdmin.PublishingScope publishScope)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.PublishingScopeClient.PublishDraftsClient(_dataViewMode,  publishScope);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


