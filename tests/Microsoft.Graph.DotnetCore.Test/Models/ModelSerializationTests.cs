﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Models
{
    using System;
    using Xunit;
    using Microsoft.Graph.Models;
    using Microsoft.Kiota.Abstractions;
    using Microsoft.Kiota.Serialization.Json;
    using System.IO;
    using System.Text;

    public class ModelSerializationTests
    {
        private readonly JsonParseNodeFactory parseNodeFactory;

        public ModelSerializationTests()
        {
            this.parseNodeFactory = new JsonParseNodeFactory();
        }

        [Fact]
        public void DeserializeDerivedType()
        {
            var userId = "userId";
            var givenName = "name";

            var stringToDeserialize = string.Format(
                "{{\"id\":\"{0}\", \"@odata.type\":\"microsoft.graph.user\", \"givenName\":\"{1}\"}}",
                userId,
                givenName);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var user = parseNode.GetObjectValue<User>(User.CreateFromDiscriminatorValue);

            Assert.NotNull(user);
            Assert.Equal(userId, user.Id);
            Assert.Equal(givenName, user.GivenName);
            //Assert.Null(user.GetEtag());
        }

        [Fact]
        public void DeserializeInvalidODataType()
        {
            var directoryObjectId = "directoryObjectId";
            var givenName = "name";

            var stringToDeserialize = string.Format(
                "{{\"id\":\"{0}\", \"@odata.type\":\"invalid\", \"givenName\":\"{1}\"}}",
                directoryObjectId,
                givenName);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var directoryObject = parseNode.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue);

            Assert.NotNull(directoryObject);
            Assert.Equal(directoryObjectId, directoryObject.Id);
            Assert.NotNull(directoryObject.AdditionalData);
            Assert.Equal(givenName, directoryObject.AdditionalData["givenName"].ToString());
        }

        [Fact]
        public void DeserializeUnknownEnumValue()
        {
            var enumValue = "newValue";
            var bodyContent = "bodyContent";

            var stringToDeserialize = string.Format(
                "{{\"contentType\":\"{1}\",\"content\":\"{0}\"}}",
                bodyContent,
                enumValue);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var itemBody = parseNode.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue);

            Assert.NotNull(itemBody);
            Assert.Equal(bodyContent, itemBody.Content);
            Assert.Null(itemBody.ContentType);
            Assert.NotNull(itemBody.AdditionalData);
            Assert.Equal(enumValue, itemBody.AdditionalData["contentType"].ToString());
        }

        [Fact]
        public void DeserializeDateValue()
        {
            var now = DateTimeOffset.UtcNow;

            var stringToDeserialize = string.Format("{{\"startDate\":\"{0}\"}}", now.ToString("yyyy-MM-dd"));

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var recurrenceRange = parseNode.GetObjectValue<RecurrenceRange>(RecurrenceRange.CreateFromDiscriminatorValue);

            Assert.Equal(now.Year, recurrenceRange.StartDate.Value.Year);
            Assert.Equal(now.Month, recurrenceRange.StartDate.Value.Month);
            Assert.Equal(now.Day, recurrenceRange.StartDate.Value.Day);
        }

        [Fact]
        public void NewAbstractEntityDerivedClassInstance()
        {
            var entityId = "entityId";
            var additionalKey = "key";
            var additionalValue = "value";

            var stringToDeserialize = string.Format(
                "{{\"id\":\"{0}\", \"@odata.type\":\"newentity\", \"{1}\":\"{2}\"}}",
                entityId,
                additionalKey,
                additionalValue);

            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(stringToDeserialize));
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, memoryStream);
            var entity = parseNode.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue);

            Assert.NotNull(entity);
            Assert.Equal(entityId, entity.Id);
            Assert.NotNull(entity.AdditionalData);
            Assert.Equal(additionalValue, entity.AdditionalData[additionalKey].ToString());
        }

        [Fact]
        public void SerializeAndDeserializeKnownEnumValue()
        {
            var itemBody = new ItemBody
            {
                OdataType = "microsoft.graph.itemBody",
                Content = "bodyContent",
                ContentType = BodyType.Text,
            };

            var expectedSerializedStream = string.Format(
                "{{\"content\":\"{0}\",\"contentType\":\"{1}\",\"@odata.type\":\"microsoft.graph.itemBody\"}}",
                itemBody.Content,
                "text");

            // Serialize
            using var jsonSerializerWriter = new JsonSerializationWriter();
            jsonSerializerWriter.WriteObjectValue(string.Empty, itemBody);
            var serializedStream = jsonSerializerWriter.GetSerializedContent();

            //Assert
            var streamReader = new StreamReader(serializedStream);
            Assert.Equal(expectedSerializedStream, streamReader.ReadToEnd());

            // De serialize
            serializedStream.Position = 0; //reset the stream to be read again
            var parseNode = this.parseNodeFactory.GetRootParseNode(CoreConstants.MimeTypeNames.Application.Json, serializedStream);
            var newItemBody = parseNode.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue);

            Assert.NotNull(newItemBody);
            Assert.Equal(itemBody.Content, itemBody.Content);
            Assert.Equal(BodyType.Text, itemBody.ContentType);
            Assert.Null(itemBody.AdditionalData);
        }

        [Fact]
        public void SerializeDateValue()
        {
            var now = DateTimeOffset.UtcNow;

            var expectedSerializedString = string.Format("{{\"startDate\":\"{0}\"}}", now.ToString("yyyy-MM-dd"));

            var recurrence = new RecurrenceRange
            {
                StartDate = new Date(now.Year, now.Month, now.Day),
            };

            using var jsonSerializerWriter = new JsonSerializationWriter();
            jsonSerializerWriter.WriteObjectValue(string.Empty, recurrence);
            var serializedStream = jsonSerializerWriter.GetSerializedContent();

            // Assert
            var streamReader = new StreamReader(serializedStream);
            Assert.Equal(expectedSerializedString, streamReader.ReadToEnd());
        }
        /*
        [Fact]
        public void TestEtagHelper()
        {
            var userId = "userId";
            var testEtag = "testEtag";

            var stringToDeserialize = string.Format(
                "{{\"id\":\"{0}\", \"@odata.type\":\"microsoft.graph.user\", \"@odata.etag\":\"{1}\"}}",
                userId,
                testEtag);

            var user = this.serializer.DeserializeObject<Entity>(stringToDeserialize) as User;

            Assert.NotNull(user);
            Assert.Equal(userId, user.Id);
            Assert.Equal(testEtag, user.GetEtag());
        }
        */
    }
}
