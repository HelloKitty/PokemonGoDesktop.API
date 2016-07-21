// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: LevelSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from LevelSettings.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class LevelSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for LevelSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LevelSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNMZXZlbFNldHRpbmdzLnByb3RvEhNQT0dPUHJvdG9zLlNldHRpbmdzIlEK",
            "DUxldmVsU2V0dGluZ3MSGwoTdHJhaW5lcl9jcF9tb2RpZmllchgCIAEoARIj",
            "Cht0cmFpbmVyX2RpZmZpY3VsdHlfbW9kaWZpZXIYAyABKAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.LevelSettings), global::POGOProtos.Settings.LevelSettings.Parser, new[]{ "TrainerCpModifier", "TrainerDifficultyModifier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class LevelSettings : pb::IMessage<LevelSettings> {
    private static readonly pb::MessageParser<LevelSettings> _parser = new pb::MessageParser<LevelSettings>(() => new LevelSettings());
    public static pb::MessageParser<LevelSettings> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.LevelSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public LevelSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    public LevelSettings(LevelSettings other) : this() {
      trainerCpModifier_ = other.trainerCpModifier_;
      trainerDifficultyModifier_ = other.trainerDifficultyModifier_;
    }

    public LevelSettings Clone() {
      return new LevelSettings(this);
    }

    /// <summary>Field number for the "trainer_cp_modifier" field.</summary>
    public const int TrainerCpModifierFieldNumber = 2;
    private double trainerCpModifier_;
    public double TrainerCpModifier {
      get { return trainerCpModifier_; }
      set {
        trainerCpModifier_ = value;
      }
    }

    /// <summary>Field number for the "trainer_difficulty_modifier" field.</summary>
    public const int TrainerDifficultyModifierFieldNumber = 3;
    private double trainerDifficultyModifier_;
    public double TrainerDifficultyModifier {
      get { return trainerDifficultyModifier_; }
      set {
        trainerDifficultyModifier_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as LevelSettings);
    }

    public bool Equals(LevelSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TrainerCpModifier != other.TrainerCpModifier) return false;
      if (TrainerDifficultyModifier != other.TrainerDifficultyModifier) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (TrainerCpModifier != 0D) hash ^= TrainerCpModifier.GetHashCode();
      if (TrainerDifficultyModifier != 0D) hash ^= TrainerDifficultyModifier.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (TrainerCpModifier != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(TrainerCpModifier);
      }
      if (TrainerDifficultyModifier != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(TrainerDifficultyModifier);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (TrainerCpModifier != 0D) {
        size += 1 + 8;
      }
      if (TrainerDifficultyModifier != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(LevelSettings other) {
      if (other == null) {
        return;
      }
      if (other.TrainerCpModifier != 0D) {
        TrainerCpModifier = other.TrainerCpModifier;
      }
      if (other.TrainerDifficultyModifier != 0D) {
        TrainerDifficultyModifier = other.TrainerDifficultyModifier;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 17: {
            TrainerCpModifier = input.ReadDouble();
            break;
          }
          case 25: {
            TrainerDifficultyModifier = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
