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
    using Newtonsoft.Json;

    /// <summary>
    /// The type Deleted.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Deleted
    {
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false, IsRequired = false)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
