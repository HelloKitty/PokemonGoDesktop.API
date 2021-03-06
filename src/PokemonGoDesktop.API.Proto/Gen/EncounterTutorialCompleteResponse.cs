// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/EncounterTutorialCompleteResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Networking/Responses/EncounterTutorialCompleteResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class EncounterTutorialCompleteResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/EncounterTutorialCompleteResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EncounterTutorialCompleteResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxOZXR3b3JraW5nL1Jlc3BvbnNlcy9FbmNvdW50ZXJUdXRvcmlhbENvbXBs",
            "ZXRlUmVzcG9uc2UucHJvdG8SFE5ldHdvcmtpbmcuUmVzcG9uc2VzGhZEYXRh",
            "L1Bva2Vtb25EYXRhLnByb3RvGh9EYXRhL0NhcHR1cmUvQ2FwdHVyZUF3YXJk",
            "LnByb3RvIowCCiFFbmNvdW50ZXJUdXRvcmlhbENvbXBsZXRlUmVzcG9uc2US",
            "TgoGcmVzdWx0GAEgASgOMj4uTmV0d29ya2luZy5SZXNwb25zZXMuRW5jb3Vu",
            "dGVyVHV0b3JpYWxDb21wbGV0ZVJlc3BvbnNlLlJlc3VsdBInCgxwb2tlbW9u",
            "X2RhdGEYAiABKAsyES5EYXRhLlBva2Vtb25EYXRhEjEKDWNhcHR1cmVfYXdh",
            "cmQYAyABKAsyGi5EYXRhLkNhcHR1cmUuQ2FwdHVyZUF3YXJkIjsKBlJlc3Vs",
            "dBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIZChVFUlJPUl9JTlZBTElEX1BP",
            "S0VNT04QAkIdqgIaUG9rZW1vbkdvRGVza3RvcC5BUEkuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::PokemonGoDesktop.API.Proto.PokemonDataReflection.Descriptor, global::PokemonGoDesktop.API.Proto.CaptureAwardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.EncounterTutorialCompleteResponse), global::PokemonGoDesktop.API.Proto.EncounterTutorialCompleteResponse.Parser, new[]{ "Result", "PokemonData", "CaptureAward" }, null, new[]{ typeof(global::PokemonGoDesktop.API.Proto.EncounterTutorialCompleteResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class EncounterTutorialCompleteResponse : pb::IMessage<EncounterTutorialCompleteResponse> {
    private static readonly pb::MessageParser<EncounterTutorialCompleteResponse> _parser = new pb::MessageParser<EncounterTutorialCompleteResponse>(() => new EncounterTutorialCompleteResponse());
    public static pb::MessageParser<EncounterTutorialCompleteResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.EncounterTutorialCompleteResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public EncounterTutorialCompleteResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public EncounterTutorialCompleteResponse(EncounterTutorialCompleteResponse other) : this() {
      result_ = other.result_;
      PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
      CaptureAward = other.captureAward_ != null ? other.CaptureAward.Clone() : null;
    }

    public EncounterTutorialCompleteResponse Clone() {
      return new EncounterTutorialCompleteResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::PokemonGoDesktop.API.Proto.EncounterTutorialCompleteResponse.Types.Result result_ = 0;
    public global::PokemonGoDesktop.API.Proto.EncounterTutorialCompleteResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_data" field.</summary>
    public const int PokemonDataFieldNumber = 2;
    private global::PokemonGoDesktop.API.Proto.PokemonData pokemonData_;
    public global::PokemonGoDesktop.API.Proto.PokemonData PokemonData {
      get { return pokemonData_; }
      set {
        pokemonData_ = value;
      }
    }

    /// <summary>Field number for the "capture_award" field.</summary>
    public const int CaptureAwardFieldNumber = 3;
    private global::PokemonGoDesktop.API.Proto.CaptureAward captureAward_;
    public global::PokemonGoDesktop.API.Proto.CaptureAward CaptureAward {
      get { return captureAward_; }
      set {
        captureAward_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as EncounterTutorialCompleteResponse);
    }

    public bool Equals(EncounterTutorialCompleteResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(PokemonData, other.PokemonData)) return false;
      if (!object.Equals(CaptureAward, other.CaptureAward)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (pokemonData_ != null) hash ^= PokemonData.GetHashCode();
      if (captureAward_ != null) hash ^= CaptureAward.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (pokemonData_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PokemonData);
      }
      if (captureAward_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CaptureAward);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (pokemonData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
      }
      if (captureAward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureAward);
      }
      return size;
    }

    public void MergeFrom(EncounterTutorialCompleteResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.pokemonData_ != null) {
        if (pokemonData_ == null) {
          pokemonData_ = new global::PokemonGoDesktop.API.Proto.PokemonData();
        }
        PokemonData.MergeFrom(other.PokemonData);
      }
      if (other.captureAward_ != null) {
        if (captureAward_ == null) {
          captureAward_ = new global::PokemonGoDesktop.API.Proto.CaptureAward();
        }
        CaptureAward.MergeFrom(other.CaptureAward);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::PokemonGoDesktop.API.Proto.EncounterTutorialCompleteResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (pokemonData_ == null) {
              pokemonData_ = new global::PokemonGoDesktop.API.Proto.PokemonData();
            }
            input.ReadMessage(pokemonData_);
            break;
          }
          case 26: {
            if (captureAward_ == null) {
              captureAward_ = new global::PokemonGoDesktop.API.Proto.CaptureAward();
            }
            input.ReadMessage(captureAward_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the EncounterTutorialCompleteResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_INVALID_POKEMON")] ErrorInvalidPokemon = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
