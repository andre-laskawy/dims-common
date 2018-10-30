// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: LogLevelInfo.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dims.Common.Models {

  /// <summary>Holder for reflection information generated from LogLevelInfo.proto</summary>
  public static partial class LogLevelInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for LogLevelInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogLevelInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJMb2dMZXZlbEluZm8ucHJvdG8SEkRpbXMuQ29tbW9uLk1vZGVscyIdCgxM",
            "b2dMZXZlbEluZm8SDQoFTGV2ZWwYASABKAlCKwoPaW8uZ3JwYy5tZXNzYWdl",
            "QhBNZXNzYWdlRGF0YVByb3RvUAGiAgNITFdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dims.Common.Models.LogLevelInfo), global::Dims.Common.Models.LogLevelInfo.Parser, new[]{ "Level" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LogLevelInfo : pb::IMessage<LogLevelInfo> {
    private static readonly pb::MessageParser<LogLevelInfo> _parser = new pb::MessageParser<LogLevelInfo>(() => new LogLevelInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LogLevelInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dims.Common.Models.LogLevelInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogLevelInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogLevelInfo(LogLevelInfo other) : this() {
      level_ = other.level_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogLevelInfo Clone() {
      return new LogLevelInfo(this);
    }

    /// <summary>Field number for the "Level" field.</summary>
    public const int LevelFieldNumber = 1;
    private string level_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Level {
      get { return level_; }
      set {
        level_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LogLevelInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LogLevelInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Level.Length != 0) hash ^= Level.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Level.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Level);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Level.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Level);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LogLevelInfo other) {
      if (other == null) {
        return;
      }
      if (other.Level.Length != 0) {
        Level = other.Level;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Level = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
