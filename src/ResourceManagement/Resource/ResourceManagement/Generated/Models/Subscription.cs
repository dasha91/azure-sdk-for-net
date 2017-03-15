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
using Microsoft.Azure.Subscriptions.Models;

namespace Microsoft.Azure.Subscriptions.Models
{
    /// <summary>
    /// Subscription information.
    /// </summary>
    public partial class Subscription
    {
        private string _displayName;
        
        /// <summary>
        /// Optional. Gets or sets the subscription display name
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. Gets or sets the ID of the resource
        /// (/subscriptions/SubscriptionId).
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. Gets or sets the subscription state
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _subscriptionId;
        
        /// <summary>
        /// Optional. Gets or sets the subscription Id.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        private SubscriptionPolicies _subscriptionPolicies;
        
        /// <summary>
        /// Optional. Gets or sets the subscription policies
        /// </summary>
        public SubscriptionPolicies SubscriptionPolicies
        {
            get { return this._subscriptionPolicies; }
            set { this._subscriptionPolicies = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Subscription class.
        /// </summary>
        public Subscription()
        {
        }
    }
}
