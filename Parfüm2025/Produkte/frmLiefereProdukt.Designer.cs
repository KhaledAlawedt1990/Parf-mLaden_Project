namespace Parfüm2025
{
    partial class frmLiefereProdukt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProduktName = new System.Windows.Forms.ComboBox();
            this.cbKunde = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbDezGeschäft = new System.Windows.Forms.RadioButton();
            this.txtTotoMenge = new System.Windows.Forms.TextBox();
            this.rbHauptGeschäft = new System.Windows.Forms.RadioButton();
            this.lblGelieferteMenge = new System.Windows.Forms.Label();
            this.txtGelieferteMenge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLiefern = new System.Windows.Forms.Button();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProduktName);
            this.groupBox1.Controls.Add(this.cbKunde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbDezGeschäft);
            this.groupBox1.Controls.Add(this.txtTotoMenge);
            this.groupBox1.Controls.Add(this.rbHauptGeschäft);
            this.groupBox1.Controls.Add(this.lblGelieferteMenge);
            this.groupBox1.Controls.Add(this.txtGelieferteMenge);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(472, 358);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkt Information";
            // 
            // cbProduktName
            // 
            this.cbProduktName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduktName.FormattingEnabled = true;
            this.cbProduktName.Location = new System.Drawing.Point(192, 44);
            this.cbProduktName.Name = "cbProduktName";
            this.cbProduktName.Size = new System.Drawing.Size(256, 33);
            this.cbProduktName.TabIndex = 59;
            this.cbProduktName.SelectedIndexChanged += new System.EventHandler(this.cbProduktName_SelectedIndexChanged);
            // 
            // cbKunde
            // 
            this.cbKunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKunde.FormattingEnabled = true;
            this.cbKunde.Location = new System.Drawing.Point(192, 169);
            this.cbKunde.Name = "cbKunde";
            this.cbKunde.Size = new System.Drawing.Size(256, 33);
            this.cbKunde.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(93, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Kunde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Produkt Name:";
            // 
            // rbDezGeschäft
            // 
            this.rbDezGeschäft.AutoSize = true;
            this.rbDezGeschäft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDezGeschäft.Location = new System.Drawing.Point(296, 297);
            this.rbDezGeschäft.Margin = new System.Windows.Forms.Padding(4);
            this.rbDezGeschäft.Name = "rbDezGeschäft";
            this.rbDezGeschäft.Size = new System.Drawing.Size(142, 28);
            this.rbDezGeschäft.TabIndex = 55;
            this.rbDezGeschäft.Text = "Dez Geschäft";
            this.rbDezGeschäft.UseVisualStyleBackColor = true;
            // 
            // txtTotoMenge
            // 
            this.txtTotoMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotoMenge.Location = new System.Drawing.Point(192, 225);
            this.txtTotoMenge.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotoMenge.Multiline = true;
            this.txtTotoMenge.Name = "txtTotoMenge";
            this.txtTotoMenge.ReadOnly = true;
            this.txtTotoMenge.Size = new System.Drawing.Size(256, 40);
            this.txtTotoMenge.TabIndex = 49;
            // 
            // rbHauptGeschäft
            // 
            this.rbHauptGeschäft.AutoSize = true;
            this.rbHauptGeschäft.Checked = true;
            this.rbHauptGeschäft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHauptGeschäft.Location = new System.Drawing.Point(64, 297);
            this.rbHauptGeschäft.Margin = new System.Windows.Forms.Padding(4);
            this.rbHauptGeschäft.Name = "rbHauptGeschäft";
            this.rbHauptGeschäft.Size = new System.Drawing.Size(159, 28);
            this.rbHauptGeschäft.TabIndex = 54;
            this.rbHauptGeschäft.TabStop = true;
            this.rbHauptGeschäft.Text = "Haupt Geschäft";
            this.rbHauptGeschäft.UseVisualStyleBackColor = true;
            // 
            // lblGelieferteMenge
            // 
            this.lblGelieferteMenge.AutoSize = true;
            this.lblGelieferteMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGelieferteMenge.ForeColor = System.Drawing.Color.Black;
            this.lblGelieferteMenge.Location = new System.Drawing.Point(7, 108);
            this.lblGelieferteMenge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGelieferteMenge.Name = "lblGelieferteMenge";
            this.lblGelieferteMenge.Size = new System.Drawing.Size(167, 25);
            this.lblGelieferteMenge.TabIndex = 51;
            this.lblGelieferteMenge.Text = "Gelieferte Menge:";
            // 
            // txtGelieferteMenge
            // 
            this.txtGelieferteMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGelieferteMenge.Location = new System.Drawing.Point(192, 105);
            this.txtGelieferteMenge.Margin = new System.Windows.Forms.Padding(4);
            this.txtGelieferteMenge.Multiline = true;
            this.txtGelieferteMenge.Name = "txtGelieferteMenge";
            this.txtGelieferteMenge.Size = new System.Drawing.Size(256, 40);
            this.txtGelieferteMenge.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(48, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "TotalMenge:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 53);
            this.panel1.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verkaufen";
            // 
            // btnLiefern
            // 
            this.btnLiefern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLiefern.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLiefern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiefern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiefern.ForeColor = System.Drawing.Color.White;
            this.btnLiefern.Location = new System.Drawing.Point(146, 442);
            this.btnLiefern.Margin = new System.Windows.Forms.Padding(4);
            this.btnLiefern.Name = "btnLiefern";
            this.btnLiefern.Size = new System.Drawing.Size(141, 49);
            this.btnLiefern.TabIndex = 60;
            this.btnLiefern.Text = "Liefen";
            this.btnLiefern.UseVisualStyleBackColor = false;
            this.btnLiefern.Click += new System.EventHandler(this.btnLiefern_Click);
            // 
            // btnSchließen
            // 
            this.btnSchließen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchließen.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSchließen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSchließen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchließen.ForeColor = System.Drawing.Color.White;
            this.btnSchließen.Location = new System.Drawing.Point(350, 442);
            this.btnSchließen.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(141, 49);
            this.btnSchließen.TabIndex = 61;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = false;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLiefereProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 504);
            this.Controls.Add(this.btnLiefern);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLiefereProdukt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liefere-Produkt";
            this.Load += new System.EventHandler(this.frmLiefereProdukt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDezGeschäft;
        private System.Windows.Forms.TextBox txtTotoMenge;
        private System.Windows.Forms.RadioButton rbHauptGeschäft;
        private System.Windows.Forms.TextBox txtGelieferteMenge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGelieferteMenge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLiefern;
        private System.Windows.Forms.Button btnSchließen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKunde;
        private System.Windows.Forms.ComboBox cbProduktName;
    }
}