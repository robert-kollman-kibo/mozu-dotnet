
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

namespace Mozu.Api.Resources.Commerce
{
	/// <summary>
	/// 
	/// </summary>
	public partial class TargetRuleResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public TargetRuleResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public TargetRuleResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new TargetRuleResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRuleCollection = targetrule.GetTargetRules( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection GetTargetRules(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="filter"></param>
		/// <param name="pageSize"></param>
		/// <param name="responseFields"></param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRuleCollection = await targetrule.GetTargetRulesAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> GetTargetRulesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.GetTargetRule( code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule GetTargetRule(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRuleClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.GetTargetRuleAsync( code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> GetTargetRuleAsync(string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.GetTargetRuleClient( code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.CreateTargetRule( targetRule,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule CreateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.CreateTargetRuleClient( targetRule,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.CreateTargetRuleAsync( targetRule,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> CreateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.CreateTargetRuleClient( targetRule,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   targetrule.ValidateTargetRule( targetRule);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void ValidateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.ValidateTargetRuleClient( targetRule);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   await targetrule.ValidateTargetRuleAsync( targetRule);
		/// </code>
		/// </example>
		public virtual async Task ValidateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.ValidateTargetRuleClient( targetRule);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = targetrule.UpdateTargetRule( targetRule,  code,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ShippingAdmin.TargetRule UpdateTargetRule(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.UpdateTargetRuleClient( targetRule,  code,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="responseFields"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="targetRule"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ShippingAdmin.TargetRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   var targetRule = await targetrule.UpdateTargetRuleAsync( targetRule,  code,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ShippingAdmin.TargetRule> UpdateTargetRuleAsync(Mozu.Api.Contracts.ShippingAdmin.TargetRule targetRule, string code, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ShippingAdmin.TargetRule> response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.UpdateTargetRuleClient( targetRule,  code,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   targetrule.DeleteTargetRule( code);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteTargetRule(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.DeleteTargetRuleClient( code);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var targetrule = new TargetRule();
		///   await targetrule.DeleteTargetRuleAsync( code);
		/// </code>
		/// </example>
		public virtual async Task DeleteTargetRuleAsync(string code)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.TargetRuleClient.DeleteTargetRuleClient( code);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

