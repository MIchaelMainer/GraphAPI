// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WorkbookTableRowsCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookTableRowsCollectionRequestBuilder : BaseRequestBuilder, IWorkbookTableRowsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookTableRowsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookTableRowsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookTableRowsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookTableRowsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookTableRowsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookTableRowRequestBuilder"/> for the specified WorkbookTableWorkbookTableRow.
        /// </summary>
        /// <param name="id">The ID for the WorkbookTableWorkbookTableRow.</param>
        /// <returns>The <see cref="IWorkbookTableRowRequestBuilder"/>.</returns>
        public IWorkbookTableRowRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookTableRowRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
