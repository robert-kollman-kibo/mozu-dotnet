
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ShippingAdmin
{
		///
		///	Properties of a shipping carrier-specific setting associated with a carrier configuration.
		///
		public class Setting
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Carrier-specific key field.
			///
			public string Key { get; set; }

			///
			///The label of the carrier-specific key.
			///
			public LocalizableString Label { get; set; }

			///
			///Carrier-specific value for the associated key.
			///
			public string Value { get; set; }

		}

}