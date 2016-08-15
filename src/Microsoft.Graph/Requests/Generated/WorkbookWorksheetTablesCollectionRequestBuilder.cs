// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WorkbookWorksheetTablesCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookWorksheetTablesCollectionRequestBuilder : BaseRequestBuilder, IWorkbookWorksheetTablesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookWorksheetTablesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookWorksheetTablesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookWorksheetTablesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookWorksheetTablesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookWorksheetTablesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookTableRequestBuilder"/> for the specified WorkbookWorksheetWorkbookTable.
        /// </summary>
        /// <param name="id">The ID for the WorkbookWorksheetWorkbookTable.</param>
        /// <returns>The <see cref="IWorkbookTableRequestBuilder"/>.</returns>
        public IWorkbookTableRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookTableRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}