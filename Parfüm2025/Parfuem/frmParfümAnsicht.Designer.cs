﻿namespace Parfüm2025
{
    partial class frmpafümAnsicht
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAlleParfüms = new System.Windows.Forms.TabPage();
            this.btnErstelleEineParfümListePdf = new System.Windows.Forms.Button();
            this.lbVorschläge = new System.Windows.Forms.ListBox();
            this.txtFilterWert = new System.Windows.Forms.TextBox();
            this.cbFilterBei = new System.Windows.Forms.ComboBox();
            this.btnDatenAktualisieren = new System.Windows.Forms.Button();
            this.btnNeuParfümHinzufügen = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.txtParfümSuchen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvParfüm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mehrDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.parfümHinzufügentoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pafümAktualisierentoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.duftEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2HerrnDüfte = new System.Windows.Forms.TabPage();
            this.txtHerrenParfümFilterbeiNummer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHerrenParfümFilterbeiName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHerrenParfümFilterbeiMarke = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHerrefDüfte = new System.Windows.Forms.DataGridView();
            this.tabPage3DamenDüfte = new System.Windows.Forms.TabPage();
            this.txtDamenPafrümFilterBeiNummer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDamenParfümFilterbeiName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDamenParfümFilterBeiMarke = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDamenParfüm = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpAlleParfüms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParfüm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2HerrnDüfte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerrefDüfte)).BeginInit();
            this.tabPage3DamenDüfte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamenParfüm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpAlleParfüms);
            this.tabControl1.Controls.Add(this.tabPage2HerrnDüfte);
            this.tabControl1.Controls.Add(this.tabPage3DamenDüfte);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 101);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1875, 971);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tpAlleParfüms
            // 
            this.tpAlleParfüms.BackColor = System.Drawing.Color.White;
            this.tpAlleParfüms.Controls.Add(this.btnErstelleEineParfümListePdf);
            this.tpAlleParfüms.Controls.Add(this.lbVorschläge);
            this.tpAlleParfüms.Controls.Add(this.txtFilterWert);
            this.tpAlleParfüms.Controls.Add(this.cbFilterBei);
            this.tpAlleParfüms.Controls.Add(this.btnDatenAktualisieren);
            this.tpAlleParfüms.Controls.Add(this.btnNeuParfümHinzufügen);
            this.tpAlleParfüms.Controls.Add(this.btnSuchen);
            this.tpAlleParfüms.Controls.Add(this.txtParfümSuchen);
            this.tpAlleParfüms.Controls.Add(this.label12);
            this.tpAlleParfüms.Controls.Add(this.label3);
            this.tpAlleParfüms.Controls.Add(this.dgvParfüm);
            this.tpAlleParfüms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAlleParfüms.ForeColor = System.Drawing.Color.Black;
            this.tpAlleParfüms.Location = new System.Drawing.Point(4, 40);
            this.tpAlleParfüms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAlleParfüms.Name = "tpAlleParfüms";
            this.tpAlleParfüms.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpAlleParfüms.Size = new System.Drawing.Size(1867, 927);
            this.tpAlleParfüms.TabIndex = 0;
            this.tpAlleParfüms.Text = "Unisexdüfte";
            // 
            // btnErstelleEineParfümListePdf
            // 
            this.btnErstelleEineParfümListePdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErstelleEineParfümListePdf.BackColor = System.Drawing.Color.ForestGreen;
            this.btnErstelleEineParfümListePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErstelleEineParfümListePdf.ForeColor = System.Drawing.Color.White;
            this.btnErstelleEineParfümListePdf.Location = new System.Drawing.Point(1593, 37);
            this.btnErstelleEineParfümListePdf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnErstelleEineParfümListePdf.Name = "btnErstelleEineParfümListePdf";
            this.btnErstelleEineParfümListePdf.Size = new System.Drawing.Size(260, 52);
            this.btnErstelleEineParfümListePdf.TabIndex = 26;
            this.btnErstelleEineParfümListePdf.Text = "Erstelle Pdf";
            this.btnErstelleEineParfümListePdf.UseVisualStyleBackColor = false;
            this.btnErstelleEineParfümListePdf.Click += new System.EventHandler(this.btnErstelleEineParfümListePdf_Click);
            // 
            // lbVorschläge
            // 
            this.lbVorschläge.FormattingEnabled = true;
            this.lbVorschläge.ItemHeight = 25;
            this.lbVorschläge.Location = new System.Drawing.Point(493, 86);
            this.lbVorschläge.Margin = new System.Windows.Forms.Padding(4);
            this.lbVorschläge.Name = "lbVorschläge";
            this.lbVorschläge.Size = new System.Drawing.Size(349, 204);
            this.lbVorschläge.TabIndex = 24;
            this.lbVorschläge.Visible = false;
            this.lbVorschläge.Click += new System.EventHandler(this.lbVorschläge_Click_1);
            // 
            // txtFilterWert
            // 
            this.txtFilterWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterWert.Location = new System.Drawing.Point(443, 127);
            this.txtFilterWert.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterWert.Multiline = true;
            this.txtFilterWert.Name = "txtFilterWert";
            this.txtFilterWert.Size = new System.Drawing.Size(549, 40);
            this.txtFilterWert.TabIndex = 23;
            this.txtFilterWert.TextChanged += new System.EventHandler(this.txtFilterWert_TextChanged);
            this.txtFilterWert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterWert_KeyPress);
            // 
            // cbFilterBei
            // 
            this.cbFilterBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBei.FormattingEnabled = true;
            this.cbFilterBei.Items.AddRange(new object[] {
            "ParfümNummer",
            "Marke",
            "Name",
            "Kategorie",
            "Duftrichtung",
            "Jahreszeiten"});
            this.cbFilterBei.Location = new System.Drawing.Point(144, 127);
            this.cbFilterBei.Margin = new System.Windows.Forms.Padding(4);
            this.cbFilterBei.Name = "cbFilterBei";
            this.cbFilterBei.Size = new System.Drawing.Size(289, 37);
            this.cbFilterBei.TabIndex = 22;
            this.cbFilterBei.SelectedIndexChanged += new System.EventHandler(this.cbFilterBei_SelectedIndexChanged);
            // 
            // btnDatenAktualisieren
            // 
            this.btnDatenAktualisieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatenAktualisieren.BackColor = System.Drawing.Color.White;
            this.btnDatenAktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatenAktualisieren.Image = global::Parfüm2025.Properties.Resources.update1;
            this.btnDatenAktualisieren.Location = new System.Drawing.Point(1484, 117);
            this.btnDatenAktualisieren.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatenAktualisieren.Name = "btnDatenAktualisieren";
            this.btnDatenAktualisieren.Size = new System.Drawing.Size(59, 49);
            this.btnDatenAktualisieren.TabIndex = 21;
            this.btnDatenAktualisieren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatenAktualisieren.UseVisualStyleBackColor = false;
            this.btnDatenAktualisieren.Click += new System.EventHandler(this.btnDatenAktualisieren_Click);
            // 
            // btnNeuParfümHinzufügen
            // 
            this.btnNeuParfümHinzufügen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNeuParfümHinzufügen.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNeuParfümHinzufügen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNeuParfümHinzufügen.ForeColor = System.Drawing.Color.White;
            this.btnNeuParfümHinzufügen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNeuParfümHinzufügen.Location = new System.Drawing.Point(1548, 117);
            this.btnNeuParfümHinzufügen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNeuParfümHinzufügen.Name = "btnNeuParfümHinzufügen";
            this.btnNeuParfümHinzufügen.Size = new System.Drawing.Size(305, 50);
            this.btnNeuParfümHinzufügen.TabIndex = 20;
            this.btnNeuParfümHinzufügen.Text = "Addnew Parfümdaten";
            this.btnNeuParfümHinzufügen.UseVisualStyleBackColor = false;
            this.btnNeuParfümHinzufügen.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuchen.ForeColor = System.Drawing.Color.White;
            this.btnSuchen.Location = new System.Drawing.Point(849, 38);
            this.btnSuchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(169, 52);
            this.btnSuchen.TabIndex = 18;
            this.btnSuchen.Text = "Suche";
            this.btnSuchen.UseVisualStyleBackColor = false;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // txtParfümSuchen
            // 
            this.txtParfümSuchen.BackColor = System.Drawing.Color.White;
            this.txtParfümSuchen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParfümSuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParfümSuchen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtParfümSuchen.Location = new System.Drawing.Point(493, 44);
            this.txtParfümSuchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParfümSuchen.Multiline = true;
            this.txtParfümSuchen.Name = "txtParfümSuchen";
            this.txtParfümSuchen.Size = new System.Drawing.Size(350, 41);
            this.txtParfümSuchen.TabIndex = 16;
            this.txtParfümSuchen.TextChanged += new System.EventHandler(this.txtParfümSuchen_TextChanged);
            this.txtParfümSuchen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParfümSuchen_KeyDown);
            this.txtParfümSuchen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParfümSuchen_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(19, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(444, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = "Nach einem bestimmten Parüfm suchen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter bei:";
            // 
            // dgvParfüm
            // 
            this.dgvParfüm.AllowUserToAddRows = false;
            this.dgvParfüm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvParfüm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParfüm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParfüm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParfüm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParfüm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParfüm.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParfüm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvParfüm.EnableHeadersVisualStyles = false;
            this.dgvParfüm.Location = new System.Drawing.Point(23, 172);
            this.dgvParfüm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvParfüm.MultiSelect = false;
            this.dgvParfüm.Name = "dgvParfüm";
            this.dgvParfüm.ReadOnly = true;
            this.dgvParfüm.RowHeadersWidth = 60;
            this.dgvParfüm.RowTemplate.Height = 30;
            this.dgvParfüm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParfüm.ShowCellErrors = false;
            this.dgvParfüm.Size = new System.Drawing.Size(1835, 668);
            this.dgvParfüm.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mehrDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.parfümHinzufügentoolStripMenuItem1,
            this.pafümAktualisierentoolStripMenuItem2,
            this.duftEntfernenToolStripMenuItem,
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(491, 200);
            // 
            // mehrDetailsToolStripMenuItem
            // 
            this.mehrDetailsToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.details_32;
            this.mehrDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mehrDetailsToolStripMenuItem.Name = "mehrDetailsToolStripMenuItem";
            this.mehrDetailsToolStripMenuItem.Size = new System.Drawing.Size(490, 38);
            this.mehrDetailsToolStripMenuItem.Text = "Sehe Duft details";
            this.mehrDetailsToolStripMenuItem.Click += new System.EventHandler(this.mehrDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(487, 6);
            // 
            // parfümHinzufügentoolStripMenuItem1
            // 
            this.parfümHinzufügentoolStripMenuItem1.Image = global::Parfüm2025.Properties.Resources.plus_10021331;
            this.parfümHinzufügentoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.parfümHinzufügentoolStripMenuItem1.Name = "parfümHinzufügentoolStripMenuItem1";
            this.parfümHinzufügentoolStripMenuItem1.Size = new System.Drawing.Size(490, 38);
            this.parfümHinzufügentoolStripMenuItem1.Text = "Hinzufüge neuen Duft";
            this.parfümHinzufügentoolStripMenuItem1.Click += new System.EventHandler(this.parfümHinzufügentoolStripMenuItem1_Click);
            // 
            // pafümAktualisierentoolStripMenuItem2
            // 
            this.pafümAktualisierentoolStripMenuItem2.Image = global::Parfüm2025.Properties.Resources.refresh_5791276;
            this.pafümAktualisierentoolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pafümAktualisierentoolStripMenuItem2.Name = "pafümAktualisierentoolStripMenuItem2";
            this.pafümAktualisierentoolStripMenuItem2.Size = new System.Drawing.Size(490, 38);
            this.pafümAktualisierentoolStripMenuItem2.Text = "Aktualisiere bestehenden Duft";
            this.pafümAktualisierentoolStripMenuItem2.Click += new System.EventHandler(this.pafümAktualisierentoolStripMenuItem2_Click);
            // 
            // duftEntfernenToolStripMenuItem
            // 
            this.duftEntfernenToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.delete_5953478__1_;
            this.duftEntfernenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.duftEntfernenToolStripMenuItem.Name = "duftEntfernenToolStripMenuItem";
            this.duftEntfernenToolStripMenuItem.Size = new System.Drawing.Size(490, 38);
            this.duftEntfernenToolStripMenuItem.Text = "Entferne Duft";
            this.duftEntfernenToolStripMenuItem.Click += new System.EventHandler(this.duftEntfernenToolStripMenuItem_Click);
            // 
            // erstelleEineParfümlisteAlsPDFToolStripMenuItem
            // 
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.pdf_file_format_6795752;
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Name = "erstelleEineParfümlisteAlsPDFToolStripMenuItem";
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Size = new System.Drawing.Size(490, 38);
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Text = "Erstelle eine Pdf-Datei aus Parfümliste";
            this.erstelleEineParfümlisteAlsPDFToolStripMenuItem.Click += new System.EventHandler(this.erstelleEineParfümlisteAlsPDFToolStripMenuItem_Click);
            // 
            // tabPage2HerrnDüfte
            // 
            this.tabPage2HerrnDüfte.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2HerrnDüfte.Controls.Add(this.txtHerrenParfümFilterbeiNummer);
            this.tabPage2HerrnDüfte.Controls.Add(this.label4);
            this.tabPage2HerrnDüfte.Controls.Add(this.txtHerrenParfümFilterbeiName);
            this.tabPage2HerrnDüfte.Controls.Add(this.label5);
            this.tabPage2HerrnDüfte.Controls.Add(this.txtHerrenParfümFilterbeiMarke);
            this.tabPage2HerrnDüfte.Controls.Add(this.label6);
            this.tabPage2HerrnDüfte.Controls.Add(this.dgvHerrefDüfte);
            this.tabPage2HerrnDüfte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2HerrnDüfte.Location = new System.Drawing.Point(4, 40);
            this.tabPage2HerrnDüfte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2HerrnDüfte.Name = "tabPage2HerrnDüfte";
            this.tabPage2HerrnDüfte.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2HerrnDüfte.Size = new System.Drawing.Size(1867, 927);
            this.tabPage2HerrnDüfte.TabIndex = 1;
            this.tabPage2HerrnDüfte.Text = "Herrndüfte";
            // 
            // txtHerrenParfümFilterbeiNummer
            // 
            this.txtHerrenParfümFilterbeiNummer.BackColor = System.Drawing.Color.White;
            this.txtHerrenParfümFilterbeiNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHerrenParfümFilterbeiNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerrenParfümFilterbeiNummer.Location = new System.Drawing.Point(144, 42);
            this.txtHerrenParfümFilterbeiNummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHerrenParfümFilterbeiNummer.Name = "txtHerrenParfümFilterbeiNummer";
            this.txtHerrenParfümFilterbeiNummer.Size = new System.Drawing.Size(303, 38);
            this.txtHerrenParfümFilterbeiNummer.TabIndex = 16;
            this.txtHerrenParfümFilterbeiNummer.TextChanged += new System.EventHandler(this.txtHerrenParfümFilterbeiNummer_TextChanged);
            this.txtHerrenParfümFilterbeiNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHerrenParfümFilterbeiNummer_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nummer:";
            // 
            // txtHerrenParfümFilterbeiName
            // 
            this.txtHerrenParfümFilterbeiName.BackColor = System.Drawing.Color.White;
            this.txtHerrenParfümFilterbeiName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHerrenParfümFilterbeiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerrenParfümFilterbeiName.Location = new System.Drawing.Point(1125, 42);
            this.txtHerrenParfümFilterbeiName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHerrenParfümFilterbeiName.Name = "txtHerrenParfümFilterbeiName";
            this.txtHerrenParfümFilterbeiName.Size = new System.Drawing.Size(383, 38);
            this.txtHerrenParfümFilterbeiName.TabIndex = 14;
            this.txtHerrenParfümFilterbeiName.TextChanged += new System.EventHandler(this.txtHerrenParfümFilterbeiName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1029, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name:";
            // 
            // txtHerrenParfümFilterbeiMarke
            // 
            this.txtHerrenParfümFilterbeiMarke.BackColor = System.Drawing.Color.White;
            this.txtHerrenParfümFilterbeiMarke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHerrenParfümFilterbeiMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerrenParfümFilterbeiMarke.Location = new System.Drawing.Point(589, 42);
            this.txtHerrenParfümFilterbeiMarke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHerrenParfümFilterbeiMarke.Name = "txtHerrenParfümFilterbeiMarke";
            this.txtHerrenParfümFilterbeiMarke.Size = new System.Drawing.Size(415, 38);
            this.txtHerrenParfümFilterbeiMarke.TabIndex = 12;
            this.txtHerrenParfümFilterbeiMarke.TextChanged += new System.EventHandler(this.txtHerrenParfümFilterbeiMarke_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Marke:";
            // 
            // dgvHerrefDüfte
            // 
            this.dgvHerrefDüfte.AllowUserToAddRows = false;
            this.dgvHerrefDüfte.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHerrefDüfte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHerrefDüfte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHerrefDüfte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHerrefDüfte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerrefDüfte.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHerrefDüfte.Location = new System.Drawing.Point(4, 91);
            this.dgvHerrefDüfte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHerrefDüfte.MultiSelect = false;
            this.dgvHerrefDüfte.Name = "dgvHerrefDüfte";
            this.dgvHerrefDüfte.ReadOnly = true;
            this.dgvHerrefDüfte.RowHeadersWidth = 60;
            this.dgvHerrefDüfte.RowTemplate.Height = 30;
            this.dgvHerrefDüfte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHerrefDüfte.Size = new System.Drawing.Size(1849, 641);
            this.dgvHerrefDüfte.TabIndex = 10;
            // 
            // tabPage3DamenDüfte
            // 
            this.tabPage3DamenDüfte.Controls.Add(this.txtDamenPafrümFilterBeiNummer);
            this.tabPage3DamenDüfte.Controls.Add(this.label7);
            this.tabPage3DamenDüfte.Controls.Add(this.txtDamenParfümFilterbeiName);
            this.tabPage3DamenDüfte.Controls.Add(this.label8);
            this.tabPage3DamenDüfte.Controls.Add(this.txtDamenParfümFilterBeiMarke);
            this.tabPage3DamenDüfte.Controls.Add(this.label9);
            this.tabPage3DamenDüfte.Controls.Add(this.dgvDamenParfüm);
            this.tabPage3DamenDüfte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3DamenDüfte.Location = new System.Drawing.Point(4, 40);
            this.tabPage3DamenDüfte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3DamenDüfte.Name = "tabPage3DamenDüfte";
            this.tabPage3DamenDüfte.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3DamenDüfte.Size = new System.Drawing.Size(1867, 927);
            this.tabPage3DamenDüfte.TabIndex = 2;
            this.tabPage3DamenDüfte.Text = "Damendüfte";
            this.tabPage3DamenDüfte.UseVisualStyleBackColor = true;
            // 
            // txtDamenPafrümFilterBeiNummer
            // 
            this.txtDamenPafrümFilterBeiNummer.BackColor = System.Drawing.Color.White;
            this.txtDamenPafrümFilterBeiNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDamenPafrümFilterBeiNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDamenPafrümFilterBeiNummer.Location = new System.Drawing.Point(143, 25);
            this.txtDamenPafrümFilterBeiNummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDamenPafrümFilterBeiNummer.Name = "txtDamenPafrümFilterBeiNummer";
            this.txtDamenPafrümFilterBeiNummer.Size = new System.Drawing.Size(303, 38);
            this.txtDamenPafrümFilterBeiNummer.TabIndex = 23;
            this.txtDamenPafrümFilterBeiNummer.TextChanged += new System.EventHandler(this.txtDamenPafrümFilterBeiNummer_TextChanged);
            this.txtDamenPafrümFilterBeiNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDamenPafrümFilterBeiNummer_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nummer:";
            // 
            // txtDamenParfümFilterbeiName
            // 
            this.txtDamenParfümFilterbeiName.BackColor = System.Drawing.Color.White;
            this.txtDamenParfümFilterbeiName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDamenParfümFilterbeiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDamenParfümFilterbeiName.Location = new System.Drawing.Point(1124, 25);
            this.txtDamenParfümFilterbeiName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDamenParfümFilterbeiName.Name = "txtDamenParfümFilterbeiName";
            this.txtDamenParfümFilterbeiName.Size = new System.Drawing.Size(383, 38);
            this.txtDamenParfümFilterbeiName.TabIndex = 21;
            this.txtDamenParfümFilterbeiName.TextChanged += new System.EventHandler(this.txtDamenParfümFilterbeiName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1029, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Name:";
            // 
            // txtDamenParfümFilterBeiMarke
            // 
            this.txtDamenParfümFilterBeiMarke.BackColor = System.Drawing.Color.White;
            this.txtDamenParfümFilterBeiMarke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDamenParfümFilterBeiMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDamenParfümFilterBeiMarke.Location = new System.Drawing.Point(589, 25);
            this.txtDamenParfümFilterBeiMarke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDamenParfümFilterBeiMarke.Name = "txtDamenParfümFilterBeiMarke";
            this.txtDamenParfümFilterBeiMarke.Size = new System.Drawing.Size(415, 38);
            this.txtDamenParfümFilterBeiMarke.TabIndex = 19;
            this.txtDamenParfümFilterBeiMarke.TextChanged += new System.EventHandler(this.txtDamenParfümFilterBeiMarke_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(491, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Marke:";
            // 
            // dgvDamenParfüm
            // 
            this.dgvDamenParfüm.AllowUserToAddRows = false;
            this.dgvDamenParfüm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDamenParfüm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDamenParfüm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDamenParfüm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDamenParfüm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamenParfüm.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDamenParfüm.Location = new System.Drawing.Point(3, 73);
            this.dgvDamenParfüm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDamenParfüm.Name = "dgvDamenParfüm";
            this.dgvDamenParfüm.ReadOnly = true;
            this.dgvDamenParfüm.RowHeadersWidth = 51;
            this.dgvDamenParfüm.RowTemplate.Height = 30;
            this.dgvDamenParfüm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDamenParfüm.Size = new System.Drawing.Size(1851, 658);
            this.dgvDamenParfüm.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1873, 84);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(721, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parfüm Verwaltung";
            // 
            // frmpafümAnsicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1873, 1061);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmpafümAnsicht";
            this.Text = "Pafrümansicht";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAlleParfüms.ResumeLayout(false);
            this.tpAlleParfüms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParfüm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2HerrnDüfte.ResumeLayout(false);
            this.tabPage2HerrnDüfte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerrefDüfte)).EndInit();
            this.tabPage3DamenDüfte.ResumeLayout(false);
            this.tabPage3DamenDüfte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamenParfüm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAlleParfüms;
        private System.Windows.Forms.TabPage tabPage2HerrnDüfte;
        private System.Windows.Forms.TabPage tabPage3DamenDüfte;
        private System.Windows.Forms.DataGridView dgvParfüm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mehrDetailsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHerrenParfümFilterbeiNummer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHerrenParfümFilterbeiName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHerrenParfümFilterbeiMarke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDamenPafrümFilterBeiNummer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDamenParfümFilterbeiName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDamenParfümFilterBeiMarke;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDamenParfüm;
        private System.Windows.Forms.TextBox txtParfümSuchen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnNeuParfümHinzufügen;
        private System.Windows.Forms.ToolStripMenuItem duftEntfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parfümHinzufügentoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pafümAktualisierentoolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvHerrefDüfte;
        private System.Windows.Forms.Button btnDatenAktualisieren;
        private System.Windows.Forms.TextBox txtFilterWert;
        private System.Windows.Forms.ComboBox cbFilterBei;
        private System.Windows.Forms.ListBox lbVorschläge;
        private System.Windows.Forms.ToolStripMenuItem erstelleEineParfümlisteAlsPDFToolStripMenuItem;
        private System.Windows.Forms.Button btnErstelleEineParfümListePdf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

