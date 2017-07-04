
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

namespace Mozu.Api.Resources.Content.Documentlists
{
	/// <summary>
	/// Use this subresource to manage documents in a document list.
	/// </summary>
	public partial class DocumentResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public DocumentResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public DocumentResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new DocumentResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public DocumentResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				

		/// <summary>
		/// Retrieve the content associated with a document, such as a product image or PDF specifications file, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var stream = await document.GetDocumentContentAsync(_dataViewMode,  documentListName,  documentId);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> GetDocumentContentAsync(string documentListName, string documentId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentContentClient(_dataViewMode,  documentListName,  documentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Performs transformations on a document. For example, resizing an image.
		/// </summary>
		/// <param name="crop">Crops the image based on the specified coordinates. The reference point for positive coordinates is the top-left corner of the image, and the reference point for negative coordinates is the bottom-right corner of the image.Usage: Example:  removes 10 pixels from all edges of the image.  leaves the image uncropped.</param>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="height">Specifies an exact height dimension for the image, in pixels.</param>
		/// <param name="max">Specifies a pixel limitation for the largest side of an image.</param>
		/// <param name="maxHeight">Specifies a pixel limitation for the height of the image, preserving the aspect ratio if the image needs resizing.</param>
		/// <param name="maxWidth">Specifies a pixel limitation for the width of the image, preserving the aspect ratio if the image needs resizing.</param>
		/// <param name="quality">Adjusts the image compression. Accepts values from 0-100, where 100 = highest quality, least compression.</param>
		/// <param name="width">Specifies an exact width dimension for the image, in pixels.</param>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var stream = await document.TransformDocumentContentAsync( documentListName,  documentId,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> TransformDocumentContentAsync(string documentListName, string documentId, int? width =  null, int? height =  null, int? max =  null, int? maxWidth =  null, int? maxHeight =  null, string crop =  null, int? quality =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.TransformDocumentContentClient( documentListName,  documentId,  width,  height,  max,  maxWidth,  maxHeight,  crop,  quality);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a document within the specified document list.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var document = await document.GetDocumentAsync(_dataViewMode,  documentListName,  documentId,  includeInactive,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.Document> GetDocumentAsync(string documentListName, string documentId, bool? includeInactive =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentClient(_dataViewMode,  documentListName,  documentId,  includeInactive,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Retrieves a collection of documents according to any filter and sort criteria.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query. This parameter is optional. Refer to [Sorting and Filtering](../../../../Developer/api-guides/sorting-filtering.htm) for a list of supported filters.</param>
		/// <param name="includeInactive">Include inactive content.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var documentCollection = await document.GetDocumentsAsync(_dataViewMode,  documentListName,  filter,  sortBy,  pageSize,  startIndex,  includeInactive,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.DocumentCollection> GetDocumentsAsync(string documentListName, string filter =  null, string sortBy =  null, int? pageSize =  null, int? startIndex =  null, bool? includeInactive =  null, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentCollection> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.GetDocumentsClient(_dataViewMode,  documentListName,  filter,  sortBy,  pageSize,  startIndex,  includeInactive,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Creates a new document in an defined document list.
		/// </summary>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="document">The document properties that define the content used by the content management system (CMS).</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var document = await document.CreateDocumentAsync(_dataViewMode,  document,  documentListName,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.Document> CreateDocumentAsync(Mozu.Api.Contracts.Content.Document document, string documentListName, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.CreateDocumentClient(_dataViewMode,  document,  documentListName,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Updates the binary data or content associated with a document, such as a product image or PDF specifications file, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="stream">Data stream that delivers information. Used to input and output data.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   await document.UpdateDocumentContentAsync( stream,  documentListName,  documentId,  contentType);
		/// </code>
		/// </example>
		public virtual async Task UpdateDocumentContentAsync(System.IO.Stream stream, string documentListName, string documentId, String  contentType= null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.UpdateDocumentContentClient( stream,  documentListName,  documentId,  contentType);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// Updates a document in a document list.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="document">The document properties that define the content used by the content management system (CMS).</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.Document"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   var document = await document.UpdateDocumentAsync( document,  documentListName,  documentId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Content.Document> UpdateDocumentAsync(Mozu.Api.Contracts.Content.Document document, string documentListName, string documentId, string responseFields =  null, CancellationToken ct = default(CancellationToken))
		{
			MozuClient<Mozu.Api.Contracts.Content.Document> response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.UpdateDocumentClient( document,  documentListName,  documentId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);
			return await response.ResultAsync();

		}


		/// <summary>
		/// Deletes a specific document based on the specified document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   await document.DeleteDocumentAsync( documentListName,  documentId);
		/// </code>
		/// </example>
		public virtual async Task DeleteDocumentAsync(string documentListName, string documentId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.DeleteDocumentClient( documentListName,  documentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


		/// <summary>
		/// Deletes the content associated with a document, such as a product image or PDF specification, by supplying the document ID.
		/// </summary>
		/// <param name="documentId">Unique identifier for a document, used by content and document calls. Document IDs are associated with document types, document type lists, sites, and tenants.</param>
		/// <param name="documentListName">Name of content documentListName to delete</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var document = new Document();
		///   await document.DeleteDocumentContentAsync( documentListName,  documentId);
		/// </code>
		/// </example>
		public virtual async Task DeleteDocumentContentAsync(string documentListName, string documentId, CancellationToken ct = default(CancellationToken))
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Content.Documentlists.DocumentClient.DeleteDocumentContentClient( documentListName,  documentId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync(ct).ConfigureAwait(false);

		}


	}

}


