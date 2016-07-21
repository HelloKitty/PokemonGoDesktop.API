// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GymLevelSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from GymLevelSettings.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class GymLevelSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for GymLevelSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymLevelSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZHeW1MZXZlbFNldHRpbmdzLnByb3RvEhpQT0dPUHJvdG9zLlNldHRpbmdz",
            "Lk1hc3RlciJ3ChBHeW1MZXZlbFNldHRpbmdzEhsKE3JlcXVpcmVkX2V4cGVy",
            "aWVuY2UYASADKAUSFAoMbGVhZGVyX3Nsb3RzGAIgAygFEhUKDXRyYWluZXJf",
            "c2xvdHMYAyADKAUSGQoRc2VhcmNoX3JvbGxfYm9udXMYBCADKAViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.GymLevelSettings), global::POGOProtos.Settings.Master.GymLevelSettings.Parser, new[]{ "RequiredExperience", "LeaderSlots", "TrainerSlots", "SearchRollBonus" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class GymLevelSettings : pb::IMessage<GymLevelSettings> {
    private static readonly pb::MessageParser<GymLevelSettings> _parser = new pb::MessageParser<GymLevelSettings>(() => new GymLevelSettings());
    public static pb::MessageParser<GymLevelSettings> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.GymLevelSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public GymLevelSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    public GymLevelSettings(GymLevelSettings other) : this() {
      requiredExperience_ = other.requiredExperience_.Clone();
      leaderSlots_ = other.leaderSlots_.Clone();
      trainerSlots_ = other.trainerSlots_.Clone();
      searchRollBonus_ = other.searchRollBonus_.Clone();
    }

    public GymLevelSettings Clone() {
      return new GymLevelSettings(this);
    }

    /// <summary>Field number for the "required_experience" field.</summary>
    public const int RequiredExperienceFieldNumber = 1;
    private static readonly pb::FieldCodec<int> _repeated_requiredExperience_codec
        = pb::FieldCodec.ForInt32(10);
    private readonly pbc::RepeatedField<int> requiredExperience_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> RequiredExperience {
      get { return requiredExperience_; }
    }

    /// <summary>Field number for the "leader_slots" field.</summary>
    public const int LeaderSlotsFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_leaderSlots_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> leaderSlots_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> LeaderSlots {
      get { return leaderSlots_; }
    }

    /// <summary>Field number for the "trainer_slots" field.</summary>
    public const int TrainerSlotsFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_trainerSlots_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> trainerSlots_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> TrainerSlots {
      get { return trainerSlots_; }
    }

    /// <summary>Field number for the "search_roll_bonus" field.</summary>
    public const int SearchRollBonusFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_searchRollBonus_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> searchRollBonus_ = new pbc::RepeatedField<int>();
    public pbc::RepeatedField<int> SearchRollBonus {
      get { return searchRollBonus_; }
    }

    public override bool Equals(object other) {
      return Equals(other as GymLevelSettings);
    }

    public bool Equals(GymLevelSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!requiredExperience_.Equals(other.requiredExperience_)) return false;
      if(!leaderSlots_.Equals(other.leaderSlots_)) return false;
      if(!trainerSlots_.Equals(other.trainerSlots_)) return false;
      if(!searchRollBonus_.Equals(other.searchRollBonus_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= requiredExperience_.GetHashCode();
      hash ^= leaderSlots_.GetHashCode();
      hash ^= trainerSlots_.GetHashCode();
      hash ^= searchRollBonus_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      requiredExperience_.WriteTo(output, _repeated_requiredExperience_codec);
      leaderSlots_.WriteTo(output, _repeated_leaderSlots_codec);
      trainerSlots_.WriteTo(output, _repeated_trainerSlots_codec);
      searchRollBonus_.WriteTo(output, _repeated_searchRollBonus_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += requiredExperience_.CalculateSize(_repeated_requiredExperience_codec);
      size += leaderSlots_.CalculateSize(_repeated_leaderSlots_codec);
      size += trainerSlots_.CalculateSize(_repeated_trainerSlots_codec);
      size += searchRollBonus_.CalculateSize(_repeated_searchRollBonus_codec);
      return size;
    }

    public void MergeFrom(GymLevelSettings other) {
      if (other == null) {
        return;
      }
      requiredExperience_.Add(other.requiredExperience_);
      leaderSlots_.Add(other.leaderSlots_);
      trainerSlots_.Add(other.trainerSlots_);
      searchRollBonus_.Add(other.searchRollBonus_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 8: {
            requiredExperience_.AddEntriesFrom(input, _repeated_requiredExperience_codec);
            break;
          }
          case 18:
          case 16: {
            leaderSlots_.AddEntriesFrom(input, _repeated_leaderSlots_codec);
            break;
          }
          case 26:
          case 24: {
            trainerSlots_.AddEntriesFrom(input, _repeated_trainerSlots_codec);
            break;
          }
          case 34:
          case 32: {
            searchRollBonus_.AddEntriesFrom(input, _repeated_searchRollBonus_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
