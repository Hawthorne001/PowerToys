﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.Tracing;
using Microsoft.PowerToys.Telemetry;
using Microsoft.PowerToys.Telemetry.Events;

namespace AdvancedPaste.Telemetry
{
    [EventData]
    public class AdvancedPasteGenerateCustomFormatEvent : EventBase, IEvent
    {
        public int PromptTokens { get; set; }

        public int CompletionTokens { get; set; }

        public string ModelName { get; set; }

        public AdvancedPasteGenerateCustomFormatEvent(int promptTokens, int completionTokens, string modelName)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            ModelName = modelName;
        }

        public PartA_PrivTags PartA_PrivTags => PartA_PrivTags.ProductAndServiceUsage;
    }
}
