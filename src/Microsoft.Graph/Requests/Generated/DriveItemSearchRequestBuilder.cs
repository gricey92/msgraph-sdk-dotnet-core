// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The type DriveItemSearchRequestBuilder.
    /// </summary>
    public partial class DriveItemSearchRequestBuilder : BaseRequestBuilder, IDriveItemSearchRequestBuilder
    {
    
        public DriveItemSearchRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string q = null)
            : base(requestUrl, client)
        {
            
            this.Q = q;

        }
    
        /// <summary>
        /// Gets the value of Q.
        /// </summary>
        public string Q { get; set; }
    
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDriveItemSearchRequest Request(IEnumerable<Option> options = null)
        {
        
            var functionRequestUrl = this.RequestUrl;
            
            var functionParametersStringBuilder = new StringBuilder();

            if (this.Q != null)
            {
                functionParametersStringBuilder.AppendFormat("q='{0}'", this.Q);
            }
            else
            {
                functionParametersStringBuilder.Append("q=null");
            }

            functionRequestUrl = string.Format("{0}({1})", this.RequestUrl, functionParametersStringBuilder.ToString());
            
            return new DriveItemSearchRequest(
                functionRequestUrl,
                this.Client,
                options);
        
        }

    }
}

