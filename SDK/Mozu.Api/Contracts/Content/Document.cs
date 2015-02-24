
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json.Linq;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.Content
{
		///
		///	The document properties that define the content used by the content management system (CMS).
		///
		public class Document
		{
			///
			///The character length allowed for the content text.
			///
			public long ContentLength { get; set; }

			///
			///The mime type associated with the document content, if applicable.
			///
			public string ContentMimeType { get; set; }

			///
			///The date and time the most recent content update was made. UTC date/time. System-supplied and read-only.
			///
			public DateTime? ContentUpdateDate { get; set; }

			///
			///Fully qualified name of the document type. 
			///
			public string DocumentTypeFQN { get; set; }

			///
			///If applicable, the file extension associated with the document content. For example, the extension may be .html for an HTML web page.
			///
			public string Extension { get; set; }

			///
			///Unique identifier of the source product property. For a product field it will be the name of the field. For a product attribute it will be the Attribute FQN. 
			///
			public string Id { get; set; }

			///
			///The date and time when a document was added to the document list. System-supplied and read-only.
			///
			public DateTime? InsertDate { get; set; }

			///
			///The fully qualified name of the document list.
			///
			public string ListFQN { get; set; }

			///
			///The display name of the source product property. For a product field it will be the display name of the field. For a product attribute it will be the Attribute Name.
			///
			public string Name { get; set; }

			///
			///Collection of property attributes defined for the object. Properties are associated to all objects within Mozu, including documents, products, and product types.
			///
			public JObject Properties { get; set; }

			///
			///The current state of the document or product definition. States for documents include Active, Draft, or Latest. Active documents are published and cannot be deleted. Querying Latest returns the most recent version of the document, regardless of whether it is published or a draft. States for product include New, Draft, or Live.
			///
			public string PublishState { get; set; }

			///
			///Date and time when the entity was last updated, represented in UTC Date/Time.
			///
			public DateTime? UpdateDate { get; set; }

		}

}