
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


namespace Mozu.Api.Contracts.Reference
{
		///
		///	The paged collection of all top level internet domains that the system supports including general, USA-specific, infrastructure, and country codes. The Internet Assigned Numbers Authority (IANA) maintains this list.
		///
		public class TopLevelDomainCollection
		{
			///
			///An array list of objects in the returned collection.
			///
			public List<string> Items { get; set; }

			///
			///The number of results listed in the query collection, represented by a signed 64-bit (8-byte) integer. This value is system-supplied and read-only.
			///
			public int TotalCount { get; set; }

		}

}