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
    /// The type WorkbookFunctionsBeta_DistRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsBeta_DistRequestBody
    {
    
        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [DataMember(Name = "x", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken X { get; set; }
    
        /// <summary>
        /// Gets or sets Alpha.
        /// </summary>
        [DataMember(Name = "alpha", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Alpha { get; set; }
    
        /// <summary>
        /// Gets or sets Beta.
        /// </summary>
        [DataMember(Name = "beta", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Beta { get; set; }
    
        /// <summary>
        /// Gets or sets Cumulative.
        /// </summary>
        [DataMember(Name = "cumulative", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Cumulative { get; set; }
    
        /// <summary>
        /// Gets or sets A.
        /// </summary>
        [DataMember(Name = "A", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken A { get; set; }
    
        /// <summary>
        /// Gets or sets B.
        /// </summary>
        [DataMember(Name = "B", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken B { get; set; }
    
    }
}
