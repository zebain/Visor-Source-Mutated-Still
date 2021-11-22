using System;

// Token: 0x0200003A RID: 58
internal struct Struct8
{
	// Token: 0x060001DE RID: 478 RVA: 0x5FF0A881 File Offset: 0x5FEFF681
	public void method_0()
	{
		this.uint_1 = 1024U;
	}

	// Token: 0x060001DF RID: 479 RVA: 0x5FF1896C File Offset: 0x5FF0D76C
	public uint method_1(Class40 class40_0)
	{
		uint num = (class40_0.uint_2 >> 11) * this.uint_1;
		if (class40_0.uint_3 < num)
		{
			class40_0.uint_2 = num;
			this.uint_1 += 2048U - this.uint_1 >> 5;
			if (class40_0.uint_2 < 16777216U)
			{
				class40_0.uint_3 = (class40_0.uint_3 << 8 | (uint)((byte)class40_0.stream_0.ReadByte()));
				class40_0.uint_2 <<= 8;
			}
			return 0U;
		}
		class40_0.uint_2 -= num;
		class40_0.uint_3 -= num;
		this.uint_1 -= this.uint_1 >> 5;
		if (class40_0.uint_2 < 16777216U)
		{
			class40_0.uint_3 = (class40_0.uint_3 << 8 | (uint)((byte)class40_0.stream_0.ReadByte()));
			class40_0.uint_2 <<= 8;
		}
		return 1U;
	}

	// Token: 0x04000398 RID: 920
	private const int int_0 = 11;

	// Token: 0x04000399 RID: 921
	private const uint uint_0 = 2048U;

	// Token: 0x0400039A RID: 922
	private const int int_1 = 5;

	// Token: 0x0400039B RID: 923
	private uint uint_1;
}
