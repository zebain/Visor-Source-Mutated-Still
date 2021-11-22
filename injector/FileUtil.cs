using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

// Token: 0x02000002 RID: 2
public static class FileUtil
{
	// Token: 0x06000002 RID: 2
	[DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
	private static extern int RmRegisterResources(uint pSessionHandle, uint nFiles, string[] rgsFilenames, uint nApplications, [In] FileUtil.RM_UNIQUE_PROCESS[] rgApplications, uint nServices, string[] rgsServiceNames);

	// Token: 0x06000003 RID: 3
	[DllImport("rstrtmgr.dll", CharSet = CharSet.Auto)]
	private static extern int RmStartSession(out uint pSessionHandle, int dwSessionFlags, string strSessionKey);

	// Token: 0x06000004 RID: 4
	[DllImport("rstrtmgr.dll")]
	private static extern int RmEndSession(uint pSessionHandle);

	// Token: 0x06000005 RID: 5
	[DllImport("rstrtmgr.dll")]
	private static extern int RmGetList(uint dwSessionHandle, out uint pnProcInfoNeeded, ref uint pnProcInfo, [In] [Out] FileUtil.RM_PROCESS_INFO[] rgAffectedApps, ref uint lpdwRebootReasons);

	// Token: 0x06000006 RID: 6 RVA: 0x5FF0AB20 File Offset: 0x5FEFF920
	public static List<Process> WhoIsLocking(string path)
	{
		string strSessionKey = Guid.NewGuid().ToString();
		List<Process> list = new List<Process>();
		uint num2;
		int num = FileUtil.RmStartSession(out num2, 0, strSessionKey);
		if (num != 0)
		{
			throw new Exception("Could not begin restart session.  Unable to determine file locker.");
		}
		try
		{
			uint num3 = 0U;
			uint num4 = 0U;
			uint num5 = 0U;
			string[] array = new string[]
			{
				path
			};
			num = FileUtil.RmRegisterResources(num2, (uint)array.Length, array, 0U, null, 0U, null);
			if (num != 0)
			{
				throw new Exception("Could not register resource.");
			}
			num = FileUtil.RmGetList(num2, out num3, ref num4, null, ref num5);
			if (num == 234)
			{
				FileUtil.RM_PROCESS_INFO[] array2 = new FileUtil.RM_PROCESS_INFO[num3];
				num4 = num3;
				num = FileUtil.RmGetList(num2, out num3, ref num4, array2, ref num5);
				if (num != 0)
				{
					throw new Exception("Could not list processes locking resource.");
				}
				list = new List<Process>((int)num4);
				int num6 = 0;
				while ((long)num6 < (long)((ulong)num4))
				{
					try
					{
						list.Add(Process.GetProcessById(array2[num6].Process.dwProcessId));
					}
					catch (ArgumentException)
					{
					}
					num6++;
				}
			}
			else if (num != 0)
			{
				throw new Exception("Could not list processes locking resource. Failed to get size of result.");
			}
		}
		finally
		{
			FileUtil.RmEndSession(num2);
		}
		return list;
	}

	// Token: 0x04000001 RID: 1
	private const int RmRebootReasonNone = 0;

	// Token: 0x04000002 RID: 2
	private const int CCH_RM_MAX_APP_NAME = 255;

	// Token: 0x04000003 RID: 3
	private const int CCH_RM_MAX_SVC_NAME = 63;

	// Token: 0x0200001A RID: 26
	private struct RM_UNIQUE_PROCESS
	{
		// Token: 0x040002EF RID: 751
		public int dwProcessId;

		// Token: 0x040002F0 RID: 752
		public System.Runtime.InteropServices.ComTypes.FILETIME ProcessStartTime;
	}

	// Token: 0x0200001B RID: 27
	private enum RM_APP_TYPE
	{
		// Token: 0x040002F2 RID: 754
		RmUnknownApp,
		// Token: 0x040002F3 RID: 755
		RmMainWindow,
		// Token: 0x040002F4 RID: 756
		RmOtherWindow,
		// Token: 0x040002F5 RID: 757
		RmService,
		// Token: 0x040002F6 RID: 758
		RmExplorer,
		// Token: 0x040002F7 RID: 759
		RmConsole,
		// Token: 0x040002F8 RID: 760
		RmCritical = 1000
	}

	// Token: 0x0200001C RID: 28
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct RM_PROCESS_INFO
	{
		// Token: 0x040002F9 RID: 761
		public FileUtil.RM_UNIQUE_PROCESS Process;

		// Token: 0x040002FA RID: 762
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string strAppName;

		// Token: 0x040002FB RID: 763
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string strServiceShortName;

		// Token: 0x040002FC RID: 764
		public FileUtil.RM_APP_TYPE ApplicationType;

		// Token: 0x040002FD RID: 765
		public uint AppStatus;

		// Token: 0x040002FE RID: 766
		public uint TSSessionId;

		// Token: 0x040002FF RID: 767
		[MarshalAs(UnmanagedType.Bool)]
		public bool bRestartable;
	}
}
