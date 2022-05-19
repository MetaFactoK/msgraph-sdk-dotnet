using Microsoft.Graph.Models.CallRecords;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Communications.CallRecords.GetDirectRoutingCallsWithFromDateTimeWithToDateTime {
    /// <summary>Provides operations to call the getDirectRoutingCalls method.</summary>
    public class GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The value property</summary>
        public List<DirectRoutingLogRow> Value {
            get { return BackingStore?.Get<List<DirectRoutingLogRow>>(nameof(Value)); }
            set { BackingStore?.Set(nameof(Value), value); }
        }
        /// <summary>
        /// Instantiates a new getDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse and sets the default values.
        /// </summary>
        public GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetDirectRoutingCallsWithFromDateTimeWithToDateTimeResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"value", n => { Value = n.GetCollectionOfObjectValues<DirectRoutingLogRow>(DirectRoutingLogRow.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DirectRoutingLogRow>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
