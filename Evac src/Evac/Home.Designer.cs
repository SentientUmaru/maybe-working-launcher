namespace Evaccheats
{
	// Token: 0x0200000C RID: 12
	public partial class Home : global::System.Windows.Forms.Form
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00005067 File Offset: 0x00003267
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00005088 File Offset: 0x00003288
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Evaccheats.Home));
			this.username = new global::System.Windows.Forms.Label();
			this.siticoneControlBox3 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox4 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button6 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label18 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.username.AutoSize = true;
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.username.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.Color.White;
			this.username.Location = new global::System.Drawing.Point(418, 45);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(75, 28);
			this.username.TabIndex = 0;
			this.username.Text = "label1";
			this.username.Click += new global::System.EventHandler(this.username_Click);
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
			this.siticoneControlBox3.TabIndex = 39;
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
			this.siticoneControlBox4.TabIndex = 40;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(215, 6, 87);
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(208, 40);
			this.button1.TabIndex = 41;
			this.button1.Text = "HOME";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new global::System.Drawing.Point(52, 245);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(208, 248);
			this.panel1.TabIndex = 42;
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
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.button2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Couture", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.DimGray;
			this.button2.Location = new global::System.Drawing.Point(0, 40);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(208, 40);
			this.button2.TabIndex = 42;
			this.button2.Text = "ACCOUNT";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(396, 401);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(215, 22);
			this.label1.TabIndex = 43;
			this.label1.Text = "Added New Menu Theme";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(396, 445);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(170, 22);
			this.label2.TabIndex = 44;
			this.label2.Text = "Removed Show RID";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(396, 423);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(156, 22);
			this.label3.TabIndex = 45;
			this.label3.Text = "Added Player Info";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(396, 467);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(0, 22);
			this.label4.TabIndex = 46;
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.Transparent;
			this.label6.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(396, 489);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(236, 22);
			this.label6.TabIndex = 48;
			this.label6.Text = "Improved Give All Weapons";
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(396, 511);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(299, 22);
			this.label7.TabIndex = 49;
			this.label7.Text = "Improved Players Give All Weapons";
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(396, 533);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(115, 22);
			this.label8.TabIndex = 50;
			this.label8.Text = "Added Clone";
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(396, 555);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(239, 22);
			this.label9.TabIndex = 51;
			this.label9.Text = "Improved Take All Weapons";
			this.label10.AutoSize = true;
			this.label10.BackColor = global::System.Drawing.Color.Transparent;
			this.label10.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.White;
			this.label10.Location = new global::System.Drawing.Point(396, 577);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(211, 22);
			this.label10.TabIndex = 52;
			this.label10.Text = "Added Ram With Vehicle";
			this.label11.AutoSize = true;
			this.label11.BackColor = global::System.Drawing.Color.Transparent;
			this.label11.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(396, 599);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(146, 22);
			this.label11.TabIndex = 53;
			this.label11.Text = "Added Silent Kill";
			this.label12.AutoSize = true;
			this.label12.BackColor = global::System.Drawing.Color.Transparent;
			this.label12.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.Color.White;
			this.label12.Location = new global::System.Drawing.Point(396, 621);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(217, 22);
			this.label12.TabIndex = 54;
			this.label12.Text = "Added Fix Players Vehicle";
			this.label13.AutoSize = true;
			this.label13.BackColor = global::System.Drawing.Color.Transparent;
			this.label13.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.Color.White;
			this.label13.Location = new global::System.Drawing.Point(396, 643);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(228, 22);
			this.label13.TabIndex = 55;
			this.label13.Text = "Added Max Players Vehicle";
			this.label14.AutoSize = true;
			this.label14.BackColor = global::System.Drawing.Color.Transparent;
			this.label14.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.ForeColor = global::System.Drawing.Color.White;
			this.label14.Location = new global::System.Drawing.Point(396, 665);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(452, 22);
			this.label14.TabIndex = 56;
			this.label14.Text = "Added Protection {Report, Ped, Weather, Attachment}";
			this.label15.AutoSize = true;
			this.label15.BackColor = global::System.Drawing.Color.Transparent;
			this.label15.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.ForeColor = global::System.Drawing.Color.White;
			this.label15.Location = new global::System.Drawing.Point(396, 687);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(151, 22);
			this.label15.TabIndex = 57;
			this.label15.Text = "Added Rapid Fire";
			this.label16.AutoSize = true;
			this.label16.BackColor = global::System.Drawing.Color.Transparent;
			this.label16.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.ForeColor = global::System.Drawing.Color.White;
			this.label16.Location = new global::System.Drawing.Point(396, 709);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(201, 22);
			this.label16.TabIndex = 58;
			this.label16.Text = "Added Vehicle Spawner";
			this.label17.AutoSize = true;
			this.label17.BackColor = global::System.Drawing.Color.Transparent;
			this.label17.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.ForeColor = global::System.Drawing.Color.White;
			this.label17.Location = new global::System.Drawing.Point(396, 731);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(236, 22);
			this.label17.TabIndex = 59;
			this.label17.Text = "Added Top Speed Multipler";
			this.label18.AutoSize = true;
			this.label18.BackColor = global::System.Drawing.Color.Transparent;
			this.label18.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.Color.White;
			this.label18.Location = new global::System.Drawing.Point(396, 753);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(1078, 22);
			this.label18.TabIndex = 60;
			this.label18.Text = "Added Recovery {Character Level 1-8000, Clear Reports, Clear Badsports, Custom Vehicle Sell Value, 25M,60M Vehicle Sell, Unlocks}";
			this.label19.AutoSize = true;
			this.label19.BackColor = global::System.Drawing.Color.Transparent;
			this.label19.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.ForeColor = global::System.Drawing.Color.White;
			this.label19.Location = new global::System.Drawing.Point(396, 775);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(203, 22);
			this.label19.TabIndex = 61;
			this.label19.Text = "Added Custom Headers";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(396, 467);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(270, 22);
			this.label5.TabIndex = 47;
			this.label5.Text = "Improved Money Delay To 1500";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			base.ClientSize = new global::System.Drawing.Size(1530, 866);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.label18);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.siticoneControlBox4);
			base.Controls.Add(this.siticoneControlBox3);
			base.Controls.Add(this.username);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Home";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Load += new global::System.EventHandler(this.Home_Load);
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000038 RID: 56
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label username;

		// Token: 0x0400003A RID: 58
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;

		// Token: 0x0400003B RID: 59
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox4;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label14;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label15;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label16;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label17;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label label5;
	}
}
