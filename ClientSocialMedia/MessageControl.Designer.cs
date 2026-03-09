namespace ClientSocialMedia
{
    partial class MessageControl
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
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.RichTextBox();
            this.dateLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePic
            // 
            this.profilePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePic.Location = new System.Drawing.Point(3, 3);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(40, 40);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.Location = new System.Drawing.Point(49, 3);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(89, 16);
            this.nameLb.TabIndex = 1;
            this.nameLb.Text = "Nutzername";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(52, 22);
            this.text.MaximumSize = new System.Drawing.Size(300, 100);
            this.text.MinimumSize = new System.Drawing.Size(250, 20);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.text.Size = new System.Drawing.Size(300, 40);
            this.text.TabIndex = 2;
            this.text.Text = "Template Text";
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLb.ForeColor = System.Drawing.Color.Gray;
            this.dateLb.Location = new System.Drawing.Point(217, 7);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(135, 12);
            this.dateLb.TabIndex = 3;
            this.dateLb.Text = "Gesendet: dd/MM/yyyy hh:mm";
            // 
            // MessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.text);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.profilePic);
            this.MaximumSize = new System.Drawing.Size(400, 100);
            this.MinimumSize = new System.Drawing.Size(400, 80);
            this.Name = "MessageControl";
            this.Size = new System.Drawing.Size(400, 80);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.Label dateLb;
    }
}
