// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: CheckAwardedBadgesMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from CheckAwardedBadgesMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CheckAwardedBadgesMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for CheckAwardedBadgesMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckAwardedBadgesMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DaGVja0F3YXJkZWRCYWRnZXNNZXNzYWdlLnByb3RvEidQT0dPUHJvdG9z",
            "Lk5ldHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMiGwoZQ2hlY2tBd2FyZGVk",
            "QmFkZ2VzTWVzc2FnZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.CheckAwardedBadgesMessage), global::POGOProtos.Networking.Requests.Messages.CheckAwardedBadgesMessage.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  No message needed.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CheckAwardedBadgesMessage : pb::IMessage<CheckAwardedBadgesMessage> {
    private static readonly pb::MessageParser<CheckAwardedBadgesMessage> _parser = new pb::MessageParser<CheckAwardedBadgesMessage>(() => new CheckAwardedBadgesMessage());
    public static pb::MessageParser<CheckAwardedBadgesMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.CheckAwardedBadgesMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CheckAwardedBadgesMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CheckAwardedBadgesMessage(CheckAwardedBadgesMessage other) : this() {
    }

    public CheckAwardedBadgesMessage Clone() {
      return new CheckAwardedBadgesMessage(this);
    }

    public override bool Equals(object other) {
      return Equals(other as CheckAwardedBadgesMessage);
    }

    public bool Equals(CheckAwardedBadgesMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(CheckAwardedBadgesMessage other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
