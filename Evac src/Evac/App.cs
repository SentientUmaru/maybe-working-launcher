using System;
using System.Collections.Generic;

namespace Evaccheats
{
	// Token: 0x02000003 RID: 3
	internal class App
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002D88 File Offset: 0x00000F88
		public static string GrabVariable(string name)
		{
			string result;
			try
			{
				if (User.ID != null || User.HWID != null || User.IP != null || !Constants.Breached)
				{
					result = App.Variables[name];
				}
				else
				{
					Constants.Breached = true;
					result = "User is not logged in, possible breach detected!";
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x0400000F RID: 15
		public static string Error = null;

		// Token: 0x04000010 RID: 16
		public static Dictionary<string, string> Variables = new Dictionary<string, string>();
	}
}
