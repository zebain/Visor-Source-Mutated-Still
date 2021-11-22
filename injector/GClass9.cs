using System;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x0200002F RID: 47
public class GClass9
{
	// Token: 0x06000110 RID: 272 RVA: 0x5FF1158C File Offset: 0x5FF0638C
	public GClass9(long long_1)
	{
		object[] array = new object[]
		{
			this,
			long_1
		};
		new GClass15().method_112(array, 399988940);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x5FF115D8 File Offset: 0x5FF063D8
	public GClass9(byte[] byte_2)
	{
		object[] array = new object[]
		{
			this,
			byte_2
		};
		new GClass15().method_112(array, 67608);
	}

	// Token: 0x04000340 RID: 832
	private readonly byte[] byte_0;

	// Token: 0x04000341 RID: 833
	private byte[] byte_1;

	// Token: 0x04000342 RID: 834
	private readonly object object_0;

	// Token: 0x04000343 RID: 835
	private GEnum0 genum0_0;

	// Token: 0x04000344 RID: 836
	private long long_0;

	// Token: 0x04000345 RID: 837
	private readonly int int_0;

	// Token: 0x04000346 RID: 838
	private int int_1;

	// Token: 0x04000347 RID: 839
	private uint uint_0;

	// Token: 0x02000041 RID: 65
	public class GClass10
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x5FF18E84 File Offset: 0x5FF0DC84
		protected bool method_0(byte[] byte_0)
		{
			int num = BitConverter.ToInt32(byte_0, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(byte_0, 28);
			this.String_0 = Encoding.UTF8.GetString(byte_0, index, num);
			if (this.String_0[this.String_0.Length - 1] != '/')
			{
				this.String_0 += "/";
			}
			return true;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x5FF0A8EC File Offset: 0x5FEFF6EC
		protected void method_1()
		{
			this.String_0 = Convert.ToBase64String(Encoding.UTF8.GetBytes(this.String_0));
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x5FF0A90F File Offset: 0x5FEFF70F
		protected void method_2(string string_2, string string_3)
		{
			this.method_3(string_2, false);
			this.method_3(string_3, true);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x5FF18F2C File Offset: 0x5FF0DD2C
		private void method_3(string string_2, bool bool_0)
		{
			if (bool_0)
			{
				StringBuilder stringBuilder = new StringBuilder(this.String_0);
				foreach (char c in string_2)
				{
					if (c != '+')
					{
						if (c != '/')
						{
							if (c != '=')
							{
								stringBuilder.Append(c);
							}
							else
							{
								stringBuilder.Append("%3D");
							}
						}
						else
						{
							stringBuilder.Append("%2F");
						}
					}
					else
					{
						stringBuilder.Append("%2B");
					}
				}
				this.String_0 = stringBuilder.ToString();
				return;
			}
			this.String_0 += string_2;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x5FF0A935 File Offset: 0x5FEFF735
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x5FF0A940 File Offset: 0x5FEFF740
		public string String_0
		{
			get
			{
				return this.string_0;
			}
			private set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x5FF0A94F File Offset: 0x5FEFF74F
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x5FF0A95A File Offset: 0x5FEFF75A
		public string String_1
		{
			get
			{
				return this.string_1;
			}
			private set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x5FF1902C File Offset: 0x5FF0DE2C
		public unsafe static object smethod_0(void* pVoid_0)
		{
			return Pointer.Box(pVoid_0, typeof(void*));
		}

		// Token: 0x060001FB RID: 507 RVA: 0x5FF1904C File Offset: 0x5FF0DE4C
		public unsafe static void* smethod_1(object object_0)
		{
			return Pointer.Unbox(object_0);
		}

		// Token: 0x040003AF RID: 943
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040003B0 RID: 944
		[CompilerGenerated]
		private string string_1;

		// Token: 0x02000071 RID: 113
		[Serializable]
		private sealed class Class0
		{
			// Token: 0x06000395 RID: 917 RVA: 0x5FF11048 File Offset: 0x5FF05E48
			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}

			// Token: 0x0400040C RID: 1036
			public static readonly GClass9.GClass10.Class0 class0_0 = new GClass9.GClass10.Class0();

			// Token: 0x0400040D RID: 1037
			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
		}
	}

	// Token: 0x02000042 RID: 66
	public class GClass11 : GClass9.GClass10
	{
		// Token: 0x040003B1 RID: 945
		[CompilerGenerated]
		private string string_2;
	}

	// Token: 0x02000043 RID: 67
	public class GClass12 : GClass9.GClass10
	{
	}
}
