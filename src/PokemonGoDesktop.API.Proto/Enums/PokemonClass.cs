// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PokemonClass.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from PokemonClass.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonClassReflection {

    #region Descriptor
    /// <summary>File descriptor for PokemonClass.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonClassReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQb2tlbW9uQ2xhc3MucHJvdG8SEFBPR09Qcm90b3MuRW51bXMqNQoMUG9r",
            "ZW1vbkNsYXNzEgoKBk5PUk1BTBAAEg0KCUxFR0VOREFSWRABEgoKBk1ZVEhJ",
            "QxACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.PokemonClass), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonClass {
    [pbr::OriginalName("NORMAL")] Normal = 0,
    [pbr::OriginalName("LEGENDARY")] Legendary = 1,
    [pbr::OriginalName("MYTHIC")] Mythic = 2,
  }

  #endregion

}

#endregion Designer generated code
