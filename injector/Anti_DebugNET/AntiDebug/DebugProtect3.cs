using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000017 RID: 23
	internal class DebugProtect3
	{
		// Token: 0x060000B2 RID: 178
		[DllImport("ntdll.dll")]
		internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x060000B3 RID: 179
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x060000B4 RID: 180
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x060000B5 RID: 181
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x060000B6 RID: 182
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x060000B7 RID: 183 RVA: 0x5FF104C0 File Offset: 0x5FF052C0
		public static void HideOSThreads()
		{
			ProcessThreadCollection threads = Process.GetCurrentProcess().Threads;
			foreach (object obj in threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[GetOSThreads]: thread.Id {0:X}", processThread.Id);
				IntPtr intPtr = DebugProtect3.OpenThread(ThreadAccess.SET_INFORMATION, false, (uint)processThread.Id);
				if (intPtr == IntPtr.Zero)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("[GetOSThreads]: skipped thread.Id {0:X}", processThread.Id);
				}
				else
				{
					if (DebugProtect3.HideFromDebugger(intPtr))
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("[GetOSThreads]: thread.Id {0:X} hidden from debbuger.", processThread.Id);
					}
					DebugProtect3.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x5FF105E8 File Offset: 0x5FF053E8
		public static bool HideFromDebugger(IntPtr Handle)
		{
			NtStatus ntStatus = DebugProtect3.NtSetInformationThread(Handle, ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0);
			return ntStatus == NtStatus.Success;
		}
	}
}
