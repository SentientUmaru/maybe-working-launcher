using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Evaccheats
{
	// Token: 0x0200000C RID: 12
	public partial class Home : Form
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00004FF7 File Offset: 0x000031F7
		public Home()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005005 File Offset: 0x00003205
		private void Home_Load(object sender, EventArgs e)
		{
			this.username.Text = (User.Username ?? "");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005020 File Offset: 0x00003220
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005022 File Offset: 0x00003222
		private void process1_Exited(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005024 File Offset: 0x00003224
		private void button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005026 File Offset: 0x00003226
		private void button2_Click(object sender, EventArgs e)
		{
			new ip().Show();
			base.Hide();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005038 File Offset: 0x00003238
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000503A File Offset: 0x0000323A
		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005041 File Offset: 0x00003241
		private void button3_Click(object sender, EventArgs e)
		{
			new Purchase().Show();
			base.Hide();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00005053 File Offset: 0x00003253
		private void username_Click(object sender, EventArgs e)
		{
			new ip().Show();
			base.Hide();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005065 File Offset: 0x00003265
		private void button4_Click(object sender, EventArgs e)
		{
		}
	}
}
