// Generated by https://github.com/gamous/FFXIVNetworkOpcodes
namespace FFXIVOpcodes.CN
{
    public enum ServerLobbyIpcType : ushort
    {
    
    };
    
    public enum ClientLobbyIpcType : ushort
    {
    
    };
    
    public enum ServerZoneIpcType : ushort
    {
        PlayerSpawn = 0x008F,
        NpcSpawn = 0x01C3,
        NpcSpawn2 = 0x0360,
        ActorFreeSpawn = 0x039C,
        ObjectSpawn = 0x017B,
        ObjectDespawn = 0x03B8,
        CreateTreasure = 0x0121,
        OpenTreasure = 0x01DE,
        TreasureFadeOut = 0x03D7,
        ActorMove = 0x016D,
        _record_unk10_ = 0x02DF,
        Transfer = 0x03B2,
        Effect = 0x01F4,
        AoeEffect8 = 0x015A,
        AoeEffect16 = 0x032D,
        AoeEffect24 = 0x01A1,
        AoeEffect32 = 0x02CF,
        ActorCast = 0x014C,
        ActorControl = 0x03D0,
        ActorControlTarget = 0x0111,
        ActorControlSelf = 0x00F1,
        DirectorVars = 0x01BC,
        ContentDirectorSync = 0x019C,
        _record_unk23_ = 0x03C2,
        EnvironmentControl = 0x0133,
        _record_unk29_ = 0x01EC,
        LandSetMap = 0x009D,
        EventStart = 0x03D2,
        EventFinish = 0x00A8,
        EventPlay = 0x022F,
        EventPlay4 = 0x01AB,
        EventPlay8 = 0x015D,
        EventPlay16 = 0x00AE,
        EventPlay32 = 0x027A,
        EventPlay64 = 0x009A,
        EventPlay128 = 0x0277,
        EventPlay255 = 0x00A2,
        BattleTalk2 = 0x0276,
        BattleTalk4 = 0x0181,
        BattleTalk8 = 0x023A,
        BalloonTalk2 = 0x03C7,
        BalloonTalk4 = 0x0280,
        BalloonTalk8 = 0x037C,
        SystemLogMessage = 0x0293,
        SystemLogMessage32 = 0x02B1,
        SystemLogMessage48 = 0x030F,
        SystemLogMessage80 = 0x0364,
        SystemLogMessage144 = 0x02D7,
        NpcYell = 0x0136,
        ActorSetPos = 0x0292,
        PrepareZoning = 0x022B,
        StatusEffectList3 = 0x03B3,
        WeatherChange = 0x0322,
        UpdateParty = 0x00F8,
        UpdateAlliance = 0x02DE,
        UpdateSpAlliance = 0x00EA,
        UpdateHpMpTp = 0x023C,
        StatusEffectList = 0x0283,
        EurekaStatusEffectList = 0x01AA,
        StatusEffectList2 = 0x0076,
        BossStatusEffectList = 0x0122,
        EffectResult = 0x00AA,
        EffectResult4 = 0x00DE,
        EffectResult8 = 0x0185,
        EffectResult16 = 0x024B,
        EffectResultBasic = 0x008B,
        EffectResultBasic4 = 0x00D6,
        EffectResultBasic8 = 0x01B3,
        EffectResultBasic16 = 0x039A,
        EffectResultBasic32 = 0x016A,
        EffectResultBasic64 = 0x033D,
        PartyPos = 0x0324,
        AlliancePos = 0x039E,
        SpAlliancePos = 0x03A7,
        PlaceMarker = 0x0314,
        PlaceFieldMarkerPreset = 0x0188,
        PlaceFieldMarker = 0x032C,
        ActorGauge = 0x00E2,
        CharaVisualEffect = 0x032E,
        Fall = 0x032B,
        UpdateHate = 0x00A9,
        UpdateHater = 0x0331,
        FirstAttack = 0x0299,
        ModelEquip = 0x0228,
        EquipDisplayFlags = 0x03A3,
        UnMount = 0x02D0,
        Mount = 0x02B5,
        PlayMotionSync = 0x01A6,
        CountdownInitiate = 0x02E4,
        CountdownCancel = 0x02BD,
        InitZone = 0x00CE,
        Examine = 0x00EC,
        ExamineSearchInfo = 0x01B5,
        InventoryActionAck = 0x017F,
        MarketBoardItemListing = 0x0102,
        MarketBoardItemListingCount = 0x02E6,
        MarketBoardItemListingHistory = 0x0231,
        MarketBoardSearchResult = 0x01B8,
        MarketBoardPurchase = 0x02B0,
        PlayerSetup = 0x01AF,
        PlayerStats = 0x02C2,
        Playtime = 0x00DC,
        UpdateClassInfo = 0x02B7,
        UpdateInventorySlot = 0x0313,
        UpdateSearchInfo = 0x00B9,
        WardLandInfo = 0x037E,
        CEDirector = 0x039D,
        Logout = 0x02AE,
        FreeCompanyInfo = 0x026F,
        FreeCompanyDialog = 0x014B,
        AirshipStatusList = 0x035A,
        AirshipStatus = 0x03B9,
        AirshipExplorationResult = 0x00CA,
        SubmarineStatusList = 0x0209,
        SubmarineProgressionStatus = 0x00E7,
        SubmarineExplorationResult = 0x0301,
        CFPreferredRole = 0x038F,
        CompanyAirshipStatus = 0x013B,
        CompanySubmersibleStatus = 0x016E,
        ContentFinderNotifyPop = 0x02DD,
        FateInfo = 0x032A,
        UpdateRecastTimes = 0x02B9,
        SocialList = 0x0362,
        IslandWorkshopSupplyDemand = 0x0106,
        RSV = 0x0321,
        RSF = 0x0086,
    };
    
    public enum ClientLobbyIpcType : ushort
    {
        ActionRequest = 0x01DB,
        ActionRequestGroundTargeted = 0x0124,
        ChatHandler = 0x02CD,
        ClientTrigger  = 0x0118,
        InventoryModifyHandler = 0x02FA,
        MarketBoardPurchaseHandler = 0x0220,
        SetSearchInfoHandler = 0x019D,
        UpdatePositionHandler = 0x0071,
        UpdatePositionInstance = 0x00DB,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
