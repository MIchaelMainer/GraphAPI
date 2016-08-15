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
    /// The type WorkbookRangeColumnRequestBuilder.
    /// </summary>
    public partial class WorkbookRangeColumnRequestBuilder : BaseGetMethodRequestBuilder<IWorkbookRangeColumnRequest>, IWorkbookRangeColumnRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookRangeColumnRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="column">A column parameter for the OData method call.</param>
        public WorkbookRangeColumnRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32 column)
            : base(requestUrl, client)
        {
            this.SetParameter("column", column, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookRangeColumnRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookRangeColumnRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}