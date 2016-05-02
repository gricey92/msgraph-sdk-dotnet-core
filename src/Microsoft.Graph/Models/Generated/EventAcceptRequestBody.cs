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
    /// The type EventAcceptRequestBody.
    /// </summary>
    [DataContract]
    public partial class EventAcceptRequestBody
    {
    
        /// <summary>
        /// Gets or sets Comment.
        /// </summary>
        [DataMember(Name = "Comment", EmitDefaultValue = false, IsRequired = false)]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets SendResponse.
        /// </summary>
        [DataMember(Name = "SendResponse", EmitDefaultValue = false, IsRequired = false)]
        public bool? SendResponse { get; set; }
    
    }
}
