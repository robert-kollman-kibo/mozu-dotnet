
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

namespace Mozu.Api.Contracts.AppDev
{
		///
		///	Properties of the metadata associated with a file or subfolder in a development or release package associated with an application version.
		///
		public class FileMetadata
		{
			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Checksum function used to validate the local version of the file against the version on the server.
			///
			public string CheckSum { get; set; }

			///
			///Unique identifier of the source property, such as a catalog, discount, order, or email template.For a product field it will be the name of the field.For a category ID, must be a positive integer not greater than 2000000. By default,  auto-generates a category ID when categories are created. If you want to specify an ID during creation (which preserves category link relationships when migrating tenant data from one sandbox to another), you must also include the  query string in the endpoint. For example, . Then, use the  property to specify the desired category ID.For a product attribute it will be the Attribute FQN.For a document, the ID must be specified as a 32 character, case-insensitive, alphanumeric string. You can specify the ID as 32 sequential characters or as groups separated by dashes in the format 8-4-4-4-12. For example, or.For email templates, the ID must be one of the following values:///
			///
			public string Id { get; set; }

			///
			///The path and file name that represents the file location.
			///
			public string Path { get; set; }

			///
			///The total size of the package file, in bytes.
			///
			public long SizeInBytes { get; set; }

			///
			///The type of file in the package.
			///
			public string Type { get; set; }

		}

}