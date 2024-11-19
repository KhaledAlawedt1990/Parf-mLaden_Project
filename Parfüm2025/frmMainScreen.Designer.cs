namespace Parfüm2025
{
    partial class frmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parfümverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lageverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnungverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parfümverwaltungToolStripMenuItem,
            this.mitarbeiterverwaltungToolStripMenuItem,
            this.userverwaltungToolStripMenuItem,
            this.kundeverwaltungToolStripMenuItem,
            this.lageverwaltungToolStripMenuItem,
            this.rechnungverwaltungToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1643, 100);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1643, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(631, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deine Duft - Deine Geschichte";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(401, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alowidat Parfüm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // parfümverwaltungToolStripMenuItem
            // 
            this.parfümverwaltungToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.parfümverwaltungToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parfümverwaltungToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.perfume_1241933;
            this.parfümverwaltungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parfümverwaltungToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.parfümverwaltungToolStripMenuItem.Name = "parfümverwaltungToolStripMenuItem";
            this.parfümverwaltungToolStripMenuItem.Size = new System.Drawing.Size(247, 96);
            this.parfümverwaltungToolStripMenuItem.Text = "Parfümverwaltung";
            this.parfümverwaltungToolStripMenuItem.Click += new System.EventHandler(this.parfümverwaltungToolStripMenuItem_Click);
            // 
            // mitarbeiterverwaltungToolStripMenuItem
            // 
            this.mitarbeiterverwaltungToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.mitarbeiterverwaltungToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitarbeiterverwaltungToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.users_643;
            this.mitarbeiterverwaltungToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mitarbeiterverwaltungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mitarbeiterverwaltungToolStripMenuItem.Name = "mitarbeiterverwaltungToolStripMenuItem";
            this.mitarbeiterverwaltungToolStripMenuItem.Size = new System.Drawing.Size(283, 96);
            this.mitarbeiterverwaltungToolStripMenuItem.Text = "Mitarbeiterverwaltung";
            this.mitarbeiterverwaltungToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mitarbeiterverwaltungToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterverwaltungToolStripMenuItem_Click);
            // 
            // userverwaltungToolStripMenuItem
            // 
            this.userverwaltungToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.userverwaltungToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userverwaltungToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.Users_2_643;
            this.userverwaltungToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userverwaltungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userverwaltungToolStripMenuItem.Name = "userverwaltungToolStripMenuItem";
            this.userverwaltungToolStripMenuItem.Size = new System.Drawing.Size(224, 96);
            this.userverwaltungToolStripMenuItem.Text = "Userverwaltung";
            this.userverwaltungToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userverwaltungToolStripMenuItem.Click += new System.EventHandler(this.userverwaltungToolStripMenuItem_Click);
            // 
            // kundeverwaltungToolStripMenuItem
            // 
            this.kundeverwaltungToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.kundeverwaltungToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kundeverwaltungToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.People_642;
            this.kundeverwaltungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kundeverwaltungToolStripMenuItem.Name = "kundeverwaltungToolStripMenuItem";
            this.kundeverwaltungToolStripMenuItem.Size = new System.Drawing.Size(240, 96);
            this.kundeverwaltungToolStripMenuItem.Text = "Kundeverwaltung";
            this.kundeverwaltungToolStripMenuItem.Click += new System.EventHandler(this.kundeverwaltungToolStripMenuItem_Click);
            // 
            // lageverwaltungToolStripMenuItem
            // 
            this.lageverwaltungToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.lageverwaltungToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lageverwaltungToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.store_56226101;
            this.lageverwaltungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lageverwaltungToolStripMenuItem.Name = "lageverwaltungToolStripMenuItem";
            this.lageverwaltungToolStripMenuItem.Size = new System.Drawing.Size(225, 96);
            this.lageverwaltungToolStripMenuItem.Text = "Lageverwaltung";
            // 
            // rechnungverwaltungToolStripMenuItem
            // 
            this.rechnungverwaltungToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.rechnungverwaltungToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechnungverwaltungToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.maths_140528941;
            this.rechnungverwaltungToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rechnungverwaltungToolStripMenuItem.Name = "rechnungverwaltungToolStripMenuItem";
            this.rechnungverwaltungToolStripMenuItem.Size = new System.Drawing.Size(270, 96);
            this.rechnungverwaltungToolStripMenuItem.Text = "Rechnungverwaltung";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.sign_out_32__22;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(147, 96);
            this.logoutToolStripMenuItem.Text = "Ausloggen";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainScreen";
            this.Text = "frmMainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainScreen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainScreen_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parfümverwaltungToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundeverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lageverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechnungverwaltungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}