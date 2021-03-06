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
    /// The type Workbook.
    /// </summary>
    [DataContract]
    public partial class Workbook : Entity
    {
    
        /// <summary>
        /// Gets or sets application.
        /// </summary>
        [DataMember(Name = "application", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookApplication Application { get; set; }
    
        /// <summary>
        /// Gets or sets names.
        /// </summary>
        [DataMember(Name = "names", EmitDefaultValue = false, IsRequired = false)]
        public IWorkbookNamesCollectionPage Names { get; set; }
    
        /// <summary>
        /// Gets or sets tables.
        /// </summary>
        [DataMember(Name = "tables", EmitDefaultValue = false, IsRequired = false)]
        public IWorkbookTablesCollectionPage Tables { get; set; }
    
        /// <summary>
        /// Gets or sets worksheets.
        /// </summary>
        [DataMember(Name = "worksheets", EmitDefaultValue = false, IsRequired = false)]
        public IWorkbookWorksheetsCollectionPage Worksheets { get; set; }
    
        /// <summary>
        /// Gets or sets functions.
        /// </summary>
        [DataMember(Name = "functions", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookFunctions Functions { get; set; }
    
    }
}

