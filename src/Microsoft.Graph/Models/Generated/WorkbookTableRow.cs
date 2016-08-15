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
    /// The type Workbook Table Row.
    /// </summary>
    [DataContract]
    public partial class WorkbookTableRow : Entity
    {
    
        /// <summary>
        /// Gets or sets index.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false, IsRequired = false)]
        public Int32? Index { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Values { get; set; }
    
    }
}

