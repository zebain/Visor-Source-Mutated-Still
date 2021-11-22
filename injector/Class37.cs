using System;

// Token: 0x02000037 RID: 55
internal abstract class Class37
{
	// Token: 0x060001D1 RID: 465 RVA: 0x5FF0A837 File Offset: 0x5FEFF637
	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2U;
		if (uint_9 < 4U)
		{
			return uint_9;
		}
		return 3U;
	}

	// Token: 0x04000371 RID: 881
	public const uint uint_0 = 12U;

	// Token: 0x04000372 RID: 882
	public const int int_0 = 6;

	// Token: 0x04000373 RID: 883
	private const int int_1 = 2;

	// Token: 0x04000374 RID: 884
	public const uint uint_1 = 4U;

	// Token: 0x04000375 RID: 885
	public const uint uint_2 = 2U;

	// Token: 0x04000376 RID: 886
	public const int int_2 = 4;

	// Token: 0x04000377 RID: 887
	public const uint uint_3 = 4U;

	// Token: 0x04000378 RID: 888
	public const uint uint_4 = 14U;

	// Token: 0x04000379 RID: 889
	public const uint uint_5 = 128U;

	// Token: 0x0400037A RID: 890
	public const int int_3 = 4;

	// Token: 0x0400037B RID: 891
	public const uint uint_6 = 16U;

	// Token: 0x0400037C RID: 892
	public const int int_4 = 3;

	// Token: 0x0400037D RID: 893
	public const int int_5 = 3;

	// Token: 0x0400037E RID: 894
	public const int int_6 = 8;

	// Token: 0x0400037F RID: 895
	public const uint uint_7 = 8U;

	// Token: 0x04000380 RID: 896
	public const uint uint_8 = 8U;

	// Token: 0x0200006C RID: 108
	public struct Struct6
	{
		// Token: 0x06000383 RID: 899 RVA: 0x5FF0A9B9 File Offset: 0x5FEFF7B9
		public void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x5FF1BBDC File Offset: 0x5FF109DC
		public void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x5FF0A9C9 File Offset: 0x5FEFF7C9
		public void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x5FF0A9F0 File Offset: 0x5FEFF7F0
		public void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x5FF0AA17 File Offset: 0x5FEFF817
		public void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x5FF0AA3E File Offset: 0x5FEFF83E
		public bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x04000400 RID: 1024
		public uint uint_0;
	}
}
