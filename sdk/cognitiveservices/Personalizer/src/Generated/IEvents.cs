// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Events operations.
    /// </summary>
    public partial interface IEvents
    {
        /// <summary>
        /// Post Reward.
        /// </summary>
        /// <remarks>
        /// Report reward that resulted from using the action specified in
        /// rewardActionId for the specified event.
        /// </remarks>
        /// <param name='eventId'>
        /// The event id this reward applies to.
        /// </param>
        /// <param name='reward'>
        /// The reward should be a floating point number, typically between 0
        /// and 1.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> RewardWithHttpMessagesAsync(string eventId, RewardRequest reward, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Activate Event.
        /// </summary>
        /// <remarks>
        /// Report that the specified event was actually displayed to the user
        /// and a reward should be expected for it
        /// </remarks>
        /// <param name='eventId'>
        /// The event ID this activation applies to.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> ActivateWithHttpMessagesAsync(string eventId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
