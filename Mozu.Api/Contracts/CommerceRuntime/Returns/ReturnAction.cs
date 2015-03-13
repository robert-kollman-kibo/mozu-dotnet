
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


namespace Mozu.Api.Contracts.CommerceRuntime.Returns
{
		///
		///	Properties of an action a user can perform for a return.
		///
		public class ReturnAction
		{
			///
			///The name of the fulfillment action to perform for the purchased product. Options include "Ship" or "PickUp" (in-store pick-up).
			///
			public string ActionName { get; set; }

			///
			///The list of returns for which to perform the action.
			///
			public List<string> ReturnIds { get; set; }

		}

}