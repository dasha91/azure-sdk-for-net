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

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    /// <summary>
    /// The Name object of Usage.
    /// </summary>
    public partial class Name
    {
        private string _localizedValue;
        
        /// <summary>
        /// Required. Gets or sets the localized value of usage.
        /// </summary>
        public string LocalizedValue
        {
            get { return this._localizedValue; }
            set { this._localizedValue = value; }
        }
        
        private string _value;
        
        /// <summary>
        /// Required. Gets or sets the value of usage.
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Name class.
        /// </summary>
        public Name()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Name class with required
        /// arguments.
        /// </summary>
        public Name(string value, string localizedValue)
            : this()
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            if (localizedValue == null)
            {
                throw new ArgumentNullException("localizedValue");
            }
            this.Value = value;
            this.LocalizedValue = localizedValue;
        }
    }
}
