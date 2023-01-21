// Copyright (c) 2022, 2023, Oracle and/or its affiliates.
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License, version 2.0, as
// published by the Free Software Foundation.
//
// This program is also distributed with certain software (including
// but not limited to OpenSSL) that is licensed under separate terms,
// as designated in a particular file or component or in included license
// documentation.  The authors of MySQL hereby grant you an
// additional permission to link the program and your derivative works
// with the separately licensed software that they have included with
// MySQL.
//
// Without limiting anything contained in the foregoing, this file,
// which is part of MySQL Connector/NET, is also subject to the
// Universal FOSS Exception, version 1.0, a copy of which can be found at
// http://oss.oracle.com/licenses/universal-foss-exception.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License, version 2.0, for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mysqlx_sql.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mysqlx.Sql {

  /// <summary>Holder for reflection information generated from mysqlx_sql.proto</summary>
  internal static partial class MysqlxSqlReflection {

    #region Descriptor
    /// <summary>File descriptor for mysqlx_sql.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MysqlxSqlReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBteXNxbHhfc3FsLnByb3RvEgpNeXNxbHguU3FsGgxteXNxbHgucHJvdG8a",
            "Fm15c3FseF9kYXRhdHlwZXMucHJvdG8ifwoLU3RtdEV4ZWN1dGUSFgoJbmFt",
            "ZXNwYWNlGAMgASgJOgNzcWwSDAoEc3RtdBgBIAIoDBIjCgRhcmdzGAIgAygL",
            "MhUuTXlzcWx4LkRhdGF0eXBlcy5BbnkSHwoQY29tcGFjdF9tZXRhZGF0YRgE",
            "IAEoCDoFZmFsc2U6BIjqMAwiFQoNU3RtdEV4ZWN1dGVPazoEkOowEUIZChdj",
            "b20ubXlzcWwuY2oueC5wcm90b2J1Zg=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mysqlx.MysqlxReflection.Descriptor, global::Mysqlx.Datatypes.MysqlxDatatypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Sql.StmtExecute), global::Mysqlx.Sql.StmtExecute.Parser, new[]{ "Namespace", "Stmt", "Args", "CompactMetadata" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Sql.StmtExecuteOk), global::Mysqlx.Sql.StmtExecuteOk.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  ///Execute a statement in the given namespace.
  ///
  ///@startuml "Execute Statements"
  ///client -> server: StmtExecute
  ///... zero or more Resultsets ...
  ///server --> client: StmtExecuteOk
  ///@enduml
  ///
  ///@notice This message may generate a notice containing WARNINGs generated by
  ///its execution. This message may generate a  notice containing INFO messages
  ///generated by its execution.
  ///
  ///@returns zero or more  @ref Mysqlx::Resultset followed by @ref Mysqlx::Sql::StmtExecuteOk
  /// </summary>
  internal sealed partial class StmtExecute : pb::IMessage<StmtExecute>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StmtExecute> _parser = new pb::MessageParser<StmtExecute>(() => new StmtExecute());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StmtExecute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Sql.MysqlxSqlReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StmtExecute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StmtExecute(StmtExecute other) : this() {
      _hasBits0 = other._hasBits0;
      namespace_ = other.namespace_;
      stmt_ = other.stmt_;
      args_ = other.args_.Clone();
      compactMetadata_ = other.compactMetadata_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StmtExecute Clone() {
      return new StmtExecute(this);
    }

    /// <summary>Field number for the "namespace" field.</summary>
    public const int NamespaceFieldNumber = 3;
    private readonly static string NamespaceDefaultValue = global::System.Text.Encoding.UTF8.GetString(global::System.Convert.FromBase64String("c3Fs"), 0, 3);

    private string namespace_;
    /// <summary>
    ///* namespace of the statement to be executed 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Namespace {
      get { return namespace_ ?? NamespaceDefaultValue; }
      set {
        namespace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "namespace" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasNamespace {
      get { return namespace_ != null; }
    }
    /// <summary>Clears the value of the "namespace" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearNamespace() {
      namespace_ = null;
    }

    /// <summary>Field number for the "stmt" field.</summary>
    public const int StmtFieldNumber = 1;
    private readonly static pb::ByteString StmtDefaultValue = pb::ByteString.Empty;

    private pb::ByteString stmt_;
    /// <summary>
    ///* statement that shall be executed  
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Stmt {
      get { return stmt_ ?? StmtDefaultValue; }
      set {
        stmt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "stmt" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasStmt {
      get { return stmt_ != null; }
    }
    /// <summary>Clears the value of the "stmt" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearStmt() {
      stmt_ = null;
    }

    /// <summary>Field number for the "args" field.</summary>
    public const int ArgsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Mysqlx.Datatypes.Any> _repeated_args_codec
        = pb::FieldCodec.ForMessage(18, global::Mysqlx.Datatypes.Any.Parser);
    private readonly pbc::RepeatedField<global::Mysqlx.Datatypes.Any> args_ = new pbc::RepeatedField<global::Mysqlx.Datatypes.Any>();
    /// <summary>
    ///* values for wildcard replacements 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Mysqlx.Datatypes.Any> Args {
      get { return args_; }
    }

    /// <summary>Field number for the "compact_metadata" field.</summary>
    public const int CompactMetadataFieldNumber = 4;
    private readonly static bool CompactMetadataDefaultValue = false;

    private bool compactMetadata_;
    /// <summary>
    ///* send only type information for @ref Mysqlx::Resultset::ColumnMetaData,
    ///skipping names and others 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CompactMetadata {
      get { if ((_hasBits0 & 1) != 0) { return compactMetadata_; } else { return CompactMetadataDefaultValue; } }
      set {
        _hasBits0 |= 1;
        compactMetadata_ = value;
      }
    }
    /// <summary>Gets whether the "compact_metadata" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCompactMetadata {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "compact_metadata" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCompactMetadata() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StmtExecute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StmtExecute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Namespace != other.Namespace) return false;
      if (Stmt != other.Stmt) return false;
      if(!args_.Equals(other.args_)) return false;
      if (CompactMetadata != other.CompactMetadata) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasNamespace) hash ^= Namespace.GetHashCode();
      if (HasStmt) hash ^= Stmt.GetHashCode();
      hash ^= args_.GetHashCode();
      if (HasCompactMetadata) hash ^= CompactMetadata.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HasStmt) {
        output.WriteRawTag(10);
        output.WriteBytes(Stmt);
      }
      args_.WriteTo(output, _repeated_args_codec);
      if (HasNamespace) {
        output.WriteRawTag(26);
        output.WriteString(Namespace);
      }
      if (HasCompactMetadata) {
        output.WriteRawTag(32);
        output.WriteBool(CompactMetadata);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HasStmt) {
        output.WriteRawTag(10);
        output.WriteBytes(Stmt);
      }
      args_.WriteTo(ref output, _repeated_args_codec);
      if (HasNamespace) {
        output.WriteRawTag(26);
        output.WriteString(Namespace);
      }
      if (HasCompactMetadata) {
        output.WriteRawTag(32);
        output.WriteBool(CompactMetadata);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (HasNamespace) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Namespace);
      }
      if (HasStmt) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Stmt);
      }
      size += args_.CalculateSize(_repeated_args_codec);
      if (HasCompactMetadata) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StmtExecute other) {
      if (other == null) {
        return;
      }
      if (other.HasNamespace) {
        Namespace = other.Namespace;
      }
      if (other.HasStmt) {
        Stmt = other.Stmt;
      }
      args_.Add(other.args_);
      if (other.HasCompactMetadata) {
        CompactMetadata = other.CompactMetadata;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Stmt = input.ReadBytes();
            break;
          }
          case 18: {
            args_.AddEntriesFrom(input, _repeated_args_codec);
            break;
          }
          case 26: {
            Namespace = input.ReadString();
            break;
          }
          case 32: {
            CompactMetadata = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Stmt = input.ReadBytes();
            break;
          }
          case 18: {
            args_.AddEntriesFrom(ref input, _repeated_args_codec);
            break;
          }
          case 26: {
            Namespace = input.ReadString();
            break;
          }
          case 32: {
            CompactMetadata = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  ///*
  ///Statement executed successfully
  /// </summary>
  internal sealed partial class StmtExecuteOk : pb::IMessage<StmtExecuteOk>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StmtExecuteOk> _parser = new pb::MessageParser<StmtExecuteOk>(() => new StmtExecuteOk());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StmtExecuteOk> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Sql.MysqlxSqlReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StmtExecuteOk() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StmtExecuteOk(StmtExecuteOk other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StmtExecuteOk Clone() {
      return new StmtExecuteOk(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StmtExecuteOk);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StmtExecuteOk other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StmtExecuteOk other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
