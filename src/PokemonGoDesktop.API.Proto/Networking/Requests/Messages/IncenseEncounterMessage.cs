// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: IncenseEncounterMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from IncenseEncounterMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class IncenseEncounterMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for IncenseEncounterMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IncenseEncounterMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1JbmNlbnNlRW5jb3VudGVyTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5O",
            "ZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzIksKF0luY2Vuc2VFbmNvdW50",
            "ZXJNZXNzYWdlEhQKDGVuY291bnRlcl9pZBgBIAEoAxIaChJlbmNvdW50ZXJf",
            "bG9jYXRpb24YAiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.IncenseEncounterMessage), global::POGOProtos.Networking.Requests.Messages.IncenseEncounterMessage.Parser, new[]{ "EncounterId", "EncounterLocation" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class IncenseEncounterMessage : pb::IMessage<IncenseEncounterMessage> {
    private static readonly pb::MessageParser<IncenseEncounterMessage> _parser = new pb::MessageParser<IncenseEncounterMessage>(() => new IncenseEncounterMessage());
    public static pb::MessageParser<IncenseEncounterMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.IncenseEncounterMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public IncenseEncounterMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public IncenseEncounterMessage(IncenseEncounterMessage other) : this() {
      encounterId_ = other.encounterId_;
      encounterLocation_ = other.encounterLocation_;
    }

    public IncenseEncounterMessage Clone() {
      return new IncenseEncounterMessage(this);
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 1;
    private long encounterId_;
    public long EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "encounter_location" field.</summary>
    public const int EncounterLocationFieldNumber = 2;
    private string encounterLocation_ = "";
    public string EncounterLocation {
      get { return encounterLocation_; }
      set {
        encounterLocation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as IncenseEncounterMessage);
    }

    public bool Equals(IncenseEncounterMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncounterId != other.EncounterId) return false;
      if (EncounterLocation != other.EncounterLocation) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (EncounterId != 0L) hash ^= EncounterId.GetHashCode();
      if (EncounterLocation.Length != 0) hash ^= EncounterLocation.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (EncounterId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(EncounterId);
      }
      if (EncounterLocation.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EncounterLocation);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (EncounterId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EncounterId);
      }
      if (EncounterLocation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EncounterLocation);
      }
      return size;
    }

    public void MergeFrom(IncenseEncounterMessage other) {
      if (other == null) {
        return;
      }
      if (other.EncounterId != 0L) {
        EncounterId = other.EncounterId;
      }
      if (other.EncounterLocation.Length != 0) {
        EncounterLocation = other.EncounterLocation;
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
            EncounterId = input.ReadInt64();
            break;
          }
          case 18: {
            EncounterLocation = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
