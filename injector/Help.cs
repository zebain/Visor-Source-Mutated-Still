using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using injector.Properties;
using Siticone.UI.WinForms;

namespace injector
{
	// Token: 0x02000009 RID: 9
	public partial class Help : Form
	{
		// Token: 0x0600006B RID: 107 RVA: 0x5FF0A12C File Offset: 0x5FEFEF2C
		public Help()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x5FF0A0F7 File Offset: 0x5FEFEEF7
		private void Help_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x5FF0A0F7 File Offset: 0x5FEFEEF7
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x5FF0A14A File Offset: 0x5FEFEF4A
		private void button3_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
