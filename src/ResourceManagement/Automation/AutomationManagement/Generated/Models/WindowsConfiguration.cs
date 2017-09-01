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
using Hyak.Common;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The udpate deployment windows configuration.
    /// </summary>
    public partial class WindowsConfiguration
    {
        private IList<string> _excludedKbNumbers;
        
        /// <summary>
        /// Optional. Gets or sets the excluded kb number of software update
        /// configuration.
        /// </summary>
        public IList<string> ExcludedKbNumbers
        {
            get { return this._excludedKbNumbers; }
            set { this._excludedKbNumbers = value; }
        }
        
        private string _includedUpdateClassifications;
        
        /// <summary>
        /// Optional. Gets or sets the windows update classifications of
        /// software update configuration.
        /// </summary>
        public string IncludedUpdateClassifications
        {
            get { return this._includedUpdateClassifications; }
            set { this._includedUpdateClassifications = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WindowsConfiguration class.
        /// </summary>
        public WindowsConfiguration()
        {
            this.ExcludedKbNumbers = new LazyList<string>();
        }
    }
}