using System;
using System.Runtime.InteropServices;

// Token: 0x02000035 RID: 53
internal struct Struct5
{
	// Token: 0x060001B1 RID: 433 RVA: 0x5FF0A0F7 File Offset: 0x5FEFEEF7
	private void method_0(bool bool_1)
	{
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x5FF16F30 File Offset: 0x5FF0BD30
	internal Struct5(int int_2)
	{
		this.int_1 = 0;
		this.uint_0 = 0U;
		if (int_2 > 1)
		{
			this.uint_1 = new uint[int_2];
			this.bool_0 = true;
			return;
		}
		this.uint_1 = null;
		this.bool_0 = false;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x5FF16FA0 File Offset: 0x5FF0BDA0
	internal Struct5(Struct4 struct4_0, ref int int_2)
	{
		this.bool_0 = false;
		this.uint_1 = struct4_0.UInt32_0;
		int int32_ = struct4_0.Int32_1;
		int num = int32_ >> 31;
		int_2 = (int_2 ^ num) - num;
		if (this.uint_1 == null)
		{
			this.int_1 = 0;
			this.uint_0 = (uint)((int32_ ^ num) - num);
			return;
		}
		this.int_1 = this.uint_1.Length - 1;
		this.uint_0 = this.uint_1[0];
		while (this.int_1 > 0 && this.uint_1[this.int_1] == 0U)
		{
			this.int_1--;
		}
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x5FF170A0 File Offset: 0x5FF0BEA0
	internal Struct4 method_1(int int_2)
	{
		uint[] uint_;
		this.method_2(int_2, out int_2, out uint_);
		return new Struct4(int_2, uint_);
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x5FF170D0 File Offset: 0x5FF0BED0
	private void method_2(int int_2, out int int_3, out uint[] uint_2)
	{
		if (this.int_1 == 0)
		{
			if (this.uint_0 <= 2147483647U)
			{
				int_3 = int_2 * (int)this.uint_0;
				uint_2 = null;
				return;
			}
			if (this.uint_1 == null)
			{
				this.uint_1 = new uint[]
				{
					this.uint_0
				};
			}
			else if (this.bool_0)
			{
				this.uint_1[0] = this.uint_0;
			}
			else if (this.uint_1[0] != this.uint_0)
			{
				this.uint_1 = new uint[]
				{
					this.uint_0
				};
			}
		}
		int_3 = int_2;
		int num = this.uint_1.Length - this.int_1 - 1;
		if (num <= 1)
		{
			if (num == 0 || this.uint_1[this.int_1 + 1] == 0U)
			{
				this.bool_0 = false;
				uint_2 = this.uint_1;
				return;
			}
			if (this.bool_0)
			{
				this.uint_1[this.int_1 + 1] = 0U;
				this.bool_0 = false;
				uint_2 = this.uint_1;
				return;
			}
		}
		uint_2 = this.uint_1;
		Array.Resize<uint>(ref uint_2, this.int_1 + 1);
		if (!this.bool_0)
		{
			this.uint_1 = uint_2;
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x5FF0A7B7 File Offset: 0x5FEFF5B7
	private void method_3(uint uint_2)
	{
		this.uint_0 = uint_2;
		this.int_1 = 0;
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x5FF172A0 File Offset: 0x5FF0C0A0
	private void method_4(ulong ulong_0)
	{
		uint num = Class36.smethod_5(ulong_0);
		if (num == 0U)
		{
			this.uint_0 = Class36.smethod_4(ulong_0);
			this.int_1 = 0;
			return;
		}
		this.method_6(2);
		this.uint_1[0] = (uint)ulong_0;
		this.uint_1[1] = num;
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060001B8 RID: 440 RVA: 0x5FF0A7D4 File Offset: 0x5FEFF5D4
	internal int Int32_0
	{
		get
		{
			return this.int_1 + 1;
		}
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x5FF17318 File Offset: 0x5FF0C118
	private void method_5()
	{
		if (this.int_1 > 0 && this.uint_1[this.int_1] == 0U)
		{
			this.uint_0 = this.uint_1[0];
			int num;
			do
			{
				num = this.int_1 - 1;
				this.int_1 = num;
			}
			while (num > 0 && this.uint_1[this.int_1] == 0U);
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060001BA RID: 442 RVA: 0x5FF173A4 File Offset: 0x5FF0C1A4
	private int Int32_1
	{
		get
		{
			int num = 0;
			for (int i = this.int_1; i >= 0; i--)
			{
				if (this.uint_1[i] != 0U)
				{
					num++;
				}
			}
			return num;
		}
	}

	// Token: 0x060001BB RID: 443 RVA: 0x5FF17404 File Offset: 0x5FF0C204
	private void method_6(int int_2)
	{
		if (int_2 <= 1)
		{
			this.int_1 = 0;
			return;
		}
		if (!this.bool_0 || this.uint_1.Length < int_2)
		{
			this.uint_1 = new uint[int_2];
			this.bool_0 = true;
		}
		this.int_1 = int_2 - 1;
	}

	// Token: 0x060001BC RID: 444 RVA: 0x5FF1747C File Offset: 0x5FF0C27C
	private void method_7(int int_2)
	{
		if (int_2 <= 1)
		{
			this.int_1 = 0;
			this.uint_0 = 0U;
			return;
		}
		if (this.bool_0 && this.uint_1.Length >= int_2)
		{
			Array.Clear(this.uint_1, 0, int_2);
		}
		else
		{
			this.uint_1 = new uint[int_2];
			this.bool_0 = true;
		}
		this.int_1 = int_2 - 1;
	}

	// Token: 0x060001BD RID: 445 RVA: 0x5FF1751C File Offset: 0x5FF0C31C
	private void method_8(int int_2, int int_3)
	{
		if (int_2 <= 1)
		{
			if (this.int_1 > 0)
			{
				this.uint_0 = this.uint_1[0];
			}
			this.int_1 = 0;
			return;
		}
		if (this.bool_0 && this.uint_1.Length >= int_2)
		{
			if (this.int_1 + 1 < int_2)
			{
				Array.Clear(this.uint_1, this.int_1 + 1, int_2 - this.int_1 - 1);
				if (this.int_1 == 0)
				{
					this.uint_1[0] = this.uint_0;
				}
			}
		}
		else
		{
			uint[] array = new uint[int_2 + int_3];
			if (this.int_1 == 0)
			{
				array[0] = this.uint_0;
			}
			else
			{
				Array.Copy(this.uint_1, array, Math.Min(int_2, this.int_1 + 1));
			}
			this.uint_1 = array;
			this.bool_0 = true;
		}
		this.int_1 = int_2 - 1;
	}

	// Token: 0x060001BE RID: 446 RVA: 0x5FF17688 File Offset: 0x5FF0C488
	private void method_9([Optional] int int_2)
	{
		if (this.bool_0)
		{
			return;
		}
		uint[] destinationArray = new uint[this.int_1 + 1 + int_2];
		Array.Copy(this.uint_1, destinationArray, this.int_1 + 1);
		this.uint_1 = destinationArray;
		this.bool_0 = true;
	}

	// Token: 0x060001BF RID: 447 RVA: 0x5FF176FC File Offset: 0x5FF0C4FC
	private void method_10(ref Struct5 struct5_0, int int_2)
	{
		if (struct5_0.int_1 == 0)
		{
			this.uint_0 = struct5_0.uint_0;
			this.int_1 = 0;
			return;
		}
		if (!this.bool_0 || this.uint_1.Length <= struct5_0.int_1)
		{
			this.uint_1 = new uint[struct5_0.int_1 + 1 + int_2];
			this.bool_0 = true;
		}
		this.int_1 = struct5_0.int_1;
		Array.Copy(struct5_0.uint_1, this.uint_1, this.int_1 + 1);
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x5FF177C0 File Offset: 0x5FF0C5C0
	private void method_11(uint uint_2)
	{
		if (uint_2 == 0U)
		{
			this.method_3(0U);
			return;
		}
		if (uint_2 == 1U)
		{
			return;
		}
		if (this.int_1 == 0)
		{
			this.method_4((ulong)this.uint_0 * (ulong)uint_2);
			return;
		}
		this.method_9(1);
		for (int i = 0; i <= this.int_1; i++)
		{
			Struct5.smethod_3(ref this.uint_1[i], uint_2, 0U);
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x5FF17824 File Offset: 0x5FF0C624
	internal void method_12(ref Struct5 struct5_0, ref Struct5 struct5_1)
	{
		if (struct5_0.int_1 == 0)
		{
			if (struct5_1.int_1 == 0)
			{
				this.method_4((ulong)struct5_0.uint_0 * (ulong)struct5_1.uint_0);
				return;
			}
			this.method_10(ref struct5_1, 1);
			this.method_11(struct5_0.uint_0);
			return;
		}
		else
		{
			if (struct5_1.int_1 == 0)
			{
				this.method_10(ref struct5_0, 1);
				this.method_11(struct5_1.uint_0);
				return;
			}
			this.method_7(struct5_0.int_1 + struct5_1.int_1 + 2);
			uint[] array;
			int num;
			uint[] array2;
			int num2;
			if (struct5_0.Int32_1 <= struct5_1.Int32_1)
			{
				array = struct5_0.uint_1;
				num = struct5_0.int_1 + 1;
				array2 = struct5_1.uint_1;
				num2 = struct5_1.int_1 + 1;
			}
			else
			{
				array = struct5_1.uint_1;
				num = struct5_1.int_1 + 1;
				array2 = struct5_0.uint_1;
				num2 = struct5_0.int_1 + 1;
			}
			for (int i = 0; i < num; i++)
			{
				uint num3 = array[i];
				if (num3 != 0U)
				{
					uint num4 = 0U;
					int num5 = i;
					int j = 0;
					while (j < num2)
					{
						num4 = Struct5.smethod_4(ref this.uint_1[num5], num3, array2[j], num4);
						j++;
						num5++;
					}
					while (num4 != 0U)
					{
						num4 = Struct5.smethod_2(ref this.uint_1[num5++], 0U, num4);
					}
				}
			}
			this.method_5();
			return;
		}
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x5FF17A60 File Offset: 0x5FF0C860
	private static uint smethod_0(ref Struct5 struct5_0, uint uint_2)
	{
		if (uint_2 == 1U)
		{
			return 0U;
		}
		if (struct5_0.int_1 == 0)
		{
			return struct5_0.uint_0 % uint_2;
		}
		ulong num = 0UL;
		for (int i = struct5_0.int_1; i >= 0; i--)
		{
			num = Class36.smethod_3((uint)num, struct5_0.uint_1[i]);
			num %= (ulong)uint_2;
		}
		return (uint)num;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x5FF17AFC File Offset: 0x5FF0C8FC
	internal void method_13(ref Struct5 struct5_0)
	{
		if (struct5_0.int_1 == 0)
		{
			this.method_3(Struct5.smethod_0(ref this, struct5_0.uint_0));
			return;
		}
		if (this.int_1 == 0)
		{
			return;
		}
		Struct5 @struct = default(Struct5);
		Struct5.smethod_1(ref this, ref struct5_0, false, ref @struct);
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x5FF17B5C File Offset: 0x5FF0C95C
	private static void smethod_1(ref Struct5 struct5_0, ref Struct5 struct5_1, bool bool_1, ref Struct5 struct5_2)
	{
		struct5_2.method_3(0U);
		if (struct5_0.int_1 < struct5_1.int_1)
		{
			return;
		}
		int num = struct5_1.int_1 + 1;
		int num2 = struct5_0.int_1 - struct5_1.int_1;
		int num3 = num2;
		int i = struct5_0.int_1;
		while (i >= num2)
		{
			if (struct5_1.uint_1[i - num2] != struct5_0.uint_1[i])
			{
				if (struct5_1.uint_1[i - num2] < struct5_0.uint_1[i])
				{
					num3++;
				}
				IL_E2:
				if (num3 == 0)
				{
					return;
				}
				if (bool_1)
				{
					struct5_2.method_6(num3);
				}
				uint num4 = struct5_1.uint_1[num - 1];
				uint num5 = struct5_1.uint_1[num - 2];
				int num6 = Class36.smethod_8(num4);
				int num7 = 32 - num6;
				if (num6 > 0)
				{
					num4 = (num4 << num6 | num5 >> num7);
					num5 <<= num6;
					if (num > 2)
					{
						num5 |= struct5_1.uint_1[num - 3] >> num7;
					}
				}
				struct5_0.method_9(0);
				int num8 = num3;
				while (--num8 >= 0)
				{
					uint num9 = (num8 + num <= struct5_0.int_1) ? struct5_0.uint_1[num8 + num] : 0U;
					ulong num10 = Class36.smethod_3(num9, struct5_0.uint_1[num8 + num - 1]);
					uint num11 = struct5_0.uint_1[num8 + num - 2];
					if (num6 > 0)
					{
						num10 = (num10 << num6 | (ulong)(num11 >> num7));
						num11 <<= num6;
						if (num8 + num >= 3)
						{
							num11 |= struct5_0.uint_1[num8 + num - 3] >> num7;
						}
					}
					ulong num12 = num10 / (ulong)num4;
					ulong num13 = (ulong)((uint)(num10 % (ulong)num4));
					if (num12 > 4294967295UL)
					{
						num13 += (ulong)num4 * (num12 - 4294967295UL);
						num12 = 4294967295UL;
					}
					while (num13 <= 4294967295UL && num12 * (ulong)num5 > Class36.smethod_3((uint)num13, num11))
					{
						num12 -= 1UL;
						num13 += (ulong)num4;
					}
					if (num12 > 0UL)
					{
						ulong num14 = 0UL;
						for (int j = 0; j < num; j++)
						{
							num14 += (ulong)struct5_1.uint_1[j] * num12;
							uint num15 = (uint)num14;
							num14 >>= 32;
							if (struct5_0.uint_1[num8 + j] < num15)
							{
								num14 += 1UL;
							}
							struct5_0.uint_1[num8 + j] -= num15;
						}
						if ((ulong)num9 < num14)
						{
							uint uint_ = 0U;
							for (int k = 0; k < num; k++)
							{
								uint_ = Struct5.smethod_2(ref struct5_0.uint_1[num8 + k], struct5_1.uint_1[k], uint_);
							}
							num12 -= 1UL;
						}
						struct5_0.int_1 = num8 + num - 1;
					}
					if (bool_1)
					{
						if (num3 == 1)
						{
							struct5_2.uint_0 = (uint)num12;
						}
						else
						{
							struct5_2.uint_1[num8] = (uint)num12;
						}
					}
				}
				struct5_0.int_1 = num - 1;
				struct5_0.method_5();
				return;
			}
			else
			{
				i--;
			}
		}
		num3++;
		goto IL_E2;
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x5FF18098 File Offset: 0x5FF0CE98
	private static uint smethod_2(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)uint_2 + (ulong)uint_3 + (ulong)uint_4;
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x5FF180D0 File Offset: 0x5FF0CED0
	private static uint smethod_3(ref uint uint_2, uint uint_3, uint uint_4)
	{
		ulong num = (ulong)uint_2 * (ulong)uint_3 + (ulong)uint_4;
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x5FF18108 File Offset: 0x5FF0CF08
	private static uint smethod_4(ref uint uint_2, uint uint_3, uint uint_4, uint uint_5)
	{
		ulong num = (ulong)uint_3 * (ulong)uint_4 + (ulong)uint_2 + (ulong)uint_5;
		uint_2 = (uint)num;
		return (uint)(num >> 32);
	}

	// Token: 0x0400036B RID: 875
	private const int int_0 = 32;

	// Token: 0x0400036C RID: 876
	private int int_1;

	// Token: 0x0400036D RID: 877
	private uint uint_0;

	// Token: 0x0400036E RID: 878
	private uint[] uint_1;

	// Token: 0x0400036F RID: 879
	private bool bool_0;
}
