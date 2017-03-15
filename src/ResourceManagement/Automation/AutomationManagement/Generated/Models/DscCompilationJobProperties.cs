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
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of Dsc Compilation job properties.
    /// </summary>
    public partial class DscCompilationJobProperties : JobPropertiesBase
    {
        private DscConfigurationAssociationProperty _configuration;
        
        /// <summary>
        /// Optional. Gets or sets the configuration.
        /// </summary>
        public DscConfigurationAssociationProperty Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }
        
        private string _runOn;
        
        /// <summary>
        /// Optional. Gets or sets the hybrid worker group name for the job.
        /// </summary>
        public string RunOn
        {
            get { return this._runOn; }
            set { this._runOn = value; }
        }
        
        private string _startedBy;
        
        /// <summary>
        /// Optional. Gets or sets the compilation job started by.
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscCompilationJobProperties class.
        /// </summary>
        public DscCompilationJobProperties()
        {
        }
    }
}
