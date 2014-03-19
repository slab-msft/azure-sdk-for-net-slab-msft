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
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// The Get Web Site Publish Profile operation response.
    /// </summary>
    public partial class WebSiteGetPublishProfileResponse : OperationResponse, IEnumerable<WebSiteGetPublishProfileResponse.PublishProfile>
    {
        private IList<WebSiteGetPublishProfileResponse.PublishProfile> _publishProfiles;
        
        /// <summary>
        /// Optional. Contains one or more publish profiles.
        /// </summary>
        public IList<WebSiteGetPublishProfileResponse.PublishProfile> PublishProfiles
        {
            get { return this._publishProfiles; }
            set { this._publishProfiles = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteGetPublishProfileResponse
        /// class.
        /// </summary>
        public WebSiteGetPublishProfileResponse()
        {
            this._publishProfiles = new List<WebSiteGetPublishProfileResponse.PublishProfile>();
        }
        
        /// <summary>
        /// Gets the sequence of PublishProfiles.
        /// </summary>
        public IEnumerator<WebSiteGetPublishProfileResponse.PublishProfile> GetEnumerator()
        {
            return this.PublishProfiles.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of PublishProfiles.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Contains attributes that contain information for a single database
        /// connection.
        /// </summary>
        public partial class Database
        {
            private string _connectionString;
            
            /// <summary>
            /// Optional. Contains a database connection string.
            /// </summary>
            public string ConnectionString
            {
                get { return this._connectionString; }
                set { this._connectionString = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. Contains the friendly name of the connection string.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _providerName;
            
            /// <summary>
            /// Optional. Contains the type of database provider (for example,
            /// "SQL" or "MySQL").
            /// </summary>
            public string ProviderName
            {
                get { return this._providerName; }
                set { this._providerName = value; }
            }
            
            private string _type;
            
            /// <summary>
            /// Optional.
            /// </summary>
            public string Type
            {
                get { return this._type; }
                set { this._type = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Database class.
            /// </summary>
            public Database()
            {
            }
        }
        
        /// <summary>
        /// Contains attributes that hold publish profile values.
        /// </summary>
        public partial class PublishProfile
        {
            private Uri _controlPanelUri;
            
            /// <summary>
            /// Optional. The URL of the control panel for the web site.
            /// </summary>
            public Uri ControlPanelUri
            {
                get { return this._controlPanelUri; }
                set { this._controlPanelUri = value; }
            }
            
            private IList<WebSiteGetPublishProfileResponse.Database> _databases;
            
            /// <summary>
            /// Optional. Contains connection information for the databases
            /// used by the web site application.
            /// </summary>
            public IList<WebSiteGetPublishProfileResponse.Database> Databases
            {
                get { return this._databases; }
                set { this._databases = value; }
            }
            
            private Uri _destinationAppUri;
            
            /// <summary>
            /// Optional. The URL of the website that will be published to.
            /// </summary>
            public Uri DestinationAppUri
            {
                get { return this._destinationAppUri; }
                set { this._destinationAppUri = value; }
            }
            
            private bool _ftpPassiveMode;
            
            /// <summary>
            /// Optional. True or False depending on whether FTP passive mode
            /// is being used. This attribute applies only if publishMethod is
            /// set to FTP.
            /// </summary>
            public bool FtpPassiveMode
            {
                get { return this._ftpPassiveMode; }
                set { this._ftpPassiveMode = value; }
            }
            
            private Uri _hostingProviderForumUri;
            
            /// <summary>
            /// Optional. The URL of the forum of the hosting provider.
            /// </summary>
            public Uri HostingProviderForumUri
            {
                get { return this._hostingProviderForumUri; }
                set { this._hostingProviderForumUri = value; }
            }
            
            private string _mSDeploySite;
            
            /// <summary>
            /// Optional. The name of the site that will be published to. This
            /// attribute applies only if publishMethod is set to MSDeploy.
            /// </summary>
            public string MSDeploySite
            {
                get { return this._mSDeploySite; }
                set { this._mSDeploySite = value; }
            }
            
            private string _mySqlConnectionString;
            
            /// <summary>
            /// Optional. The MySQL database connection string for the web site
            /// application, if the web site connects to a MySQL database.
            /// </summary>
            public string MySqlConnectionString
            {
                get { return this._mySqlConnectionString; }
                set { this._mySqlConnectionString = value; }
            }
            
            private string _profileName;
            
            /// <summary>
            /// Optional. The unique name of the publish profile.
            /// </summary>
            public string ProfileName
            {
                get { return this._profileName; }
                set { this._profileName = value; }
            }
            
            private string _publishMethod;
            
            /// <summary>
            /// Optional. The publish method, such as MSDeploy or FTP.
            /// </summary>
            public string PublishMethod
            {
                get { return this._publishMethod; }
                set { this._publishMethod = value; }
            }
            
            private string _publishUrl;
            
            /// <summary>
            /// Optional. The URL to which content will be uploaded.
            /// </summary>
            public string PublishUrl
            {
                get { return this._publishUrl; }
                set { this._publishUrl = value; }
            }
            
            private string _sqlServerConnectionString;
            
            /// <summary>
            /// Optional. The SQL Server database connection string for the web
            /// site application, if the web site connects to a SQL Server
            /// database.
            /// </summary>
            public string SqlServerConnectionString
            {
                get { return this._sqlServerConnectionString; }
                set { this._sqlServerConnectionString = value; }
            }
            
            private string _userName;
            
            /// <summary>
            /// Optional. The name for the identity that will be used for
            /// publishing.
            /// </summary>
            public string UserName
            {
                get { return this._userName; }
                set { this._userName = value; }
            }
            
            private string _userPassword;
            
            /// <summary>
            /// Optional. Hash value of the password that will be used for
            /// publishing.
            /// </summary>
            public string UserPassword
            {
                get { return this._userPassword; }
                set { this._userPassword = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the PublishProfile class.
            /// </summary>
            public PublishProfile()
            {
                this._databases = new List<WebSiteGetPublishProfileResponse.Database>();
            }
        }
    }
}
