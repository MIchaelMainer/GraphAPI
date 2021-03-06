// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartSeriesRequestBuilder.
    /// </summary>
    public partial class WorkbookChartSeriesRequestBuilder : EntityRequestBuilder, IWorkbookChartSeriesRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookChartSeriesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookChartSeriesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookChartSeriesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookChartSeriesRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookChartSeriesRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Format.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesFormatRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesFormatRequestBuilder Format
        {
            get
            {
                return new WorkbookChartSeriesFormatRequestBuilder(this.AppendSegmentToRequestUrl("format"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Points.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesPointsCollectionRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesPointsCollectionRequestBuilder Points
        {
            get
            {
                return new WorkbookChartSeriesPointsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("points"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for WorkbookChartSeriesItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesItemAtRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookChartSeriesItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartSeriesCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesCountRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesCountRequestBuilder Count()
        {
            return new WorkbookChartSeriesCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
    
    }
}
