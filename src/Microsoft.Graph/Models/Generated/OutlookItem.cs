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
    /// The type Outlook Item.
    /// </summary>
    [DataContract]
    public partial class OutlookItem : Entity
    {
    
        protected internal OutlookItem()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [DataMember(Name = "createdDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [DataMember(Name = "lastModifiedDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets change key.
        /// </summary>
        [DataMember(Name = "changeKey", EmitDefaultValue = false, IsRequired = false)]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets categories.
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> Categories { get; set; }
    
    }
}

