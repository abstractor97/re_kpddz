//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Notice.proto
namespace Msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CS_CTalkRequest")]
  public partial class CS_CTalkRequest : global::ProtoBuf.IExtensible
  {
    public CS_CTalkRequest() {}
    
    private string _userId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"userId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string userId
    {
      get { return _userId; }
      set { _userId = value; }
    }
    private string _content;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SC_CTalkResponse")]
  public partial class SC_CTalkResponse : global::ProtoBuf.IExtensible
  {
    public SC_CTalkResponse() {}
    
    private string _sender;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"sender", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string sender
    {
      get { return _sender; }
      set { _sender = value; }
    }
    private string _content;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SC_CNoticeWithLampResponse")]
  public partial class SC_CNoticeWithLampResponse : global::ProtoBuf.IExtensible
  {
    public SC_CNoticeWithLampResponse() {}
    
    private string _content;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}