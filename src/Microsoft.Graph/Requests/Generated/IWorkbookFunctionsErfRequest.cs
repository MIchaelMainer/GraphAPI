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
    /// The interface IWorkbookFunctionsErfRequest.
    /// </summary>
    public partial interface IWorkbookFunctionsErfRequest : IBaseRequest
    {

        /// <summary>
        /// Gets the request body.
        /// </summary>
        WorkbookFunctionsErfRequestBody RequestBody { get; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        System.Threading.Tasks.Task<WorkbookFunctionResult> PostAsync();

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>TheWorkbookFunctionResult</returns>
        System.Threading.Tasks.Task<WorkbookFunctionResult> PostAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFunctionsErfRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookFunctionsErfRequest Select(string value);
    }
}
