using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x0200002B RID: 43
public class GClass5
{
	// Token: 0x060000F1 RID: 241 RVA: 0x5FF11048 File Offset: 0x5FF05E48
	public static bool smethod_0()
	{
		return true;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x5FF11058 File Offset: 0x5FF05E58
	public static bool smethod_1(bool bool_0)
	{
		object[] object_ = new object[]
		{
			bool_0
		};
		return (bool)new GClass15().method_112(object_, 84848);
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x5FF1109C File Offset: 0x5FF05E9C
	public static bool smethod_2()
	{
		return false;
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x5FF110B0 File Offset: 0x5FF05EB0
	public static bool smethod_3()
	{
		if (GClass7.smethod_0())
		{
			return false;
		}
		long num = Marshal.GetHINSTANCE(typeof(GClass5).Module).ToInt64();
		uint num2 = (uint)Marshal.ReadInt32(new IntPtr(num + 400024992L));
		long num3 = 400024162L;
		bool result = true;
		byte[] array = new byte[12];
		GClass1 gclass = new GClass1();
		if (Marshal.ReadInt32(new IntPtr(num + 400024840L)) != (int)gclass.method_0(new IntPtr(num + 400024162L), num2))
		{
			result = false;
		}
		GClass2 gclass2 = new GClass2();
		int num4 = 0;
		while ((long)num4 < (long)((ulong)num2))
		{
			Marshal.Copy(new IntPtr(num + num3 + (long)num4), array, 0, array.Length);
			uint num5 = gclass2.method_0(BitConverter.ToUInt32(array, 0));
			uint uint_ = gclass2.method_0(BitConverter.ToUInt32(array, 4));
			uint num6 = gclass2.method_0(BitConverter.ToUInt32(array, 8));
			if (gclass.method_0(new IntPtr(num + (long)((ulong)num5)), uint_) != num6)
			{
				result = false;
			}
			num4 += array.Length;
		}
		num2 = (uint)Marshal.ReadInt32(new IntPtr(num + (long)((ulong)GClass7.smethod_3())));
		num3 = (long)((ulong)GClass7.smethod_2());
		if (Marshal.ReadInt32(new IntPtr(num + (long)((ulong)GClass7.smethod_4()))) != (int)gclass.method_0(new IntPtr(num + num3), num2))
		{
			result = false;
		}
		GClass2 gclass3 = new GClass2();
		int num7 = 0;
		while ((long)num7 < (long)((ulong)num2))
		{
			Marshal.Copy(new IntPtr(num + num3 + (long)num7), array, 0, array.Length);
			uint num8 = gclass3.method_0(BitConverter.ToUInt32(array, 0));
			uint uint_2 = gclass3.method_0(BitConverter.ToUInt32(array, 4));
			uint num9 = gclass3.method_0(BitConverter.ToUInt32(array, 8));
			if (gclass.method_0(new IntPtr(num + (long)((ulong)num8)), uint_2) != num9)
			{
				result = false;
			}
			num7 += array.Length;
		}
		return result;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x5FF0A3E6 File Offset: 0x5FEFF1E6
	public static string smethod_4()
	{
		return new GClass15().method_112(null, 60795);
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x5FF11294 File Offset: 0x5FF06094
	public static bool smethod_5(ref string string_0)
	{
		object[] array = new object[]
		{
			string_0
		};
		bool result;
		try
		{
			result = (bool)new GClass15().method_112(array, 400010099);
		}
		finally
		{
			string_0 = array[0];
		}
		return result;
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000F7 RID: 247 RVA: 0x5FF0A3F8 File Offset: 0x5FEFF1F8
	// (set) Token: 0x060000F8 RID: 248 RVA: 0x5FF0A403 File Offset: 0x5FEFF203
	public GClass8 GClass8_0
	{
		get
		{
			return this.gclass8_0;
		}
		private set
		{
			this.gclass8_0 = value;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x5FF0A412 File Offset: 0x5FEFF212
	// (set) Token: 0x060000FA RID: 250 RVA: 0x5FF0A41D File Offset: 0x5FEFF21D
	public GClass14 GClass14_0
	{
		get
		{
			return this.gclass14_0;
		}
		private set
		{
			this.gclass14_0 = value;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000FB RID: 251 RVA: 0x5FF0A42C File Offset: 0x5FEFF22C
	// (set) Token: 0x060000FC RID: 252 RVA: 0x5FF0A437 File Offset: 0x5FEFF237
	public GClass9 GClass9_0
	{
		get
		{
			return this.gclass9_0;
		}
		private set
		{
			this.gclass9_0 = value;
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x5FF11300 File Offset: 0x5FF06100
	private static string smethod_6(uint uint_0)
	{
		object[] object_ = new object[]
		{
			uint_0
		};
		return new GClass15().method_112(object_, 69302);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x5FF0A446 File Offset: 0x5FEFF246
	public static void smethod_7(string string_0)
	{
		MessageBox.Show(string_0, Assembly.GetExecutingAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x060000FF RID: 255 RVA: 0x5FF11348 File Offset: 0x5FF06148
	private static void smethod_8(object object_0)
	{
		object[] object_ = new object[]
		{
			object_0
		};
		new GClass15().method_112(object_, 399975281);
	}

	// Token: 0x06000100 RID: 256 RVA: 0x5FF11384 File Offset: 0x5FF06184
	public bool method_0(long long_0)
	{
		object[] object_ = new object[]
		{
			this,
			long_0
		};
		return (bool)new GClass15().method_112(object_, 46004);
	}

	// Token: 0x04000334 RID: 820
	public static readonly GClass5 gclass5_0 = new GClass5();

	// Token: 0x04000335 RID: 821
	private GClass8 gclass8_0;

	// Token: 0x04000336 RID: 822
	private GClass14 gclass14_0;

	// Token: 0x04000337 RID: 823
	private GClass9 gclass9_0;
}
