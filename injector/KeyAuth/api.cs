using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000003 RID: 3
	public class api
	{
		// Token: 0x06000007 RID: 7 RVA: 0x5FF0AD28 File Offset: 0x5FEFFB28
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				MessageBox.Show("Application not setup correctly. Please watch video link found in Login.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x5FF0ADDC File Offset: 0x5FEFFBDC
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			if (text2 == "KeyAuth_Invalid")
			{
				MessageBox.Show("Application not found.");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			if (response_structure.success)
			{
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else if (response_structure.message == "invalidver")
			{
				Process.Start(response_structure.download);
				Environment.Exit(0);
			}
			else
			{
				MessageBox.Show(response_structure.message);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x5FF0AFAC File Offset: 0x5FEFFDAC
		public bool register(string username, string pass, string key)
		{
			bool result;
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				if (!response_structure.success)
				{
					MessageBox.Show(response_structure.message);
					result = false;
				}
				else
				{
					this.load_user_data(response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x5FF0B1B4 File Offset: 0x5FEFFFB4
		public bool login(string username, string pass)
		{
			object[] object_ = new object[]
			{
				this,
				username,
				pass
			};
			return (bool)new GClass15().method_112(object_, 104222);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x5FF0B208 File Offset: 0x5FF00008
		public void upgrade(string username, string key)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
				nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				if (!response_structure.success)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
				}
				else
				{
					MessageBox.Show(response_structure.message);
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x5FF0B3B0 File Offset: 0x5FF001B0
		public bool license(string key)
		{
			bool result;
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				result = false;
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
				nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
				nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				if (!response_structure.success)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
					result = false;
				}
				else
				{
					this.load_user_data(response_structure.info);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x5FF0B580 File Offset: 0x5FF00380
		public void ban()
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				if (!response_structure.success)
				{
					MessageBox.Show(response_structure.message);
					Environment.Exit(0);
				}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x5FF0B6C8 File Offset: 0x5FF004C8
		public string var(string varid)
		{
			string result;
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				result = "";
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
				nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				if (!response_structure.success)
				{
					MessageBox.Show(response_structure.message);
					result = "";
				}
				else
				{
					result = response_structure.message;
				}
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x5FF0B85C File Offset: 0x5FF0065C
		public void webhook(string webid, string param)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string value = WindowsIdentity.GetCurrent().User.Value;
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
				nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
				nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				if (!response_structure.success)
				{
					MessageBox.Show(response_structure.message);
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x5FF0B9EC File Offset: 0x5FF007EC
		public byte[] download(string fileid)
		{
			byte[] result;
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
				result = new byte[0];
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
				nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				string text2 = api.req(post_data);
				text2 = encryption.decrypt(text2, this.enckey, text);
				api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
				if (!response_structure.success)
				{
					MessageBox.Show(response_structure.message);
				}
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x5FF0BB6C File Offset: 0x5FF0096C
		public void log(string message)
		{
			if (!this.initzalized)
			{
				MessageBox.Show("Please initzalize first");
			}
			else
			{
				string text = encryption.sha256(encryption.iv_key());
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
				nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
				nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
				nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
				nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
				nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
				nameValueCollection["init_iv"] = text;
				NameValueCollection post_data = nameValueCollection;
				api.req(post_data);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x5FF0BC98 File Offset: 0x5FF00A98
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.business/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch
			{
				MessageBox.Show("Connection failure. Please try again, or contact us for help.");
				Thread.Sleep(3500);
				Environment.Exit(0);
				result = "nothing";
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x5FF0BD34 File Offset: 0x5FF00B34
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x04000004 RID: 4
		public string name;

		// Token: 0x04000005 RID: 5
		public string ownerid;

		// Token: 0x04000006 RID: 6
		public string secret;

		// Token: 0x04000007 RID: 7
		public string version;

		// Token: 0x04000008 RID: 8
		public string checker;

		// Token: 0x04000009 RID: 9
		private string sessionid;

		// Token: 0x0400000A RID: 10
		private string enckey;

		// Token: 0x0400000B RID: 11
		private bool initzalized;

		// Token: 0x0400000C RID: 12
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000D RID: 13
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200001D RID: 29
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000BF RID: 191 RVA: 0x5FF0A247 File Offset: 0x5FEFF047
			// (set) Token: 0x060000C0 RID: 192 RVA: 0x5FF0A252 File Offset: 0x5FEFF052
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x5FF0A261 File Offset: 0x5FEFF061
			// (set) Token: 0x060000C2 RID: 194 RVA: 0x5FF0A26C File Offset: 0x5FEFF06C
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x5FF0A27B File Offset: 0x5FEFF07B
			// (set) Token: 0x060000C4 RID: 196 RVA: 0x5FF0A286 File Offset: 0x5FEFF086
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x5FF0A295 File Offset: 0x5FEFF095
			// (set) Token: 0x060000C6 RID: 198 RVA: 0x5FF0A2A0 File Offset: 0x5FEFF0A0
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x5FF0A2AF File Offset: 0x5FEFF0AF
			// (set) Token: 0x060000C8 RID: 200 RVA: 0x5FF0A2BA File Offset: 0x5FEFF0BA
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000C9 RID: 201 RVA: 0x5FF0A2C9 File Offset: 0x5FEFF0C9
			// (set) Token: 0x060000CA RID: 202 RVA: 0x5FF0A2D4 File Offset: 0x5FEFF0D4
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000CB RID: 203 RVA: 0x5FF0A2E3 File Offset: 0x5FEFF0E3
			// (set) Token: 0x060000CC RID: 204 RVA: 0x5FF0A2EE File Offset: 0x5FEFF0EE
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }
		}

		// Token: 0x0200001E RID: 30
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000CE RID: 206 RVA: 0x5FF0A2FD File Offset: 0x5FEFF0FD
			// (set) Token: 0x060000CF RID: 207 RVA: 0x5FF0A308 File Offset: 0x5FEFF108
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x5FF0A317 File Offset: 0x5FEFF117
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x5FF0A322 File Offset: 0x5FEFF122
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x5FF0A331 File Offset: 0x5FEFF131
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x5FF0A33C File Offset: 0x5FEFF13C
			[DataMember]
			public string ip { get; set; }
		}

		// Token: 0x0200001F RID: 31
		public class user_data_class
		{
			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x5FF0A34B File Offset: 0x5FEFF14B
			// (set) Token: 0x060000D6 RID: 214 RVA: 0x5FF0A356 File Offset: 0x5FEFF156
			public string username
			{
				[CompilerGenerated]
				get
				{
					return this.<username>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<username>k__BackingField = value;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000D7 RID: 215 RVA: 0x5FF0A365 File Offset: 0x5FEFF165
			// (set) Token: 0x060000D8 RID: 216 RVA: 0x5FF0A370 File Offset: 0x5FEFF170
			public List<api.Data> subscriptions
			{
				[CompilerGenerated]
				get
				{
					return this.<subscriptions>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<subscriptions>k__BackingField = value;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x5FF0A37F File Offset: 0x5FEFF17F
			// (set) Token: 0x060000DA RID: 218 RVA: 0x5FF0A38A File Offset: 0x5FEFF18A
			public string ip
			{
				[CompilerGenerated]
				get
				{
					return this.<ip>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<ip>k__BackingField = value;
				}
			}

			// Token: 0x0400030A RID: 778
			private string <username>k__BackingField;

			// Token: 0x0400030B RID: 779
			private List<api.Data> <subscriptions>k__BackingField;

			// Token: 0x0400030C RID: 780
			private string <ip>k__BackingField;
		}

		// Token: 0x02000020 RID: 32
		public class Data
		{
			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000DC RID: 220 RVA: 0x5FF0A399 File Offset: 0x5FEFF199
			// (set) Token: 0x060000DD RID: 221 RVA: 0x5FF0A3A4 File Offset: 0x5FEFF1A4
			public string subscription
			{
				[CompilerGenerated]
				get
				{
					return this.<subscription>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<subscription>k__BackingField = value;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000DE RID: 222 RVA: 0x5FF0A3B3 File Offset: 0x5FEFF1B3
			// (set) Token: 0x060000DF RID: 223 RVA: 0x5FF0A3BE File Offset: 0x5FEFF1BE
			public string expiry
			{
				[CompilerGenerated]
				get
				{
					return this.<expiry>k__BackingField;
				}
				[CompilerGenerated]
				set
				{
					this.<expiry>k__BackingField = value;
				}
			}

			// Token: 0x0400030D RID: 781
			private string <subscription>k__BackingField;

			// Token: 0x0400030E RID: 782
			private string <expiry>k__BackingField;
		}
	}
}
