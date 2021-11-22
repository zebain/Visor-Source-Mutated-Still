using System;
using System.Runtime.InteropServices;

// Token: 0x0200002C RID: 44
public static class GClass6
{
	// Token: 0x06000103 RID: 259 RVA: 0x5FF113D4 File Offset: 0x5FF061D4
	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		int[] result;
		try
		{
			byte[] array = (IntPtr.Size == 4) ? GClass6.byte_0 : GClass6.byte_1;
			intPtr = Class33.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), (Class33.Enum1)12288U, Class33.Enum2.const_6);
			Marshal.Copy(array, 0, intPtr, array.Length);
			GClass6.Delegate0 @delegate = (GClass6.Delegate0)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(GClass6.Delegate0));
			GCHandle a = default(GCHandle);
			int[] array2 = new int[4];
			try
			{
				a = GCHandle.Alloc(array2, GCHandleType.Pinned);
				@delegate(int_0, array2);
			}
			finally
			{
				if (a != default(GCHandle))
				{
					a.Free();
				}
			}
			result = array2;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Class33.VirtualFree(intPtr, 0U, 32768U);
			}
		}
		return result;
	}

	// Token: 0x04000338 RID: 824
	private static readonly byte[] byte_0 = new byte[]
	{
		85,
		139,
		236,
		83,
		87,
		139,
		69,
		8,
		15,
		162,
		139,
		125,
		12,
		137,
		7,
		137,
		95,
		4,
		137,
		79,
		8,
		137,
		87,
		12,
		95,
		91,
		139,
		229,
		93,
		195
	};

	// Token: 0x04000339 RID: 825
	private static readonly byte[] byte_1 = new byte[]
	{
		83,
		73,
		137,
		208,
		137,
		200,
		15,
		162,
		65,
		137,
		64,
		0,
		65,
		137,
		88,
		4,
		65,
		137,
		72,
		8,
		65,
		137,
		80,
		12,
		91,
		195
	};

	// Token: 0x0200003F RID: 63
	// (Invoke) Token: 0x060001EE RID: 494
	private delegate void Delegate0(int int_0, int[] int_1);
}
