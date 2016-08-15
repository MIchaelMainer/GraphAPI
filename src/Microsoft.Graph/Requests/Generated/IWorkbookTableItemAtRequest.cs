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
    /// The interface IWorkbookTableItemAtRequest.
    /// </summary>
    public partial interface IWorkbookTableItemAtRequest : IBaseRequest
    {

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        System.Threading.Tasks.Task<WorkbookTable> GetAsync();

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>TheWorkbookTable</returns>
        System.Threading.Tasks.Task<WorkbookTable> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableItemAtRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableItemAtRequest Select(string value);
    }
}