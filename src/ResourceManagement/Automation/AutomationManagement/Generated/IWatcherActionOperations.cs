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
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation watcher actions.  (see
    /// http://aka.ms/azureautomationsdk/watcheractionoperations for more
    /// information)
    /// </summary>
    public partial interface IWatcherActionOperations
    {
        /// <summary>
        /// Create the watcher action identified by watcher name.  (see
        /// http://aka.ms/azureautomationsdk/watcheractionoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// The watcher's name.
        /// </param>
        /// <param name='parameters'>
        /// The create or update parameters for watcher.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the create or update watcher action
        /// operation.
        /// </returns>
        Task<WatcherActionCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string automationAccount, string watcherName, WatcherActionCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the watcher action by watcher name.  (see
        /// http://aka.ms/azureautomationsdk/watcheractionoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// The watcher name.
        /// </param>
        /// <param name='watcherActionName'>
        /// The watcher action's name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string automationAccount, string watcherName, string watcherActionName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the watcher action identified by watcher name.  (see
        /// http://aka.ms/azureautomationsdk/watcheractionoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// The watcher name.
        /// </param>
        /// <param name='watcherActionName'>
        /// The watcher action's name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get watcher action operation.
        /// </returns>
        Task<WatcherActionGetResponse> GetAsync(string resourceGroupName, string automationAccount, string watcherName, string watcherActionName, CancellationToken cancellationToken);
    }
}
