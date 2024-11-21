namespace Parfüm2025
{
    partial class frmLagerListe
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
            this.dgvLager = new System.Windows.Forms.DataGridView();
            this.btnHinzufügeNeueMenge = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLager
            // 
            this.dgvLager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLager.Location = new System.Drawing.Point(24, 319);
            this.dgvLager.Name = "dgvLager";
            this.dgvLager.Size = new System.Drawing.Size(1040, 322);
            this.dgvLager.TabIndex = 1;
            // 
            // btnHinzufügeNeueMenge
            // 
            this.btnHinzufügeNeueMenge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHinzufügeNeueMenge.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHinzufügeNeueMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHinzufügeNeueMenge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHinzufügeNeueMenge.Location = new System.Drawing.Point(840, 273);
            this.btnHinzufügeNeueMenge.Name = "btnHinzufügeNeueMenge";
            this.btnHinzufügeNeueMenge.Size = new System.Drawing.Size(224, 40);
            this.btnHinzufügeNeueMenge.TabIndex = 2;
            this.btnHinzufügeNeueMenge.Text = "hinzufüge neue Menge";
            this.btnHinzufügeNeueMenge.UseVisualStyleBackColor = false;
            this.btnHinzufügeNeueMenge.Click += new System.EventHandler(this.btnHinzufügeNeueMenge_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Parfüm2025.Properties.Resources.store_869636;
            this.pictureBox1.Location = new System.Drawing.Point(189, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLagerListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1098, 669);
            this.Controls.Add(this.btnHinzufügeNeueMenge);
            this.Controls.Add(this.dgvLager);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLagerListe";
            this.Text = "frmLagerListe";
            this.Load += new System.EventHandler(this.frmLagerListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLager;
        private System.Windows.Forms.Button btnHinzufügeNeueMenge;
    }
}