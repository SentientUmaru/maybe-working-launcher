using System;
using System.Windows.Forms;

namespace Evaccheats
{
	// Token: 0x02000010 RID: 16
	internal static class Program
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00009931 File Offset: 0x00007B31
		[STAThread]
		private static void Main()
		{
			OnProgramStart.Initialize("Evac", "508213", "WYavDB7nv2vqzko0SdpBhYn9FB3VXKmIHwI", "1.0");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
