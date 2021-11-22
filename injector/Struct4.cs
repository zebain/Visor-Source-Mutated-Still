using System;

// Token: 0x02000034 RID: 52
[Serializable]
internal struct Struct4
{
	// Token: 0x06000196 RID: 406 RVA: 0x5FF0A5A2 File Offset: 0x5FEFF3A2
	private void method_0()
	{
		if (this.uint_1 != null)
		{
			Struct4.smethod_11(this.uint_1);
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000197 RID: 407 RVA: 0x5FF0A5BE File Offset: 0x5FEFF3BE
	private static Struct4 Struct4_0
	{
		get
		{
			return Struct4.struct4_1;
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000198 RID: 408 RVA: 0x5FF0A5C5 File Offset: 0x5FEFF3C5
	private bool Boolean_0
	{
		get
		{
			if (this.uint_1 != null)
			{
				return (this.uint_1[0] & 1U) == 0U;
			}
			return (this.int_1 & 1) == 0;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000199 RID: 409 RVA: 0x5FF0A605 File Offset: 0x5FEFF405
	private int Int32_0
	{
		get
		{
			return (this.int_1 >> 31) - (-this.int_1 >> 31);
		}
	}

	// Token: 0x0600019A RID: 410 RVA: 0x5FF0A627 File Offset: 0x5FEFF427
	public bool vmethod_0(object object_0)
	{
		return object_0 is Struct4 && this.Equals((Struct4)object_0);
	}

	// Token: 0x0600019B RID: 411 RVA: 0x5FF16370 File Offset: 0x5FF0B170
	public int vmethod_1()
	{
		if (this.uint_1 == null)
		{
			return this.int_1;
		}
		int result = this.int_1;
		int num = Struct4.smethod_11(this.uint_1);
		while (--num >= 0)
		{
			result = Class36.smethod_7(result, (int)this.uint_1[num]);
		}
		return result;
	}

	// Token: 0x0600019C RID: 412 RVA: 0x5FF163E8 File Offset: 0x5FF0B1E8
	private int method_1(Struct4 struct4_4)
	{
		if ((this.int_1 ^ struct4_4.int_1) < 0)
		{
			if (this.int_1 >= 0)
			{
				return 1;
			}
			return -1;
		}
		else if (this.uint_1 == null)
		{
			if (struct4_4.uint_1 != null)
			{
				return -struct4_4.int_1;
			}
			if (this.int_1 < struct4_4.int_1)
			{
				return -1;
			}
			if (this.int_1 <= struct4_4.int_1)
			{
				return 0;
			}
			return 1;
		}
		else
		{
			int num;
			int num2;
			if (struct4_4.uint_1 == null || (num = Struct4.smethod_11(this.uint_1)) > (num2 = Struct4.smethod_11(struct4_4.uint_1)))
			{
				return this.int_1;
			}
			if (num < num2)
			{
				return -this.int_1;
			}
			int num3 = Struct4.smethod_12(this.uint_1, struct4_4.uint_1, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (this.uint_1[num3 - 1] >= struct4_4.uint_1[num3 - 1])
			{
				return this.int_1;
			}
			return -this.int_1;
		}
	}

	// Token: 0x0600019D RID: 413 RVA: 0x5FF16544 File Offset: 0x5FF0B344
	internal byte[] method_2()
	{
		if (this.uint_1 == null && this.int_1 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (this.uint_1 == null)
		{
			array = new uint[]
			{
				(uint)this.int_1
			};
			b = ((this.int_1 < 0) ? byte.MaxValue : 0);
		}
		else if (this.int_1 == -1)
		{
			array = (uint[])this.uint_1.Clone();
			Class36.smethod_0(array);
			b = byte.MaxValue;
		}
		else
		{
			array = this.uint_1;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		foreach (uint num2 in array)
		{
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 255U);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 128) == (b & 128))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	// Token: 0x0600019E RID: 414 RVA: 0x5FF0A657 File Offset: 0x5FEFF457
	private Struct4(int int_2)
	{
		if (int_2 == -2147483648)
		{
			this = Struct4.struct4_0;
			return;
		}
		this.int_1 = int_2;
		this.uint_1 = null;
	}

	// Token: 0x0600019F RID: 415 RVA: 0x5FF16724 File Offset: 0x5FF0B524
	internal Struct4(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = byte_0.Length;
		bool flag = num > 0 && (byte_0[num - 1] & 128) == 128;
		while (num > 0 && byte_0[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			this.int_1 = 0;
			this.uint_1 = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				this.int_1 = -1;
			}
			else
			{
				this.int_1 = 0;
			}
			for (int i = num - 1; i >= 0; i--)
			{
				this.int_1 <<= 8;
				this.int_1 |= (int)byte_0[i];
			}
			this.uint_1 = null;
			if (this.int_1 < 0 && !flag)
			{
				this.uint_1 = new uint[1];
				this.uint_1[0] = (uint)this.int_1;
				this.int_1 = 1;
			}
			if (this.int_1 == -2147483648)
			{
				this = Struct4.struct4_0;
				return;
			}
		}
		else
		{
			int num2 = num % 4;
			int num3 = num / 4 + ((num2 == 0) ? 0 : 1);
			bool flag2 = true;
			uint[] array = new uint[num3];
			int j = 3;
			int k;
			for (k = 0; k < num3 - ((num2 != 0) ? 1 : 0); k++)
			{
				for (int l = 0; l < 4; l++)
				{
					if (byte_0[j] != 0)
					{
						flag2 = false;
					}
					array[k] <<= 8;
					array[k] |= (uint)byte_0[j];
					j--;
				}
				j += 8;
			}
			if (num2 != 0)
			{
				if (flag)
				{
					array[num3 - 1] = uint.MaxValue;
				}
				for (j = num - 1; j >= num - num2; j--)
				{
					if (byte_0[j] != 0)
					{
						flag2 = false;
					}
					array[k] <<= 8;
					array[k] |= (uint)byte_0[j];
				}
			}
			if (flag2)
			{
				this = Struct4.struct4_2;
				return;
			}
			if (flag)
			{
				Class36.smethod_0(array);
				int num4 = array.Length;
				while (num4 > 0 && array[num4 - 1] == 0U)
				{
					num4--;
				}
				if (num4 == 1 && array[0] > 0U)
				{
					if (array[0] == 1U)
					{
						this = Struct4.struct4_3;
						return;
					}
					if (array[0] == 2147483648U)
					{
						this = Struct4.struct4_0;
						return;
					}
					this.int_1 = (int)(uint.MaxValue * array[0]);
					this.uint_1 = null;
					return;
				}
				else
				{
					if (num4 != array.Length)
					{
						this.int_1 = -1;
						this.uint_1 = new uint[num4];
						Array.Copy(array, this.uint_1, num4);
						return;
					}
					this.int_1 = -1;
					this.uint_1 = array;
					return;
				}
			}
			else
			{
				this.int_1 = 1;
				this.uint_1 = array;
			}
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x5FF0A68A File Offset: 0x5FEFF48A
	internal Struct4(int int_2, uint[] uint_2)
	{
		this.int_1 = int_2;
		this.uint_1 = uint_2;
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x5FF0A6A6 File Offset: 0x5FEFF4A6
	private static void smethod_0(ref Struct5 struct5_0, ref Struct5 struct5_1, ref Struct5 struct5_2, ref Struct5 struct5_3)
	{
		Class36.smethod_2<Struct5>(ref struct5_0, ref struct5_3);
		struct5_0.method_12(ref struct5_3, ref struct5_1);
		struct5_0.method_13(ref struct5_2);
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x5FF0A6D3 File Offset: 0x5FEFF4D3
	private static void smethod_1(ref Struct5 struct5_0, ref Struct5 struct5_1, ref Struct5 struct5_2)
	{
		Class36.smethod_2<Struct5>(ref struct5_0, ref struct5_2);
		struct5_0.method_12(ref struct5_2, ref struct5_2);
		struct5_0.method_13(ref struct5_1);
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x5FF16BD4 File Offset: 0x5FF0B9D4
	private static void smethod_2(uint uint_2, ref Struct5 struct5_0, ref Struct5 struct5_1, ref Struct5 struct5_2, ref Struct5 struct5_3)
	{
		while (uint_2 != 0U)
		{
			if ((uint_2 & 1U) == 1U)
			{
				Struct4.smethod_0(ref struct5_0, ref struct5_1, ref struct5_2, ref struct5_3);
			}
			if (uint_2 == 1U)
			{
				break;
			}
			Struct4.smethod_1(ref struct5_1, ref struct5_2, ref struct5_3);
			uint_2 >>= 1;
		}
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x5FF16C3C File Offset: 0x5FF0BA3C
	private static void smethod_3(uint uint_2, ref Struct5 struct5_0, ref Struct5 struct5_1, ref Struct5 struct5_2, ref Struct5 struct5_3)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((uint_2 & 1U) == 1U)
			{
				Struct4.smethod_0(ref struct5_0, ref struct5_1, ref struct5_2, ref struct5_3);
			}
			Struct4.smethod_1(ref struct5_1, ref struct5_2, ref struct5_3);
			uint_2 >>= 1;
		}
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x5FF16CB4 File Offset: 0x5FF0BAB4
	internal static Struct4 smethod_4(Struct4 struct4_4, Struct4 struct4_5, Struct4 struct4_6)
	{
		if (struct4_5.Int32_0 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int num = 1;
		int num2 = 1;
		int num3 = 1;
		bool boolean_ = struct4_5.Boolean_0;
		Struct5 @struct = new Struct5(Struct4.Struct4_0, ref num);
		Struct5 struct2 = new Struct5(struct4_4, ref num2);
		Struct5 struct3 = new Struct5(struct4_6, ref num3);
		Struct5 struct4 = new Struct5(struct2.Int32_0);
		@struct.method_13(ref struct3);
		if (struct4_5.uint_1 == null)
		{
			Struct4.smethod_2((uint)struct4_5.int_1, ref @struct, ref struct2, ref struct3, ref struct4);
		}
		else
		{
			int num4 = Struct4.smethod_11(struct4_5.uint_1);
			for (int i = 0; i < num4 - 1; i++)
			{
				Struct4.smethod_3(struct4_5.uint_1[i], ref @struct, ref struct2, ref struct3, ref struct4);
			}
			Struct4.smethod_2(struct4_5.uint_1[num4 - 1], ref @struct, ref struct2, ref struct3, ref struct4);
		}
		return @struct.method_1((struct4_4.int_1 > 0) ? 1 : (boolean_ ? 1 : -1));
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x5FF0A700 File Offset: 0x5FEFF500
	public static bool smethod_5(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.method_1(struct4_5) < 0;
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x5FF0A716 File Offset: 0x5FEFF516
	public static bool smethod_6(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.method_1(struct4_5) <= 0;
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x5FF0A733 File Offset: 0x5FEFF533
	public static bool smethod_7(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.method_1(struct4_5) > 0;
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x5FF0A749 File Offset: 0x5FEFF549
	public static bool smethod_8(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.method_1(struct4_5) >= 0;
	}

	// Token: 0x060001AA RID: 426 RVA: 0x5FF0A766 File Offset: 0x5FEFF566
	public static bool smethod_9(Struct4 struct4_4, Struct4 struct4_5)
	{
		return struct4_4.Equals(struct4_5);
	}

	// Token: 0x060001AB RID: 427 RVA: 0x5FF0A780 File Offset: 0x5FEFF580
	public static bool smethod_10(Struct4 struct4_4, Struct4 struct4_5)
	{
		return !struct4_4.Equals(struct4_5);
	}

	// Token: 0x060001AC RID: 428 RVA: 0x5FF16E44 File Offset: 0x5FF0BC44
	private static int smethod_11(uint[] uint_2)
	{
		int num = uint_2.Length;
		if (uint_2[num - 1] != 0U)
		{
			return num;
		}
		return num - 1;
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060001AD RID: 429 RVA: 0x5FF0A7A1 File Offset: 0x5FEFF5A1
	internal int Int32_1
	{
		get
		{
			return this.int_1;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060001AE RID: 430 RVA: 0x5FF0A7AC File Offset: 0x5FEFF5AC
	internal uint[] UInt32_0
	{
		get
		{
			return this.uint_1;
		}
	}

	// Token: 0x060001AF RID: 431 RVA: 0x5FF16E7C File Offset: 0x5FF0BC7C
	private static int smethod_12(uint[] uint_2, uint[] uint_3, int int_2)
	{
		int num = int_2;
		while (--num >= 0)
		{
			if (uint_2[num] != uint_3[num])
			{
				return num + 1;
			}
		}
		return 0;
	}

	// Token: 0x04000363 RID: 867
	private const uint uint_0 = 2147483648U;

	// Token: 0x04000364 RID: 868
	private const int int_0 = 32;

	// Token: 0x04000365 RID: 869
	private readonly int int_1;

	// Token: 0x04000366 RID: 870
	private readonly uint[] uint_1;

	// Token: 0x04000367 RID: 871
	private static readonly Struct4 struct4_0 = new Struct4(-1, new uint[]
	{
		2147483648U
	});

	// Token: 0x04000368 RID: 872
	private static readonly Struct4 struct4_1 = new Struct4(1);

	// Token: 0x04000369 RID: 873
	private static readonly Struct4 struct4_2 = new Struct4(0);

	// Token: 0x0400036A RID: 874
	private static readonly Struct4 struct4_3 = new Struct4(-1);
}
