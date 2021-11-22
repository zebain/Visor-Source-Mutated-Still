using System;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000013 RID: 19
	public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
	{
		// Token: 0x040002E3 RID: 739
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerEnabled;

		// Token: 0x040002E4 RID: 740
		[MarshalAs(UnmanagedType.U1)]
		public bool KernelDebuggerNotPresent;
	}
}
