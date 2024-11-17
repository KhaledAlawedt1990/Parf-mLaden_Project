namespace Parfüm2025
{
    partial class frmLogginScreen
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
            this.gbAnmeldeDaten = new System.Windows.Forms.GroupBox();
            this.btnEinloggen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAnmeldeDaten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAnmeldeDaten
            // 
            this.gbAnmeldeDaten.Controls.Add(this.btnSchliessen);
            this.gbAnmeldeDaten.Controls.Add(this.btnEinloggen);
            this.gbAnmeldeDaten.Controls.Add(this.label2);
            this.gbAnmeldeDaten.Controls.Add(this.label1);
            this.gbAnmeldeDaten.Controls.Add(this.txtPasswort);
            this.gbAnmeldeDaten.Controls.Add(this.txtUsername);
            this.gbAnmeldeDaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnmeldeDaten.Location = new System.Drawing.Point(408, 26);
            this.gbAnmeldeDaten.Name = "gbAnmeldeDaten";
            this.gbAnmeldeDaten.Size = new System.Drawing.Size(240, 398);
            this.gbAnmeldeDaten.TabIndex = 3;
            this.gbAnmeldeDaten.TabStop = false;
            this.gbAnmeldeDaten.Text = "Anmeldedaten";
            // 
            // btnEinloggen
            // 
            this.btnEinloggen.Location = new System.Drawing.Point(20, 287);
            this.btnEinloggen.Name = "btnEinloggen";
            this.btnEinloggen.Size = new System.Drawing.Size(198, 32);
            this.btnEinloggen.TabIndex = 4;
            this.btnEinloggen.Text = "Einloggen";
            this.btnEinloggen.UseVisualStyleBackColor = true;
            this.btnEinloggen.Click += new System.EventHandler(this.btnEinloggen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User name:";
            // 
            // txtPasswort
            // 
            this.txtPasswort.Location = new System.Drawing.Point(20, 168);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(198, 26);
            this.txtPasswort.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(20, 94);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(198, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources.pexels_anis_salmani_208342252_11711830;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(20, 334);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(198, 32);
            this.btnSchliessen.TabIndex = 5;
            this.btnSchliessen.Text = "Schließen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbAnmeldeDaten);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogginScreen";
            this.Text = "LogginScreen";
            this.gbAnmeldeDaten.ResumeLayout(false);
            this.gbAnmeldeDaten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnmeldeDaten;
        private System.Windows.Forms.Button btnEinloggen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSchliessen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}