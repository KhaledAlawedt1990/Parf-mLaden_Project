namespace Parfüm2025
{
    partial class frmAddUpdateVerkaufDaten
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
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGesamtPreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNormalPreis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVerkaufsID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVerkaufsMenge = new System.Windows.Forms.TextBox();
            this.txtGrammText = new System.Windows.Forms.TextBox();
            this.dtpErstellungsDatum = new System.Windows.Forms.DateTimePicker();
            this.txtLagerbestand = new System.Windows.Forms.TextBox();
            this.txtKundeName = new System.Windows.Forms.TextBox();
            this.txtParfümNummer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbVorschläge = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(298, 415);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(134, 31);
            this.btnAbbrechen.TabIndex = 5;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(145, 415);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(134, 31);
            this.btnSpeichern.TabIndex = 4;
            this.btnSpeichern.Text = "speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbVorschläge);
            this.groupBox1.Controls.Add(this.txtGesamtPreis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNormalPreis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVerkaufsID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVerkaufsMenge);
            this.groupBox1.Controls.Add(this.txtGrammText);
            this.groupBox1.Controls.Add(this.dtpErstellungsDatum);
            this.groupBox1.Controls.Add(this.txtLagerbestand);
            this.groupBox1.Controls.Add(this.txtKundeName);
            this.groupBox1.Controls.Add(this.txtParfümNummer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 367);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verkauf-daten";
            // 
            // txtGesamtPreis
            // 
            this.txtGesamtPreis.Location = new System.Drawing.Point(163, 275);
            this.txtGesamtPreis.Name = "txtGesamtPreis";
            this.txtGesamtPreis.ReadOnly = true;
            this.txtGesamtPreis.Size = new System.Drawing.Size(170, 26);
            this.txtGesamtPreis.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "GesamtPreis:";
            // 
            // txtNormalPreis
            // 
            this.txtNormalPreis.Location = new System.Drawing.Point(163, 235);
            this.txtNormalPreis.Name = "txtNormalPreis";
            this.txtNormalPreis.Size = new System.Drawing.Size(170, 26);
            this.txtNormalPreis.TabIndex = 19;
            this.txtNormalPreis.TextChanged += new System.EventHandler(this.txtNormalPreis_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "NormalPreis:*";
            // 
            // txtVerkaufsID
            // 
            this.txtVerkaufsID.Location = new System.Drawing.Point(165, 37);
            this.txtVerkaufsID.Name = "txtVerkaufsID";
            this.txtVerkaufsID.ReadOnly = true;
            this.txtVerkaufsID.Size = new System.Drawing.Size(246, 26);
            this.txtVerkaufsID.TabIndex = 17;
            this.txtVerkaufsID.Text = "-1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "VerkaufsID:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(339, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Gramm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(7, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "VerkaufsMenge:*";
            // 
            // txtVerkaufsMenge
            // 
            this.txtVerkaufsMenge.Location = new System.Drawing.Point(165, 157);
            this.txtVerkaufsMenge.Name = "txtVerkaufsMenge";
            this.txtVerkaufsMenge.Size = new System.Drawing.Size(168, 26);
            this.txtVerkaufsMenge.TabIndex = 13;
            // 
            // txtGrammText
            // 
            this.txtGrammText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGrammText.Location = new System.Drawing.Point(339, 199);
            this.txtGrammText.Name = "txtGrammText";
            this.txtGrammText.Size = new System.Drawing.Size(70, 26);
            this.txtGrammText.TabIndex = 12;
            this.txtGrammText.Text = "Gramm";
            // 
            // dtpErstellungsDatum
            // 
            this.dtpErstellungsDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpErstellungsDatum.Location = new System.Drawing.Point(163, 315);
            this.dtpErstellungsDatum.Name = "dtpErstellungsDatum";
            this.dtpErstellungsDatum.Size = new System.Drawing.Size(246, 26);
            this.dtpErstellungsDatum.TabIndex = 11;
            // 
            // txtLagerbestand
            // 
            this.txtLagerbestand.Location = new System.Drawing.Point(165, 198);
            this.txtLagerbestand.Name = "txtLagerbestand";
            this.txtLagerbestand.ReadOnly = true;
            this.txtLagerbestand.Size = new System.Drawing.Size(168, 26);
            this.txtLagerbestand.TabIndex = 10;
            // 
            // txtKundeName
            // 
            this.txtKundeName.Location = new System.Drawing.Point(163, 117);
            this.txtKundeName.Name = "txtKundeName";
            this.txtKundeName.Size = new System.Drawing.Size(246, 26);
            this.txtKundeName.TabIndex = 7;
            this.txtKundeName.TextChanged += new System.EventHandler(this.txtKundeName_TextChanged);
            // 
            // txtParfümNummer
            // 
            this.txtParfümNummer.Location = new System.Drawing.Point(165, 78);
            this.txtParfümNummer.Name = "txtParfümNummer";
            this.txtParfümNummer.Size = new System.Drawing.Size(246, 26);
            this.txtParfümNummer.TabIndex = 6;
            this.txtParfümNummer.TextChanged += new System.EventHandler(this.txtParfümNummer_TextChanged);
            this.txtParfümNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParfümNummer_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ErstellungsDatum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lagerbestand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "KundeName:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ParfümNummer:*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbVorschläge
            // 
            this.lbVorschläge.FormattingEnabled = true;
            this.lbVorschläge.ItemHeight = 20;
            this.lbVorschläge.Location = new System.Drawing.Point(163, 146);
            this.lbVorschläge.Name = "lbVorschläge";
            this.lbVorschläge.Size = new System.Drawing.Size(246, 164);
            this.lbVorschläge.TabIndex = 22;
            this.lbVorschläge.Visible = false;
            this.lbVorschläge.Click += new System.EventHandler(this.lbVorschläge_Click);
            this.lbVorschläge.SelectedIndexChanged += new System.EventHandler(this.lbVorschläge_SelectedIndexChanged);
            // 
            // frmAddUpdateVerkaufDaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 467);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddUpdateVerkaufDaten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdate-VerkaufDaten";
            this.Load += new System.EventHandler(this.frmAddUpdateVerkaufDaten_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVerkaufsMenge;
        private System.Windows.Forms.TextBox txtGrammText;
        private System.Windows.Forms.DateTimePicker dtpErstellungsDatum;
        private System.Windows.Forms.TextBox txtLagerbestand;
        private System.Windows.Forms.TextBox txtKundeName;
        private System.Windows.Forms.TextBox txtParfümNummer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerkaufsID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGesamtPreis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNormalPreis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lbVorschläge;
    }
}