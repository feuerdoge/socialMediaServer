namespace ClientSocialMedia
{
    partial class ProfileControl
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
            this.profileLb = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.mailTb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profileLb
            // 
            this.profileLb.AutoSize = true;
            this.profileLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLb.Location = new System.Drawing.Point(201, 117);
            this.profileLb.Name = "profileLb";
            this.profileLb.Size = new System.Drawing.Size(80, 25);
            this.profileLb.TabIndex = 0;
            this.profileLb.Text = "Profile";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(206, 183);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 20);
            this.nameTb.TabIndex = 1;
            this.nameTb.Text = "Benutzername...";
            // 
            // mailTb
            // 
            this.mailTb.Location = new System.Drawing.Point(206, 235);
            this.mailTb.Name = "mailTb";
            this.mailTb.Size = new System.Drawing.Size(100, 20);
            this.mailTb.TabIndex = 2;
            this.mailTb.Text = "E-Mail...";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(218, 278);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Speichern";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.mailTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.profileLb);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(575, 482);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profileLb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox mailTb;
        private System.Windows.Forms.Button saveBtn;
    }
}
