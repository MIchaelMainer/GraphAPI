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
    /// The type WorkbookApplicationCalculateRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookApplicationCalculateRequestBody
    {
    
        /// <summary>
        /// Gets or sets CalculationType.
        /// </summary>
        [DataMember(Name = "calculationType", EmitDefaultValue = false, IsRequired = false)]
        public string CalculationType { get; set; }
    
    }
}
