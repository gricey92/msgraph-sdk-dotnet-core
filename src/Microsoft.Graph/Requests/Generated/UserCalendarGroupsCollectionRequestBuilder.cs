// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserCalendarGroupsCollectionRequestBuilder.
    /// </summary>
    public partial class UserCalendarGroupsCollectionRequestBuilder : BaseRequestBuilder, IUserCalendarGroupsCollectionRequestBuilder
    {  
        /// <summary>
        /// Constructs a new UserCalendarGroupsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserCalendarGroupsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserCalendarGroupsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserCalendarGroupsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserCalendarGroupsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICalendarGroupRequestBuilder"/> for the specified UserCalendarGroup.
        /// </summary>
        /// <param name="id">The ID for the UserCalendarGroup.</param>
        /// <returns>The <see cref="ICalendarGroupRequestBuilder"/>.</returns>
        public ICalendarGroupRequestBuilder this[string id]
        {
            get
            {
                return new CalendarGroupRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }
    }
}
