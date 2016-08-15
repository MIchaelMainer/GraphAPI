// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WorkbookWorksheetsCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookWorksheetsCollectionRequestBuilder : BaseRequestBuilder, IWorkbookWorksheetsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookWorksheetsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookWorksheetsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookWorksheetsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookWorksheetsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookWorksheetsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookWorksheetRequestBuilder"/> for the specified WorkbookWorkbookWorksheet.
        /// </summary>
        /// <param name="id">The ID for the WorkbookWorkbookWorksheet.</param>
        /// <returns>The <see cref="IWorkbookWorksheetRequestBuilder"/>.</returns>
        public IWorkbookWorksheetRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookWorksheetRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
