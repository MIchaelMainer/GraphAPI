// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WorkbookWorksheetChartsCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookWorksheetChartsCollectionRequestBuilder : BaseRequestBuilder, IWorkbookWorksheetChartsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookWorksheetChartsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookWorksheetChartsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookWorksheetChartsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookWorksheetChartsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookWorksheetChartsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookChartRequestBuilder"/> for the specified WorkbookWorksheetWorkbookChart.
        /// </summary>
        /// <param name="id">The ID for the WorkbookWorksheetWorkbookChart.</param>
        /// <returns>The <see cref="IWorkbookChartRequestBuilder"/>.</returns>
        public IWorkbookChartRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookChartRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
