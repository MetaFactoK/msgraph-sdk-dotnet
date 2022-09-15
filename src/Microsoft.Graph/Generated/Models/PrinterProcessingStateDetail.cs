namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the collection of agreementAcceptance entities.</summary>
    public enum PrinterProcessingStateDetail {
        Paused,
        MediaJam,
        MediaNeeded,
        MediaLow,
        MediaEmpty,
        CoverOpen,
        InterlockOpen,
        OutputTrayMissing,
        OutputAreaFull,
        MarkerSupplyLow,
        MarkerSupplyEmpty,
        InputTrayMissing,
        OutputAreaAlmostFull,
        MarkerWasteAlmostFull,
        MarkerWasteFull,
        FuserOverTemp,
        FuserUnderTemp,
        Other,
        None,
        MovingToPaused,
        Shutdown,
        ConnectingToDevice,
        TimedOut,
        Stopping,
        StoppedPartially,
        TonerLow,
        TonerEmpty,
        SpoolAreaFull,
        DoorOpen,
        OpticalPhotoConductorNearEndOfLife,
        OpticalPhotoConductorLifeOver,
        DeveloperLow,
        DeveloperEmpty,
        InterpreterResourceUnavailable,
        UnknownFutureValue,
        AlertRemovalOfBinaryChangeEntry,
        BanderAdded,
        BanderAlmostEmpty,
        BanderAlmostFull,
        BanderAtLimit,
        BanderClosed,
        BanderConfigurationChange,
        BanderCoverClosed,
        BanderCoverOpen,
        BanderEmpty,
        BanderFull,
        BanderInterlockClosed,
        BanderInterlockOpen,
        BanderJam,
        BanderLifeAlmostOver,
        BanderLifeOver,
        BanderMemoryExhausted,
        BanderMissing,
        BanderMotorFailure,
        BanderNearLimit,
        BanderOffline,
        BanderOpened,
        BanderOverTemperature,
        BanderPowerSaver,
        BanderRecoverableFailure,
        BanderRecoverableStorage,
        BanderRemoved,
        BanderResourceAdded,
        BanderResourceRemoved,
        BanderThermistorFailure,
        BanderTimingFailure,
        BanderTurnedOff,
        BanderTurnedOn,
        BanderUnderTemperature,
        BanderUnrecoverableFailure,
        BanderUnrecoverableStorageError,
        BanderWarmingUp,
        BinderAdded,
        BinderAlmostEmpty,
        BinderAlmostFull,
        BinderAtLimit,
        BinderClosed,
        BinderConfigurationChange,
        BinderCoverClosed,
        BinderCoverOpen,
        BinderEmpty,
        BinderFull,
        BinderInterlockClosed,
        BinderInterlockOpen,
        BinderJam,
        BinderLifeAlmostOver,
        BinderLifeOver,
        BinderMemoryExhausted,
        BinderMissing,
        BinderMotorFailure,
        BinderNearLimit,
        BinderOffline,
        BinderOpened,
        BinderOverTemperature,
        BinderPowerSaver,
        BinderRecoverableFailure,
        BinderRecoverableStorage,
        BinderRemoved,
        BinderResourceAdded,
        BinderResourceRemoved,
        BinderThermistorFailure,
        BinderTimingFailure,
        BinderTurnedOff,
        BinderTurnedOn,
        BinderUnderTemperature,
        BinderUnrecoverableFailure,
        BinderUnrecoverableStorageError,
        BinderWarmingUp,
        CameraFailure,
        ChamberCooling,
        ChamberFailure,
        ChamberHeating,
        ChamberTemperatureHigh,
        ChamberTemperatureLow,
        CleanerLifeAlmostOver,
        CleanerLifeOver,
        ConfigurationChange,
        Deactivated,
        Deleted,
        DieCutterAdded,
        DieCutterAlmostEmpty,
        DieCutterAlmostFull,
        DieCutterAtLimit,
        DieCutterClosed,
        DieCutterConfigurationChange,
        DieCutterCoverClosed,
        DieCutterCoverOpen,
        DieCutterEmpty,
        DieCutterFull,
        DieCutterInterlockClosed,
        DieCutterInterlockOpen,
        DieCutterJam,
        DieCutterLifeAlmostOver,
        DieCutterLifeOver,
        DieCutterMemoryExhausted,
        DieCutterMissing,
        DieCutterMotorFailure,
        DieCutterNearLimit,
        DieCutterOffline,
        DieCutterOpened,
        DieCutterOverTemperature,
        DieCutterPowerSaver,
        DieCutterRecoverableFailure,
        DieCutterRecoverableStorage,
        DieCutterRemoved,
        DieCutterResourceAdded,
        DieCutterResourceRemoved,
        DieCutterThermistorFailure,
        DieCutterTimingFailure,
        DieCutterTurnedOff,
        DieCutterTurnedOn,
        DieCutterUnderTemperature,
        DieCutterUnrecoverableFailure,
        DieCutterUnrecoverableStorageError,
        DieCutterWarmingUp,
        ExtruderCooling,
        ExtruderFailure,
        ExtruderHeating,
        ExtruderJam,
        ExtruderTemperatureHigh,
        ExtruderTemperatureLow,
        FanFailure,
        FaxModemLifeAlmostOver,
        FaxModemLifeOver,
        FaxModemMissing,
        FaxModemTurnedOff,
        FaxModemTurnedOn,
        FolderAdded,
        FolderAlmostEmpty,
        FolderAlmostFull,
        FolderAtLimit,
        FolderClosed,
        FolderConfigurationChange,
        FolderCoverClosed,
        FolderCoverOpen,
        FolderEmpty,
        FolderFull,
        FolderInterlockClosed,
        FolderInterlockOpen,
        FolderJam,
        FolderLifeAlmostOver,
        FolderLifeOver,
        FolderMemoryExhausted,
        FolderMissing,
        FolderMotorFailure,
        FolderNearLimit,
        FolderOffline,
        FolderOpened,
        FolderOverTemperature,
        FolderPowerSaver,
        FolderRecoverableFailure,
        FolderRecoverableStorage,
        FolderRemoved,
        FolderResourceAdded,
        FolderResourceRemoved,
        FolderThermistorFailure,
        FolderTimingFailure,
        FolderTurnedOff,
        FolderTurnedOn,
        FolderUnderTemperature,
        FolderUnrecoverableFailure,
        FolderUnrecoverableStorageError,
        FolderWarmingUp,
        Hibernate,
        HoldNewJobs,
        IdentifyPrinterRequested,
        ImprinterAdded,
        ImprinterAlmostEmpty,
        ImprinterAlmostFull,
        ImprinterAtLimit,
        ImprinterClosed,
        ImprinterConfigurationChange,
        ImprinterCoverClosed,
        ImprinterCoverOpen,
        ImprinterEmpty,
        ImprinterFull,
        ImprinterInterlockClosed,
        ImprinterInterlockOpen,
        ImprinterJam,
        ImprinterLifeAlmostOver,
        ImprinterLifeOver,
        ImprinterMemoryExhausted,
        ImprinterMissing,
        ImprinterMotorFailure,
        ImprinterNearLimit,
        ImprinterOffline,
        ImprinterOpened,
        ImprinterOverTemperature,
        ImprinterPowerSaver,
        ImprinterRecoverableFailure,
        ImprinterRecoverableStorage,
        ImprinterRemoved,
        ImprinterResourceAdded,
        ImprinterResourceRemoved,
        ImprinterThermistorFailure,
        ImprinterTimingFailure,
        ImprinterTurnedOff,
        ImprinterTurnedOn,
        ImprinterUnderTemperature,
        ImprinterUnrecoverableFailure,
        ImprinterUnrecoverableStorageError,
        ImprinterWarmingUp,
        InputCannotFeedSizeSelected,
        InputManualInputRequest,
        InputMediaColorChange,
        InputMediaFormPartsChange,
        InputMediaSizeChange,
        InputMediaTrayFailure,
        InputMediaTrayFeedError,
        InputMediaTrayJam,
        InputMediaTypeChange,
        InputMediaWeightChange,
        InputPickRollerFailure,
        InputPickRollerLifeOver,
        InputPickRollerLifeWarn,
        InputPickRollerMissing,
        InputTrayElevationFailure,
        InputTrayPositionFailure,
        InserterAdded,
        InserterAlmostEmpty,
        InserterAlmostFull,
        InserterAtLimit,
        InserterClosed,
        InserterConfigurationChange,
        InserterCoverClosed,
        InserterCoverOpen,
        InserterEmpty,
        InserterFull,
        InserterInterlockClosed,
        InserterInterlockOpen,
        InserterJam,
        InserterLifeAlmostOver,
        InserterLifeOver,
        InserterMemoryExhausted,
        InserterMissing,
        InserterMotorFailure,
        InserterNearLimit,
        InserterOffline,
        InserterOpened,
        InserterOverTemperature,
        InserterPowerSaver,
        InserterRecoverableFailure,
        InserterRecoverableStorage,
        InserterRemoved,
        InserterResourceAdded,
        InserterResourceRemoved,
        InserterThermistorFailure,
        InserterTimingFailure,
        InserterTurnedOff,
        InserterTurnedOn,
        InserterUnderTemperature,
        InserterUnrecoverableFailure,
        InserterUnrecoverableStorageError,
        InserterWarmingUp,
        InterlockClosed,
        InterpreterCartridgeAdded,
        InterpreterCartridgeDeleted,
        InterpreterComplexPageEncountered,
        InterpreterMemoryDecrease,
        InterpreterMemoryIncrease,
        InterpreterResourceAdded,
        InterpreterResourceDeleted,
        LampAtEol,
        LampFailure,
        LampNearEol,
        LaserAtEol,
        LaserFailure,
        LaserNearEol,
        MakeEnvelopeAdded,
        MakeEnvelopeAlmostEmpty,
        MakeEnvelopeAlmostFull,
        MakeEnvelopeAtLimit,
        MakeEnvelopeClosed,
        MakeEnvelopeConfigurationChange,
        MakeEnvelopeCoverClosed,
        MakeEnvelopeCoverOpen,
        MakeEnvelopeEmpty,
        MakeEnvelopeFull,
        MakeEnvelopeInterlockClosed,
        MakeEnvelopeInterlockOpen,
        MakeEnvelopeJam,
        MakeEnvelopeLifeAlmostOver,
        MakeEnvelopeLifeOver,
        MakeEnvelopeMemoryExhausted,
        MakeEnvelopeMissing,
        MakeEnvelopeMotorFailure,
        MakeEnvelopeNearLimit,
        MakeEnvelopeOffline,
        MakeEnvelopeOpened,
        MakeEnvelopeOverTemperature,
        MakeEnvelopePowerSaver,
        MakeEnvelopeRecoverableFailure,
        MakeEnvelopeRecoverableStorage,
        MakeEnvelopeRemoved,
        MakeEnvelopeResourceAdded,
        MakeEnvelopeResourceRemoved,
        MakeEnvelopeThermistorFailure,
        MakeEnvelopeTimingFailure,
        MakeEnvelopeTurnedOff,
        MakeEnvelopeTurnedOn,
        MakeEnvelopeUnderTemperature,
        MakeEnvelopeUnrecoverableFailure,
        MakeEnvelopeUnrecoverableStorageError,
        MakeEnvelopeWarmingUp,
        MarkerAdjustingPrintQuality,
        MarkerCleanerMissing,
        MarkerDeveloperAlmostEmpty,
        MarkerDeveloperEmpty,
        MarkerDeveloperMissing,
        MarkerFuserMissing,
        MarkerFuserThermistorFailure,
        MarkerFuserTimingFailure,
        MarkerInkAlmostEmpty,
        MarkerInkEmpty,
        MarkerInkMissing,
        MarkerOpcMissing,
        MarkerPrintRibbonAlmostEmpty,
        MarkerPrintRibbonEmpty,
        MarkerPrintRibbonMissing,
        MarkerSupplyAlmostEmpty,
        MarkerSupplyMissing,
        MarkerTonerCartridgeMissing,
        MarkerTonerMissing,
        MarkerWasteInkReceptacleAlmostFull,
        MarkerWasteInkReceptacleFull,
        MarkerWasteInkReceptacleMissing,
        MarkerWasteMissing,
        MarkerWasteTonerReceptacleAlmostFull,
        MarkerWasteTonerReceptacleFull,
        MarkerWasteTonerReceptacleMissing,
        MaterialEmpty,
        MaterialLow,
        MaterialNeeded,
        MediaDrying,
        MediaPathCannotDuplexMediaSelected,
        MediaPathFailure,
        MediaPathInputEmpty,
        MediaPathInputFeedError,
        MediaPathInputJam,
        MediaPathInputRequest,
        MediaPathJam,
        MediaPathMediaTrayAlmostFull,
        MediaPathMediaTrayFull,
        MediaPathMediaTrayMissing,
        MediaPathOutputFeedError,
        MediaPathOutputFull,
        MediaPathOutputJam,
        MediaPathPickRollerFailure,
        MediaPathPickRollerLifeOver,
        MediaPathPickRollerLifeWarn,
        MediaPathPickRollerMissing,
        MotorFailure,
        OutputMailboxSelectFailure,
        OutputMediaTrayFailure,
        OutputMediaTrayFeedError,
        OutputMediaTrayJam,
        PerforaterAdded,
        PerforaterAlmostEmpty,
        PerforaterAlmostFull,
        PerforaterAtLimit,
        PerforaterClosed,
        PerforaterConfigurationChange,
        PerforaterCoverClosed,
        PerforaterCoverOpen,
        PerforaterEmpty,
        PerforaterFull,
        PerforaterInterlockClosed,
        PerforaterInterlockOpen,
        PerforaterJam,
        PerforaterLifeAlmostOver,
        PerforaterLifeOver,
        PerforaterMemoryExhausted,
        PerforaterMissing,
        PerforaterMotorFailure,
        PerforaterNearLimit,
        PerforaterOffline,
        PerforaterOpened,
        PerforaterOverTemperature,
        PerforaterPowerSaver,
        PerforaterRecoverableFailure,
        PerforaterRecoverableStorage,
        PerforaterRemoved,
        PerforaterResourceAdded,
        PerforaterResourceRemoved,
        PerforaterThermistorFailure,
        PerforaterTimingFailure,
        PerforaterTurnedOff,
        PerforaterTurnedOn,
        PerforaterUnderTemperature,
        PerforaterUnrecoverableFailure,
        PerforaterUnrecoverableStorageError,
        PerforaterWarmingUp,
        PlatformCooling,
        PlatformFailure,
        PlatformHeating,
        PlatformTemperatureHigh,
        PlatformTemperatureLow,
        PowerDown,
        PowerUp,
        PrinterManualReset,
        PrinterNmsReset,
        PrinterReadyToPrint,
        PuncherAdded,
        PuncherAlmostEmpty,
        PuncherAlmostFull,
        PuncherAtLimit,
        PuncherClosed,
        PuncherConfigurationChange,
        PuncherCoverClosed,
        PuncherCoverOpen,
        PuncherEmpty,
        PuncherFull,
        PuncherInterlockClosed,
        PuncherInterlockOpen,
        PuncherJam,
        PuncherLifeAlmostOver,
        PuncherLifeOver,
        PuncherMemoryExhausted,
        PuncherMissing,
        PuncherMotorFailure,
        PuncherNearLimit,
        PuncherOffline,
        PuncherOpened,
        PuncherOverTemperature,
        PuncherPowerSaver,
        PuncherRecoverableFailure,
        PuncherRecoverableStorage,
        PuncherRemoved,
        PuncherResourceAdded,
        PuncherResourceRemoved,
        PuncherThermistorFailure,
        PuncherTimingFailure,
        PuncherTurnedOff,
        PuncherTurnedOn,
        PuncherUnderTemperature,
        PuncherUnrecoverableFailure,
        PuncherUnrecoverableStorageError,
        PuncherWarmingUp,
        Resuming,
        ScanMediaPathFailure,
        ScanMediaPathInputEmpty,
        ScanMediaPathInputFeedError,
        ScanMediaPathInputJam,
        ScanMediaPathInputRequest,
        ScanMediaPathJam,
        ScanMediaPathOutputFeedError,
        ScanMediaPathOutputFull,
        ScanMediaPathOutputJam,
        ScanMediaPathPickRollerFailure,
        ScanMediaPathPickRollerLifeOver,
        ScanMediaPathPickRollerLifeWarn,
        ScanMediaPathPickRollerMissing,
        ScanMediaPathTrayAlmostFull,
        ScanMediaPathTrayFull,
        ScanMediaPathTrayMissing,
        ScannerLightFailure,
        ScannerLightLifeAlmostOver,
        ScannerLightLifeOver,
        ScannerLightMissing,
        ScannerSensorFailure,
        ScannerSensorLifeAlmostOver,
        ScannerSensorLifeOver,
        ScannerSensorMissing,
        SeparationCutterAdded,
        SeparationCutterAlmostEmpty,
        SeparationCutterAlmostFull,
        SeparationCutterAtLimit,
        SeparationCutterClosed,
        SeparationCutterConfigurationChange,
        SeparationCutterCoverClosed,
        SeparationCutterCoverOpen,
        SeparationCutterEmpty,
        SeparationCutterFull,
        SeparationCutterInterlockClosed,
        SeparationCutterInterlockOpen,
        SeparationCutterJam,
        SeparationCutterLifeAlmostOver,
        SeparationCutterLifeOver,
        SeparationCutterMemoryExhausted,
        SeparationCutterMissing,
        SeparationCutterMotorFailure,
        SeparationCutterNearLimit,
        SeparationCutterOffline,
        SeparationCutterOpened,
        SeparationCutterOverTemperature,
        SeparationCutterPowerSaver,
        SeparationCutterRecoverableFailure,
        SeparationCutterRecoverableStorage,
        SeparationCutterRemoved,
        SeparationCutterResourceAdded,
        SeparationCutterResourceRemoved,
        SeparationCutterThermistorFailure,
        SeparationCutterTimingFailure,
        SeparationCutterTurnedOff,
        SeparationCutterTurnedOn,
        SeparationCutterUnderTemperature,
        SeparationCutterUnrecoverableFailure,
        SeparationCutterUnrecoverableStorageError,
        SeparationCutterWarmingUp,
        SheetRotatorAdded,
        SheetRotatorAlmostEmpty,
        SheetRotatorAlmostFull,
        SheetRotatorAtLimit,
        SheetRotatorClosed,
        SheetRotatorConfigurationChange,
        SheetRotatorCoverClosed,
        SheetRotatorCoverOpen,
        SheetRotatorEmpty,
        SheetRotatorFull,
        SheetRotatorInterlockClosed,
        SheetRotatorInterlockOpen,
        SheetRotatorJam,
        SheetRotatorLifeAlmostOver,
        SheetRotatorLifeOver,
        SheetRotatorMemoryExhausted,
        SheetRotatorMissing,
        SheetRotatorMotorFailure,
        SheetRotatorNearLimit,
        SheetRotatorOffline,
        SheetRotatorOpened,
        SheetRotatorOverTemperature,
        SheetRotatorPowerSaver,
        SheetRotatorRecoverableFailure,
        SheetRotatorRecoverableStorage,
        SheetRotatorRemoved,
        SheetRotatorResourceAdded,
        SheetRotatorResourceRemoved,
        SheetRotatorThermistorFailure,
        SheetRotatorTimingFailure,
        SheetRotatorTurnedOff,
        SheetRotatorTurnedOn,
        SheetRotatorUnderTemperature,
        SheetRotatorUnrecoverableFailure,
        SheetRotatorUnrecoverableStorageError,
        SheetRotatorWarmingUp,
        SlitterAdded,
        SlitterAlmostEmpty,
        SlitterAlmostFull,
        SlitterAtLimit,
        SlitterClosed,
        SlitterConfigurationChange,
        SlitterCoverClosed,
        SlitterCoverOpen,
        SlitterEmpty,
        SlitterFull,
        SlitterInterlockClosed,
        SlitterInterlockOpen,
        SlitterJam,
        SlitterLifeAlmostOver,
        SlitterLifeOver,
        SlitterMemoryExhausted,
        SlitterMissing,
        SlitterMotorFailure,
        SlitterNearLimit,
        SlitterOffline,
        SlitterOpened,
        SlitterOverTemperature,
        SlitterPowerSaver,
        SlitterRecoverableFailure,
        SlitterRecoverableStorage,
        SlitterRemoved,
        SlitterResourceAdded,
        SlitterResourceRemoved,
        SlitterThermistorFailure,
        SlitterTimingFailure,
        SlitterTurnedOff,
        SlitterTurnedOn,
        SlitterUnderTemperature,
        SlitterUnrecoverableFailure,
        SlitterUnrecoverableStorageError,
        SlitterWarmingUp,
        StackerAdded,
        StackerAlmostEmpty,
        StackerAlmostFull,
        StackerAtLimit,
        StackerClosed,
        StackerConfigurationChange,
        StackerCoverClosed,
        StackerCoverOpen,
        StackerEmpty,
        StackerFull,
        StackerInterlockClosed,
        StackerInterlockOpen,
        StackerJam,
        StackerLifeAlmostOver,
        StackerLifeOver,
        StackerMemoryExhausted,
        StackerMissing,
        StackerMotorFailure,
        StackerNearLimit,
        StackerOffline,
        StackerOpened,
        StackerOverTemperature,
        StackerPowerSaver,
        StackerRecoverableFailure,
        StackerRecoverableStorage,
        StackerRemoved,
        StackerResourceAdded,
        StackerResourceRemoved,
        StackerThermistorFailure,
        StackerTimingFailure,
        StackerTurnedOff,
        StackerTurnedOn,
        StackerUnderTemperature,
        StackerUnrecoverableFailure,
        StackerUnrecoverableStorageError,
        StackerWarmingUp,
        Standby,
        StaplerAdded,
        StaplerAlmostEmpty,
        StaplerAlmostFull,
        StaplerAtLimit,
        StaplerClosed,
        StaplerConfigurationChange,
        StaplerCoverClosed,
        StaplerCoverOpen,
        StaplerEmpty,
        StaplerFull,
        StaplerInterlockClosed,
        StaplerInterlockOpen,
        StaplerJam,
        StaplerLifeAlmostOver,
        StaplerLifeOver,
        StaplerMemoryExhausted,
        StaplerMissing,
        StaplerMotorFailure,
        StaplerNearLimit,
        StaplerOffline,
        StaplerOpened,
        StaplerOverTemperature,
        StaplerPowerSaver,
        StaplerRecoverableFailure,
        StaplerRecoverableStorage,
        StaplerRemoved,
        StaplerResourceAdded,
        StaplerResourceRemoved,
        StaplerThermistorFailure,
        StaplerTimingFailure,
        StaplerTurnedOff,
        StaplerTurnedOn,
        StaplerUnderTemperature,
        StaplerUnrecoverableFailure,
        StaplerUnrecoverableStorageError,
        StaplerWarmingUp,
        StitcherAdded,
        StitcherAlmostEmpty,
        StitcherAlmostFull,
        StitcherAtLimit,
        StitcherClosed,
        StitcherConfigurationChange,
        StitcherCoverClosed,
        StitcherCoverOpen,
        StitcherEmpty,
        StitcherFull,
        StitcherInterlockClosed,
        StitcherInterlockOpen,
        StitcherJam,
        StitcherLifeAlmostOver,
        StitcherLifeOver,
        StitcherMemoryExhausted,
        StitcherMissing,
        StitcherMotorFailure,
        StitcherNearLimit,
        StitcherOffline,
        StitcherOpened,
        StitcherOverTemperature,
        StitcherPowerSaver,
        StitcherRecoverableFailure,
        StitcherRecoverableStorage,
        StitcherRemoved,
        StitcherResourceAdded,
        StitcherResourceRemoved,
        StitcherThermistorFailure,
        StitcherTimingFailure,
        StitcherTurnedOff,
        StitcherTurnedOn,
        StitcherUnderTemperature,
        StitcherUnrecoverableFailure,
        StitcherUnrecoverableStorageError,
        StitcherWarmingUp,
        SubunitAdded,
        SubunitAlmostEmpty,
        SubunitAlmostFull,
        SubunitAtLimit,
        SubunitClosed,
        SubunitCoolingDown,
        SubunitEmpty,
        SubunitFull,
        SubunitLifeAlmostOver,
        SubunitLifeOver,
        SubunitMemoryExhausted,
        SubunitMissing,
        SubunitMotorFailure,
        SubunitNearLimit,
        SubunitOffline,
        SubunitOpened,
        SubunitOverTemperature,
        SubunitPowerSaver,
        SubunitRecoverableFailure,
        SubunitRecoverableStorage,
        SubunitRemoved,
        SubunitResourceAdded,
        SubunitResourceRemoved,
        SubunitThermistorFailure,
        SubunitTimingFailure,
        SubunitTurnedOff,
        SubunitTurnedOn,
        SubunitUnderTemperature,
        SubunitUnrecoverableFailure,
        SubunitUnrecoverableStorage,
        SubunitWarmingUp,
        Suspend,
        Testing,
        TrimmerAdded,
        TrimmerAlmostEmpty,
        TrimmerAlmostFull,
        TrimmerAtLimit,
        TrimmerClosed,
        TrimmerConfigurationChange,
        TrimmerCoverClosed,
        TrimmerCoverOpen,
        TrimmerEmpty,
        TrimmerFull,
        TrimmerInterlockClosed,
        TrimmerInterlockOpen,
        TrimmerJam,
        TrimmerLifeAlmostOver,
        TrimmerLifeOver,
        TrimmerMemoryExhausted,
        TrimmerMissing,
        TrimmerMotorFailure,
        TrimmerNearLimit,
        TrimmerOffline,
        TrimmerOpened,
        TrimmerOverTemperature,
        TrimmerPowerSaver,
        TrimmerRecoverableFailure,
        TrimmerRecoverableStorage,
        TrimmerRemoved,
        TrimmerResourceAdded,
        TrimmerResourceRemoved,
        TrimmerThermistorFailure,
        TrimmerTimingFailure,
        TrimmerTurnedOff,
        TrimmerTurnedOn,
        TrimmerUnderTemperature,
        TrimmerUnrecoverableFailure,
        TrimmerUnrecoverableStorageError,
        TrimmerWarmingUp,
        Unknown,
        WrapperAdded,
        WrapperAlmostEmpty,
        WrapperAlmostFull,
        WrapperAtLimit,
        WrapperClosed,
        WrapperConfigurationChange,
        WrapperCoverClosed,
        WrapperCoverOpen,
        WrapperEmpty,
        WrapperFull,
        WrapperInterlockClosed,
        WrapperInterlockOpen,
        WrapperJam,
        WrapperLifeAlmostOver,
        WrapperLifeOver,
        WrapperMemoryExhausted,
        WrapperMissing,
        WrapperMotorFailure,
        WrapperNearLimit,
        WrapperOffline,
        WrapperOpened,
        WrapperOverTemperature,
        WrapperPowerSaver,
        WrapperRecoverableFailure,
        WrapperRecoverableStorage,
        WrapperRemoved,
        WrapperResourceAdded,
        WrapperResourceRemoved,
        WrapperThermistorFailure,
        WrapperTimingFailure,
        WrapperTurnedOff,
        WrapperTurnedOn,
        WrapperUnderTemperature,
        WrapperUnrecoverableFailure,
        WrapperUnrecoverableStorageError,
        WrapperWarmingUp,
    }
}
