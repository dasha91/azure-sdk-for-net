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
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// Represents a directory configuration, maps a directory path to a
    /// storage container.
    /// </summary>
    public partial class DirectoryConfiguration
    {
        private string _containerName;
        
        /// <summary>
        /// Optional. container to use.
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }
        
        private DirectoryPath _path;
        
        /// <summary>
        /// Optional. path to directory.
        /// </summary>
        public DirectoryPath Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DirectoryConfiguration class.
        /// </summary>
        public DirectoryConfiguration()
        {
        }
    }
}
