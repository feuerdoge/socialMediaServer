namespace ClientSocialMedia
{
    partial class KommentarControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.autor = new System.Windows.Forms.Label();
            this.profil = new System.Windows.Forms.PictureBox();
            this.komm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).BeginInit();
            this.SuspendLayout();
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(76, 5);
            this.autor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(44, 16);
            this.autor.TabIndex = 0;
            this.autor.Text = "label1";
            // 
            // profil
            // 
            this.profil.Image = global::ClientSocialMedia.Properties.Resources.profile;
            this.profil.Location = new System.Drawing.Point(5, 5);
            this.profil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(55, 55);
            this.profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profil.TabIndex = 1;
            this.profil.TabStop = false;
            // 
            // komm
            // 
            this.komm.Location = new System.Drawing.Point(77, 26);
            this.komm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.komm.Multiline = true;
            this.komm.Name = "komm";
            this.komm.ReadOnly = true;
            this.komm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.komm.Size = new System.Drawing.Size(331, 85);
            this.komm.TabIndex = 2;
            // 
            // KommentarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.komm);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.autor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KommentarControl";
            this.Size = new System.Drawing.Size(413, 116);
            ((System.ComponentModel.ISupportInitialize)(this.profil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.PictureBox profil;
        private System.Windows.Forms.TextBox komm;
    }
}
