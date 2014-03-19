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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.WebSitesExtensions;
using Microsoft.WindowsAzure.WebSitesExtensions.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The websites extensions client manages the web sites deployments, web
    /// jobs and other extensions.
    /// </summary>
    public static partial class DeploymentOperationsExtensions
    {
        /// <summary>
        /// Gets a deployment for a website.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='deploymentId'>
        /// Required. The deployment identifier.
        /// </param>
        /// <returns>
        /// The deployment information operation response.
        /// </returns>
        public static DeploymentGetResponse Get(this IDeploymentOperations operations, string deploymentId)
        {
            try
            {
                return operations.GetAsync(deploymentId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Gets a deployment for a website.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='deploymentId'>
        /// Required. The deployment identifier.
        /// </param>
        /// <returns>
        /// The deployment information operation response.
        /// </returns>
        public static Task<DeploymentGetResponse> GetAsync(this IDeploymentOperations operations, string deploymentId)
        {
            return operations.GetAsync(deploymentId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a deployment log for a website.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='deploymentId'>
        /// Required. The deployment identifier.
        /// </param>
        /// <param name='deploymentLogId'>
        /// Required. The deployment log identifier.
        /// </param>
        /// <returns>
        /// The get log for a deployments operation response.
        /// </returns>
        public static DeploymentGetLogResponse GetLog(this IDeploymentOperations operations, string deploymentId, string deploymentLogId)
        {
            try
            {
                return operations.GetLogAsync(deploymentId, deploymentLogId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Gets a deployment log for a website.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='deploymentId'>
        /// Required. The deployment identifier.
        /// </param>
        /// <param name='deploymentLogId'>
        /// Required. The deployment log identifier.
        /// </param>
        /// <returns>
        /// The get log for a deployments operation response.
        /// </returns>
        public static Task<DeploymentGetLogResponse> GetLogAsync(this IDeploymentOperations operations, string deploymentId, string deploymentLogId)
        {
            return operations.GetLogAsync(deploymentId, deploymentLogId, CancellationToken.None);
        }
        
        /// <summary>
        /// List the deployments for a website.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Additional parameters.
        /// </param>
        /// <returns>
        /// The list of deployments operation response.
        /// </returns>
        public static DeploymentListResponse List(this IDeploymentOperations operations, DeploymentListParameters parameters)
        {
            try
            {
                return operations.ListAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// List the deployments for a website.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Additional parameters.
        /// </param>
        /// <returns>
        /// The list of deployments operation response.
        /// </returns>
        public static Task<DeploymentListResponse> ListAsync(this IDeploymentOperations operations, DeploymentListParameters parameters)
        {
            return operations.ListAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// List the logs for a deployment for a website.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='deploymentId'>
        /// Required. The deployment identifier.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Additional parameters.
        /// </param>
        /// <returns>
        /// The list of deployments operation response.
        /// </returns>
        public static DeploymentListLogsResponse ListLogs(this IDeploymentOperations operations, string deploymentId, DeploymentListParameters parameters)
        {
            try
            {
                return operations.ListLogsAsync(deploymentId, parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// List the logs for a deployment for a website.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='deploymentId'>
        /// Required. The deployment identifier.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Additional parameters.
        /// </param>
        /// <returns>
        /// The list of deployments operation response.
        /// </returns>
        public static Task<DeploymentListLogsResponse> ListLogsAsync(this IDeploymentOperations operations, string deploymentId, DeploymentListParameters parameters)
        {
            return operations.ListLogsAsync(deploymentId, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Redeploys a specific website deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='deploymentId'>
        /// Required. The deployment identifier.
        /// </param>
        /// <returns>
        /// The deployment information operation response.
        /// </returns>
        public static DeploymentUpdateResponse Redeploy(this IDeploymentOperations operations, string deploymentId)
        {
            try
            {
                return operations.RedeployAsync(deploymentId).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Redeploys a specific website deployment.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.WebSitesExtensions.IDeploymentOperations.
        /// </param>
        /// <param name='deploymentId'>
        /// Required. The deployment identifier.
        /// </param>
        /// <returns>
        /// The deployment information operation response.
        /// </returns>
        public static Task<DeploymentUpdateResponse> RedeployAsync(this IDeploymentOperations operations, string deploymentId)
        {
            return operations.RedeployAsync(deploymentId, CancellationToken.None);
        }
    }
}
