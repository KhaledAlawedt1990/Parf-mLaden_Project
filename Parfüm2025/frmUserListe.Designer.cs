﻿namespace Parfüm2025
{
    partial class frmUserListe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.cmsUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SeheBenutzerDetailstoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualisiereBenutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entferneBenutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktiviereBenutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktiviereBenutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.cmsUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1341, 270);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dein Duft - Deine Geschichte";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alowidat Parfüm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(84, 671);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 16;
            this.lblRecord.Text = "###";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 671);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Record:";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.ContextMenuStrip = this.cmsUser;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUser.Location = new System.Drawing.Point(12, 288);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUser.RowHeadersWidth = 60;
            this.dgvUser.RowTemplate.Height = 30;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(1345, 367);
            this.dgvUser.TabIndex = 12;
            // 
            // cmsUser
            // 
            this.cmsUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SeheBenutzerDetailstoolStripMenuItem1,
            this.aktualisiereBenutzerToolStripMenuItem,
            this.entferneBenutzerToolStripMenuItem,
            this.deaktiviereBenutzerToolStripMenuItem,
            this.aktiviereBenutzerToolStripMenuItem});
            this.cmsUser.Name = "cmsUser";
            this.cmsUser.Size = new System.Drawing.Size(247, 194);
            // 
            // SeheBenutzerDetailstoolStripMenuItem1
            // 
            this.SeheBenutzerDetailstoolStripMenuItem1.Image = global::Parfüm2025.Properties.Resources.PersonDetails_321;
            this.SeheBenutzerDetailstoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SeheBenutzerDetailstoolStripMenuItem1.Name = "SeheBenutzerDetailstoolStripMenuItem1";
            this.SeheBenutzerDetailstoolStripMenuItem1.Size = new System.Drawing.Size(246, 38);
            this.SeheBenutzerDetailstoolStripMenuItem1.Text = "Sehe Benutzer Details";
            this.SeheBenutzerDetailstoolStripMenuItem1.Click += new System.EventHandler(this.SeheBenutzerDetailstoolStripMenuItem1_Click);
            // 
            // aktualisiereBenutzerToolStripMenuItem
            // 
            this.aktualisiereBenutzerToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.recycle_171638182;
            this.aktualisiereBenutzerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktualisiereBenutzerToolStripMenuItem.Name = "aktualisiereBenutzerToolStripMenuItem";
            this.aktualisiereBenutzerToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.aktualisiereBenutzerToolStripMenuItem.Text = "Aktualisiere Benutzer";
            this.aktualisiereBenutzerToolStripMenuItem.Click += new System.EventHandler(this.aktualisiereBenutzerToolStripMenuItem_Click);
            // 
            // entferneBenutzerToolStripMenuItem
            // 
            this.entferneBenutzerToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.sign_out_32__23;
            this.entferneBenutzerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entferneBenutzerToolStripMenuItem.Name = "entferneBenutzerToolStripMenuItem";
            this.entferneBenutzerToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.entferneBenutzerToolStripMenuItem.Text = "Entferne Benutzer";
            this.entferneBenutzerToolStripMenuItem.Click += new System.EventHandler(this.entferneBenutzerToolStripMenuItem_Click);
            // 
            // deaktiviereBenutzerToolStripMenuItem
            // 
            this.deaktiviereBenutzerToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.unemployed_97729492;
            this.deaktiviereBenutzerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deaktiviereBenutzerToolStripMenuItem.Name = "deaktiviereBenutzerToolStripMenuItem";
            this.deaktiviereBenutzerToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.deaktiviereBenutzerToolStripMenuItem.Text = "Deaktiviere Benutzer";
            this.deaktiviereBenutzerToolStripMenuItem.Click += new System.EventHandler(this.deaktiviereBenutzerToolStripMenuItem_Click);
            // 
            // aktiviereBenutzerToolStripMenuItem
            // 
            this.aktiviereBenutzerToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.tester_41572772;
            this.aktiviereBenutzerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktiviereBenutzerToolStripMenuItem.Name = "aktiviereBenutzerToolStripMenuItem";
            this.aktiviereBenutzerToolStripMenuItem.Size = new System.Drawing.Size(246, 38);
            this.aktiviereBenutzerToolStripMenuItem.Text = "Aktiviere Benutzer";
            this.aktiviereBenutzerToolStripMenuItem.Click += new System.EventHandler(this.aktiviereBenutzerToolStripMenuItem_Click);
            // 
            // frmUserListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUser);
            this.Name = "frmUserListe";
            this.Text = "frmUserListe";
            this.Load += new System.EventHandler(this.frmUserListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.cmsUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.ContextMenuStrip cmsUser;
        private System.Windows.Forms.ToolStripMenuItem SeheBenutzerDetailstoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aktualisiereBenutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entferneBenutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktiviereBenutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktiviereBenutzerToolStripMenuItem;
    }
}