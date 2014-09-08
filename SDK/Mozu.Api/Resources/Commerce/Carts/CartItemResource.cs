
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Resources.Commerce.Carts
{
	/// <summary>
	/// Use the cart items subresource to manage a collection of items in an active shopping cart.
	/// </summary>
	public partial class CartItemResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public CartItemResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public CartItemResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new CartItemResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a particular cart item by providing the cart item ID.
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to retrieve.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = cartitem.GetCartItem( cartItemId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem GetCartItem(string cartItemId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.GetCartItemClient( cartItemId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> GetCartItemAsync(string cartItemId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.GetCartItemClient( cartItemId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a list of cart items including the total number of items in the cart.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItemCollection = cartitem.GetCartItems( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection GetCartItems(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.GetCartItemsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection> GetCartItemsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItemCollection> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.GetCartItemsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds a product to the current shopper's cart.
		/// </summary>
		/// <param name="responseFields"></param>
		/// <param name="cartItem">All properties of the new cart item. The product code is required.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = cartitem.AddItemToCart( cartItem,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem AddItemToCart(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.AddItemToCartClient( cartItem,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> AddItemToCartAsync(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.AddItemToCartClient( cartItem,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update the quantity of an individual cart item in the cart of the current shopper.
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to update quantity.</param>
		/// <param name="quantity">The number of cart items in the shopper's active cart.</param>
		/// <param name="responseFields"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = cartitem.UpdateCartItemQuantity( cartItemId,  quantity,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem UpdateCartItemQuantity(string cartItemId, int quantity, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.UpdateCartItemQuantityClient( cartItemId,  quantity,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> UpdateCartItemQuantityAsync(string cartItemId, int quantity, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.UpdateCartItemQuantityClient( cartItemId,  quantity,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Update the product or product quantity of an item in the current shopper's cart.
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to update.</param>
		/// <param name="responseFields"></param>
		/// <param name="cartItem">The properties of the cart item to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cartItem = cartitem.UpdateCartItem( cartItem,  cartItemId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem UpdateCartItem(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string cartItemId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.UpdateCartItemClient( cartItem,  cartItemId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> UpdateCartItemAsync(Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem cartItem, string cartItemId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartItem> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.UpdateCartItemClient( cartItem,  cartItemId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes all items in the current shopper's active cart.
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   var cart = cartitem.RemoveAllCartItems();
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.Cart RemoveAllCartItems()
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.RemoveAllCartItemsClient();
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> RemoveAllCartItemsAsync()
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.RemoveAllCartItemsClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes a specific cart item by providing the cart item ID.
		/// </summary>
		/// <param name="cartItemId">Identifier of the cart item to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var cartitem = new CartItem();
		///   cartitem.DeleteCartItem( cartItemId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteCartItem(string cartItemId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.DeleteCartItemClient( cartItemId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		public virtual async Task DeleteCartItemAsync(string cartItemId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Carts.CartItemClient.DeleteCartItemClient( cartItemId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


