// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookChartSeriesCollectionRequest.
    /// </summary>
    public partial interface IWorkbookChartSeriesCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified WorkbookChartSeries to the collection via POST.
        /// </summary>
        /// <param name="workbookChartSeries">The WorkbookChartSeries to add.</param>
        /// <returns>The created WorkbookChartSeries.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> AddAsync(WorkbookChartSeries workbookChartSeries);

        /// <summary>
        /// Adds the specified WorkbookChartSeries to the collection via POST.
        /// </summary>
        /// <param name="workbookChartSeries">The WorkbookChartSeries to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartSeries.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeries> AddAsync(WorkbookChartSeries workbookChartSeries, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWorkbookChartSeriesCollectionPage> GetAsync();

        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWorkbookChartSeriesCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesCollectionRequest OrderBy(string value);
    }
}
