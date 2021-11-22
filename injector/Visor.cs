using System;
using System.ComponentModel;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using Siticone.UI.WinForms;

namespace injector
{
	// Token: 0x02000008 RID: 8
	public partial class Visor : Form
	{
		// Token: 0x0600003C RID: 60 RVA: 0x6C2C6000 File Offset: 0x6C2B9200
		public Visor()
		{
			Console.Beep(500, 500);
			MessageBox.Show("Entry Point");
			this.InitializeComponent();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x5FF0D524 File Offset: 0x5FF02324
		private void button1_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 77418);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x5FF0D574 File Offset: 0x5FF02374
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400027005);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x5FF0D5C4 File Offset: 0x5FF023C4
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 48575);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x5FF0D614 File Offset: 0x5FF02414
		private void label1_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400010919);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x5FF0D664 File Offset: 0x5FF02464
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400037805);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x5FF0D6B4 File Offset: 0x5FF024B4
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399964029);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x5FF0D704 File Offset: 0x5FF02504
		private string identifier(string wmiClass, string wmiProperty)
		{
			object[] object_ = new object[]
			{
				this,
				wmiClass,
				wmiProperty
			};
			return new GClass15().method_112(object_, 83580);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x6C2C6028 File Offset: 0x6C2B9228
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				object[] object_ = new object[]
				{
					this,
					sender,
					e
				};
				new GClass15().method_112(object_, 105346);
			}
			catch
			{
				MessageBox.Show("unhandled. Press Ok To Continue");
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x5FF0D7AC File Offset: 0x5FF025AC
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			object[] object_ = new object[]
			{
				this,
				unixtime
			};
			return (DateTime)new GClass15().method_112(object_, 68485);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x5FF0D804 File Offset: 0x5FF02604
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 46872);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x5FF0D854 File Offset: 0x5FF02654
		private void button2_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 80478);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x5FF0D8A4 File Offset: 0x5FF026A4
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399976716);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x5FF0D8F4 File Offset: 0x5FF026F4
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 65350);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x5FF0D944 File Offset: 0x5FF02744
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400009409);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x5FF0D994 File Offset: 0x5FF02794
		private void button3_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399985496);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x5FF0D9E4 File Offset: 0x5FF027E4
		private void button4_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400027631);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x5FF0DA34 File Offset: 0x5FF02834
		private void button5_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 66638);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x5FF0DA84 File Offset: 0x5FF02884
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399998932);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x5FF0DAD4 File Offset: 0x5FF028D4
		private void groupBox5_Enter(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400011042);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x5FF0DB24 File Offset: 0x5FF02924
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399998722);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x5FF0DB74 File Offset: 0x5FF02974
		private void timer1_Tick(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399974551);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x5FF0DBC4 File Offset: 0x5FF029C4
		private void expiry_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 72754);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x5FF0DC14 File Offset: 0x5FF02A14
		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 51278);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x5FF0DC64 File Offset: 0x5FF02A64
		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 89567);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x5FF0DCB4 File Offset: 0x5FF02AB4
		private void label1_Click_1(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 59153);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x5FF0DD04 File Offset: 0x5FF02B04
		private void groupBox1_Enter(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399979071);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x5FF0DD54 File Offset: 0x5FF02B54
		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 79273);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x5FF0DDA4 File Offset: 0x5FF02BA4
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400005427);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x5FF0DDF4 File Offset: 0x5FF02BF4
		private void bunifuSwitch1_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 66081);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x5FF0DE44 File Offset: 0x5FF02C44
		private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 69977);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x5FF0DE94 File Offset: 0x5FF02C94
		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 65101);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x5FF0DEE4 File Offset: 0x5FF02CE4
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399998571);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x5FF0DF34 File Offset: 0x5FF02D34
		private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 87830);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x5FF0DF84 File Offset: 0x5FF02D84
		private void button6_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400002814);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x5FF0DFD4 File Offset: 0x5FF02DD4
		private void button6_Click_1(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399992824);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x5FF0E024 File Offset: 0x5FF02E24
		private void textBox2_TextChanged_1(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 70589);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x5FF0E074 File Offset: 0x5FF02E74
		private void button7_Click(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 45563);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x5FF0E0C4 File Offset: 0x5FF02EC4
		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399995377);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x5FF0E114 File Offset: 0x5FF02F14
		private void DiskInfo_TextChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 78627);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x5FF0E164 File Offset: 0x5FF02F64
		private void checkBox1_CheckedChanged_3(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 400027319);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x5FF0E1B4 File Offset: 0x5FF02FB4
		private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 50601);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x5FF0E204 File Offset: 0x5FF03004
		private void Norecoil_TextChanged(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 399999135);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x5FF0E254 File Offset: 0x5FF03054
		private void button6_Click_2(object sender, EventArgs e)
		{
			object[] object_ = new object[]
			{
				this,
				sender,
				e
			};
			new GClass15().method_112(object_, 54232);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x5FF0E2A4 File Offset: 0x5FF030A4
		public static string GetFileProcessName(string filePath)
		{
			object[] object_ = new object[]
			{
				filePath
			};
			return new GClass15().method_112(object_, 400006237);
		}

		// Token: 0x0400003C RID: 60
		private IContainer components;

		// Token: 0x0400003D RID: 61
		private Button button1;

		// Token: 0x0400003E RID: 62
		private BunifuElipse bunifuElipse1;

		// Token: 0x0400003F RID: 63
		private BunifuElipse bunifuElipse2;

		// Token: 0x04000040 RID: 64
		private TextBox textBox1;

		// Token: 0x04000041 RID: 65
		private Button button2;

		// Token: 0x04000042 RID: 66
		private BunifuElipse bunifuElipse3;

		// Token: 0x04000043 RID: 67
		private NumericUpDown numericUpDown1;

		// Token: 0x04000044 RID: 68
		private BunifuElipse bunifuElipse4;

		// Token: 0x04000045 RID: 69
		private Label label2;

		// Token: 0x04000046 RID: 70
		private SiticoneLabel subscription;

		// Token: 0x04000047 RID: 71
		private SiticoneLabel expiry;

		// Token: 0x04000048 RID: 72
		private SiticoneLabel key;

		// Token: 0x04000049 RID: 73
		private BunifuElipse bunifuElipse5;

		// Token: 0x0400004A RID: 74
		private Button button3;

		// Token: 0x0400004B RID: 75
		private BunifuElipse bunifuElipse6;

		// Token: 0x0400004C RID: 76
		private BunifuDragControl bunifuDragControl1;

		// Token: 0x0400004D RID: 77
		private Label label3;

		// Token: 0x0400004E RID: 78
		private Button button4;

		// Token: 0x0400004F RID: 79
		private BunifuElipse bunifuElipse7;

		// Token: 0x04000050 RID: 80
		private TextBox textBox2;

		// Token: 0x04000051 RID: 81
		private Button button5;

		// Token: 0x04000052 RID: 82
		private BunifuElipse bunifuElipse8;

		// Token: 0x04000053 RID: 83
		private RadioButton radioButton2;

		// Token: 0x04000054 RID: 84
		private RadioButton radioButton1;

		// Token: 0x04000055 RID: 85
		private Label Status;

		// Token: 0x04000056 RID: 86
		private RadioButton radioButton3;

		// Token: 0x04000057 RID: 87
		private Panel panel1;

		// Token: 0x04000058 RID: 88
		private RadioButton radioButton4;

		// Token: 0x04000059 RID: 89
		private Timer timer1;

		// Token: 0x0400005A RID: 90
		private RadioButton radioButton5;

		// Token: 0x0400005B RID: 91
		private FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x0400005C RID: 92
		private Button button7;

		// Token: 0x0400005D RID: 93
		private BunifuElipse bunifuElipse9;

		// Token: 0x0400005E RID: 94
		private TextBox Norecoil;

		// Token: 0x0400005F RID: 95
		private OpenFileDialog openFileDialog1;

		// Token: 0x04000060 RID: 96
		private RadioButton radioButton6;

		// Token: 0x04000061 RID: 97
		private CheckBox checkBox1;

		// Token: 0x04000062 RID: 98
		private BunifuTransition bunifuTransition1;

		// Token: 0x04000063 RID: 99
		private Panel panel3;

		// Token: 0x04000064 RID: 100
		private Panel panel2;

		// Token: 0x04000065 RID: 101
		private Panel panel4;

		// Token: 0x04000066 RID: 102
		private Label label1;

		// Token: 0x04000067 RID: 103
		private TextBox Visiblebetter;

		// Token: 0x04000068 RID: 104
		private CheckBox checkBox2;
	}
}
