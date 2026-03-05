namespace ClientSocialMedia
{
    partial class Kommentaruebersicht
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
            this.schliessen = new System.Windows.Forms.Button();
            this.kommentarsektion = new System.Windows.Forms.FlowLayoutPanel();
            this.kommentarVerfassen = new System.Windows.Forms.Panel();
            this.erstellen = new System.Windows.Forms.Button();
            this.inhaltKommentar = new System.Windows.Forms.TextBox();
            this.about = new System.Windows.Forms.Label();
            this.verfassen = new System.Windows.Forms.Button();
            this.kommentarVerfassen.SuspendLayout();
            this.SuspendLayout();
            // 
            // schliessen
            // 
            this.schliessen.Location = new System.Drawing.Point(377, 4);
            this.schliessen.Name = "schliessen";
            this.schliessen.Size = new System.Drawing.Size(24, 23);
            this.schliessen.TabIndex = 0;
            this.schliessen.Text = "x";
            this.schliessen.UseVisualStyleBackColor = true;
            this.schliessen.Click += new System.EventHandler(this.schliessen_Click);
            // 
            // kommentarsektion
            // 
            this.kommentarsektion.Location = new System.Drawing.Point(3, 28);
            this.kommentarsektion.Name = "kommentarsektion";
            this.kommentarsektion.Size = new System.Drawing.Size(406, 352);
            this.kommentarsektion.TabIndex = 1;
            // 
            // kommentarVerfassen
            // 
            this.kommentarVerfassen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kommentarVerfassen.Controls.Add(this.erstellen);
            this.kommentarVerfassen.Controls.Add(this.inhaltKommentar);
            this.kommentarVerfassen.Controls.Add(this.about);
            this.kommentarVerfassen.Location = new System.Drawing.Point(14, 46);
            this.kommentarVerfassen.Name = "kommentarVerfassen";
            this.kommentarVerfassen.Size = new System.Drawing.Size(387, 242);
            this.kommentarVerfassen.TabIndex = 0;
            this.kommentarVerfassen.Visible = false;
            // 
            // erstellen
            // 
            this.erstellen.Location = new System.Drawing.Point(306, 4);
            this.erstellen.Name = "erstellen";
            this.erstellen.Size = new System.Drawing.Size(75, 23);
            this.erstellen.TabIndex = 3;
            this.erstellen.Text = "Erstellen";
            this.erstellen.UseVisualStyleBackColor = true;
            this.erstellen.Click += new System.EventHandler(this.erstellen_Click);
            // 
            // inhaltKommentar
            // 
            this.inhaltKommentar.Location = new System.Drawing.Point(3, 33);
            this.inhaltKommentar.Multiline = true;
            this.inhaltKommentar.Name = "inhaltKommentar";
            this.inhaltKommentar.Size = new System.Drawing.Size(378, 206);
            this.inhaltKommentar.TabIndex = 2;
            this.inhaltKommentar.Text = "(Kommentar Schreiben)";
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(4, 4);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(110, 13);
            this.about.TabIndex = 0;
            this.about.Text = "Kommentar Verfassen";
            // 
            // verfassen
            // 
            this.verfassen.Location = new System.Drawing.Point(4, 4);
            this.verfassen.Name = "verfassen";
            this.verfassen.Size = new System.Drawing.Size(75, 23);
            this.verfassen.TabIndex = 2;
            this.verfassen.Text = "Verfassen";
            this.verfassen.UseVisualStyleBackColor = true;
            this.verfassen.Click += new System.EventHandler(this.verfassen_Click);
            // 
            // Kommentaruebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.verfassen);
            this.Controls.Add(this.kommentarVerfassen);
            this.Controls.Add(this.kommentarsektion);
            this.Controls.Add(this.schliessen);
            this.Name = "Kommentaruebersicht";
            this.Size = new System.Drawing.Size(413, 383);
            this.kommentarVerfassen.ResumeLayout(false);
            this.kommentarVerfassen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button schliessen;
        private System.Windows.Forms.FlowLayoutPanel kommentarsektion;
        private System.Windows.Forms.Panel kommentarVerfassen;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.TextBox inhaltKommentar;
        private System.Windows.Forms.Button erstellen;
        private System.Windows.Forms.Button verfassen;
    }
}
