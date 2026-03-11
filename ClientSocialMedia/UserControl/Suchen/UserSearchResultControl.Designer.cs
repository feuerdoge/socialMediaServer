namespace ClientSocialMedia
{
    partial class UserSearchResultControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profilPic = new System.Windows.Forms.PictureBox();
            this.nameLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilPic)).BeginInit();
            this.SuspendLayout();
            // 
            // profilPic
            // 
            this.profilPic.Location = new System.Drawing.Point(3, 3);
            this.profilPic.Name = "profilPic";
            this.profilPic.Size = new System.Drawing.Size(54, 54);
            this.profilPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilPic.TabIndex = 0;
            this.profilPic.TabStop = false;
            this.profilPic.Click += new System.EventHandler(this.UserSearchResultControl_Click);
            this.profilPic.MouseLeave += new System.EventHandler(this.UserSearchResultControl_MouseLeave);
            this.profilPic.MouseHover += new System.EventHandler(this.UserSearchResultControl_MouseHover);
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.Location = new System.Drawing.Point(78, 24);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(92, 16);
            this.nameLb.TabIndex = 1;
            this.nameLb.Text = "NutzerName";
            this.nameLb.Click += new System.EventHandler(this.UserSearchResultControl_Click);
            this.nameLb.MouseLeave += new System.EventHandler(this.UserSearchResultControl_MouseLeave);
            this.nameLb.MouseHover += new System.EventHandler(this.UserSearchResultControl_MouseHover);
            // 
            // UserSearchResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.profilPic);
            this.Name = "UserSearchResultControl";
            this.Size = new System.Drawing.Size(379, 60);
            this.Click += new System.EventHandler(this.UserSearchResultControl_Click);
            this.MouseLeave += new System.EventHandler(this.UserSearchResultControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserSearchResultControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.profilPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilPic;
        private System.Windows.Forms.Label nameLb;
    }
}
