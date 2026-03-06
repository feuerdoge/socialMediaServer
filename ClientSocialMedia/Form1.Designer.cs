namespace ClientSocialMedia
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.momentaneAnsicht = new System.Windows.Forms.Panel();
            this.inhaltAnzeige = new System.Windows.Forms.FlowLayoutPanel();
            this.beitragsErstellungsPanel = new System.Windows.Forms.Panel();
            this.erstellen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(313, 554);
            this.menuPanel.TabIndex = 0;
            // 
            // profilePic
            // 
            this.profilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Location = new System.Drawing.Point(984, 15);
            this.profilePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(67, 62);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            this.profilePic.Visible = false;
            this.profilePic.Click += new System.EventHandler(this.profilePic_Click);
            this.profilePic.MouseHover += new System.EventHandler(this.profilePic_MouseHover);
            // 
            // momentaneAnsicht
            // 
            this.momentaneAnsicht.Location = new System.Drawing.Point(309, -1);
            this.momentaneAnsicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.momentaneAnsicht.Name = "momentaneAnsicht";
            this.momentaneAnsicht.Size = new System.Drawing.Size(607, 62);
            this.momentaneAnsicht.TabIndex = 2;
            // 
            // inhaltAnzeige
            // 
            this.inhaltAnzeige.AutoScroll = true;
            this.inhaltAnzeige.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inhaltAnzeige.Location = new System.Drawing.Point(313, 0);
            this.inhaltAnzeige.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inhaltAnzeige.Name = "inhaltAnzeige";
            this.inhaltAnzeige.Size = new System.Drawing.Size(663, 554);
            this.inhaltAnzeige.TabIndex = 3;
            this.inhaltAnzeige.Visible = false;
            this.inhaltAnzeige.WrapContents = false;
            // 
            // beitragsErstellungsPanel
            // 
            this.beitragsErstellungsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.beitragsErstellungsPanel.Location = new System.Drawing.Point(320, 68);
            this.beitragsErstellungsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.beitragsErstellungsPanel.Name = "beitragsErstellungsPanel";
            this.beitragsErstellungsPanel.Size = new System.Drawing.Size(567, 441);
            this.beitragsErstellungsPanel.TabIndex = 0;
            this.beitragsErstellungsPanel.Visible = false;
            // 
            // erstellen
            // 
            this.erstellen.Location = new System.Drawing.Point(913, 145);
            this.erstellen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.erstellen.Name = "erstellen";
            this.erstellen.Size = new System.Drawing.Size(137, 28);
            this.erstellen.TabIndex = 4;
            this.erstellen.Text = "Beitrag Erstellen";
            this.erstellen.UseVisualStyleBackColor = true;
            this.erstellen.Visible = false;
            this.erstellen.Click += new System.EventHandler(this.erstellen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.beitragsErstellungsPanel);
            this.Controls.Add(this.erstellen);
            this.Controls.Add(this.inhaltAnzeige);
            this.Controls.Add(this.momentaneAnsicht);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Panel momentaneAnsicht;
        private System.Windows.Forms.FlowLayoutPanel inhaltAnzeige;
        private System.Windows.Forms.Button erstellen;
        private System.Windows.Forms.Panel beitragsErstellungsPanel;
    }
}

