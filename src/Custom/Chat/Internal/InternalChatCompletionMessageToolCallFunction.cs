﻿using System;

namespace OpenAI.Chat;

[CodeGenType("ChatCompletionMessageToolCallFunction")]
[CodeGenSerialization(nameof(Arguments), SerializationValueHook = nameof(SerializeArgumentsValue), DeserializationValueHook = nameof(DeserializeArgumentsValue))]
internal partial class InternalChatCompletionMessageToolCallFunction
{
    // CUSTOM: Changed type from string to BinaryData.
    public BinaryData Arguments { get; set; }
}