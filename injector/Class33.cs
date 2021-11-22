using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000033 RID: 51
internal static class Class33
{
	// Token: 0x06000186 RID: 390
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, int int_5, int int_6, IntPtr intptr_3, int int_7, int int_8, IntPtr intptr_4);

	// Token: 0x06000187 RID: 391
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Class33.Enum2 enum2_0, int int_5, int int_6, string string_0);

	// Token: 0x06000188 RID: 392
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool FlushViewOfFile(IntPtr intptr_3, int int_5);

	// Token: 0x06000189 RID: 393
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Class33.Enum3 enum3_0, int int_5, int int_6, IntPtr intptr_4);

	// Token: 0x0600018A RID: 394
	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr OpenFileMapping(int int_5, bool bool_0, string string_0);

	// Token: 0x0600018B RID: 395
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	// Token: 0x0600018C RID: 396
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	// Token: 0x0600018D RID: 397
	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	// Token: 0x0600018E RID: 398
	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAlloc(IntPtr intptr_3, UIntPtr uintptr_0, Class33.Enum1 enum1_0, Class33.Enum2 enum2_0);

	// Token: 0x0600018F RID: 399
	[DllImport("kernel32")]
	public static extern bool VirtualFree(IntPtr intptr_3, uint uint_0, uint uint_1);

	// Token: 0x06000190 RID: 400
	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Class33.Enum2 enum2_0, out Class33.Enum2 enum2_1);

	// Token: 0x06000191 RID: 401
	[DllImport("kernel32")]
	public static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	// Token: 0x06000192 RID: 402
	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	// Token: 0x06000193 RID: 403
	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	// Token: 0x06000194 RID: 404
	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, byte[] byte_0, uint uint_0, out uint uint_1);

	// Token: 0x0400035B RID: 859
	public const int int_0 = -2147483648;

	// Token: 0x0400035C RID: 860
	public const int int_1 = 3;

	// Token: 0x0400035D RID: 861
	public const int int_2 = 128;

	// Token: 0x0400035E RID: 862
	public const int int_3 = 1;

	// Token: 0x0400035F RID: 863
	public const int int_4 = 2;

	// Token: 0x04000360 RID: 864
	public static readonly IntPtr intptr_0 = new IntPtr(-1);

	// Token: 0x04000361 RID: 865
	public static readonly IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x04000362 RID: 866
	public static readonly IntPtr intptr_2 = new IntPtr(-1);

	// Token: 0x02000065 RID: 101
	public enum Enum1 : uint
	{
		// Token: 0x040003DC RID: 988
		const_0 = 4096U,
		// Token: 0x040003DD RID: 989
		const_1 = 8192U
	}

	// Token: 0x02000066 RID: 102
	public enum Enum2 : uint
	{
		// Token: 0x040003DF RID: 991
		const_0 = 1U,
		// Token: 0x040003E0 RID: 992
		const_1,
		// Token: 0x040003E1 RID: 993
		const_2 = 4U,
		// Token: 0x040003E2 RID: 994
		const_3 = 8U,
		// Token: 0x040003E3 RID: 995
		const_4 = 16U,
		// Token: 0x040003E4 RID: 996
		const_5 = 32U,
		// Token: 0x040003E5 RID: 997
		const_6 = 64U,
		// Token: 0x040003E6 RID: 998
		const_7 = 256U
	}

	// Token: 0x02000067 RID: 103
	public enum Enum3 : uint
	{
		// Token: 0x040003E8 RID: 1000
		const_0 = 1U,
		// Token: 0x040003E9 RID: 1001
		const_1,
		// Token: 0x040003EA RID: 1002
		const_2 = 4U,
		// Token: 0x040003EB RID: 1003
		const_3 = 31U
	}

	// Token: 0x02000068 RID: 104
	public enum Enum4 : uint
	{
		// Token: 0x040003ED RID: 1005
		const_0 = 536870912U,
		// Token: 0x040003EE RID: 1006
		const_1 = 1073741824U,
		// Token: 0x040003EF RID: 1007
		const_2 = 2147483648U
	}

	// Token: 0x02000069 RID: 105
	public enum Enum5
	{
		// Token: 0x040003F1 RID: 1009
		const_0 = 1,
		// Token: 0x040003F2 RID: 1010
		const_1,
		// Token: 0x040003F3 RID: 1011
		const_2 = 4,
		// Token: 0x040003F4 RID: 1012
		const_3 = 8,
		// Token: 0x040003F5 RID: 1013
		const_4 = 16,
		// Token: 0x040003F6 RID: 1014
		const_5 = 32,
		// Token: 0x040003F7 RID: 1015
		const_6 = 512,
		// Token: 0x040003F8 RID: 1016
		const_7 = 256,
		// Token: 0x040003F9 RID: 1017
		const_8 = 768,
		// Token: 0x040003FA RID: 1018
		const_9 = 131097,
		// Token: 0x040003FB RID: 1019
		const_10 = 131078,
		// Token: 0x040003FC RID: 1020
		const_11 = 131097,
		// Token: 0x040003FD RID: 1021
		const_12 = 983103
	}

	// Token: 0x0200006A RID: 106
	internal static class Class34
	{
		// Token: 0x040003FE RID: 1022
		public static UIntPtr uintptr_0 = new UIntPtr(2147483650U);

		// Token: 0x040003FF RID: 1023
		public static UIntPtr uintptr_1 = new UIntPtr(2147483649U);
	}

	// Token: 0x0200006B RID: 107
	public static class Class35
	{
		// Token: 0x0600037B RID: 891
		[DllImport("advapi32")]
		private static extern uint RegOpenKeyEx(UIntPtr uintptr_0, string string_0, uint uint_0, int int_0, out UIntPtr uintptr_1);

		// Token: 0x0600037C RID: 892
		[DllImport("advapi32")]
		private static extern uint RegCloseKey(UIntPtr uintptr_0);

		// Token: 0x0600037D RID: 893
		[DllImport("advapi32")]
		private static extern int RegQueryValueEx(UIntPtr uintptr_0, string string_0, int int_0, ref uint uint_0, StringBuilder stringBuilder_0, ref uint uint_1);

		// Token: 0x0600037E RID: 894
		[DllImport("advapi32")]
		private static extern uint RegQueryInfoKey(UIntPtr uintptr_0, StringBuilder stringBuilder_0, ref uint uint_0, IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, IntPtr intptr_7, out long long_0);

		// Token: 0x0600037F RID: 895 RVA: 0x5FF0A989 File Offset: 0x5FEFF789
		public static string smethod_0(UIntPtr uintptr_0, string string_0, string string_1)
		{
			return Class33.Class35.smethod_3(uintptr_0, string_0, Class33.Enum5.const_7, string_1);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x5FF0A9A1 File Offset: 0x5FEFF7A1
		public static bool smethod_1(UIntPtr uintptr_0, string string_0, ref DateTime dateTime_0)
		{
			return Class33.Class35.smethod_2(uintptr_0, string_0, Class33.Enum5.const_7, ref dateTime_0);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x5FF1BA24 File Offset: 0x5FF10824
		public static bool smethod_2(UIntPtr uintptr_0, string string_0, Class33.Enum5 enum5_0, ref DateTime dateTime_0)
		{
			UIntPtr zero = UIntPtr.Zero;
			bool result;
			try
			{
				uint num = Class33.Class35.RegOpenKeyEx(uintptr_0, string_0, 0U, (int)(Class33.Enum5.const_0 | enum5_0), out zero);
				if (num != 0U)
				{
					result = false;
				}
				else
				{
					uint num2 = 0U;
					long fileTime;
					num = Class33.Class35.RegQueryInfoKey(zero, null, ref num2, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, out fileTime);
					if (num != 0U)
					{
						result = false;
					}
					else
					{
						dateTime_0 = DateTime.FromFileTime(fileTime);
						result = true;
					}
				}
			}
			finally
			{
				if (UIntPtr.Zero != zero)
				{
					Class33.Class35.RegCloseKey(zero);
				}
			}
			return result;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x5FF1BB18 File Offset: 0x5FF10918
		public static string smethod_3(UIntPtr uintptr_0, string string_0, Class33.Enum5 enum5_0, string string_1)
		{
			UIntPtr zero = UIntPtr.Zero;
			string result;
			try
			{
				uint num = Class33.Class35.RegOpenKeyEx(uintptr_0, string_0, 0U, (int)(Class33.Enum5.const_0 | enum5_0), out zero);
				if (num != 0U)
				{
					result = null;
				}
				else
				{
					uint num2 = 0U;
					uint num3 = 1024U;
					StringBuilder stringBuilder = new StringBuilder(1024);
					Class33.Class35.RegQueryValueEx(zero, string_1, 0, ref num2, stringBuilder, ref num3);
					result = stringBuilder.ToString();
				}
			}
			finally
			{
				if (UIntPtr.Zero != zero)
				{
					Class33.Class35.RegCloseKey(zero);
				}
			}
			return result;
		}
	}
}
