using System;

// Token: 0x02000026 RID: 38
public class GClass2
{
	// Token: 0x060000EA RID: 234 RVA: 0x5FF0A3CD File Offset: 0x5FEFF1CD
	public GClass2()
	{
		this.uint_0 = 1021185734U;
	}

	// Token: 0x060000EB RID: 235 RVA: 0x5FF10EA0 File Offset: 0x5FF05CA0
	public uint method_0(uint uint_1)
	{
		uint num = uint_1 ^ this.uint_0;
		this.uint_0 = (GClass3.smethod_0(this.uint_0, 7) ^ num);
		return num;
	}

	// Token: 0x04000317 RID: 791
	private uint uint_0;
}
