using System;
using System.Runtime.InteropServices;

// Token: 0x02000024 RID: 36
public class GClass0
{
	// Token: 0x060000E1 RID: 225 RVA: 0x5FF10AE4 File Offset: 0x5FF058E4
	public GClass0(byte[] byte_0)
	{
		uint num = 4U;
		uint[] array = new uint[2];
		this.uint_0 = new uint[32];
		uint num2 = 7U;
		array[1] = 0U;
		while (num2 != 4294967295U)
		{
			array[(int)(num2 / num)] = (array[(int)(num2 / num)] << 8) + (uint)byte_0[(int)num2];
			num2 -= 1U;
		}
		this.uint_0[0] = 435187059U;
		for (num2 = 1U; num2 < 32U; num2 += 1U)
		{
			this.uint_0[(int)num2] = this.uint_0[(int)(num2 - 1U)] + 1449465166U;
		}
		uint num3 = 0U;
		uint num4 = 0U;
		uint num5 = 0U;
		num2 = 0U;
		uint num6 = 0U;
		uint num7 = num3;
		while (num4 < 96U)
		{
			num7 = (this.uint_0[(int)num2] = GClass3.smethod_0(this.uint_0[(int)num2] + num7 + num6, 3));
			num6 = (array[(int)num5] = GClass3.smethod_0(array[(int)num5] + num7 + num6, (int)(num7 + num6)));
			num4 += 1U;
			num2 = (num2 + 1U) % 32U;
			num5 = (num5 + 1U) % 2U;
		}
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x5FF10BCC File Offset: 0x5FF059CC
	private void method_0(ref GClass0.Struct3 struct3_0)
	{
		uint num = struct3_0.uint_0 + this.uint_0[0];
		uint num2 = struct3_0.uint_1 + this.uint_0[1];
		for (uint num3 = 1U; num3 <= 15U; num3 += 1U)
		{
			num = GClass3.smethod_0(num ^ num2, (int)num2) + this.uint_0[(int)(2U * num3)];
			num2 = GClass3.smethod_0(num2 ^ num, (int)num) + this.uint_0[(int)(2U * num3 + 1U)];
		}
		struct3_0.uint_0 = num;
		struct3_0.uint_1 = num2;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x5FF10C40 File Offset: 0x5FF05A40
	private void method_1(ref GClass0.Struct3 struct3_0)
	{
		uint num = struct3_0.uint_1;
		uint num2 = struct3_0.uint_0;
		for (uint num3 = 15U; num3 > 0U; num3 -= 1U)
		{
			num = (GClass3.smethod_1(num - this.uint_0[(int)(2U * num3 + 1U)], (int)num2) ^ num2);
			num2 = (GClass3.smethod_1(num2 - this.uint_0[(int)(2U * num3)], (int)num) ^ num);
		}
		struct3_0.uint_1 = num - this.uint_0[1];
		struct3_0.uint_0 = num2 - this.uint_0[0];
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x5FF10CB4 File Offset: 0x5FF05AB4
	public byte[] method_2(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		this.method_4(byte_0, array);
		return array;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x5FF10CD4 File Offset: 0x5FF05AD4
	public byte[] method_3(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		this.method_5(byte_0, array);
		return array;
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x5FF10CF4 File Offset: 0x5FF05AF4
	public void method_4(byte[] byte_0, byte[] byte_1)
	{
		GClass0.Struct3 @struct = default(GClass0.Struct3);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			@struct.ulong_0 = BitConverter.ToUInt64(byte_0, i);
			this.method_0(ref @struct);
			BitConverter.GetBytes(@struct.ulong_0).CopyTo(byte_1, i);
		}
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x5FF10D40 File Offset: 0x5FF05B40
	public void method_5(byte[] byte_0, byte[] byte_1)
	{
		GClass0.Struct3 @struct = default(GClass0.Struct3);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			@struct.ulong_0 = BitConverter.ToUInt64(byte_0, i);
			this.method_1(ref @struct);
			BitConverter.GetBytes(@struct.ulong_0).CopyTo(byte_1, i);
		}
	}

	// Token: 0x0400030F RID: 783
	private const int int_0 = 15;

	// Token: 0x04000310 RID: 784
	private const int int_1 = 8;

	// Token: 0x04000311 RID: 785
	private const int int_2 = 2;

	// Token: 0x04000312 RID: 786
	private const int int_3 = 32;

	// Token: 0x04000313 RID: 787
	private readonly uint[] uint_0;

	// Token: 0x04000314 RID: 788
	private const uint uint_1 = 4207804417U;

	// Token: 0x04000315 RID: 789
	private const uint uint_2 = 4207804418U;

	// Token: 0x0200003E RID: 62
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct3
	{
		// Token: 0x040003A7 RID: 935
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x040003A8 RID: 936
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x040003A9 RID: 937
		[FieldOffset(4)]
		public uint uint_1;
	}
}
