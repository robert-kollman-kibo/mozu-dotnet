
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
		public class CustomerAuthTicket
		{
			public string AccessToken { get; set; }

			public DateTime AccessTokenExpiration { get; set; }

			public string RefreshToken { get; set; }

			public DateTime RefreshTokenExpiration { get; set; }

			public string UserId { get; set; }

			public CustomerAccount CustomerAccount { get; set; }

		}

}