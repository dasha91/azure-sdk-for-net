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
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Model for delegated offer.
    /// </summary>
    public partial class DelegatedOfferModel
    {
        private AccessibilityState _accessibilityState;
        
        /// <summary>
        /// Optional. Accessibility state.
        /// </summary>
        public AccessibilityState AccessibilityState
        {
            get { return this._accessibilityState; }
            set { this._accessibilityState = value; }
        }
        
        private bool _decommissionedByParentProvider;
        
        /// <summary>
        /// Optional. Indicating whether the delegated offer was decommissioned
        /// by the parent provider.
        /// </summary>
        public bool DecommissionedByParentProvider
        {
            get { return this._decommissionedByParentProvider; }
            set { this._decommissionedByParentProvider = value; }
        }
        
        private string _externalReferenceId;
        
        /// <summary>
        /// Optional. External reference ID.
        /// </summary>
        public string ExternalReferenceId
        {
            get { return this._externalReferenceId; }
            set { this._externalReferenceId = value; }
        }
        
        private string _offerName;
        
        /// <summary>
        /// Optional. name of the offer being delegated.
        /// </summary>
        public string OfferName
        {
            get { return this._offerName; }
            set { this._offerName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DelegatedOfferModel class.
        /// </summary>
        public DelegatedOfferModel()
        {
        }
    }
}
