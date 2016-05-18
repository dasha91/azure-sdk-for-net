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

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Database restorable deleted
    /// database.
    /// </summary>
    public partial class DeletedDatabaseBackupProperties
    {
        private DateTime _creationDate;
        
        /// <summary>
        /// Optional. Gets or sets the creation date
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }
        
        private string _databaseName;
        
        /// <summary>
        /// Optional. Gets or sets database name
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }
        
        private DateTime _deletionDate;
        
        /// <summary>
        /// Optional. Gets or sets the deletion date
        /// </summary>
        public DateTime DeletionDate
        {
            get { return this._deletionDate; }
            set { this._deletionDate = value; }
        }
        
        private System.DateTime? _earliestRestoreDate;
        
        /// <summary>
        /// Optional. Gets or sets the earliest restore date
        /// </summary>
        public System.DateTime? EarliestRestoreDate
        {
            get { return this._earliestRestoreDate; }
            set { this._earliestRestoreDate = value; }
        }
        
        private string _edition;
        
        /// <summary>
        /// Optional. Gets or sets edition
        /// </summary>
        public string Edition
        {
            get { return this._edition; }
            set { this._edition = value; }
        }
        
        private string _elasticPoolName;
        
        /// <summary>
        /// Optional. Gets or sets the elastic pool name for the database
        /// </summary>
        public string ElasticPoolName
        {
            get { return this._elasticPoolName; }
            set { this._elasticPoolName = value; }
        }
        
        private long _maxSizeBytes;
        
        /// <summary>
        /// Optional. Gets or sets max size in bytes
        /// </summary>
        public long MaxSizeBytes
        {
            get { return this._maxSizeBytes; }
            set { this._maxSizeBytes = value; }
        }
        
        private string _serviceLevelObjective;
        
        /// <summary>
        /// Optional. Gets or sets the current service level objective name for
        /// the database
        /// </summary>
        public string ServiceLevelObjective
        {
            get { return this._serviceLevelObjective; }
            set { this._serviceLevelObjective = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeletedDatabaseBackupProperties
        /// class.
        /// </summary>
        public DeletedDatabaseBackupProperties()
        {
        }
    }
}
