﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.CFS.Approvals.Model.Flighting
{
    using Microsoft.Azure.Cosmos.Table;

    public partial class UserDelegationSetting : TableEntity
    {
        public int Id { get; set; }
        public string ManagerAlias { get; set; }
        public string DelegatedToAlias { get; set; }
        public int TenantId { get; set; }
        public System.DateTime DateFrom { get; set; }
        public System.DateTime DateTo { get; set; }
        public int AccessType { get; set; }
        public bool IsHidden { get; set; }
    }
}
