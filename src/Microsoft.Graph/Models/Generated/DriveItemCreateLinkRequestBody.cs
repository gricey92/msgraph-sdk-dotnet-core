// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DriveItemCreateLinkRequestBody.
    /// </summary>
    [DataContract]
    public partial class DriveItemCreateLinkRequestBody
    {
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false, IsRequired = false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or sets Scope.
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false, IsRequired = false)]
        public string Scope { get; set; }
    
    }
}
