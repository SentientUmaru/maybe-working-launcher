using System;

namespace Evaccheats
{
	// Token: 0x02000006 RID: 6
	internal class ApplicationSettings
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002F73 File Offset: 0x00001173
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002F7A File Offset: 0x0000117A
		public static bool Status { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002F82 File Offset: 0x00001182
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002F89 File Offset: 0x00001189
		public static bool DeveloperMode { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002F91 File Offset: 0x00001191
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002F98 File Offset: 0x00001198
		public static string Hash { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002FA7 File Offset: 0x000011A7
		public static string Version { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002FAF File Offset: 0x000011AF
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002FB6 File Offset: 0x000011B6
		public static string Update_Link { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002FBE File Offset: 0x000011BE
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002FC5 File Offset: 0x000011C5
		public static bool Freemode { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002FCD File Offset: 0x000011CD
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002FD4 File Offset: 0x000011D4
		public static bool Login { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002FDC File Offset: 0x000011DC
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002FE3 File Offset: 0x000011E3
		public static string Name { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002FEB File Offset: 0x000011EB
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002FF2 File Offset: 0x000011F2
		public static bool Register { get; set; }
	}
}
