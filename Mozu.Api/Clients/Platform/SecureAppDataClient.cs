
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
using System.Threading;

namespace Mozu.Api.Clients.Platform
{
	/// <summary>
	/// Manage Secure App Settings. Expose via arc.js so that arc apps can securely access secrets. Third-party extensions can also access their data. Secured via AppKey.AppId
	/// </summary>
	public partial class SecureAppDataClient 	{
		
		/// <summary>
		/// platform-secureappdata Get GetDBValue description DOCUMENT_HERE 
		/// </summary>
		/// <param name="appKeyId"></param>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="responseFields">Filtering syntax appended to an API call to increase or decrease the amount of data returned inside a JSON object. This parameter should only be used to retrieve data. Attempting to update data using this parameter may cause data loss.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{JObject}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetDBValue( appKeyId,  dbEntryQuery,  responseFields);
		///   var jsonClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<JObject> GetDBValueClient(string appKeyId, string dbEntryQuery, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Platform.SecureAppDataUrl.GetDBValueUrl(appKeyId, dbEntryQuery, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<JObject>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// platform-secureappdata Post CreateDBValue description DOCUMENT_HERE 
		/// </summary>
		/// <param name="appKeyId"></param>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=CreateDBValue( value,  appKeyId,  dbEntryQuery);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient CreateDBValueClient(JObject value, string appKeyId, string dbEntryQuery)
		{
			var url = Mozu.Api.Urls.Platform.SecureAppDataUrl.CreateDBValueUrl(appKeyId, dbEntryQuery);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<JObject>(value);
			return mozuClient;

		}

		/// <summary>
		/// platform-secureappdata Put UpdateDBValue description DOCUMENT_HERE 
		/// </summary>
		/// <param name="appKeyId"></param>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateDBValue( value,  appKeyId,  dbEntryQuery);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient UpdateDBValueClient(JObject value, string appKeyId, string dbEntryQuery)
		{
			var url = Mozu.Api.Urls.Platform.SecureAppDataUrl.UpdateDBValueUrl(appKeyId, dbEntryQuery);
			const string verb = "PUT";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<JObject>(value);
			return mozuClient;

		}

		/// <summary>
		/// platform-secureappdata Delete DeleteDBValue description DOCUMENT_HERE 
		/// </summary>
		/// <param name="appKeyId"></param>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteDBValue( appKeyId,  dbEntryQuery);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteDBValueClient(string appKeyId, string dbEntryQuery)
		{
			var url = Mozu.Api.Urls.Platform.SecureAppDataUrl.DeleteDBValueUrl(appKeyId, dbEntryQuery);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


