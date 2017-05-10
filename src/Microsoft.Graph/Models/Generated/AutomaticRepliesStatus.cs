// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AutomaticRepliesStatus.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AutomaticRepliesStatus
    {
    
        /// <summary>
        /// disabled
        /// </summary>
        Disabled = 0,
	
        /// <summary>
        /// always Enabled
        /// </summary>
        AlwaysEnabled = 1,
	
        /// <summary>
        /// scheduled
        /// </summary>
        Scheduled = 2,
	
    }
}