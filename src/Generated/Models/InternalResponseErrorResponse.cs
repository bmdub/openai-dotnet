// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Responses
{
    internal partial class InternalResponseErrorResponse
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalResponseErrorResponse(ResponseError error)
        {
            Error = error;
        }

        internal InternalResponseErrorResponse(ResponseError error, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Error = error;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public ResponseError Error { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
