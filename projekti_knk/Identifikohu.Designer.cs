namespace Projekti_KNK
{
    partial class Identifikohu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Identifikohu));
            this.txtFjalkalimi = new System.Windows.Forms.TextBox();
            this.txtPerdorusi = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btnAnulo = new System.Windows.Forms.Button();
            this.btnRuaje = new System.Windows.Forms.Button();
            this.tmrSekonda = new System.Windows.Forms.Timer(this.components);
            this.tmrMinuta = new System.Windows.Forms.Timer(this.components);
            this.tmrOra = new System.Windows.Forms.Timer(this.components);
            this.rdbSHQIP = new System.Windows.Forms.RadioButton();
            this.rdbAnglisht = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFjalkalimi
            // 
            this.txtFjalkalimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFjalkalimi.Location = new System.Drawing.Point(127, 379);
            this.txtFjalkalimi.Name = "txtFjalkalimi";
            this.txtFjalkalimi.PasswordChar = '*';
            this.txtFjalkalimi.Size = new System.Drawing.Size(293, 26);
            this.txtFjalkalimi.TabIndex = 5;
            // 
            // txtPerdorusi
            // 
            this.txtPerdorusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerdorusi.Location = new System.Drawing.Point(127, 351);
            this.txtPerdorusi.Name = "txtPerdorusi";
            this.txtPerdorusi.Size = new System.Drawing.Size(293, 26);
            this.txtPerdorusi.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 382);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Fjalkalimi:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(12, 351);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(90, 20);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "Përdorusi:";
            // 
            // btnAnulo
            // 
            this.btnAnulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnulo.Location = new System.Drawing.Point(326, 411);
            this.btnAnulo.Name = "btnAnulo";
            this.btnAnulo.Size = new System.Drawing.Size(94, 38);
            this.btnAnulo.TabIndex = 7;
            this.btnAnulo.Text = "Anulo";
            this.btnAnulo.UseVisualStyleBackColor = true;
            // 
            // btnRuaje
            // 
            this.btnRuaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaje.Location = new System.Drawing.Point(222, 411);
            this.btnRuaje.Name = "btnRuaje";
            this.btnRuaje.Size = new System.Drawing.Size(98, 38);
            this.btnRuaje.TabIndex = 6;
            this.btnRuaje.Text = "Ruaje";
            this.btnRuaje.UseVisualStyleBackColor = true;
            this.btnRuaje.Click += new System.EventHandler(this.btnRuaje_Click);
            // 
            // tmrSekonda
            // 
            this.tmrSekonda.Enabled = true;
            this.tmrSekonda.Interval = 1000;
            this.tmrSekonda.Tick += new System.EventHandler(this.tmrSekonda_Tick);
            // 
            // tmrMinuta
            // 
            this.tmrMinuta.Enabled = true;
            this.tmrMinuta.Interval = 60000;
            this.tmrMinuta.Tick += new System.EventHandler(this.tmrMinuta_Tick);
            // 
            // tmrOra
            // 
            this.tmrOra.Enabled = true;
            this.tmrOra.Interval = 3600000;
            this.tmrOra.Tick += new System.EventHandler(this.tmrOra_Tick);
            // 
            // rdbSHQIP
            // 
            this.rdbSHQIP.AutoSize = true;
            this.rdbSHQIP.Checked = true;
            this.rdbSHQIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSHQIP.Location = new System.Drawing.Point(28, 159);
            this.rdbSHQIP.Name = "rdbSHQIP";
            this.rdbSHQIP.Size = new System.Drawing.Size(57, 17);
            this.rdbSHQIP.TabIndex = 0;
            this.rdbSHQIP.TabStop = true;
            this.rdbSHQIP.Text = "Shqip";
            this.rdbSHQIP.UseVisualStyleBackColor = true;
            this.rdbSHQIP.CheckedChanged += new System.EventHandler(this.rdbSHQIP_CheckedChanged);
            // 
            // rdbAnglisht
            // 
            this.rdbAnglisht.AutoSize = true;
            this.rdbAnglisht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnglisht.Location = new System.Drawing.Point(28, 182);
            this.rdbAnglisht.Name = "rdbAnglisht";
            this.rdbAnglisht.Size = new System.Drawing.Size(66, 17);
            this.rdbAnglisht.TabIndex = 1;
            this.rdbAnglisht.Text = "English";
            this.rdbAnglisht.UseVisualStyleBackColor = true;
            this.rdbAnglisht.CheckedChanged += new System.EventHandler(this.rdbAnglisht_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekti_KNK.Properties.Resources.SRS;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(28, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // Identifikohu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 464);
            this.Controls.Add(this.rdbAnglisht);
            this.Controls.Add(this.rdbSHQIP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAnulo);
            this.Controls.Add(this.btnRuaje);
            this.Controls.Add(this.txtFjalkalimi);
            this.Controls.Add(this.txtPerdorusi);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lbl_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Identifikohu";
            this.Text = "Identifikohu";
            this.Load += new System.EventHandler(this.Identifikohu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFjalkalimi;
        private System.Windows.Forms.TextBox txtPerdorusi;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btnAnulo;
        private System.Windows.Forms.Button btnRuaje;
        private System.Windows.Forms.Timer tmrSekonda;
        private System.Windows.Forms.Timer tmrMinuta;
        private System.Windows.Forms.Timer tmrOra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbSHQIP;
        private System.Windows.Forms.RadioButton rdbAnglisht;
    }
}