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
using Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models;

namespace Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models
{
    /// <summary>
    /// A metric setting get response.
    /// </summary>
    public partial class MetricSetting
    {
        private string _namespace;
        
        /// <summary>
        /// Optional. The metric settings namespace. For endpoint monitoring
        /// metrics the namespace value is WindowsAzure.Availability
        /// </summary>
        public string Namespace
        {
            get { return this._namespace; }
            set { this._namespace = value; }
        }
        
        private string _resourceId;
        
        /// <summary>
        /// Required. The resource id of the service.
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }
        
        private MetricSettingValue _value;
        
        /// <summary>
        /// Required. The metric settings value.
        /// </summary>
        public MetricSettingValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MetricSetting class.
        /// </summary>
        public MetricSetting()
        {
        }
    }
}
