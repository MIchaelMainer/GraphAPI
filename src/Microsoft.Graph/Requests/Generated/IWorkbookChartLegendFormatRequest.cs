// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookChartLegendFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartLegendFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartLegendFormat using PUT.
        /// </summary>
        /// <param name="workbookChartLegendFormatToCreate">The WorkbookChartLegendFormat to create.</param>
        /// <returns>The created WorkbookChartLegendFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegendFormat> CreateAsync(WorkbookChartLegendFormat workbookChartLegendFormatToCreate);        /// <summary>
        /// Creates the specified WorkbookChartLegendFormat using PUT.
        /// </summary>
        /// <param name="workbookChartLegendFormatToCreate">The WorkbookChartLegendFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartLegendFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegendFormat> CreateAsync(WorkbookChartLegendFormat workbookChartLegendFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartLegendFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartLegendFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartLegendFormat.
        /// </summary>
        /// <returns>The WorkbookChartLegendFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegendFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartLegendFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartLegendFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegendFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartLegendFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartLegendFormatToUpdate">The WorkbookChartLegendFormat to update.</param>
        /// <returns>The updated WorkbookChartLegendFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegendFormat> UpdateAsync(WorkbookChartLegendFormat workbookChartLegendFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartLegendFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartLegendFormatToUpdate">The WorkbookChartLegendFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartLegendFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegendFormat> UpdateAsync(WorkbookChartLegendFormat workbookChartLegendFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLegendFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLegendFormatRequest Select(string value);

    }
}
