using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Evaccheats.Properties
{
	// Token: 0x02000011 RID: 17
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00009961 File Offset: 0x00007B61
		internal Resources()
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00009969 File Offset: 0x00007B69
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("Evaccheats.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00009995 File Offset: 0x00007B95
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000999C File Offset: 0x00007B9C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000099A4 File Offset: 0x00007BA4
		internal static Bitmap Account
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Account", Resources.resourceCulture);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000099BF File Offset: 0x00007BBF
		internal static Bitmap Comp_1
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Comp 1", Resources.resourceCulture);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000099DA File Offset: 0x00007BDA
		internal static Bitmap Comp_11
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Comp 11", Resources.resourceCulture);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000099F5 File Offset: 0x00007BF5
		internal static Bitmap Purchase
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("Purchase", Resources.resourceCulture);
			}
		}

		// Token: 0x0400007D RID: 125
		private static ResourceManager resourceMan;

		// Token: 0x0400007E RID: 126
		private static CultureInfo resourceCulture;
	}
}
