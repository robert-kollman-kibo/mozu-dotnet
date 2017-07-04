
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Details of a product variation option.
		///
		public class ProductVariationOption
		{
			///
			///The fully qualified name of the attribute, which is a user defined attribute identifier.
			///
			public string AttributeFQN { get; set; }

			///
			///Complex type that contains content for a language specified by LocaleCode.
			///
			public AttributeVocabularyValueLocalizedContent Content { get; set; }

			///
			///The value of a property, used by numerous objects within  including facets, attributes, products, localized content, metadata, capabilities ( and third-party), location inventory adjustment, and more. The value may be a string, integer, or double. Validation may be run against the entered and saved values depending on the object type.
			///
			public object Value { get; set; }

		}

}