
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


namespace Mozu.Api.Contracts.CommerceRuntime.Orders
{
		///
		///	Properties of the resulting order validation performed by an order validation capability.
		///
		public class OrderValidationResult
		{
			///
			///Date and time when the entity was created, represented in UTC Date/Time.
			///
			public DateTime? CreatedDate { get; set; }

			///
			///Array list of validation and status messages associated with shipping rates, orders, and product purchasable state.
			///
			public List<OrderValidationMessage> Messages { get; set; }

			///
			///The current status of an object. This status is specific to the object including payment (New, Authorized, Captured, Declined, Failed, Voided, Credited, CheckRequested, or RolledBack), discount (Active, Scheduled, or Expired), returns (ReturnAuthorized), tenant, package (Fulfilled or NotFulfilled), application, master and product catalogs, orders (Pending, Submitted, Processing, Pending Review, Closed, or Canceled), and order validation results (Pass, Fail, Error, or Review).
			///
			public string Status { get; set; }

			///
			///Read-only identifier defined by the order validation capability that uniquely identifies this validation operation.
			///
			public string ValidationId { get; set; }

			///
			///Read-only name of this order validator supplied by the capability.
			///
			public string ValidatorName { get; set; }

			///
			///The type of order validator supplied by the capability. At this time, the only supported validator type is Fraud.
			///
			public string ValidatorType { get; set; }

		}

}