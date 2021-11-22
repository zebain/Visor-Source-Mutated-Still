using System;

// Token: 0x02000027 RID: 39
public class GClass3
{
	// Token: 0x060000EC RID: 236 RVA: 0x5FF10EE4 File Offset: 0x5FF05CE4
	public static uint smethod_0(uint uint_0, int int_1)
	{
		uint num = uint_0 << int_1;
		uint num2 = uint_0 >> 32 - int_1;
		return num | num2;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x5FF10F20 File Offset: 0x5FF05D20
	public static uint smethod_1(uint uint_0, int int_1)
	{
		uint num = uint_0 >> int_1;
		uint num2 = uint_0 << 32 - int_1;
		return num | num2;
	}

	// Token: 0x060000EE RID: 238 RVA: 0x5FF10F5C File Offset: 0x5FF05D5C
	public static uint smethod_2(uint uint_0)
	{
		uint num = uint_0 & 16711935U;
		uint num2 = uint_0 & 4278255360U;
		return (num >> 8 | num << 24) + (num2 << 8 | num2 >> 24);
	}

	// Token: 0x04000318 RID: 792
	public const int int_0 = 32;
}
