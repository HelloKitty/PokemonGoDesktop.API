// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RequestType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests {

  /// <summary>Holder for reflection information generated from RequestType.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class RequestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for RequestType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFSZXF1ZXN0VHlwZS5wcm90bxIeUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "cXVlc3RzKsEMCgtSZXF1ZXN0VHlwZRIQCgxNRVRIT0RfVU5TRVQQABIRCg1Q",
            "TEFZRVJfVVBEQVRFEAESDgoKR0VUX1BMQVlFUhACEhEKDUdFVF9JTlZFTlRP",
            "UlkQBBIVChFET1dOTE9BRF9TRVRUSU5HUxAFEhsKF0RPV05MT0FEX0lURU1f",
            "VEVNUExBVEVTEAYSIgoeRE9XTkxPQURfUkVNT1RFX0NPTkZJR19WRVJTSU9O",
            "EAcSDwoLRk9SVF9TRUFSQ0gQZRINCglFTkNPVU5URVIQZhIRCg1DQVRDSF9Q",
            "T0tFTU9OEGcSEAoMRk9SVF9ERVRBSUxTEGgSDAoISVRFTV9VU0UQaRITCg9H",
            "RVRfTUFQX09CSkVDVFMQahIXChNGT1JUX0RFUExPWV9QT0tFTU9OEG4SFwoT",
            "Rk9SVF9SRUNBTExfUE9LRU1PThBvEhMKD1JFTEVBU0VfUE9LRU1PThBwEhMK",
            "D1VTRV9JVEVNX1BPVElPThBxEhQKEFVTRV9JVEVNX0NBUFRVUkUQchIRCg1V",
            "U0VfSVRFTV9GTEVFEHMSEwoPVVNFX0lURU1fUkVWSVZFEHQSEAoMVFJBREVf",
            "U0VBUkNIEHUSDwoLVFJBREVfT0ZGRVIQdhISCg5UUkFERV9SRVNQT05TRRB3",
            "EhAKDFRSQURFX1JFU1VMVBB4EhYKEkdFVF9QTEFZRVJfUFJPRklMRRB5EhEK",
            "DUdFVF9JVEVNX1BBQ0sQehIRCg1CVVlfSVRFTV9QQUNLEHsSEAoMQlVZX0dF",
            "TV9QQUNLEHwSEgoORVZPTFZFX1BPS0VNT04QfRIUChBHRVRfSEFUQ0hFRF9F",
            "R0dTEH4SHwobRU5DT1VOVEVSX1RVVE9SSUFMX0NPTVBMRVRFEH8SFQoQTEVW",
            "RUxfVVBfUkVXQVJEUxCAARIZChRDSEVDS19BV0FSREVEX0JBREdFUxCBARIR",
            "CgxVU0VfSVRFTV9HWU0QhQESFAoPR0VUX0dZTV9ERVRBSUxTEIYBEhUKEFNU",
            "QVJUX0dZTV9CQVRUTEUQhwESDwoKQVRUQUNLX0dZTRCIARIbChZSRUNZQ0xF",
            "X0lOVkVOVE9SWV9JVEVNEIkBEhgKE0NPTExFQ1RfREFJTFlfQk9OVVMQigES",
            "FgoRVVNFX0lURU1fWFBfQk9PU1QQiwESGwoWVVNFX0lURU1fRUdHX0lOQ1VC",
            "QVRPUhCMARIQCgtVU0VfSU5DRU5TRRCNARIYChNHRVRfSU5DRU5TRV9QT0tF",
            "TU9OEI4BEhYKEUlOQ0VOU0VfRU5DT1VOVEVSEI8BEhYKEUFERF9GT1JUX01P",
            "RElGSUVSEJABEhMKDkRJU0tfRU5DT1VOVEVSEJEBEiEKHENPTExFQ1RfREFJ",
            "TFlfREVGRU5ERVJfQk9OVVMQkgESFAoPVVBHUkFERV9QT0tFTU9OEJMBEhkK",
            "FFNFVF9GQVZPUklURV9QT0tFTU9OEJQBEhUKEE5JQ0tOQU1FX1BPS0VNT04Q",
            "lQESEAoLRVFVSVBfQkFER0UQlgESGQoUU0VUX0NPTlRBQ1RfU0VUVElOR1MQ",
            "lwESFQoQR0VUX0FTU0VUX0RJR0VTVBCsAhIWChFHRVRfRE9XTkxPQURfVVJM",
            "UxCtAhIcChdHRVRfU1VHR0VTVEVEX0NPREVOQU1FUxCRAxIdChhDSEVDS19D",
            "T0RFTkFNRV9BVkFJTEFCTEUQkgMSEwoOQ0xBSU1fQ09ERU5BTUUQkwMSDwoK",
            "U0VUX0FWQVRBUhCUAxIUCg9TRVRfUExBWUVSX1RFQU0QlQMSGwoWTUFSS19U",
            "VVRPUklBTF9DT01QTEVURRCWAxIWChFMT0FEX1NQQVdOX1BPSU5UUxD0AxIJ",
            "CgRFQ0hPEJoFEhsKFkRFQlVHX1VQREFURV9JTlZFTlRPUlkQvAUSGAoTREVC",
            "VUdfREVMRVRFX1BMQVlFUhC9BRIXChJTRklEQV9SRUdJU1RSQVRJT04QoAYS",
            "FQoQU0ZJREFfQUNUSU9OX0xPRxChBhIYChNTRklEQV9DRVJUSUZJQ0FUSU9O",
            "EKIGEhEKDFNGSURBX1VQREFURRCjBhIRCgxTRklEQV9BQ1RJT04QpAYSEQoM",
            "U0ZJREFfRE9XU0VSEKUGEhIKDVNGSURBX0NBUFRVUkUQpgZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Networking.Requests.RequestType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RequestType {
    /// <summary>
    ///  No implementation required
    /// </summary>
    [pbr::OriginalName("METHOD_UNSET")] MethodUnset = 0,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("PLAYER_UPDATE")] PlayerUpdate = 1,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_PLAYER")] GetPlayer = 2,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INVENTORY")] GetInventory = 4,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_SETTINGS")] DownloadSettings = 5,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_ITEM_TEMPLATES")] DownloadItemTemplates = 6,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DOWNLOAD_REMOTE_CONFIG_VERSION")] DownloadRemoteConfigVersion = 7,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_SEARCH")] FortSearch = 101,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ENCOUNTER")] Encounter = 102,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CATCH_POKEMON")] CatchPokemon = 103,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_DETAILS")] FortDetails = 104,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("ITEM_USE")] ItemUse = 105,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_MAP_OBJECTS")] GetMapObjects = 106,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_DEPLOY_POKEMON")] FortDeployPokemon = 110,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("FORT_RECALL_POKEMON")] FortRecallPokemon = 111,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("RELEASE_POKEMON")] ReleasePokemon = 112,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_POTION")] UseItemPotion = 113,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_CAPTURE")] UseItemCapture = 114,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("USE_ITEM_FLEE")] UseItemFlee = 115,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_REVIVE")] UseItemRevive = 116,
    /// <summary>
    ///  Not yet implemented in the game
    /// </summary>
    [pbr::OriginalName("TRADE_SEARCH")] TradeSearch = 117,
    /// <summary>
    ///  Not yet implemented in the game
    /// </summary>
    [pbr::OriginalName("TRADE_OFFER")] TradeOffer = 118,
    /// <summary>
    ///  Not yet implemented in the game
    /// </summary>
    [pbr::OriginalName("TRADE_RESPONSE")] TradeResponse = 119,
    /// <summary>
    ///  Not yet implemented in the game
    /// </summary>
    [pbr::OriginalName("TRADE_RESULT")] TradeResult = 120,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_PLAYER_PROFILE")] GetPlayerProfile = 121,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("GET_ITEM_PACK")] GetItemPack = 122,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("BUY_ITEM_PACK")] BuyItemPack = 123,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("BUY_GEM_PACK")] BuyGemPack = 124,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("EVOLVE_POKEMON")] EvolvePokemon = 125,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_HATCHED_EGGS")] GetHatchedEggs = 126,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ENCOUNTER_TUTORIAL_COMPLETE")] EncounterTutorialComplete = 127,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("LEVEL_UP_REWARDS")] LevelUpRewards = 128,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("CHECK_AWARDED_BADGES")] CheckAwardedBadges = 129,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_GYM")] UseItemGym = 133,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_GYM_DETAILS")] GetGymDetails = 134,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("START_GYM_BATTLE")] StartGymBattle = 135,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ATTACK_GYM")] AttackGym = 136,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("RECYCLE_INVENTORY_ITEM")] RecycleInventoryItem = 137,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("COLLECT_DAILY_BONUS")] CollectDailyBonus = 138,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_XP_BOOST")] UseItemXpBoost = 139,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_ITEM_EGG_INCUBATOR")] UseItemEggIncubator = 140,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("USE_INCENSE")] UseIncense = 141,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_INCENSE_POKEMON")] GetIncensePokemon = 142,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("INCENSE_ENCOUNTER")] IncenseEncounter = 143,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ADD_FORT_MODIFIER")] AddFortModifier = 144,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("DISK_ENCOUNTER")] DiskEncounter = 145,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("COLLECT_DAILY_DEFENDER_BONUS")] CollectDailyDefenderBonus = 146,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("UPGRADE_POKEMON")] UpgradePokemon = 147,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_FAVORITE_POKEMON")] SetFavoritePokemon = 148,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("NICKNAME_POKEMON")] NicknamePokemon = 149,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("EQUIP_BADGE")] EquipBadge = 150,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_CONTACT_SETTINGS")] SetContactSettings = 151,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_ASSET_DIGEST")] GetAssetDigest = 300,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_DOWNLOAD_URLS")] GetDownloadUrls = 301,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("GET_SUGGESTED_CODENAMES")] GetSuggestedCodenames = 401,
    /// <summary>
    ///  Implemented [R &amp; M] TEST RESPONSE
    /// </summary>
    [pbr::OriginalName("CHECK_CODENAME_AVAILABLE")] CheckCodenameAvailable = 402,
    /// <summary>
    ///  Implemented [R &amp; M] TEST RESPONSE
    /// </summary>
    [pbr::OriginalName("CLAIM_CODENAME")] ClaimCodename = 403,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_AVATAR")] SetAvatar = 404,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("SET_PLAYER_TEAM")] SetPlayerTeam = 405,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("MARK_TUTORIAL_COMPLETE")] MarkTutorialComplete = 406,
    /// <summary>
    ///  Can't find this one
    /// </summary>
    [pbr::OriginalName("LOAD_SPAWN_POINTS")] LoadSpawnPoints = 500,
    /// <summary>
    ///  Implemented [R &amp; M]
    /// </summary>
    [pbr::OriginalName("ECHO")] Echo = 666,
    [pbr::OriginalName("DEBUG_UPDATE_INVENTORY")] DebugUpdateInventory = 700,
    [pbr::OriginalName("DEBUG_DELETE_PLAYER")] DebugDeletePlayer = 701,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_REGISTRATION")] SfidaRegistration = 800,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_ACTION_LOG")] SfidaActionLog = 801,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_CERTIFICATION")] SfidaCertification = 802,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_UPDATE")] SfidaUpdate = 803,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_ACTION")] SfidaAction = 804,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_DOWSER")] SfidaDowser = 805,
    /// <summary>
    ///  Not yet released.
    /// </summary>
    [pbr::OriginalName("SFIDA_CAPTURE")] SfidaCapture = 806,
  }

  #endregion

}

#endregion Designer generated code
