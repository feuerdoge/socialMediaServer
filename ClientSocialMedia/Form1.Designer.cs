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
            this.momentaneAnsicht = new System.Windows.Forms.Panel();
            this.inhaltAnzeige = new System.Windows.Forms.FlowLayoutPanel();
            this.beitragsErstellungsPanel = new System.Windows.Forms.Panel();
            this.tagLabel = new System.Windows.Forms.Label();
            this.tagPick = new System.Windows.Forms.ComboBox();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.beitragsErstellungsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(235, 451);
            this.menuPanel.TabIndex = 0;
            // 
            // momentaneAnsicht
            // 
            this.momentaneAnsicht.Location = new System.Drawing.Point(232, -1);
            this.momentaneAnsicht.Name = "momentaneAnsicht";
            this.momentaneAnsicht.Size = new System.Drawing.Size(455, 50);
            this.momentaneAnsicht.TabIndex = 2;
            // 
            // inhaltAnzeige
            // 
            this.inhaltAnzeige.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inhaltAnzeige.AutoScroll = true;
            this.inhaltAnzeige.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inhaltAnzeige.Location = new System.Drawing.Point(235, 0);
            this.inhaltAnzeige.Name = "inhaltAnzeige";
            this.inhaltAnzeige.Size = new System.Drawing.Size(500, 450);
            this.inhaltAnzeige.TabIndex = 3;
            this.inhaltAnzeige.Visible = false;
            this.inhaltAnzeige.WrapContents = false;
            // 
            // beitragsErstellungsPanel
            // 
            this.beitragsErstellungsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.beitragsErstellungsPanel.Controls.Add(this.tagLabel);
            this.beitragsErstellungsPanel.Controls.Add(this.tagPick);
            this.beitragsErstellungsPanel.Location = new System.Drawing.Point(240, 55);
            this.beitragsErstellungsPanel.Name = "beitragsErstellungsPanel";
            this.beitragsErstellungsPanel.Size = new System.Drawing.Size(425, 358);
            this.beitragsErstellungsPanel.TabIndex = 0;
            this.beitragsErstellungsPanel.Visible = false;
            // 
            // tagLabel
            // 
            this.tagLabel.AutoSize = true;
            this.tagLabel.Location = new System.Drawing.Point(228, 27);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(26, 13);
            this.tagLabel.TabIndex = 1;
            this.tagLabel.Text = "Tag";
            // 
            // tagPick
            // 
            this.tagPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagPick.FormattingEnabled = true;
            this.tagPick.Location = new System.Drawing.Point(260, 24);
            this.tagPick.Name = "tagPick";
            this.tagPick.Size = new System.Drawing.Size(121, 21);
            this.tagPick.TabIndex = 0;
            this.tagPick.Tag = "";
            this.tagPick.Visible = false;
            // 
            // profilePic
            // 
            this.profilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePic.Location = new System.Drawing.Point(737, 12);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(50, 50);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePic.TabIndex = 1;
            this.profilePic.TabStop = false;
            this.profilePic.Visible = false;
            this.profilePic.Click += new System.EventHandler(this.profilePic_Click);
            this.profilePic.MouseLeave += new System.EventHandler(this.profilePic_MouseLeave);
            this.profilePic.MouseHover += new System.EventHandler(this.profilePic_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.beitragsErstellungsPanel);
            this.Controls.Add(this.inhaltAnzeige);
            this.Controls.Add(this.momentaneAnsicht);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(815, 490);
            this.Name = "Form1";
            this.Text = "s";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.beitragsErstellungsPanel.ResumeLayout(false);
            this.beitragsErstellungsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Panel momentaneAnsicht;
        private System.Windows.Forms.FlowLayoutPanel inhaltAnzeige;
        private System.Windows.Forms.Panel beitragsErstellungsPanel;
        private System.Windows.Forms.ComboBox tagPick;
        private System.Windows.Forms.Label tagLabel;
    }
}

