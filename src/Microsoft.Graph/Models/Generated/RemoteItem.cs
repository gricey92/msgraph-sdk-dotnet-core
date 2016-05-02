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
    /// The type RemoteItem.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class RemoteItem
    {
    
        /// <summary>
        /// Gets or sets file.
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false, IsRequired = false)]
        public File File { get; set; }
    
        /// <summary>
        /// Gets or sets fileSystemInfo.
        /// </summary>
        [DataMember(Name = "fileSystemInfo", EmitDefaultValue = false, IsRequired = false)]
        public FileSystemInfo FileSystemInfo { get; set; }
    
        /// <summary>
        /// Gets or sets folder.
        /// </summary>
        [DataMember(Name = "folder", EmitDefaultValue = false, IsRequired = false)]
        public Folder Folder { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false, IsRequired = false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false, IsRequired = false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets parentReference.
        /// </summary>
        [DataMember(Name = "parentReference", EmitDefaultValue = false, IsRequired = false)]
        public ItemReference ParentReference { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false, IsRequired = false)]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
