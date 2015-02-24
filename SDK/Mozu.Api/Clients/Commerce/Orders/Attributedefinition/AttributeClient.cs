
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

namespace Mozu.Api.Clients.Commerce.Orders.Attributedefinition
{
	/// <summary>
	/// Use the Order Attribute Definition resource to manage the attributes that uniquely describe orders, such as the associated shopping season or "How did you hear about us?" information. Merchants can display order attributes on the order summary, the order confirmation page, invoices, or packing slips.
	/// </summary>
	public partial class AttributeClient 	{
		
		/// <summary>
		/// Retrieves a list of order attributes according to any filter criteria or sort options.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.Extensible.AttributeCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributes( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var attributeCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.Extensible.AttributeCollection> GetAttributesClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.Attributedefinition.AttributeUrl.GetAttributesUrl(startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.Extensible.AttributeCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Returns the list of vocabulary values defined for the order attribute specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{List{<see cref="Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue"/>}}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttributeVocabularyValues( attributeFQN);
		///   var attributeVocabularyValueClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>> GetAttributeVocabularyValuesClient(string attributeFQN)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.Attributedefinition.AttributeUrl.GetAttributeVocabularyValuesUrl(attributeFQN);
			const string verb = "GET";
			var mozuClient = new MozuClient<List<Mozu.Api.Contracts.Core.Extensible.AttributeVocabularyValue>>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the details of the order attribute specified in the request.
		/// </summary>
		/// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Core.Extensible.Attribute"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAttribute( attributeFQN,  responseFields);
		///   var attributeClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute> GetAttributeClient(string attributeFQN, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Orders.Attributedefinition.AttributeUrl.GetAttributeUrl(attributeFQN, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Core.Extensible.Attribute>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


