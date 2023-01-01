namespace Evaccheats
{
	// Token: 0x02000002 RID: 2
	public partial class ip : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002136 File Offset: 0x00000336
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002158 File Offset: 0x00000358
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Evaccheats.ip));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button6 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.username = new global::System.Windows.Forms.Label();
			this.usernamee = new global::System.Windows.Forms.Label();
			this.email = new global::System.Windows.Forms.Label();
			this.hwid = new global::System.Windows.Forms.Label();
			this.ipp = new global::System.Windows.Forms.Label();
			this.lastlogin = new global::System.Windows.Forms.Label();
			this.siticoneControlBox3 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox4 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new global::System.Drawing.Point(52, 245);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(208, 251);
			this.panel1.TabIndex = 43;
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.button6.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button6.ForeColor = global::System.Drawing.Color.DimGray;
			this.button6.Location = new global::System.Drawing.Point(0, 120);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(208, 40);
			this.button6.TabIndex = 46;
			this.button6.Text = "LOGOUT";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.button3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.DimGray;
			this.button3.Location = new global::System.Drawing.Point(0, 80);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(208, 40);
			this.button3.TabIndex = 43;
			this.button3.Text = "PURCHASE";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.button2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(0, 40);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(208, 40);
			this.button2.TabIndex = 42;
			this.button2.Text = "ACCOUNT";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.DimGray;
			this.button1.Location = new global::System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(208, 40);
			this.button1.TabIndex = 41;
			this.button1.Text = "HOME";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.username.AutoSize = true;
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.username.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.Color.White;
			this.username.Location = new global::System.Drawing.Point(456, 477);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(50, 19);
			this.username.TabIndex = 44;
			this.username.Text = "label1";
			this.username.Click += new global::System.EventHandler(this.username_Click);
			this.usernamee.AutoSize = true;
			this.usernamee.BackColor = global::System.Drawing.Color.Transparent;
			this.usernamee.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.usernamee.ForeColor = global::System.Drawing.Color.White;
			this.usernamee.Location = new global::System.Drawing.Point(418, 45);
			this.usernamee.Name = "usernamee";
			this.usernamee.Size = new global::System.Drawing.Size(75, 28);
			this.usernamee.TabIndex = 45;
			this.usernamee.Text = "label1";
			this.usernamee.Click += new global::System.EventHandler(this.usernamee_Click);
			this.email.AutoSize = true;
			this.email.BackColor = global::System.Drawing.Color.Transparent;
			this.email.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.email.ForeColor = global::System.Drawing.Color.White;
			this.email.Location = new global::System.Drawing.Point(963, 476);
			this.email.Name = "email";
			this.email.Size = new global::System.Drawing.Size(50, 19);
			this.email.TabIndex = 46;
			this.email.Text = "label1";
			this.hwid.AutoSize = true;
			this.hwid.BackColor = global::System.Drawing.Color.Transparent;
			this.hwid.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hwid.ForeColor = global::System.Drawing.Color.White;
			this.hwid.Location = new global::System.Drawing.Point(456, 603);
			this.hwid.Name = "hwid";
			this.hwid.Size = new global::System.Drawing.Size(50, 19);
			this.hwid.TabIndex = 47;
			this.hwid.Text = "label1";
			this.ipp.AutoSize = true;
			this.ipp.BackColor = global::System.Drawing.Color.Transparent;
			this.ipp.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ipp.ForeColor = global::System.Drawing.Color.White;
			this.ipp.Location = new global::System.Drawing.Point(963, 603);
			this.ipp.Name = "ipp";
			this.ipp.Size = new global::System.Drawing.Size(50, 19);
			this.ipp.TabIndex = 48;
			this.ipp.Text = "label1";
			this.lastlogin.AutoSize = true;
			this.lastlogin.BackColor = global::System.Drawing.Color.Transparent;
			this.lastlogin.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lastlogin.ForeColor = global::System.Drawing.Color.White;
			this.lastlogin.Location = new global::System.Drawing.Point(715, 732);
			this.lastlogin.Name = "lastlogin";
			this.lastlogin.Size = new global::System.Drawing.Size(66, 19);
			this.lastlogin.TabIndex = 49;
			this.lastlogin.Text = "lastlogin";
			this.siticoneControlBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox3.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneControlBox3.BorderRadius = 10;
			this.siticoneControlBox3.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneControlBox3.FillColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneControlBox3.HoveredState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox3.Location = new global::System.Drawing.Point(1418, 12);
			this.siticoneControlBox3.Name = "siticoneControlBox3";
			this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
			this.siticoneControlBox3.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox3.TabIndex = 50;
			this.siticoneControlBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox4.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneControlBox4.BorderRadius = 10;
			this.siticoneControlBox4.FillColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneControlBox4.HoveredState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox4.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox4.HoveredState.Parent = this.siticoneControlBox4;
			this.siticoneControlBox4.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox4.Location = new global::System.Drawing.Point(1469, 12);
			this.siticoneControlBox4.Name = "siticoneControlBox4";
			this.siticoneControlBox4.ShadowDecoration.Parent = this.siticoneControlBox4;
			this.siticoneControlBox4.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox4.TabIndex = 51;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Evaccheats.Properties.Resources.Account;
			base.ClientSize = new global::System.Drawing.Size(1530, 866);
			base.Controls.Add(this.siticoneControlBox4);
			base.Controls.Add(this.siticoneControlBox3);
			base.Controls.Add(this.lastlogin);
			base.Controls.Add(this.ipp);
			base.Controls.Add(this.hwid);
			base.Controls.Add(this.email);
			base.Controls.Add(this.usernamee);
			base.Controls.Add(this.username);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "ip";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Evac | Account";
			base.Load += new global::System.EventHandler(this.Account_Load);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label username;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label usernamee;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label email;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label hwid;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label ipp;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label lastlogin;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button button6;

		// Token: 0x0400000D RID: 13
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;

		// Token: 0x0400000E RID: 14
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox4;
	}
}
