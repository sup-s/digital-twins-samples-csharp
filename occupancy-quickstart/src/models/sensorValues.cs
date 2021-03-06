// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Microsoft.Azure.DigitalTwins.Samples.Models
{
    public class SpaceValue
    {
        public string Type;
        public string Value;
        public string Timestamp;
        public IEnumerable<HistoricalValues> HistoricalValues;
    }
}