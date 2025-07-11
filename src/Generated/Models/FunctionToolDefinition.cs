// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    public partial class FunctionToolDefinition : ToolDefinition
    {
        internal FunctionToolDefinition(InternalAssistantToolDefinitionType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, InternalFunctionDefinition function) : base(kind, additionalBinaryDataProperties)
        {
            Function = function;
        }

        internal InternalFunctionDefinition Function { get; set; }
    }
}
