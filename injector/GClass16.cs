using System;
using System.IO;

// Token: 0x02000038 RID: 56
public class GClass16
{
	// Token: 0x060001D3 RID: 467 RVA: 0x5FF183B4 File Offset: 0x5FF0D1B4
	public GClass16()
	{
		this.uint_1 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.struct9_0[num] = new Struct9(6);
			num++;
		}
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x5FF1851C File Offset: 0x5FF0D31C
	private void method_0(uint uint_4)
	{
		if (this.uint_1 != uint_4)
		{
			this.uint_1 = uint_4;
			this.uint_2 = Math.Max(this.uint_1, 1U);
			uint uint_5 = Math.Max(this.uint_2, 4096U);
			this.gclass17_0.method_0(uint_5);
		}
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x5FF1858C File Offset: 0x5FF0D38C
	private void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.class39_0.method_0(int_0, int_1);
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x5FF185DC File Offset: 0x5FF0D3DC
	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << int_0;
		this.class38_0.method_0(num);
		this.class38_1.method_0(num);
		this.uint_3 = num - 1U;
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x5FF1864C File Offset: 0x5FF0D44C
	private void method_3(Stream stream_0, Stream stream_1)
	{
		this.class40_0.method_0(stream_0);
		this.gclass17_0.method_1(stream_1, false);
		for (;;)
		{
			for (uint num = 0U; num <= this.uint_3; num += 1U)
			{
				uint num2 = 0U + num;
				this.struct8_0[(int)num2].method_0();
				this.struct8_5[(int)num2].method_0();
			}
			this.struct8_1[0].method_0();
			this.struct8_2[0].method_0();
			this.struct8_3[0].method_0();
			this.struct8_4[0].method_0();
		}
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x5FF0A0F7 File Offset: 0x5FEFEEF7
	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x5FF186F0 File Offset: 0x5FF0D4F0
	public void method_5(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int int_ = (int)(byte_0[0] % 9);
		byte b = byte_0[0] / 9;
		int int_2 = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)byte_0[1 + i] << i * 8);
		}
		this.method_0(num2);
		this.method_1(int_2, int_);
		this.method_2(num);
	}

	// Token: 0x04000381 RID: 897
	private uint uint_0 = 1U;

	// Token: 0x04000382 RID: 898
	private readonly GClass17 gclass17_0 = new GClass17();

	// Token: 0x04000383 RID: 899
	private readonly Class40 class40_0 = new Class40();

	// Token: 0x04000384 RID: 900
	private readonly Struct8[] struct8_0 = new Struct8[192];

	// Token: 0x04000385 RID: 901
	private readonly Struct8[] struct8_1 = new Struct8[12];

	// Token: 0x04000386 RID: 902
	private readonly Struct8[] struct8_2 = new Struct8[12];

	// Token: 0x04000387 RID: 903
	private readonly Struct8[] struct8_3 = new Struct8[12];

	// Token: 0x04000388 RID: 904
	private readonly Struct8[] struct8_4 = new Struct8[12];

	// Token: 0x04000389 RID: 905
	private readonly Struct8[] struct8_5 = new Struct8[192];

	// Token: 0x0400038A RID: 906
	private readonly Struct9[] struct9_0 = new Struct9[4];

	// Token: 0x0400038B RID: 907
	private readonly Struct8[] struct8_6 = new Struct8[114];

	// Token: 0x0400038C RID: 908
	private Struct9 struct9_1 = new Struct9(4);

	// Token: 0x0400038D RID: 909
	private readonly GClass16.Class38 class38_0 = new GClass16.Class38();

	// Token: 0x0400038E RID: 910
	private readonly GClass16.Class38 class38_1 = new GClass16.Class38();

	// Token: 0x0400038F RID: 911
	private readonly GClass16.Class39 class39_0 = new GClass16.Class39();

	// Token: 0x04000390 RID: 912
	private uint uint_1;

	// Token: 0x04000391 RID: 913
	private uint uint_2;

	// Token: 0x04000392 RID: 914
	private uint uint_3;

	// Token: 0x0200006D RID: 109
	private class Class38
	{
		// Token: 0x06000389 RID: 905 RVA: 0x5FF1BC4C File Offset: 0x5FF10A4C
		public void method_0(uint uint_1)
		{
			for (uint num = this.uint_0; num < uint_1; num += 1U)
			{
				this.struct9_0[(int)num] = new Struct9(3);
				this.struct9_1[(int)num] = new Struct9(3);
			}
			this.uint_0 = uint_1;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x5FF1BCC8 File Offset: 0x5FF10AC8
		public void method_1()
		{
			this.struct8_0.method_0();
			while (0U < this.uint_0)
			{
				this.struct9_0[0].method_0();
				this.struct9_1[0].method_0();
			}
			this.struct8_1.method_0();
			this.struct9_2.method_0();
		}

		// Token: 0x0600038B RID: 907 RVA: 0x5FF1BD24 File Offset: 0x5FF10B24
		public uint method_2(Class40 class40_0, uint uint_1)
		{
			if (this.struct8_0.method_1(class40_0) == 0U)
			{
				return this.struct9_0[(int)uint_1].method_1(class40_0);
			}
			uint num = 8U;
			if (this.struct8_1.method_1(class40_0) == 0U)
			{
				num += this.struct9_1[(int)uint_1].method_1(class40_0);
			}
			else
			{
				num += 8U;
				num += this.struct9_2.method_1(class40_0);
			}
			return num;
		}

		// Token: 0x04000401 RID: 1025
		private Struct8 struct8_0;

		// Token: 0x04000402 RID: 1026
		private Struct8 struct8_1;

		// Token: 0x04000403 RID: 1027
		private readonly Struct9[] struct9_0 = new Struct9[16];

		// Token: 0x04000404 RID: 1028
		private readonly Struct9[] struct9_1 = new Struct9[16];

		// Token: 0x04000405 RID: 1029
		private Struct9 struct9_2 = new Struct9(8);

		// Token: 0x04000406 RID: 1030
		private uint uint_0;
	}

	// Token: 0x0200006E RID: 110
	private class Class39
	{
		// Token: 0x0600038D RID: 909 RVA: 0x5FF1BE24 File Offset: 0x5FF10C24
		public void method_0(int int_2, int int_3)
		{
			if (this.struct7_0 != null && this.int_0 == int_3 && this.int_1 == int_2)
			{
				return;
			}
			this.int_1 = int_2;
			this.uint_1 = (1U << int_2) - 1U;
			this.int_0 = int_3;
			uint num = 1U << this.int_0 + this.int_1;
			this.struct7_0 = new GClass16.Class39.Struct7[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.struct7_0[(int)num2].method_0();
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x5FF1BEAC File Offset: 0x5FF10CAC
		public void method_1()
		{
			uint num = 1U << this.int_0 + this.int_1;
			while (0U < num)
			{
				this.struct7_0[0].method_1();
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x5FF0AA50 File Offset: 0x5FEFF850
		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & this.uint_1) << this.int_0) + (uint)(byte_0 >> 8 - this.int_0);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x5FF0AA8B File Offset: 0x5FEFF88B
		public byte method_3(Class40 class40_0, uint uint_2, byte byte_0)
		{
			return this.struct7_0[(int)this.method_2(uint_2, byte_0)].method_2(class40_0);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x5FF0AAB5 File Offset: 0x5FEFF8B5
		public byte method_4(Class40 class40_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return this.struct7_0[(int)this.method_2(uint_2, byte_0)].method_3(class40_0, byte_1);
		}

		// Token: 0x04000407 RID: 1031
		private uint uint_0 = 1U;

		// Token: 0x04000408 RID: 1032
		private GClass16.Class39.Struct7[] struct7_0;

		// Token: 0x04000409 RID: 1033
		private int int_0;

		// Token: 0x0400040A RID: 1034
		private int int_1;

		// Token: 0x0400040B RID: 1035
		private uint uint_1;

		// Token: 0x02000072 RID: 114
		private struct Struct7
		{
			// Token: 0x06000396 RID: 918 RVA: 0x5FF0AB08 File Offset: 0x5FEFF908
			public void method_0()
			{
				this.struct8_0 = new Struct8[768];
			}

			// Token: 0x06000397 RID: 919 RVA: 0x5FF1BEE4 File Offset: 0x5FF10CE4
			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					this.struct8_0[i].method_0();
				}
			}

			// Token: 0x06000398 RID: 920 RVA: 0x5FF1BF2C File Offset: 0x5FF10D2C
			public byte method_2(Class40 class40_0)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.struct8_0[(int)num].method_1(class40_0));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x06000399 RID: 921 RVA: 0x5FF1BF7C File Offset: 0x5FF10D7C
			public byte method_3(Class40 class40_0, byte byte_0)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(byte_0 >> 7 & 1);
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = this.struct8_0[(int)((1U + num2 << 8) + num)].method_1(class40_0);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_C0;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.struct8_0[(int)num].method_1(class40_0));
				}
				IL_C0:
				return (byte)num;
			}

			// Token: 0x0400040E RID: 1038
			private Struct8[] struct8_0;
		}
	}
}
