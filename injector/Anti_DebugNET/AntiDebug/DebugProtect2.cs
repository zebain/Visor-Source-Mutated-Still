using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000016 RID: 22
	internal class DebugProtect2
	{
		// Token: 0x060000A7 RID: 167
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQueryInformationProcess([In] IntPtr ProcessHandle, [In] PROCESSINFOCLASS ProcessInformationClass, out IntPtr ProcessInformation, [In] int ProcessInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000A8 RID: 168
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtClose([In] IntPtr Handle);

		// Token: 0x060000A9 RID: 169
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtRemoveProcessDebug(IntPtr ProcessHandle, IntPtr DebugObjectHandle);

		// Token: 0x060000AA RID: 170
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtSetInformationDebugObject([In] IntPtr DebugObjectHandle, [In] DebugObjectInformationClass DebugObjectInformationClass, [In] IntPtr DebugObjectInformation, [In] int DebugObjectInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000AB RID: 171
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQuerySystemInformation([In] SYSTEM_INFORMATION_CLASS SystemInformationClass, IntPtr SystemInformation, [In] int SystemInformationLength, [Optional] out int ReturnLength);

		// Token: 0x060000AC RID: 172 RVA: 0x5FF10218 File Offset: 0x5FF05018
		public static int PerformChecks()
		{
			int result;
			if (DebugProtect2.CheckDebugPort() == 1)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebugPort: HIT");
				result = 1;
			}
			else if (DebugProtect2.CheckKernelDebugInformation())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckKernelDebugInformation: HIT");
				result = 1;
			}
			else if (DebugProtect2.DetachFromDebuggerProcess())
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("DetachFromDebuggerProcess: HIT");
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x5FF102AC File Offset: 0x5FF050AC
		private static int CheckDebugPort()
		{
			IntPtr intPtr = new IntPtr(0);
			int num;
			NtStatus ntStatus = DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugPort, out intPtr, Marshal.SizeOf<IntPtr>(intPtr), out num);
			int result;
			if (ntStatus == NtStatus.Success && intPtr == new IntPtr(-1))
			{
				Console.WriteLine("DebugPort : {0:X}", intPtr);
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x5FF10340 File Offset: 0x5FF05140
		private unsafe static bool DetachFromDebuggerProcess()
		{
			IntPtr invalid_HANDLE_VALUE = DebugProtect2.INVALID_HANDLE_VALUE;
			uint structure = 0U;
			int num;
			NtStatus ntStatus = DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugObjectHandle, out invalid_HANDLE_VALUE, IntPtr.Size, out num);
			bool result;
			if (ntStatus > NtStatus.Success)
			{
				result = false;
			}
			else
			{
				int num2;
				ntStatus = DebugProtect2.NtSetInformationDebugObject(invalid_HANDLE_VALUE, DebugObjectInformationClass.DebugObjectFlags, new IntPtr((void*)(&structure)), Marshal.SizeOf<uint>(structure), out num2);
				if (ntStatus > NtStatus.Success)
				{
					result = false;
				}
				else
				{
					ntStatus = DebugProtect2.NtRemoveProcessDebug(Process.GetCurrentProcess().Handle, invalid_HANDLE_VALUE);
					if (ntStatus > NtStatus.Success)
					{
						result = false;
					}
					else
					{
						ntStatus = DebugProtect2.NtClose(invalid_HANDLE_VALUE);
						result = (ntStatus <= NtStatus.Success);
					}
				}
			}
			return result;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x5FF10444 File Offset: 0x5FF05244
		private unsafe static bool CheckKernelDebugInformation()
		{
			SYSTEM_KERNEL_DEBUGGER_INFORMATION system_KERNEL_DEBUGGER_INFORMATION;
			int num;
			NtStatus ntStatus = DebugProtect2.NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS.SystemKernelDebuggerInformation, new IntPtr((void*)(&system_KERNEL_DEBUGGER_INFORMATION)), Marshal.SizeOf<SYSTEM_KERNEL_DEBUGGER_INFORMATION>(system_KERNEL_DEBUGGER_INFORMATION), out num);
			return ntStatus == NtStatus.Success && (system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerEnabled && !system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerNotPresent);
		}

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
	}
}
