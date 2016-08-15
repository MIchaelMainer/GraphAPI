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
    /// The type WorkbookTableRowAddRequestBuilder.
    /// </summary>
    public partial class WorkbookTableRowAddRequestBuilder : BasePostMethodRequestBuilder<IWorkbookTableRowAddRequest>, IWorkbookTableRowAddRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookTableRowAddRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <param name="values">A values parameter for the OData method call.</param>
        public WorkbookTableRowAddRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Int32? index,
            Newtonsoft.Json.Linq.JToken values)
            : base(requestUrl, client)
        {
            this.SetParameter("index", index, true);
            this.SetParameter("values", values, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookTableRowAddRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookTableRowAddRequest(functionUrl, this.Client, options);

            if (this.HasParameter("index"))
            {
                request.RequestBody.Index = this.GetParameter<Int32?>("index");
            }

            if (this.HasParameter("values"))
            {
                request.RequestBody.Values = this.GetParameter<Newtonsoft.Json.Linq.JToken>("values");
            }

            return request;
        }
    }
}
