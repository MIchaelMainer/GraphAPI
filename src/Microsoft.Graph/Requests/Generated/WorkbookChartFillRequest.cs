// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type WorkbookChartFillRequest.
    /// </summary>
    public partial class WorkbookChartFillRequest : BaseRequest, IWorkbookChartFillRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartFillRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartFillRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartFill using PUT.
        /// </summary>
        /// <param name="workbookChartFillToCreate">The WorkbookChartFill to create.</param>
        /// <returns>The created WorkbookChartFill.</returns>
        public System.Threading.Tasks.Task<WorkbookChartFill> CreateAsync(WorkbookChartFill workbookChartFillToCreate)
        {
            return this.CreateAsync(workbookChartFillToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartFill using PUT.
        /// </summary>
        /// <param name="workbookChartFillToCreate">The WorkbookChartFill to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartFill> CreateAsync(WorkbookChartFill workbookChartFillToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<WorkbookChartFill>(workbookChartFillToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookChartFill.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartFill>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartFill.
        /// </summary>
        /// <returns>The WorkbookChartFill.</returns>
        public System.Threading.Tasks.Task<WorkbookChartFill> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartFill.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartFill> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartFill>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartFill using PATCH.
        /// </summary>
        /// <param name="workbookChartFillToUpdate">The WorkbookChartFill to update.</param>
        /// <returns>The updated WorkbookChartFill.</returns>
        public System.Threading.Tasks.Task<WorkbookChartFill> UpdateAsync(WorkbookChartFill workbookChartFillToUpdate)
        {
            return this.UpdateAsync(workbookChartFillToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartFill using PATCH.
        /// </summary>
        /// <param name="workbookChartFillToUpdate">The WorkbookChartFill to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartFill.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartFill> UpdateAsync(WorkbookChartFill workbookChartFillToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartFill>(workbookChartFillToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartFillRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartFillRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookChartFillToInitialize">The <see cref="WorkbookChartFill"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartFill workbookChartFillToInitialize)
        {

        }
    }
}
