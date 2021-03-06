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
    /// The interface IWorkbookChartAxisRequest.
    /// </summary>
    public partial interface IWorkbookChartAxisRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartAxis using PUT.
        /// </summary>
        /// <param name="workbookChartAxisToCreate">The WorkbookChartAxis to create.</param>
        /// <returns>The created WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> CreateAsync(WorkbookChartAxis workbookChartAxisToCreate);        /// <summary>
        /// Creates the specified WorkbookChartAxis using PUT.
        /// </summary>
        /// <param name="workbookChartAxisToCreate">The WorkbookChartAxis to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> CreateAsync(WorkbookChartAxis workbookChartAxisToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartAxis.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartAxis.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartAxis.
        /// </summary>
        /// <returns>The WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartAxis.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartAxis using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisToUpdate">The WorkbookChartAxis to update.</param>
        /// <returns>The updated WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> UpdateAsync(WorkbookChartAxis workbookChartAxisToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartAxis using PATCH.
        /// </summary>
        /// <param name="workbookChartAxisToUpdate">The WorkbookChartAxis to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartAxis.</returns>
        System.Threading.Tasks.Task<WorkbookChartAxis> UpdateAsync(WorkbookChartAxis workbookChartAxisToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartAxisRequest Select(string value);

    }
}
