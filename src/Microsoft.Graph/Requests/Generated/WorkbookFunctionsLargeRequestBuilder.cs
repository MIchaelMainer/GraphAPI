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
    /// The type WorkbookFunctionsLargeRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsLargeRequestBuilder : BasePostMethodRequestBuilder<IWorkbookFunctionsLargeRequest>, IWorkbookFunctionsLargeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsLargeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="array">A array parameter for the OData method call.</param>
        /// <param name="k">A k parameter for the OData method call.</param>
        public WorkbookFunctionsLargeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken array,
            Newtonsoft.Json.Linq.JToken k)
            : base(requestUrl, client)
        {
            this.SetParameter("array", array, true);
            this.SetParameter("k", k, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsLargeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsLargeRequest(functionUrl, this.Client, options);

            if (this.HasParameter("array"))
            {
                request.RequestBody.Array = this.GetParameter<Newtonsoft.Json.Linq.JToken>("array");
            }

            if (this.HasParameter("k"))
            {
                request.RequestBody.K = this.GetParameter<Newtonsoft.Json.Linq.JToken>("k");
            }

            return request;
        }
    }
}
