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
using Microsoft.Azure.Insights;
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights
{
    public static partial class MetricDefinitionOperationsExtensions
    {
        /// <summary>
        /// The List Metric Definitions operation lists the metric definitions
        /// for the resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Insights.IMetricDefinitionOperations.
        /// </param>
        /// <param name='resourceUri'>
        /// Required. The uri of the target resource to get metrics for.
        /// </param>
        /// <param name='filterString'>
        /// Required. An OData $filter expression that supports querying by the
        /// name of the metric definition.
        /// </param>
        /// <returns>
        /// The List Metric Definitions operation response.
        /// </returns>
        public static MetricDefinitionListResponse GetMetricDefinitions(this IMetricDefinitionOperations operations, string resourceUri, string filterString)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IMetricDefinitionOperations)s).GetMetricDefinitionsAsync(resourceUri, filterString);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Metric Definitions operation lists the metric definitions
        /// for the resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Insights.IMetricDefinitionOperations.
        /// </param>
        /// <param name='resourceUri'>
        /// Required. The uri of the target resource to get metrics for.
        /// </param>
        /// <param name='filterString'>
        /// Required. An OData $filter expression that supports querying by the
        /// name of the metric definition.
        /// </param>
        /// <returns>
        /// The List Metric Definitions operation response.
        /// </returns>
        public static Task<MetricDefinitionListResponse> GetMetricDefinitionsAsync(this IMetricDefinitionOperations operations, string resourceUri, string filterString)
        {
            return operations.GetMetricDefinitionsAsync(resourceUri, filterString, CancellationToken.None);
        }
    }
}
