using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Evaccheats
{
	// Token: 0x0200000F RID: 15
	public partial class Login : Form
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00008A92 File Offset: 0x00006C92
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008AA0 File Offset: 0x00006CA0
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			base.Hide();
			new Register().Show();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008AB2 File Offset: 0x00006CB2
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008ABA File Offset: 0x00006CBA
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			if (API.Login(this.username.Text, this.password.Text))
			{
				new Home().Show();
				base.Hide();
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00008AE9 File Offset: 0x00006CE9
		private void Login_Load(object sender, EventArgs e)
		{
		}
	}
}
