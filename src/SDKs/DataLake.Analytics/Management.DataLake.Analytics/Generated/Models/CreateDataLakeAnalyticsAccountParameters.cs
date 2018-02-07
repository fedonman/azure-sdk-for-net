// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters to use for creating a Data Lake Analytics account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CreateDataLakeAnalyticsAccountParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateDataLakeAnalyticsAccountParameters class.
        /// </summary>
        public CreateDataLakeAnalyticsAccountParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateDataLakeAnalyticsAccountParameters class.
        /// </summary>
        /// <param name="location">The resource location.</param>
        /// <param name="defaultDataLakeStoreAccount">The default Data Lake
        /// Store account associated with this account.</param>
        /// <param name="dataLakeStoreAccounts">The list of Data Lake Store
        /// accounts associated with this account.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="storageAccounts">The list of Azure Blob Storage
        /// accounts associated with this account.</param>
        /// <param name="computePolicies">The list of compute policies
        /// associated with this account.</param>
        /// <param name="firewallRules">The list of firewall rules associated
        /// with this account.</param>
        /// <param name="firewallState">The current state of the IP address
        /// firewall for this account. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="firewallAllowAzureIps">The current state of allowing
        /// or disallowing IPs originating within Azure through the firewall.
        /// If the firewall is disabled, this is not enforced. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="newTier">The commitment tier for the next month.
        /// Possible values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'</param>
        /// <param name="maxJobCount">The maximum supported jobs running under
        /// the account at the same time.</param>
        /// <param name="maxDegreeOfParallelism">The maximum supported degree
        /// of parallelism for this account.</param>
        /// <param name="maxDegreeOfParallelismPerJob">The maximum supported
        /// degree of parallelism per job for this account.</param>
        /// <param name="minPriorityPerJob">The minimum supported priority per
        /// job for this account.</param>
        /// <param name="queryStoreRetention">The number of days that job
        /// metadata is retained.</param>
        public CreateDataLakeAnalyticsAccountParameters(string location, string defaultDataLakeStoreAccount, IList<AddDataLakeStoreWithAccountParameters> dataLakeStoreAccounts, IDictionary<string, string> tags = default(IDictionary<string, string>), IList<AddStorageAccountWithAccountParameters> storageAccounts = default(IList<AddStorageAccountWithAccountParameters>), IList<CreateComputePolicyWithAccountParameters> computePolicies = default(IList<CreateComputePolicyWithAccountParameters>), IList<CreateFirewallRuleWithAccountParameters> firewallRules = default(IList<CreateFirewallRuleWithAccountParameters>), FirewallState? firewallState = default(FirewallState?), FirewallAllowAzureIpsState? firewallAllowAzureIps = default(FirewallAllowAzureIpsState?), TierType? newTier = default(TierType?), int? maxJobCount = default(int?), int? maxDegreeOfParallelism = default(int?), int? maxDegreeOfParallelismPerJob = default(int?), int? minPriorityPerJob = default(int?), int? queryStoreRetention = default(int?))
        {
            Location = location;
            Tags = tags;
            DefaultDataLakeStoreAccount = defaultDataLakeStoreAccount;
            DataLakeStoreAccounts = dataLakeStoreAccounts;
            StorageAccounts = storageAccounts;
            ComputePolicies = computePolicies;
            FirewallRules = firewallRules;
            FirewallState = firewallState;
            FirewallAllowAzureIps = firewallAllowAzureIps;
            NewTier = newTier;
            MaxJobCount = maxJobCount;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            QueryStoreRetention = queryStoreRetention;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the default Data Lake Store account associated with
        /// this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultDataLakeStoreAccount")]
        public string DefaultDataLakeStoreAccount { get; set; }

        /// <summary>
        /// Gets or sets the list of Data Lake Store accounts associated with
        /// this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataLakeStoreAccounts")]
        public IList<AddDataLakeStoreWithAccountParameters> DataLakeStoreAccounts { get; set; }

        /// <summary>
        /// Gets or sets the list of Azure Blob Storage accounts associated
        /// with this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccounts")]
        public IList<AddStorageAccountWithAccountParameters> StorageAccounts { get; set; }

        /// <summary>
        /// Gets or sets the list of compute policies associated with this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computePolicies")]
        public IList<CreateComputePolicyWithAccountParameters> ComputePolicies { get; set; }

        /// <summary>
        /// Gets or sets the list of firewall rules associated with this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallRules")]
        public IList<CreateFirewallRuleWithAccountParameters> FirewallRules { get; set; }

        /// <summary>
        /// Gets or sets the current state of the IP address firewall for this
        /// account. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallState")]
        public FirewallState? FirewallState { get; set; }

        /// <summary>
        /// Gets or sets the current state of allowing or disallowing IPs
        /// originating within Azure through the firewall. If the firewall is
        /// disabled, this is not enforced. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallAllowAzureIps")]
        public FirewallAllowAzureIpsState? FirewallAllowAzureIps { get; set; }

        /// <summary>
        /// Gets or sets the commitment tier for the next month. Possible
        /// values include: 'Consumption', 'Commitment_100AUHours',
        /// 'Commitment_500AUHours', 'Commitment_1000AUHours',
        /// 'Commitment_5000AUHours', 'Commitment_10000AUHours',
        /// 'Commitment_50000AUHours', 'Commitment_100000AUHours',
        /// 'Commitment_500000AUHours'
        /// </summary>
        [JsonProperty(PropertyName = "properties.newTier")]
        public TierType? NewTier { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported jobs running under the account
        /// at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelism")]
        public int? MaxDegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism per job
        /// for this account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelismPerJob")]
        public int? MaxDegreeOfParallelismPerJob { get; set; }

        /// <summary>
        /// Gets or sets the minimum supported priority per job for this
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minPriorityPerJob")]
        public int? MinPriorityPerJob { get; set; }

        /// <summary>
        /// Gets or sets the number of days that job metadata is retained.
        /// </summary>
        [JsonProperty(PropertyName = "properties.queryStoreRetention")]
        public int? QueryStoreRetention { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (DefaultDataLakeStoreAccount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DefaultDataLakeStoreAccount");
            }
            if (DataLakeStoreAccounts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataLakeStoreAccounts");
            }
            if (DataLakeStoreAccounts != null)
            {
                foreach (var element in DataLakeStoreAccounts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (StorageAccounts != null)
            {
                foreach (var element1 in StorageAccounts)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (ComputePolicies != null)
            {
                foreach (var element2 in ComputePolicies)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (FirewallRules != null)
            {
                foreach (var element3 in FirewallRules)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (MaxJobCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxJobCount", 1);
            }
            if (MaxDegreeOfParallelism < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelism", 1);
            }
            if (MaxDegreeOfParallelismPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelismPerJob", 1);
            }
            if (MinPriorityPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinPriorityPerJob", 1);
            }
            if (QueryStoreRetention > 180)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "QueryStoreRetention", 180);
            }
            if (QueryStoreRetention < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "QueryStoreRetention", 1);
            }
        }
    }
}
