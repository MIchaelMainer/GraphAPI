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
    /// The type Workbook Chart.
    /// </summary>
    [DataContract]
    public partial class WorkbookChart : Entity
    {
    
        /// <summary>
        /// Gets or sets height.
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false, IsRequired = false)]
        public double? Height { get; set; }
    
        /// <summary>
        /// Gets or sets left.
        /// </summary>
        [DataMember(Name = "left", EmitDefaultValue = false, IsRequired = false)]
        public double? Left { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets top.
        /// </summary>
        [DataMember(Name = "top", EmitDefaultValue = false, IsRequired = false)]
        public double? Top { get; set; }
    
        /// <summary>
        /// Gets or sets width.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false, IsRequired = false)]
        public double? Width { get; set; }
    
        /// <summary>
        /// Gets or sets axes.
        /// </summary>
        [DataMember(Name = "axes", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookChartAxes Axes { get; set; }
    
        /// <summary>
        /// Gets or sets data labels.
        /// </summary>
        [DataMember(Name = "dataLabels", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookChartDataLabels DataLabels { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookChartAreaFormat Format { get; set; }
    
        /// <summary>
        /// Gets or sets legend.
        /// </summary>
        [DataMember(Name = "legend", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookChartLegend Legend { get; set; }
    
        /// <summary>
        /// Gets or sets series.
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false, IsRequired = false)]
        public IWorkbookChartSeriesCollectionPage Series { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookChartTitle Title { get; set; }
    
        /// <summary>
        /// Gets or sets worksheet.
        /// </summary>
        [DataMember(Name = "worksheet", EmitDefaultValue = false, IsRequired = false)]
        public WorkbookWorksheet Worksheet { get; set; }
    
    }
}

