// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The type CalendarGroupRequest.
    /// </summary>
    public partial class CalendarGroupRequest : BaseRequest, ICalendarGroupRequest
    {
        /// <summary>
        /// Constructs a new CalendarGroupRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CalendarGroupRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CalendarGroup using PUT.
        /// </summary>
        /// <param name="calendarGroupToCreate">The CalendarGroup to create.</param>
        /// <returns>The created CalendarGroup.</returns>
        public Task<CalendarGroup> CreateAsync(CalendarGroup calendarGroupToCreate)
        {
            return this.CreateAsync(calendarGroupToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified CalendarGroup using PUT.
        /// </summary>
        /// <param name="calendarGroupToCreate">The CalendarGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CalendarGroup.</returns>
        public async Task<CalendarGroup> CreateAsync(CalendarGroup calendarGroupToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PUT";
            var newEntity = await this.SendAsync<CalendarGroup>(calendarGroupToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified CalendarGroup.
        /// </summary>
        /// <returns>The task to await.</returns>
        public Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified CalendarGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<CalendarGroup>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified CalendarGroup.
        /// </summary>
        /// <returns>The CalendarGroup.</returns>
        public Task<CalendarGroup> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified CalendarGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CalendarGroup.</returns>
        public async Task<CalendarGroup> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<CalendarGroup>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified CalendarGroup using PATCH.
        /// </summary>
        /// <param name="calendarGroupToUpdate">The CalendarGroup to update.</param>
        /// <returns>The updated CalendarGroup.</returns>
        public Task<CalendarGroup> UpdateAsync(CalendarGroup calendarGroupToUpdate)
        {
            return this.UpdateAsync(calendarGroupToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified CalendarGroup using PATCH.
        /// </summary>
        /// <param name="calendarGroupToUpdate">The CalendarGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated CalendarGroup.</returns>
        public async Task<CalendarGroup> UpdateAsync(CalendarGroup calendarGroupToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<CalendarGroup>(calendarGroupToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarGroupRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ICalendarGroupRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="calendarGroupToInitialize">The <see cref="CalendarGroup"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CalendarGroup calendarGroupToInitialize)
        {
        
            if (calendarGroupToInitialize != null && calendarGroupToInitialize.AdditionalData != null)
            {
        
                if (calendarGroupToInitialize.Calendars != null && calendarGroupToInitialize.Calendars.CurrentPage != null)
                {
                    calendarGroupToInitialize.Calendars.AdditionalData = calendarGroupToInitialize.AdditionalData;

                    object nextPageLink;
                    calendarGroupToInitialize.AdditionalData.TryGetValue("calendars@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        calendarGroupToInitialize.Calendars.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }
        
            }

        
        }
    }
}
