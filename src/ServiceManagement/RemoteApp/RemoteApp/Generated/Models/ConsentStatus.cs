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

namespace Microsoft.WindowsAzure.Management.RemoteApp.Models
{
    /// <summary>
    /// End user consent status.
    /// </summary>
    public enum ConsentStatus
    {
        /// <summary>
        /// Unknown consent status.
        /// </summary>
        Unknown = 0,
        
        /// <summary>
        /// The user consent status is not found.
        /// </summary>
        NotFound = 1,
        
        /// <summary>
        /// The user has not yet acted upon the consent request.
        /// </summary>
        Pending = 2,
        
        /// <summary>
        /// The user has accepted the consent request.
        /// </summary>
        Accepted = 3,
        
        /// <summary>
        /// The user has rejected the consent request.
        /// </summary>
        Rejected = 4,
        
        /// <summary>
        /// The user has ignored the consent request.
        /// </summary>
        Ignore = 5,
    }
}
