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
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// Operation to apply changes from specified Git branch to the
    /// configuration database.
    /// </summary>
    public partial interface ITenantConfigurationOperations
    {
        /// <summary>
        /// Begin deploy operation of configuration from the specified Git
        /// branch to the configuration database in an Api Management
        /// service.To determine whether the operation has finished processing
        /// the request, call GetTenantConfigurationLongRunningOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='parameters'>
        /// Deploy Configuration parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running tenant operations.
        /// </returns>
        Task<TenantLongRunningOperationResponse> BeginDeployAsync(string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begin save operation creates a commit of the current configuration
        /// snapshot to the specified branch in the repository in an Api
        /// Management service.To determine whether the operation has finished
        /// processing the request, call
        /// GetTenantConfigurationLongRunningOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='parameters'>
        /// Save Configuration parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running tenant operations.
        /// </returns>
        Task<TenantLongRunningOperationResponse> BeginSaveAsync(string resourceGroupName, string serviceName, SaveConfigurationParameter parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Begin validate operation of configuration changes in the specified
        /// Git branch of an Api Management service.To determine whether the
        /// operation has finished processing the request, call
        /// GetLongRunningOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='parameters'>
        /// Validate Configuration parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running tenant operations.
        /// </returns>
        Task<TenantLongRunningOperationResponse> BeginValidateAsync(string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deploy Git changes to configuration database in Api Management
        /// service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='parameters'>
        /// Deploy Configuration parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running tenant configuration
        /// operations.
        /// </returns>
        Task<TenantConfigurationLongRunningOperationResponse> DeployAsync(string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running tenant operations.
        /// </returns>
        Task<TenantLongRunningOperationResponse> GetLongRunningOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running tenant configuration
        /// operations.
        /// </returns>
        Task<TenantConfigurationLongRunningOperationResponse> GetTenantConfigurationLongRunningOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Commit configuration snapshot to an Api Management service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='parameters'>
        /// Save Configuration parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running tenant configuration
        /// operations.
        /// </returns>
        Task<TenantConfigurationLongRunningOperationResponse> SaveAsync(string resourceGroupName, string serviceName, SaveConfigurationParameter parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Validate Git changes in an Api Management service.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Api Management service.
        /// </param>
        /// <param name='parameters'>
        /// Validate Configuration parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running tenant configuration
        /// operations.
        /// </returns>
        Task<TenantConfigurationLongRunningOperationResponse> ValidateAsync(string resourceGroupName, string serviceName, DeployConfigurationParameters parameters, CancellationToken cancellationToken);
    }
}
