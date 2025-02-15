// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Translator.DocumentTranslation
{
    public partial class TranslationSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceUrl");
            writer.WriteStringValue(SourceUri.AbsoluteUri);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter");
                writer.WriteObjectValue(Filter);
            }
            if (Optional.IsDefined(LanguageCode))
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(LanguageCode);
            }
            if (Optional.IsDefined(StorageSource))
            {
                writer.WritePropertyName("storageSource");
                writer.WriteStringValue(StorageSource);
            }
            writer.WriteEndObject();
        }
    }
}
