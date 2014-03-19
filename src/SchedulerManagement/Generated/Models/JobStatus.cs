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

namespace Microsoft.WindowsAzure.Scheduler.Models
{
    /// <summary>
    /// Current status of the job.
    /// </summary>
    public partial class JobStatus
    {
        private int _executionCount;
        
        /// <summary>
        /// Required. Number of times this job has executed.
        /// </summary>
        public int ExecutionCount
        {
            get { return this._executionCount; }
            set { this._executionCount = value; }
        }
        
        private int _failureCount;
        
        /// <summary>
        /// Optional. Number of times this job has failed.
        /// </summary>
        public int FailureCount
        {
            get { return this._failureCount; }
            set { this._failureCount = value; }
        }
        
        private int _faultedCount;
        
        /// <summary>
        /// Optional. Number of faulted occurrences (occurrences that were
        /// retried and failed as many times as the retry policy states).
        /// </summary>
        public int FaultedCount
        {
            get { return this._faultedCount; }
            set { this._faultedCount = value; }
        }
        
        private System.DateTime? _lastExecutionTime;
        
        /// <summary>
        /// Optional. Time the last occurrence executed in ISO-8601 format.
        /// Could be empty if job has not run yet.
        /// </summary>
        public System.DateTime? LastExecutionTime
        {
            get { return this._lastExecutionTime; }
            set { this._lastExecutionTime = value; }
        }
        
        private System.DateTime? _nextExecutionTime;
        
        /// <summary>
        /// Optional. Time of the next occurrence in ISO-8601 format. Could be
        /// empty if the job is completed.
        /// </summary>
        public System.DateTime? NextExecutionTime
        {
            get { return this._nextExecutionTime; }
            set { this._nextExecutionTime = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobStatus class.
        /// </summary>
        public JobStatus()
        {
        }
    }
}
