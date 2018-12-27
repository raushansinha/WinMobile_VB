
Namespace NWA.Safetrac.Scanner.BO

    Public Enum ReturnCodes
        
#Region "BINBULK CODES"
        BinBulkValid
        BinBulkInvalid = 7
#End Region

#Region "BAGTAG CODES"
        BagtagOnAlert = 30
        BagtagAlreadyOnAlert
        BagtagNotOnAlert
        BagtagOnNoLoad
        BagtagAlreadyLoaded
        BagtagUnloaded
        BagtagLoaded
        BagtagInvalidForFlight
        BagtagUnknown
        BagtagValid
        BagtagInvalid
        BagtagDuplicatesFound = 28
#End Region

#Region "CONTAINER CODES"
        ContainerLoaded
        ContainerNumValid
        ContainerNameValid
        ContainerNumInvalid
        ContainerNameInvalid
        ContainerNumFormatInvalid
        ContainerNameFormatInvalid
        ContainerAlreadyClosed
        ContainerAlreadyOpened
        ContainerClosed = 51
        ContainerReopened
        ContainerNumAlreadyRegistered
        ContainerNameAlreadyRegistered
        ContainerRegistrationFailed
        ContainerRegistered
        ContainerDeregistered
        ContainerNumCreated
        ContainerNumCreationError
        ContainerTypeChanged
        ContainerDestinationChanged
        ContainerDefinitionChanged
        ContainerAlreadyLoaded
        ContainerMoved
        ContainerPositioned
        ContainerPositionInvalid
        ContainerPositionInUse
        ContainerPositionCleared
        ContainerNotRegistered
#End Region

#Region "FLIGHT CODES"
        FlightAdded
        FlightModified
        FlightRemoved
        FlightAlreadyExists
        FlightInvalid = 48
        FlightDateInvalid = 49
        FlightDepartureUnknown = 4
        FlightDestinationUnknown
        FlightDestinationInvalid
        FlightDeparted = 8
        FlightClosed = 50
        FlightMismatch
        FlightNoMoreLoads
#End Region

#Region "MAIL CODES"
        MailNotFound
        MailOffloaded
        MailAlreadyRegistered
#End Region

#Region "FREIGHT CODES"
        FreightUnloaded
        FreightNotLoaded
        FreightLoaded
        FreightExpedited
        FreightAlreadyLoaded
#End Region

#Region "MISCELLANEOUS CODES"
        PBMEnabled
        PBMDisabled
        IsBatchTypeStation
        IsHubTypeStation
        IsInternational
        IsWideBody
        IsNarrowBody
        FlightAddError
        NotInNetwork
        Success
        Failed
        PassengerNotCheckedIn
        PassengerOnStandBy
        NotAuthorized
        Ok = 1
        NotOk = 0
        DatabaseError
        DestinationInvalid
        FinalDestinationInvalid
        ZipCodeInvalid
        Relabel
        Overrulable
        Unknown
        LogonInvalid
        HHTNotInPack
        HHTNotAssigned
        HHTInvalid
        NotConfiguredFlight
        CartsNotAllowed
        WFCodeAccepted
        Exception
        FrontEndError
        MaxBagsExceeded
        HAgentUnknown
