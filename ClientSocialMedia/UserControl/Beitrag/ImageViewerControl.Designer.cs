namespace ClientSocialMedia
{
    partial class ImageViewerControl
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
            this.picturePB = new System.Windows.Forms.PictureBox();
            this.rightBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturePB)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePB
            // 
            this.picturePB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePB.Location = new System.Drawing.Point(40, 36);
            this.picturePB.Name = "picturePB";
            this.picturePB.Size = new System.Drawing.Size(346, 217);
            this.picturePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePB.TabIndex = 0;
            this.picturePB.TabStop = false;
            // 
            // rightBtn
            // 
            this.rightBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightBtn.Location = new System.Drawing.Point(392, 121);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(28, 26);
            this.rightBtn.TabIndex = 1;
            this.rightBtn.Text = "->";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(369, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(51, 27);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftBtn.Location = new System.Drawing.Point(6, 121);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(28, 26);
            this.leftBtn.TabIndex = 3;
            this.leftBtn.Text = "<-";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // ImageViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.picturePB);
            this.Name = "ImageViewerControl";
            this.Size = new System.Drawing.Size(427, 289);
            ((System.ComponentModel.ISupportInitialize)(this.picturePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePB;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button leftBtn;
    }
}
