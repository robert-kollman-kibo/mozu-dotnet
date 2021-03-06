
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Content
{
		///
		///	Provides details and data for properties for content in the site.
		///
		public class Property
		{
			///
			///If true, the attribute can have more than one value.
			///
			public bool IsMultiValued { get; set; }

			///
			///Indicates if the property, attribute, product option, or product extra is required. If true, the object must have a defined value.
			///
			public bool IsRequired { get; set; }

			///
			///The user supplied name that appears in . You can use this field for identification purposes.
			///
			public string Name { get; set; }

			///
			///Property type available for content. Property types are like templates that can be reused.
			///
			public PropertyType PropertyType { get; set; }

		}

}