namespace Projekti_KNK
{
    partial class Forma_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Admin));
            this.btnSh_Admin = new System.Windows.Forms.Button();
            this.sts_A = new System.Windows.Forms.StatusStrip();
            this.tss_PA = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_Administrator = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsm_Regjistrimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Regjistrimi_S = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Regjistrimi_P = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Regjistrimi_A = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Regjistrimi_D = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Regjistrimi_L = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Regjistrimi_LeRE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PercaktoProf = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Lista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Lista_S = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Lista_P = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Lista_A = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Lista_D = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Lista_L = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Lista_lL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Lista_lP = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_MA = new System.Windows.Forms.Label();
            this.lbl_EA = new System.Windows.Forms.Label();
            this.lbl_Eadmin = new System.Windows.Forms.Label();
            this.lbl_Madmin = new System.Windows.Forms.Label();
            this.lbl_Pastro = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblShkyqu = new System.Windows.Forms.Label();
            this.sts_A.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSh_Admin
            // 
            this.btnSh_Admin.Location = new System.Drawing.Point(12, 12);
            this.btnSh_Admin.Name = "btnSh_Admin";
            this.btnSh_Admin.Size = new System.Drawing.Size(156, 23);
            this.btnSh_Admin.TabIndex = 1;
            this.btnSh_Admin.Text = "Shto Admin";
            this.btnSh_Admin.UseVisualStyleBackColor = true;
            // 
            // sts_A
            // 
            this.sts_A.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sts_A.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_PA,
            this.tss_Administrator});
            this.sts_A.Location = new System.Drawing.Point(0, 388);
            this.sts_A.Name = "sts_A";
            this.sts_A.Size = new System.Drawing.Size(685, 24);
            this.sts_A.TabIndex = 9;
            this.sts_A.Text = "StatusStrip";
            // 
            // tss_PA
            // 
            this.tss_PA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tss_PA.Name = "tss_PA";
            this.tss_PA.Size = new System.Drawing.Size(70, 19);
            this.tss_PA.Text = "Perdorusi:";
            // 
            // tss_Administrator
            // 
            this.tss_Administrator.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tss_Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tss_Administrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tss_Administrator.Name = "tss_Administrator";
            this.tss_Administrator.Size = new System.Drawing.Size(86, 19);
            this.tss_Administrator.Text = "Administrator";
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Regjistrimi,
            this.tsm_Lista});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(685, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // tsm_Regjistrimi
            // 
            this.tsm_Regjistrimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Regjistrimi_S,
            this.tsm_Regjistrimi_P,
            this.tsm_Regjistrimi_A,
            this.tsm_Regjistrimi_D,
            this.tsm_Regjistrimi_L});
            this.tsm_Regjistrimi.Name = "tsm_Regjistrimi";
            this.tsm_Regjistrimi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsm_Regjistrimi.Size = new System.Drawing.Size(65, 34);
            this.tsm_Regjistrimi.Text = "&Regjistro";
            // 
            // tsm_Regjistrimi_S
            // 
            this.tsm_Regjistrimi_S.Name = "tsm_Regjistrimi_S";
            this.tsm_Regjistrimi_S.Size = new System.Drawing.Size(147, 22);
            this.tsm_Regjistrimi_S.Text = "Student";
            this.tsm_Regjistrimi_S.Click += new System.EventHandler(this.tsm_Regjistrimi_S_Click);
            // 
            // tsm_Regjistrimi_P
            // 
            this.tsm_Regjistrimi_P.Name = "tsm_Regjistrimi_P";
            this.tsm_Regjistrimi_P.Size = new System.Drawing.Size(147, 22);
            this.tsm_Regjistrimi_P.Text = "Profesor";
            this.tsm_Regjistrimi_P.Click += new System.EventHandler(this.tsm_Regjistrimi_P_Click);
            // 
            // tsm_Regjistrimi_A
            // 
            this.tsm_Regjistrimi_A.Name = "tsm_Regjistrimi_A";
            this.tsm_Regjistrimi_A.Size = new System.Drawing.Size(147, 22);
            this.tsm_Regjistrimi_A.Text = "Administrator";
            this.tsm_Regjistrimi_A.Click += new System.EventHandler(this.tsm_Regjistrimi_A_Click);
            // 
            // tsm_Regjistrimi_D
            // 
            this.tsm_Regjistrimi_D.Name = "tsm_Regjistrimi_D";
            this.tsm_Regjistrimi_D.Size = new System.Drawing.Size(147, 22);
            this.tsm_Regjistrimi_D.Text = "Drejtimi";
            this.tsm_Regjistrimi_D.Click += new System.EventHandler(this.tsm_Regjistrimi_D_Click);
            // 
            // tsm_Regjistrimi_L
            // 
            this.tsm_Regjistrimi_L.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Regjistrimi_LeRE,
            this.tsm_PercaktoProf});
            this.tsm_Regjistrimi_L.Name = "tsm_Regjistrimi_L";
            this.tsm_Regjistrimi_L.Size = new System.Drawing.Size(147, 22);
            this.tsm_Regjistrimi_L.Text = "Lënda";
            // 
            // tsm_Regjistrimi_LeRE
            // 
            this.tsm_Regjistrimi_LeRE.Name = "tsm_Regjistrimi_LeRE";
            this.tsm_Regjistrimi_LeRE.Size = new System.Drawing.Size(177, 22);
            this.tsm_Regjistrimi_LeRE.Text = "Lënda e re";
            this.tsm_Regjistrimi_LeRE.Click += new System.EventHandler(this.tsm_Regjistrimi_LeRE_Click);
            // 
            // tsm_PercaktoProf
            // 
            this.tsm_PercaktoProf.Name = "tsm_PercaktoProf";
            this.tsm_PercaktoProf.Size = new System.Drawing.Size(177, 22);
            this.tsm_PercaktoProf.Text = "Përcakto Profesorin";
            this.tsm_PercaktoProf.Click += new System.EventHandler(this.tsm_PercaktoProf_Click);
            // 
            // tsm_Lista
            // 
            this.tsm_Lista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Lista_S,
            this.tsm_Lista_P,
            this.tsm_Lista_A,
            this.tsm_Lista_D,
            this.tsm_Lista_L});
            this.tsm_Lista.Name = "tsm_Lista";
            this.tsm_Lista.Size = new System.Drawing.Size(43, 34);
            this.tsm_Lista.Text = "&Lista";
            // 
            // tsm_Lista_S
            // 
            this.tsm_Lista_S.Name = "tsm_Lista_S";
            this.tsm_Lista_S.Size = new System.Drawing.Size(147, 22);
            this.tsm_Lista_S.Text = "Student";
            this.tsm_Lista_S.Click += new System.EventHandler(this.tsm_Lista_S_Click);
            // 
            // tsm_Lista_P
            // 
            this.tsm_Lista_P.Name = "tsm_Lista_P";
            this.tsm_Lista_P.Size = new System.Drawing.Size(147, 22);
            this.tsm_Lista_P.Text = "Profesor";
            this.tsm_Lista_P.Click += new System.EventHandler(this.tsm_Lista_P_Click);
            // 
            // tsm_Lista_A
            // 
            this.tsm_Lista_A.Name = "tsm_Lista_A";
            this.tsm_Lista_A.Size = new System.Drawing.Size(147, 22);
            this.tsm_Lista_A.Text = "Administrator";
            this.tsm_Lista_A.Click += new System.EventHandler(this.tsm_Lista_A_Click);
            // 
            // tsm_Lista_D
            // 
            this.tsm_Lista_D.Name = "tsm_Lista_D";
            this.tsm_Lista_D.Size = new System.Drawing.Size(147, 22);
            this.tsm_Lista_D.Text = "Drejtim";
            this.tsm_Lista_D.Click += new System.EventHandler(this.tsm_Lista_D_Click);
            // 
            // tsm_Lista_L
            // 
            this.tsm_Lista_L.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Lista_lL,
            this.tsm_Lista_lP});
            this.tsm_Lista_L.Name = "tsm_Lista_L";
            this.tsm_Lista_L.Size = new System.Drawing.Size(147, 22);
            this.tsm_Lista_L.Text = "Lënda";
            // 
            // tsm_Lista_lL
            // 
            this.tsm_Lista_lL.Name = "tsm_Lista_lL";
            this.tsm_Lista_lL.Size = new System.Drawing.Size(145, 22);
            this.tsm_Lista_lL.Text = "Lista Lëndve";
            this.tsm_Lista_lL.Click += new System.EventHandler(this.tsm_Lista_lL_Click);
            // 
            // tsm_Lista_lP
            // 
            this.tsm_Lista_lP.Name = "tsm_Lista_lP";
            this.tsm_Lista_lP.Size = new System.Drawing.Size(145, 22);
            this.tsm_Lista_lP.Text = "Lista Profesor";
            this.tsm_Lista_lP.Click += new System.EventHandler(this.tsm_Lista_lP_Click);
            // 
            // lbl_MA
            // 
            this.lbl_MA.AutoSize = true;
            this.lbl_MA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_MA.Image = ((System.Drawing.Image)(resources.GetObject("lbl_MA.Image")));
            this.lbl_MA.Location = new System.Drawing.Point(12, 112);
            this.lbl_MA.Name = "lbl_MA";
            this.lbl_MA.Size = new System.Drawing.Size(76, 20);
            this.lbl_MA.TabIndex = 7;
            this.lbl_MA.Text = "Mbiemri:";
            // 
            // lbl_EA
            // 
            this.lbl_EA.AutoSize = true;
            this.lbl_EA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_EA.Image = ((System.Drawing.Image)(resources.GetObject("lbl_EA.Image")));
            this.lbl_EA.Location = new System.Drawing.Point(12, 81);
            this.lbl_EA.Name = "lbl_EA";
            this.lbl_EA.Size = new System.Drawing.Size(50, 20);
            this.lbl_EA.TabIndex = 5;
            this.lbl_EA.Text = "Emri:";
            // 
            // lbl_Eadmin
            // 
            this.lbl_Eadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eadmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Eadmin.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Eadmin.Image")));
            this.lbl_Eadmin.Location = new System.Drawing.Point(116, 81);
            this.lbl_Eadmin.Name = "lbl_Eadmin";
            this.lbl_Eadmin.Size = new System.Drawing.Size(240, 20);
            this.lbl_Eadmin.TabIndex = 6;
            // 
            // lbl_Madmin
            // 
            this.lbl_Madmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Madmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Madmin.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Madmin.Image")));
            this.lbl_Madmin.Location = new System.Drawing.Point(116, 112);
            this.lbl_Madmin.Name = "lbl_Madmin";
            this.lbl_Madmin.Size = new System.Drawing.Size(240, 20);
            this.lbl_Madmin.TabIndex = 8;
            // 
            // lbl_Pastro
            // 
            this.lbl_Pastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Pastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pastro.Location = new System.Drawing.Point(622, 388);
            this.lbl_Pastro.Name = "lbl_Pastro";
            this.lbl_Pastro.Size = new System.Drawing.Size(60, 22);
            this.lbl_Pastro.TabIndex = 10;
            this.lbl_Pastro.Text = "Pastro";
            this.lbl_Pastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Pastro.Click += new System.EventHandler(this.lbl_Pastro_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Enabled = false;
            this.dgv.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv.Location = new System.Drawing.Point(0, 41);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(685, 344);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lblShkyqu
            // 
            this.lblShkyqu.AutoSize = true;
            this.lblShkyqu.Location = new System.Drawing.Point(630, 13);
            this.lblShkyqu.Name = "lblShkyqu";
            this.lblShkyqu.Size = new System.Drawing.Size(43, 13);
            this.lblShkyqu.TabIndex = 37;
            this.lblShkyqu.Text = "Shkyqu";
            this.lblShkyqu.Click += new System.EventHandler(this.lblShkyqu_Click);
            // 
            // Forma_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Projekti_KNK.Properties.Resources.minimalistic_textures_simple_www_wall321_com_84;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.lblShkyqu);
            this.Controls.Add(this.lbl_Pastro);
            this.Controls.Add(this.lbl_Madmin);
            this.Controls.Add(this.lbl_Eadmin);
            this.Controls.Add(this.lbl_MA);
            this.Controls.Add(this.lbl_EA);
            this.Controls.Add(this.sts_A);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnSh_Admin);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forma_Admin";
            this.Text = "Administratori";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Forma_Admin_Load);
            this.sts_A.ResumeLayout(false);
            this.sts_A.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSh_Admin;
        private System.Windows.Forms.StatusStrip sts_A;
        private System.Windows.Forms.ToolStripStatusLabel tss_PA;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_Regjistrimi;
        private System.Windows.Forms.ToolStripMenuItem tsm_Regjistrimi_S;
        private System.Windows.Forms.ToolStripMenuItem tsm_Regjistrimi_P;
        private System.Windows.Forms.ToolStripMenuItem tsm_Regjistrimi_A;
        private System.Windows.Forms.ToolStripMenuItem tsm_Lista;
        private System.Windows.Forms.ToolStripMenuItem tsm_Lista_S;
        private System.Windows.Forms.ToolStripMenuItem tsm_Lista_P;
        private System.Windows.Forms.ToolStripMenuItem tsm_Lista_D;
        private System.Windows.Forms.ToolStripStatusLabel tss_Administrator;
        private System.Windows.Forms.ToolStripMenuItem tsm_Regjistrimi_D;
        private System.Windows.Forms.ToolStripMenuItem tsm_Regjistrimi_L;
        private System.Windows.Forms.ToolStripMenuItem tsm_Lista_L;
        private System.Windows.Forms.ToolStripMenuItem tsm_Lista_A;
        private System.Windows.Forms.Label lbl_MA;
        private System.Windows.Forms.Label lbl_EA;
        private System.Windows.Forms.Label lbl_Eadmin;
        private System.Windows.Forms.Label lbl_Madmin;
        private System.Windows.Forms.Label lbl_Pastro;
        private System.Windows.Forms.ToolStripMenuItem tsm_Regjistrimi_LeRE;
        private System.Windows.Forms.ToolStripMenuItem tsm_PercaktoProf;
        private System.Windows.Forms.ToolStripMenuItem tsm_Lista_lL;
        private System.Windows.Forms.ToolStripMenuItem tsm_Lista_lP;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblShkyqu;
    }
}