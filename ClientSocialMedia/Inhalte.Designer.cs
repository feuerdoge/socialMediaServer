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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Kommentarsektion = new System.Windows.Forms.Label();
            this.likeBtn = new System.Windows.Forms.Button();
            this.likesLb = new System.Windows.Forms.Label();
            this.abonnierenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.beitragBild)).BeginInit();
            this.SuspendLayout();
            // 
            // beitragTitel
            // 
            this.beitragTitel.AutoSize = true;
            this.beitragTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beitragTitel.Location = new System.Drawing.Point(169, 14);
            this.beitragTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.beitragTitel.Name = "beitragTitel";
            this.beitragTitel.Size = new System.Drawing.Size(66, 31);
            this.beitragTitel.TabIndex = 0;
            this.beitragTitel.Text = "Titel";
            // 
            // beitragBild
            // 
            this.beitragBild.BackgroundImage = global::ClientSocialMedia.Properties.Resources.empty;
            this.beitragBild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beitragBild.Location = new System.Drawing.Point(65, 48);
            this.beitragBild.Margin = new System.Windows.Forms.Padding(4);
            this.beitragBild.Name = "beitragBild";
            this.beitragBild.Size = new System.Drawing.Size(299, 245);
            this.beitragBild.TabIndex = 1;
            this.beitragBild.TabStop = false;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(341, 155);
            this.next.Margin = new System.Windows.Forms.Padding(4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(37, 28);
            this.next.TabIndex = 2;
            this.next.Text = "Nxt";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(47, 155);
            this.last.Margin = new System.Windows.Forms.Padding(4);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(37, 28);
            this.last.TabIndex = 3;
            this.last.Text = "Lst";
            this.last.UseVisualStyleBackColor = true;
            this.last.Visible = false;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 382);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(413, 199);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Kommentarsektion
            // 
            this.Kommentarsektion.AutoSize = true;
            this.Kommentarsektion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kommentarsektion.Location = new System.Drawing.Point(4, 347);
            this.Kommentarsektion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kommentarsektion.Name = "Kommentarsektion";
            this.Kommentarsektion.Size = new System.Drawing.Size(168, 31);
            this.Kommentarsektion.TabIndex = 5;
            this.Kommentarsektion.Text = "Kommentare";
            // 
            // likeBtn
            // 
            this.likeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeBtn.Location = new System.Drawing.Point(65, 300);
            this.likeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(45, 43);
            this.likeBtn.TabIndex = 6;
            this.likeBtn.Text = "👍";
            this.likeBtn.UseVisualStyleBackColor = true;
            this.likeBtn.Click += new System.EventHandler(this.likeBtn_Click);
            // 
            // likesLb
            // 
            this.likesLb.AutoSize = true;
            this.likesLb.Location = new System.Drawing.Point(118, 318);
            this.likesLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likesLb.Name = "likesLb";
            this.likesLb.Size = new System.Drawing.Size(85, 16);
            this.likesLb.TabIndex = 7;
            this.likesLb.Text = "Anzahl Likes:";
            // 
            // abonnierenBtn
            // 
            this.abonnierenBtn.BackColor = System.Drawing.Color.Red;
            this.abonnierenBtn.ForeColor = System.Drawing.Color.White;
            this.abonnierenBtn.Location = new System.Drawing.Point(235, 315);
            this.abonnierenBtn.Name = "abonnierenBtn";
            this.abonnierenBtn.Size = new System.Drawing.Size(89, 23);
            this.abonnierenBtn.TabIndex = 8;
            this.abonnierenBtn.TabStop = false;
            this.abonnierenBtn.Text = "Abonnieren";
            this.abonnierenBtn.UseVisualStyleBackColor = false;
            this.abonnierenBtn.Click += new System.EventHandler(this.abonnierenBtn_Click);
            // 
            // Inhalte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.abonnierenBtn);
            this.Controls.Add(this.likesLb);
            this.Controls.Add(this.likeBtn);
            this.Controls.Add(this.Kommentarsektion);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Controls.Add(this.beitragBild);
            this.Controls.Add(this.beitragTitel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inhalte";
            this.Size = new System.Drawing.Size(421, 585);
            ((System.ComponentModel.ISupportInitialize)(this.beitragBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beitragTitel;
        private System.Windows.Forms.PictureBox beitragBild;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Kommentarsektion;
        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Label likesLb;
        private System.Windows.Forms.Button abonnierenBtn;
    }
}