#End Region

        'NoData = 43
        'Standby = 35
        'NotCheckedIn = 36
        'TrackingError = 37
        'SecurityError = 38
        'NoLoad = 39
        'ULDDereg = 31
        'OverrideFail = 32
        'NoLoading = 27
        'BagtagInvalidGeneral = 16
        'BagtagInvalidTooShort = 17
        'BagtagInvalidTooLong = 18
        'BagtagInvalidAlpha = 19
        'BagtagInvalidBin = 20
        'BagtagInvalidBulk = 21
        'BagtagInvalidNoSwitch = 21
        'ContainerInvalidGeneral = 22
        'ContainerInvalidTooShort = 23
        'NoMoreLoads = 9
        'CustomOkLoad = 10
        'LoadError = 11
        'ULDLoadError = 12
        'OKLoadViolation = 13
        'ReEnterBin = 14

    End Enum
    
    ''' <summary>
    ''' Types of Containers
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ContainerTypes
        ''' <summary>
        ''' Aircraft on ground
        ''' </summary>
        ''' <remarks></remarks>
        AircraftOnGround
        ''' <summary>
        ''' Company material
        ''' </summary>
        ''' <remarks></remarks>
        Comat
        ''' <summary>
        ''' Foreign Mail
        ''' </summary>
        ''' <remarks></remarks>
        Foreign
        ''' <summary>
        ''' Freight
        ''' </summary>
        ''' <remarks></remarks>
        Freight
        ''' <summary>
        ''' Hub Container
        ''' </summary>
        ''' <remarks></remarks>
        Hub
        ''' <summary>
        ''' Local / OAL Bags
        ''' </summary>
        ''' <remarks></remarks>
        Local
        ''' <summary>
        ''' Mail
        ''' </summary>
        ''' <remarks></remarks>
        Mail
        ''' <summary>
        ''' Local or transfer Bags
        ''' </summary>
        ''' <remarks></remarks>
        Mixed
        ''' <summary>
        ''' Mixed priority Bags
        ''' </summary>
        ''' <remarks></remarks>
        MixedPriority
        ''' <summary>
        ''' Priority Bags
        ''' </summary>
        ''' <remarks></remarks>
        Priority
        ''' <summary>
        ''' Quick Freight
        ''' </summary>
        ''' <remarks></remarks>
        QuickFreight
        ''' <summary>
        ''' Mixed Cart
        ''' </summary>
        ''' <remarks></remarks>
        Sort
        ''' <summary>
        ''' Staged Bags
        ''' </summary>
        ''' <remarks></remarks>
        StagedBags
        ''' <summary>
        ''' Staged Freight
        ''' </summary>
        ''' <remarks></remarks>
        StagedFreight
        ''' <summary>
        ''' Staged Mail
        ''' </summary>
        ''' <remarks></remarks>
        StagedMail
        ''' <summary>
        ''' Transfer Bags
        ''' </summary>
        ''' <remarks></remarks>
        TransferBags
        ''' <summary>
        ''' Thru Bags
        ''' </summary>
        ''' <remarks></remarks>
        ThruBags
        ''' <summary>
        ''' Thru Freight
        ''' </summary>
        ''' <remarks></remarks>
        ThruFreight
        ''' <summary>
        ''' Thru Mail
        ''' </summary>
        ''' <remarks></remarks>
        ThruMail
        ''' <summary>
        ''' Transfer Freight
        ''' </summary>
        ''' <remarks></remarks>
        XferFreight
        ''' <summary>
        ''' Transfer Mail
        ''' </summary>
        ''' <remarks></remarks>
        XferMail
        ''' <summary>
        ''' Empty Container
        ''' </summary>
        ''' <remarks></remarks>
        Empty
    End Enum

    ''' <summary>
    ''' Scan Modes
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ScanModes
        ''' <summary>
        ''' Normal mode
        ''' </summary>
        ''' <remarks></remarks>
        Normal = 0
        ''' <summary>
        ''' Manual Mode
        ''' </summary>
        ''' <remarks></remarks>
        Manual = 1
        ''' <summary>
        ''' Animal Mode
        ''' </summary>
        ''' <remarks></remarks>
        Animal = 2
        ''' <summary>
        ''' Damaged Mode
        ''' </summary>
        ''' <remarks></remarks>
        Damaged = 3
        ''' <summary>
        ''' Heavy Bag Mode
        ''' </summary>
        ''' <remarks></remarks>
        Heavy = 4
        ''' <summary>
        ''' Planeside Bags Mode
        ''' </summary>
        ''' <remarks></remarks>
        Planeside = 5
        ''' <summary>
        ''' Single Scan Mode
        ''' </summary>
        ''' <remarks></remarks>
        SingleHeavy = 6
    End Enum
    ''' <summary>
    ''' Freight Modes
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum FreightTypes
        ''' <summary>
        ''' Aircraft on ground 
        ''' </summary>
        ''' <remarks></remarks>
        AircraftOnGround
        ''' <summary>
        ''' Company Material
        ''' </summary>
        ''' <remarks></remarks>
        Comat
        ''' <summary>
        ''' Staged Freight
        ''' </summary>
        ''' <remarks></remarks>
        StagedFreight
        ''' <summary>
        ''' Thru Freight
        ''' </summary>
        ''' <remarks></remarks>
        ThruFreight
        ''' <summary>
        ''' Transfer Freight
        ''' </summary>
        ''' <remarks></remarks>
        XferFreight
        ''' <summary>
        ''' Quick Freight
        ''' </summary>
        ''' <remarks></remarks>
        QuickFreight
    End Enum
    ''' <summary>
    ''' Bag Types
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum BagTypes
        ''' <summary>
        ''' Standard Bag
        ''' </summary>
        ''' <remarks></remarks>
        Bag
        ''' <summary>
        ''' Heavy Bag
        ''' </summary>
        ''' <remarks></remarks>
        HeavyBag
        ''' <summary>
        ''' Planeside Bag
        ''' </summary>
        ''' <remarks></remarks>
        PlanesideBag
    End Enum
    ''' <summary>
    ''' Mail Types
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum MailTypes
        ''' <summary>
        ''' Foreign Mail
        ''' </summary>
        ''' <remarks></remarks>
        Foreign
        ''' <summary>
        ''' Normal Mail
        ''' </summary>
        ''' <remarks></remarks>
        Mail
        ''' <summary>
        ''' Military Mail
        ''' </summary>
        ''' <remarks></remarks>
        Sam
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <remarks></remarks>
        XMail
    End Enum


    ''' <summary>
    ''' Bag Statuses
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum BagStatuses
        ''' <summary>
        ''' No load authority
        ''' </summary>
        ''' <remarks></remarks>
        NoAuth
        ''' <summary>
        ''' Bag is OK to load
        ''' </summary>
        ''' <remarks></remarks>
        Ok
        ''' <summary>
        ''' Passenger associated with the Bag is on a standby
        ''' </summary>
        ''' <remarks></remarks>
        StandBy
        ''' <summary>
        ''' Expedited Bag
        ''' </summary>
        ''' <remarks></remarks>
        Expedite
        ''' <summary>
        ''' Bag to unload
        ''' </summary>
        ''' <remarks></remarks>
        UnloadBag
    End Enum
    ''' <summary>
    ''' Bin Bulk Return Codes
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum BinBulkReturnCodes
        ''' <summary>
        ''' Valid Bin
        ''' </summary>
        ''' <remarks></remarks>
        BinValid = 300
        ''' <summary>
        ''' Valid Bulk
        ''' </summary>
        ''' <remarks></remarks>
        BulkValid = 301
        ''' <summary>
        ''' Invalid Bin Bulk
        ''' </summary>
        ''' <remarks></remarks>
        BinBulkInvalidGeneral = 302
        ''' <summary>
        ''' Too Long Bin Bulk Number
        ''' </summary>
        ''' <remarks></remarks>
        BinBulkInvalidTooLong = 303
        ''' <summary>
        ''' Invalid Bin Bulk
        ''' </summary>
        ''' <remarks></remarks>
        BinBulkInvalidBodyType = 304
    End Enum

    Public Enum ContainerReturnCodes
        ContainerValidActual = 0
        ContainerValidSubst = 200
        ContainerInvalidGeneral = 201
        ContainerInvalidTooShort = 202
        'added newly - validate - pending
        ContainerInvalidTooLong
        ContainerInvalidBodyType = 203
    End Enum

    Public Enum MailReturnCodes
        MailDomesticOk = 400      ' Domestic mail
        MailForeignOk = 401      ' Foreign
        MailEmeOk = 402      ' Emery
        MailInvalid = 403
        MailSwitchBin = 404
        MailSwitchBulk = 405
        MailSwitchContainer = 406
        MailInvalidBulk = 407
        MailInvalidBin = 408
    End Enum
    ''' <summary>
    ''' AWB Return Codes
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum AWBReturnCodes
        ''' <summary>
        ''' Valid AWB
        ''' </summary>
        ''' <remarks></remarks>
        AWBValid = 150
        ''' <summary>
        ''' Invalid AWB
        ''' </summary>
        ''' <remarks></remarks>
        AWBInvalid = 151
        InputError = -1
        NotAuthorized = 0
        Ok = 1
        DatabaseError = 2
        UnknownAWB = 3
        ULDClosed = 4
        LoadError = 5
        AlreadyRegsitered = 6
        ULDDeRegistered = 7
        OverruleableLoadError = 8
        FlightDeparted = 9
        FlightClosed = 10
        ADJWeight = 11
        CargoNotDone = 12
    End Enum

    Public Enum BagTagReturnCodes
        BagtagValid = 0
        BagtagSwitchBin = 1
        BagtagSwitchBulk = 2
        BagtagSwitchContainer = 3
        BagtagInvalidGeneral = 100
        BagtagInvalidTooShort = 101
        BagtagInvalidTooLong = 102
        BagtagInvalidAlpha = 103
        BagtagInvalidBin = 104
        BagtagInvalidBulk = 105
        BagtagInvalidBodyType = 106
        BagtagInvalidNoSwitch = 107
        'CONT_VALID_ACTUAL = 0
        'CONT_VALID_SUBST = 200
        ContainerInvalidGeneral = 201
        ContainerInvalidTooShort = 202
        BagtagDuplicatesFound = 16
        'CONT_INVALID_BODYTYPE = 203
    End Enum
    ''' <summary>
    ''' Station Type
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum StationType
        ''' <summary>
        ''' Batch Station
        ''' </summary>
        ''' <remarks></remarks>
        Batch
        ''' <summary>
        ''' Hub Station
        ''' </summary>
        ''' <remarks></remarks>
        Hub
    End Enum

    Public Enum SafetracFunction
        Login
        MainMenu
        Logoff
        AutoLogoff
        AlertMenu
        FlightsMenu
        SetBagAlert
        RemoveBagAlert
        ViewBagsOnAlert
        LoadBagIntoBinBulk
        ViewDuplicateBagTags
        ExpediteBag
        LoadMailIntoBinBulk
        LoadMailIntoContainer
        LoadFreightIntoBinBulk
        CreateNewAWB
        MergeContainersAndHolds
        ViewLineItems
        CreateMultipleContainerSheets
        PositionLineItems
        UnloadLineItems
        UpdateAWBs
        AddLateBag
        CloseFlight
        ReopenFlight
        LoadBagOnAlert
        CancelLoadOfBagOnAlert
        ExpediteCargo
        ViewBagTagInquiry
        ViewBagsToGo
        BinBulkInquiry
        ViewBagsToBeUnloaded
        UnloadBag
        UnloadFreight
        UnloadMailFromBinBulk
        UnloadMailFromContainer
        AddFlight
        RemoveFlight
        ModifyFlight
        PrecloseFlight
        ContainerInquiry
        RegisterContainer
        LoadBagToContainer
        PositionContainer
        CreateContainerSheetNumber
        ChangeContainerDefinition
        ViewHHTInformation
    End Enum

End Namespace