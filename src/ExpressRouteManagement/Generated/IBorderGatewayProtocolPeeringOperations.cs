// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute
{
    public partial interface IBorderGatewayProtocolPeeringOperations
    {
        /// <summary>
        /// The New Dedicated Circuit operation creates a new dedicated circuit.
        /// </summary>
        /// <param name='serviceKey'>
        /// The service key representing the relationship between Azure and the
        /// customer.
        /// </param>
        /// <param name='accessType'>
        /// Whether the peering is private or public.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the New Bgp Peering operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<ExpressRouteOperationResponse> BeginNewAsync(string serviceKey, BgpPeeringAccessType accessType, BorderGatewayProtocolPeeringNewParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Remove Bgp Peering Route operation deletes an existing bgp
        /// peering.
        /// </summary>
        /// <param name='serviceKey'>
        /// Service Key representing the bgp peering to be deleted.
        /// </param>
        /// <param name='accessType'>
        /// Whether the peering is private or public.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<ExpressRouteOperationResponse> BeginRemoveAsync(string serviceKey, BgpPeeringAccessType accessType, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Update Bgp Peering operation updates an existing bgp peering.
        /// </summary>
        /// <param name='serviceKey'>
        /// The service key representing the relationship between Azure and the
        /// customer.
        /// </param>
        /// <param name='accessType'>
        /// Whether the peering is private or public.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Bgp Peering operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<ExpressRouteOperationResponse> BeginUpdateAsync(string serviceKey, BgpPeeringAccessType accessType, BorderGatewayProtocolPeeringUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Bgp Peering operation retrieves the bgp peering for the
        /// dedicated circuit with the specified service key.
        /// </summary>
        /// <param name='serviceKey'>
        /// The servicee key representing the dedicated circuit.
        /// </param>
        /// <param name='accessType'>
        /// Whether the peering is private or public.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Bgp Peering Operation Response.
        /// </returns>
        Task<BorderGatewayProtocolPeeringGetResponse> GetAsync(string serviceKey, BgpPeeringAccessType accessType, CancellationToken cancellationToken);
        
        /// <summary>
        /// The New Bgp Peering operation creates a new bgp peering associated
        /// with the dedicated circuit specified by the service key provided.
        /// </summary>
        /// <param name='serviceKey'>
        /// The service key representing the relationship between Azure and the
        /// customer.
        /// </param>
        /// <param name='accessType'>
        /// Whether the peering is private or public.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the New Bgp Peering operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Bgp Peering Operation Response.
        /// </returns>
        Task<BorderGatewayProtocolPeeringGetResponse> NewAsync(string serviceKey, BgpPeeringAccessType accessType, BorderGatewayProtocolPeeringNewParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Remove Bgp Peering operation deletes an existing bgp peering.
        /// </summary>
        /// <param name='serviceKey'>
        /// Service key associated with the bgp peering to be deleted.
        /// </param>
        /// <param name='accessType'>
        /// Whether the peering is private or public.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<ExpressRouteOperationStatusResponse> RemoveAsync(string serviceKey, BgpPeeringAccessType accessType, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Update Bgp Peering operation updates an existing bgp peering or
        /// creates a new one if one doesn't exist.
        /// </summary>
        /// <param name='serviceKey'>
        /// The service key representing the relationship between Azure and the
        /// customer.
        /// </param>
        /// <param name='accessType'>
        /// Whether the peering is private or public.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Bgp Peering operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Bgp Peering Operation Response.
        /// </returns>
        Task<BorderGatewayProtocolPeeringGetResponse> UpdateAsync(string serviceKey, BgpPeeringAccessType accessType, BorderGatewayProtocolPeeringUpdateParameters parameters, CancellationToken cancellationToken);
    }
}
