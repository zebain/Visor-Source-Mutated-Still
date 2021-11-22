using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000015 RID: 21
	internal class DebugProtect1
	{
		// Token: 0x060000A0 RID: 160
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x060000A1 RID: 161
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x060000A2 RID: 162 RVA: 0x5FF100D4 File Offset: 0x5FF04ED4
		public static int PerformChecks()
		{
			int result;
			if (DebugProtect1.CheckDebuggerManagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerManagedPresent: HIT");
				result = 1;
			}
			else if (DebugProtect1.CheckDebuggerUnmanagedPresent() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerUnmanagedPresent: HIT");
				result = 1;
			}
			else if (DebugProtect1.CheckRemoteDebugger() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckRemoteDebugger: HIT");
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x5FF10178 File Offset: 0x5FF04F78
		private static int CheckDebuggerManagedPresent()
		{
			int result;
			if (Debugger.IsAttached)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x5FF101A4 File Offset: 0x5FF04FA4
		private static int CheckDebuggerUnmanagedPresent()
		{
			int result;
			if (DebugProtect1.IsDebuggerPresent())
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x5FF101D0 File Offset: 0x5FF04FD0
		private static int CheckRemoteDebugger()
		{
			bool flag = false;
			int result;
			if (DebugProtect1.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag) && flag)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}
}
