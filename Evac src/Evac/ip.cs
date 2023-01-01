using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Evaccheats.Properties;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Evaccheats
{
	// Token: 0x02000002 RID: 2
	public partial class ip : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public ip()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		private void Account_Load(object sender, EventArgs e)
		{
			this.username.Text = (User.Username ?? "");
			this.usernamee.Text = (User.Username ?? "");
			this.email.Text = (User.Email ?? "");
			this.hwid.Text = (User.HWID ?? "");
			this.ipp.Text = (User.IP ?? "");
			this.lastlogin.Text = (User.LastLogin ?? "");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002103 File Offset: 0x00000303
		private void button1_Click(object sender, EventArgs e)
		{
			new Home().Show();
			base.Hide();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002115 File Offset: 0x00000315
		private void username_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002117 File Offset: 0x00000317
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002119 File Offset: 0x00000319
		private void button3_Click(object sender, EventArgs e)
		{
			new Purchase().Show();
			base.Hide();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000212B File Offset: 0x0000032B
		private void button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000212D File Offset: 0x0000032D
		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002134 File Offset: 0x00000334
		private void usernamee_Click(object sender, EventArgs e)
		{
		}
	}
}
