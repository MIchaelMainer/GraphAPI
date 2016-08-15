// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsBitandRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsBitandRequestBody
    {
    
        /// <summary>
        /// Gets or sets Number1.
        /// </summary>
        [DataMember(Name = "number1", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Number1 { get; set; }
    
        /// <summary>
        /// Gets or sets Number2.
        /// </summary>
        [DataMember(Name = "number2", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Number2 { get; set; }
    
    }
}
