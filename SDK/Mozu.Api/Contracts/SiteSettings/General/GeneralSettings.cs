
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

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.SiteSettings.General
{
		///
		///	General settings used on the storefront site.
		///
		public class GeneralSettings
		{
			///
			///If true, the site allows entry of addresses not verified by an address validation service.
			///
			public bool? AllowInvalidAddresses { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///The physical directory path or URL where the mobile favicon image file is stored. The favicon icon is generally 57x57 pixels. The icon appears on a mobile website or on the mobile device's OS Home.
			///
			public string FavIconMobilePath { get; set; }

			///
			///The physical directory path or URL where the mobile favicon image file is stored. The favicon icon is generally 16x16 pixels. The icon appears on a a browser tab as the website's mini logo or on a browser address bar, or next to the page name in a list of bookmarks.
			///
			public string FavIconPath { get; set; }

			///
			///The Google Analytics code associated with a particular store. This could be the web tracking code.
			///
			public string GoogleAnalyticsCode { get; set; }

			///
			///If true, a service to verify addresses as valid is enabled for the site.
			///
			public bool? IsAddressValidationEnabled { get; set; }

			///
			///If true, the Google analytics for eCommerce is enabled for this site. If false, the analytics are not enabled.
			///
			public bool? IsGoogleAnalyticsEcommerceEnabled { get; set; }

			///
			///If true, enable Google analytics for this site. If false, analytics are not enabled.
			///
			public bool? IsGoogleAnalyticsEnabled { get; set; }

			///
			///If true, this site represents a Mozu-hosted web storefront.
			///
			public bool IsMozuWebSite { get; set; }

			///
			///If true, shoppers on this site can create customer wish lists.
			///
			public bool? IsWishlistCreationEnabled { get; set; }

			///
			///The physical directory path or URL where the website logo is stored.
			///
			public string LogoPath { get; set; }

			///
			///The tagline or text that appears when hovering over the site logo.
			///
			public string LogoText { get; set; }

			///
			///The name of the theme to use when viewing this website on a mobile device.
			///
			public string MobileTheme { get; set; }

			///
			///Email address to display on email messages sent from the site.
			///
			public string ReplyToEmailAddress { get; set; }

			///
			///Email address to set up so that shoppers and users browsing the site can use to contact the merchant.
			///
			public string SenderEmailAddress { get; set; }

			///
			///Email alias used in emails sent to your shoppers.
			///
			public string SenderEmailAlias { get; set; }

			///
			///Choose a format to use on the site: 12-hour (hh:mm:ss tt) or 24-hour format (HH:mm:ss).
			///
			public string SiteTimeFormat { get; set; }

			///
			///Choose the time zone to use for the site.
			///
			public string SiteTimeZone { get; set; }

			///
			///The name of the theme to use when viewing the website on a mobile device.
			///
			public string TabletTheme { get; set; }

			///
			///The territories configured for the site that are subject to sales tax.
			///
			public List<TaxableTerritory> TaxableTerritories { get; set; }

			///
			///Unique identifier of the tenant site that site uses to render content for the shopper. For example, if this site represents a third-party sales channel such as Amazon but the company wants to send shopper emails, this value represents the Mozu-hosted web storefront site that maintains this content.
			///
			public int? TemplateSiteId { get; set; }

			///
			///The name of the theme used on the storefront.
			///
			public string Theme { get; set; }

			///
			///The name of the website to display on the storefront with no spaces.
			///
			public string WebsiteName { get; set; }

		}

}