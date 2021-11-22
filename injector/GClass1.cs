using System;
using System.Runtime.InteropServices;

// Token: 0x02000025 RID: 37
public class GClass1
{
	// Token: 0x060000E8 RID: 232 RVA: 0x5FF10D8C File Offset: 0x5FF05B8C
	public GClass1()
	{
		if (GClass1.uint_0 == null)
		{
			GClass1.uint_0 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				GClass1.uint_0[i] = num;
			}
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x5FF10E54 File Offset: 0x5FF05C54
	public uint method_0(IntPtr intptr_0, uint uint_1)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)uint_1))
		{
			num = (GClass1.uint_0[(int)(((uint)Marshal.ReadByte(new IntPtr(intptr_0.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x04000316 RID: 790
	private static uint[] uint_0;
}
