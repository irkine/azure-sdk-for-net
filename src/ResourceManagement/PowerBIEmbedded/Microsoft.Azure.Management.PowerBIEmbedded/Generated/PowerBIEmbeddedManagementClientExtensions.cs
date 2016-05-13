
namespace Microsoft.Azure.Management.PowerBIEmbedded
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for PowerBIEmbeddedManagementClient.
    /// </summary>
    public static partial class PowerBIEmbeddedManagementClientExtensions
    {
            /// <summary>
            /// The **Get Power BI Workspace Collection** operation retrieves an existing
            /// Power BI Workspace Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            public static WorkspaceCollection GetWorkspaceCollection(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).GetWorkspaceCollectionAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Get Power BI Workspace Collection** operation retrieves an existing
            /// Power BI Workspace Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceCollection> GetWorkspaceCollectionAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkspaceCollectionWithHttpMessagesAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Create Power BI Workspace Collection** operation creates a new Power
            /// BI Workspace Collection with the specified properties. A Power BI
            /// Workspace Collection contains one or more Power BI Workspaces and can be
            /// used to provision keys that provide API access to those Power BI
            /// Workspaces.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
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
            public static WorkspaceCollection CreateWorkspaceCollection(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, CreateWorkspaceCollectionRequest body)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).CreateWorkspaceCollectionAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Create Power BI Workspace Collection** operation creates a new Power
            /// BI Workspace Collection with the specified properties. A Power BI
            /// Workspace Collection contains one or more Power BI Workspaces and can be
            /// used to provision keys that provide API access to those Power BI
            /// Workspaces.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceCollection> CreateWorkspaceCollectionAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, CreateWorkspaceCollectionRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWorkspaceCollectionWithHttpMessagesAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Update Power BI Workspace Collection** operation updates an existing
            /// Power BI Workspace Collection with the specified properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
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
            public static WorkspaceCollection UpdateWorkspaceCollection(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, UpdateWorkspaceCollectionRequest body)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).UpdateWorkspaceCollectionAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Update Power BI Workspace Collection** operation updates an existing
            /// Power BI Workspace Collection with the specified properties.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceCollection> UpdateWorkspaceCollectionAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, UpdateWorkspaceCollectionRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWorkspaceCollectionWithHttpMessagesAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Delete Power BI Workspace Collection** operation deletes a Power BI
            /// Workspace Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            public static void DeleteWorkspaceCollection(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion)
            {
                Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).DeleteWorkspaceCollectionAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Delete Power BI Workspace Collection** operation deletes a Power BI
            /// Workspace Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteWorkspaceCollectionAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWorkspaceCollectionWithHttpMessagesAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The **Check Power BI Workspace Collection Name Availability** operation
            /// checks that the specified Power BI Workspace Collection name is valid and
            /// not in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static CheckNameResponse CheckNameAvailability(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string location, string apiVersion, CheckNameRequest body)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).CheckNameAvailabilityAsync(subscriptionId, location, apiVersion, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Check Power BI Workspace Collection Name Availability** operation
            /// checks that the specified Power BI Workspace Collection name is valid and
            /// not in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameResponse> CheckNameAvailabilityAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string location, string apiVersion, CheckNameRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(subscriptionId, location, apiVersion, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Get Power BI Workspace Collections in Resource Group** operation
            /// retrieves all existing Power BI Workspace Collections in the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            public static WorkspaceCollectionList GetWorkspacesCollectionsInResourceGroup(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string apiVersion)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).GetWorkspacesCollectionsInResourceGroupAsync(subscriptionId, resourceGroupName, apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Get Power BI Workspace Collections in Resource Group** operation
            /// retrieves all existing Power BI Workspace Collections in the specified
            /// resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceCollectionList> GetWorkspacesCollectionsInResourceGroupAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkspacesCollectionsInResourceGroupWithHttpMessagesAsync(subscriptionId, resourceGroupName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Get Power BI Workspace Collections in Subscription** operation
            /// retrieves all existing Power BI Workspace Collections in the specified
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            public static WorkspaceCollectionList GetWorkspacesCollectionsInSubscription(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string apiVersion)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).GetWorkspacesCollectionsInSubscriptionAsync(subscriptionId, apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Get Power BI Workspace Collections in Subscription** operation
            /// retrieves all existing Power BI Workspace Collections in the specified
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceCollectionList> GetWorkspacesCollectionsInSubscriptionAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkspacesCollectionsInSubscriptionWithHttpMessagesAsync(subscriptionId, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **List Power BI Workspace Collection Keys** operation retrieves the
            /// primary and secondary access keys for the specified Power BI Workspace
            /// Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            public static WorkspaceCollectionAccessKeys GetWorkspaceCollectionAccessKeys(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).GetWorkspaceCollectionAccessKeysAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **List Power BI Workspace Collection Keys** operation retrieves the
            /// primary and secondary access keys for the specified Power BI Workspace
            /// Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceCollectionAccessKeys> GetWorkspaceCollectionAccessKeysAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkspaceCollectionAccessKeysWithHttpMessagesAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Regenerate Power BI Workspace Collection Key** operation regenerates
            /// the primary or secondary access key for the specified Power BI Workspace
            /// Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='body'>
            /// Access key to regenerate
            /// </param>
            public static WorkspaceCollectionAccessKeys RegenerateWorkspaceCollectionAccessKey(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, WorkspaceCollectionAccessKey body)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).RegenerateWorkspaceCollectionAccessKeyAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Regenerate Power BI Workspace Collection Key** operation regenerates
            /// the primary or secondary access key for the specified Power BI Workspace
            /// Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='body'>
            /// Access key to regenerate
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceCollectionAccessKeys> RegenerateWorkspaceCollectionAccessKeyAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, WorkspaceCollectionAccessKey body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateWorkspaceCollectionAccessKeyWithHttpMessagesAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Get Available Operations** operation indicates which operations can
            /// be performed by the Power BI Resource Provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            public static OperationList GetAvailableOperations(this IPowerBIEmbeddedManagementClient operations, string apiVersion)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).GetAvailableOperationsAsync(apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Get Available Operations** operation indicates which operations can
            /// be performed by the Power BI Resource Provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationList> GetAvailableOperationsAsync(this IPowerBIEmbeddedManagementClient operations, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAvailableOperationsWithHttpMessagesAsync(apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Get Power BI Workspace Collection Long Running Operation Status**
            /// operation indicates the status for a Power BI Workspace Collection
            /// operation (delete, etc.).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static void GetLongRunningOperationStatus(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string location, string operationId, string apiVersion)
            {
                Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).GetLongRunningOperationStatusAsync(subscriptionId, location, operationId, apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Get Power BI Workspace Collection Long Running Operation Status**
            /// operation indicates the status for a Power BI Workspace Collection
            /// operation (delete, etc.).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetLongRunningOperationStatusAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string location, string operationId, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetLongRunningOperationStatusWithHttpMessagesAsync(subscriptionId, location, operationId, apiVersion, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// The **Get Power BI Workspaces in Workspace Collection** operation
            /// retrieves all existing Power BI Workspaces in the specified Workspace
            /// Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            public static WorkspaceList GetWorkspaces(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion)
            {
                return Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).GetWorkspacesAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Get Power BI Workspaces in Workspace Collection** operation
            /// retrieves all existing Power BI Workspaces in the specified Workspace
            /// Collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='workspaceCollectionName'>
            /// Power BI Embedded workspace collection name
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WorkspaceList> GetWorkspacesAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string workspaceCollectionName, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWorkspacesWithHttpMessagesAsync(subscriptionId, resourceGroupName, workspaceCollectionName, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The **Migrate Power BI Workspace Collection** operation moves an existing
            /// Power BI Workspace Collection to a different resource group and/or
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='body'>
            /// Workspace migration request
            /// </param>
            public static void MigrateWorkspaceCollection(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string apiVersion, MigrateWorkspaceCollectionRequest body)
            {
                Task.Factory.StartNew(s => ((IPowerBIEmbeddedManagementClient)s).MigrateWorkspaceCollectionAsync(subscriptionId, resourceGroupName, apiVersion, body), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// The **Migrate Power BI Workspace Collection** operation moves an existing
            /// Power BI Workspace Collection to a different resource group and/or
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure resource group
            /// </param>
            /// <param name='apiVersion'>
            /// Azure API version
            /// </param>
            /// <param name='body'>
            /// Workspace migration request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task MigrateWorkspaceCollectionAsync(this IPowerBIEmbeddedManagementClient operations, string subscriptionId, string resourceGroupName, string apiVersion, MigrateWorkspaceCollectionRequest body, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.MigrateWorkspaceCollectionWithHttpMessagesAsync(subscriptionId, resourceGroupName, apiVersion, body, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
