// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Machine Learning compute object. </summary>
    public partial class Compute
    {
        /// <summary> Initializes a new instance of Compute. </summary>
        public Compute()
        {
            ProvisioningErrors = new ChangeTrackingList<ErrorResponse>();
        }

        /// <summary> Initializes a new instance of Compute. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="computeLocation"> Location for the underlying compute. </param>
        /// <param name="provisioningState"> The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed. </param>
        /// <param name="description"> The description of the Machine Learning compute. </param>
        /// <param name="createdOn"> The time at which the compute was created. </param>
        /// <param name="modifiedOn"> The time at which the compute was last modified. </param>
        /// <param name="resourceId"> ARM resource id of the underlying compute. </param>
        /// <param name="provisioningErrors"> Errors during provisioning. </param>
        /// <param name="isAttachedCompute"> Indicating whether the compute was provisioned by user and brought from outside if true, or machine learning service provisioned it if false. </param>
        /// <param name="disableLocalAuth"> Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication. </param>
        internal Compute(ComputeType computeType, string computeLocation, ProvisioningState? provisioningState, string description, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, ResourceIdentifier resourceId, IReadOnlyList<ErrorResponse> provisioningErrors, bool? isAttachedCompute, bool? disableLocalAuth)
        {
            ComputeType = computeType;
            ComputeLocation = computeLocation;
            ProvisioningState = provisioningState;
            Description = description;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            ResourceId = resourceId;
            ProvisioningErrors = provisioningErrors;
            IsAttachedCompute = isAttachedCompute;
            DisableLocalAuth = disableLocalAuth;
        }

        /// <summary> The type of compute. </summary>
        internal ComputeType ComputeType { get; set; }
        /// <summary> Location for the underlying compute. </summary>
        public string ComputeLocation { get; }
        /// <summary> The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The description of the Machine Learning compute. </summary>
        public string Description { get; set; }
        /// <summary> The time at which the compute was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time at which the compute was last modified. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> ARM resource id of the underlying compute. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Errors during provisioning. </summary>
        public IReadOnlyList<ErrorResponse> ProvisioningErrors { get; }
        /// <summary> Indicating whether the compute was provisioned by user and brought from outside if true, or machine learning service provisioned it if false. </summary>
        public bool? IsAttachedCompute { get; }
        /// <summary> Opt-out of local authentication and ensure customers can use only MSI and AAD exclusively for authentication. </summary>
        public bool? DisableLocalAuth { get; set; }
    }
}
