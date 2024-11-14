namespace Parfüm2025
{
    partial class frmMitarbeiterListe
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMitarbeiter = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterwert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnAddnewMitarbeiter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.cmsMitarbeiter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seheMitarbeiterDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualisiereMitarbeiterdatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entferneMitarbeiterdatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktiviereMitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktiviereMitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsMitarbeiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMitarbeiter
            // 
            this.dgvMitarbeiter.AllowUserToAddRows = false;
            this.dgvMitarbeiter.AllowUserToDeleteRows = false;
            this.dgvMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMitarbeiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMitarbeiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMitarbeiter.ContextMenuStrip = this.cmsMitarbeiter;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMitarbeiter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMitarbeiter.Location = new System.Drawing.Point(12, 326);
            this.dgvMitarbeiter.MultiSelect = false;
            this.dgvMitarbeiter.Name = "dgvMitarbeiter";
            this.dgvMitarbeiter.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMitarbeiter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMitarbeiter.RowTemplate.Height = 50;
            this.dgvMitarbeiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMitarbeiter.Size = new System.Drawing.Size(1533, 453);
            this.dgvMitarbeiter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter bei:";
            // 
            // txtFilterwert
            // 
            this.txtFilterwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterwert.Location = new System.Drawing.Point(298, 290);
            this.txtFilterwert.Name = "txtFilterwert";
            this.txtFilterwert.Size = new System.Drawing.Size(585, 29);
            this.txtFilterwert.TabIndex = 4;
            this.txtFilterwert.TextChanged += new System.EventHandler(this.txtFilterwert_TextChanged);
            this.txtFilterwert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterwert_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 794);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(90, 794);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 6;
            this.lblRecord.Text = "###";
            // 
            // btnAddnewMitarbeiter
            // 
            this.btnAddnewMitarbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnewMitarbeiter.BackColor = System.Drawing.Color.Gold;
            this.btnAddnewMitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewMitarbeiter.Image = global::Parfüm2025.Properties.Resources.new_employee_13271134;
            this.btnAddnewMitarbeiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewMitarbeiter.Location = new System.Drawing.Point(1193, 282);
            this.btnAddnewMitarbeiter.Name = "btnAddnewMitarbeiter";
            this.btnAddnewMitarbeiter.Size = new System.Drawing.Size(352, 37);
            this.btnAddnewMitarbeiter.TabIndex = 7;
            this.btnAddnewMitarbeiter.Text = "Neuen Mitarbeiter hinzufügen";
            this.btnAddnewMitarbeiter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddnewMitarbeiter.UseVisualStyleBackColor = false;
            this.btnAddnewMitarbeiter.Click += new System.EventHandler(this.btnAddnewMitarbeiter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources.Vorderseite;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1557, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "Vollname",
            "MitarbeiterID"});
            this.cbFilterBei.Location = new System.Drawing.Point(103, 290);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(189, 28);
            this.cbFilterBei.TabIndex = 8;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // cmsMitarbeiter
            // 
            this.cmsMitarbeiter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seheMitarbeiterDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aktualisiereMitarbeiterdatenToolStripMenuItem,
            this.entferneMitarbeiterdatenToolStripMenuItem,
            this.toolStripSeparator2,
            this.deaktiviereMitarbeiterToolStripMenuItem,
            this.aktiviereMitarbeiterToolStripMenuItem});
            this.cmsMitarbeiter.Name = "cmsMitarbeiter";
            this.cmsMitarbeiter.Size = new System.Drawing.Size(295, 206);
            // 
            // seheMitarbeiterDetailsToolStripMenuItem
            // 
            this.seheMitarbeiterDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seheMitarbeiterDetailsToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.details_32;
            this.seheMitarbeiterDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seheMitarbeiterDetailsToolStripMenuItem.Name = "seheMitarbeiterDetailsToolStripMenuItem";
            this.seheMitarbeiterDetailsToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.seheMitarbeiterDetailsToolStripMenuItem.Text = "Sehe Mitarbeiter Details ";
            this.seheMitarbeiterDetailsToolStripMenuItem.Click += new System.EventHandler(this.seheMitarbeiterDetailsToolStripMenuItem_Click);
            // 
            // aktualisiereMitarbeiterdatenToolStripMenuItem
            // 
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.refresh_5791276;
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Name = "aktualisiereMitarbeiterdatenToolStripMenuItem";
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Text = "Aktualisiere Mitarbeiterdaten";
            this.aktualisiereMitarbeiterdatenToolStripMenuItem.Click += new System.EventHandler(this.aktualisiereMitarbeiterdatenToolStripMenuItem_Click);
            // 
            // entferneMitarbeiterdatenToolStripMenuItem
            // 
            this.entferneMitarbeiterdatenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entferneMitarbeiterdatenToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.delete_5953478__1_;
            this.entferneMitarbeiterdatenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entferneMitarbeiterdatenToolStripMenuItem.Name = "entferneMitarbeiterdatenToolStripMenuItem";
            this.entferneMitarbeiterdatenToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.entferneMitarbeiterdatenToolStripMenuItem.Text = "Entferne Mitarbeiterdaten";
            this.entferneMitarbeiterdatenToolStripMenuItem.Click += new System.EventHandler(this.entferneMitarbeiterdatenToolStripMenuItem_Click);
            // 
            // deaktiviereMitarbeiterToolStripMenuItem
            // 
            this.deaktiviereMitarbeiterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deaktiviereMitarbeiterToolStripMenuItem.Name = "deaktiviereMitarbeiterToolStripMenuItem";
            this.deaktiviereMitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.deaktiviereMitarbeiterToolStripMenuItem.Text = "Deaktiviere Mitarbeiter";
            this.deaktiviereMitarbeiterToolStripMenuItem.Click += new System.EventHandler(this.deaktiviereMitarbeiterToolStripMenuItem_Click);
            // 
            // aktiviereMitarbeiterToolStripMenuItem
            // 
            this.aktiviereMitarbeiterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktiviereMitarbeiterToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.tester_4157277;
            this.aktiviereMitarbeiterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktiviereMitarbeiterToolStripMenuItem.Name = "aktiviereMitarbeiterToolStripMenuItem";
            this.aktiviereMitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(294, 38);
            this.aktiviereMitarbeiterToolStripMenuItem.Text = "Aktiviere Mitarbeiter";
            this.aktiviereMitarbeiterToolStripMenuItem.Click += new System.EventHandler(this.aktiviereMitarbeiterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // frmMitarbeiterListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 823);
            this.Controls.Add(this.cbFilterBei);
            this.Controls.Add(this.btnAddnewMitarbeiter);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterwert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMitarbeiter);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMitarbeiterListe";
            this.Text = "frmMitarbeiterListe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMitarbeiterListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMitarbeiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsMitarbeiter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvMitarbeiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterwert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnAddnewMitarbeiter;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.ContextMenuStrip cmsMitarbeiter;
        private System.Windows.Forms.ToolStripMenuItem seheMitarbeiterDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aktualisiereMitarbeiterdatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entferneMitarbeiterdatenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deaktiviereMitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktiviereMitarbeiterToolStripMenuItem;
    }
}