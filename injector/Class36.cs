using System;

// Token: 0x02000036 RID: 54
internal static class Class36
{
	// Token: 0x060001C8 RID: 456 RVA: 0x5FF18148 File Offset: 0x5FF0CF48
	internal static void smethod_0(uint[] uint_0)
	{
		int i = 0;
		uint num = 0U;
		while (i < uint_0.Length)
		{
			num = ~uint_0[i] + 1U;
			uint_0[i] = num;
			if (num == 0U)
			{
				i++;
			}
			else
			{
				i++;
				IL_65:
				if (num != 0U)
				{
					while (i < uint_0.Length)
					{
						uint_0[i] = ~uint_0[i];
						i++;
					}
					return;
				}
				uint_0 = Class36.smethod_1(uint_0, uint_0.Length + 1);
				uint_0[uint_0.Length - 1] = 1U;
				return;
			}
		}
		goto IL_65;
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x5FF18220 File Offset: 0x5FF0D020
	private static uint[] smethod_1(uint[] uint_0, int int_1)
	{
		if (uint_0.Length == int_1)
		{
			return uint_0;
		}
		uint[] array = new uint[int_1];
		int num = Math.Min(uint_0.Length, int_1);
		for (int i = 0; i < num; i++)
		{
			array[i] = uint_0[i];
		}
		return array;
	}

	// Token: 0x060001CA RID: 458 RVA: 0x5FF18298 File Offset: 0x5FF0D098
	internal static void smethod_2<T>(ref T gparam_0, ref T gparam_1)
	{
		T t = gparam_0;
		gparam_0 = gparam_1;
		gparam_1 = t;
	}

	// Token: 0x060001CB RID: 459 RVA: 0x5FF0A7E5 File Offset: 0x5FEFF5E5
	internal static ulong smethod_3(uint uint_0, uint uint_1)
	{
		return (ulong)uint_0 << 32 | (ulong)uint_1;
	}

	// Token: 0x060001CC RID: 460 RVA: 0x5FF0A7F8 File Offset: 0x5FEFF5F8
	internal static uint smethod_4(ulong ulong_0)
	{
		return (uint)ulong_0;
	}

	// Token: 0x060001CD RID: 461 RVA: 0x5FF0A7FF File Offset: 0x5FEFF5FF
	internal static uint smethod_5(ulong ulong_0)
	{
		return (uint)(ulong_0 >> 32);
	}

	// Token: 0x060001CE RID: 462 RVA: 0x5FF0A80C File Offset: 0x5FEFF60C
	private static uint smethod_6(uint uint_0, uint uint_1)
	{
		return (uint_0 << 7 | uint_0 >> 25) ^ uint_1;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x5FF0A828 File Offset: 0x5FEFF628
	internal static int smethod_7(int int_1, int int_2)
	{
		return (int)Class36.smethod_6((uint)int_1, (uint)int_2);
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x5FF182D4 File Offset: 0x5FF0D0D4
	internal static int smethod_8(uint uint_0)
	{
		if (uint_0 == 0U)
		{
			return 32;
		}
		int num = 0;
		if ((uint_0 & 4294901760U) == 0U)
		{
			num += 16;
			uint_0 <<= 16;
		}
		if ((uint_0 & 4278190080U) == 0U)
		{
			num += 8;
			uint_0 <<= 8;
		}
		if ((uint_0 & 4026531840U) == 0U)
		{
			num += 4;
			uint_0 <<= 4;
		}
		if ((uint_0 & 3221225472U) == 0U)
		{
			num += 2;
			uint_0 <<= 2;
		}
		if ((uint_0 & 2147483648U) == 0U)
		{
			num++;
		}
		return num;
	}

	// Token: 0x04000370 RID: 880
	private const int int_0 = 32;
}
