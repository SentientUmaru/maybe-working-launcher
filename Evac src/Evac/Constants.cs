using System;
using System.Linq;
using System.Security.Principal;

namespace Evaccheats
{
	// Token: 0x02000004 RID: 4
	internal class Constants
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002E02 File Offset: 0x00001002
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002E09 File Offset: 0x00001009
		public static string Token { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002E11 File Offset: 0x00001011
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002E18 File Offset: 0x00001018
		public static string Date { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002E20 File Offset: 0x00001020
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002E27 File Offset: 0x00001027
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002E2F File Offset: 0x0000102F
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002E36 File Offset: 0x00001036
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x06000017 RID: 23 RVA: 0x00002E3E File Offset: 0x0000103E
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002E79 File Offset: 0x00001079
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x04000015 RID: 21
		public static bool Breached = false;

		// Token: 0x04000016 RID: 22
		public static bool Started = false;

		// Token: 0x04000017 RID: 23
		public static string IV = null;

		// Token: 0x04000018 RID: 24
		public static string Key = null;

		// Token: 0x04000019 RID: 25
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x0400001A RID: 26
		public static bool Initialized = false;

		// Token: 0x0400001B RID: 27
		public static Random random = new Random();
	}
}
