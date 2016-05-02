// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    
    /// <summary>
    /// The type GraphServiceDirectoryRolesCollectionPage.
    /// </summary>
    public partial class GraphServiceDirectoryRolesCollectionPage : CollectionPage<DirectoryRole>, IGraphServiceDirectoryRolesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IGraphServiceDirectoryRolesCollectionRequest"/> instance.
        /// </summary>
        public IGraphServiceDirectoryRolesCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new GraphServiceDirectoryRolesCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
