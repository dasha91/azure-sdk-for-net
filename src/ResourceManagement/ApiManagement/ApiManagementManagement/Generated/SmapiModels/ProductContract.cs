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
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Product profile.
    /// </summary>
    public partial class ProductContract
    {
        private bool? _approvalRequired;
        
        /// <summary>
        /// Optional. Gets or sets whether subscription approval is required.
        /// If false, new subscriptions will be approved automatically
        /// enabling developers to call the product’s APIs immediately after
        /// subscribing. If true, administrators must manually approve the
        /// subscription before the developer can any of the product’s APIs.
        /// Can be present only if subscriptionRequired property is present
        /// and has a value of false.
        /// </summary>
        public bool? ApprovalRequired
        {
            get { return this._approvalRequired; }
            set { this._approvalRequired = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets Product description. May be 1 to 500
        /// characters long.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _idPath;
        
        /// <summary>
        /// Optional. Gets or sets Product identifier path.
        /// </summary>
        public string IdPath
        {
            get { return this._idPath; }
            set { this._idPath = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets Product name. Must be 1 to 300 characters
        /// long.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private ProductStateContract _state;
        
        /// <summary>
        /// Optional. Gets or sets whether product is published or not.
        /// Published products are discoverable by users of developer portal.
        /// Non published products are visible only to administrators.
        /// </summary>
        public ProductStateContract State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private bool? _subscriptionRequired;
        
        /// <summary>
        /// Optional. Gets or sets whether a product subscription is required
        /// for accessing APIs included in this product. If true, the product
        /// is referred to as "protected" and a valid subscription key is
        /// required for a request to an API included in the product to
        /// succeed. If false, the product is referred to as "open" and
        /// requests to an API included in the product can be made without a
        /// subscription key. If property is omitted when creating a new
        /// product it's value is assumed to be true.
        /// </summary>
        public bool? SubscriptionRequired
        {
            get { return this._subscriptionRequired; }
            set { this._subscriptionRequired = value; }
        }
        
        private int? _subscriptionsLimit;
        
        /// <summary>
        /// Optional. Gets or sets whether the number of subscriptions a user
        /// can have to this product at the same time. Set to null or omit to
        /// allow unlimited per user subscriptions. Can be present only if
        /// subscriptionRequired property is present and has a value of false.
        /// </summary>
        public int? SubscriptionsLimit
        {
            get { return this._subscriptionsLimit; }
            set { this._subscriptionsLimit = value; }
        }
        
        private string _terms;
        
        /// <summary>
        /// Optional. Gets or sets Product terms and conditions. Developer will
        /// have to accept these terms before he's allowed to call product API.
        /// </summary>
        public string Terms
        {
            get { return this._terms; }
            set { this._terms = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProductContract class.
        /// </summary>
        public ProductContract()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ProductContract class with
        /// required arguments.
        /// </summary>
        public ProductContract(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}
