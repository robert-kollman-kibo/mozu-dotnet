
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

namespace Mozu.Api.Clients.Commerce.Catalog.Admin
{
	/// <summary>
	/// 
	/// </summary>
	public partial class ProductSortDefinitionClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductSortDefinitionPagedCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductSortDefinitions(dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var productSortDefinitionPagedCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinitionPagedCollection> GetProductSortDefinitionsClient(DataViewMode dataViewMode, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductSortDefinitionUrl.GetProductSortDefinitionsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinitionPagedCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productSortDefinitionId"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetProductSortDefinition(dataViewMode,  productSortDefinitionId,  responseFields);
		///   var productSortDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition> GetProductSortDefinitionClient(DataViewMode dataViewMode, int productSortDefinitionId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductSortDefinitionUrl.GetProductSortDefinitionUrl(productSortDefinitionId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="useProvidedId"></param>
		/// <param name="definition"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddProductSortDefinition(dataViewMode,  definition,  useProvidedId,  responseFields);
		///   var productSortDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition> AddProductSortDefinitionClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition definition, bool? useProvidedId =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductSortDefinitionUrl.AddProductSortDefinitionUrl(useProvidedId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition>(definition)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productSortDefinitionId"></param>
		/// <param name="responseFields"></param>
		/// <param name="definition"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateProductSortDefinition(dataViewMode,  definition,  productSortDefinitionId,  responseFields);
		///   var productSortDefinitionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition> UpdateProductSortDefinitionClient(DataViewMode dataViewMode, Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition definition, int productSortDefinitionId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductSortDefinitionUrl.UpdateProductSortDefinitionUrl(productSortDefinitionId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.ProductAdmin.ProductSortDefinition>(definition)									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="productSortDefinitionId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteProductSortDefinition(dataViewMode,  productSortDefinitionId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteProductSortDefinitionClient(DataViewMode dataViewMode, int productSortDefinitionId)
		{
			var url = Mozu.Api.Urls.Commerce.Catalog.Admin.ProductSortDefinitionUrl.DeleteProductSortDefinitionUrl(productSortDefinitionId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithHeader(Headers.X_VOL_DATAVIEW_MODE ,dataViewMode.ToString())
;
			return mozuClient;

		}


	}

}


