namespace coursereg
{
    partial class studentHomePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentHomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myDetailsToolStripMenuItem,
            this.addDropToolStripMenuItem,
            this.exitSystemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 68);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myDetailsToolStripMenuItem
            // 
            this.myDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myDetailsToolStripMenuItem.Image")));
            this.myDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.myDetailsToolStripMenuItem.Name = "myDetailsToolStripMenuItem";
            this.myDetailsToolStripMenuItem.Size = new System.Drawing.Size(153, 64);
            this.myDetailsToolStripMenuItem.Text = "My Details";
            this.myDetailsToolStripMenuItem.Click += new System.EventHandler(this.myDetailsToolStripMenuItem_Click);
            // 
            // addDropToolStripMenuItem
            // 
            this.addDropToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addDropToolStripMenuItem.Image")));
            this.addDropToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addDropToolStripMenuItem.Name = "addDropToolStripMenuItem";
            this.addDropToolStripMenuItem.Size = new System.Drawing.Size(151, 64);
            this.addDropToolStripMenuItem.Text = "Add/Drop";
            this.addDropToolStripMenuItem.Click += new System.EventHandler(this.addDropToolStripMenuItem_Click);
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem.Image")));
            this.exitSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(158, 64);
            this.exitSystemToolStripMenuItem.Text = "Exit System";
            this.exitSystemToolStripMenuItem.Click += new System.EventHandler(this.exitSystemToolStripMenuItem_Click);
            // 
            // studentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1231, 793);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "studentHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studentHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
    }
}