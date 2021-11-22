using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

// Token: 0x02000032 RID: 50
public class GClass15
{
	// Token: 0x06000113 RID: 275 RVA: 0x5FF1166C File Offset: 0x5FF0646C
	public GClass15()
	{
		this.long_0 = Marshal.GetHINSTANCE(this.module_0).ToInt64();
		this.dictionary_0[0U] = new GClass15.Delegate1(this.method_75);
		this.dictionary_0[1U] = new GClass15.Delegate1(this.method_97);
		this.dictionary_0[2U] = new GClass15.Delegate1(this.method_74);
		this.dictionary_0[3U] = new GClass15.Delegate1(this.method_54);
		this.dictionary_0[4U] = new GClass15.Delegate1(this.method_47);
		this.dictionary_0[5U] = new GClass15.Delegate1(this.method_76);
		this.dictionary_0[6U] = new GClass15.Delegate1(this.method_53);
		this.dictionary_0[7U] = new GClass15.Delegate1(this.method_63);
		this.dictionary_0[8U] = new GClass15.Delegate1(this.method_36);
		this.dictionary_0[9U] = new GClass15.Delegate1(this.method_46);
		this.dictionary_0[10U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[11U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[12U] = new GClass15.Delegate1(this.method_60);
		this.dictionary_0[13U] = new GClass15.Delegate1(this.method_55);
		this.dictionary_0[14U] = new GClass15.Delegate1(this.method_37);
		this.dictionary_0[15U] = new GClass15.Delegate1(this.method_67);
		this.dictionary_0[16U] = new GClass15.Delegate1(this.method_82);
		this.dictionary_0[17U] = new GClass15.Delegate1(this.method_44);
		this.dictionary_0[18U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[19U] = new GClass15.Delegate1(this.method_49);
		this.dictionary_0[20U] = new GClass15.Delegate1(this.method_99);
		this.dictionary_0[21U] = new GClass15.Delegate1(this.method_58);
		this.dictionary_0[22U] = new GClass15.Delegate1(this.method_106);
		this.dictionary_0[23U] = new GClass15.Delegate1(this.method_38);
		this.dictionary_0[24U] = new GClass15.Delegate1(this.method_87);
		this.dictionary_0[25U] = new GClass15.Delegate1(this.method_93);
		this.dictionary_0[26U] = new GClass15.Delegate1(this.method_102);
		this.dictionary_0[27U] = new GClass15.Delegate1(this.method_80);
		this.dictionary_0[28U] = new GClass15.Delegate1(this.method_88);
		this.dictionary_0[29U] = new GClass15.Delegate1(this.method_52);
		this.dictionary_0[30U] = new GClass15.Delegate1(this.method_56);
		this.dictionary_0[31U] = new GClass15.Delegate1(this.method_9);
		this.dictionary_0[32U] = new GClass15.Delegate1(this.method_40);
		this.dictionary_0[33U] = new GClass15.Delegate1(this.method_59);
		this.dictionary_0[34U] = new GClass15.Delegate1(this.method_65);
		this.dictionary_0[35U] = new GClass15.Delegate1(this.method_73);
		this.dictionary_0[36U] = new GClass15.Delegate1(this.method_108);
		this.dictionary_0[37U] = new GClass15.Delegate1(this.method_110);
		this.dictionary_0[38U] = new GClass15.Delegate1(this.method_103);
		this.dictionary_0[39U] = new GClass15.Delegate1(this.method_70);
		this.dictionary_0[40U] = new GClass15.Delegate1(this.method_66);
		this.dictionary_0[41U] = new GClass15.Delegate1(this.method_78);
		this.dictionary_0[42U] = new GClass15.Delegate1(this.method_61);
		this.dictionary_0[43U] = new GClass15.Delegate1(this.method_100);
		this.dictionary_0[44U] = new GClass15.Delegate1(this.method_39);
		this.dictionary_0[45U] = new GClass15.Delegate1(this.method_42);
		this.dictionary_0[46U] = new GClass15.Delegate1(this.method_96);
		this.dictionary_0[47U] = new GClass15.Delegate1(this.method_64);
		this.dictionary_0[48U] = new GClass15.Delegate1(this.method_92);
		this.dictionary_0[49U] = new GClass15.Delegate1(this.method_85);
		this.dictionary_0[50U] = new GClass15.Delegate1(this.method_104);
		this.dictionary_0[51U] = new GClass15.Delegate1(this.method_48);
		this.dictionary_0[52U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[53U] = new GClass15.Delegate1(this.method_86);
		this.dictionary_0[54U] = new GClass15.Delegate1(this.method_68);
		this.dictionary_0[55U] = new GClass15.Delegate1(this.method_43);
		this.dictionary_0[56U] = new GClass15.Delegate1(this.method_101);
		this.dictionary_0[57U] = new GClass15.Delegate1(this.method_35);
		this.dictionary_0[58U] = new GClass15.Delegate1(this.method_109);
		this.dictionary_0[59U] = new GClass15.Delegate1(this.method_105);
		this.dictionary_0[60U] = new GClass15.Delegate1(this.method_81);
		this.dictionary_0[61U] = new GClass15.Delegate1(this.method_91);
		this.dictionary_0[62U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[63U] = new GClass15.Delegate1(this.method_84);
		this.dictionary_0[64U] = new GClass15.Delegate1(this.method_107);
		this.dictionary_0[65U] = new GClass15.Delegate1(this.method_94);
		this.dictionary_0[66U] = new GClass15.Delegate1(this.method_45);
		this.dictionary_0[67U] = new GClass15.Delegate1(this.method_71);
		this.dictionary_0[68U] = new GClass15.Delegate1(this.method_51);
		this.dictionary_0[69U] = new GClass15.Delegate1(this.method_41);
		this.dictionary_0[70U] = new GClass15.Delegate1(this.method_50);
		this.dictionary_0[71U] = new GClass15.Delegate1(this.method_83);
		this.dictionary_0[72U] = new GClass15.Delegate1(this.method_62);
		this.dictionary_0[73U] = new GClass15.Delegate1(this.method_98);
		this.dictionary_0[74U] = new GClass15.Delegate1(this.method_79);
		this.dictionary_0[75U] = new GClass15.Delegate1(this.method_72);
		this.dictionary_0[76U] = new GClass15.Delegate1(this.method_77);
		this.dictionary_0[77U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[78U] = new GClass15.Delegate1(this.method_70);
		this.dictionary_0[79U] = new GClass15.Delegate1(this.method_52);
		this.dictionary_0[80U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[81U] = new GClass15.Delegate1(this.method_91);
		this.dictionary_0[82U] = new GClass15.Delegate1(this.method_99);
		this.dictionary_0[83U] = new GClass15.Delegate1(this.method_54);
		this.dictionary_0[84U] = new GClass15.Delegate1(this.method_91);
		this.dictionary_0[85U] = new GClass15.Delegate1(this.method_96);
		this.dictionary_0[86U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[87U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[88U] = new GClass15.Delegate1(this.method_36);
		this.dictionary_0[89U] = new GClass15.Delegate1(this.method_61);
		this.dictionary_0[90U] = new GClass15.Delegate1(this.method_88);
		this.dictionary_0[91U] = new GClass15.Delegate1(this.method_85);
		this.dictionary_0[92U] = new GClass15.Delegate1(this.method_72);
		this.dictionary_0[93U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[94U] = new GClass15.Delegate1(this.method_60);
		this.dictionary_0[95U] = new GClass15.Delegate1(this.method_42);
		this.dictionary_0[96U] = new GClass15.Delegate1(this.method_50);
		this.dictionary_0[97U] = new GClass15.Delegate1(this.method_36);
		this.dictionary_0[98U] = new GClass15.Delegate1(this.method_79);
		this.dictionary_0[99U] = new GClass15.Delegate1(this.method_77);
		this.dictionary_0[100U] = new GClass15.Delegate1(this.method_91);
		this.dictionary_0[101U] = new GClass15.Delegate1(this.method_45);
		this.dictionary_0[102U] = new GClass15.Delegate1(this.method_78);
		this.dictionary_0[103U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[104U] = new GClass15.Delegate1(this.method_87);
		this.dictionary_0[105U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[106U] = new GClass15.Delegate1(this.method_76);
		this.dictionary_0[107U] = new GClass15.Delegate1(this.method_40);
		this.dictionary_0[108U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[109U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[110U] = new GClass15.Delegate1(this.method_97);
		this.dictionary_0[111U] = new GClass15.Delegate1(this.method_68);
		this.dictionary_0[112U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[113U] = new GClass15.Delegate1(this.method_55);
		this.dictionary_0[114U] = new GClass15.Delegate1(this.method_85);
		this.dictionary_0[115U] = new GClass15.Delegate1(this.method_55);
		this.dictionary_0[116U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[117U] = new GClass15.Delegate1(this.method_85);
		this.dictionary_0[118U] = new GClass15.Delegate1(this.method_36);
		this.dictionary_0[119U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[120U] = new GClass15.Delegate1(this.method_87);
		this.dictionary_0[121U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[122U] = new GClass15.Delegate1(this.method_40);
		this.dictionary_0[123U] = new GClass15.Delegate1(this.method_78);
		this.dictionary_0[124U] = new GClass15.Delegate1(this.method_68);
		this.dictionary_0[125U] = new GClass15.Delegate1(this.method_61);
		this.dictionary_0[126U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[127U] = new GClass15.Delegate1(this.method_73);
		this.dictionary_0[128U] = new GClass15.Delegate1(this.method_60);
		this.dictionary_0[129U] = new GClass15.Delegate1(this.method_68);
		this.dictionary_0[130U] = new GClass15.Delegate1(this.method_99);
		this.dictionary_0[131U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[132U] = new GClass15.Delegate1(this.method_37);
		this.dictionary_0[133U] = new GClass15.Delegate1(this.method_67);
		this.dictionary_0[134U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[135U] = new GClass15.Delegate1(this.method_62);
		this.dictionary_0[136U] = new GClass15.Delegate1(this.method_98);
		this.dictionary_0[137U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[138U] = new GClass15.Delegate1(this.method_109);
		this.dictionary_0[139U] = new GClass15.Delegate1(this.method_94);
		this.dictionary_0[140U] = new GClass15.Delegate1(this.method_103);
		this.dictionary_0[141U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[142U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[143U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[144U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[145U] = new GClass15.Delegate1(this.method_110);
		this.dictionary_0[146U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[147U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[148U] = new GClass15.Delegate1(this.method_56);
		this.dictionary_0[149U] = new GClass15.Delegate1(this.method_47);
		this.dictionary_0[150U] = new GClass15.Delegate1(this.method_78);
		this.dictionary_0[151U] = new GClass15.Delegate1(this.method_59);
		this.dictionary_0[152U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[153U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[154U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[155U] = new GClass15.Delegate1(this.method_82);
		this.dictionary_0[156U] = new GClass15.Delegate1(this.method_73);
		this.dictionary_0[157U] = new GClass15.Delegate1(this.method_97);
		this.dictionary_0[158U] = new GClass15.Delegate1(this.method_97);
		this.dictionary_0[159U] = new GClass15.Delegate1(this.method_110);
		this.dictionary_0[160U] = new GClass15.Delegate1(this.method_97);
		this.dictionary_0[161U] = new GClass15.Delegate1(this.method_110);
		this.dictionary_0[162U] = new GClass15.Delegate1(this.method_45);
		this.dictionary_0[163U] = new GClass15.Delegate1(this.method_100);
		this.dictionary_0[164U] = new GClass15.Delegate1(this.method_50);
		this.dictionary_0[165U] = new GClass15.Delegate1(this.method_42);
		this.dictionary_0[166U] = new GClass15.Delegate1(this.method_96);
		this.dictionary_0[167U] = new GClass15.Delegate1(this.method_101);
		this.dictionary_0[168U] = new GClass15.Delegate1(this.method_49);
		this.dictionary_0[169U] = new GClass15.Delegate1(this.method_91);
		this.dictionary_0[170U] = new GClass15.Delegate1(this.method_85);
		this.dictionary_0[171U] = new GClass15.Delegate1(this.method_59);
		this.dictionary_0[172U] = new GClass15.Delegate1(this.method_78);
		this.dictionary_0[173U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[174U] = new GClass15.Delegate1(this.method_78);
		this.dictionary_0[175U] = new GClass15.Delegate1(this.method_101);
		this.dictionary_0[176U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[177U] = new GClass15.Delegate1(this.method_83);
		this.dictionary_0[178U] = new GClass15.Delegate1(this.method_108);
		this.dictionary_0[179U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[180U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[181U] = new GClass15.Delegate1(this.method_80);
		this.dictionary_0[182U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[183U] = new GClass15.Delegate1(this.method_97);
		this.dictionary_0[184U] = new GClass15.Delegate1(this.method_97);
		this.dictionary_0[185U] = new GClass15.Delegate1(this.method_110);
		this.dictionary_0[186U] = new GClass15.Delegate1(this.method_61);
		this.dictionary_0[187U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[188U] = new GClass15.Delegate1(this.method_102);
		this.dictionary_0[189U] = new GClass15.Delegate1(this.method_45);
		this.dictionary_0[190U] = new GClass15.Delegate1(this.method_49);
		this.dictionary_0[191U] = new GClass15.Delegate1(this.method_50);
		this.dictionary_0[192U] = new GClass15.Delegate1(this.method_78);
		this.dictionary_0[193U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[194U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[195U] = new GClass15.Delegate1(this.method_104);
		this.dictionary_0[196U] = new GClass15.Delegate1(this.method_70);
		this.dictionary_0[197U] = new GClass15.Delegate1(this.method_102);
		this.dictionary_0[198U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[199U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[200U] = new GClass15.Delegate1(this.method_59);
		this.dictionary_0[201U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[202U] = new GClass15.Delegate1(this.method_50);
		this.dictionary_0[203U] = new GClass15.Delegate1(this.method_77);
		this.dictionary_0[204U] = new GClass15.Delegate1(this.method_72);
		this.dictionary_0[205U] = new GClass15.Delegate1(this.method_57);
		this.dictionary_0[206U] = new GClass15.Delegate1(this.method_65);
		this.dictionary_0[207U] = new GClass15.Delegate1(this.method_45);
		this.dictionary_0[208U] = new GClass15.Delegate1(this.method_73);
		this.dictionary_0[209U] = new GClass15.Delegate1(this.method_73);
		this.dictionary_0[210U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[211U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[212U] = new GClass15.Delegate1(this.method_93);
		this.dictionary_0[213U] = new GClass15.Delegate1(this.method_85);
		this.dictionary_0[214U] = new GClass15.Delegate1(this.method_76);
		this.dictionary_0[215U] = new GClass15.Delegate1(this.method_70);
		this.dictionary_0[216U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[217U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[218U] = new GClass15.Delegate1(this.method_97);
		this.dictionary_0[219U] = new GClass15.Delegate1(this.method_110);
		this.dictionary_0[220U] = new GClass15.Delegate1(this.method_40);
		this.dictionary_0[221U] = new GClass15.Delegate1(this.method_104);
		this.dictionary_0[222U] = new GClass15.Delegate1(this.method_99);
		this.dictionary_0[223U] = new GClass15.Delegate1(this.method_105);
		this.dictionary_0[224U] = new GClass15.Delegate1(this.method_85);
		this.dictionary_0[225U] = new GClass15.Delegate1(this.method_60);
		this.dictionary_0[226U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[227U] = new GClass15.Delegate1(this.method_91);
		this.dictionary_0[228U] = new GClass15.Delegate1(this.method_77);
		this.dictionary_0[229U] = new GClass15.Delegate1(this.method_77);
		this.dictionary_0[230U] = new GClass15.Delegate1(this.method_60);
		this.dictionary_0[231U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[232U] = new GClass15.Delegate1(this.method_40);
		this.dictionary_0[233U] = new GClass15.Delegate1(this.method_64);
		this.dictionary_0[234U] = new GClass15.Delegate1(this.method_49);
		this.dictionary_0[235U] = new GClass15.Delegate1(this.method_108);
		this.dictionary_0[236U] = new GClass15.Delegate1(this.method_78);
		this.dictionary_0[237U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[238U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[239U] = new GClass15.Delegate1(this.method_37);
		this.dictionary_0[240U] = new GClass15.Delegate1(this.method_44);
		this.dictionary_0[241U] = new GClass15.Delegate1(this.method_90);
		this.dictionary_0[242U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[243U] = new GClass15.Delegate1(this.method_89);
		this.dictionary_0[244U] = new GClass15.Delegate1(this.method_49);
		this.dictionary_0[245U] = new GClass15.Delegate1(this.method_69);
		this.dictionary_0[246U] = new GClass15.Delegate1(this.method_96);
		this.dictionary_0[247U] = new GClass15.Delegate1(this.method_77);
		this.dictionary_0[248U] = new GClass15.Delegate1(this.method_55);
		this.dictionary_0[249U] = new GClass15.Delegate1(this.method_99);
		this.dictionary_0[250U] = new GClass15.Delegate1(this.method_95);
		this.dictionary_0[251U] = new GClass15.Delegate1(this.method_40);
		this.dictionary_0[252U] = new GClass15.Delegate1(this.method_73);
		this.dictionary_0[253U] = new GClass15.Delegate1(this.method_56);
		this.dictionary_0[254U] = new GClass15.Delegate1(this.method_60);
		this.dictionary_0[255U] = new GClass15.Delegate1(this.method_49);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x5FF13174 File Offset: 0x5FF07F74
	private void method_0(GClass15.Class2 class2_0)
	{
		this.stack_0.Push(class2_0.vmethod_4());
	}

	// Token: 0x06000115 RID: 277 RVA: 0x5FF13194 File Offset: 0x5FF07F94
	private GClass15.Class2 method_1()
	{
		return this.stack_0.Pop();
	}

	// Token: 0x06000116 RID: 278 RVA: 0x5FF131B0 File Offset: 0x5FF07FB0
	private GClass15.Class2 method_2()
	{
		return this.stack_0.Peek();
	}

	// Token: 0x06000117 RID: 279 RVA: 0x5FF131CC File Offset: 0x5FF07FCC
	private byte method_3()
	{
		byte result = Marshal.ReadByte(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0++;
		return result;
	}

	// Token: 0x06000118 RID: 280 RVA: 0x5FF13200 File Offset: 0x5FF08000
	private short method_4()
	{
		short result = Marshal.ReadInt16(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 2;
		return result;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x5FF13234 File Offset: 0x5FF08034
	private int method_5()
	{
		int result = Marshal.ReadInt32(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 4;
		return result;
	}

	// Token: 0x0600011A RID: 282 RVA: 0x5FF13268 File Offset: 0x5FF08068
	private long method_6()
	{
		long result = Marshal.ReadInt64(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 8;
		return result;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x5FF1329C File Offset: 0x5FF0809C
	private float method_7()
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(this.method_5()), 0);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x5FF132BC File Offset: 0x5FF080BC
	private double method_8()
	{
		return BitConverter.ToDouble(BitConverter.GetBytes(this.method_6()), 0);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x5FF132DC File Offset: 0x5FF080DC
	private void method_9()
	{
		byte byte_ = this.method_3();
		int num = this.method_5();
		int num2 = this.method_5();
		int int_ = this.method_5();
		int int_2 = this.method_5();
		GClass15.Class32 @class = null;
		for (int i = 0; i < this.list_1.Count; i++)
		{
			GClass15.Class32 class2 = this.list_1[i];
			if (class2.method_0() == num && class2.method_1() == num2)
			{
				@class = class2;
				IL_6D:
				if (@class == null)
				{
					bool flag = false;
					@class = new GClass15.Class32(num, num2);
					int j = 0;
					while (j < this.list_1.Count)
					{
						GClass15.Class32 class32_ = this.list_1[j];
						if (@class.method_2(class32_) >= 0)
						{
							j++;
						}
						else
						{
							this.list_1.Insert(j, @class);
							flag = true;
							IL_C6:
							if (!flag)
							{
								this.list_1.Add(@class);
								goto IL_D7;
							}
							goto IL_D7;
						}
					}
					goto IL_C6;
				}
				IL_D7:
				@class.method_3(byte_, int_, int_2);
				return;
			}
		}
		goto IL_6D;
	}

	// Token: 0x0600011E RID: 286 RVA: 0x5FF133CC File Offset: 0x5FF081CC
	private TypeCode method_10(GClass15.Class2 class2_0, GClass15.Class2 class2_1)
	{
		TypeCode typeCode = class2_0.vmethod_7();
		TypeCode typeCode2 = class2_1.vmethod_7();
		if (typeCode != TypeCode.Empty && typeCode != TypeCode.Object && typeCode2 != TypeCode.Empty)
		{
			if (typeCode2 != TypeCode.Object)
			{
				if (typeCode == TypeCode.UInt32)
				{
					if (typeCode2 != TypeCode.Int32)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
				else if (typeCode2 == TypeCode.UInt32)
				{
					if (typeCode != TypeCode.Int32)
					{
						return TypeCode.Empty;
					}
					return typeCode2;
				}
				else if (typeCode == TypeCode.UInt64)
				{
					if (typeCode2 != TypeCode.Int32 && typeCode2 != TypeCode.Int64)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
				else
				{
					if (typeCode2 != TypeCode.UInt64)
					{
						if (typeCode != TypeCode.Double)
						{
							if (typeCode2 != TypeCode.Double)
							{
								if (typeCode != TypeCode.Single)
								{
									if (typeCode2 != TypeCode.Single)
									{
										if (typeCode != TypeCode.Int64)
										{
											if (typeCode2 != TypeCode.Int64)
											{
												return TypeCode.Int32;
											}
										}
										return TypeCode.Int64;
									}
								}
								return TypeCode.Single;
							}
						}
						return TypeCode.Double;
					}
					if (typeCode != TypeCode.Int32 && typeCode != TypeCode.Int64)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
			}
		}
		return TypeCode.Empty;
	}

	// Token: 0x0600011F RID: 287 RVA: 0x5FF1346C File Offset: 0x5FF0826C
	private GClass15.Class2 method_11(GClass15.Class2 class2_0, GClass15.Class2 class2_1, bool bool_0, bool bool_1)
	{
		TypeCode typeCode = this.method_10(class2_0, class2_1);
		switch (typeCode)
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num = class2_0.vmethod_11();
				uint num2 = class2_1.vmethod_11();
				int_ = (int)(bool_0 ? checked(num + num2) : (num + num2));
			}
			else
			{
				int num3 = class2_0.F877E806();
				int num4 = class2_1.F877E806();
				int_ = (bool_0 ? checked(num3 + num4) : (num3 + num4));
			}
			return new GClass15.Class4(int_);
		}
		case TypeCode.UInt32:
		{
			int value;
			if (bool_1)
			{
				uint num5 = class2_0.vmethod_11();
				uint num6 = class2_1.vmethod_11();
				value = (int)(bool_0 ? checked(num5 + num6) : (num5 + num6));
			}
			else
			{
				int num7 = class2_0.F877E806();
				int num8 = class2_1.F877E806();
				value = (bool_0 ? checked(num7 + num8) : (num7 + num8));
			}
			GClass15.Class10 @class = (class2_0.vmethod_7() == typeCode) ? ((GClass15.Class10)class2_0) : ((GClass15.Class10)class2_1);
			return new GClass15.Class10(Pointer.Box(new IntPtr(value).ToPointer(), @class.method_0()), @class.method_0());
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num9 = class2_0.vmethod_12();
				ulong num10 = class2_1.vmethod_12();
				long_ = (long)(bool_0 ? checked(num9 + num10) : (num9 + num10));
			}
			else
			{
				long num11 = class2_0.CFA1D037();
				long num12 = class2_1.CFA1D037();
				long_ = (bool_0 ? checked(num11 + num12) : (num11 + num12));
			}
			return new GClass15.Class5(long_);
		}
		case TypeCode.UInt64:
		{
			long value2;
			if (bool_1)
			{
				ulong num13 = class2_0.vmethod_12();
				ulong num14 = class2_1.vmethod_12();
				value2 = (long)(bool_0 ? checked(num13 + num14) : (num13 + num14));
			}
			else
			{
				long num15 = class2_0.CFA1D037();
				long num16 = class2_1.CFA1D037();
				value2 = (bool_0 ? checked(num15 + num16) : (num15 + num16));
			}
			GClass15.Class10 class2 = (class2_0.vmethod_7() == typeCode) ? ((GClass15.Class10)class2_0) : ((GClass15.Class10)class2_1);
			return new GClass15.Class10(Pointer.Box(new IntPtr(value2).ToPointer(), class2.method_0()), class2.method_0());
		}
		case TypeCode.Single:
		{
			float num17 = (bool_1 ? class2_0.vmethod_5() : class2_0).A08827DF();
			float num18 = (bool_1 ? class2_1.vmethod_5() : class2_1).A08827DF();
			return new GClass15.Class6(bool_0 ? (num17 + num18) : (num17 + num18));
		}
		case TypeCode.Double:
		{
			double num19 = (bool_1 ? class2_0.vmethod_5() : class2_0).vmethod_13();
			double num20 = (bool_1 ? class2_1.vmethod_5() : class2_1).vmethod_13();
			return new GClass15.Class7(bool_0 ? (num19 + num20) : (num19 + num20));
		}
		default:
			throw new InvalidOperationException();
		}
	}

	// Token: 0x06000120 RID: 288 RVA: 0x5FF136D0 File Offset: 0x5FF084D0
	private GClass15.Class2 method_12(GClass15.Class2 class2_0, GClass15.Class2 class2_1, bool bool_0, bool bool_1)
	{
		TypeCode typeCode = this.method_10(class2_0, class2_1);
		switch (typeCode)
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num = class2_0.vmethod_11();
				uint num2 = class2_1.vmethod_11();
				int_ = (int)(bool_0 ? checked(num - num2) : (num - num2));
			}
			else
			{
				int num3 = class2_0.F877E806();
				int num4 = class2_1.F877E806();
				int_ = (bool_0 ? checked(num3 - num4) : (num3 - num4));
			}
			return new GClass15.Class4(int_);
		}
		case TypeCode.UInt32:
		{
			int value;
			if (bool_1)
			{
				uint num5 = class2_0.vmethod_11();
				uint num6 = class2_1.vmethod_11();
				value = (int)(bool_0 ? checked(num5 - num6) : (num5 - num6));
			}
			else
			{
				int num7 = class2_0.F877E806();
				int num8 = class2_1.F877E806();
				value = (bool_0 ? checked(num7 - num8) : (num7 - num8));
			}
			GClass15.Class10 @class = (class2_0.vmethod_7() == typeCode) ? ((GClass15.Class10)class2_0) : ((GClass15.Class10)class2_1);
			return new GClass15.Class10(Pointer.Box(new IntPtr(value).ToPointer(), @class.method_0()), @class.method_0());
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num9 = class2_0.vmethod_12();
				ulong num10 = class2_1.vmethod_12();
				long_ = (long)(bool_0 ? checked(num9 - num10) : (num9 - num10));
			}
			else
			{
				long num11 = class2_0.CFA1D037();
				long num12 = class2_1.CFA1D037();
				long_ = (bool_0 ? checked(num11 - num12) : (num11 - num12));
			}
			return new GClass15.Class5(long_);
		}
		case TypeCode.UInt64:
		{
			long value2;
			if (bool_1)
			{
				ulong num13 = class2_0.vmethod_12();
				ulong num14 = class2_1.vmethod_12();
				value2 = (long)(bool_0 ? checked(num13 - num14) : (num13 - num14));
			}
			else
			{
				long num15 = class2_0.CFA1D037();
				long num16 = class2_1.CFA1D037();
				value2 = (bool_0 ? checked(num15 - num16) : (num15 - num16));
			}
			GClass15.Class10 class2 = (class2_0.vmethod_7() == typeCode) ? ((GClass15.Class10)class2_0) : ((GClass15.Class10)class2_1);
			return new GClass15.Class10(Pointer.Box(new IntPtr(value2).ToPointer(), class2.method_0()), class2.method_0());
		}
		case TypeCode.Single:
		{
			float num17 = (bool_1 ? class2_0.vmethod_5() : class2_0).A08827DF();
			float num18 = (bool_1 ? class2_1.vmethod_5() : class2_1).A08827DF();
			return new GClass15.Class6(bool_0 ? (num17 - num18) : (num17 - num18));
		}
		case TypeCode.Double:
		{
			double num19 = (bool_1 ? class2_0.vmethod_5() : class2_0).vmethod_13();
			double num20 = (bool_1 ? class2_1.vmethod_5() : class2_1).vmethod_13();
			return new GClass15.Class7(bool_0 ? (num19 - num20) : (num19 - num20));
		}
		default:
			throw new InvalidOperationException();
		}
	}

	// Token: 0x06000121 RID: 289 RVA: 0x5FF13934 File Offset: 0x5FF08734
	private GClass15.Class2 method_13(GClass15.Class2 class2_0, GClass15.Class2 class2_1, bool bool_0, bool bool_1)
	{
		switch (this.method_10(class2_0, class2_1))
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num = class2_0.vmethod_11();
				uint num2 = class2_1.vmethod_11();
				int_ = (int)(bool_0 ? checked(num * num2) : (num * num2));
			}
			else
			{
				int num3 = class2_0.F877E806();
				int num4 = class2_1.F877E806();
				int_ = (bool_0 ? checked(num3 * num4) : (num3 * num4));
			}
			return new GClass15.Class4(int_);
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num5 = class2_0.vmethod_12();
				ulong num6 = class2_1.vmethod_12();
				long_ = (long)(bool_0 ? checked(num5 * num6) : (num5 * num6));
			}
			else
			{
				long num7 = class2_0.CFA1D037();
				long num8 = class2_1.CFA1D037();
				long_ = (bool_0 ? checked(num7 * num8) : (num7 * num8));
			}
			return new GClass15.Class5(long_);
		}
		case TypeCode.Single:
		{
			float num9 = (bool_1 ? class2_0.vmethod_5() : class2_0).A08827DF();
			float num10 = (bool_1 ? class2_1.vmethod_5() : class2_1).A08827DF();
			return new GClass15.Class7((double)(bool_0 ? (num9 * num10) : (num9 * num10)));
		}
		case TypeCode.Double:
		{
			double num11 = (bool_1 ? class2_0.vmethod_5() : class2_0).vmethod_13();
			double num12 = (bool_1 ? class2_1.vmethod_5() : class2_1).vmethod_13();
			return new GClass15.Class7(bool_0 ? (num11 * num12) : (num11 * num12));
		}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000122 RID: 290 RVA: 0x5FF13A8C File Offset: 0x5FF0888C
	private GClass15.Class2 method_14(GClass15.Class2 class2_0, GClass15.Class2 class2_1, bool bool_0)
	{
		switch (this.method_10(class2_0, class2_1))
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_0)
			{
				int num = (int)class2_0.vmethod_11();
				uint num2 = class2_1.vmethod_11();
				int_ = num / (int)num2;
			}
			else
			{
				int num3 = class2_0.F877E806();
				int num4 = class2_1.F877E806();
				int_ = num3 / num4;
			}
			return new GClass15.Class4(int_);
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_0)
			{
				long num5 = (long)class2_0.vmethod_12();
				ulong num6 = class2_1.vmethod_12();
				long_ = num5 / (long)num6;
			}
			else
			{
				long num7 = class2_0.CFA1D037();
				long num8 = class2_1.CFA1D037();
				long_ = num7 / num8;
			}
			return new GClass15.Class5(long_);
		}
		case TypeCode.Single:
		{
			float num9 = (bool_0 ? class2_0.vmethod_5() : class2_0).A08827DF();
			float num10 = (bool_0 ? class2_1.vmethod_5() : class2_1).A08827DF();
			return new GClass15.Class6(num9 / num10);
		}
		case TypeCode.Double:
		{
			double num11 = (bool_0 ? class2_0.vmethod_5() : class2_0).vmethod_13();
			double num12 = (bool_0 ? class2_1.vmethod_5() : class2_1).vmethod_13();
			return new GClass15.Class7(num11 / num12);
		}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000123 RID: 291 RVA: 0x5FF13B88 File Offset: 0x5FF08988
	private GClass15.Class2 method_15(GClass15.Class2 class2_0, GClass15.Class2 class2_1, bool bool_0)
	{
		TypeCode typeCode = class2_0.vmethod_7();
		if (typeCode != TypeCode.Int32)
		{
			if (typeCode != TypeCode.Int64)
			{
				throw new InvalidOperationException();
			}
			if (bool_0)
			{
				long num = (long)class2_0.vmethod_12();
				ulong num2 = class2_1.vmethod_12();
				return new GClass15.Class5(num % (long)num2);
			}
			long num3 = class2_0.CFA1D037();
			long num4 = class2_1.CFA1D037();
			return new GClass15.Class5(num3 % num4);
		}
		else
		{
			if (bool_0)
			{
				int num5 = (int)class2_0.vmethod_11();
				uint num6 = class2_1.vmethod_11();
				return new GClass15.Class4(num5 % (int)num6);
			}
			int num7 = class2_0.F877E806();
			int num8 = class2_1.F877E806();
			return new GClass15.Class4(num7 % num8);
		}
	}

	// Token: 0x06000124 RID: 292 RVA: 0x5FF13C0C File Offset: 0x5FF08A0C
	private GClass15.Class2 method_16(GClass15.Class2 class2_0, GClass15.Class2 class2_1)
	{
		switch (this.method_10(class2_0, class2_1))
		{
		case TypeCode.Int32:
		{
			int num = class2_0.F877E806();
			int num2 = class2_1.F877E806();
			return new GClass15.Class4(num ^ num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class2_0.CFA1D037();
			long num4 = class2_1.CFA1D037();
			return new GClass15.Class5(num3 ^ num4);
		}
		case TypeCode.Single:
			return new GClass15.Class6((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass15.Class7((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000125 RID: 293 RVA: 0x5FF13CB0 File Offset: 0x5FF08AB0
	private GClass15.Class2 method_17(GClass15.Class2 class2_0, GClass15.Class2 class2_1)
	{
		switch (this.method_10(class2_0, class2_1))
		{
		case TypeCode.Int32:
		{
			int num = class2_0.F877E806();
			int num2 = class2_1.F877E806();
			return new GClass15.Class4(num | num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class2_0.CFA1D037();
			long num4 = class2_1.CFA1D037();
			return new GClass15.Class5(num3 | num4);
		}
		case TypeCode.Single:
			return new GClass15.Class6((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass15.Class7((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000126 RID: 294 RVA: 0x5FF13D54 File Offset: 0x5FF08B54
	private GClass15.Class2 method_18(GClass15.Class2 class2_0, GClass15.Class2 class2_1)
	{
		switch (this.method_10(class2_0, class2_1))
		{
		case TypeCode.Int32:
		{
			int num = class2_0.F877E806();
			int num2 = class2_1.F877E806();
			return new GClass15.Class4(num & num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class2_0.CFA1D037();
			long num4 = class2_1.CFA1D037();
			return new GClass15.Class5(num3 & num4);
		}
		case TypeCode.Single:
			return new GClass15.Class6((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass15.Class7((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x06000127 RID: 295 RVA: 0x5FF13DF8 File Offset: 0x5FF08BF8
	private int method_19(GClass15.Class2 class2_0, GClass15.Class2 class2_1, bool bool_0, int int_1)
	{
		int num = int_1;
		TypeCode typeCode = class2_0.vmethod_7();
		TypeCode typeCode2 = class2_1.vmethod_7();
		if (typeCode != TypeCode.Object)
		{
			if (typeCode2 != TypeCode.Object)
			{
				if (typeCode != TypeCode.Double)
				{
					if (typeCode2 != TypeCode.Double)
					{
						if (typeCode != TypeCode.Single)
						{
							if (typeCode2 != TypeCode.Single)
							{
								if (typeCode != TypeCode.Int64)
								{
									if (typeCode2 != TypeCode.Int64)
									{
										if (typeCode == TypeCode.Int32 || typeCode2 == TypeCode.Int32)
										{
											num = (bool_0 ? class2_0.vmethod_11().CompareTo(class2_1.vmethod_11()) : class2_0.F877E806().CompareTo(class2_1.F877E806()));
											goto IL_119;
										}
										goto IL_119;
									}
								}
								num = (bool_0 ? class2_0.vmethod_12().CompareTo(class2_1.vmethod_12()) : class2_0.CFA1D037().CompareTo(class2_1.CFA1D037()));
								goto IL_119;
							}
						}
						num = class2_0.A08827DF().CompareTo(class2_1.A08827DF());
						goto IL_119;
					}
				}
				num = class2_0.vmethod_13().CompareTo(class2_1.vmethod_13());
				goto IL_119;
			}
		}
		object obj = class2_0.vmethod_1();
		object obj2 = class2_1.vmethod_1();
		if (obj == obj2)
		{
			return 0;
		}
		if (obj2 == null)
		{
			return 1;
		}
		if (obj == null)
		{
			return -1;
		}
		IL_119:
		if (num < 0)
		{
			num = -1;
		}
		else if (num > 0)
		{
			num = 1;
		}
		return num;
	}

	// Token: 0x06000128 RID: 296 RVA: 0x5FF13F30 File Offset: 0x5FF08D30
	private GClass15.Class2 method_20(GClass15.Class2 class2_0)
	{
		TypeCode typeCode = class2_0.vmethod_7();
		if (typeCode == TypeCode.Int32)
		{
			return new GClass15.Class4(~class2_0.F877E806());
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		return new GClass15.Class5(~class2_0.CFA1D037());
	}

	// Token: 0x06000129 RID: 297 RVA: 0x5FF13F70 File Offset: 0x5FF08D70
	private GClass15.Class2 method_21(GClass15.Class2 class2_0)
	{
		switch (class2_0.vmethod_7())
		{
		case TypeCode.Int32:
			return new GClass15.Class4(-class2_0.F877E806());
		case TypeCode.Int64:
			return new GClass15.Class5(-class2_0.CFA1D037());
		case TypeCode.Single:
			return new GClass15.Class6(-class2_0.A08827DF());
		case TypeCode.Double:
			return new GClass15.Class7(-class2_0.vmethod_13());
		}
		throw new InvalidOperationException();
	}

	// Token: 0x0600012A RID: 298 RVA: 0x5FF13FE0 File Offset: 0x5FF08DE0
	private GClass15.Class2 method_22(GClass15.Class2 class2_0, GClass15.Class2 class2_1, bool bool_0)
	{
		TypeCode typeCode = class2_0.vmethod_7();
		if (typeCode != TypeCode.Int32)
		{
			if (typeCode != TypeCode.Int64)
			{
				throw new InvalidOperationException();
			}
			if (bool_0)
			{
				ulong num = class2_0.vmethod_12();
				int num2 = class2_1.F877E806();
				return new GClass15.Class5(num >> (num2 & 63));
			}
			long num3 = class2_0.CFA1D037();
			int num4 = class2_1.F877E806();
			return new GClass15.Class5(num3 >> (num4 & 63));
		}
		else
		{
			if (bool_0)
			{
				uint num5 = class2_0.vmethod_11();
				int num6 = class2_1.F877E806();
				return new GClass15.Class4(num5 >> (num6 & 31));
			}
			int num7 = class2_0.F877E806();
			int num8 = class2_1.F877E806();
			return new GClass15.Class4(num7 >> (num8 & 31));
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x5FF14070 File Offset: 0x5FF08E70
	private GClass15.Class2 method_23(GClass15.Class2 class2_0, GClass15.Class2 class2_1)
	{
		TypeCode typeCode = class2_0.vmethod_7();
		if (typeCode == TypeCode.Int32)
		{
			int num = class2_0.F877E806();
			int num2 = class2_1.F877E806();
			return new GClass15.Class4(num << num2);
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		long num3 = class2_0.CFA1D037();
		int num4 = class2_1.F877E806();
		return new GClass15.Class5(num3 << num4);
	}

	// Token: 0x0600012C RID: 300 RVA: 0x5FF140C4 File Offset: 0x5FF08EC4
	private GClass15.Class2 method_24(object object_0, Type type_1)
	{
		GClass15.Class2 @class = object_0 as GClass15.Class2;
		if (type_1.IsEnum)
		{
			if (@class != null)
			{
				object_0 = @class.vmethod_1();
			}
			if (object_0 != null && !(object_0 is Enum))
			{
				object_0 = Enum.ToObject(type_1, object_0);
			}
			return new GClass15.Class22((object_0 == null) ? ((Enum)Activator.CreateInstance(type_1)) : ((Enum)object_0));
		}
		switch (Type.GetTypeCode(type_1))
		{
		case TypeCode.Boolean:
			return new GClass15.Class25((@class != null) ? @class.vmethod_8() : Convert.ToBoolean(object_0));
		case TypeCode.Char:
			return new GClass15.Class26((@class != null) ? @class.E6138F88() : Convert.ToChar(object_0));
		case TypeCode.SByte:
			return new GClass15.Class28((@class != null) ? @class.vmethod_9() : Convert.ToSByte(object_0));
		case TypeCode.Byte:
			return new GClass15.Class27((@class != null) ? @class.vmethod_10() : Convert.ToByte(object_0));
		case TypeCode.Int16:
			return new GClass15.Class23((@class != null) ? @class.FCCCFC2F() : Convert.ToInt16(object_0));
		case TypeCode.UInt16:
			return new GClass15.Class24((@class != null) ? @class.C7D32E95() : Convert.ToUInt16(object_0));
		case TypeCode.Int32:
			return new GClass15.Class4((@class != null) ? @class.F877E806() : Convert.ToInt32(object_0));
		case TypeCode.UInt32:
			return new GClass15.Class29((@class != null) ? @class.vmethod_11() : Convert.ToUInt32(object_0));
		case TypeCode.Int64:
			return new GClass15.Class5((@class != null) ? @class.CFA1D037() : Convert.ToInt64(object_0));
		case TypeCode.UInt64:
			return new GClass15.Class30((@class != null) ? @class.vmethod_12() : Convert.ToUInt64(object_0));
		case TypeCode.Single:
			return new GClass15.Class6((@class != null) ? @class.A08827DF() : Convert.ToSingle(object_0));
		case TypeCode.Double:
			return new GClass15.Class7((@class != null) ? @class.vmethod_13() : Convert.ToDouble(object_0));
		case TypeCode.String:
			return new GClass15.Class8((@class != null) ? @class.ToString() : ((string)object_0));
		}
		if (type_1 == typeof(IntPtr))
		{
			if (@class != null)
			{
				return new GClass15.Class20(@class.A295314C());
			}
			return new GClass15.Class20((object_0 != null) ? ((IntPtr)object_0) : IntPtr.Zero);
		}
		else if (type_1 == typeof(UIntPtr))
		{
			if (@class != null)
			{
				return new GClass15.Class21(@class.vmethod_14());
			}
			return new GClass15.Class21((object_0 != null) ? ((UIntPtr)object_0) : UIntPtr.Zero);
		}
		else if (type_1.IsValueType)
		{
			if (@class != null)
			{
				return new GClass15.Class11(@class.vmethod_1());
			}
			return new GClass15.Class11((object_0 == null) ? Activator.CreateInstance(type_1) : object_0);
		}
		else
		{
			if (type_1.IsArray)
			{
				return new GClass15.Class12((@class != null) ? ((Array)@class.vmethod_1()) : ((Array)object_0));
			}
			if (!type_1.IsPointer)
			{
				return new GClass15.Class9((@class != null) ? @class.vmethod_1() : object_0);
			}
			if (@class != null)
			{
				return new GClass15.Class10(Pointer.Box(Pointer.Unbox(@class.vmethod_1()), type_1), type_1);
			}
			return new GClass15.Class10(Pointer.Box((object_0 != null) ? Pointer.Unbox(object_0) : null, type_1), type_1);
		}
	}

	// Token: 0x0600012D RID: 301 RVA: 0x5FF1439C File Offset: 0x5FF0919C
	private string method_25(int int_1)
	{
		Dictionary<int, object> obj = GClass15.dictionary_1;
		string result;
		lock (obj)
		{
			object obj2;
			if (GClass15.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (string)obj2;
			}
			else
			{
				string text = this.module_0.ResolveString(int_1);
				GClass15.dictionary_1.Add(int_1, text);
				result = text;
			}
		}
		return result;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x5FF14408 File Offset: 0x5FF09208
	private Type method_26(int int_1)
	{
		Dictionary<int, object> obj = GClass15.dictionary_1;
		Type result;
		lock (obj)
		{
			object obj2;
			if (GClass15.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (Type)obj2;
			}
			else
			{
				Type type = this.module_0.ResolveType(int_1);
				GClass15.dictionary_1.Add(int_1, type);
				result = type;
			}
		}
		return result;
	}

	// Token: 0x0600012F RID: 303 RVA: 0x5FF14474 File Offset: 0x5FF09274
	private MethodBase method_27(int int_1)
	{
		Dictionary<int, object> obj = GClass15.dictionary_1;
		MethodBase result;
		lock (obj)
		{
			object obj2;
			if (GClass15.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (MethodBase)obj2;
			}
			else
			{
				MethodBase methodBase = this.module_0.ResolveMethod(int_1);
				GClass15.dictionary_1.Add(int_1, methodBase);
				result = methodBase;
			}
		}
		return result;
	}

	// Token: 0x06000130 RID: 304 RVA: 0x5FF144E0 File Offset: 0x5FF092E0
	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> obj = GClass15.dictionary_1;
		FieldInfo result;
		lock (obj)
		{
			object obj2;
			if (GClass15.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (FieldInfo)obj2;
			}
			else
			{
				FieldInfo fieldInfo = this.module_0.ResolveField(int_1);
				GClass15.dictionary_1.Add(int_1, fieldInfo);
				result = fieldInfo;
			}
		}
		return result;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x5FF1454C File Offset: 0x5FF0934C
	private GClass15.Class2 method_29(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Dictionary<int, GClass15.Class2> dictionary = new Dictionary<int, GClass15.Class2>();
		object[] array = new object[parameters.Length];
		for (int i = parameters.Length - 1; i >= 0; i--)
		{
			GClass15.Class2 @class = this.method_1();
			if (@class.vmethod_3())
			{
				dictionary[i] = @class;
			}
			array[i] = this.method_24(@class, parameters[i].ParameterType).vmethod_1();
		}
		object object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
		foreach (KeyValuePair<int, GClass15.Class2> keyValuePair in dictionary)
		{
			keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
		}
		return this.method_24(object_, methodBase_0.DeclaringType);
	}

	// Token: 0x06000132 RID: 306 RVA: 0x5FF14628 File Offset: 0x5FF09428
	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (declaringType.IsGenericType && declaringType.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			if (string.Equals(methodBase_0.Name, "get_HasValue", StringComparison.Ordinal))
			{
				object_1 = (object_0 != null);
			}
			else if (string.Equals(methodBase_0.Name, "get_Value", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					throw new InvalidOperationException();
				}
				object_1 = object_0;
			}
			else if (methodBase_0.Name.Equals("GetValueOrDefault", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
				}
				object_1 = object_0;
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x5FF146D0 File Offset: 0x5FF094D0
	private GClass15.Class2 method_31(MethodBase methodBase_0, bool bool_0)
	{
		MethodInfo methodInfo = methodBase_0 as MethodInfo;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Dictionary<int, GClass15.Class2> dictionary = new Dictionary<int, GClass15.Class2>();
		object[] array = new object[parameters.Length];
		GClass15.Class2 @class;
		for (int i = parameters.Length - 1; i >= 0; i--)
		{
			@class = this.method_1();
			if (@class.vmethod_3())
			{
				dictionary[i] = @class;
			}
			array[i] = this.method_24(@class, parameters[i].ParameterType).vmethod_1();
		}
		@class = (methodBase_0.IsStatic ? null : this.method_1());
		object obj;
		if (@class != null)
		{
			if ((obj = @class.vmethod_1()) != null)
			{
				goto IL_8E;
			}
		}
		obj = null;
		IL_8E:
		object obj2 = obj;
		if (bool_0 && obj2 == null)
		{
			throw new NullReferenceException();
		}
		object object_ = null;
		if (methodBase_0.IsConstructor && methodBase_0.DeclaringType.IsValueType)
		{
			obj2 = Activator.CreateInstance(methodBase_0.DeclaringType, array);
			if (@class != null && @class.vmethod_3())
			{
				@class.vmethod_2(this.method_24(obj2, methodBase_0.DeclaringType).vmethod_1());
			}
		}
		else if (!this.method_30(methodBase_0, obj2, ref object_, array))
		{
			if (!bool_0 && methodBase_0.IsVirtual && !methodBase_0.IsFinal)
			{
				object[] array2 = new object[parameters.Length + 1];
				array2[0] = obj2;
				for (int j = 0; j < parameters.Length; j++)
				{
					array2[j + 1] = array[j];
				}
				Dictionary<MethodBase, DynamicMethod> obj3 = GClass15.dictionary_2;
				DynamicMethod dynamicMethod;
				lock (obj3)
				{
					if (!GClass15.dictionary_2.TryGetValue(methodBase_0, out dynamicMethod))
					{
						Type[] array3 = new Type[array2.Length];
						array3[0] = methodBase_0.DeclaringType;
						for (int k = 0; k < parameters.Length; k++)
						{
							array3[k + 1] = parameters[k].ParameterType;
						}
						string name = "";
						Type returnType;
						if (methodInfo != null)
						{
							if (methodInfo.ReturnType != typeof(void))
							{
								returnType = methodInfo.ReturnType;
								goto IL_1D0;
							}
						}
						returnType = null;
						IL_1D0:
						dynamicMethod = new DynamicMethod(name, returnType, array3, typeof(GClass15).Module, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(@class.vmethod_3() ? OpCodes.Ldarga : OpCodes.Ldarg, 0);
						for (int l = 1; l < array3.Length; l++)
						{
							ilgenerator.Emit(dictionary.ContainsKey(l - 1) ? OpCodes.Ldarga : OpCodes.Ldarg, l);
						}
						ilgenerator.Emit(OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						GClass15.dictionary_2[methodBase_0] = dynamicMethod;
					}
				}
				object_ = dynamicMethod.Invoke(null, array2);
				foreach (KeyValuePair<int, GClass15.Class2> keyValuePair in dictionary)
				{
					keyValuePair.Value.vmethod_2(array2[keyValuePair.Key + 1]);
				}
				dictionary.Clear();
			}
			if (methodBase_0.Name == "CreateFile")
			{
				array[0] = "C:\\Users\\Charms\\Desktop\\Reversing\\vmp.exe";
			}
			object_ = methodBase_0.Invoke(obj2, array);
			if (methodBase_0.Name == "NtQueryInformationProcess")
			{
				object_ = 1;
			}
			if (methodBase_0.Name == "get_IsAttached")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "IsLogging")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "IsDebuggerPresent")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "CheckRemoteDebuggerPresent")
			{
				object_ = false;
			}
		}
		foreach (KeyValuePair<int, GClass15.Class2> keyValuePair2 in dictionary)
		{
			keyValuePair2.Value.vmethod_2(array[keyValuePair2.Key]);
		}
		if (methodInfo != null)
		{
			if (methodInfo.ReturnType != typeof(void))
			{
				return this.method_24(object_, methodInfo.ReturnType);
			}
		}
		return null;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x5FF14B08 File Offset: 0x5FF09908
	private GClass15.Class2 method_32(int int_1, bool bool_0)
	{
		int num = this.int_0;
		this.int_0 = int_1;
		ushort num2 = (ushort)this.method_4();
		Dictionary<int, GClass15.Class2> dictionary = new Dictionary<int, GClass15.Class2>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[(int)num2];
			for (int i = (int)(num2 - 1); i >= 0; i--)
			{
				GClass15.Class2 @class = this.method_1();
				if (@class.vmethod_3())
				{
					dictionary[i] = @class;
				}
				array[i] = this.method_24(@class, this.method_26(this.method_5())).vmethod_1();
			}
		}
		int num3 = this.method_5();
		int_1 = this.int_0;
		this.int_0 = num;
		if (bool_0 && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		object object_ = new GClass15().method_112(array, int_1);
		foreach (KeyValuePair<int, GClass15.Class2> keyValuePair in dictionary)
		{
			keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
		}
		if (num3 != 0)
		{
			Type type = this.method_26(num3);
			if (type != typeof(void))
			{
				return this.method_24(object_, type);
			}
		}
		return null;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x5FF14C40 File Offset: 0x5FF09A40
	private bool method_33(object object_0, Type type_1)
	{
		if (object_0 == null)
		{
			return true;
		}
		Type type = object_0.GetType();
		return type == type_1 || type_1.IsAssignableFrom(type);
	}

	// Token: 0x06000136 RID: 310 RVA: 0x5FF14C6C File Offset: 0x5FF09A6C
	private void method_34(Exception exception_1)
	{
		this.stack_0.Clear();
		this.stack_2.Clear();
		if (this.class31_0 == null)
		{
			this.exception_0 = exception_1;
		}
		while (this.stack_1.Count != 0)
		{
			List<GClass15.Class31> list = this.stack_1.Peek().method_4();
			int num = (this.class31_0 == null) ? 0 : (list.IndexOf(this.class31_0) + 1);
			this.class31_0 = null;
			for (int i = num; i < list.Count; i++)
			{
				GClass15.Class31 @class = list[i];
				byte b = @class.method_0();
				if (b != 0)
				{
					if (b == 1)
					{
						this.class31_0 = @class;
						this.stack_0.Push(new GClass15.Class9(this.exception_0));
						this.int_0 = @class.method_2();
						return;
					}
				}
				else
				{
					Type type = exception_1.GetType();
					Type type2 = this.method_26(@class.method_2());
					if (type == type2 || type.IsSubclassOf(type2))
					{
						this.stack_1.Pop();
						this.stack_0.Push(new GClass15.Class9(this.exception_0));
						this.int_0 = @class.method_1();
						return;
					}
				}
			}
			this.stack_1.Pop();
			for (int j = list.Count; j > 0; j--)
			{
				GClass15.Class31 class2 = list[j - 1];
				if (class2.method_0() == 2 || class2.method_0() == 4)
				{
					this.stack_2.Push(class2.method_1());
				}
			}
			if (this.stack_2.Count != 0)
			{
				this.int_0 = this.stack_2.Pop();
				return;
			}
		}
		throw exception_1;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x5FF14E10 File Offset: 0x5FF09C10
	private void method_35()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_1();
		GClass15.Class2 class2 = this.method_24(this.method_1().vmethod_1(), type_);
		if (@class.vmethod_3())
		{
			class2 = new GClass15.Class15(class2, @class);
		}
		this.list_0.Add(class2);
	}

	// Token: 0x06000138 RID: 312 RVA: 0x5FF14E68 File Offset: 0x5FF09C68
	private void method_36()
	{
		int num = this.method_1().F877E806();
		foreach (GClass15.Class32 @class in this.list_1)
		{
			if (@class.method_0() == num)
			{
				this.stack_1.Push(@class);
			}
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x5FF14ED8 File Offset: 0x5FF09CD8
	private void method_37()
	{
		this.method_0(new GClass15.Class4(this.method_5()));
	}

	// Token: 0x0600013A RID: 314 RVA: 0x5FF14EF8 File Offset: 0x5FF09CF8
	private void method_38()
	{
		this.method_0(new GClass15.Class5(this.method_6()));
	}

	// Token: 0x0600013B RID: 315 RVA: 0x5FF14F18 File Offset: 0x5FF09D18
	private void method_39()
	{
		this.method_0(new GClass15.Class6(this.method_7()));
	}

	// Token: 0x0600013C RID: 316 RVA: 0x5FF14F38 File Offset: 0x5FF09D38
	private void method_40()
	{
		this.method_0(new GClass15.Class7(this.method_8()));
	}

	// Token: 0x0600013D RID: 317 RVA: 0x5FF14F58 File Offset: 0x5FF09D58
	private void method_41()
	{
		this.method_0(new GClass15.Class9(null));
	}

	// Token: 0x0600013E RID: 318 RVA: 0x5FF14F74 File Offset: 0x5FF09D74
	private void method_42()
	{
		this.method_0(new GClass15.Class8(this.method_25(this.method_1().F877E806())));
	}

	// Token: 0x0600013F RID: 319 RVA: 0x5FF14FA0 File Offset: 0x5FF09DA0
	private void method_43()
	{
		this.method_0(this.method_2().vmethod_0());
	}

	// Token: 0x06000140 RID: 320 RVA: 0x5FF14FC0 File Offset: 0x5FF09DC0
	private void method_44()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_11(class2_, class2_2, false, false));
	}

	// Token: 0x06000141 RID: 321 RVA: 0x5FF14FEC File Offset: 0x5FF09DEC
	private void method_45()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_11(class2_, class2_2, true, false));
	}

	// Token: 0x06000142 RID: 322 RVA: 0x5FF15018 File Offset: 0x5FF09E18
	private void method_46()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_11(class2_, class2_2, true, true));
	}

	// Token: 0x06000143 RID: 323 RVA: 0x5FF15044 File Offset: 0x5FF09E44
	private void method_47()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_12(class2_2, class2_, false, false));
	}

	// Token: 0x06000144 RID: 324 RVA: 0x5FF15070 File Offset: 0x5FF09E70
	private void method_48()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_12(class2_2, class2_, true, false));
	}

	// Token: 0x06000145 RID: 325 RVA: 0x5FF1509C File Offset: 0x5FF09E9C
	private void method_49()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_12(class2_2, class2_, true, true));
	}

	// Token: 0x06000146 RID: 326 RVA: 0x5FF150C8 File Offset: 0x5FF09EC8
	private void method_50()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_13(class2_2, class2_, false, false));
	}

	// Token: 0x06000147 RID: 327 RVA: 0x5FF150F4 File Offset: 0x5FF09EF4
	private void method_51()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_13(class2_2, class2_, true, false));
	}

	// Token: 0x06000148 RID: 328 RVA: 0x5FF15120 File Offset: 0x5FF09F20
	private void method_52()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_13(class2_2, class2_, true, true));
	}

	// Token: 0x06000149 RID: 329 RVA: 0x5FF1514C File Offset: 0x5FF09F4C
	private void method_53()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_14(class2_2, class2_, false));
	}

	// Token: 0x0600014A RID: 330 RVA: 0x5FF15178 File Offset: 0x5FF09F78
	private void method_54()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_14(class2_2, class2_, true));
	}

	// Token: 0x0600014B RID: 331 RVA: 0x5FF151A4 File Offset: 0x5FF09FA4
	private void method_55()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_15(class2_2, class2_, false));
	}

	// Token: 0x0600014C RID: 332 RVA: 0x5FF151D0 File Offset: 0x5FF09FD0
	private void method_56()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_15(class2_2, class2_, true));
	}

	// Token: 0x0600014D RID: 333 RVA: 0x5FF151FC File Offset: 0x5FF09FFC
	private void method_57()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_18(class2_2, class2_));
	}

	// Token: 0x0600014E RID: 334 RVA: 0x5FF15228 File Offset: 0x5FF0A028
	private void method_58()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_17(class2_2, class2_));
	}

	// Token: 0x0600014F RID: 335 RVA: 0x5FF15254 File Offset: 0x5FF0A054
	private void method_59()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_16(class2_2, class2_));
	}

	// Token: 0x06000150 RID: 336 RVA: 0x5FF15280 File Offset: 0x5FF0A080
	private void method_60()
	{
		GClass15.Class2 class2_ = this.method_1();
		this.method_0(this.method_20(class2_));
	}

	// Token: 0x06000151 RID: 337 RVA: 0x5FF152A4 File Offset: 0x5FF0A0A4
	private void method_61()
	{
		GClass15.Class2 class2_ = this.method_1();
		this.method_0(this.method_21(class2_));
	}

	// Token: 0x06000152 RID: 338 RVA: 0x5FF152C8 File Offset: 0x5FF0A0C8
	private void method_62()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_22(class2_2, class2_, false));
	}

	// Token: 0x06000153 RID: 339 RVA: 0x5FF152F4 File Offset: 0x5FF0A0F4
	private void method_63()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_22(class2_2, class2_, true));
	}

	// Token: 0x06000154 RID: 340 RVA: 0x5FF15320 File Offset: 0x5FF0A120
	private void method_64()
	{
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(this.method_23(class2_2, class2_));
	}

	// Token: 0x06000155 RID: 341 RVA: 0x5FF1534C File Offset: 0x5FF0A14C
	private void method_65()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		this.method_0(this.method_24(this.method_1(), type_));
	}

	// Token: 0x06000156 RID: 342 RVA: 0x5FF15380 File Offset: 0x5FF0A180
	private void method_66()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		this.method_0(this.method_24(this.method_1().DF4F620E(type_, false), type_));
	}

	// Token: 0x06000157 RID: 343 RVA: 0x5FF153BC File Offset: 0x5FF0A1BC
	private void method_67()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		this.method_0(this.method_24(this.method_1().DF4F620E(type_, true), type_));
	}

	// Token: 0x06000158 RID: 344 RVA: 0x5FF153F8 File Offset: 0x5FF0A1F8
	private void method_68()
	{
		this.method_0(new GClass15.Class4(Marshal.SizeOf(this.method_26(this.method_5()))));
	}

	// Token: 0x06000159 RID: 345 RVA: 0x5FF15424 File Offset: 0x5FF0A224
	private void method_69()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_1();
		if (!@class.vmethod_3())
		{
			if (!(@class.vmethod_1() is Pointer))
			{
				throw new ArgumentException();
			}
			@class = new GClass15.Class18(new IntPtr(Pointer.Unbox(@class.vmethod_1())), type_);
		}
		this.method_0(this.method_24(@class, type_));
	}

	// Token: 0x0600015A RID: 346 RVA: 0x5FF1548C File Offset: 0x5FF0A28C
	private void method_70()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().F877E806());
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		this.method_0(this.method_24(fieldInfo.GetValue(obj), fieldInfo.FieldType));
	}

	// Token: 0x0600015B RID: 347 RVA: 0x5FF154E4 File Offset: 0x5FF0A2E4
	private void method_71()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().F877E806());
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		this.method_0(new GClass15.Class16(fieldInfo, obj));
	}

	// Token: 0x0600015C RID: 348 RVA: 0x5FF15530 File Offset: 0x5FF0A330
	private void method_72()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().F877E806());
		GClass15.Class2 object_ = this.method_1();
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		fieldInfo.SetValue(obj, this.method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	// Token: 0x0600015D RID: 349 RVA: 0x5FF1558C File Offset: 0x5FF0A38C
	private void method_73()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().F877E806());
		GClass15.Class2 object_ = this.method_1();
		fieldInfo.SetValue(null, this.method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	// Token: 0x0600015E RID: 350 RVA: 0x5FF155CC File Offset: 0x5FF0A3CC
	private void method_74()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		GClass15.Class2 object_ = this.method_1();
		GClass15.Class2 @class = this.method_1();
		if (!@class.vmethod_3())
		{
			if (!(@class.vmethod_1() is Pointer))
			{
				throw new ArgumentException();
			}
			@class = new GClass15.Class18(new IntPtr(Pointer.Unbox(@class.vmethod_1())), type_);
		}
		@class.vmethod_2(this.method_24(object_, type_).vmethod_1());
	}

	// Token: 0x0600015F RID: 351 RVA: 0x5FF15640 File Offset: 0x5FF0A440
	private void method_75()
	{
		this.method_0(this.list_0[(int)((ushort)this.method_4())].vmethod_0());
	}

	// Token: 0x06000160 RID: 352 RVA: 0x5FF1566C File Offset: 0x5FF0A46C
	private void method_76()
	{
		this.method_0(new GClass15.Class14(this.list_0[(int)((ushort)this.method_4())]));
	}

	// Token: 0x06000161 RID: 353 RVA: 0x5FF15698 File Offset: 0x5FF0A498
	private void method_77()
	{
		GClass15.Class2 object_ = this.method_1();
		GClass15.Class2 @class = this.list_0[(int)((ushort)this.method_4())];
		@class.vmethod_2(this.method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	// Token: 0x06000162 RID: 354 RVA: 0x5FF156D8 File Offset: 0x5FF0A4D8
	private void method_78()
	{
		this.type_0 = this.method_26(this.method_1().F877E806());
	}

	// Token: 0x06000163 RID: 355 RVA: 0x5FF156FC File Offset: 0x5FF0A4FC
	private void method_79()
	{
		MethodBase methodBase_ = this.method_27(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_31(methodBase_, false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000164 RID: 356 RVA: 0x5FF15730 File Offset: 0x5FF0A530
	private void method_80()
	{
		MethodBase methodBase = this.method_27(this.method_1().F877E806());
		if (this.type_0 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			foreach (ParameterInfo parameterInfo in parameters)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = this.type_0.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
			this.type_0 = null;
		}
		GClass15.Class2 @class = this.method_31(methodBase, true);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000165 RID: 357 RVA: 0x5FF157D4 File Offset: 0x5FF0A5D4
	private void method_81()
	{
		MethodBase methodBase = this.method_1().vmethod_1() as MethodBase;
		if (methodBase == null)
		{
			throw new ArgumentException();
		}
		GClass15.Class2 @class = this.method_31(methodBase, false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000166 RID: 358 RVA: 0x5FF15810 File Offset: 0x5FF0A610
	private void method_82()
	{
		GClass15.Class2 @class = this.method_32(this.method_1().F877E806(), false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000167 RID: 359 RVA: 0x5FF1583C File Offset: 0x5FF0A63C
	private void method_83()
	{
		GClass15.Class2 @class = this.method_32(this.method_1().F877E806(), true);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000168 RID: 360 RVA: 0x5FF15868 File Offset: 0x5FF0A668
	private void method_84()
	{
		MethodBase methodBase_ = this.method_27(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_29(methodBase_);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000169 RID: 361 RVA: 0x5FF1589C File Offset: 0x5FF0A69C
	private void method_85()
	{
		Type type = this.method_26(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_1();
		if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			@class.vmethod_2(null);
			return;
		}
		if (type.IsValueType)
		{
			foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
			{
				fieldInfo.SetValue(@class.vmethod_1(), fieldInfo.FieldType.IsValueType ? Activator.CreateInstance(fieldInfo.FieldType) : null);
			}
			return;
		}
		@class.vmethod_2(null);
	}

	// Token: 0x0600016A RID: 362 RVA: 0x5FF15940 File Offset: 0x5FF0A740
	private void method_86()
	{
		int int_ = this.method_1().F877E806();
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(new GClass15.Class4(this.method_19(class2_2, class2_, false, int_)));
	}

	// Token: 0x0600016B RID: 363 RVA: 0x5FF1597C File Offset: 0x5FF0A77C
	private void method_87()
	{
		int int_ = this.method_1().F877E806();
		GClass15.Class2 class2_ = this.method_1();
		GClass15.Class2 class2_2 = this.method_1();
		this.method_0(new GClass15.Class4(this.method_19(class2_2, class2_, true, int_)));
	}

	// Token: 0x0600016C RID: 364 RVA: 0x5FF159B8 File Offset: 0x5FF0A7B8
	private void method_88()
	{
		Type elementType = this.method_26(this.method_1().F877E806());
		this.method_0(new GClass15.Class12(Array.CreateInstance(elementType, this.method_1().F877E806())));
	}

	// Token: 0x0600016D RID: 365 RVA: 0x5FF159F4 File Offset: 0x5FF0A7F4
	private void method_89()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		GClass15.Class2 object_ = this.method_1();
		GClass15.Class2 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		array.SetValue(this.method_24(this.method_24(object_, type_), array.GetType().GetElementType()).vmethod_1(), @class.F877E806());
	}

	// Token: 0x0600016E RID: 366 RVA: 0x5FF15A6C File Offset: 0x5FF0A86C
	private void method_90()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(this.method_24(array.GetValue(@class.F877E806()), type_));
	}

	// Token: 0x0600016F RID: 367 RVA: 0x5FF15AC8 File Offset: 0x5FF0A8C8
	private void method_91()
	{
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(new GClass15.Class4(array.Length));
	}

	// Token: 0x06000170 RID: 368 RVA: 0x5FF15B00 File Offset: 0x5FF0A900
	private void method_92()
	{
		GClass15.Class2 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(new GClass15.Class17(array, @class.F877E806()));
	}

	// Token: 0x06000171 RID: 369 RVA: 0x5FF15B40 File Offset: 0x5FF0A940
	private void method_93()
	{
		this.method_0(new GClass15.Class19(this.method_27(this.method_1().F877E806())));
	}

	// Token: 0x06000172 RID: 370 RVA: 0x5FF15B6C File Offset: 0x5FF0A96C
	private void method_94()
	{
		MethodBase methodBase = this.method_27(this.method_1().F877E806());
		Type type = this.method_1().vmethod_1().GetType();
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		int num = 0;
		foreach (ParameterInfo parameterInfo in parameters)
		{
			array[num++] = parameterInfo.ParameterType;
		}
		while (type != null)
		{
			if (type == declaringType)
			{
				break;
			}
			MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (method != null && method.GetBaseDefinition() == methodBase)
			{
				methodBase = method;
				break;
			}
			type = type.BaseType;
		}
		this.method_0(new GClass15.Class19(methodBase));
	}

	// Token: 0x06000173 RID: 371 RVA: 0x5FF15C30 File Offset: 0x5FF0AA30
	private void method_95()
	{
		this.int_0 = this.method_1().F877E806();
	}

	// Token: 0x06000174 RID: 372 RVA: 0x5FF15C50 File Offset: 0x5FF0AA50
	private void method_96()
	{
		this.method_1();
	}

	// Token: 0x06000175 RID: 373 RVA: 0x5FF15C64 File Offset: 0x5FF0AA64
	private void method_97()
	{
		this.stack_2.Push(this.method_1().F877E806());
		int num = this.method_1().F877E806();
		while (this.stack_1.Count != 0 && num > this.stack_1.Peek().method_1())
		{
			List<GClass15.Class31> list = this.stack_1.Pop().method_4();
			for (int i = list.Count; i > 0; i--)
			{
				GClass15.Class31 @class = list[i - 1];
				if (@class.method_0() == 2)
				{
					this.stack_2.Push(@class.method_1());
				}
			}
		}
		this.exception_0 = null;
		this.stack_0.Clear();
		this.int_0 = this.stack_2.Pop();
	}

	// Token: 0x06000176 RID: 374 RVA: 0x5FF15D24 File Offset: 0x5FF0AB24
	private void method_98()
	{
		if (this.exception_0 == null)
		{
			this.int_0 = this.stack_2.Pop();
			return;
		}
		this.method_34(this.exception_0);
	}

	// Token: 0x06000177 RID: 375 RVA: 0x5FF15D58 File Offset: 0x5FF0AB58
	private void method_99()
	{
		if (this.method_1().F877E806() != 0)
		{
			this.stack_1.Pop();
			this.stack_0.Push(new GClass15.Class9(this.exception_0));
			this.int_0 = this.class31_0.method_1();
			this.class31_0 = null;
			return;
		}
		this.method_34(this.exception_0);
	}

	// Token: 0x06000178 RID: 376 RVA: 0x5FF15DBC File Offset: 0x5FF0ABBC
	private void method_100()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		this.method_0(new GClass15.Class9(this.method_24(this.method_1(), type_).vmethod_1()));
	}

	// Token: 0x06000179 RID: 377 RVA: 0x5FF15DF8 File Offset: 0x5FF0ABF8
	private void method_101()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		this.method_0(this.method_24(this.method_1().vmethod_1(), type_));
	}

	// Token: 0x0600017A RID: 378 RVA: 0x5FF15E30 File Offset: 0x5FF0AC30
	private void method_102()
	{
		Type type = this.method_26(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_1();
		object obj = @class.vmethod_1();
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		if (type.IsValueType)
		{
			if (type != obj.GetType())
			{
				throw new InvalidCastException();
			}
			this.method_0(@class);
			return;
		}
		else
		{
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Boolean:
				this.method_0(new GClass15.Class25((bool)obj));
				return;
			case TypeCode.Char:
				this.method_0(new GClass15.Class26((char)obj));
				return;
			case TypeCode.SByte:
				this.method_0(new GClass15.Class28((sbyte)obj));
				return;
			case TypeCode.Byte:
				this.method_0(new GClass15.Class27((byte)obj));
				return;
			case TypeCode.Int16:
				this.method_0(new GClass15.Class23((short)obj));
				return;
			case TypeCode.UInt16:
				this.method_0(new GClass15.Class24((ushort)obj));
				return;
			case TypeCode.Int32:
				this.method_0(new GClass15.Class4((int)obj));
				return;
			case TypeCode.UInt32:
				this.method_0(new GClass15.Class29((uint)obj));
				return;
			case TypeCode.Int64:
				this.method_0(new GClass15.Class5((long)obj));
				return;
			case TypeCode.UInt64:
				this.method_0(new GClass15.Class30((ulong)obj));
				return;
			case TypeCode.Single:
				this.method_0(new GClass15.Class6((float)obj));
				return;
			case TypeCode.Double:
				this.method_0(new GClass15.Class7((double)obj));
				return;
			default:
				throw new InvalidCastException();
			}
		}
	}

	// Token: 0x0600017B RID: 379 RVA: 0x5FF15FA4 File Offset: 0x5FF0ADA4
	private void method_103()
	{
		this.method_0(new GClass15.Class4(Marshal.ReadInt32(new IntPtr(this.long_0 + (long)((ulong)this.method_1().vmethod_11())))));
	}

	// Token: 0x0600017C RID: 380 RVA: 0x5FF15FDC File Offset: 0x5FF0ADDC
	private void method_104()
	{
		int num = this.method_1().F877E806();
		int num2 = num >> 24;
		if (num2 <= 10)
		{
			switch (num2)
			{
			case 1:
			case 2:
				goto IL_E8;
			case 3:
			case 5:
				break;
			case 4:
				this.method_0(new GClass15.Class11(this.module_0.ModuleHandle.ResolveFieldHandle(num)));
				return;
			case 6:
				goto IL_C3;
			default:
				if (num2 == 10)
				{
					try
					{
						this.method_0(new GClass15.Class11(this.module_0.ModuleHandle.ResolveFieldHandle(num)));
					}
					catch
					{
						this.method_0(new GClass15.Class11(this.module_0.ModuleHandle.ResolveMethodHandle(num)));
					}
					return;
				}
				break;
			}
		}
		else
		{
			if (num2 == 27)
			{
				goto IL_E8;
			}
			if (num2 == 43)
			{
				goto IL_C3;
			}
		}
		throw new InvalidOperationException();
		IL_C3:
		this.method_0(new GClass15.Class11(this.module_0.ModuleHandle.ResolveMethodHandle(num)));
		return;
		IL_E8:
		this.method_0(new GClass15.Class11(this.module_0.ModuleHandle.ResolveTypeHandle(num)));
	}

	// Token: 0x0600017D RID: 381 RVA: 0x5FF16108 File Offset: 0x5FF0AF08
	private void method_105()
	{
		Exception ex = this.method_1().vmethod_1() as Exception;
		if (ex == null)
		{
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x5FF16130 File Offset: 0x5FF0AF30
	private void method_106()
	{
		if (this.exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw this.exception_0;
	}

	// Token: 0x0600017F RID: 383 RVA: 0x5FF16154 File Offset: 0x5FF0AF54
	private void method_107()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_1();
		if (!this.method_33(@class.vmethod_1(), type_))
		{
			throw new InvalidCastException();
		}
		this.method_0(@class);
	}

	// Token: 0x06000180 RID: 384 RVA: 0x5FF16198 File Offset: 0x5FF0AF98
	private void method_108()
	{
		Type type_ = this.method_26(this.method_1().F877E806());
		GClass15.Class2 @class = this.method_1();
		if (!this.method_33(@class.vmethod_1(), type_))
		{
			@class = new GClass15.Class9(null);
		}
		this.method_0(@class);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x5FF161DC File Offset: 0x5FF0AFDC
	private void method_109()
	{
		GClass15.Class2 @class = this.method_1();
		if (@class.vmethod_1() is IConvertible)
		{
			double d = @class.vmethod_13();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new OverflowException();
			}
		}
		else
		{
			@class = new GClass15.Class7(double.NaN);
		}
		this.method_0(@class);
	}

	// Token: 0x06000182 RID: 386 RVA: 0x5FF16230 File Offset: 0x5FF0B030
	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(this.method_1().A295314C());
		this.list_2.Add(item);
		this.method_0(new GClass15.Class9(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	// Token: 0x06000183 RID: 387 RVA: 0x5FF1627C File Offset: 0x5FF0B07C
	private void method_111()
	{
		using (List<IntPtr>.Enumerator enumerator = this.list_2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Marshal.FreeHGlobal(enumerator.Current);
			}
		}
	}

	// Token: 0x06000184 RID: 388 RVA: 0x5FF162CC File Offset: 0x5FF0B0CC
	public object method_112(object[] object_0, int int_1)
	{
		this.int_0 = int_1;
		this.method_0(new GClass15.Class12(object_0));
		object result;
		try
		{
			try
			{
				do
				{
					IL_13:
					this.dictionary_0[(uint)this.method_3()]();
				}
				while (this.int_0 != 0);
			}
			catch (Exception exception_)
			{
				this.method_34(exception_);
				goto IL_13;
			}
			result = this.method_1().vmethod_1();
		}
		finally
		{
			this.method_111();
		}
		return result;
	}

	// Token: 0x0400034C RID: 844
	private readonly Dictionary<uint, GClass15.Delegate1> dictionary_0 = new Dictionary<uint, GClass15.Delegate1>();

	// Token: 0x0400034D RID: 845
	private readonly Module module_0 = typeof(GClass15).Module;

	// Token: 0x0400034E RID: 846
	private readonly long long_0;

	// Token: 0x0400034F RID: 847
	private int int_0;

	// Token: 0x04000350 RID: 848
	private Type type_0;

	// Token: 0x04000351 RID: 849
	private Stack<GClass15.Class3> stack_0 = new Stack<GClass15.Class3>();

	// Token: 0x04000352 RID: 850
	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	// Token: 0x04000353 RID: 851
	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	// Token: 0x04000354 RID: 852
	private List<GClass15.Class2> list_0 = new List<GClass15.Class2>();

	// Token: 0x04000355 RID: 853
	private List<GClass15.Class32> list_1 = new List<GClass15.Class32>();

	// Token: 0x04000356 RID: 854
	private Stack<GClass15.Class32> stack_1 = new Stack<GClass15.Class32>();

	// Token: 0x04000357 RID: 855
	private Stack<int> stack_2 = new Stack<int>();

	// Token: 0x04000358 RID: 856
	private Exception exception_0;

	// Token: 0x04000359 RID: 857
	private GClass15.Class31 class31_0;

	// Token: 0x0400035A RID: 858
	private List<IntPtr> list_2 = new List<IntPtr>();

	// Token: 0x02000044 RID: 68
	private static class Class1
	{
	}

	// Token: 0x02000045 RID: 69
	private abstract class Class2
	{
		// Token: 0x060001FC RID: 508
		public abstract GClass15.Class2 vmethod_0();

		// Token: 0x060001FD RID: 509
		public abstract object vmethod_1();

		// Token: 0x060001FE RID: 510
		public abstract void vmethod_2(object object_0);

		// Token: 0x060001FF RID: 511 RVA: 0x5FF1109C File Offset: 0x5FF05E9C
		public virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x5FF19064 File Offset: 0x5FF0DE64
		public virtual GClass15.Class3 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000201 RID: 513 RVA: 0x5FF19078 File Offset: 0x5FF0DE78
		public virtual GClass15.Class2 vmethod_5()
		{
			return this;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x5FF19064 File Offset: 0x5FF0DE64
		public virtual Type vmethod_6()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x5FF19064 File Offset: 0x5FF0DE64
		public virtual TypeCode vmethod_7()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x5FF1908C File Offset: 0x5FF0DE8C
		public virtual bool vmethod_8()
		{
			return Convert.ToBoolean(this.vmethod_1());
		}

		// Token: 0x06000205 RID: 517 RVA: 0x5FF190A8 File Offset: 0x5FF0DEA8
		public virtual sbyte vmethod_9()
		{
			return Convert.ToSByte(this.vmethod_1());
		}

		// Token: 0x06000206 RID: 518 RVA: 0x5FF190C0 File Offset: 0x5FF0DEC0
		public virtual short FCCCFC2F()
		{
			return Convert.ToInt16(this.vmethod_1());
		}

		// Token: 0x06000207 RID: 519 RVA: 0x5FF190DC File Offset: 0x5FF0DEDC
		public virtual int F877E806()
		{
			return Convert.ToInt32(this.vmethod_1());
		}

		// Token: 0x06000208 RID: 520 RVA: 0x5FF190F8 File Offset: 0x5FF0DEF8
		public virtual long CFA1D037()
		{
			return Convert.ToInt64(this.vmethod_1());
		}

		// Token: 0x06000209 RID: 521 RVA: 0x5FF19110 File Offset: 0x5FF0DF10
		public virtual char E6138F88()
		{
			return Convert.ToChar(this.vmethod_1());
		}

		// Token: 0x0600020A RID: 522 RVA: 0x5FF19128 File Offset: 0x5FF0DF28
		public virtual byte vmethod_10()
		{
			return Convert.ToByte(this.vmethod_1());
		}

		// Token: 0x0600020B RID: 523 RVA: 0x5FF19144 File Offset: 0x5FF0DF44
		public virtual ushort C7D32E95()
		{
			return Convert.ToUInt16(this.vmethod_1());
		}

		// Token: 0x0600020C RID: 524 RVA: 0x5FF19160 File Offset: 0x5FF0DF60
		public virtual uint vmethod_11()
		{
			return Convert.ToUInt32(this.vmethod_1());
		}

		// Token: 0x0600020D RID: 525 RVA: 0x5FF19178 File Offset: 0x5FF0DF78
		public virtual ulong vmethod_12()
		{
			return Convert.ToUInt64(this.vmethod_1());
		}

		// Token: 0x0600020E RID: 526 RVA: 0x5FF19190 File Offset: 0x5FF0DF90
		public virtual float A08827DF()
		{
			return Convert.ToSingle(this.vmethod_1());
		}

		// Token: 0x0600020F RID: 527 RVA: 0x5FF191AC File Offset: 0x5FF0DFAC
		public virtual double vmethod_13()
		{
			return Convert.ToDouble(this.vmethod_1());
		}

		// Token: 0x06000210 RID: 528 RVA: 0x5FF191C8 File Offset: 0x5FF0DFC8
		public override string ToString()
		{
			object obj = this.vmethod_1();
			if (obj == null)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x5FF19064 File Offset: 0x5FF0DE64
		public virtual IntPtr A295314C()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000212 RID: 530 RVA: 0x5FF19064 File Offset: 0x5FF0DE64
		public virtual UIntPtr vmethod_14()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x5FF19064 File Offset: 0x5FF0DE64
		public virtual object DF4F620E(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x02000046 RID: 70
	private abstract class Class3 : GClass15.Class2
	{
		// Token: 0x06000215 RID: 533 RVA: 0x5FF19078 File Offset: 0x5FF0DE78
		public override GClass15.Class3 vmethod_4()
		{
			return this;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x5FF1109C File Offset: 0x5FF05E9C
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	// Token: 0x02000047 RID: 71
	private sealed class Class4 : GClass15.Class3
	{
		// Token: 0x06000218 RID: 536 RVA: 0x5FF19200 File Offset: 0x5FF0E000
		public Class4(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x5FF1921C File Offset: 0x5FF0E01C
		public override Type vmethod_6()
		{
			return typeof(int);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x5FF19234 File Offset: 0x5FF0E034
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x5FF19248 File Offset: 0x5FF0E048
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class4(this.int_0);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x5FF19260 File Offset: 0x5FF0E060
		public override object vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x5FF19278 File Offset: 0x5FF0E078
		public override void vmethod_2(object object_0)
		{
			this.int_0 = Convert.ToInt32(object_0);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x5FF19294 File Offset: 0x5FF0E094
		public override bool vmethod_8()
		{
			return this.int_0 != 0;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x5FF192AC File Offset: 0x5FF0E0AC
		public override sbyte vmethod_9()
		{
			return (sbyte)this.int_0;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x5FF192C4 File Offset: 0x5FF0E0C4
		public override short FCCCFC2F()
		{
			return (short)this.int_0;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x5FF192DC File Offset: 0x5FF0E0DC
		public override int F877E806()
		{
			return this.int_0;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x5FF192F0 File Offset: 0x5FF0E0F0
		public override long CFA1D037()
		{
			return (long)this.int_0;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x5FF19304 File Offset: 0x5FF0E104
		public override char E6138F88()
		{
			return (char)this.int_0;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x5FF1931C File Offset: 0x5FF0E11C
		public override byte vmethod_10()
		{
			return (byte)this.int_0;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x5FF19304 File Offset: 0x5FF0E104
		public override ushort C7D32E95()
		{
			return (ushort)this.int_0;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x5FF192DC File Offset: 0x5FF0E0DC
		public override uint vmethod_11()
		{
			return (uint)this.int_0;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x5FF19330 File Offset: 0x5FF0E130
		public override ulong vmethod_12()
		{
			return (ulong)this.int_0;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x5FF19348 File Offset: 0x5FF0E148
		public override float A08827DF()
		{
			return (float)this.int_0;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x5FF1935C File Offset: 0x5FF0E15C
		public override double vmethod_13()
		{
			return (double)this.int_0;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x5FF19374 File Offset: 0x5FF0E174
		public override IntPtr A295314C()
		{
			return new IntPtr(this.int_0);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x5FF19390 File Offset: 0x5FF0E190
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)this.int_0);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x5FF193A8 File Offset: 0x5FF0E1A8
		public override GClass15.Class2 vmethod_5()
		{
			return new GClass15.Class29((uint)this.int_0);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x5FF193C0 File Offset: 0x5FF0E1C0
		public override object DF4F620E(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					if (IntPtr.Size == 4)
					{
						return new IntPtr(bool_0 ? ((int)((uint)this.int_0)) : this.int_0);
					}
					return new IntPtr((long)(unchecked(bool_0 ? ((ulong)this.int_0) : ((ulong)((long)this.int_0)))));
				}
				else
				{
					if (type_0 == typeof(UIntPtr))
					{
						return new UIntPtr((uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0))));
					}
					switch (Type.GetTypeCode(type_0))
					{
					case TypeCode.SByte:
						return bool_0 ? ((sbyte)((uint)this.int_0)) : ((sbyte)this.int_0);
					case TypeCode.Byte:
						return bool_0 ? ((byte)((uint)this.int_0)) : ((byte)this.int_0);
					case TypeCode.Int16:
						return bool_0 ? ((short)((uint)this.int_0)) : ((short)this.int_0);
					case TypeCode.UInt16:
						return bool_0 ? ((ushort)((uint)this.int_0)) : ((ushort)this.int_0);
					case TypeCode.Int32:
						return bool_0 ? ((int)((uint)this.int_0)) : this.int_0;
					case TypeCode.UInt32:
						return (uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0)));
					case TypeCode.Int64:
						return (long)(unchecked(bool_0 ? ((ulong)this.int_0) : ((ulong)((long)this.int_0))));
					case TypeCode.UInt64:
						return (uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0)));
					case TypeCode.Double:
						return bool_0 ? this.int_0 : ((double)this.int_0);
					}
					throw new ArgumentException();
				}
			}
		}

		// Token: 0x040003B2 RID: 946
		private int int_0;
	}

	// Token: 0x02000048 RID: 72
	private sealed class Class5 : GClass15.Class3
	{
		// Token: 0x0600022E RID: 558 RVA: 0x5FF19570 File Offset: 0x5FF0E370
		public Class5(long long_1)
		{
			this.long_0 = long_1;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x5FF1958C File Offset: 0x5FF0E38C
		public override Type vmethod_6()
		{
			return typeof(long);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x5FF195A4 File Offset: 0x5FF0E3A4
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x5FF195B8 File Offset: 0x5FF0E3B8
		public override GClass15.Class2 vmethod_5()
		{
			return new GClass15.Class30((ulong)this.long_0);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x5FF195D4 File Offset: 0x5FF0E3D4
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class5(this.long_0);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x5FF195EC File Offset: 0x5FF0E3EC
		public override object vmethod_1()
		{
			return this.long_0;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x5FF19604 File Offset: 0x5FF0E404
		public override void vmethod_2(object object_0)
		{
			this.long_0 = Convert.ToInt64(object_0);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x5FF19620 File Offset: 0x5FF0E420
		public override bool vmethod_8()
		{
			return this.long_0 != 0L;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x5FF19644 File Offset: 0x5FF0E444
		public override char E6138F88()
		{
			return (char)this.long_0;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x5FF19658 File Offset: 0x5FF0E458
		public override byte vmethod_10()
		{
			return (byte)this.long_0;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x5FF19670 File Offset: 0x5FF0E470
		public override sbyte vmethod_9()
		{
			return (sbyte)this.long_0;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x5FF19688 File Offset: 0x5FF0E488
		public override short FCCCFC2F()
		{
			return (short)this.long_0;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x5FF1969C File Offset: 0x5FF0E49C
		public override int F877E806()
		{
			return (int)this.long_0;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x5FF196B0 File Offset: 0x5FF0E4B0
		public override long CFA1D037()
		{
			return this.long_0;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x5FF19644 File Offset: 0x5FF0E444
		public override ushort C7D32E95()
		{
			return (ushort)this.long_0;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x5FF196C8 File Offset: 0x5FF0E4C8
		public override uint vmethod_11()
		{
			return (uint)this.long_0;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x5FF196B0 File Offset: 0x5FF0E4B0
		public override ulong vmethod_12()
		{
			return (ulong)this.long_0;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x5FF196E0 File Offset: 0x5FF0E4E0
		public override float A08827DF()
		{
			return (float)this.long_0;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x5FF196F8 File Offset: 0x5FF0E4F8
		public override double vmethod_13()
		{
			return (double)this.long_0;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x5FF19710 File Offset: 0x5FF0E510
		public override IntPtr A295314C()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.long_0)) : this.long_0);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x5FF1973C File Offset: 0x5FF0E53C
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((UIntPtr.Size == 4) ? ((ulong)((uint)this.long_0)) : ((ulong)this.long_0));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x5FF19768 File Offset: 0x5FF0E568
		public override object DF4F620E(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr(bool_0 ? ((long)((ulong)this.long_0)) : this.long_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)(bool_0 ? this.long_0 : ((long)((ulong)this.long_0))));
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return bool_0 ? ((sbyte)((ulong)this.long_0)) : ((sbyte)this.long_0);
				case TypeCode.Byte:
					return bool_0 ? ((byte)((ulong)this.long_0)) : ((byte)this.long_0);
				case TypeCode.Int16:
					return bool_0 ? ((short)((ulong)this.long_0)) : ((short)this.long_0);
				case TypeCode.UInt16:
					return bool_0 ? ((ushort)((uint)this.long_0)) : ((ushort)this.long_0);
				case TypeCode.Int32:
					return bool_0 ? ((int)((ulong)this.long_0)) : ((int)this.long_0);
				case TypeCode.UInt32:
					return bool_0 ? ((uint)((ulong)this.long_0)) : ((uint)this.long_0);
				case TypeCode.Int64:
					return bool_0 ? ((long)((ulong)this.long_0)) : this.long_0;
				case TypeCode.UInt64:
					return (ulong)(bool_0 ? this.long_0 : ((long)((ulong)this.long_0)));
				case TypeCode.Double:
					return bool_0 ? this.long_0 : ((double)this.long_0);
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x040003B3 RID: 947
		private long long_0;
	}

	// Token: 0x02000049 RID: 73
	private sealed class Class6 : GClass15.Class3
	{
		// Token: 0x06000244 RID: 580 RVA: 0x5FF198F4 File Offset: 0x5FF0E6F4
		public Class6(float float_1)
		{
			this.float_0 = float_1;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x5FF19910 File Offset: 0x5FF0E710
		public override Type vmethod_6()
		{
			return typeof(float);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x5FF19928 File Offset: 0x5FF0E728
		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x5FF19938 File Offset: 0x5FF0E738
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class6(this.float_0);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x5FF19950 File Offset: 0x5FF0E750
		public override object vmethod_1()
		{
			return this.float_0;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x5FF19968 File Offset: 0x5FF0E768
		public override void vmethod_2(object object_0)
		{
			this.float_0 = Convert.ToSingle(object_0);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x5FF19984 File Offset: 0x5FF0E784
		public override bool vmethod_8()
		{
			return Convert.ToBoolean(this.float_0);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x5FF1999C File Offset: 0x5FF0E79C
		public override sbyte vmethod_9()
		{
			return (sbyte)this.float_0;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x5FF199B4 File Offset: 0x5FF0E7B4
		public override short FCCCFC2F()
		{
			return (short)this.float_0;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x5FF199C8 File Offset: 0x5FF0E7C8
		public override int F877E806()
		{
			return (int)this.float_0;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x5FF199DC File Offset: 0x5FF0E7DC
		public override long CFA1D037()
		{
			return (long)this.float_0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x5FF199F4 File Offset: 0x5FF0E7F4
		public override char E6138F88()
		{
			return (char)this.float_0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x5FF19A08 File Offset: 0x5FF0E808
		public override byte vmethod_10()
		{
			return (byte)this.float_0;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x5FF199F4 File Offset: 0x5FF0E7F4
		public override ushort C7D32E95()
		{
			return (ushort)this.float_0;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x5FF19A20 File Offset: 0x5FF0E820
		public override uint vmethod_11()
		{
			return (uint)this.float_0;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x5FF19A34 File Offset: 0x5FF0E834
		public override ulong vmethod_12()
		{
			return (ulong)this.float_0;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x5FF19A48 File Offset: 0x5FF0E848
		public override float A08827DF()
		{
			return this.float_0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x5FF19A60 File Offset: 0x5FF0E860
		public override double vmethod_13()
		{
			return (double)this.float_0;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x5FF19A74 File Offset: 0x5FF0E874
		public override IntPtr A295314C()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.float_0)) : ((long)this.float_0));
		}

		// Token: 0x06000257 RID: 599 RVA: 0x5FF19AA0 File Offset: 0x5FF0E8A0
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)((uint)this.float_0)) : ((ulong)this.float_0));
		}

		// Token: 0x06000258 RID: 600 RVA: 0x5FF19ACC File Offset: 0x5FF0E8CC
		public override object DF4F620E(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)this.float_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)this.float_0);
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return bool_0 ? ((sbyte)((uint)this.float_0)) : ((sbyte)this.float_0);
				case TypeCode.Byte:
					return (byte)this.float_0;
				case TypeCode.Int16:
					return bool_0 ? ((short)((uint)this.float_0)) : ((short)this.float_0);
				case TypeCode.UInt16:
					return (ushort)this.float_0;
				case TypeCode.Int32:
					return (int)this.float_0;
				case TypeCode.UInt32:
					return (uint)this.float_0;
				case TypeCode.UInt64:
					return (ulong)this.float_0;
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x040003B4 RID: 948
		private float float_0;
	}

	// Token: 0x0200004A RID: 74
	private sealed class Class7 : GClass15.Class3
	{
		// Token: 0x06000259 RID: 601 RVA: 0x5FF19BC4 File Offset: 0x5FF0E9C4
		public Class7(double double_1)
		{
			this.double_0 = double_1;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x5FF19BE0 File Offset: 0x5FF0E9E0
		public override Type vmethod_6()
		{
			return typeof(double);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x5FF19BF8 File Offset: 0x5FF0E9F8
		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x5FF19C0C File Offset: 0x5FF0EA0C
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class7(this.double_0);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x5FF19C24 File Offset: 0x5FF0EA24
		public override object vmethod_1()
		{
			return this.double_0;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x5FF19C3C File Offset: 0x5FF0EA3C
		public override void vmethod_2(object object_0)
		{
			this.double_0 = (double)object_0;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x5FF19C58 File Offset: 0x5FF0EA58
		public override bool vmethod_8()
		{
			return Convert.ToBoolean(this.double_0);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x5FF19C74 File Offset: 0x5FF0EA74
		public override sbyte vmethod_9()
		{
			return (sbyte)this.double_0;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x5FF19C8C File Offset: 0x5FF0EA8C
		public override short FCCCFC2F()
		{
			return (short)this.double_0;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x5FF19CA0 File Offset: 0x5FF0EAA0
		public override int F877E806()
		{
			return (int)this.double_0;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x5FF19CB8 File Offset: 0x5FF0EAB8
		public override long CFA1D037()
		{
			return (long)this.double_0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x5FF19CCC File Offset: 0x5FF0EACC
		public override char E6138F88()
		{
			return (char)this.double_0;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x5FF19CE4 File Offset: 0x5FF0EAE4
		public override byte vmethod_10()
		{
			return (byte)this.double_0;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x5FF19CCC File Offset: 0x5FF0EACC
		public override ushort C7D32E95()
		{
			return (ushort)this.double_0;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x5FF19CF8 File Offset: 0x5FF0EAF8
		public override uint vmethod_11()
		{
			return (uint)this.double_0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x5FF19D0C File Offset: 0x5FF0EB0C
		public override ulong vmethod_12()
		{
			return (ulong)this.double_0;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x5FF19D24 File Offset: 0x5FF0EB24
		public override float A08827DF()
		{
			return (float)this.double_0;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x5FF19D38 File Offset: 0x5FF0EB38
		public override double vmethod_13()
		{
			return this.double_0;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x5FF19D50 File Offset: 0x5FF0EB50
		public override IntPtr A295314C()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.double_0)) : ((long)this.double_0));
		}

		// Token: 0x0600026C RID: 620 RVA: 0x5FF19D7C File Offset: 0x5FF0EB7C
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)((uint)this.double_0)) : ((ulong)this.double_0));
		}

		// Token: 0x0600026D RID: 621 RVA: 0x5FF19DA8 File Offset: 0x5FF0EBA8
		public override object DF4F620E(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)this.double_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)this.double_0);
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return bool_0 ? ((sbyte)((uint)this.double_0)) : ((sbyte)this.double_0);
				case TypeCode.Byte:
					return (byte)this.double_0;
				case TypeCode.Int16:
					return bool_0 ? ((short)((uint)this.double_0)) : ((short)this.double_0);
				case TypeCode.UInt16:
					return (ushort)this.double_0;
				case TypeCode.Int32:
					return (int)this.double_0;
				case TypeCode.UInt32:
					return (uint)this.double_0;
				case TypeCode.Int64:
					return (long)this.double_0;
				case TypeCode.UInt64:
					return (ulong)this.double_0;
				case TypeCode.Double:
					return this.double_0;
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x040003B5 RID: 949
		private double double_0;
	}

	// Token: 0x0200004B RID: 75
	private sealed class Class8 : GClass15.Class3
	{
		// Token: 0x0600026E RID: 622 RVA: 0x5FF19EC4 File Offset: 0x5FF0ECC4
		public Class8(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x5FF19EE0 File Offset: 0x5FF0ECE0
		public override Type vmethod_6()
		{
			return typeof(string);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x5FF11048 File Offset: 0x5FF05E48
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x5FF19EF8 File Offset: 0x5FF0ECF8
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class8(this.string_0);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x5FF19F10 File Offset: 0x5FF0ED10
		public override object vmethod_1()
		{
			return this.string_0;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x5FF19F28 File Offset: 0x5FF0ED28
		public override void vmethod_2(object object_0)
		{
			this.string_0 = ((object_0 != null) ? Convert.ToString(object_0) : null);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x5FF19F48 File Offset: 0x5FF0ED48
		public override bool vmethod_8()
		{
			return this.string_0 != null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x5FF19F10 File Offset: 0x5FF0ED10
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x040003B6 RID: 950
		private string string_0;
	}

	// Token: 0x0200004C RID: 76
	private sealed class Class23 : GClass15.Class2
	{
		// Token: 0x06000276 RID: 630 RVA: 0x5FF19F60 File Offset: 0x5FF0ED60
		public Class23(short short_1)
		{
			this.short_0 = short_1;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x5FF19F7C File Offset: 0x5FF0ED7C
		public override Type vmethod_6()
		{
			return typeof(short);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x5FF19F94 File Offset: 0x5FF0ED94
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class23(this.short_0);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x5FF19FB0 File Offset: 0x5FF0EDB0
		public override object vmethod_1()
		{
			return this.short_0;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x5FF19FC8 File Offset: 0x5FF0EDC8
		public override void vmethod_2(object object_0)
		{
			this.short_0 = Convert.ToInt16(object_0);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x5FF19FE4 File Offset: 0x5FF0EDE4
		public override GClass15.Class3 vmethod_4()
		{
			return new GClass15.Class4(this.F877E806());
		}

		// Token: 0x0600027C RID: 636 RVA: 0x5FF19FFC File Offset: 0x5FF0EDFC
		public override sbyte vmethod_9()
		{
			return (sbyte)this.short_0;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x5FF1A014 File Offset: 0x5FF0EE14
		public override byte vmethod_10()
		{
			return (byte)this.short_0;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x5FF1A028 File Offset: 0x5FF0EE28
		public override short FCCCFC2F()
		{
			return this.short_0;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x5FF1A040 File Offset: 0x5FF0EE40
		public override ushort C7D32E95()
		{
			return (ushort)this.short_0;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x5FF1A028 File Offset: 0x5FF0EE28
		public override int F877E806()
		{
			return (int)this.short_0;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x5FF1A028 File Offset: 0x5FF0EE28
		public override uint vmethod_11()
		{
			return (uint)this.short_0;
		}

		// Token: 0x040003B7 RID: 951
		private short short_0;
	}

	// Token: 0x0200004D RID: 77
	private sealed class Class24 : GClass15.Class2
	{
		// Token: 0x06000282 RID: 642 RVA: 0x5FF1A054 File Offset: 0x5FF0EE54
		public Class24(ushort ushort_1)
		{
			this.ushort_0 = ushort_1;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x5FF1A070 File Offset: 0x5FF0EE70
		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x5FF1A088 File Offset: 0x5FF0EE88
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class24(this.ushort_0);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x5FF1A0A4 File Offset: 0x5FF0EEA4
		public override object vmethod_1()
		{
			return this.ushort_0;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x5FF1A0C0 File Offset: 0x5FF0EEC0
		public override void vmethod_2(object object_0)
		{
			this.ushort_0 = Convert.ToUInt16(object_0);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x5FF19FE4 File Offset: 0x5FF0EDE4
		public override GClass15.Class3 vmethod_4()
		{
			return new GClass15.Class4(this.F877E806());
		}

		// Token: 0x06000288 RID: 648 RVA: 0x5FF1A0DC File Offset: 0x5FF0EEDC
		public override sbyte vmethod_9()
		{
			return (sbyte)this.ushort_0;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x5FF1A0F4 File Offset: 0x5FF0EEF4
		public override byte vmethod_10()
		{
			return (byte)this.ushort_0;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x5FF1A108 File Offset: 0x5FF0EF08
		public override short FCCCFC2F()
		{
			return (short)this.ushort_0;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x5FF1A11C File Offset: 0x5FF0EF1C
		public override ushort C7D32E95()
		{
			return this.ushort_0;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x5FF1A11C File Offset: 0x5FF0EF1C
		public override int F877E806()
		{
			return (int)this.ushort_0;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x5FF1A11C File Offset: 0x5FF0EF1C
		public override uint vmethod_11()
		{
			return (uint)this.ushort_0;
		}

		// Token: 0x040003B8 RID: 952
		private ushort ushort_0;
	}

	// Token: 0x0200004E RID: 78
	private sealed class Class25 : GClass15.Class2
	{
		// Token: 0x0600028E RID: 654 RVA: 0x5FF1A134 File Offset: 0x5FF0EF34
		public Class25(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x5FF1A150 File Offset: 0x5FF0EF50
		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x5FF1A168 File Offset: 0x5FF0EF68
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class25(this.bool_0);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x5FF1A180 File Offset: 0x5FF0EF80
		public override object vmethod_1()
		{
			return this.bool_0;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x5FF1A198 File Offset: 0x5FF0EF98
		public override void vmethod_2(object object_0)
		{
			this.bool_0 = Convert.ToBoolean(object_0);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x5FF19FE4 File Offset: 0x5FF0EDE4
		public override GClass15.Class3 vmethod_4()
		{
			return new GClass15.Class4(this.F877E806());
		}

		// Token: 0x06000294 RID: 660 RVA: 0x5FF1A1B4 File Offset: 0x5FF0EFB4
		public override int F877E806()
		{
			if (!this.bool_0)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x040003B9 RID: 953
		private bool bool_0;
	}

	// Token: 0x0200004F RID: 79
	private sealed class Class26 : GClass15.Class2
	{
		// Token: 0x06000295 RID: 661 RVA: 0x5FF1A1CC File Offset: 0x5FF0EFCC
		public Class26(char char_1)
		{
			this.char_0 = char_1;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x5FF1A1E8 File Offset: 0x5FF0EFE8
		public override Type vmethod_6()
		{
			return typeof(char);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x5FF1A200 File Offset: 0x5FF0F000
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class26(this.char_0);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x5FF1A218 File Offset: 0x5FF0F018
		public override object vmethod_1()
		{
			return this.char_0;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x5FF1A230 File Offset: 0x5FF0F030
		public override void vmethod_2(object object_0)
		{
			this.char_0 = Convert.ToChar(object_0);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x5FF19FE4 File Offset: 0x5FF0EDE4
		public override GClass15.Class3 vmethod_4()
		{
			return new GClass15.Class4(this.F877E806());
		}

		// Token: 0x0600029B RID: 667 RVA: 0x5FF1A24C File Offset: 0x5FF0F04C
		public override sbyte vmethod_9()
		{
			return (sbyte)this.char_0;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x5FF1A260 File Offset: 0x5FF0F060
		public override byte vmethod_10()
		{
			return (byte)this.char_0;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x5FF1A274 File Offset: 0x5FF0F074
		public override short FCCCFC2F()
		{
			return (short)this.char_0;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x5FF1A288 File Offset: 0x5FF0F088
		public override ushort C7D32E95()
		{
			return (ushort)this.char_0;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x5FF1A288 File Offset: 0x5FF0F088
		public override int F877E806()
		{
			return (int)this.char_0;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x5FF1A288 File Offset: 0x5FF0F088
		public override uint vmethod_11()
		{
			return (uint)this.char_0;
		}

		// Token: 0x040003BA RID: 954
		private char char_0;
	}

	// Token: 0x02000050 RID: 80
	private sealed class Class27 : GClass15.Class2
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x5FF1A29C File Offset: 0x5FF0F09C
		public Class27(byte byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x5FF1A2B8 File Offset: 0x5FF0F0B8
		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x5FF1A2D0 File Offset: 0x5FF0F0D0
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class27(this.byte_0);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x5FF1A2EC File Offset: 0x5FF0F0EC
		public override object vmethod_1()
		{
			return this.byte_0;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x5FF1A304 File Offset: 0x5FF0F104
		public override void vmethod_2(object object_0)
		{
			this.byte_0 = Convert.ToByte(object_0);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x5FF19FE4 File Offset: 0x5FF0EDE4
		public override GClass15.Class3 vmethod_4()
		{
			return new GClass15.Class4(this.F877E806());
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x5FF1A320 File Offset: 0x5FF0F120
		public override sbyte vmethod_9()
		{
			return (sbyte)this.byte_0;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x5FF1A334 File Offset: 0x5FF0F134
		public override byte vmethod_10()
		{
			return this.byte_0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x5FF1A334 File Offset: 0x5FF0F134
		public override short FCCCFC2F()
		{
			return (short)this.byte_0;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x5FF1A334 File Offset: 0x5FF0F134
		public override ushort C7D32E95()
		{
			return (ushort)this.byte_0;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x5FF1A334 File Offset: 0x5FF0F134
		public override int F877E806()
		{
			return (int)this.byte_0;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x5FF1A334 File Offset: 0x5FF0F134
		public override uint vmethod_11()
		{
			return (uint)this.byte_0;
		}

		// Token: 0x040003BB RID: 955
		private byte byte_0;
	}

	// Token: 0x02000051 RID: 81
	private sealed class Class28 : GClass15.Class2
	{
		// Token: 0x060002AD RID: 685 RVA: 0x5FF1A34C File Offset: 0x5FF0F14C
		public Class28(sbyte sbyte_1)
		{
			this.sbyte_0 = sbyte_1;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x5FF1A370 File Offset: 0x5FF0F170
		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x5FF1A388 File Offset: 0x5FF0F188
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class28(this.sbyte_0);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x5FF1A3A4 File Offset: 0x5FF0F1A4
		public override object vmethod_1()
		{
			return this.sbyte_0;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x5FF1A3C0 File Offset: 0x5FF0F1C0
		public override void vmethod_2(object object_0)
		{
			this.sbyte_0 = Convert.ToSByte(object_0);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x5FF19FE4 File Offset: 0x5FF0EDE4
		public override GClass15.Class3 vmethod_4()
		{
			return new GClass15.Class4(this.F877E806());
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x5FF1A3DC File Offset: 0x5FF0F1DC
		public override sbyte vmethod_9()
		{
			return this.sbyte_0;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x5FF1A3F4 File Offset: 0x5FF0F1F4
		public override byte vmethod_10()
		{
			return (byte)this.sbyte_0;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x5FF1A3DC File Offset: 0x5FF0F1DC
		public override short FCCCFC2F()
		{
			return (short)this.sbyte_0;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x5FF1A408 File Offset: 0x5FF0F208
		public override ushort C7D32E95()
		{
			return (ushort)this.sbyte_0;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x5FF1A3DC File Offset: 0x5FF0F1DC
		public override int F877E806()
		{
			return (int)this.sbyte_0;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x5FF1A3DC File Offset: 0x5FF0F1DC
		public override uint vmethod_11()
		{
			return (uint)this.sbyte_0;
		}

		// Token: 0x040003BC RID: 956
		private sbyte sbyte_0;
	}

	// Token: 0x02000052 RID: 82
	private sealed class Class29 : GClass15.Class2
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x5FF1A420 File Offset: 0x5FF0F220
		public Class29(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x5FF1A43C File Offset: 0x5FF0F23C
		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x5FF1A454 File Offset: 0x5FF0F254
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class29(this.uint_0);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x5FF1A46C File Offset: 0x5FF0F26C
		public override object vmethod_1()
		{
			return this.uint_0;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x5FF1A488 File Offset: 0x5FF0F288
		public override void vmethod_2(object object_0)
		{
			this.uint_0 = Convert.ToUInt32(object_0);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x5FF19FE4 File Offset: 0x5FF0EDE4
		public override GClass15.Class3 vmethod_4()
		{
			return new GClass15.Class4(this.F877E806());
		}

		// Token: 0x060002BF RID: 703 RVA: 0x5FF1A4A4 File Offset: 0x5FF0F2A4
		public override sbyte vmethod_9()
		{
			return (sbyte)this.uint_0;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x5FF1A4B8 File Offset: 0x5FF0F2B8
		public override byte vmethod_10()
		{
			return (byte)this.uint_0;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x5FF1A4CC File Offset: 0x5FF0F2CC
		public override short FCCCFC2F()
		{
			return (short)this.uint_0;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x5FF1A4E0 File Offset: 0x5FF0F2E0
		public override ushort C7D32E95()
		{
			return (ushort)this.uint_0;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x5FF1A4F8 File Offset: 0x5FF0F2F8
		public override int F877E806()
		{
			return (int)this.uint_0;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x5FF1A4F8 File Offset: 0x5FF0F2F8
		public override uint vmethod_11()
		{
			return this.uint_0;
		}

		// Token: 0x040003BD RID: 957
		private uint uint_0;
	}

	// Token: 0x02000053 RID: 83
	private sealed class Class30 : GClass15.Class2
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x5FF1A50C File Offset: 0x5FF0F30C
		public Class30(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x5FF1A528 File Offset: 0x5FF0F328
		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x5FF1A540 File Offset: 0x5FF0F340
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class30(this.ulong_0);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x5FF1A558 File Offset: 0x5FF0F358
		public override object vmethod_1()
		{
			return this.ulong_0;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x5FF1A574 File Offset: 0x5FF0F374
		public override void vmethod_2(object object_0)
		{
			this.ulong_0 = Convert.ToUInt64(object_0);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x5FF1A590 File Offset: 0x5FF0F390
		public override GClass15.Class3 vmethod_4()
		{
			return new GClass15.Class5(this.CFA1D037());
		}

		// Token: 0x060002CB RID: 715 RVA: 0x5FF1A5A8 File Offset: 0x5FF0F3A8
		public override sbyte vmethod_9()
		{
			return (sbyte)this.ulong_0;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x5FF1A5C0 File Offset: 0x5FF0F3C0
		public override byte vmethod_10()
		{
			return (byte)this.ulong_0;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x5FF1A5D8 File Offset: 0x5FF0F3D8
		public override short FCCCFC2F()
		{
			return (short)this.ulong_0;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x5FF1A5F0 File Offset: 0x5FF0F3F0
		public override ushort C7D32E95()
		{
			return (ushort)this.ulong_0;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x5FF1A608 File Offset: 0x5FF0F408
		public override int F877E806()
		{
			return (int)this.ulong_0;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x5FF1A620 File Offset: 0x5FF0F420
		public override uint vmethod_11()
		{
			return (uint)this.ulong_0;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x5FF1A638 File Offset: 0x5FF0F438
		public override long CFA1D037()
		{
			return (long)this.ulong_0;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x5FF1A638 File Offset: 0x5FF0F438
		public override ulong vmethod_12()
		{
			return this.ulong_0;
		}

		// Token: 0x040003BE RID: 958
		private ulong ulong_0;
	}

	// Token: 0x02000054 RID: 84
	private sealed class Class9 : GClass15.Class3
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x5FF1A650 File Offset: 0x5FF0F450
		public Class9(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x5FF1A66C File Offset: 0x5FF0F46C
		public override Type vmethod_6()
		{
			return typeof(object);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x5FF11048 File Offset: 0x5FF05E48
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x5FF1A684 File Offset: 0x5FF0F484
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class9(this.object_0);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x5FF1A69C File Offset: 0x5FF0F49C
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x5FF1A6B4 File Offset: 0x5FF0F4B4
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x5FF1A6C8 File Offset: 0x5FF0F4C8
		public override bool vmethod_8()
		{
			return this.object_0 != null;
		}

		// Token: 0x040003BF RID: 959
		private object object_0;
	}

	// Token: 0x02000055 RID: 85
	private sealed class Class10 : GClass15.Class3
	{
		// Token: 0x060002DA RID: 730 RVA: 0x5FF1A6E0 File Offset: 0x5FF0F4E0
		public Class10(object object_1, Type type_1)
		{
			this.object_0 = object_1;
			this.type_0 = type_1;
			this.class2_0 = GClass15.Class10.smethod_0(object_1);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x5FF1A710 File Offset: 0x5FF0F510
		private static GClass15.Class2 smethod_0(object object_1)
		{
			IntPtr intPtr = (object_1 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_1));
			if (IntPtr.Size == 4)
			{
				return new GClass15.Class4(intPtr.ToInt32());
			}
			return new GClass15.Class5(intPtr.ToInt64());
		}

		// Token: 0x060002DC RID: 732 RVA: 0x5FF1A66C File Offset: 0x5FF0F46C
		public override Type vmethod_6()
		{
			return typeof(object);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x5FF1A754 File Offset: 0x5FF0F554
		public Type method_0()
		{
			return this.type_0;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x5FF1A768 File Offset: 0x5FF0F568
		public override TypeCode vmethod_7()
		{
			if (IntPtr.Size != 4)
			{
				return TypeCode.UInt64;
			}
			return TypeCode.UInt32;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x5FF1A784 File Offset: 0x5FF0F584
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class10(this.object_0, this.type_0);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x5FF1A7A8 File Offset: 0x5FF0F5A8
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x5FF1A7C0 File Offset: 0x5FF0F5C0
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
			this.class2_0 = GClass15.Class10.smethod_0(object_1);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x5FF1A7E0 File Offset: 0x5FF0F5E0
		public override bool vmethod_8()
		{
			return this.object_0 != null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x5FF1A7F8 File Offset: 0x5FF0F5F8
		public override sbyte vmethod_9()
		{
			return this.class2_0.vmethod_9();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x5FF1A810 File Offset: 0x5FF0F610
		public override short FCCCFC2F()
		{
			return this.class2_0.FCCCFC2F();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x5FF1A82C File Offset: 0x5FF0F62C
		public override int F877E806()
		{
			return this.class2_0.F877E806();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x5FF1A848 File Offset: 0x5FF0F648
		public override long CFA1D037()
		{
			return this.class2_0.CFA1D037();
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x5FF1A860 File Offset: 0x5FF0F660
		public override byte vmethod_10()
		{
			return this.class2_0.vmethod_10();
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x5FF1A87C File Offset: 0x5FF0F67C
		public override ushort C7D32E95()
		{
			return this.class2_0.C7D32E95();
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x5FF1A894 File Offset: 0x5FF0F694
		public override uint vmethod_11()
		{
			return this.class2_0.vmethod_11();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x5FF1A8B0 File Offset: 0x5FF0F6B0
		public override ulong vmethod_12()
		{
			return this.class2_0.vmethod_12();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x5FF1A8CC File Offset: 0x5FF0F6CC
		public override float A08827DF()
		{
			return this.class2_0.A08827DF();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x5FF1A8E8 File Offset: 0x5FF0F6E8
		public override double vmethod_13()
		{
			return this.class2_0.vmethod_13();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x5FF1A904 File Offset: 0x5FF0F704
		public override IntPtr A295314C()
		{
			return this.class2_0.A295314C();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x5FF1A91C File Offset: 0x5FF0F71C
		public override UIntPtr vmethod_14()
		{
			return this.class2_0.vmethod_14();
		}

		// Token: 0x060002EF RID: 751 RVA: 0x5FF1A938 File Offset: 0x5FF0F738
		public override object DF4F620E(Type type_1, bool bool_0)
		{
			return this.class2_0.DF4F620E(type_1, bool_0);
		}

		// Token: 0x040003C0 RID: 960
		private object object_0;

		// Token: 0x040003C1 RID: 961
		private Type type_0;

		// Token: 0x040003C2 RID: 962
		private GClass15.Class2 class2_0;
	}

	// Token: 0x02000056 RID: 86
	private sealed class Class11 : GClass15.Class3
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x5FF1A954 File Offset: 0x5FF0F754
		public Class11(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			this.object_0 = object_1;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x5FF1A980 File Offset: 0x5FF0F780
		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x5FF1A998 File Offset: 0x5FF0F798
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class11(this.object_0);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x5FF1A9B0 File Offset: 0x5FF0F7B0
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x5FF1A9C8 File Offset: 0x5FF0F7C8
		public override void vmethod_2(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			this.object_0 = object_1;
		}

		// Token: 0x040003C3 RID: 963
		private object object_0;
	}

	// Token: 0x02000057 RID: 87
	private sealed class Class12 : GClass15.Class3
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x5FF1A9F0 File Offset: 0x5FF0F7F0
		public Class12(Array array_1)
		{
			this.array_0 = array_1;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x5FF1AA0C File Offset: 0x5FF0F80C
		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x5FF1AA24 File Offset: 0x5FF0F824
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class12(this.array_0);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x5FF1AA3C File Offset: 0x5FF0F83C
		public override object vmethod_1()
		{
			return this.array_0;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x5FF1AA54 File Offset: 0x5FF0F854
		public override void vmethod_2(object object_0)
		{
			this.array_0 = (Array)object_0;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x5FF1AA70 File Offset: 0x5FF0F870
		public override bool vmethod_8()
		{
			return this.array_0 != null;
		}

		// Token: 0x040003C4 RID: 964
		private Array array_0;
	}

	// Token: 0x02000058 RID: 88
	private abstract class Class13 : GClass15.Class3
	{
		// Token: 0x060002FB RID: 763 RVA: 0x5FF11048 File Offset: 0x5FF05E48
		public override bool vmethod_3()
		{
			return true;
		}
	}

	// Token: 0x02000059 RID: 89
	private sealed class Class14 : GClass15.Class13
	{
		// Token: 0x060002FD RID: 765 RVA: 0x5FF1AAA0 File Offset: 0x5FF0F8A0
		public Class14(GClass15.Class2 class2_1)
		{
			this.class2_0 = class2_1;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x5FF1AABC File Offset: 0x5FF0F8BC
		public override Type vmethod_6()
		{
			return this.class2_0.vmethod_6();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x5FF1AAD8 File Offset: 0x5FF0F8D8
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class14(this.class2_0);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x5FF1AAF0 File Offset: 0x5FF0F8F0
		public override object vmethod_1()
		{
			return this.class2_0.vmethod_1();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x5FF1AB08 File Offset: 0x5FF0F908
		public override void vmethod_2(object object_0)
		{
			this.class2_0.vmethod_2(object_0);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x5FF1AB24 File Offset: 0x5FF0F924
		public override bool vmethod_8()
		{
			return this.class2_0 != null;
		}

		// Token: 0x040003C5 RID: 965
		private GClass15.Class2 class2_0;
	}

	// Token: 0x0200005A RID: 90
	private sealed class Class15 : GClass15.Class13
	{
		// Token: 0x06000303 RID: 771 RVA: 0x5FF1AB3C File Offset: 0x5FF0F93C
		public Class15(GClass15.Class2 class2_2, GClass15.Class2 class2_3)
		{
			this.class2_0 = class2_2;
			this.class2_1 = class2_3;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x5FF1AB60 File Offset: 0x5FF0F960
		public override Type vmethod_6()
		{
			return this.class2_0.vmethod_6();
		}

		// Token: 0x06000305 RID: 773 RVA: 0x5FF1AB7C File Offset: 0x5FF0F97C
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class15(this.class2_0, this.class2_1);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x5FF1AB9C File Offset: 0x5FF0F99C
		public override object vmethod_1()
		{
			return this.class2_0.vmethod_1();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x5FF1ABB8 File Offset: 0x5FF0F9B8
		public override void vmethod_2(object object_0)
		{
			this.class2_0.vmethod_2(object_0);
			this.class2_1.vmethod_2(this.class2_0.vmethod_1());
		}

		// Token: 0x06000308 RID: 776 RVA: 0x5FF1ABE8 File Offset: 0x5FF0F9E8
		public override bool vmethod_8()
		{
			return this.class2_0 != null;
		}

		// Token: 0x040003C6 RID: 966
		private GClass15.Class2 class2_0;

		// Token: 0x040003C7 RID: 967
		private GClass15.Class2 class2_1;
	}

	// Token: 0x0200005B RID: 91
	private sealed class Class16 : GClass15.Class13
	{
		// Token: 0x06000309 RID: 777 RVA: 0x5FF1AC00 File Offset: 0x5FF0FA00
		public Class16(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x5FF1AC24 File Offset: 0x5FF0FA24
		public override Type vmethod_6()
		{
			return this.fieldInfo_0.FieldType;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x5FF1AC3C File Offset: 0x5FF0FA3C
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class16(this.fieldInfo_0, this.object_0);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x5FF1AC5C File Offset: 0x5FF0FA5C
		public override object vmethod_1()
		{
			return this.fieldInfo_0.GetValue(this.object_0);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x5FF1AC80 File Offset: 0x5FF0FA80
		public override void vmethod_2(object object_1)
		{
			this.fieldInfo_0.SetValue(this.object_0, object_1);
		}

		// Token: 0x040003C8 RID: 968
		private FieldInfo fieldInfo_0;

		// Token: 0x040003C9 RID: 969
		private object object_0;
	}

	// Token: 0x0200005C RID: 92
	private sealed class Class17 : GClass15.Class13
	{
		// Token: 0x0600030E RID: 782 RVA: 0x5FF1ACA0 File Offset: 0x5FF0FAA0
		public Class17(Array array_1, int int_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x5FF1ACC4 File Offset: 0x5FF0FAC4
		public override Type vmethod_6()
		{
			return this.array_0.GetType().GetElementType();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x5FF1ACE4 File Offset: 0x5FF0FAE4
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class17(this.array_0, this.int_0);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x5FF1AD08 File Offset: 0x5FF0FB08
		public override object vmethod_1()
		{
			return this.array_0.GetValue(this.int_0);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x5FF1AD2C File Offset: 0x5FF0FB2C
		public override void vmethod_2(object object_0)
		{
			this.array_0.SetValue(object_0, this.int_0);
		}

		// Token: 0x040003CA RID: 970
		private Array array_0;

		// Token: 0x040003CB RID: 971
		private int int_0;
	}

	// Token: 0x0200005D RID: 93
	private sealed class Class19 : GClass15.Class3
	{
		// Token: 0x06000313 RID: 787 RVA: 0x5FF1AD4C File Offset: 0x5FF0FB4C
		public Class19(MethodBase methodBase_1)
		{
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x5FF1AD68 File Offset: 0x5FF0FB68
		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x5FF1AD80 File Offset: 0x5FF0FB80
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class19(this.methodBase_0);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x5FF1AD9C File Offset: 0x5FF0FB9C
		public override object vmethod_1()
		{
			return this.methodBase_0;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x5FF1ADB4 File Offset: 0x5FF0FBB4
		public override void vmethod_2(object object_0)
		{
			this.methodBase_0 = (MethodBase)object_0;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x5FF1ADD0 File Offset: 0x5FF0FBD0
		public override bool vmethod_8()
		{
			return this.methodBase_0 != null;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x5FF1ADE8 File Offset: 0x5FF0FBE8
		public override IntPtr A295314C()
		{
			return this.methodBase_0.MethodHandle.GetFunctionPointer();
		}

		// Token: 0x040003CC RID: 972
		private MethodBase methodBase_0;
	}

	// Token: 0x0200005E RID: 94
	private sealed class Class20 : GClass15.Class3
	{
		// Token: 0x0600031A RID: 794 RVA: 0x5FF1AE10 File Offset: 0x5FF0FC10
		public Class20(IntPtr intptr_1)
		{
			this.intptr_0 = intptr_1;
			this.class2_0 = GClass15.Class20.smethod_0(this.intptr_0);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x5FF1AE3C File Offset: 0x5FF0FC3C
		private static GClass15.Class2 smethod_0(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new GClass15.Class4(intptr_1.ToInt32());
			}
			return new GClass15.Class5(intptr_1.ToInt64());
		}

		// Token: 0x0600031C RID: 796 RVA: 0x5FF1AE6C File Offset: 0x5FF0FC6C
		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x5FF1AE84 File Offset: 0x5FF0FC84
		public override TypeCode vmethod_7()
		{
			return this.class2_0.vmethod_7();
		}

		// Token: 0x0600031E RID: 798 RVA: 0x5FF1AEA0 File Offset: 0x5FF0FCA0
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class20(this.intptr_0);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x5FF1AEB8 File Offset: 0x5FF0FCB8
		public override object vmethod_1()
		{
			return this.intptr_0;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x5FF1AED4 File Offset: 0x5FF0FCD4
		public override void vmethod_2(object object_0)
		{
			this.intptr_0 = (IntPtr)object_0;
			this.class2_0 = GClass15.Class20.smethod_0(this.intptr_0);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x5FF1AF00 File Offset: 0x5FF0FD00
		public override bool vmethod_8()
		{
			return this.intptr_0 != IntPtr.Zero;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x5FF1AF20 File Offset: 0x5FF0FD20
		public override sbyte vmethod_9()
		{
			return this.class2_0.vmethod_9();
		}

		// Token: 0x06000323 RID: 803 RVA: 0x5FF1AF38 File Offset: 0x5FF0FD38
		public override short FCCCFC2F()
		{
			return this.class2_0.FCCCFC2F();
		}

		// Token: 0x06000324 RID: 804 RVA: 0x5FF1AF54 File Offset: 0x5FF0FD54
		public override int F877E806()
		{
			return this.class2_0.F877E806();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x5FF1AF70 File Offset: 0x5FF0FD70
		public override long CFA1D037()
		{
			return this.class2_0.CFA1D037();
		}

		// Token: 0x06000326 RID: 806 RVA: 0x5FF1AF8C File Offset: 0x5FF0FD8C
		public override byte vmethod_10()
		{
			return this.class2_0.vmethod_10();
		}

		// Token: 0x06000327 RID: 807 RVA: 0x5FF1AFA8 File Offset: 0x5FF0FDA8
		public override ushort C7D32E95()
		{
			return this.class2_0.C7D32E95();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x5FF1AFC0 File Offset: 0x5FF0FDC0
		public override uint vmethod_11()
		{
			return this.class2_0.vmethod_11();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x5FF1AFDC File Offset: 0x5FF0FDDC
		public override ulong vmethod_12()
		{
			return this.class2_0.vmethod_12();
		}

		// Token: 0x0600032A RID: 810 RVA: 0x5FF1AFF4 File Offset: 0x5FF0FDF4
		public override float A08827DF()
		{
			return this.class2_0.A08827DF();
		}

		// Token: 0x0600032B RID: 811 RVA: 0x5FF1B010 File Offset: 0x5FF0FE10
		public override double vmethod_13()
		{
			return this.class2_0.vmethod_13();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x5FF1B02C File Offset: 0x5FF0FE2C
		public override IntPtr A295314C()
		{
			return this.intptr_0;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x5FF1B040 File Offset: 0x5FF0FE40
		public override UIntPtr vmethod_14()
		{
			return this.class2_0.vmethod_14();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x5FF1B058 File Offset: 0x5FF0FE58
		public override object DF4F620E(Type type_0, bool bool_0)
		{
			return this.class2_0.DF4F620E(type_0, bool_0);
		}

		// Token: 0x040003CD RID: 973
		private IntPtr intptr_0;

		// Token: 0x040003CE RID: 974
		private GClass15.Class2 class2_0;
	}

	// Token: 0x0200005F RID: 95
	private sealed class Class21 : GClass15.Class3
	{
		// Token: 0x0600032F RID: 815 RVA: 0x5FF1B074 File Offset: 0x5FF0FE74
		public Class21(UIntPtr uintptr_1)
		{
			this.uintptr_0 = uintptr_1;
			this.class2_0 = GClass15.Class21.smethod_0(this.uintptr_0);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x5FF1B0A0 File Offset: 0x5FF0FEA0
		private static GClass15.Class2 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new GClass15.Class4((int)uintptr_1.ToUInt32());
			}
			return new GClass15.Class5((long)uintptr_1.ToUInt64());
		}

		// Token: 0x06000331 RID: 817 RVA: 0x5FF1B0D0 File Offset: 0x5FF0FED0
		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x5FF1B0E8 File Offset: 0x5FF0FEE8
		public override TypeCode vmethod_7()
		{
			return this.class2_0.vmethod_7();
		}

		// Token: 0x06000333 RID: 819 RVA: 0x5FF1B104 File Offset: 0x5FF0FF04
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class21(this.uintptr_0);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x5FF1B11C File Offset: 0x5FF0FF1C
		public override object vmethod_1()
		{
			return this.uintptr_0;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x5FF1B134 File Offset: 0x5FF0FF34
		public override void vmethod_2(object object_0)
		{
			this.uintptr_0 = (UIntPtr)object_0;
			this.class2_0 = GClass15.Class21.smethod_0(this.uintptr_0);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x5FF1B160 File Offset: 0x5FF0FF60
		public override bool vmethod_8()
		{
			return this.uintptr_0 != UIntPtr.Zero;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x5FF1B180 File Offset: 0x5FF0FF80
		public override sbyte vmethod_9()
		{
			return this.class2_0.vmethod_9();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x5FF1B19C File Offset: 0x5FF0FF9C
		public override short FCCCFC2F()
		{
			return this.class2_0.FCCCFC2F();
		}

		// Token: 0x06000339 RID: 825 RVA: 0x5FF1B1B8 File Offset: 0x5FF0FFB8
		public override int F877E806()
		{
			return this.class2_0.F877E806();
		}

		// Token: 0x0600033A RID: 826 RVA: 0x5FF1B1D4 File Offset: 0x5FF0FFD4
		public override long CFA1D037()
		{
			return this.class2_0.CFA1D037();
		}

		// Token: 0x0600033B RID: 827 RVA: 0x5FF1B1F0 File Offset: 0x5FF0FFF0
		public override byte vmethod_10()
		{
			return this.class2_0.vmethod_10();
		}

		// Token: 0x0600033C RID: 828 RVA: 0x5FF1B208 File Offset: 0x5FF10008
		public override ushort C7D32E95()
		{
			return this.class2_0.C7D32E95();
		}

		// Token: 0x0600033D RID: 829 RVA: 0x5FF1B224 File Offset: 0x5FF10024
		public override uint vmethod_11()
		{
			return this.class2_0.vmethod_11();
		}

		// Token: 0x0600033E RID: 830 RVA: 0x5FF1B240 File Offset: 0x5FF10040
		public override ulong vmethod_12()
		{
			return this.class2_0.vmethod_12();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x5FF1B258 File Offset: 0x5FF10058
		public override float A08827DF()
		{
			return this.class2_0.A08827DF();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x5FF1B274 File Offset: 0x5FF10074
		public override double vmethod_13()
		{
			return this.class2_0.vmethod_13();
		}

		// Token: 0x06000341 RID: 833 RVA: 0x5FF1B290 File Offset: 0x5FF10090
		public override IntPtr A295314C()
		{
			return this.class2_0.A295314C();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x5FF1B2A8 File Offset: 0x5FF100A8
		public override UIntPtr vmethod_14()
		{
			return this.uintptr_0;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x5FF1B2C0 File Offset: 0x5FF100C0
		public override object DF4F620E(Type type_0, bool bool_0)
		{
			return this.class2_0.DF4F620E(type_0, bool_0);
		}

		// Token: 0x040003CF RID: 975
		private UIntPtr uintptr_0;

		// Token: 0x040003D0 RID: 976
		private GClass15.Class2 class2_0;
	}

	// Token: 0x02000060 RID: 96
	private sealed class Class22 : GClass15.Class3
	{
		// Token: 0x06000344 RID: 836 RVA: 0x5FF1B2DC File Offset: 0x5FF100DC
		public Class22(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = enum_1;
			this.class2_0 = GClass15.Class22.smethod_0(this.enum_0);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x5FF1B310 File Offset: 0x5FF10110
		private static GClass15.Class2 smethod_0(Enum enum_1)
		{
			switch (enum_1.GetTypeCode())
			{
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
				return new GClass15.Class4(Convert.ToInt32(enum_1));
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
				return new GClass15.Class4((int)Convert.ToUInt32(enum_1));
			case TypeCode.Int64:
				return new GClass15.Class5(Convert.ToInt64(enum_1));
			case TypeCode.UInt64:
				return new GClass15.Class5((long)Convert.ToUInt64(enum_1));
			default:
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x5FF1B384 File Offset: 0x5FF10184
		public override GClass15.Class2 vmethod_5()
		{
			return this.class2_0.vmethod_5();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x5FF1B39C File Offset: 0x5FF1019C
		public override Type vmethod_6()
		{
			return this.enum_0.GetType();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x5FF1B3B8 File Offset: 0x5FF101B8
		public override TypeCode vmethod_7()
		{
			return this.class2_0.vmethod_7();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x5FF1B3D0 File Offset: 0x5FF101D0
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class22(this.enum_0);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x5FF1B3EC File Offset: 0x5FF101EC
		public override object vmethod_1()
		{
			return this.enum_0;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x5FF1B404 File Offset: 0x5FF10204
		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = (Enum)object_0;
			this.class2_0 = GClass15.Class22.smethod_0(this.enum_0);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x5FF1B438 File Offset: 0x5FF10238
		public override byte vmethod_10()
		{
			return this.class2_0.vmethod_10();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x5FF1B450 File Offset: 0x5FF10250
		public override sbyte vmethod_9()
		{
			return this.class2_0.vmethod_9();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x5FF1B468 File Offset: 0x5FF10268
		public override short FCCCFC2F()
		{
			return this.class2_0.FCCCFC2F();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x5FF1B480 File Offset: 0x5FF10280
		public override ushort C7D32E95()
		{
			return this.class2_0.C7D32E95();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x5FF1B498 File Offset: 0x5FF10298
		public override int F877E806()
		{
			return this.class2_0.F877E806();
		}

		// Token: 0x06000351 RID: 849 RVA: 0x5FF1B4B4 File Offset: 0x5FF102B4
		public override uint vmethod_11()
		{
			return this.class2_0.vmethod_11();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x5FF1B4D0 File Offset: 0x5FF102D0
		public override long CFA1D037()
		{
			return this.class2_0.CFA1D037();
		}

		// Token: 0x06000353 RID: 851 RVA: 0x5FF1B4EC File Offset: 0x5FF102EC
		public override ulong vmethod_12()
		{
			return this.class2_0.vmethod_12();
		}

		// Token: 0x06000354 RID: 852 RVA: 0x5FF1B508 File Offset: 0x5FF10308
		public override float A08827DF()
		{
			return this.class2_0.A08827DF();
		}

		// Token: 0x06000355 RID: 853 RVA: 0x5FF1B520 File Offset: 0x5FF10320
		public override double vmethod_13()
		{
			return this.class2_0.vmethod_13();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x5FF1B538 File Offset: 0x5FF10338
		public override IntPtr A295314C()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)this.F877E806()) : this.CFA1D037());
		}

		// Token: 0x06000357 RID: 855 RVA: 0x5FF1B564 File Offset: 0x5FF10364
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)this.vmethod_11()) : this.vmethod_12());
		}

		// Token: 0x06000358 RID: 856 RVA: 0x5FF1B590 File Offset: 0x5FF10390
		public override object DF4F620E(Type type_0, bool bool_0)
		{
			return this.class2_0.DF4F620E(type_0, bool_0);
		}

		// Token: 0x040003D1 RID: 977
		private Enum enum_0;

		// Token: 0x040003D2 RID: 978
		private GClass15.Class2 class2_0;
	}

	// Token: 0x02000061 RID: 97
	private sealed class Class18 : GClass15.Class13
	{
		// Token: 0x06000359 RID: 857 RVA: 0x5FF1B5B4 File Offset: 0x5FF103B4
		public Class18(IntPtr intptr_1, Type type_1)
		{
			this.intptr_0 = intptr_1;
			this.type_0 = type_1;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x5FF1B5D8 File Offset: 0x5FF103D8
		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x5FF1109C File Offset: 0x5FF05E9C
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x5FF1B5F0 File Offset: 0x5FF103F0
		public override GClass15.Class2 vmethod_0()
		{
			return new GClass15.Class18(this.intptr_0, this.type_0);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x5FF1B614 File Offset: 0x5FF10414
		public override object vmethod_1()
		{
			if (!this.type_0.IsValueType)
			{
				throw new InvalidOperationException();
			}
			return Marshal.PtrToStructure(this.intptr_0, this.type_0);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x5FF1B648 File Offset: 0x5FF10448
		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			if (this.type_0.IsValueType)
			{
				Marshal.StructureToPtr(object_0, this.intptr_0, false);
				return;
			}
			switch (Type.GetTypeCode(object_0.GetType()))
			{
			case TypeCode.Char:
				Marshal.WriteInt16(this.intptr_0, Convert.ToChar(object_0));
				return;
			case TypeCode.SByte:
				Marshal.WriteByte(this.intptr_0, (byte)Convert.ToSByte(object_0));
				return;
			case TypeCode.Byte:
				Marshal.WriteByte(this.intptr_0, Convert.ToByte(object_0));
				return;
			case TypeCode.Int16:
				Marshal.WriteInt16(this.intptr_0, Convert.ToInt16(object_0));
				return;
			case TypeCode.UInt16:
				Marshal.WriteInt16(this.intptr_0, (short)Convert.ToUInt16(object_0));
				return;
			case TypeCode.Int32:
				Marshal.WriteInt32(this.intptr_0, Convert.ToInt32(object_0));
				return;
			case TypeCode.UInt32:
				Marshal.WriteInt32(this.intptr_0, (int)Convert.ToUInt32(object_0));
				return;
			case TypeCode.Int64:
				Marshal.WriteInt64(this.intptr_0, Convert.ToInt64(object_0));
				return;
			case TypeCode.UInt64:
				Marshal.WriteInt64(this.intptr_0, (long)Convert.ToUInt64(object_0));
				return;
			case TypeCode.Single:
				Marshal.WriteInt32(this.intptr_0, BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(object_0)), 0));
				return;
			case TypeCode.Double:
				Marshal.WriteInt64(this.intptr_0, BitConverter.ToInt64(BitConverter.GetBytes(Convert.ToDouble(object_0)), 0));
				return;
			default:
				throw new ArgumentException();
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x5FF1B79C File Offset: 0x5FF1059C
		public override sbyte vmethod_9()
		{
			return (sbyte)Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x5FF1B7B8 File Offset: 0x5FF105B8
		public override short FCCCFC2F()
		{
			return Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x5FF1B7D0 File Offset: 0x5FF105D0
		public override int F877E806()
		{
			return Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x5FF1B7E8 File Offset: 0x5FF105E8
		public override long CFA1D037()
		{
			return Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x5FF1B804 File Offset: 0x5FF10604
		public override char E6138F88()
		{
			return (char)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x5FF1B820 File Offset: 0x5FF10620
		public override byte vmethod_10()
		{
			return Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x5FF1B804 File Offset: 0x5FF10604
		public override ushort C7D32E95()
		{
			return (ushort)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x5FF1B7D0 File Offset: 0x5FF105D0
		public override uint vmethod_11()
		{
			return (uint)Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x5FF1B7E8 File Offset: 0x5FF105E8
		public override ulong vmethod_12()
		{
			return (ulong)Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x5FF1B838 File Offset: 0x5FF10638
		public override float A08827DF()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(this.intptr_0)), 0);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x5FF1B85C File Offset: 0x5FF1065C
		public override double vmethod_13()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(this.intptr_0)), 0);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x5FF1B880 File Offset: 0x5FF10680
		public override IntPtr A295314C()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)Marshal.ReadInt32(this.intptr_0)) : Marshal.ReadInt64(this.intptr_0));
		}

		// Token: 0x0600036B RID: 875 RVA: 0x5FF1B8B4 File Offset: 0x5FF106B4
		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)Marshal.ReadInt32(this.intptr_0)) : ((ulong)Marshal.ReadInt64(this.intptr_0)));
		}

		// Token: 0x040003D3 RID: 979
		private IntPtr intptr_0;

		// Token: 0x040003D4 RID: 980
		private Type type_0;
	}

	// Token: 0x02000062 RID: 98
	private sealed class Class31
	{
		// Token: 0x0600036C RID: 876 RVA: 0x5FF1B8E8 File Offset: 0x5FF106E8
		public Class31(byte byte_1, int int_2, int int_3)
		{
			this.byte_0 = byte_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x5FF1B910 File Offset: 0x5FF10710
		public byte method_0()
		{
			return this.byte_0;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x5FF1B928 File Offset: 0x5FF10728
		public int method_1()
		{
			return this.int_0;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x5FF1B940 File Offset: 0x5FF10740
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x040003D5 RID: 981
		private byte byte_0;

		// Token: 0x040003D6 RID: 982
		private int int_0;

		// Token: 0x040003D7 RID: 983
		private int int_1;
	}

	// Token: 0x02000063 RID: 99
	private sealed class Class32
	{
		// Token: 0x06000370 RID: 880 RVA: 0x5FF1B954 File Offset: 0x5FF10754
		public Class32(int int_2, int int_3)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x5FF1B980 File Offset: 0x5FF10780
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x5FF1B998 File Offset: 0x5FF10798
		public int method_1()
		{
			return this.int_1;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x5FF1B9AC File Offset: 0x5FF107AC
		public int method_2(GClass15.Class32 class32_0)
		{
			if (class32_0 == null)
			{
				return 1;
			}
			int num = this.int_0.CompareTo(class32_0.method_0());
			if (num == 0)
			{
				num = class32_0.method_1().CompareTo(this.int_1);
			}
			return num;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x5FF1B9EC File Offset: 0x5FF107EC
		public void method_3(byte byte_0, int int_2, int int_3)
		{
			this.list_0.Add(new GClass15.Class31(byte_0, int_2, int_3));
		}

		// Token: 0x06000375 RID: 885 RVA: 0x5FF1BA0C File Offset: 0x5FF1080C
		public List<GClass15.Class31> method_4()
		{
			return this.list_0;
		}

		// Token: 0x040003D8 RID: 984
		private int int_0;

		// Token: 0x040003D9 RID: 985
		private int int_1;

		// Token: 0x040003DA RID: 986
		private List<GClass15.Class31> list_0 = new List<GClass15.Class31>();
	}

	// Token: 0x02000064 RID: 100
	// (Invoke) Token: 0x06000377 RID: 887
	internal delegate void Delegate1();
}
