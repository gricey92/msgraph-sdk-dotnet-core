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
    /// The type SharingLink.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SharingLink
    {
    
        /// <summary>
        /// Gets or sets application.
        /// </summary>
        [DataMember(Name = "application", EmitDefaultValue = false, IsRequired = false)]
        public Identity Application { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets webUrl.
        /// </summary>
        [DataMember(Name = "webUrl", EmitDefaultValue = false, IsRequired = false)]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
