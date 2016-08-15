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
    /// The type WorkbookFunctionsDatevalueRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsDatevalueRequestBuilder : BasePostMethodRequestBuilder<IWorkbookFunctionsDatevalueRequest>, IWorkbookFunctionsDatevalueRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsDatevalueRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="dateText">A dateText parameter for the OData method call.</param>
        public WorkbookFunctionsDatevalueRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken dateText)
            : base(requestUrl, client)
        {
            this.SetParameter("dateText", dateText, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsDatevalueRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsDatevalueRequest(functionUrl, this.Client, options);

            if (this.HasParameter("dateText"))
            {
                request.RequestBody.DateText = this.GetParameter<Newtonsoft.Json.Linq.JToken>("dateText");
            }

            return request;
        }
    }
}
