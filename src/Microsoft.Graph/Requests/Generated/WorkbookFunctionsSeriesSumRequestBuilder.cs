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
    /// The type WorkbookFunctionsSeriesSumRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsSeriesSumRequestBuilder : BasePostMethodRequestBuilder<IWorkbookFunctionsSeriesSumRequest>, IWorkbookFunctionsSeriesSumRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsSeriesSumRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        /// <param name="n">A n parameter for the OData method call.</param>
        /// <param name="m">A m parameter for the OData method call.</param>
        /// <param name="coefficients">A coefficients parameter for the OData method call.</param>
        public WorkbookFunctionsSeriesSumRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken x,
            Newtonsoft.Json.Linq.JToken n,
            Newtonsoft.Json.Linq.JToken m,
            Newtonsoft.Json.Linq.JToken coefficients)
            : base(requestUrl, client)
        {
            this.SetParameter("x", x, true);
            this.SetParameter("n", n, true);
            this.SetParameter("m", m, true);
            this.SetParameter("coefficients", coefficients, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsSeriesSumRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsSeriesSumRequest(functionUrl, this.Client, options);

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<Newtonsoft.Json.Linq.JToken>("x");
            }

            if (this.HasParameter("n"))
            {
                request.RequestBody.N = this.GetParameter<Newtonsoft.Json.Linq.JToken>("n");
            }

            if (this.HasParameter("m"))
            {
                request.RequestBody.M = this.GetParameter<Newtonsoft.Json.Linq.JToken>("m");
            }

            if (this.HasParameter("coefficients"))
            {
                request.RequestBody.Coefficients = this.GetParameter<Newtonsoft.Json.Linq.JToken>("coefficients");
            }

            return request;
        }
    }
}
