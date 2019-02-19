
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Core.Extensible
{
		///
		///	Properties of an attribute used to describe customers or orders.
		///
		public class Attribute
		{
			public string AdminName { get; set; }

			public string AttributeCode { get; set; }

			public string AttributeFQN { get; set; }

			public List<AttributeMetadataItem> AttributeMetadata { get; set; }

			public AuditInfo AuditInfo { get; set; }

			public AttributeLocalizedContent Content { get; set; }

			public string DataType { get; set; }

			///
			///Whether the customer or order attribute appears in  only, or in both  and the website storefront. Possible values are Admin and AdminAndStorefront.
			///
			public string DisplayGroup { get; set; }

			public int? Id { get; set; }

			public string InputType { get; set; }

			public bool? IsActive { get; set; }

			///
			///If true, the attribute can have more than one value.
			///
			public bool? IsMultiValued { get; set; }

			///
			///Flag used to indicate if this attribute definition is read-only. Once an attribute definition is set to read-only this action cannot be undone.
			///
			public bool IsReadOnly { get; set; }

			///
			///Indicates if the property, attribute, product option, or product extra is required. If true, the object must have a defined value.
			///
			public bool? IsRequired { get; set; }

			///
			///If true, the attribute is visible in its defined display group.
			///
			public bool? IsVisible { get; set; }

			public string Namespace { get; set; }

			///
			///Integer that represents the sequence order of the attribute.
			///
			public int? Order { get; set; }

			public AttributeValidation Validation { get; set; }

			///
			///An attribute value type is either predefined vocabulary by the admin during attribute set up or user-defined with an appropriate type (AdminEntered or ShopperEntered depending on the user). These types are used by products and attributes. The difference between predefined values versus manually entered values is such that the first choice is a set of options to choose from. AdminEntered and ShopperEntered are values that are entered rather than system-supplied and are not stored in the database, but captured during a live commerce operations such as during an order.
			///
			public string ValueType { get; set; }

			public List<AttributeVocabularyValue> VocabularyValues { get; set; }

		}

}