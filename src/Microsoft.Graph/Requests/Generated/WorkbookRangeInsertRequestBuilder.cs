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
    /// The type WorkbookRangeInsertRequestBuilder.
    /// </summary>
    public partial class WorkbookRangeInsertRequestBuilder : BasePostMethodRequestBuilder<IWorkbookRangeInsertRequest>, IWorkbookRangeInsertRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookRangeInsertRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="shift">A shift parameter for the OData method call.</param>
        public WorkbookRangeInsertRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string shift)
            : base(requestUrl, client)
        {
            this.SetParameter("shift", shift, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookRangeInsertRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookRangeInsertRequest(functionUrl, this.Client, options);

            if (this.HasParameter("shift"))
            {
                request.RequestBody.Shift = this.GetParameter<string>("shift");
            }

            return request;
        }
    }
}
