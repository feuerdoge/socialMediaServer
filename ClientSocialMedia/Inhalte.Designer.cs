namespace ClientSocialMedia
{
    partial class Inhalte
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
            this.beitragTitel = new System.Windows.Forms.Label();
            this.beitragBild = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.kommentareVorschau = new System.Windows.Forms.FlowLayoutPanel();
            this.Kommentarsektion = new System.Windows.Forms.Label();
            this.likeBtn = new System.Windows.Forms.Button();
            this.likesLb = new System.Windows.Forms.Label();
            this.abonnierenBtn = new System.Windows.Forms.Button();
            this.anzeigen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.beitragBild)).BeginInit();
            this.SuspendLayout();
            // 
            // beitragTitel
            // 
            this.beitragTitel.AutoSize = true;
            this.beitragTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beitragTitel.Location = new System.Drawing.Point(200, 12);
            this.beitragTitel.Name = "beitragTitel";
            this.beitragTitel.Size = new System.Drawing.Size(53, 25);
            this.beitragTitel.TabIndex = 0;
            this.beitragTitel.Text = "Titel";
            // 
            // beitragBild
            // 
            this.beitragBild.BackgroundImage = global::ClientSocialMedia.Properties.Resources.empty;
            this.beitragBild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beitragBild.Location = new System.Drawing.Point(109, 40);
            this.beitragBild.Name = "beitragBild";
            this.beitragBild.Size = new System.Drawing.Size(224, 199);
            this.beitragBild.TabIndex = 1;
            this.beitragBild.TabStop = false;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(316, 127);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(28, 23);
            this.next.TabIndex = 2;
            this.next.Text = "Nxt";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(95, 127);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(28, 23);
            this.last.TabIndex = 3;
            this.last.Text = "Lst";
            this.last.UseVisualStyleBackColor = true;
            this.last.Visible = false;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // kommentareVorschau
            // 
            this.kommentareVorschau.AutoScroll = true;
            this.kommentareVorschau.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.kommentareVorschau.Location = new System.Drawing.Point(3, 310);
            this.kommentareVorschau.Name = "kommentareVorschau";
            this.kommentareVorschau.Size = new System.Drawing.Size(433, 162);
            this.kommentareVorschau.TabIndex = 4;
            this.kommentareVorschau.WrapContents = false;
            // 
            // Kommentarsektion
            // 
            this.Kommentarsektion.AutoSize = true;
            this.Kommentarsektion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kommentarsektion.Location = new System.Drawing.Point(3, 282);
            this.Kommentarsektion.Name = "Kommentarsektion";
            this.Kommentarsektion.Size = new System.Drawing.Size(133, 25);
            this.Kommentarsektion.TabIndex = 5;
            this.Kommentarsektion.Text = "Kommentare";
            // 
            // likeBtn
            // 
            this.likeBtn.BackColor = System.Drawing.Color.White;
            this.likeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeBtn.Location = new System.Drawing.Point(49, 244);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(34, 35);
            this.likeBtn.TabIndex = 6;
            this.likeBtn.Text = "👍";
            this.likeBtn.UseVisualStyleBackColor = false;
            this.likeBtn.Click += new System.EventHandler(this.likeBtn_Click);
            // 
            // likesLb
            // 
            this.likesLb.AutoSize = true;
            this.likesLb.Location = new System.Drawing.Point(88, 258);
            this.likesLb.Name = "likesLb";
            this.likesLb.Size = new System.Drawing.Size(70, 13);
            this.likesLb.TabIndex = 7;
            this.likesLb.Text = "Anzahl Likes:";
            // 
            // abonnierenBtn
            // 
            this.abonnierenBtn.BackColor = System.Drawing.Color.Red;
            this.abonnierenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abonnierenBtn.ForeColor = System.Drawing.Color.White;
            this.abonnierenBtn.Location = new System.Drawing.Point(176, 256);
            this.abonnierenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.abonnierenBtn.Name = "abonnierenBtn";
            this.abonnierenBtn.Size = new System.Drawing.Size(67, 19);
            this.abonnierenBtn.TabIndex = 8;
            this.abonnierenBtn.TabStop = false;
            this.abonnierenBtn.Text = "Abonnieren";
            this.abonnierenBtn.UseVisualStyleBackColor = false;
            this.abonnierenBtn.Click += new System.EventHandler(this.abonnierenBtn_Click);
            // 
            // anzeigen
            // 
            this.anzeigen.Location = new System.Drawing.Point(176, 282);
            this.anzeigen.Name = "anzeigen";
            this.anzeigen.Size = new System.Drawing.Size(97, 23);
            this.anzeigen.TabIndex = 9;
            this.anzeigen.Text = "Alle Anzeigen";
            this.anzeigen.UseVisualStyleBackColor = true;
            this.anzeigen.Click += new System.EventHandler(this.anzeigen_Click);
            // 
            // Inhalte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.anzeigen);
            this.Controls.Add(this.abonnierenBtn);
            this.Controls.Add(this.likesLb);
            this.Controls.Add(this.likeBtn);
            this.Controls.Add(this.Kommentarsektion);
            this.Controls.Add(this.kommentareVorschau);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Controls.Add(this.beitragBild);
            this.Controls.Add(this.beitragTitel);
            this.Name = "Inhalte";
            this.Size = new System.Drawing.Size(439, 475);
            ((System.ComponentModel.ISupportInitialize)(this.beitragBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beitragTitel;
        private System.Windows.Forms.PictureBox beitragBild;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.FlowLayoutPanel kommentareVorschau;
        private System.Windows.Forms.Label Kommentarsektion;
        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Label likesLb;
        private System.Windows.Forms.Button abonnierenBtn;
        private System.Windows.Forms.Button anzeigen;
    }
}
