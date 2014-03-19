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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// The respoonse to the get supported platform configuration request.
    /// </summary>
    public partial class GatewayListSupportedDevicesResponse : OperationResponse
    {
        private IList<GatewayListSupportedDevicesResponse.Vendor> _vendors;
        
        /// <summary>
        /// Optional. The set of supported vendors.
        /// </summary>
        public IList<GatewayListSupportedDevicesResponse.Vendor> Vendors
        {
            get { return this._vendors; }
            set { this._vendors = value; }
        }
        
        private string _version;
        
        /// <summary>
        /// Optional. The version for this device configuration list.
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// GatewayListSupportedDevicesResponse class.
        /// </summary>
        public GatewayListSupportedDevicesResponse()
        {
            this._vendors = new List<GatewayListSupportedDevicesResponse.Vendor>();
        }
        
        public partial class OSFamily
        {
            private string _name;
            
            /// <summary>
            /// Optional. The name of the os family.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the OSFamily class.
            /// </summary>
            public OSFamily()
            {
            }
        }
        
        /// <summary>
        /// The name and supported OS Families for this vendor on the platform.
        /// </summary>
        public partial class Platform
        {
            private string _name;
            
            /// <summary>
            /// Optional. The platform name.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private IList<GatewayListSupportedDevicesResponse.OSFamily> _oSFamilies;
            
            /// <summary>
            /// Optional. The supported OS Families for this platform.
            /// </summary>
            public IList<GatewayListSupportedDevicesResponse.OSFamily> OSFamilies
            {
                get { return this._oSFamilies; }
                set { this._oSFamilies = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Platform class.
            /// </summary>
            public Platform()
            {
                this._oSFamilies = new List<GatewayListSupportedDevicesResponse.OSFamily>();
            }
        }
        
        /// <summary>
        /// The name and supported platforms for the vendor.
        /// </summary>
        public partial class Vendor
        {
            private string _name;
            
            /// <summary>
            /// Optional. The vendor name.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private IList<GatewayListSupportedDevicesResponse.Platform> _platforms;
            
            /// <summary>
            /// Optional. The supported platforms for the vendor.
            /// </summary>
            public IList<GatewayListSupportedDevicesResponse.Platform> Platforms
            {
                get { return this._platforms; }
                set { this._platforms = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Vendor class.
            /// </summary>
            public Vendor()
            {
                this._platforms = new List<GatewayListSupportedDevicesResponse.Platform>();
            }
        }
    }
}
