// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DynaTrace
{
    /// <summary>
    /// A class representing a collection of <see cref="TagRuleResource" /> and their operations.
    /// Each <see cref="TagRuleResource" /> in the collection will belong to the same instance of <see cref="MonitorResource" />.
    /// To get a <see cref="TagRuleCollection" /> instance call the GetTagRules method from an instance of <see cref="MonitorResource" />.
    /// </summary>
    public partial class TagRuleCollection : ArmCollection, IEnumerable<TagRuleResource>, IAsyncEnumerable<TagRuleResource>
    {
        private readonly ClientDiagnostics _tagRuleClientDiagnostics;
        private readonly TagRulesRestOperations _tagRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="TagRuleCollection"/> class for mocking. </summary>
        protected TagRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TagRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TagRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tagRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DynaTrace", TagRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(TagRuleResource.ResourceType, out string tagRuleApiVersion);
            _tagRuleRestClient = new TagRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, tagRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MonitorResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MonitorResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a TagRule
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}
        /// Operation Id: TagRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<TagRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleSetName, TagRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tagRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DynaTraceArmOperation<TagRuleResource>(new TagRuleOperationSource(Client), _tagRuleClientDiagnostics, Pipeline, _tagRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a TagRule
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}
        /// Operation Id: TagRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<TagRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleSetName, TagRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tagRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data, cancellationToken);
                var operation = new DynaTraceArmOperation<TagRuleResource>(new TagRuleOperationSource(Client), _tagRuleClientDiagnostics, Pipeline, _tagRuleRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a TagRule
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}
        /// Operation Id: TagRules_Get
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<TagRuleResource>> GetAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _tagRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a TagRule
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}
        /// Operation Id: TagRules_Get
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<TagRuleResource> Get(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _tagRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TagRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all TagRule by monitorName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules
        /// Operation Id: TagRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TagRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TagRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TagRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tagRuleRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TagRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TagRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tagRuleRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TagRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List all TagRule by monitorName
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules
        /// Operation Id: TagRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TagRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TagRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<TagRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tagRuleRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TagRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TagRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tagRuleRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TagRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}
        /// Operation Id: TagRules_Get
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _tagRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}/tagRules/{ruleSetName}
        /// Operation Id: TagRules_Get
        /// </summary>
        /// <param name="ruleSetName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var scope = _tagRuleClientDiagnostics.CreateScope("TagRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _tagRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TagRuleResource> IEnumerable<TagRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TagRuleResource> IAsyncEnumerable<TagRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
