// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    internal partial class InternalImageGenToolCallItemResource : ResponseItem
    {
        internal InternalImageGenToolCallItemResource(string id, InternalImageGenToolCallItemResourceStatus status, string result) : base(InternalItemType.ImageGenerationCall, id)
        {
            Status = status;
            Result = result;
        }

        internal InternalImageGenToolCallItemResource(InternalItemType kind, string id, IDictionary<string, BinaryData> additionalBinaryDataProperties, InternalImageGenToolCallItemResourceStatus status, string result) : base(kind, id, additionalBinaryDataProperties)
        {
            Status = status;
            Result = result;
        }

        internal InternalImageGenToolCallItemResourceStatus Status { get; }

        public string Result { get; }
    }
}
