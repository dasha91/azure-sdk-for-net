﻿// 
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

using Hyak.Common;
using System;
using System.Diagnostics;
using System.Reflection;

namespace Microsoft.Azure.Management.HDInsight.Job
{
    public partial class HDInsightJobManagementClient : ServiceClient<HDInsightJobManagementClient>, IHDInsightJobManagementClient
    {
        private static readonly TimeSpan MinBackOff = TimeSpan.FromMinutes(0);
        private static readonly TimeSpan MaxBackOff = TimeSpan.FromMinutes(8);
        private const int RetryCount = 5;
        private static readonly TimeSpan DeltaBackOff = TimeSpan.FromMinutes(1);

        private static string SdkVersion = ".Net " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        /// <summary>
        /// The default poll interval to get job status for the HDInsight Job Management Client.
        /// </summary>
        public static readonly TimeSpan DefaultPollInterval = TimeSpan.FromSeconds(30);
    }
}
