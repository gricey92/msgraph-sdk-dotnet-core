// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface IGraphServiceSubscriptionsCollectionRequest.
    /// </summary>
    public partial interface IGraphServiceSubscriptionsCollectionRequest : IBaseRequest
    {
        
        /// <summary>
        /// Adds the specified Subscription to the collection via POST.
        /// </summary>
        /// <param name="subscription">The Subscription to add.</param>
        /// <returns>The created Subscription.</returns>
        Task<Subscription> AddAsync(Subscription subscription);

        /// <summary>
        /// Adds the specified Subscription to the collection via POST.
        /// </summary>
        /// <param name="subscription">The Subscription to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Subscription.</returns>
        Task<Subscription> AddAsync(Subscription subscription, CancellationToken cancellationToken);
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <returns>The collection page.</returns>
        Task<IGraphServiceSubscriptionsCollectionPage> GetAsync();
        
        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        Task<IGraphServiceSubscriptionsCollectionPage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceSubscriptionsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceSubscriptionsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceSubscriptionsCollectionRequest Top(int value);
        
        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceSubscriptionsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceSubscriptionsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IGraphServiceSubscriptionsCollectionRequest OrderBy(string value);
    }
}
