using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the identityProtectionRoot singleton.</summary>
    public class RiskyUserHistoryItem : RiskyUser, IParsable {
        /// <summary>The activity related to user risk level change.</summary>
        public RiskUserActivity Activity {
            get { return BackingStore?.Get<RiskUserActivity>(nameof(Activity)); }
            set { BackingStore?.Set(nameof(Activity), value); }
        }
        /// <summary>The id of actor that does the operation.</summary>
        public string InitiatedBy {
            get { return BackingStore?.Get<string>(nameof(InitiatedBy)); }
            set { BackingStore?.Set(nameof(InitiatedBy), value); }
        }
        /// <summary>The id of the user.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RiskyUserHistoryItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RiskyUserHistoryItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetObjectValue<RiskUserActivity>(RiskUserActivity.CreateFromDiscriminatorValue); } },
                {"initiatedBy", n => { InitiatedBy = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<RiskUserActivity>("activity", Activity);
            writer.WriteStringValue("initiatedBy", InitiatedBy);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
