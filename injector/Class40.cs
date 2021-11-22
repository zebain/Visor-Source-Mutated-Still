using System;
using System.IO;

// Token: 0x02000039 RID: 57
internal class Class40
{
	// Token: 0x060001DA RID: 474 RVA: 0x5FF187E8 File Offset: 0x5FF0D5E8
	public void method_0(Stream stream_1)
	{
		this.stream_0 = stream_1;
		this.uint_3 = 0U;
		this.uint_2 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.uint_3 = (this.uint_3 << 8 | (uint)((byte)this.stream_0.ReadByte()));
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x5FF0A85C File Offset: 0x5FEFF65C
	public void method_1()
	{
		this.stream_0 = null;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x5FF1886C File Offset: 0x5FF0D66C
	public uint method_2(int int_0)
	{
		uint num = this.uint_2;
		uint num2 = this.uint_3;
		uint num3 = 0U;
		for (int i = int_0; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				num <<= 8;
			}
		}
		this.uint_2 = num;
		this.uint_3 = num2;
		return num3;
	}

	// Token: 0x04000393 RID: 915
	private uint uint_0 = 1U;

	// Token: 0x04000394 RID: 916
	public const uint uint_1 = 16777216U;

	// Token: 0x04000395 RID: 917
	public uint uint_2;

	// Token: 0x04000396 RID: 918
	public uint uint_3;

	// Token: 0x04000397 RID: 919
	public Stream stream_0;
}
