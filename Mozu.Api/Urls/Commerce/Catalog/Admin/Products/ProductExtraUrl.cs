
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Catalog.Admin.Products
{
	public partial class ProductExtraUrl 
	{

		/// <summary>
        /// Get Resource Url for GetExtras
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetExtrasUrl(string productCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetExtraValueLocalizedDeltaPrices
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="value">The value string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetExtraValueLocalizedDeltaPricesUrl(string productCode, string attributeFQN, string value)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}/Values/{value}/localizedDeltaPrice";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetExtraValueLocalizedDeltaPrice
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="value">The value string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetExtraValueLocalizedDeltaPriceUrl(string productCode, string attributeFQN, string value, string currencyCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}/Values/{value}/localizedDeltaPrice/{currencyCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "currencyCode", currencyCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetExtra
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetExtraUrl(string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddExtraValueLocalizedDeltaPrice
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="value">The value string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddExtraValueLocalizedDeltaPriceUrl(string productCode, string attributeFQN, string value, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}/Values/{value}/localizedDeltaPrice?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AddExtra
        /// </summary>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddExtraUrl(string productCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateExtraValueLocalizedDeltaPrices
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="value">The value string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateExtraValueLocalizedDeltaPricesUrl(string productCode, string attributeFQN, string value)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}/Values/{value}/localizedDeltaPrice";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateExtraValueLocalizedDeltaPrice
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="value">The value string to create.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateExtraValueLocalizedDeltaPriceUrl(string productCode, string attributeFQN, string value, string currencyCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}/Values/{value}/localizedDeltaPrice/{currencyCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "currencyCode", currencyCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateExtra
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateExtraUrl(string productCode, string attributeFQN, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteExtra
        /// </summary>
        /// <param name="attributeFQN">The fully qualified name of the attribute, which is a user defined attribute identifier.</param>
        /// <param name="productCode">Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteExtraUrl(string productCode, string attributeFQN)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "productCode", productCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for DeleteExtraValueLocalizedDeltaPrice
        /// </summary>
        /// <param name="attributeFQN">Fully qualified name for an attribute.</param>
        /// <param name="currencyCode">The three character ISO currency code, such as USD for US Dollars.</param>
        /// <param name="productCode">The unique, user-defined product code of a product, used throughout  to reference and associate to a product.</param>
        /// <param name="value">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteExtraValueLocalizedDeltaPriceUrl(string productCode, string attributeFQN, string value, string currencyCode)
		{
			var url = "/api/commerce/catalog/admin/products/{productCode}/Extras/{attributeFQN}/Values/{value}/localizedDeltaPrice/{currencyCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "attributeFQN", attributeFQN);
			mozuUrl.FormatUrl( "currencyCode", currencyCode);
			mozuUrl.FormatUrl( "productCode", productCode);
			mozuUrl.FormatUrl( "value", value);
			return mozuUrl;
		}

		
	}
}

