// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Evals
{
    internal partial class InternalEvalCustomDataSourceConfigResource : InternalEvalDataSourceConfigResource
    {
        internal InternalEvalCustomDataSourceConfigResource(IDictionary<string, BinaryData> schema) : base(InternalEvalDataSourceConfigType.Custom)
        {
            // Plugin customization: ensure initialization of collections
            Schema = schema ?? new ChangeTrackingDictionary<string, BinaryData>();
        }

        internal InternalEvalCustomDataSourceConfigResource(InternalEvalDataSourceConfigType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, IDictionary<string, BinaryData> schema) : base(kind, additionalBinaryDataProperties)
        {
            // Plugin customization: ensure initialization of collections
            Schema = schema ?? new ChangeTrackingDictionary<string, BinaryData>();
        }

        public IDictionary<string, BinaryData> Schema { get; }
    }
}
