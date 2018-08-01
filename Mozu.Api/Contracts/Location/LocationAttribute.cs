
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

using Mozu.Api.Contracts.Core;
using Mozu.Api.Contracts.Core.Extensible;

namespace Mozu.Api.Contracts.Location
{
		///
		///	An attribute associated with the location.
		///
		public class LocationAttribute
		{
			///
			///The custom attribute object for the location.
			///
			public Attribute AttributeDefinition { get; set; }

			///
			///Unique identifier of the attribute definition.
			///
			public int? AttributeDefinitionId { get; set; }

			///
			///Basic audit info about the object, including date, time, and user account. This data may be captured when creating, updating, and removing data.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Fully qualified name of the attribute for the order or customer.
			///
			public string FullyQualifiedName { get; set; }

			///
			///List of value data for objects.
			///
			public List<object> Values { get; set; }

		}

}