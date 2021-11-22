using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000011 RID: 17
	public enum ThreadInformationClass
	{
		// Token: 0x040002B2 RID: 690
		ThreadBasicInformation,
		// Token: 0x040002B3 RID: 691
		ThreadTimes,
		// Token: 0x040002B4 RID: 692
		ThreadPriority,
		// Token: 0x040002B5 RID: 693
		ThreadBasePriority,
		// Token: 0x040002B6 RID: 694
		ThreadAffinityMask,
		// Token: 0x040002B7 RID: 695
		ThreadImpersonationToken,
		// Token: 0x040002B8 RID: 696
		ThreadDescriptorTableEntry,
		// Token: 0x040002B9 RID: 697
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x040002BA RID: 698
		ThreadEventPair_Reusable,
		// Token: 0x040002BB RID: 699
		ThreadQuerySetWin32StartAddress,
		// Token: 0x040002BC RID: 700
		ThreadZeroTlsCell,
		// Token: 0x040002BD RID: 701
		ThreadPerformanceCount,
		// Token: 0x040002BE RID: 702
		ThreadAmILastThread,
		// Token: 0x040002BF RID: 703
		ThreadIdealProcessor,
		// Token: 0x040002C0 RID: 704
		ThreadPriorityBoost,
		// Token: 0x040002C1 RID: 705
		ThreadSetTlsArrayAddress,
		// Token: 0x040002C2 RID: 706
		ThreadIsIoPending,
		// Token: 0x040002C3 RID: 707
		ThreadHideFromDebugger,
		// Token: 0x040002C4 RID: 708
		ThreadBreakOnTermination,
		// Token: 0x040002C5 RID: 709
		ThreadSwitchLegacyState,
		// Token: 0x040002C6 RID: 710
		ThreadIsTerminated,
		// Token: 0x040002C7 RID: 711
		ThreadLastSystemCall,
		// Token: 0x040002C8 RID: 712
		ThreadIoPriority,
		// Token: 0x040002C9 RID: 713
		ThreadCycleTime,
		// Token: 0x040002CA RID: 714
		ThreadPagePriority,
		// Token: 0x040002CB RID: 715
		ThreadActualBasePriority,
		// Token: 0x040002CC RID: 716
		ThreadTebInformation,
		// Token: 0x040002CD RID: 717
		ThreadCSwitchMon,
		// Token: 0x040002CE RID: 718
		ThreadCSwitchPmu,
		// Token: 0x040002CF RID: 719
		ThreadWow64Context,
		// Token: 0x040002D0 RID: 720
		ThreadGroupInformation,
		// Token: 0x040002D1 RID: 721
		ThreadUmsInformation,
		// Token: 0x040002D2 RID: 722
		ThreadCounterProfiling,
		// Token: 0x040002D3 RID: 723
		ThreadIdealProcessorEx,
		// Token: 0x040002D4 RID: 724
		ThreadCpuAccountingInformation,
		// Token: 0x040002D5 RID: 725
		ThreadSuspendCount,
		// Token: 0x040002D6 RID: 726
		ThreadDescription = 38,
		// Token: 0x040002D7 RID: 727
		ThreadActualGroupAffinity = 41,
		// Token: 0x040002D8 RID: 728
		ThreadDynamicCodePolicy
	}
}
