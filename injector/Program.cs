using System;
using System.Windows.Forms;

namespace injector
{
	// Token: 0x0200000A RID: 10
	internal static class Program
	{
		// Token: 0x06000071 RID: 113 RVA: 0x5FF0A155 File Offset: 0x5FEFEF55
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Visor());
		}

		// Token: 0x04000080 RID: 128
		public static string GameFolder;
	}
}
