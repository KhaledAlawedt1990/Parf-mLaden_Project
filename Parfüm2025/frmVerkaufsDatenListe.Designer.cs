namespace Parfüm2025
{
    partial class frmVerkaufsDatenListe
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
            this.txtFilerwert = new System.Windows.Forms.TextBox();
            this.cbFilterbei = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktualisereVerkaufsDaten = new System.Windows.Forms.Button();
            this.btnHinzufügeVerkaufsDaten = new System.Windows.Forms.Button();
            this.dgvVerkaufsDaten = new System.Windows.Forms.DataGridView();
            this.cmsVerkaufdaten = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seheVerkaufToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualisiereVerkaufdatentoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.entferneVerkaufsdatenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerkaufsDaten)).BeginInit();
            this.cmsVerkaufdaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilerwert
            // 
            this.txtFilerwert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilerwert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFilerwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilerwert.Location = new System.Drawing.Point(265, 295);
            this.txtFilerwert.Name = "txtFilerwert";
            this.txtFilerwert.Size = new System.Drawing.Size(777, 26);
            this.txtFilerwert.TabIndex = 13;
            this.txtFilerwert.TextChanged += new System.EventHandler(this.txtFilerwert_TextChanged);
            this.txtFilerwert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilerwert_KeyPress);
            // 
            // cbFilterbei
            // 
            this.cbFilterbei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilterbei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterbei.FormattingEnabled = true;
            this.cbFilterbei.Items.AddRange(new object[] {
            "KundenName",
            "ParfümNummer",
            "BelegID"});
            this.cbFilterbei.Location = new System.Drawing.Point(92, 293);
            this.cbFilterbei.Name = "cbFilterbei";
            this.cbFilterbei.Size = new System.Drawing.Size(163, 28);
            this.cbFilterbei.TabIndex = 12;
            this.cbFilterbei.SelectedIndexChanged += new System.EventHandler(this.cbFilterbei_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filer bei:";
            // 
            // btnAktualisereVerkaufsDaten
            // 
            this.btnAktualisereVerkaufsDaten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAktualisereVerkaufsDaten.BackColor = System.Drawing.Color.White;
            this.btnAktualisereVerkaufsDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktualisereVerkaufsDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisereVerkaufsDaten.ForeColor = System.Drawing.Color.Black;
            this.btnAktualisereVerkaufsDaten.Location = new System.Drawing.Point(1133, 282);
            this.btnAktualisereVerkaufsDaten.Name = "btnAktualisereVerkaufsDaten";
            this.btnAktualisereVerkaufsDaten.Size = new System.Drawing.Size(224, 40);
            this.btnAktualisereVerkaufsDaten.TabIndex = 10;
            this.btnAktualisereVerkaufsDaten.Text = "Aktualisiere VerkaufsDaten";
            this.btnAktualisereVerkaufsDaten.UseVisualStyleBackColor = false;
            this.btnAktualisereVerkaufsDaten.Click += new System.EventHandler(this.btnAktualisereVerkaufsDaten_Click);
            // 
            // btnHinzufügeVerkaufsDaten
            // 
            this.btnHinzufügeVerkaufsDaten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHinzufügeVerkaufsDaten.BackColor = System.Drawing.Color.White;
            this.btnHinzufügeVerkaufsDaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHinzufügeVerkaufsDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinzufügeVerkaufsDaten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHinzufügeVerkaufsDaten.Location = new System.Drawing.Point(1363, 282);
            this.btnHinzufügeVerkaufsDaten.Name = "btnHinzufügeVerkaufsDaten";
            this.btnHinzufügeVerkaufsDaten.Size = new System.Drawing.Size(224, 40);
            this.btnHinzufügeVerkaufsDaten.TabIndex = 9;
            this.btnHinzufügeVerkaufsDaten.Text = "Hinzufüge Verkaufsdaten";
            this.btnHinzufügeVerkaufsDaten.UseVisualStyleBackColor = false;
            this.btnHinzufügeVerkaufsDaten.Click += new System.EventHandler(this.btnHinzufügeVerkaufsDaten_Click);
            // 
            // dgvVerkaufsDaten
            // 
            this.dgvVerkaufsDaten.AllowUserToAddRows = false;
            this.dgvVerkaufsDaten.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.dgvVerkaufsDaten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVerkaufsDaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerkaufsDaten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerkaufsDaten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVerkaufsDaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerkaufsDaten.ContextMenuStrip = this.cmsVerkaufdaten;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerkaufsDaten.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVerkaufsDaten.EnableHeadersVisualStyles = false;
            this.dgvVerkaufsDaten.Location = new System.Drawing.Point(16, 327);
            this.dgvVerkaufsDaten.Name = "dgvVerkaufsDaten";
            this.dgvVerkaufsDaten.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerkaufsDaten.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVerkaufsDaten.RowTemplate.Height = 30;
            this.dgvVerkaufsDaten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerkaufsDaten.Size = new System.Drawing.Size(1575, 463);
            this.dgvVerkaufsDaten.TabIndex = 8;
            // 
            // cmsVerkaufdaten
            // 
            this.cmsVerkaufdaten.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmsVerkaufdaten.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seheVerkaufToolStripMenuItem,
            this.aktualisiereVerkaufdatentoolStripMenuItem2,
            this.entferneVerkaufsdatenToolStripMenuItem});
            this.cmsVerkaufdaten.Name = "cmsVerkaufdaten";
            this.cmsVerkaufdaten.Size = new System.Drawing.Size(278, 118);
            // 
            // seheVerkaufToolStripMenuItem
            // 
            this.seheVerkaufToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seheVerkaufToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.details_323;
            this.seheVerkaufToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seheVerkaufToolStripMenuItem.Name = "seheVerkaufToolStripMenuItem";
            this.seheVerkaufToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.seheVerkaufToolStripMenuItem.Text = "Sehe Verkauf Details";
            this.seheVerkaufToolStripMenuItem.Click += new System.EventHandler(this.seheVerkaufToolStripMenuItem_Click);
            // 
            // aktualisiereVerkaufdatentoolStripMenuItem2
            // 
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Image = global::Parfüm2025.Properties.Resources.refresh_57912761;
            this.aktualisiereVerkaufdatentoolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Name = "aktualisiereVerkaufdatentoolStripMenuItem2";
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Size = new System.Drawing.Size(277, 38);
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Text = "Aktualisiere Verkaufsdaten";
            this.aktualisiereVerkaufdatentoolStripMenuItem2.Click += new System.EventHandler(this.aktualisiereVerkaufdatentoolStripMenuItem2_Click);
            // 
            // entferneVerkaufsdatenToolStripMenuItem
            // 
            this.entferneVerkaufsdatenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entferneVerkaufsdatenToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.delete_5953478__1_1;
            this.entferneVerkaufsdatenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entferneVerkaufsdatenToolStripMenuItem.Name = "entferneVerkaufsdatenToolStripMenuItem";
            this.entferneVerkaufsdatenToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.entferneVerkaufsdatenToolStripMenuItem.Text = "Entferne Verkaufsdaten";
            this.entferneVerkaufsdatenToolStripMenuItem.Click += new System.EventHandler(this.entferneVerkaufsdatenToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 801);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(88, 801);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 20);
            this.lblRecord.TabIndex = 15;
            this.lblRecord.Text = "###";
            this.lblRecord.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources.store_869636;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1575, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // frmVerkaufsDatenListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 830);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilerwert);
            this.Controls.Add(this.cbFilterbei);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualisereVerkaufsDaten);
            this.Controls.Add(this.btnHinzufügeVerkaufsDaten);
            this.Controls.Add(this.dgvVerkaufsDaten);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmVerkaufsDatenListe";
            this.Text = "frmVerkaufsDatenListe";
            this.Load += new System.EventHandler(this.frmVerkaufsDatenListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerkaufsDaten)).EndInit();
            this.cmsVerkaufdaten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilerwert;
        private System.Windows.Forms.ComboBox cbFilterbei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktualisereVerkaufsDaten;
        private System.Windows.Forms.Button btnHinzufügeVerkaufsDaten;
        private System.Windows.Forms.DataGridView dgvVerkaufsDaten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.ContextMenuStrip cmsVerkaufdaten;
        private System.Windows.Forms.ToolStripMenuItem seheVerkaufToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktualisiereVerkaufdatentoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem entferneVerkaufsdatenToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}