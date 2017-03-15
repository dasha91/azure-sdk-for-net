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

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// The localizable string class.
    /// </summary>
    public partial class LocalizableString
    {
        private string _localizedValue;
        
        /// <summary>
        /// Optional. Gets or sets the locale specific value.
        /// </summary>
        public string LocalizedValue
        {
            get { return this._localizedValue; }
            set { this._localizedValue = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Optional. Gets or sets the invariant value.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LocalizableString class.
        /// </summary>
        public LocalizableString()
        {
        }
    }
}
