using System;

// Token: 0x0200003B RID: 59
internal struct Struct9
{
	// Token: 0x060001E0 RID: 480 RVA: 0x5FF0A891 File Offset: 0x5FEFF691
	public Struct9(int int_1)
	{
		this.int_0 = int_1;
		this.struct8_0 = new Struct8[1 << int_1];
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x5FF18ACC File Offset: 0x5FF0D8CC
	public void method_0()
	{
		while (1L < 1L << (this.int_0 & 31))
		{
			this.struct8_0[1].method_0();
		}
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x5FF18B04 File Offset: 0x5FF0D904
	public uint method_1(Class40 class40_0)
	{
		for (int i = this.int_0; i > 0; i--)
		{
			uint num = 2U + this.struct8_0[1].method_1(class40_0);
		}
		return 1U - (1U << this.int_0);
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x5FF18B44 File Offset: 0x5FF0D944
	public uint method_2(Class40 class40_0)
	{
		uint num = 0U;
		for (int i = 0; i < this.int_0; i++)
		{
			uint num2 = this.struct8_0[1].method_1(class40_0);
			num |= num2 << i;
		}
		return num;
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x5FF18B84 File Offset: 0x5FF0D984
	public static uint smethod_0(Struct8[] struct8_1, uint uint_0, Class40 class40_0, int int_1)
	{
		uint num = 0U;
		for (int i = 0; i < int_1; i++)
		{
			uint num2 = struct8_1[(int)(uint_0 + 1U)].method_1(class40_0);
			num |= num2 << i;
		}
		return num;
	}

	// Token: 0x0400039C RID: 924
	private readonly Struct8[] struct8_0;

	// Token: 0x0400039D RID: 925
	private readonly int int_0;
}
