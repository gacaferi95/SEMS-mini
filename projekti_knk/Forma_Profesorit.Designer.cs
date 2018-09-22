namespace Projekti_KNK
{
    partial class Forma_Profesorit
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
            this.pnlKontrolla = new System.Windows.Forms.Panel();
            this.lblShkyqu = new System.Windows.Forms.Label();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            this.cmsModifiko1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifikoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            this.cmsModifiko1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlKontrolla
            // 
            this.pnlKontrolla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKontrolla.BackgroundImage = global::Projekti_KNK.Properties.Resources.minimalistic_textures_simple_www_wall321_com_84;
            this.pnlKontrolla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlKontrolla.Location = new System.Drawing.Point(12, 59);
            this.pnlKontrolla.Name = "pnlKontrolla";
            this.pnlKontrolla.Size = new System.Drawing.Size(200, 384);
            this.pnlKontrolla.TabIndex = 18;
            // 
            // lblShkyqu
            // 
            this.lblShkyqu.AutoSize = true;
            this.lblShkyqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShkyqu.ForeColor = System.Drawing.Color.White;
            this.lblShkyqu.Image = global::Projekti_KNK.Properties.Resources.minimalistic_textures_simple_www_wall321_com_84;
            this.lblShkyqu.Location = new System.Drawing.Point(897, 21);
            this.lblShkyqu.Name = "lblShkyqu";
            this.lblShkyqu.Size = new System.Drawing.Size(53, 16);
            this.lblShkyqu.TabIndex = 36;
            this.lblShkyqu.Text = "Shkyqu";
            this.lblShkyqu.Click += new System.EventHandler(this.lblShkyqu_Click);
            // 
            // dgvNota
            // 
            this.dgvNota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Location = new System.Drawing.Point(218, 59);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.Size = new System.Drawing.Size(732, 384);
            this.dgvNota.TabIndex = 37;
            // 
            // cmsModifiko1
            // 
            this.cmsModifiko1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifikoToolStripMenuItem});
            this.cmsModifiko1.Name = "cmsModifiko1";
            this.cmsModifiko1.Size = new System.Drawing.Size(123, 26);
            // 
            // modifikoToolStripMenuItem
            // 
            this.modifikoToolStripMenuItem.Name = "modifikoToolStripMenuItem";
            this.modifikoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.modifikoToolStripMenuItem.Text = "Modifiko";
            this.modifikoToolStripMenuItem.Click += new System.EventHandler(this.modifikoToolStripMenuItem_Click_1);
            // 
            // Forma_Profesorit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekti_KNK.Properties.Resources.minimalistic_textures_simple_www_wall321_com_84;
            this.ClientSize = new System.Drawing.Size(962, 455);
            this.ContextMenuStrip = this.cmsModifiko1;
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.lblShkyqu);
            this.Controls.Add(this.pnlKontrolla);
            this.Name = "Forma_Profesorit";
            this.Text = "Forma_Profesorit";
            this.Load += new System.EventHandler(this.Forma_Profesorit_Load_3);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            this.cmsModifiko1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlKontrolla;
        private System.Windows.Forms.Label lblShkyqu;
        private System.Windows.Forms.DataGridView dgvNota;
        private System.Windows.Forms.ContextMenuStrip cmsModifiko1;
        private System.Windows.Forms.ToolStripMenuItem modifikoToolStripMenuItem;
    }
}