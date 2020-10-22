﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.Learn.AppConfig.Tests
{
    // To learn more about TestEnvironment classes, please see: https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/core/Azure.Core.TestFramework/README.md
    public class LearnAppConfigTestEnvironment : TestEnvironment
    {
        // Note we use "api-learn" as the value for the serviceName
        // parameter in the call to the base constructor. This should
        // match the service directory name where your library lives.
        public LearnAppConfigTestEnvironment() : base("api-learn")
        {
        }

        public string Endpoint => GetRecordedVariable("API-LEARN_ENDPOINT");
        public string SettingKey => GetVariable("API-LEARN_SETTING_COLOR_KEY");
        public string SettingValue => GetVariable("API-LEARN_SETTING_COLOR_VALUE");
    }
}
