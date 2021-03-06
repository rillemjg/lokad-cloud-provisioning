﻿#region Copyright (c) Lokad 2010-2011
// This code is released under the terms of the new BSD licence.
// URL: http://www.lokad.com/
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Lokad.Cloud.Provisioning.Info
{
    [DataContract(Namespace = "http://schemas.lokad.com/lokad-cloud/provisioning/1.2"), Serializable]
    public class DeploymentInfo
    {
        [DataMember(IsRequired = true)]
        public string DeploymentName { get; set; }

        [DataMember(IsRequired = true)]
        public string DeploymentLabel { get; set; }

        [DataMember(IsRequired = true)]
        public DeploymentSlot Slot { get; set; }

        [DataMember(IsRequired = true)]
        public string PrivateId { get; set; }

        [DataMember(IsRequired = true)]
        public DeploymentStatus Status { get; set; }

        [DataMember(IsRequired = true)]
        public List<RoleInfo> Roles { get; set; }
    }
}
