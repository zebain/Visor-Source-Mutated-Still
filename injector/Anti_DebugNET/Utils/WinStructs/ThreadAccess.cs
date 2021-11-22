using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000012 RID: 18
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x040002DA RID: 730
		TERMINATE = 1,
		// Token: 0x040002DB RID: 731
		SUSPEND_RESUME = 2,
		// Token: 0x040002DC RID: 732
		GET_CONTEXT = 8,
		// Token: 0x040002DD RID: 733
		SET_CONTEXT = 16,
		// Token: 0x040002DE RID: 734
		SET_INFORMATION = 32,
		// Token: 0x040002DF RID: 735
		QUERY_INFORMATION = 64,
		// Token: 0x040002E0 RID: 736
		SET_THREAD_TOKEN = 128,
		// Token: 0x040002E1 RID: 737
		IMPERSONATE = 256,
		// Token: 0x040002E2 RID: 738
		DIRECT_IMPERSONATION = 512
	}
}
