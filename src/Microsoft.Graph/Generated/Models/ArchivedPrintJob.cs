using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ArchivedPrintJob : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>True if the job was acquired by a printer; false otherwise. Read-only.</summary>
        public bool? AcquiredByPrinter {
            get { return BackingStore?.Get<bool?>(nameof(AcquiredByPrinter)); }
            set { BackingStore?.Set(nameof(AcquiredByPrinter), value); }
        }
        /// <summary>The dateTimeOffset when the job was acquired by the printer, if any. Read-only.</summary>
        public DateTimeOffset? AcquiredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(AcquiredDateTime)); }
            set { BackingStore?.Set(nameof(AcquiredDateTime), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The dateTimeOffset when the job was completed, canceled or aborted. Read-only.</summary>
        public DateTimeOffset? CompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CompletionDateTime)); }
            set { BackingStore?.Set(nameof(CompletionDateTime), value); }
        }
        /// <summary>The number of copies that were printed. Read-only.</summary>
        public int? CopiesPrinted {
            get { return BackingStore?.Get<int?>(nameof(CopiesPrinted)); }
            set { BackingStore?.Set(nameof(CopiesPrinted), value); }
        }
        /// <summary>The user who created the print job. Read-only.</summary>
        public UserIdentity CreatedBy {
            get { return BackingStore?.Get<UserIdentity>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The dateTimeOffset when the job was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The archived print job&apos;s GUID. Read-only.</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>The printer ID that the job was queued for. Read-only.</summary>
        public string PrinterId {
            get { return BackingStore?.Get<string>(nameof(PrinterId)); }
            set { BackingStore?.Set(nameof(PrinterId), value); }
        }
        /// <summary>The print job&apos;s final processing state. Read-only.</summary>
        public PrintJobProcessingState? ProcessingState {
            get { return BackingStore?.Get<PrintJobProcessingState?>(nameof(ProcessingState)); }
            set { BackingStore?.Set(nameof(ProcessingState), value); }
        }
        /// <summary>
        /// Instantiates a new archivedPrintJob and sets the default values.
        /// </summary>
        public ArchivedPrintJob() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ArchivedPrintJob CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ArchivedPrintJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acquiredByPrinter", n => { AcquiredByPrinter = n.GetBoolValue(); } },
                {"acquiredDateTime", n => { AcquiredDateTime = n.GetDateTimeOffsetValue(); } },
                {"completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"copiesPrinted", n => { CopiesPrinted = n.GetIntValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"printerId", n => { PrinterId = n.GetStringValue(); } },
                {"processingState", n => { ProcessingState = n.GetEnumValue<PrintJobProcessingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("acquiredByPrinter", AcquiredByPrinter);
            writer.WriteDateTimeOffsetValue("acquiredDateTime", AcquiredDateTime);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteIntValue("copiesPrinted", CopiesPrinted);
            writer.WriteObjectValue<UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("printerId", PrinterId);
            writer.WriteEnumValue<PrintJobProcessingState>("processingState", ProcessingState);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
