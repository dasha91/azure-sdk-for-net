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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.WebSitesExtensions.Models;

namespace Microsoft.WindowsAzure.WebSitesExtensions.Models
{
    /// <summary>
    /// The list of continuous WebJobs operation response.
    /// </summary>
    public partial class ContinuousWebJobListResponse : OperationResponse, IEnumerable<ContinuousWebJob>
    {
        private IList<ContinuousWebJob> _continuousWebJobs;
        
        /// <summary>
        /// Optional. The list of continuous WebJobs.
        /// </summary>
        public IList<ContinuousWebJob> ContinuousWebJobs
        {
            get { return this._continuousWebJobs; }
            set { this._continuousWebJobs = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ContinuousWebJobListResponse
        /// class.
        /// </summary>
        public ContinuousWebJobListResponse()
        {
            this.ContinuousWebJobs = new List<ContinuousWebJob>();
        }
        
        /// <summary>
        /// Gets the sequence of ContinuousWebJobs.
        /// </summary>
        public IEnumerator<ContinuousWebJob> GetEnumerator()
        {
            return this.ContinuousWebJobs.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of ContinuousWebJobs.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
