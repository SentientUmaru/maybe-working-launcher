namespace Evaccheats
{
	// Token: 0x0200000D RID: 13
	public partial class Purchase : global::System.Windows.Forms.Form
	{
		// Token: 0x06000083 RID: 131 RVA: 0x000067D9 File Offset: 0x000049D9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000067F8 File Offset: 0x000049F8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Evaccheats.Purchase));
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.siticoneControlBox3 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.username = new global::System.Windows.Forms.Label();
			this.button6 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button9 = new global::System.Windows.Forms.Button();
			this.siticoneControlBox4 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.usernameee = new global::System.Windows.Forms.Label();
			this.siticoneRoundedTextBox1 = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Arial", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(381, 734);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(177, 34);
			this.button2.TabIndex = 43;
			this.button2.Text = "Join Now";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Arial", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(598, 734);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(177, 34);
			this.button1.TabIndex = 44;
			this.button1.Text = "Join Now";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Arial", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(381, 555);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(177, 34);
			this.button3.TabIndex = 45;
			this.button3.Text = "Download";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.siticoneControlBox3);
			this.panel1.Controls.Add(this.username);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Location = new global::System.Drawing.Point(52, 245);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(208, 248);
			this.panel1.TabIndex = 46;
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
			this.siticoneControlBox3.TabIndex = 48;
			this.username.AutoSize = true;
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.username.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.Color.White;
			this.username.Location = new global::System.Drawing.Point(418, 45);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(75, 28);
			this.username.TabIndex = 47;
			this.username.Text = "label1";
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
			this.button7.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.button7.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button7.ForeColor = global::System.Drawing.Color.White;
			this.button7.Location = new global::System.Drawing.Point(0, 80);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(208, 40);
			this.button7.TabIndex = 43;
			this.button7.Text = "PURCHASE";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button8.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.button8.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button8.ForeColor = global::System.Drawing.Color.DimGray;
			this.button8.Location = new global::System.Drawing.Point(0, 40);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(208, 40);
			this.button8.TabIndex = 42;
			this.button8.Text = "ACCOUNT";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.button9.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 2);
			this.button9.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button9.ForeColor = global::System.Drawing.Color.DimGray;
			this.button9.Location = new global::System.Drawing.Point(0, 0);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(208, 40);
			this.button9.TabIndex = 41;
			this.button9.Text = "HOME";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
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
			this.siticoneControlBox4.TabIndex = 49;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneControlBox1.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(1418, 12);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 51;
			this.usernameee.AutoSize = true;
			this.usernameee.BackColor = global::System.Drawing.Color.Transparent;
			this.usernameee.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.usernameee.ForeColor = global::System.Drawing.Color.White;
			this.usernameee.Location = new global::System.Drawing.Point(418, 45);
			this.usernameee.Name = "usernameee";
			this.usernameee.Size = new global::System.Drawing.Size(75, 28);
			this.usernameee.TabIndex = 52;
			this.usernameee.Text = "label1";
			this.usernameee.Click += new global::System.EventHandler(this.usernameee_Click);
			this.siticoneRoundedTextBox1.AllowDrop = true;
			this.siticoneRoundedTextBox1.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneRoundedTextBox1.BorderColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneRoundedTextBox1.BorderThickness = 0;
			this.siticoneRoundedTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneRoundedTextBox1.DefaultText = "EC-y:J-(JTWF?ytRiv";
			this.siticoneRoundedTextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.siticoneRoundedTextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.siticoneRoundedTextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneRoundedTextBox1.DisabledState.Parent = this.siticoneRoundedTextBox1;
			this.siticoneRoundedTextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.siticoneRoundedTextBox1.FillColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneRoundedTextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneRoundedTextBox1.FocusedState.Parent = this.siticoneRoundedTextBox1;
			this.siticoneRoundedTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedTextBox1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.siticoneRoundedTextBox1.HoveredState.Parent = this.siticoneRoundedTextBox1;
			this.siticoneRoundedTextBox1.Location = new global::System.Drawing.Point(704, 591);
			this.siticoneRoundedTextBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.siticoneRoundedTextBox1.Name = "siticoneRoundedTextBox1";
			this.siticoneRoundedTextBox1.PasswordChar = '\0';
			this.siticoneRoundedTextBox1.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.siticoneRoundedTextBox1.PlaceholderText = "";
			this.siticoneRoundedTextBox1.SelectedText = "";
			this.siticoneRoundedTextBox1.ShadowDecoration.Parent = this.siticoneRoundedTextBox1;
			this.siticoneRoundedTextBox1.Size = new global::System.Drawing.Size(193, 30);
			this.siticoneRoundedTextBox1.TabIndex = 53;
			this.siticoneRoundedTextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.DimGray;
			this.label1.Location = new global::System.Drawing.Point(738, 555);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(119, 28);
			this.label1.TabIndex = 54;
			this.label1.Text = "Password ";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Evaccheats.Properties.Resources.Purchase;
			base.ClientSize = new global::System.Drawing.Size(1530, 866);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneRoundedTextBox1);
			base.Controls.Add(this.usernameee);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.siticoneControlBox4);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Purchase";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Evac | Purchase";
			base.Load += new global::System.EventHandler(this.Purchase_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000054 RID: 84
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Button button6;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Button button7;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.Button button8;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Button button9;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label username;

		// Token: 0x0400005E RID: 94
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;

		// Token: 0x0400005F RID: 95
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox4;

		// Token: 0x04000060 RID: 96
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label usernameee;

		// Token: 0x04000062 RID: 98
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox siticoneRoundedTextBox1;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label1;
	}
}
