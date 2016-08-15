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
    /// The type WorkbookFunctionsDcountRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsDcountRequestBuilder : BasePostMethodRequestBuilder<IWorkbookFunctionsDcountRequest>, IWorkbookFunctionsDcountRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsDcountRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="database">A database parameter for the OData method call.</param>
        /// <param name="field">A field parameter for the OData method call.</param>
        /// <param name="criteria">A criteria parameter for the OData method call.</param>
        public WorkbookFunctionsDcountRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken database,
            Newtonsoft.Json.Linq.JToken field,
            Newtonsoft.Json.Linq.JToken criteria)
            : base(requestUrl, client)
        {
            this.SetParameter("database", database, true);
            this.SetParameter("field", field, true);
            this.SetParameter("criteria", criteria, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsDcountRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsDcountRequest(functionUrl, this.Client, options);

            if (this.HasParameter("database"))
            {
                request.RequestBody.Database = this.GetParameter<Newtonsoft.Json.Linq.JToken>("database");
            }

            if (this.HasParameter("field"))
            {
                request.RequestBody.Field = this.GetParameter<Newtonsoft.Json.Linq.JToken>("field");
            }

            if (this.HasParameter("criteria"))
            {
                request.RequestBody.Criteria = this.GetParameter<Newtonsoft.Json.Linq.JToken>("criteria");
            }

            return request;
        }
    }
}
