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
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class WatcherOperationsExtensions
    {
        /// <summary>
        /// Create the watcher identified by watcher name.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create or update parameters for watcher.
        /// </param>
        /// <returns>
        /// The response model for the create or update watcher operation.
        /// </returns>
        public static WatcherCreateOrUpdateResponse CreateOrUpdate(this IWatcherOperations operations, string resourceGroupName, string automationAccount, WatcherCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWatcherOperations)s).CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create the watcher identified by watcher name.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The create or update parameters for watcher.
        /// </param>
        /// <returns>
        /// The response model for the create or update watcher operation.
        /// </returns>
        public static Task<WatcherCreateOrUpdateResponse> CreateOrUpdateAsync(this IWatcherOperations operations, string resourceGroupName, string automationAccount, WatcherCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the watcher by name.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// Required. The watcher name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IWatcherOperations operations, string resourceGroupName, string automationAccount, string watcherName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWatcherOperations)s).DeleteAsync(resourceGroupName, automationAccount, watcherName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the watcher by name.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// Required. The watcher name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IWatcherOperations operations, string resourceGroupName, string automationAccount, string watcherName)
        {
            return operations.DeleteAsync(resourceGroupName, automationAccount, watcherName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the watcher identified by watcher name.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// Required. The watcher name.
        /// </param>
        /// <returns>
        /// The response model for the get watcher operation.
        /// </returns>
        public static WatcherGetResponse Get(this IWatcherOperations operations, string resourceGroupName, string automationAccount, string watcherName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWatcherOperations)s).GetAsync(resourceGroupName, automationAccount, watcherName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the watcher identified by watcher name.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// Required. The watcher name.
        /// </param>
        /// <returns>
        /// The response model for the get watcher operation.
        /// </returns>
        public static Task<WatcherGetResponse> GetAsync(this IWatcherOperations operations, string resourceGroupName, string automationAccount, string watcherName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, watcherName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of watchers.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list watcher operation.
        /// </returns>
        public static WatcherListResponse List(this IWatcherOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWatcherOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of watchers.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list watcher operation.
        /// </returns>
        public static Task<WatcherListResponse> ListAsync(this IWatcherOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of watchers.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list watcher operation.
        /// </returns>
        public static WatcherListResponse ListNext(this IWatcherOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWatcherOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of watchers.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list watcher operation.
        /// </returns>
        public static Task<WatcherListResponse> ListNextAsync(this IWatcherOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Starts the watcher identified by watcherName.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// Required. The watcher name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Start(this IWatcherOperations operations, string resourceGroupName, string automationAccount, string watcherName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWatcherOperations)s).StartAsync(resourceGroupName, automationAccount, watcherName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Starts the watcher identified by watcherName.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// Required. The watcher name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> StartAsync(this IWatcherOperations operations, string resourceGroupName, string automationAccount, string watcherName)
        {
            return operations.StartAsync(resourceGroupName, automationAccount, watcherName, CancellationToken.None);
        }
        
        /// <summary>
        /// Stop the watcher identified by watcherName.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// Required. The watcher name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Stop(this IWatcherOperations operations, string resourceGroupName, string automationAccount, string watcherName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWatcherOperations)s).StopAsync(resourceGroupName, automationAccount, watcherName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Stop the watcher identified by watcherName.  (see
        /// http://aka.ms/azureautomationsdk/watcheroperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IWatcherOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='watcherName'>
        /// Required. The watcher name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> StopAsync(this IWatcherOperations operations, string resourceGroupName, string automationAccount, string watcherName)
        {
            return operations.StopAsync(resourceGroupName, automationAccount, watcherName, CancellationToken.None);
        }
    }
}
