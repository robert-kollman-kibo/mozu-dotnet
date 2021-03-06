
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

namespace Mozu.Api.Resources.Commerce.Settings.General
{
	/// <summary>
	/// Use the taxable territories subresource to manage the regional territories for this site that are subejct to sales tax.
	/// </summary>
	public partial class TaxableTerritoryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TaxableTerritoryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TaxableTerritoryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TaxableTerritoryResource(_apiContext.CloneWith(contextModification));
		}

				

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = await taxableterritory.GetTaxableTerritoriesAsync();
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> GetTaxableTerritoriesAsync(CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.GetTaxableTerritoriesClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <param name="taxableTerritory">Properties of the territory which is subject to sales tax.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = await taxableterritory.AddTaxableTerritoryAsync( taxableTerritory,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> AddTaxableTerritoryAsync(Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory taxableTerritory, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.AddTaxableTerritoryClient( taxableTerritory,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="taxableterritories">Properties of the territory which is subject to sales tax.</param>
		/// <returns>
		/// List{<see cref="Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var taxableterritory = new TaxableTerritory();
		///   var taxableTerritory = await taxableterritory.UpdateTaxableTerritoriesAsync( taxableterritories);
		/// </code>
		/// </example>
		public virtual async Task<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> UpdateTaxableTerritoriesAsync(List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory> taxableterritories, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<List<Mozu.Api.Contracts.SiteSettings.General.TaxableTerritory>> response;
			var client = Mozu.Api.Clients.Commerce.Settings.General.TaxableTerritoryClient.UpdateTaxableTerritoriesClient( taxableterritories);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


	}

}


