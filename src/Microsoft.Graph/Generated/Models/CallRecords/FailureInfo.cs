using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.CallRecords {
    public class FailureInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Classification of why a call or portion of a call failed.</summary>
        public string Reason {
            get { return BackingStore?.Get<string>(nameof(Reason)); }
            set { BackingStore?.Set(nameof(Reason), value); }
        }
        /// <summary>The stage when the failure occurred. Possible values are: unknown, callSetup, midcall, unknownFutureValue.</summary>
        public FailureStage? Stage {
            get { return BackingStore?.Get<FailureStage?>(nameof(Stage)); }
            set { BackingStore?.Set(nameof(Stage), value); }
        }
        /// <summary>
        /// Instantiates a new failureInfo and sets the default values.
        /// </summary>
        public FailureInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static FailureInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FailureInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"stage", n => { Stage = n.GetEnumValue<FailureStage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("reason", Reason);
            writer.WriteEnumValue<FailureStage>("stage", Stage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
