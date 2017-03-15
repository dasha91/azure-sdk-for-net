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
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// HyperV Replica Azure enable protection input.
    /// </summary>
    public partial class HyperVReplicaAzurePolicyInput : PolicyProviderSpecificInput
    {
        private int _applicationConsistentSnapshotFrequencyInHours;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int ApplicationConsistentSnapshotFrequencyInHours
        {
            get { return this._applicationConsistentSnapshotFrequencyInHours; }
            set { this._applicationConsistentSnapshotFrequencyInHours = value; }
        }
        
        private string _encryption;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }
        
        private System.TimeSpan? _onlineIrStartTime;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public System.TimeSpan? OnlineIrStartTime
        {
            get { return this._onlineIrStartTime; }
            set { this._onlineIrStartTime = value; }
        }
        
        private int _recoveryPointHistoryDuration;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int RecoveryPointHistoryDuration
        {
            get { return this._recoveryPointHistoryDuration; }
            set { this._recoveryPointHistoryDuration = value; }
        }
        
        private int _replicationInterval;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int ReplicationInterval
        {
            get { return this._replicationInterval; }
            set { this._replicationInterval = value; }
        }
        
        private IList<string> _storageAccounts;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> StorageAccounts
        {
            get { return this._storageAccounts; }
            set { this._storageAccounts = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzurePolicyInput
        /// class.
        /// </summary>
        public HyperVReplicaAzurePolicyInput()
        {
            this.StorageAccounts = new LazyList<string>();
        }
    }
}
