using System;
using System.IO;

// Token: 0x0200003C RID: 60
public class GClass17
{
	// Token: 0x060001E5 RID: 485 RVA: 0x5FF18BBC File Offset: 0x5FF0D9BC
	public void method_0(uint uint_5)
	{
		if (this.uint_1 != uint_5)
		{
			this.byte_0 = new byte[uint_5];
		}
		this.uint_1 = uint_5;
		this.uint_0 = 0U;
		this.uint_2 = 0U;
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x5FF18C14 File Offset: 0x5FF0DA14
	public void method_1(Stream stream_1, bool bool_0)
	{
		this.method_2();
		this.stream_0 = stream_1;
		if (!bool_0)
		{
			this.uint_2 = 0U;
			this.uint_0 = 0U;
			this.uint_4 = 0U;
		}
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x5FF0A8BE File Offset: 0x5FEFF6BE
	public void method_2()
	{
		this.method_3();
		this.stream_0 = null;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x5FF18C68 File Offset: 0x5FF0DA68
	public void method_3()
	{
		uint num = this.uint_0 - this.uint_2;
		if (num == 0U)
		{
			return;
		}
		this.stream_0.Write(this.byte_0, (int)this.uint_2, (int)num);
		if (this.uint_0 >= this.uint_1)
		{
			this.uint_0 = 0U;
		}
		this.uint_2 = this.uint_0;
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x5FF18CEC File Offset: 0x5FF0DAEC
	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		while (uint_6 > 0U)
		{
			if (num >= this.uint_1)
			{
				num = 0U;
			}
			byte[] array = this.byte_0;
			uint num2 = this.uint_0;
			this.uint_0 = num2 + 1U;
			array[(int)num2] = this.byte_0[(int)num++];
			if (this.uint_0 >= this.uint_1)
			{
				this.method_3();
			}
			uint_6 -= 1U;
		}
	}

	// Token: 0x060001EA RID: 490 RVA: 0x5FF18DD4 File Offset: 0x5FF0DBD4
	public void method_5(byte byte_1)
	{
		byte[] array = this.byte_0;
		uint num = this.uint_0;
		this.uint_0 = num + 1U;
		array[(int)num] = byte_1;
		if (this.uint_0 >= this.uint_1)
		{
			this.method_3();
		}
	}

	// Token: 0x060001EB RID: 491 RVA: 0x5FF18E30 File Offset: 0x5FF0DC30
	public byte method_6(uint uint_5)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		return this.byte_0[(int)num];
	}

	// Token: 0x0400039E RID: 926
	private byte[] byte_0;

	// Token: 0x0400039F RID: 927
	private uint uint_0;

	// Token: 0x040003A0 RID: 928
	private uint uint_1;

	// Token: 0x040003A1 RID: 929
	private uint uint_2;

	// Token: 0x040003A2 RID: 930
	private Stream stream_0;

	// Token: 0x040003A3 RID: 931
	private uint uint_3 = 1U;

	// Token: 0x040003A4 RID: 932
	public uint uint_4;
}
