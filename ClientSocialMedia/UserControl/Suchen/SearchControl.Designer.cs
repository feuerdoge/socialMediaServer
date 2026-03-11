namespace ClientSocialMedia
{
    partial class SearchControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.overviewPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 80);
            this.panel1.TabIndex = 0;
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(181, 37);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(151, 20);
            this.searchTb.TabIndex = 1;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suchbegriff:";
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.White;
            this.resultPanel.Controls.Add(this.flowLayoutPanel1);
            this.resultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPanel.Location = new System.Drawing.Point(0, 80);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(450, 300);
            this.resultPanel.TabIndex = 1;
            // 
            // overviewPanel
            // 
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Location = new System.Drawing.Point(0, 80);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(450, 300);
            this.overviewPanel.TabIndex = 2;
            this.overviewPanel.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.overviewPanel);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.panel1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(450, 380);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel resultPanel;
        private System.Windows.Forms.Panel overviewPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
