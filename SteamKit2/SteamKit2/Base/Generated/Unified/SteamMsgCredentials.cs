//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_credentials.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_TestAvailablePassword_Request")]
  public partial class CCredentials_TestAvailablePassword_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_TestAvailablePassword_Request() {}
    

    private string _password = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string password
    {
      get { return _password; }
      set { _password = value; }
    }

    private byte[] _sha_digest_password = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sha_digest_password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] sha_digest_password
    {
      get { return _sha_digest_password; }
      set { _sha_digest_password = value; }
    }

    private string _account_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"account_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string account_name
    {
      get { return _account_name; }
      set { _account_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_TestAvailablePassword_Response")]
  public partial class CCredentials_TestAvailablePassword_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_TestAvailablePassword_Response() {}
    

    private bool _is_valid = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"is_valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_valid
    {
      get { return _is_valid; }
      set { _is_valid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_GetSteamGuardDetails_Request")]
  public partial class CCredentials_GetSteamGuardDetails_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_GetSteamGuardDetails_Request() {}
    

    private bool _include_new_authentications = (bool)true;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"include_new_authentications", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool include_new_authentications
    {
      get { return _include_new_authentications; }
      set { _include_new_authentications = value; }
    }

    private string _webcookie = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"webcookie", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string webcookie
    {
      get { return _webcookie; }
      set { _webcookie = value; }
    }

    private uint _timestamp_minimum_wanted = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"timestamp_minimum_wanted", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp_minimum_wanted
    {
      get { return _timestamp_minimum_wanted; }
      set { _timestamp_minimum_wanted = value; }
    }

    private int _ipaddress = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ipaddress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ipaddress
    {
      get { return _ipaddress; }
      set { _ipaddress = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_GetSteamGuardDetails_Response")]
  public partial class CCredentials_GetSteamGuardDetails_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_GetSteamGuardDetails_Response() {}
    

    private bool _is_steamguard_enabled = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"is_steamguard_enabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_steamguard_enabled
    {
      get { return _is_steamguard_enabled; }
      set { _is_steamguard_enabled = value; }
    }

    private uint _timestamp_steamguard_enabled = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"timestamp_steamguard_enabled", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp_steamguard_enabled
    {
      get { return _timestamp_steamguard_enabled; }
      set { _timestamp_steamguard_enabled = value; }
    }
    private readonly global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.NewAuthentication> _deprecated_newauthentication = new global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.NewAuthentication>();
    [global::ProtoBuf.ProtoMember(3, Name=@"deprecated_newauthentication", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.NewAuthentication> deprecated_newauthentication
    {
      get { return _deprecated_newauthentication; }
    }
  

    private string _deprecated_machine_name_userchosen = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"deprecated_machine_name_userchosen", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string deprecated_machine_name_userchosen
    {
      get { return _deprecated_machine_name_userchosen; }
      set { _deprecated_machine_name_userchosen = value; }
    }

    private uint _deprecated_timestamp_machine_steamguard_enabled = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"deprecated_timestamp_machine_steamguard_enabled", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint deprecated_timestamp_machine_steamguard_enabled
    {
      get { return _deprecated_timestamp_machine_steamguard_enabled; }
      set { _deprecated_timestamp_machine_steamguard_enabled = value; }
    }

    private bool _deprecated_authentication_exists_from_geoloc_before_mintime = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"deprecated_authentication_exists_from_geoloc_before_mintime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool deprecated_authentication_exists_from_geoloc_before_mintime
    {
      get { return _deprecated_authentication_exists_from_geoloc_before_mintime; }
      set { _deprecated_authentication_exists_from_geoloc_before_mintime = value; }
    }

    private ulong _deprecated_machine_id = default(ulong);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"deprecated_machine_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong deprecated_machine_id
    {
      get { return _deprecated_machine_id; }
      set { _deprecated_machine_id = value; }
    }
    private readonly global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.SessionData> _session_data = new global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.SessionData>();
    [global::ProtoBuf.ProtoMember(8, Name=@"session_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.SessionData> session_data
    {
      get { return _session_data; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NewAuthentication")]
  public partial class NewAuthentication : global::ProtoBuf.IExtensible
  {
    public NewAuthentication() {}
    

    private uint _timestamp_steamguard_enabled = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"timestamp_steamguard_enabled", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp_steamguard_enabled
    {
      get { return _timestamp_steamguard_enabled; }
      set { _timestamp_steamguard_enabled = value; }
    }

    private bool _is_web_cookie = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"is_web_cookie", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_web_cookie
    {
      get { return _is_web_cookie; }
      set { _is_web_cookie = value; }
    }

    private int _ipaddress = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ipaddress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ipaddress
    {
      get { return _ipaddress; }
      set { _ipaddress = value; }
    }

    private string _geoloc_info = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"geoloc_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string geoloc_info
    {
      get { return _geoloc_info; }
      set { _geoloc_info = value; }
    }

    private bool _is_remembered = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"is_remembered", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_remembered
    {
      get { return _is_remembered; }
      set { _is_remembered = value; }
    }

    private string _machine_name_user_supplied = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"machine_name_user_supplied", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string machine_name_user_supplied
    {
      get { return _machine_name_user_supplied; }
      set { _machine_name_user_supplied = value; }
    }

    private int _status = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SessionData")]
  public partial class SessionData : global::ProtoBuf.IExtensible
  {
    public SessionData() {}
    

    private ulong _machine_id = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"machine_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong machine_id
    {
      get { return _machine_id; }
      set { _machine_id = value; }
    }

    private string _machine_name_userchosen = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"machine_name_userchosen", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string machine_name_userchosen
    {
      get { return _machine_name_userchosen; }
      set { _machine_name_userchosen = value; }
    }

    private uint _timestamp_machine_steamguard_enabled = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"timestamp_machine_steamguard_enabled", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp_machine_steamguard_enabled
    {
      get { return _timestamp_machine_steamguard_enabled; }
      set { _timestamp_machine_steamguard_enabled = value; }
    }

    private bool _authentication_exists_from_geoloc_before_mintime = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"authentication_exists_from_geoloc_before_mintime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool authentication_exists_from_geoloc_before_mintime
    {
      get { return _authentication_exists_from_geoloc_before_mintime; }
      set { _authentication_exists_from_geoloc_before_mintime = value; }
    }
    private readonly global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.NewAuthentication> _newauthentication = new global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.NewAuthentication>();
    [global::ProtoBuf.ProtoMember(5, Name=@"newauthentication", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CCredentials_GetSteamGuardDetails_Response.NewAuthentication> newauthentication
    {
      get { return _newauthentication; }
    }
  

    private bool _authentication_exists_from_same_ip_before_mintime = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"authentication_exists_from_same_ip_before_mintime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool authentication_exists_from_same_ip_before_mintime
    {
      get { return _authentication_exists_from_same_ip_before_mintime; }
      set { _authentication_exists_from_same_ip_before_mintime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_NewMachineNotificationDialog_Request")]
  public partial class CCredentials_NewMachineNotificationDialog_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_NewMachineNotificationDialog_Request() {}
    

    private bool _is_approved = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"is_approved", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_approved
    {
      get { return _is_approved; }
      set { _is_approved = value; }
    }

    private bool _is_wizard_complete = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"is_wizard_complete", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_wizard_complete
    {
      get { return _is_wizard_complete; }
      set { _is_wizard_complete = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_NewMachineNotificationDialog_Response")]
  public partial class CCredentials_NewMachineNotificationDialog_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_NewMachineNotificationDialog_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_ValidateEmailAddress_Request")]
  public partial class CCredentials_ValidateEmailAddress_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_ValidateEmailAddress_Request() {}
    

    private string _stoken = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"stoken", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string stoken
    {
      get { return _stoken; }
      set { _stoken = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_ValidateEmailAddress_Response")]
  public partial class CCredentials_ValidateEmailAddress_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_ValidateEmailAddress_Response() {}
    

    private bool _was_validated = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"was_validated", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool was_validated
    {
      get { return _was_validated; }
      set { _was_validated = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_SteamGuardPhishingReport_Request")]
  public partial class CCredentials_SteamGuardPhishingReport_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_SteamGuardPhishingReport_Request() {}
    

    private string _param_string = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"param_string", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string param_string
    {
      get { return _param_string; }
      set { _param_string = value; }
    }

    private uint _ipaddress_actual = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ipaddress_actual", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ipaddress_actual
    {
      get { return _ipaddress_actual; }
      set { _ipaddress_actual = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_SteamGuardPhishingReport_Response")]
  public partial class CCredentials_SteamGuardPhishingReport_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_SteamGuardPhishingReport_Response() {}
    

    private uint _ipaddress_loginattempt = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ipaddress_loginattempt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ipaddress_loginattempt
    {
      get { return _ipaddress_loginattempt; }
      set { _ipaddress_loginattempt = value; }
    }

    private string _countryname_loginattempt = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"countryname_loginattempt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string countryname_loginattempt
    {
      get { return _countryname_loginattempt; }
      set { _countryname_loginattempt = value; }
    }

    private string _statename_loginattempt = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"statename_loginattempt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string statename_loginattempt
    {
      get { return _statename_loginattempt; }
      set { _statename_loginattempt = value; }
    }

    private string _cityname_loginattempt = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"cityname_loginattempt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cityname_loginattempt
    {
      get { return _cityname_loginattempt; }
      set { _cityname_loginattempt = value; }
    }

    private uint _ipaddress_actual = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ipaddress_actual", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ipaddress_actual
    {
      get { return _ipaddress_actual; }
      set { _ipaddress_actual = value; }
    }

    private string _countryname_actual = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"countryname_actual", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string countryname_actual
    {
      get { return _countryname_actual; }
      set { _countryname_actual = value; }
    }

    private string _statename_actual = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"statename_actual", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string statename_actual
    {
      get { return _statename_actual; }
      set { _statename_actual = value; }
    }

    private string _cityname_actual = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"cityname_actual", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cityname_actual
    {
      get { return _cityname_actual; }
      set { _cityname_actual = value; }
    }

    private string _steamguard_code = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"steamguard_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string steamguard_code
    {
      get { return _steamguard_code; }
      set { _steamguard_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_AccountLockRequest_Request")]
  public partial class CCredentials_AccountLockRequest_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_AccountLockRequest_Request() {}
    

    private string _param_string = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"param_string", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string param_string
    {
      get { return _param_string; }
      set { _param_string = value; }
    }

    private uint _ipaddress_actual = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ipaddress_actual", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ipaddress_actual
    {
      get { return _ipaddress_actual; }
      set { _ipaddress_actual = value; }
    }

    private bool _query_only = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"query_only", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool query_only
    {
      get { return _query_only; }
      set { _query_only = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_AccountLockRequest_Response")]
  public partial class CCredentials_AccountLockRequest_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_AccountLockRequest_Response() {}
    

    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }

    private bool _account_already_locked = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"account_already_locked", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool account_already_locked
    {
      get { return _account_already_locked; }
      set { _account_already_locked = value; }
    }

    private bool _expired_link = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"expired_link", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool expired_link
    {
      get { return _expired_link; }
      set { _expired_link = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_SteamGuardCode_Request")]
  public partial class CCredentials_SteamGuardCode_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_SteamGuardCode_Request() {}
    

    private bool _panic_button = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"panic_button", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool panic_button
    {
      get { return _panic_button; }
      set { _panic_button = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_SteamGuardCode_Response")]
  public partial class CCredentials_SteamGuardCode_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_SteamGuardCode_Response() {}
    

    private string _steamguard_code = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamguard_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string steamguard_code
    {
      get { return _steamguard_code; }
      set { _steamguard_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_LastCredentialChangeTime_Request")]
  public partial class CCredentials_LastCredentialChangeTime_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_LastCredentialChangeTime_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_LastCredentialChangeTime_Response")]
  public partial class CCredentials_LastCredentialChangeTime_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_LastCredentialChangeTime_Response() {}
    

    private uint _timestamp_last_password_change = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"timestamp_last_password_change", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp_last_password_change
    {
      get { return _timestamp_last_password_change; }
      set { _timestamp_last_password_change = value; }
    }

    private uint _timestamp_last_email_change = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"timestamp_last_email_change", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp_last_email_change
    {
      get { return _timestamp_last_email_change; }
      set { _timestamp_last_email_change = value; }
    }

    private uint _timestamp_last_password_reset = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"timestamp_last_password_reset", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp_last_password_reset
    {
      get { return _timestamp_last_password_reset; }
      set { _timestamp_last_password_reset = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_GetAccountAuthSecret_Request")]
  public partial class CCredentials_GetAccountAuthSecret_Request : global::ProtoBuf.IExtensible
  {
    public CCredentials_GetAccountAuthSecret_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_GetAccountAuthSecret_Response")]
  public partial class CCredentials_GetAccountAuthSecret_Response : global::ProtoBuf.IExtensible
  {
    public CCredentials_GetAccountAuthSecret_Response() {}
    

    private int _secret_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"secret_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int secret_id
    {
      get { return _secret_id; }
      set { _secret_id = value; }
    }

    private byte[] _secret = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"secret", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] secret
    {
      get { return _secret; }
      set { _secret = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CCredentials_SteamGuardLoginAttempt_Notification")]
  public partial class CCredentials_SteamGuardLoginAttempt_Notification : global::ProtoBuf.IExtensible
  {
    public CCredentials_SteamGuardLoginAttempt_Notification() {}
    

    private bool _is_web_cookie = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"is_web_cookie", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_web_cookie
    {
      get { return _is_web_cookie; }
      set { _is_web_cookie = value; }
    }

    private int _ipaddress = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ipaddress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ipaddress
    {
      get { return _ipaddress; }
      set { _ipaddress = value; }
    }

    private string _geoloc_info = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"geoloc_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string geoloc_info
    {
      get { return _geoloc_info; }
      set { _geoloc_info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface ICredentials
    {
      CCredentials_TestAvailablePassword_Response TestAvailablePassword(CCredentials_TestAvailablePassword_Request request);
    CCredentials_GetSteamGuardDetails_Response GetSteamGuardDetails(CCredentials_GetSteamGuardDetails_Request request);
    CCredentials_NewMachineNotificationDialog_Response NewMachineNotificationDialogResult(CCredentials_NewMachineNotificationDialog_Request request);
    CCredentials_ValidateEmailAddress_Response ValidateEmailAddress(CCredentials_ValidateEmailAddress_Request request);
    CCredentials_SteamGuardPhishingReport_Response SteamGuardPhishingReport(CCredentials_SteamGuardPhishingReport_Request request);
    CCredentials_AccountLockRequest_Response AccountLockRequest(CCredentials_AccountLockRequest_Request request);
    CCredentials_SteamGuardCode_Response SteamGuardCodeProcess(CCredentials_SteamGuardCode_Request request);
    CCredentials_LastCredentialChangeTime_Response GetCredentialChangeTimeDetails(CCredentials_LastCredentialChangeTime_Request request);
    CCredentials_GetAccountAuthSecret_Response GetAccountAuthSecret(CCredentials_GetAccountAuthSecret_Request request);
    
    }
    
    
    public interface ICredentialsClient
    {
      NoResponse NotifySteamGuardLoginAttempt(CCredentials_SteamGuardLoginAttempt_Notification request);
    
    }
    
    
}
#pragma warning restore 1591
