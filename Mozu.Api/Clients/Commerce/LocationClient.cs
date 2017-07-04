
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

namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// Use the Location resource to retrieve details about a location from a  hosted storefront.
	/// </summary>
	public partial class LocationClient 	{
		
		/// <summary>
		/// Retrieves the details of the location specified in the request.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.Location"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocation( code,  responseFields);
		///   var locationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.Location> GetLocationClient(string code, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetLocationUrl(code, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.Location>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of the locations configured for a specified location usage type for the specified site, according to any defined filter or sort criteria.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="locationUsageType">System-defined location usage type code, which is DS for direct ship, SP for in-store pickup, or storeFinder.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLocationsInUsageType( locationUsageType,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var locationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationCollection> GetLocationsInUsageTypeClient(string locationUsageType, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetLocationsInUsageTypeUrl(locationUsageType, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the location configured for the direct shipping (DS) location usage type for the site specified in the request. This location acts as an origin address from which order packages will ship, as well as the location where product reservations are created when order items are submitted with the direct ship fulfillment type (DS). If the direct ship location usage type is not configured for this site, the operation returns an error.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.Location"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDirectShipLocation( responseFields);
		///   var locationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.Location> GetDirectShipLocationClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetDirectShipLocationUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.Location>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the location configured for the in-store pickup (SP) location usage type for the site specified in the request. If the location is not associated with a location type configured for the in-store pickup location usage type (SP), the operation returns an error.
		/// </summary>
		/// <param name="code">User-defined code that uniqely identifies the channel group.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.Location"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetInStorePickupLocation( code,  responseFields);
		///   var locationClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.Location> GetInStorePickupLocationClient(string code, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetInStorePickupLocationUrl(code, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.Location>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of locations valid for in-store pickup of an item in an order according to any filter and sort criteria. For example, an application could use this operation to provide a store finder feature based on the shopper's GPS coordinates. If the location types for the in-store pickup location usage type are not configured for the site, this operation returns an error.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Location.LocationCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetInStorePickupLocations( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var locationCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Location.LocationCollection> GetInStorePickupLocationsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.LocationUrl.GetInStorePickupLocationsUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Location.LocationCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


