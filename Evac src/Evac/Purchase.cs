using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Evaccheats.Properties;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace Evaccheats
{
	// Token: 0x0200000D RID: 13
	public partial class Purchase : Form
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00006742 File Offset: 0x00004942
		public Purchase()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00006750 File Offset: 0x00004950
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.dropbox.com/s/g5lchzdp1qrjdnn/EC%20Menu.rar?dl=1");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000675D File Offset: 0x0000495D
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/RRShfTxgbr");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000676A File Offset: 0x0000496A
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.com/invite/Zyff6z4Db9");
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00006777 File Offset: 0x00004977
		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000677E File Offset: 0x0000497E
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00006780 File Offset: 0x00004980
		private void button9_Click(object sender, EventArgs e)
		{
			new Home().Show();
			base.Hide();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00006792 File Offset: 0x00004992
		private void button8_Click(object sender, EventArgs e)
		{
			new ip().Show();
			base.Hide();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000067A4 File Offset: 0x000049A4
		private void usernamee_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000067A6 File Offset: 0x000049A6
		private void button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000067A8 File Offset: 0x000049A8
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000067AA File Offset: 0x000049AA
		private void Purchase_Load(object sender, EventArgs e)
		{
			this.usernameee.Text = (User.Username ?? "");
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000067C5 File Offset: 0x000049C5
		private void Usrname_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000067C7 File Offset: 0x000049C7
		private void usernameee_Click(object sender, EventArgs e)
		{
			new ip().Show();
			base.Hide();
		}
	}
}
