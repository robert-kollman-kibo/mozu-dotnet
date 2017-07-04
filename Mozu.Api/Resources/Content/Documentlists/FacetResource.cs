
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

namespace Mozu.Api.Resources.Content.Documentlists
{
	/// <summary>
	/// Use the facets subresource to allow a merchant to add information for product indexing and searching.
	/// </summary>
	public partial class FacetResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public FacetResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public FacetResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new FacetResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// Retrieves the properties of facets that aid in indexing and searching.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="propertyName">The property name associated with the facets to retrieve.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.Content.Facet"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var facet = new Facet();
		///   var facet = await facet.GetFacetsAsync( documentListName,  propertyName);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.Content.Facet>> GetFacetsAsync(string documentListName, string propertyName, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.Content.Facet>> response;
			var client = Mozu.Api.Clients.Content.Documentlists.FacetClient.GetFacetsClient( documentListName,  propertyName);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


