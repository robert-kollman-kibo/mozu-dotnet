
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

namespace Mozu.Api.Clients.Platform.Entitylists
{
	/// <summary>
	/// 
	/// </summary>
	public partial class EntityClient 	{
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="id"></param>
		/// <param name="responseFields"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{JObject}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEntity( entityListFullName,  id,  responseFields);
		///   var jObjectClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<JObject> GetEntityClient(string entityListFullName, string id, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.EntityUrl.GetEntityUrl(entityListFullName, id, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<JObject>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.MZDB.EntityCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetEntities( entityListFullName,  pageSize,  startIndex,  filter,  sortBy,  responseFields);
		///   var entityCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.MZDB.EntityCollection> GetEntitiesClient(string entityListFullName, int? pageSize =  null, int? startIndex =  null, string filter =  null, string sortBy =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.EntityUrl.GetEntitiesUrl(entityListFullName, pageSize, startIndex, filter, sortBy, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.MZDB.EntityCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="responseFields"></param>
		/// <param name="item"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{JObject}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=InsertEntity( item,  entityListFullName,  responseFields);
		///   var jObjectClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<JObject> InsertEntityClient(JObject item, string entityListFullName, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.EntityUrl.InsertEntityUrl(entityListFullName, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<JObject>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(item);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="id"></param>
		/// <param name="responseFields"></param>
		/// <param name="item"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{JObject}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateEntity( item,  entityListFullName,  id,  responseFields);
		///   var jObjectClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<JObject> UpdateEntityClient(JObject item, string entityListFullName, string id, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.EntityUrl.UpdateEntityUrl(entityListFullName, id, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<JObject>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(item);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="entityListFullName"></param>
		/// <param name="id"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteEntity( entityListFullName,  id);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteEntityClient(string entityListFullName, string id)
		{
			var url = Mozu.Api.Urls.Platform.Entitylists.EntityUrl.DeleteEntityUrl(entityListFullName, id);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


