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
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The properties that are assigned to the cloud service.
    /// </summary>
    public partial class HostedServiceProperties
    {
        private string _affinityGroup;
        
        /// <summary>
        /// Optional. The affinity group with which this cloud service is
        /// associated, if any. If the service is associated with an affinity
        /// group, the Location element is not returned.
        /// </summary>
        public string AffinityGroup
        {
            get { return this._affinityGroup; }
            set { this._affinityGroup = value; }
        }
        
        private DateTime _dateCreated;
        
        /// <summary>
        /// Optional. The date that the cloud service was created, in
        /// [4DigitYear]-[2DigitMonth]-[2DigitDay]T[2DigitHour]:[2DigitMinute]:[2DigitSecond]Z
        /// format. The date 2011-05-11T16:15:26Z is an example that could
        /// bereturned by the DateCreated or DateLastModified elements.
        /// </summary>
        public DateTime DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }
        
        private DateTime _dateLastModified;
        
        /// <summary>
        /// Optional. The date that the cloud service was last updated, in
        /// [4DigitYear]-[2DigitMonth]-[2DigitDay]T[2DigitHour]:[2DigitMinute]:[2DigitSecond]Z
        /// format. The date 2011-05-11T16:15:26Z is an example that could be
        /// returned by the DateCreated or DateLastModified elements.
        /// </summary>
        public DateTime DateLastModified
        {
            get { return this._dateLastModified; }
            set { this._dateLastModified = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. The description for the cloud service.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private IDictionary<string, string> _extendedProperties;
        
        /// <summary>
        /// Optional. Represents the name of an extended cloud service
        /// property. Each extended property must have both a defined name and
        /// value. You can have a maximum of 50 extended property name and
        /// value pairs.  The maximum length of the Name element is 64
        /// characters, only alphanumeric characters and underscores are valid
        /// in the name, and it must start with a letter. Attempting to use
        /// other characters, starting with a non-letter character, or
        /// entering a name that is identical to that of another extended
        /// property owned by the same service, will result in a status code
        /// 400 (Bad Request) error.  Each extended property value has a
        /// maximum length of 255 characters.
        /// </summary>
        public IDictionary<string, string> ExtendedProperties
        {
            get { return this._extendedProperties; }
            set { this._extendedProperties = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// Optional. The user-supplied name of the cloud service. This name
        /// can be used identify the service for your tracking purposes.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. The geo-location of the cloud service in Windows Azure,
        /// if the service is not associated with an affinity group. If a
        /// location has been specified, the AffinityGroup element is not
        /// returned.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private HostedServiceStatus _status;
        
        /// <summary>
        /// Optional. The status of the cloud service.
        /// </summary>
        public HostedServiceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HostedServiceProperties class.
        /// </summary>
        public HostedServiceProperties()
        {
            this._extendedProperties = new Dictionary<string, string>();
        }
    }
}
