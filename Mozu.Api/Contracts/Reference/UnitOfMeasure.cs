
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Reference
{
		///
		///	Properties to describe the unit of measure.
		///
		public class UnitOfMeasure
		{
			///
			///The user supplied name that appears in . You can use this field for identification purposes.
			///
			public string Name { get; set; }

			///
			///The plural name of the unit of measure, such as "feet".
			///
			public string PluralName { get; set; }

			///
			///The abbreviated symbol for the unit of measure, such as "ft".
			///
			public string Symbol { get; set; }

			///
			///The type of measurement, such as length or volume.
			///
			public string UnitOfMeasureType { get; set; }

		}

}