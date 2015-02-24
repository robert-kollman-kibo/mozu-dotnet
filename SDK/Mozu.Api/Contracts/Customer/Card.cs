
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Customer
{
		///
		///	Properties of a credit card used to submit payment for an order.
		///
		public class Card
		{
			///
			///The masked credit card number part returned from the payment gateway.
			///
			public string CardNumberPart { get; set; }

			///
			///The type of credit card, such as Visa or Amex.
			///
			public string CardType { get; set; }

			///
			///Unique identifier of the customer account contact associated with the credit card.
			///
			public int ContactId { get; set; }

			///
			///The two-digit month a credit card expires for a payment method.
			///
			public short ExpireMonth { get; set; }

			///
			///The four-digit year the credit card expires for a payment method.
			///
			public short ExpireYear { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///The full name printed on a credit card. The name should match what is printed on the card exactly, used in validation during a payment.
			///
			public string NameOnCard { get; set; }

		}

}