namespace Projekti_KNK
{
    partial class Forma_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Student));
            this.btnParaqit = new System.Windows.Forms.Button();
            this.btn_transkripti = new System.Windows.Forms.Button();
            this.sts_S = new System.Windows.Forms.StatusStrip();
            this.tss_PS = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_Student = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNotaMesatare = new System.Windows.Forms.TextBox();
            this.lbl_NM = new System.Windows.Forms.Label();
            this.dgvTranskripta = new System.Windows.Forms.DataGridView();
            this.txtKerkLendet = new System.Windows.Forms.TextBox();
            this.lbl_Pastro = new System.Windows.Forms.Label();
            this.btn_Ruaj = new System.Windows.Forms.Button();
            this.lbl_ProfP = new System.Windows.Forms.Label();
            this.lbl_LendaP = new System.Windows.Forms.Label();
            this.cboProfesori = new System.Windows.Forms.ComboBox();
            this.cboLenda = new System.Windows.Forms.ComboBox();
            this.lbl_ParaqitM = new System.Windows.Forms.Label();
            this.btn_Pastro = new System.Windows.Forms.Button();
            this.btn_Grafika = new System.Windows.Forms.Button();
            this.pib_Grafika = new System.Windows.Forms.PictureBox();
            this.lblShkyqu = new System.Windows.Forms.Label();
            this.sts_S.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranskripta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_Grafika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParaqit
            // 
            this.btnParaqit.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaqit.Image = global::Projekti_KNK.Properties.Resources._1463883908_vector_66_08;
            this.btnParaqit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParaqit.Location = new System.Drawing.Point(11, 39);
            this.btnParaqit.Name = "btnParaqit";
            this.btnParaqit.Size = new System.Drawing.Size(133, 152);
            this.btnParaqit.TabIndex = 0;
            this.btnParaqit.Text = "Paraqit Provimet";
            this.btnParaqit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnParaqit.UseVisualStyleBackColor = true;
            this.btnParaqit.Click += new System.EventHandler(this.btnParaqit_Click);
            // 
            // btn_transkripti
            // 
            this.btn_transkripti.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transkripti.Image = global::Projekti_KNK.Properties.Resources._1463883944_file_bookmark;
            this.btn_transkripti.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_transkripti.Location = new System.Drawing.Point(11, 201);
            this.btn_transkripti.Name = "btn_transkripti";
            this.btn_transkripti.Size = new System.Drawing.Size(133, 152);
            this.btn_transkripti.TabIndex = 1;
            this.btn_transkripti.Text = "Transkripta e Notave";
            this.btn_transkripti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_transkripti.UseVisualStyleBackColor = true;
            this.btn_transkripti.Click += new System.EventHandler(this.btn_transkripti_Click);
            // 
            // sts_S
            // 
            this.sts_S.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_PS,
            this.tss_Student});
            this.sts_S.Location = new System.Drawing.Point(0, 464);
            this.sts_S.Name = "sts_S";
            this.sts_S.Size = new System.Drawing.Size(959, 24);
            this.sts_S.TabIndex = 3;
            this.sts_S.Text = "StatusStrip";
            // 
            // tss_PS
            // 
            this.tss_PS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tss_PS.Name = "tss_PS";
            this.tss_PS.Size = new System.Drawing.Size(70, 19);
            this.tss_PS.Text = "Perdorusi:";
            // 
            // tss_Student
            // 
            this.tss_Student.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tss_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tss_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tss_Student.Name = "tss_Student";
            this.tss_Student.Size = new System.Drawing.Size(53, 19);
            this.tss_Student.Text = "Student";
            // 
            // txtNotaMesatare
            // 
            this.txtNotaMesatare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotaMesatare.Enabled = false;
            this.txtNotaMesatare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaMesatare.Location = new System.Drawing.Point(150, 432);
            this.txtNotaMesatare.Name = "txtNotaMesatare";
            this.txtNotaMesatare.Size = new System.Drawing.Size(797, 26);
            this.txtNotaMesatare.TabIndex = 14;
            // 
            // lbl_NM
            // 
            this.lbl_NM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_NM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NM.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_NM.Image = global::Projekti_KNK.Properties.Resources.minimalistic_textures_simple_www_wall321_com_84;
            this.lbl_NM.Location = new System.Drawing.Point(12, 432);
            this.lbl_NM.Name = "lbl_NM";
            this.lbl_NM.Size = new System.Drawing.Size(132, 26);
            this.lbl_NM.TabIndex = 21;
            this.lbl_NM.Text = "Nota Mesatare:";
            this.lbl_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTranskripta
            // 
            this.dgvTranskripta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTranskripta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranskripta.Location = new System.Drawing.Point(156, 36);
            this.dgvTranskripta.Name = "dgvTranskripta";
            this.dgvTranskripta.Size = new System.Drawing.Size(790, 385);
            this.dgvTranskripta.TabIndex = 11;
            // 
            // txtKerkLendet
            // 
            this.txtKerkLendet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKerkLendet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerkLendet.Location = new System.Drawing.Point(150, 7);
            this.txtKerkLendet.Name = "txtKerkLendet";
            this.txtKerkLendet.Size = new System.Drawing.Size(553, 26);
            this.txtKerkLendet.TabIndex = 13;
            // 
            // lbl_Pastro
            // 
            this.lbl_Pastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pastro.Location = new System.Drawing.Point(887, 464);
            this.lbl_Pastro.Name = "lbl_Pastro";
            this.lbl_Pastro.Size = new System.Drawing.Size(60, 22);
            this.lbl_Pastro.TabIndex = 4;
            this.lbl_Pastro.Text = "Pastro";
            this.lbl_Pastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Pastro.Click += new System.EventHandler(this.lbl_Pastro_Click);
            // 
            // btn_Ruaj
            // 
            this.btn_Ruaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ruaj.Location = new System.Drawing.Point(305, 107);
            this.btn_Ruaj.Name = "btn_Ruaj";
            this.btn_Ruaj.Size = new System.Drawing.Size(86, 38);
            this.btn_Ruaj.TabIndex = 9;
            this.btn_Ruaj.Text = "Ruaj";
            this.btn_Ruaj.UseVisualStyleBackColor = true;
            this.btn_Ruaj.Click += new System.EventHandler(this.btn_Ruaj_Click);
            // 
            // lbl_ProfP
            // 
            this.lbl_ProfP.AutoSize = true;
            this.lbl_ProfP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProfP.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_ProfP.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ProfP.Image")));
            this.lbl_ProfP.Location = new System.Drawing.Point(162, 79);
            this.lbl_ProfP.Name = "lbl_ProfP";
            this.lbl_ProfP.Size = new System.Drawing.Size(86, 20);
            this.lbl_ProfP.TabIndex = 7;
            this.lbl_ProfP.Text = "Profesori:";
            // 
            // lbl_LendaP
            // 
            this.lbl_LendaP.AutoSize = true;
            this.lbl_LendaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LendaP.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_LendaP.Image = ((System.Drawing.Image)(resources.GetObject("lbl_LendaP.Image")));
            this.lbl_LendaP.Location = new System.Drawing.Point(162, 42);
            this.lbl_LendaP.Name = "lbl_LendaP";
            this.lbl_LendaP.Size = new System.Drawing.Size(64, 20);
            this.lbl_LendaP.TabIndex = 5;
            this.lbl_LendaP.Text = "Lenda:";
            // 
            // cboProfesori
            // 
            this.cboProfesori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProfesori.Location = new System.Drawing.Point(263, 73);
            this.cboProfesori.Name = "cboProfesori";
            this.cboProfesori.Size = new System.Drawing.Size(220, 28);
            this.cboProfesori.TabIndex = 8;
            // 
            // cboLenda
            // 
            this.cboLenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLenda.FormattingEnabled = true;
            this.cboLenda.Location = new System.Drawing.Point(263, 39);
            this.cboLenda.Name = "cboLenda";
            this.cboLenda.Size = new System.Drawing.Size(220, 28);
            this.cboLenda.TabIndex = 6;
            this.cboLenda.SelectedIndexChanged += new System.EventHandler(this.cboLenda_SelectedIndexChanged);
            // 
            // lbl_ParaqitM
            // 
            this.lbl_ParaqitM.AutoSize = true;
            this.lbl_ParaqitM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ParaqitM.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_ParaqitM.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ParaqitM.Image")));
            this.lbl_ParaqitM.Location = new System.Drawing.Point(150, 184);
            this.lbl_ParaqitM.Name = "lbl_ParaqitM";
            this.lbl_ParaqitM.Size = new System.Drawing.Size(0, 20);
            this.lbl_ParaqitM.TabIndex = 12;
            // 
            // btn_Pastro
            // 
            this.btn_Pastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pastro.Location = new System.Drawing.Point(397, 107);
            this.btn_Pastro.Name = "btn_Pastro";
            this.btn_Pastro.Size = new System.Drawing.Size(86, 38);
            this.btn_Pastro.TabIndex = 10;
            this.btn_Pastro.Text = "Pastro";
            this.btn_Pastro.UseVisualStyleBackColor = true;
            this.btn_Pastro.Click += new System.EventHandler(this.btnAnulo_Click);
            // 
            // btn_Grafika
            // 
            this.btn_Grafika.Location = new System.Drawing.Point(11, 359);
            this.btn_Grafika.Name = "btn_Grafika";
            this.btn_Grafika.Size = new System.Drawing.Size(133, 57);
            this.btn_Grafika.TabIndex = 2;
            this.btn_Grafika.Text = "Grafika e Notave";
            this.btn_Grafika.Click += new System.EventHandler(this.btn_Grafika_Click);
            // 
            // pib_Grafika
            // 
            this.pib_Grafika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pib_Grafika.Location = new System.Drawing.Point(156, 39);
            this.pib_Grafika.Name = "pib_Grafika";
            this.pib_Grafika.Size = new System.Drawing.Size(796, 380);
            this.pib_Grafika.TabIndex = 34;
            this.pib_Grafika.TabStop = false;
            this.pib_Grafika.Paint += new System.Windows.Forms.PaintEventHandler(this.pib_Grafika_Paint);
            // 
            // lblShkyqu
            // 
            this.lblShkyqu.AutoSize = true;
            this.lblShkyqu.Location = new System.Drawing.Point(887, 15);
            this.lblShkyqu.Name = "lblShkyqu";
            this.lblShkyqu.Size = new System.Drawing.Size(43, 13);
            this.lblShkyqu.TabIndex = 35;
            this.lblShkyqu.Text = "Shkyqu";
            this.lblShkyqu.Click += new System.EventHandler(this.lblShkyqu_Click);
            // 
            // Forma_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekti_KNK.Properties.Resources.minimalistic_textures_simple_www_wall321_com_84;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 488);
            this.Controls.Add(this.lblShkyqu);
            this.Controls.Add(this.pib_Grafika);
            this.Controls.Add(this.btn_Grafika);
            this.Controls.Add(this.btn_Pastro);
            this.Controls.Add(this.lbl_ParaqitM);
            this.Controls.Add(this.btn_Ruaj);
            this.Controls.Add(this.lbl_ProfP);
            this.Controls.Add(this.lbl_LendaP);
            this.Controls.Add(this.cboProfesori);
            this.Controls.Add(this.cboLenda);
            this.Controls.Add(this.lbl_Pastro);
            this.Controls.Add(this.txtNotaMesatare);
            this.Controls.Add(this.lbl_NM);
            this.Controls.Add(this.dgvTranskripta);
            this.Controls.Add(this.txtKerkLendet);
            this.Controls.Add(this.sts_S);
            this.Controls.Add(this.btn_transkripti);
            this.Controls.Add(this.btnParaqit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forma_Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Forma_Student_Load);
            this.sts_S.ResumeLayout(false);
            this.sts_S.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranskripta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pib_Grafika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParaqit;
        private System.Windows.Forms.Button btn_transkripti;
        private System.Windows.Forms.StatusStrip sts_S;
        private System.Windows.Forms.ToolStripStatusLabel tss_PS;
        private System.Windows.Forms.ToolStripStatusLabel tss_Student;
        private System.Windows.Forms.TextBox txtNotaMesatare;
        private System.Windows.Forms.Label lbl_NM;
        private System.Windows.Forms.DataGridView dgvTranskripta;
        private System.Windows.Forms.TextBox txtKerkLendet;
        private System.Windows.Forms.Label lbl_Pastro;
        private System.Windows.Forms.Button btn_Ruaj;
        private System.Windows.Forms.Label lbl_ProfP;
        private System.Windows.Forms.Label lbl_LendaP;
        private System.Windows.Forms.ComboBox cboProfesori;
        private System.Windows.Forms.ComboBox cboLenda;
        private System.Windows.Forms.Label lbl_ParaqitM;
        private System.Windows.Forms.Button btn_Pastro;
        private System.Windows.Forms.Button btn_Grafika;
        private System.Windows.Forms.PictureBox pib_Grafika;
        private System.Windows.Forms.Label lblShkyqu;
    }
}