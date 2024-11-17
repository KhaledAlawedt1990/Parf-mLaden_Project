namespace Parfüm2025
{
    partial class frmAddUpdateNeueKunde
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
            this.gbKunde = new System.Windows.Forms.GroupBox();
            this.chbIstAktive = new System.Windows.Forms.CheckBox();
            this.dtpRegestriertAm = new System.Windows.Forms.DateTimePicker();
            this.txtFirmaName = new System.Windows.Forms.TextBox();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.txtKundeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrAddUpdatePerson1 = new Parfüm2025.ctrAddUpdatePerson();
            this.gbKunde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKunde
            // 
            this.gbKunde.Controls.Add(this.chbIstAktive);
            this.gbKunde.Controls.Add(this.dtpRegestriertAm);
            this.gbKunde.Controls.Add(this.txtFirmaName);
            this.gbKunde.Controls.Add(this.txtPersonID);
            this.gbKunde.Controls.Add(this.txtKundeID);
            this.gbKunde.Controls.Add(this.label5);
            this.gbKunde.Controls.Add(this.label4);
            this.gbKunde.Controls.Add(this.label3);
            this.gbKunde.Controls.Add(this.label2);
            this.gbKunde.Controls.Add(this.label1);
            this.gbKunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbKunde.Location = new System.Drawing.Point(39, 601);
            this.gbKunde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKunde.Name = "gbKunde";
            this.gbKunde.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKunde.Size = new System.Drawing.Size(865, 256);
            this.gbKunde.TabIndex = 6;
            this.gbKunde.TabStop = false;
            this.gbKunde.Text = "Kundedaten";
            // 
            // chbIstAktive
            // 
            this.chbIstAktive.AutoSize = true;
            this.chbIstAktive.Checked = true;
            this.chbIstAktive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIstAktive.Location = new System.Drawing.Point(135, 208);
            this.chbIstAktive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbIstAktive.Name = "chbIstAktive";
            this.chbIstAktive.Size = new System.Drawing.Size(88, 29);
            this.chbIstAktive.TabIndex = 9;
            this.chbIstAktive.Text = "Aktive";
            this.chbIstAktive.UseVisualStyleBackColor = true;
            this.chbIstAktive.CheckedChanged += new System.EventHandler(this.chbIstAktive_CheckedChanged);
            // 
            // dtpRegestriertAm
            // 
            this.dtpRegestriertAm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegestriertAm.Location = new System.Drawing.Point(449, 154);
            this.dtpRegestriertAm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpRegestriertAm.Name = "dtpRegestriertAm";
            this.dtpRegestriertAm.Size = new System.Drawing.Size(371, 30);
            this.dtpRegestriertAm.TabIndex = 8;
            // 
            // txtFirmaName
            // 
            this.txtFirmaName.Location = new System.Drawing.Point(27, 154);
            this.txtFirmaName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirmaName.MaxLength = 50;
            this.txtFirmaName.Name = "txtFirmaName";
            this.txtFirmaName.Size = new System.Drawing.Size(361, 30);
            this.txtFirmaName.TabIndex = 7;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(449, 78);
            this.txtPersonID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.ReadOnly = true;
            this.txtPersonID.Size = new System.Drawing.Size(371, 30);
            this.txtPersonID.TabIndex = 6;
            this.txtPersonID.Text = "-1";
            // 
            // txtKundeID
            // 
            this.txtKundeID.Location = new System.Drawing.Point(27, 78);
            this.txtKundeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKundeID.Name = "txtKundeID";
            this.txtKundeID.ReadOnly = true;
            this.txtKundeID.Size = new System.Drawing.Size(361, 30);
            this.txtKundeID.TabIndex = 5;
            this.txtKundeID.Text = "-1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "istAktive:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "regestriertAm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "firmaName:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "personID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "kundeID:";
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbbrechen.Location = new System.Drawing.Point(539, 878);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(320, 47);
            this.btnAbbrechen.TabIndex = 5;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            this.btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichern.Location = new System.Drawing.Point(39, 878);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(320, 47);
            this.btnSpeichern.TabIndex = 4;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrAddUpdatePerson1
            // 
            this.ctrAddUpdatePerson1.Location = new System.Drawing.Point(16, 15);
            this.ctrAddUpdatePerson1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrAddUpdatePerson1.Name = "ctrAddUpdatePerson1";
            this.ctrAddUpdatePerson1.Size = new System.Drawing.Size(888, 577);
            this.ctrAddUpdatePerson1.TabIndex = 10;
            this.ctrAddUpdatePerson1.OnSelectedPerson += new System.Action<int>(this.ctrAddUpdatePerson1_OnSelectedPerson);
            // 
            // frmAddUpdateNeueKunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 928);
            this.Controls.Add(this.ctrAddUpdatePerson1);
            this.Controls.Add(this.gbKunde);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddUpdateNeueKunde";
            this.Text = "frmAddUpdateNeueKunde";
            this.Load += new System.EventHandler(this.frmAddUpdateNeueKunde_Load);
            this.gbKunde.ResumeLayout(false);
            this.gbKunde.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKunde;
        private ctrAddUpdatePerson ctrAddUpdatePerson1;
        private System.Windows.Forms.CheckBox chbIstAktive;
        private System.Windows.Forms.DateTimePicker dtpRegestriertAm;
        private System.Windows.Forms.TextBox txtFirmaName;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.TextBox txtKundeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}