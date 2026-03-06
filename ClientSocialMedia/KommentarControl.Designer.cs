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
            this.timeLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).BeginInit();
            this.SuspendLayout();
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(57, 4);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(35, 13);
            this.autor.TabIndex = 0;
            this.autor.Text = "label1";
            // 
            // profil
            // 
            this.profil.Image = global::ClientSocialMedia.Properties.Resources.profile;
            this.profil.Location = new System.Drawing.Point(4, 4);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(41, 45);
            this.profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profil.TabIndex = 1;
            this.profil.TabStop = false;
            this.profil.Click += new System.EventHandler(this.profil_Click);
            this.profil.MouseHover += new System.EventHandler(this.profil_MouseHover);
            // 
            // komm
            // 
            this.komm.Location = new System.Drawing.Point(58, 21);
            this.komm.Multiline = true;
            this.komm.Name = "komm";
            this.komm.ReadOnly = true;
            this.komm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.komm.Size = new System.Drawing.Size(249, 70);
            this.komm.TabIndex = 2;
            // 
            // timeLb
            // 
            this.timeLb.AutoSize = true;
            this.timeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLb.Location = new System.Drawing.Point(217, 5);
            this.timeLb.Name = "timeLb";
            this.timeLb.Size = new System.Drawing.Size(90, 12);
            this.timeLb.TabIndex = 3;
            this.timeLb.Text = "dd.MM.yyyy hh:mm";
            // 
            // KommentarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.timeLb);
            this.Controls.Add(this.komm);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.autor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "KommentarControl";
            this.Size = new System.Drawing.Size(310, 94);
            ((System.ComponentModel.ISupportInitialize)(this.profil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.PictureBox profil;
        private System.Windows.Forms.TextBox komm;
        private System.Windows.Forms.Label timeLb;
    }
}
