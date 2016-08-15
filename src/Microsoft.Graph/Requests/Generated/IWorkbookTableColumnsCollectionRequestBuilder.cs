// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWorkbookTableColumnsCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookTableColumnsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookTableColumnsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookTableColumnsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookTableColumnRequestBuilder"/> for the specified WorkbookTableColumn.
        /// </summary>
        /// <param name="id">The ID for the WorkbookTableColumn.</param>
        /// <returns>The <see cref="IWorkbookTableColumnRequestBuilder"/>.</returns>
        IWorkbookTableColumnRequestBuilder this[string id] { get; }
    }
}