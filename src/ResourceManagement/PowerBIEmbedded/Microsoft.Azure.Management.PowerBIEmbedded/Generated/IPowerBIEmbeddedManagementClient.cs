
namespace Microsoft.Azure.Management.PowerBIEmbedded
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Azure Resource Provider for Power BI Embedded
    /// </summary>
    public partial interface IPowerBIEmbeddedManagementClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Gets Azure subscription credentials.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is
        /// generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


            /// <summary>
        /// The Get Power BI Workspace Collection operation retrieves an
        /// existing Power BI Workspace Collection.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='workspaceCollectionName'>
        /// Power BI Embedded workspace collection name
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<WorkspaceCollection>> GetWorkspaceCollectionWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Create Power BI Workspace Collection operation creates a new
        /// Power BI Workspace Collection with the specified properties. A
        /// Power BI Workspace Collection contains one or more Power BI
        /// Workspaces and can be used to provision keys that provide API
        /// access to those Power BI Workspaces.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='workspaceCollectionName'>
        /// Power BI Embedded workspace collection name
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='body'>
        /// Create workspace collection request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<WorkspaceCollection>> CreateWorkspaceCollectionWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, CreateWorkspaceCollectionRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Update Power BI Workspace Collection operation updates an
        /// existing Power BI Workspace Collection with the specified
        /// properties.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='workspaceCollectionName'>
        /// Power BI Embedded workspace collection name
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='body'>
        /// Update workspace collection request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<WorkspaceCollection>> UpdateWorkspaceCollectionWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, UpdateWorkspaceCollectionRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Delete Power BI Workspace Collection operation deletes a Power
        /// BI Workspace Collection.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='workspaceCollectionName'>
        /// Power BI Embedded workspace collection name
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWorkspaceCollectionWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Check Power BI Workspace Collection Name Availability
        /// operation checks that the specified Power BI Workspace Collection
        /// name is valid and not in use.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='location'>
        /// Azure location
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='body'>
        /// Check name availability request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CheckNameResponse>> CheckWorkspaceCollectionAvailabilityWithHttpMessagesAsync(string subscriptionId, string location, string apiVersion, CheckNameRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Get Power BI Workspace Collections operation retrieves all
        /// existing Power BI Workspace Collections in the specified resource
        /// group.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AzureArrayWorkspaceCollection>> GetWorkspacesCollectionsByResourceGroupWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Get Power BI Workspace Collections operation retrieves all
        /// existing Power BI Workspace Collections in the specified
        /// subscription.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AzureArrayWorkspaceCollection>> GetWorkspacesCollectionsBySubscriptionWithHttpMessagesAsync(string subscriptionId, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The List Power BI Workspace Collection Keys operation retrieves
        /// the primary and secondary access keys for the specified Power BI
        /// Workspace Collection.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='workspaceCollectionName'>
        /// Power BI Embedded workspace collection name
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<WorkspaceCollectionAccessKeys>> GetWorkspaceCollectionAccessKeysWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Regenerate Power BI Workspace Collection Key operation
        /// regenerates the primary or secondary access key for the specified
        /// Power BI Workspace Collection.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='workspaceCollectionName'>
        /// Power BI Embedded workspace collection name
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='body'>
        /// Access Key to regenerate
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<WorkspaceCollectionAccessKeys>> RegenerateWorkspaceCollectionAccessKeyWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, WorkspaceCollectionAccessKey body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Get Available Operations operation indicates which operations
        /// can be performed by the Power BI Resource Provider.
        /// </summary>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AzureArrayOperation>> GetAvailableOperationsWithHttpMessagesAsync(string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Get Power BI Workspace Collection Long Running Operation
        /// Status operation indicates the status for a Power BI Workspace
        /// Collection operation (delete, etc.).
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='location'>
        /// Azure location
        /// </param>
        /// <param name='operationId'>
        /// Unique id for the long running operation
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> GetLongRunningOperationStatusWithHttpMessagesAsync(string subscriptionId, string location, string operationId, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Get Power BI Workspaces in Workspace Collection operation
        /// retrieves all existing Power BI Workspaces in the specified
        /// Workspace Collection.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='workspaceCollectionName'>
        /// Power BI Embedded workspace collection name
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<AzureArrayWorkspace>> GetWorkspacesWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The Migrate Power BI Workspace Collection operation moves an
        /// existing Power BI Workspace Collection to a different resource
        /// group and/or subscription.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Azure subscription id
        /// </param>
        /// <param name='resourceGroupName'>
        /// The Azure resource group
        /// </param>
        /// <param name='apiVersion'>
        /// Azure API version
        /// </param>
        /// <param name='body'>
        /// The workspace migration request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> MigrateWorkspaceCollectionWithHttpMessagesAsync(string subscriptionId, string resourceGroupName, string apiVersion, MigrateWorkspaceCollectionRequest body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
