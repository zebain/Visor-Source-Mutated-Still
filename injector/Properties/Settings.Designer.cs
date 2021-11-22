using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace injector.Properties
{
	// Token: 0x0200000C RID: 12
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000089 RID: 137 RVA: 0x5FF0FC10 File Offset: 0x5FF04A10
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008A RID: 138 RVA: 0x5FF0FC2C File Offset: 0x5FF04A2C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x5FF0FC70 File Offset: 0x5FF04A70
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string Login
		{
			get
			{
				object[] object_ = new object[]
				{
					this
				};
				return new GClass15().method_112(object_, 399978956);
			}
			set
			{
				object[] object_ = new object[]
				{
					this,
					value
				};
				new GClass15().method_112(object_, 400012206);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008C RID: 140 RVA: 0x5FF0FCB8 File Offset: 0x5FF04AB8
		// (set) Token: 0x0600008D RID: 141 RVA: 0x5FF0A182 File Offset: 0x5FEFEF82
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008E RID: 142 RVA: 0x5FF0FCE0 File Offset: 0x5FF04AE0
		// (set) Token: 0x0600008F RID: 143 RVA: 0x5FF0A196 File Offset: 0x5FEFEF96
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string Directory
		{
			get
			{
				return (string)this["Directory"];
			}
			set
			{
				this["Directory"] = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000090 RID: 144 RVA: 0x5FF0FD08 File Offset: 0x5FF04B08
		// (set) Token: 0x06000091 RID: 145 RVA: 0x5FF0A1AA File Offset: 0x5FEFEFAA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Clearlog
		{
			get
			{
				return (string)this["Clearlog"];
			}
			set
			{
				this["Clearlog"] = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000092 RID: 146 RVA: 0x5FF0FD30 File Offset: 0x5FF04B30
		// (set) Token: 0x06000093 RID: 147 RVA: 0x5FF0A1BE File Offset: 0x5FEFEFBE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string NorecoilDirectory
		{
			get
			{
				return (string)this["NorecoilDirectory"];
			}
			set
			{
				this["NorecoilDirectory"] = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000094 RID: 148 RVA: 0x5FF0FD58 File Offset: 0x5FF04B58
		// (set) Token: 0x06000095 RID: 149 RVA: 0x5FF0A1D2 File Offset: 0x5FEFEFD2
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool CheckBox
		{
			get
			{
				return (bool)this["CheckBox"];
			}
			set
			{
				this["CheckBox"] = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000096 RID: 150 RVA: 0x5FF0FD78 File Offset: 0x5FF04B78
		// (set) Token: 0x06000097 RID: 151 RVA: 0x5FF0A1EB File Offset: 0x5FEFEFEB
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string bettervisibility
		{
			get
			{
				return (string)this["bettervisibility"];
			}
			set
			{
				this["bettervisibility"] = value;
			}
		}

		// Token: 0x04000083 RID: 131
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
