using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Evaccheats
{
	// Token: 0x0200000E RID: 14
	public partial class Register : Form
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000786F File Offset: 0x00005A6F
		public Register()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000787D File Offset: 0x00005A7D
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
			new Login().Show();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000788F File Offset: 0x00005A8F
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007898 File Offset: 0x00005A98
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			if (API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text))
			{
				base.Hide();
				new Login().Show();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000078E8 File Offset: 0x00005AE8
		private void siticoneImageButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000078EA File Offset: 0x00005AEA
		private void Register_Load(object sender, EventArgs e)
		{
		}
	}
}
