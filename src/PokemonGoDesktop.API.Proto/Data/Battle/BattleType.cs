// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BattleType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Battle {

  /// <summary>Holder for reflection information generated from BattleType.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class BattleTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBCYXR0bGVUeXBlLnByb3RvEhZQT0dPUHJvdG9zLkRhdGEuQmF0dGxlKj0K",
            "CkJhdHRsZVR5cGUSFQoRQkFUVExFX1RZUEVfVU5TRVQQABIKCgZOT1JNQUwQ",
            "ARIMCghUUkFJTklORxACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Data.Battle.BattleType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum BattleType {
    [pbr::OriginalName("BATTLE_TYPE_UNSET")] Unset = 0,
    [pbr::OriginalName("NORMAL")] Normal = 1,
    [pbr::OriginalName("TRAINING")] Training = 2,
  }

  #endregion

}

#endregion Designer generated code
