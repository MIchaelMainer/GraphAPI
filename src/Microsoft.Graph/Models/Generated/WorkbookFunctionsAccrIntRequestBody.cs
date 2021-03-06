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
    /// The type WorkbookFunctionsAccrIntRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsAccrIntRequestBody
    {
    
        /// <summary>
        /// Gets or sets Issue.
        /// </summary>
        [DataMember(Name = "issue", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Issue { get; set; }
    
        /// <summary>
        /// Gets or sets FirstInterest.
        /// </summary>
        [DataMember(Name = "firstInterest", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken FirstInterest { get; set; }
    
        /// <summary>
        /// Gets or sets Settlement.
        /// </summary>
        [DataMember(Name = "settlement", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Settlement { get; set; }
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Par.
        /// </summary>
        [DataMember(Name = "par", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Par { get; set; }
    
        /// <summary>
        /// Gets or sets Frequency.
        /// </summary>
        [DataMember(Name = "frequency", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Frequency { get; set; }
    
        /// <summary>
        /// Gets or sets Basis.
        /// </summary>
        [DataMember(Name = "basis", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Basis { get; set; }
    
        /// <summary>
        /// Gets or sets CalcMethod.
        /// </summary>
        [DataMember(Name = "calcMethod", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken CalcMethod { get; set; }
    
    }
}
