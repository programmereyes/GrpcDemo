// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Employee.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EmployeeMessages {

  /// <summary>Holder for reflection information generated from Protos/Employee.proto</summary>
  public static partial class EmployeeReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/Employee.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EmployeeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvRW1wbG95ZWUucHJvdG8SEEVtcGxveWVlTWVzc2FnZXMiQwoT",
            "R2V0RW1wbG95ZWVSZXNwb25zZRIsCghlbXBsb3llZRgBIAMoCzIaLkVtcGxv",
            "eWVlTWVzc2FnZXMuRW1wbG95ZWUiKAoSR2V0RW1wbG95ZWVSZXF1ZXN0EhIK",
            "CmVtcGxveWVlSWQYASABKAUiLwoIRW1wbG95ZWUSEQoJRmlyc3RuYW1lGAEg",
            "ASgJEhAKCExhc3RuYW1lGAIgASgJMm8KD0VtcGxveWVlU2VydmljZRJcCgtH",
            "ZXRFbXBsb3llZRIkLkVtcGxveWVlTWVzc2FnZXMuR2V0RW1wbG95ZWVSZXF1",
            "ZXN0GiUuRW1wbG95ZWVNZXNzYWdlcy5HZXRFbXBsb3llZVJlc3BvbnNlIgBC",
            "E6oCEEVtcGxveWVlTWVzc2FnZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EmployeeMessages.GetEmployeeResponse), global::EmployeeMessages.GetEmployeeResponse.Parser, new[]{ "Employee" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::EmployeeMessages.GetEmployeeRequest), global::EmployeeMessages.GetEmployeeRequest.Parser, new[]{ "EmployeeId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::EmployeeMessages.Employee), global::EmployeeMessages.Employee.Parser, new[]{ "Firstname", "Lastname" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetEmployeeResponse : pb::IMessage<GetEmployeeResponse> {
    private static readonly pb::MessageParser<GetEmployeeResponse> _parser = new pb::MessageParser<GetEmployeeResponse>(() => new GetEmployeeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetEmployeeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EmployeeMessages.EmployeeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEmployeeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEmployeeResponse(GetEmployeeResponse other) : this() {
      employee_ = other.employee_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEmployeeResponse Clone() {
      return new GetEmployeeResponse(this);
    }

    /// <summary>Field number for the "employee" field.</summary>
    public const int EmployeeFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EmployeeMessages.Employee> _repeated_employee_codec
        = pb::FieldCodec.ForMessage(10, global::EmployeeMessages.Employee.Parser);
    private readonly pbc::RepeatedField<global::EmployeeMessages.Employee> employee_ = new pbc::RepeatedField<global::EmployeeMessages.Employee>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::EmployeeMessages.Employee> Employee {
      get { return employee_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetEmployeeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetEmployeeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!employee_.Equals(other.employee_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= employee_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      employee_.WriteTo(output, _repeated_employee_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += employee_.CalculateSize(_repeated_employee_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetEmployeeResponse other) {
      if (other == null) {
        return;
      }
      employee_.Add(other.employee_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            employee_.AddEntriesFrom(input, _repeated_employee_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetEmployeeRequest : pb::IMessage<GetEmployeeRequest> {
    private static readonly pb::MessageParser<GetEmployeeRequest> _parser = new pb::MessageParser<GetEmployeeRequest>(() => new GetEmployeeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetEmployeeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EmployeeMessages.EmployeeReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEmployeeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEmployeeRequest(GetEmployeeRequest other) : this() {
      employeeId_ = other.employeeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetEmployeeRequest Clone() {
      return new GetEmployeeRequest(this);
    }

    /// <summary>Field number for the "employeeId" field.</summary>
    public const int EmployeeIdFieldNumber = 1;
    private int employeeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EmployeeId {
      get { return employeeId_; }
      set {
        employeeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetEmployeeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetEmployeeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EmployeeId != other.EmployeeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EmployeeId != 0) hash ^= EmployeeId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EmployeeId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EmployeeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EmployeeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EmployeeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetEmployeeRequest other) {
      if (other == null) {
        return;
      }
      if (other.EmployeeId != 0) {
        EmployeeId = other.EmployeeId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            EmployeeId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Employee : pb::IMessage<Employee> {
    private static readonly pb::MessageParser<Employee> _parser = new pb::MessageParser<Employee>(() => new Employee());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Employee> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EmployeeMessages.EmployeeReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee(Employee other) : this() {
      firstname_ = other.firstname_;
      lastname_ = other.lastname_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Employee Clone() {
      return new Employee(this);
    }

    /// <summary>Field number for the "Firstname" field.</summary>
    public const int FirstnameFieldNumber = 1;
    private string firstname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Firstname {
      get { return firstname_; }
      set {
        firstname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Lastname" field.</summary>
    public const int LastnameFieldNumber = 2;
    private string lastname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Lastname {
      get { return lastname_; }
      set {
        lastname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Employee);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Employee other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Firstname != other.Firstname) return false;
      if (Lastname != other.Lastname) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Firstname.Length != 0) hash ^= Firstname.GetHashCode();
      if (Lastname.Length != 0) hash ^= Lastname.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Firstname.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Firstname);
      }
      if (Lastname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Lastname);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Firstname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Firstname);
      }
      if (Lastname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Lastname);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Employee other) {
      if (other == null) {
        return;
      }
      if (other.Firstname.Length != 0) {
        Firstname = other.Firstname;
      }
      if (other.Lastname.Length != 0) {
        Lastname = other.Lastname;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Firstname = input.ReadString();
            break;
          }
          case 18: {
            Lastname = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
