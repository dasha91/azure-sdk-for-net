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
using Microsoft.Azure.Management.BackupServices.Models;

namespace Microsoft.Azure.Management.BackupServices.Models
{
    /// <summary>
    /// The definition of a Datasource Info object.
    /// </summary>
    public partial class DataSourceInfo : ManagementResponseObject
    {
        private string _containerName;
        
        /// <summary>
        /// Optional. ContainerName of DataSource.
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }
        
        private string _containerType;
        
        /// <summary>
        /// Optional. ContainerType of DataSource.
        /// </summary>
        public string ContainerType
        {
            get { return this._containerType; }
            set { this._containerType = value; }
        }
        
        private string _friendlyName;
        
        /// <summary>
        /// Optional. FriendlyName of DataSource.
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }
        
        private string _lastBackupJobId;
        
        /// <summary>
        /// Optional. LastBackupJobId of DataSource.
        /// </summary>
        public string LastBackupJobId
        {
            get { return this._lastBackupJobId; }
            set { this._lastBackupJobId = value; }
        }
        
        private string _lastBackupStatus;
        
        /// <summary>
        /// Optional. LastBackupStatus of DataSource.
        /// </summary>
        public string LastBackupStatus
        {
            get { return this._lastBackupStatus; }
            set { this._lastBackupStatus = value; }
        }
        
        private System.DateTime? _lastBackupTime;
        
        /// <summary>
        /// Optional. LastBackupTime of DataSource.
        /// </summary>
        public System.DateTime? LastBackupTime
        {
            get { return this._lastBackupTime; }
            set { this._lastBackupTime = value; }
        }
        
        private System.DateTime? _lastRecoveryPoint;
        
        /// <summary>
        /// Optional. LastRecoveryPoint of DataSource.
        /// </summary>
        public System.DateTime? LastRecoveryPoint
        {
            get { return this._lastRecoveryPoint; }
            set { this._lastRecoveryPoint = value; }
        }
        
        private bool _policyInconsistent;
        
        /// <summary>
        /// Optional. PolicyInconsistent of DataSource.
        /// </summary>
        public bool PolicyInconsistent
        {
            get { return this._policyInconsistent; }
            set { this._policyInconsistent = value; }
        }
        
        private string _protectableObjectName;
        
        /// <summary>
        /// Optional. ProtectableObjectName of DataSource.
        /// </summary>
        public string ProtectableObjectName
        {
            get { return this._protectableObjectName; }
            set { this._protectableObjectName = value; }
        }
        
        private string _protectionPolicyId;
        
        /// <summary>
        /// Optional. ProtectionPolicyId of DataSource.
        /// </summary>
        public string ProtectionPolicyId
        {
            get { return this._protectionPolicyId; }
            set { this._protectionPolicyId = value; }
        }
        
        private string _protectionPolicyName;
        
        /// <summary>
        /// Optional. ProtectionPolicyName of DataSource.
        /// </summary>
        public string ProtectionPolicyName
        {
            get { return this._protectionPolicyName; }
            set { this._protectionPolicyName = value; }
        }
        
        private string _protectionStatus;
        
        /// <summary>
        /// Optional. ProtectionStatus of DataSource.
        /// </summary>
        public string ProtectionStatus
        {
            get { return this._protectionStatus; }
            set { this._protectionStatus = value; }
        }
        
        private int _recoveryPointsCount;
        
        /// <summary>
        /// Optional. RecoveryPointsCount of DataSource.
        /// </summary>
        public int RecoveryPointsCount
        {
            get { return this._recoveryPointsCount; }
            set { this._recoveryPointsCount = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Status of DataSource.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Type of DataSource.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataSourceInfo class.
        /// </summary>
        public DataSourceInfo()
        {
        }
    }
}
