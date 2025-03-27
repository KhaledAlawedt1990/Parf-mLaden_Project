namespace Parfüm2025
{
    partial class frmDruckvorschau
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDruckvorschau));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.konvertiereZurPdfDateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBelegID = new System.Windows.Forms.Label();
            this.lblKasse = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVerkaufsdaten = new System.Windows.Forms.DataGridView();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Einzelpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gesamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNettoBrutto = new System.Windows.Forms.Panel();
            this.lblNetto = new System.Windows.Forms.Label();
            this.lblBrutto = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblSteuer = new System.Windows.Forms.Label();
            this.pnlPdfKopf = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblFirmadaten = new System.Windows.Forms.Label();
            this.lblBegrüßung = new System.Windows.Forms.Label();
            this.lblRechnungsTitel = new System.Windows.Forms.Label();
            this.lblVollname = new System.Windows.Forms.Label();
            this.lblStadt = new System.Windows.Forms.Label();
            this.lblStrasse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHaupPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerkaufsdaten)).BeginInit();
            this.pnlNettoBrutto.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlPdfKopf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlHaupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konvertiereZurPdfDateiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(316, 42);
            // 
            // konvertiereZurPdfDateiToolStripMenuItem
            // 
            this.konvertiereZurPdfDateiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konvertiereZurPdfDateiToolStripMenuItem.Image = global::Parfüm2025.Properties.Resources.pdf_file_format_6795752;
            this.konvertiereZurPdfDateiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.konvertiereZurPdfDateiToolStripMenuItem.Name = "konvertiereZurPdfDateiToolStripMenuItem";
            this.konvertiereZurPdfDateiToolStripMenuItem.Size = new System.Drawing.Size(315, 38);
            this.konvertiereZurPdfDateiToolStripMenuItem.Text = "Konvertiere zur Pdf Datei";
            this.konvertiereZurPdfDateiToolStripMenuItem.Click += new System.EventHandler(this.konvertiereZurPdfDateiToolStripMenuItem_Click);
            // 
            // lblBelegID
            // 
            this.lblBelegID.AutoSize = true;
            this.lblBelegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBelegID.Location = new System.Drawing.Point(48, 453);
            this.lblBelegID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBelegID.Name = "lblBelegID";
            this.lblBelegID.Size = new System.Drawing.Size(39, 20);
            this.lblBelegID.TabIndex = 7;
            this.lblBelegID.Text = "???";
            // 
            // lblKasse
            // 
            this.lblKasse.AutoSize = true;
            this.lblKasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKasse.Location = new System.Drawing.Point(233, 453);
            this.lblKasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKasse.Name = "lblKasse";
            this.lblKasse.Size = new System.Drawing.Size(19, 20);
            this.lblKasse.TabIndex = 9;
            this.lblKasse.Text = "1";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(411, 454);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(108, 20);
            this.lable.TabIndex = 11;
            this.lable.Text = "Kassieserin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(597, 453);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rechnung";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(781, 453);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(39, 20);
            this.lblDatum.TabIndex = 15;
            this.lblDatum.Text = "???";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(44, 478);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 1);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(25, 416);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 33);
            this.panel3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Beleg Nu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kasse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kassieserin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Zahlungsart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(761, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Datum";
            // 
            // dgvVerkaufsdaten
            // 
            this.dgvVerkaufsdaten.AllowUserToAddRows = false;
            this.dgvVerkaufsdaten.AllowUserToDeleteRows = false;
            this.dgvVerkaufsdaten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVerkaufsdaten.BackgroundColor = System.Drawing.Color.White;
            this.dgvVerkaufsdaten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVerkaufsdaten.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVerkaufsdaten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerkaufsdaten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVerkaufsdaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerkaufsdaten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anzahl,
            this.Beschreibung,
            this.Ust,
            this.Einzelpreis,
            this.Gesamt});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerkaufsdaten.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVerkaufsdaten.Location = new System.Drawing.Point(25, 511);
            this.dgvVerkaufsdaten.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVerkaufsdaten.Name = "dgvVerkaufsdaten";
            this.dgvVerkaufsdaten.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerkaufsdaten.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVerkaufsdaten.RowHeadersVisible = false;
            this.dgvVerkaufsdaten.RowHeadersWidth = 51;
            this.dgvVerkaufsdaten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvVerkaufsdaten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVerkaufsdaten.Size = new System.Drawing.Size(945, 108);
            this.dgvVerkaufsdaten.TabIndex = 53;
            this.dgvVerkaufsdaten.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVerkaufsdaten_RowsAdded);

            // 
            // Anzahl
            // 
            this.Anzahl.HeaderText = "Parfüm Nr";
            this.Anzahl.MinimumWidth = 6;
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            this.Anzahl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Beschreibung
            // 
            this.Beschreibung.HeaderText = "Gewicht";
            this.Beschreibung.MinimumWidth = 6;
            this.Beschreibung.Name = "Beschreibung";
            this.Beschreibung.ReadOnly = true;
            this.Beschreibung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ust
            // 
            this.Ust.HeaderText = "Ust%";
            this.Ust.MinimumWidth = 6;
            this.Ust.Name = "Ust";
            this.Ust.ReadOnly = true;
            this.Ust.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Einzelpreis
            // 
            this.Einzelpreis.HeaderText = "Einzelpreis";
            this.Einzelpreis.MinimumWidth = 6;
            this.Einzelpreis.Name = "Einzelpreis";
            this.Einzelpreis.ReadOnly = true;
            this.Einzelpreis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Gesamt
            // 
            this.Gesamt.HeaderText = "Gesamt";
            this.Gesamt.MinimumWidth = 6;
            this.Gesamt.Name = "Gesamt";
            this.Gesamt.ReadOnly = true;
            // 
            // pnlNettoBrutto
            // 
            this.pnlNettoBrutto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlNettoBrutto.Controls.Add(this.lblNetto);
            this.pnlNettoBrutto.Controls.Add(this.lblBrutto);
            this.pnlNettoBrutto.Controls.Add(this.panel8);
            this.pnlNettoBrutto.Controls.Add(this.lblSteuer);
            this.pnlNettoBrutto.Location = new System.Drawing.Point(25, 548);
            this.pnlNettoBrutto.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNettoBrutto.Name = "pnlNettoBrutto";
            this.pnlNettoBrutto.Size = new System.Drawing.Size(945, 98);
            this.pnlNettoBrutto.TabIndex = 55;
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetto.Location = new System.Drawing.Point(440, 60);
            this.lblNetto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(36, 20);
            this.lblNetto.TabIndex = 44;
            this.lblNetto.Text = "???";
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrutto.Location = new System.Drawing.Point(799, 60);
            this.lblBrutto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(39, 20);
            this.lblBrutto.TabIndex = 45;
            this.lblBrutto.Text = "???";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.label24);
            this.panel8.Controls.Add(this.label25);
            this.panel8.Controls.Add(this.label21);
            this.panel8.Location = new System.Drawing.Point(4, 15);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(941, 31);
            this.panel8.TabIndex = 47;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(429, 6);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 20);
            this.label24.TabIndex = 41;
            this.label24.Text = "Netto €";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(599, 6);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 20);
            this.label25.TabIndex = 42;
            this.label25.Text = "Steuer€";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(785, 6);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 20);
            this.label21.TabIndex = 38;
            this.label21.Text = "Summe €";
            // 
            // lblSteuer
            // 
            this.lblSteuer.AutoSize = true;
            this.lblSteuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteuer.Location = new System.Drawing.Point(611, 60);
            this.lblSteuer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSteuer.Name = "lblSteuer";
            this.lblSteuer.Size = new System.Drawing.Size(36, 20);
            this.lblSteuer.TabIndex = 46;
            this.lblSteuer.Text = "???";
            // 
            // pnlPdfKopf
            // 
            this.pnlPdfKopf.Controls.Add(this.pbLogo);
            this.pnlPdfKopf.Controls.Add(this.lblFirmadaten);
            this.pnlPdfKopf.Controls.Add(this.lblBegrüßung);
            this.pnlPdfKopf.Controls.Add(this.lblRechnungsTitel);
            this.pnlPdfKopf.Controls.Add(this.lblVollname);
            this.pnlPdfKopf.Controls.Add(this.lblStadt);
            this.pnlPdfKopf.Controls.Add(this.lblStrasse);
            this.pnlPdfKopf.Controls.Add(this.label2);
            this.pnlPdfKopf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPdfKopf.Location = new System.Drawing.Point(0, 0);
            this.pnlPdfKopf.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPdfKopf.Name = "pnlPdfKopf";
            this.pnlPdfKopf.Size = new System.Drawing.Size(1045, 394);
            this.pnlPdfKopf.TabIndex = 58;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Parfüm2025.Properties.Resources.Alowidat_Final_Logo_02;
            this.pbLogo.Location = new System.Drawing.Point(16, 11);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(468, 150);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 66;
            this.pbLogo.TabStop = false;
            // 
            // lblFirmadaten
            // 
            this.lblFirmadaten.AutoSize = true;
            this.lblFirmadaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmadaten.Location = new System.Drawing.Point(692, 48);
            this.lblFirmadaten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirmadaten.Name = "lblFirmadaten";
            this.lblFirmadaten.Size = new System.Drawing.Size(262, 200);
            this.lblFirmadaten.TabIndex = 65;
            this.lblFirmadaten.Text = resources.GetString("lblFirmadaten.Text");
            // 
            // lblBegrüßung
            // 
            this.lblBegrüßung.AutoSize = true;
            this.lblBegrüßung.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBegrüßung.Location = new System.Drawing.Point(39, 336);
            this.lblBegrüßung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBegrüßung.Name = "lblBegrüßung";
            this.lblBegrüßung.Size = new System.Drawing.Size(586, 48);
            this.lblBegrüßung.TabIndex = 63;
            this.lblBegrüßung.Text = "Sehr geehrte Damen und Herrn,\r\nIm folgenden der/die erworbene/n Artikel, die ich " +
    "in Rechnung stelle:";
            // 
            // lblRechnungsTitel
            // 
            this.lblRechnungsTitel.AutoSize = true;
            this.lblRechnungsTitel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechnungsTitel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRechnungsTitel.Location = new System.Drawing.Point(34, 281);
            this.lblRechnungsTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechnungsTitel.Name = "lblRechnungsTitel";
            this.lblRechnungsTitel.Size = new System.Drawing.Size(149, 49);
            this.lblRechnungsTitel.TabIndex = 62;
            this.lblRechnungsTitel.Text = "Vorlage";
            // 
            // lblVollname
            // 
            this.lblVollname.AutoSize = true;
            this.lblVollname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVollname.Location = new System.Drawing.Point(101, 194);
            this.lblVollname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVollname.Name = "lblVollname";
            this.lblVollname.Size = new System.Drawing.Size(103, 24);
            this.lblVollname.TabIndex = 61;
            this.lblVollname.Text = "Empfänger";
            // 
            // lblStadt
            // 
            this.lblStadt.AutoSize = true;
            this.lblStadt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadt.Location = new System.Drawing.Point(43, 246);
            this.lblStadt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStadt.Name = "lblStadt";
            this.lblStadt.Size = new System.Drawing.Size(143, 24);
            this.lblStadt.TabIndex = 60;
            this.lblStadt.Text = "74821 Mosbach";
            // 
            // lblStrasse
            // 
            this.lblStrasse.AutoSize = true;
            this.lblStrasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrasse.Location = new System.Drawing.Point(43, 219);
            this.lblStrasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStrasse.Name = "lblStrasse";
            this.lblStrasse.Size = new System.Drawing.Size(137, 24);
            this.lblStrasse.TabIndex = 59;
            this.lblStrasse.Text = "Straßename 20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Herrn";
            // 
            // pnlHaupPanel
            // 
            this.pnlHaupPanel.BackColor = System.Drawing.Color.White;
            this.pnlHaupPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.pnlHaupPanel.Controls.Add(this.pnlPdfKopf);
            this.pnlHaupPanel.Controls.Add(this.pnlNettoBrutto);
            this.pnlHaupPanel.Controls.Add(this.dgvVerkaufsdaten);
            this.pnlHaupPanel.Controls.Add(this.panel3);
            this.pnlHaupPanel.Controls.Add(this.panel2);
            this.pnlHaupPanel.Controls.Add(this.lblDatum);
            this.pnlHaupPanel.Controls.Add(this.label7);
            this.pnlHaupPanel.Controls.Add(this.lable);
            this.pnlHaupPanel.Controls.Add(this.lblKasse);
            this.pnlHaupPanel.Controls.Add(this.lblBelegID);
            this.pnlHaupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHaupPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlHaupPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHaupPanel.Name = "pnlHaupPanel";
            this.pnlHaupPanel.Size = new System.Drawing.Size(1045, 1175);
            this.pnlHaupPanel.TabIndex = 4;
            // 
            // frmDruckvorschau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 1175);
            this.Controls.Add(this.pnlHaupPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDruckvorschau";
            this.Text = "Druck-Voschau";
            this.Load += new System.EventHandler(this.frmDruckvorschau_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerkaufsdaten)).EndInit();
            this.pnlNettoBrutto.ResumeLayout(false);
            this.pnlNettoBrutto.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnlPdfKopf.ResumeLayout(false);
            this.pnlPdfKopf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlHaupPanel.ResumeLayout(false);
            this.pnlHaupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konvertiereZurPdfDateiToolStripMenuItem;
        private System.Windows.Forms.Label lblBelegID;
        private System.Windows.Forms.Label lblKasse;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvVerkaufsdaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beschreibung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Einzelpreis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gesamt;
        private System.Windows.Forms.Panel pnlNettoBrutto;
        private System.Windows.Forms.Label lblNetto;
        private System.Windows.Forms.Label lblBrutto;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblSteuer;
        private System.Windows.Forms.Panel pnlPdfKopf;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblFirmadaten;
        private System.Windows.Forms.Label lblBegrüßung;
        private System.Windows.Forms.Label lblRechnungsTitel;
        private System.Windows.Forms.Label lblVollname;
        private System.Windows.Forms.Label lblStadt;
        private System.Windows.Forms.Label lblStrasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlHaupPanel;
    }
}