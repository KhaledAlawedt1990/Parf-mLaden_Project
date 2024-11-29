namespace Parfüm2025
{
    partial class frmEinkaufsDatenListe
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
            this.dgvLager = new System.Windows.Forms.DataGridView();
            this.cmsLager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seheVerkaufsDetailstoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualisiereParfümMengeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entferneParfümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHinzufügeNeueMenge = new System.Windows.Forms.Button();
            this.btnAktualisereParfümMenge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterbei = new System.Windows.Forms.ComboBox();
            this.txtFilerwert = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLager)).BeginInit();
            this.cmsLager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLager
            // 
            this.dgvLager.AllowUserToAddRows = false;
            this.dgvLager.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.dgvLager.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLager.ContextMenuStrip = this.cmsLager;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLager.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLager.EnableHeadersVisualStyles = false;
            this.dgvLager.Location = new System.Drawing.Point(24, 319);
            this.dgvLager.Name = "dgvLager";
            this.dgvLager.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLager.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLager.RowTemplate.Height = 30;
            this.dgvLager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLager.Size = new System.Drawing.Size(1309, 322);
            this.dgvLager.TabIndex = 1;
            // 
            // cmsLager
            // 
            this.cmsLager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seheVerkaufsDetailstoolStripMenuItem1,
            this.aktualisiereParfümMengeToolStripMenuItem,
            this.entferneParfümToolStripMenuItem});
            this.cmsLager.Name = "cmsLager";
            this.cmsLager.Size = new System.Drawing.Size(276, 118);
            // 
            // seheVerkaufsDetailstoolStripMenuItem1
            // 
            this.seheVerkaufsDetailstoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seheVerkaufsDetailstoolStripMenuItem1.Image = global::Parfüm2025.Properties.Resources.details_322;
            this.seheVerkaufsDetailstoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seheVerkaufsDetailstoolStripMenuItem1.Name = "seheVerkaufsDetailstoolStripMenuItem1";
            this.seheVerkaufsDetailstoolStripMenuItem1.Size = new System.Drawing.Size(275, 38);
            this.seheVerkaufsDetailstoolStripMenuItem1.Text = "Sehe Verkauf Details";
            // 
            // aktualisiereParfümMengeToolStripMenuItem
            // 
            this.aktualisiereParfümMengeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktualisiereParfümMengeToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.update_7411697;
            this.aktualisiereParfümMengeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aktualisiereParfümMengeToolStripMenuItem.Name = "aktualisiereParfümMengeToolStripMenuItem";
            this.aktualisiereParfümMengeToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.aktualisiereParfümMengeToolStripMenuItem.Text = "Aktualisiere Einkaufsdaten";
            this.aktualisiereParfümMengeToolStripMenuItem.Click += new System.EventHandler(this.aktualisiereParfümMengeToolStripMenuItem_Click);
            // 
            // entferneParfümToolStripMenuItem
            // 
            this.entferneParfümToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entferneParfümToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.delete_5953478__1_;
            this.entferneParfümToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entferneParfümToolStripMenuItem.Name = "entferneParfümToolStripMenuItem";
            this.entferneParfümToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.entferneParfümToolStripMenuItem.Text = "Entferne Einkaufsdaten";
            this.entferneParfümToolStripMenuItem.Click += new System.EventHandler(this.entferneParfümToolStripMenuItem_Click);
            // 
            // btnHinzufügeNeueMenge
            // 
            this.btnHinzufügeNeueMenge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHinzufügeNeueMenge.BackColor = System.Drawing.Color.White;
            this.btnHinzufügeNeueMenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHinzufügeNeueMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinzufügeNeueMenge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHinzufügeNeueMenge.Location = new System.Drawing.Point(1109, 274);
            this.btnHinzufügeNeueMenge.Name = "btnHinzufügeNeueMenge";
            this.btnHinzufügeNeueMenge.Size = new System.Drawing.Size(224, 40);
            this.btnHinzufügeNeueMenge.TabIndex = 2;
            this.btnHinzufügeNeueMenge.Text = "Hinzufüge Einkaufsdaten";
            this.btnHinzufügeNeueMenge.UseVisualStyleBackColor = false;
            this.btnHinzufügeNeueMenge.Click += new System.EventHandler(this.btnHinzufügeNeueMenge_Click);
            // 
            // btnAktualisereParfümMenge
            // 
            this.btnAktualisereParfümMenge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAktualisereParfümMenge.BackColor = System.Drawing.Color.White;
            this.btnAktualisereParfümMenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktualisereParfümMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAktualisereParfümMenge.ForeColor = System.Drawing.Color.Black;
            this.btnAktualisereParfümMenge.Location = new System.Drawing.Point(879, 274);
            this.btnAktualisereParfümMenge.Name = "btnAktualisereParfümMenge";
            this.btnAktualisereParfümMenge.Size = new System.Drawing.Size(224, 40);
            this.btnAktualisereParfümMenge.TabIndex = 3;
            this.btnAktualisereParfümMenge.Text = "Aktualisiere Einkaufsdaten";
            this.btnAktualisereParfümMenge.UseVisualStyleBackColor = false;
            this.btnAktualisereParfümMenge.Click += new System.EventHandler(this.btnAktualisereParfümMenge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter bei:";
            // 
            // cbFilterbei
            // 
            this.cbFilterbei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbFilterbei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterbei.FormattingEnabled = true;
            this.cbFilterbei.Items.AddRange(new object[] {
            "ParfümName",
            "ParfümNummer"});
            this.cbFilterbei.Location = new System.Drawing.Point(104, 285);
            this.cbFilterbei.Name = "cbFilterbei";
            this.cbFilterbei.Size = new System.Drawing.Size(189, 28);
            this.cbFilterbei.TabIndex = 5;
            this.cbFilterbei.SelectedIndexChanged += new System.EventHandler(this.cbFilterbei_SelectedIndexChanged);
            // 
            // txtFilerwert
            // 
            this.txtFilerwert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilerwert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFilerwert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilerwert.Location = new System.Drawing.Point(299, 285);
            this.txtFilerwert.Name = "txtFilerwert";
            this.txtFilerwert.Size = new System.Drawing.Size(539, 26);
            this.txtFilerwert.TabIndex = 6;
            this.txtFilerwert.TextChanged += new System.EventHandler(this.txtFilerwert_TextChanged);
            this.txtFilerwert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilerwert_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources.store_869636;
            this.pictureBox1.Location = new System.Drawing.Point(24, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1309, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmEinkaufsDatenListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1367, 669);
            this.Controls.Add(this.txtFilerwert);
            this.Controls.Add(this.cbFilterbei);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktualisereParfümMenge);
            this.Controls.Add(this.btnHinzufügeNeueMenge);
            this.Controls.Add(this.dgvLager);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmEinkaufsDatenListe";
            this.Text = " Einkauf-daten";
            this.Load += new System.EventHandler(this.frmLagerListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLager)).EndInit();
            this.cmsLager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLager;
        private System.Windows.Forms.Button btnHinzufügeNeueMenge;
        private System.Windows.Forms.Button btnAktualisereParfümMenge;
        private System.Windows.Forms.ContextMenuStrip cmsLager;
        private System.Windows.Forms.ToolStripMenuItem aktualisiereParfümMengeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entferneParfümToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterbei;
        private System.Windows.Forms.TextBox txtFilerwert;
        private System.Windows.Forms.ToolStripMenuItem seheVerkaufsDetailstoolStripMenuItem1;
    }
}