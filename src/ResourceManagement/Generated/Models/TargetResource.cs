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

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// Target resource.
    /// </summary>
    public partial class TargetResource
    {
        private string _id;
        
        /// <summary>
        /// Optional. Gets or sets the ID of the resource.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _resourceName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the resource.
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }
        
        private string _resourceType;
        
        /// <summary>
        /// Optional. Gets or sets the type of the resource.
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TargetResource class.
        /// </summary>
        public TargetResource()
        {
        }
    }
}
