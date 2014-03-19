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

namespace Microsoft.WindowsAzure.Management.ServiceBus.Models
{
    /// <summary>
    /// Statistics about the current usage of a service bus entity.
    /// </summary>
    public partial class CountDetails
    {
        private int _activeMessageCount;
        
        /// <summary>
        /// Optional. The current number of active messages.
        /// </summary>
        public int ActiveMessageCount
        {
            get { return this._activeMessageCount; }
            set { this._activeMessageCount = value; }
        }
        
        private int _deadLetterMessageCount;
        
        /// <summary>
        /// Optional. The current number of dead letters.
        /// </summary>
        public int DeadLetterMessageCount
        {
            get { return this._deadLetterMessageCount; }
            set { this._deadLetterMessageCount = value; }
        }
        
        private int _scheduledMessageCount;
        
        /// <summary>
        /// Optional. The current number of scheduled messages.
        /// </summary>
        public int ScheduledMessageCount
        {
            get { return this._scheduledMessageCount; }
            set { this._scheduledMessageCount = value; }
        }
        
        private int _transferDeadLetterMessageCount;
        
        /// <summary>
        /// Optional. The current number of transfer dead letters.
        /// </summary>
        public int TransferDeadLetterMessageCount
        {
            get { return this._transferDeadLetterMessageCount; }
            set { this._transferDeadLetterMessageCount = value; }
        }
        
        private int _transferMessageCount;
        
        /// <summary>
        /// Optional. The current number of transfer messages.
        /// </summary>
        public int TransferMessageCount
        {
            get { return this._transferMessageCount; }
            set { this._transferMessageCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CountDetails class.
        /// </summary>
        public CountDetails()
        {
        }
    }
}
