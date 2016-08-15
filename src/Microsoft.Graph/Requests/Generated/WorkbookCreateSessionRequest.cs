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
    /// The type WorkbookCreateSessionRequest.
    /// </summary>
    public partial class WorkbookCreateSessionRequest : BaseRequest, IWorkbookCreateSessionRequest
    {
        /// <summary>
        /// Constructs a new WorkbookCreateSessionRequest.
        /// </summary>
        public WorkbookCreateSessionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new WorkbookCreateSessionRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public WorkbookCreateSessionRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public System.Threading.Tasks.Task<WorkbookSessionInfo> PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name=""cancellationToken"">The <see cref=""CancellationToken""/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookSessionInfo> PostAsync(
            CancellationToken cancellationToken)
        {
            return this.SendAsync<WorkbookSessionInfo>(this.RequestBody, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookCreateSessionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookCreateSessionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
