﻿namespace HuaweiMobileServices.Nearby.Discovery
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    public class BroadcastOption : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public BroadcastOption(AndroidJavaObject javaObject) : base(javaObject) { }
        public Policy Policy => CallAsWrapper<Policy>("getPolicy");
        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.discovery.BroadcastOption$Builder") { }
            public BroadcastOption Build() => CallAsWrapper<BroadcastOption>("build");
            public Builder SetPolicy(Policy policy) => CallAsWrapper<Builder>("setPolicy", policy);
        }
    }
}
