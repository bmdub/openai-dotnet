// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalResponsesToolChoiceObjectFunction : InternalResponsesToolChoiceObject
    {
        public InternalResponsesToolChoiceObjectFunction(string name) : base(InternalResponsesToolChoiceObjectType.Function)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        internal InternalResponsesToolChoiceObjectFunction(InternalResponsesToolChoiceObjectType @type, IDictionary<string, BinaryData> additionalBinaryDataProperties, string name) : base(@type, additionalBinaryDataProperties)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
