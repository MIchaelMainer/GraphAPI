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
    /// The type WorkbookFunctionsWeekdayRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsWeekdayRequestBuilder : BasePostMethodRequestBuilder<IWorkbookFunctionsWeekdayRequest>, IWorkbookFunctionsWeekdayRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsWeekdayRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="serialNumber">A serialNumber parameter for the OData method call.</param>
        /// <param name="returnType">A returnType parameter for the OData method call.</param>
        public WorkbookFunctionsWeekdayRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken serialNumber,
            Newtonsoft.Json.Linq.JToken returnType)
            : base(requestUrl, client)
        {
            this.SetParameter("serialNumber", serialNumber, true);
            this.SetParameter("returnType", returnType, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsWeekdayRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsWeekdayRequest(functionUrl, this.Client, options);

            if (this.HasParameter("serialNumber"))
            {
                request.RequestBody.SerialNumber = this.GetParameter<Newtonsoft.Json.Linq.JToken>("serialNumber");
            }

            if (this.HasParameter("returnType"))
            {
                request.RequestBody.ReturnType = this.GetParameter<Newtonsoft.Json.Linq.JToken>("returnType");
            }

            return request;
        }
    }
}
