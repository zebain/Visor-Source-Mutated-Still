using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000007 RID: 7
	public partial class Main : Form
	{
		// Token: 0x06000035 RID: 53 RVA: 0x5FF0A0CD File Offset: 0x5FEFEECD
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x5FF0A0EB File Offset: 0x5FEFEEEB
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x5FF0A0F7 File Offset: 0x5FEFEEF7
		private void Main_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x5FF0C904 File Offset: 0x5FF01704
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x5FF0A0F7 File Offset: 0x5FEFEEF7
		private void subscription_Click(object sender, EventArgs e)
		{
		}
	}
}
