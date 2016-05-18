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

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Location.
    /// </summary>
    public partial class Location
    {
        private string _displayName;
        
        /// <summary>
        /// Optional. Display name of location.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. Id of location.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _latitude;
        
        /// <summary>
        /// Optional. The latitude of location.
        /// </summary>
        public string Latitude
        {
            get { return this._latitude; }
            set { this._latitude = value; }
        }
        
        private string _longitude;
        
        /// <summary>
        /// Optional. The longitude of location.
        /// </summary>
        public string Longitude
        {
            get { return this._longitude; }
            set { this._longitude = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name of location.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        public Location()
        {
        }
    }
}
