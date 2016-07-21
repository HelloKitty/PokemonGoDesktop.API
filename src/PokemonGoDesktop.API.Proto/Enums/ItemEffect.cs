// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ItemEffect.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from ItemEffect.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ItemEffectReflection {

    #region Descriptor
    /// <summary>File descriptor for ItemEffect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemEffectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBJdGVtRWZmZWN0LnByb3RvEhBQT0dPUHJvdG9zLkVudW1zKpgECgpJdGVt",
            "RWZmZWN0EhQKEElURU1fRUZGRUNUX05PTkUQABIcChdJVEVNX0VGRkVDVF9D",
            "QVBfTk9fRkxFRRDoBxIgChtJVEVNX0VGRkVDVF9DQVBfTk9fTU9WRU1FTlQQ",
            "6gcSHgoZSVRFTV9FRkZFQ1RfQ0FQX05PX1RIUkVBVBDrBxIfChpJVEVNX0VG",
            "RkVDVF9DQVBfVEFSR0VUX01BWBDsBxIgChtJVEVNX0VGRkVDVF9DQVBfVEFS",
            "R0VUX1NMT1cQ7QcSIQocSVRFTV9FRkZFQ1RfQ0FQX0NIQU5DRV9OSUdIVBDu",
            "BxIjCh5JVEVNX0VGRkVDVF9DQVBfQ0hBTkNFX1RSQUlORVIQ7wcSJwoiSVRF",
            "TV9FRkZFQ1RfQ0FQX0NIQU5DRV9GSVJTVF9USFJPVxDwBxIiCh1JVEVNX0VG",
            "RkVDVF9DQVBfQ0hBTkNFX0xFR0VORBDxBxIhChxJVEVNX0VGRkVDVF9DQVBf",
            "Q0hBTkNFX0hFQVZZEPIHEiIKHUlURU1fRUZGRUNUX0NBUF9DSEFOQ0VfUkVQ",
            "RUFUEPMHEicKIklURU1fRUZGRUNUX0NBUF9DSEFOQ0VfTVVMVElfVEhST1cQ",
            "9AcSIgodSVRFTV9FRkZFQ1RfQ0FQX0NIQU5DRV9BTFdBWVMQ9QcSKAojSVRF",
            "TV9FRkZFQ1RfQ0FQX0NIQU5DRV9TSU5HTEVfVEhST1cQ9gdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.ItemEffect), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ItemEffect {
    [pbr::OriginalName("ITEM_EFFECT_NONE")] None = 0,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_FLEE")] CapNoFlee = 1000,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_MOVEMENT")] CapNoMovement = 1002,
    [pbr::OriginalName("ITEM_EFFECT_CAP_NO_THREAT")] CapNoThreat = 1003,
    [pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_MAX")] CapTargetMax = 1004,
    [pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_SLOW")] CapTargetSlow = 1005,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_NIGHT")] CapChanceNight = 1006,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_TRAINER")] CapChanceTrainer = 1007,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_FIRST_THROW")] CapChanceFirstThrow = 1008,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_LEGEND")] CapChanceLegend = 1009,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_HEAVY")] CapChanceHeavy = 1010,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_REPEAT")] CapChanceRepeat = 1011,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_MULTI_THROW")] CapChanceMultiThrow = 1012,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_ALWAYS")] CapChanceAlways = 1013,
    [pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_SINGLE_THROW")] CapChanceSingleThrow = 1014,
  }

  #endregion

}

#endregion Designer generated code
