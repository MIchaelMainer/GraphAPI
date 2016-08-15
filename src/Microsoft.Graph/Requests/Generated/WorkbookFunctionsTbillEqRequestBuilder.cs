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
    /// The type WorkbookFunctionsTbillEqRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsTbillEqRequestBuilder : BasePostMethodRequestBuilder<IWorkbookFunctionsTbillEqRequest>, IWorkbookFunctionsTbillEqRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsTbillEqRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="settlement">A settlement parameter for the OData method call.</param>
        /// <param name="maturity">A maturity parameter for the OData method call.</param>
        /// <param name="discount">A discount parameter for the OData method call.</param>
        public WorkbookFunctionsTbillEqRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken settlement,
            Newtonsoft.Json.Linq.JToken maturity,
            Newtonsoft.Json.Linq.JToken discount)
            : base(requestUrl, client)
        {
            this.SetParameter("settlement", settlement, true);
            this.SetParameter("maturity", maturity, true);
            this.SetParameter("discount", discount, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsTbillEqRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsTbillEqRequest(functionUrl, this.Client, options);

            if (this.HasParameter("settlement"))
            {
                request.RequestBody.Settlement = this.GetParameter<Newtonsoft.Json.Linq.JToken>("settlement");
            }

            if (this.HasParameter("maturity"))
            {
                request.RequestBody.Maturity = this.GetParameter<Newtonsoft.Json.Linq.JToken>("maturity");
            }

            if (this.HasParameter("discount"))
            {
                request.RequestBody.Discount = this.GetParameter<Newtonsoft.Json.Linq.JToken>("discount");
            }

            return request;
        }
    }
}
