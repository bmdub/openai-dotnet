// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalChatCompletionRequestMessageContentPartImageImageUrl
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public ChatImageDetailLevel? Detail { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
