// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using UnbrandedTypeSpec;

namespace UnbrandedTypeSpec.Models
{
    /// <summary></summary>
    internal partial class AnonymousBodyRequest : IJsonModel<AnonymousBodyRequest>
    {
        internal AnonymousBodyRequest()
        {
        }

        void IJsonModel<AnonymousBodyRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AnonymousBodyRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnonymousBodyRequest)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("requiredUnion"u8);
#if NET6_0_OR_GREATER
            writer.WriteRawValue(RequiredUnion);
#else
            using (JsonDocument document = JsonDocument.Parse(RequiredUnion))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("requiredLiteralString"u8);
            writer.WriteStringValue(RequiredLiteralString.ToString());
            writer.WritePropertyName("requiredLiteralInt"u8);
            writer.WriteNumberValue(RequiredLiteralInt.ToSerialInt32());
            writer.WritePropertyName("requiredLiteralFloat"u8);
            writer.WriteNumberValue(RequiredLiteralFloat.ToSerialSingle());
            writer.WritePropertyName("requiredLiteralBool"u8);
            writer.WriteBooleanValue(RequiredLiteralBool);
            if (Optional.IsDefined(OptionalLiteralString))
            {
                writer.WritePropertyName("optionalLiteralString"u8);
                writer.WriteStringValue(OptionalLiteralString.Value.ToString());
            }
            if (Optional.IsDefined(OptionalLiteralInt))
            {
                writer.WritePropertyName("optionalLiteralInt"u8);
                writer.WriteNumberValue(OptionalLiteralInt.Value.ToSerialInt32());
            }
            if (Optional.IsDefined(OptionalLiteralFloat))
            {
                writer.WritePropertyName("optionalLiteralFloat"u8);
                writer.WriteNumberValue(OptionalLiteralFloat.Value.ToSerialSingle());
            }
            if (Optional.IsDefined(OptionalLiteralBool))
            {
                writer.WritePropertyName("optionalLiteralBool"u8);
                writer.WriteBooleanValue(OptionalLiteralBool.Value);
            }
            writer.WritePropertyName("requiredBadDescription"u8);
            writer.WriteStringValue(RequiredBadDescription);
            if (Optional.IsCollectionDefined(OptionalNullableList))
            {
                if (OptionalNullableList != null)
                {
                    writer.WritePropertyName("optionalNullableList"u8);
                    writer.WriteStartArray();
                    foreach (var item in OptionalNullableList)
                    {
                        writer.WriteNumberValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("optionalNullableList"u8);
                }
            }
            if (RequiredNullableList != null && Optional.IsCollectionDefined(RequiredNullableList))
            {
                writer.WritePropertyName("requiredNullableList"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredNullableList)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("requiredNullableList"u8);
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        AnonymousBodyRequest IJsonModel<AnonymousBodyRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual AnonymousBodyRequest JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AnonymousBodyRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnonymousBodyRequest)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnonymousBodyRequest(document.RootElement, options);
        }

        internal static AnonymousBodyRequest DeserializeAnonymousBodyRequest(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            BinaryData requiredUnion = default;
            AnonymousBodyRequestRequiredLiteralString requiredLiteralString = default;
            AnonymousBodyRequestRequiredLiteralInt requiredLiteralInt = default;
            AnonymousBodyRequestRequiredLiteralFloat requiredLiteralFloat = default;
            bool requiredLiteralBool = default;
            AnonymousBodyRequestOptionalLiteralString? optionalLiteralString = default;
            AnonymousBodyRequestOptionalLiteralInt? optionalLiteralInt = default;
            AnonymousBodyRequestOptionalLiteralFloat? optionalLiteralFloat = default;
            bool? optionalLiteralBool = default;
            string requiredBadDescription = default;
            IList<int> optionalNullableList = default;
            IList<int> requiredNullableList = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("name"u8))
                {
                    name = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("requiredUnion"u8))
                {
                    requiredUnion = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                if (prop.NameEquals("requiredLiteralString"u8))
                {
                    requiredLiteralString = new AnonymousBodyRequestRequiredLiteralString(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("requiredLiteralInt"u8))
                {
                    requiredLiteralInt = new AnonymousBodyRequestRequiredLiteralInt(prop.Value.GetInt32());
                    continue;
                }
                if (prop.NameEquals("requiredLiteralFloat"u8))
                {
                    requiredLiteralFloat = new AnonymousBodyRequestRequiredLiteralFloat(prop.Value.GetSingle());
                    continue;
                }
                if (prop.NameEquals("requiredLiteralBool"u8))
                {
                    requiredLiteralBool = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("optionalLiteralString"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        optionalLiteralString = null;
                        continue;
                    }
                    optionalLiteralString = new AnonymousBodyRequestOptionalLiteralString(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("optionalLiteralInt"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        optionalLiteralInt = null;
                        continue;
                    }
                    optionalLiteralInt = new AnonymousBodyRequestOptionalLiteralInt(prop.Value.GetInt32());
                    continue;
                }
                if (prop.NameEquals("optionalLiteralFloat"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        optionalLiteralFloat = null;
                        continue;
                    }
                    optionalLiteralFloat = new AnonymousBodyRequestOptionalLiteralFloat(prop.Value.GetSingle());
                    continue;
                }
                if (prop.NameEquals("optionalLiteralBool"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        optionalLiteralBool = null;
                        continue;
                    }
                    optionalLiteralBool = prop.Value.GetBoolean();
                    continue;
                }
                if (prop.NameEquals("requiredBadDescription"u8))
                {
                    requiredBadDescription = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("optionalNullableList"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    optionalNullableList = array;
                    continue;
                }
                if (prop.NameEquals("requiredNullableList"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        requiredNullableList = new ChangeTrackingList<int>();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    requiredNullableList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new AnonymousBodyRequest(
                name,
                requiredUnion,
                requiredLiteralString,
                requiredLiteralInt,
                requiredLiteralFloat,
                requiredLiteralBool,
                optionalLiteralString,
                optionalLiteralInt,
                optionalLiteralFloat,
                optionalLiteralBool,
                requiredBadDescription,
                optionalNullableList ?? new ChangeTrackingList<int>(),
                requiredNullableList,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<AnonymousBodyRequest>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AnonymousBodyRequest>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnonymousBodyRequest)} does not support writing '{options.Format}' format.");
            }
        }

        AnonymousBodyRequest IPersistableModel<AnonymousBodyRequest>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual AnonymousBodyRequest PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<AnonymousBodyRequest>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeAnonymousBodyRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnonymousBodyRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnonymousBodyRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="anonymousBodyRequest"> The <see cref="AnonymousBodyRequest"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(AnonymousBodyRequest anonymousBodyRequest)
        {
            return BinaryContent.Create(anonymousBodyRequest, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="AnonymousBodyRequest"/> from. </param>
        public static explicit operator AnonymousBodyRequest(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeAnonymousBodyRequest(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
