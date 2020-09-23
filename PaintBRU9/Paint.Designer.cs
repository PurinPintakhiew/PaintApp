namespace PaintBRU
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.Pict = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRect = new System.Windows.Forms.ToolStripButton();
            this.tsbCircle = new System.Windows.Forms.ToolStripButton();
            this.Dawd = new System.Windows.Forms.ToolStripButton();
            this.btnE = new System.Windows.Forms.ToolStripButton();
            this.tsbColor = new System.Windows.Forms.ToolStripButton();
            this.SC = new System.Windows.Forms.ToolStripButton();
            this.txtSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DlgSave = new System.Windows.Forms.SaveFileDialog();
            this.newPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Pict)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pict
            // 
            this.Pict.BackColor = System.Drawing.Color.White;
            this.Pict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pict.Location = new System.Drawing.Point(0, 0);
            this.Pict.Name = "Pict";
            this.Pict.Size = new System.Drawing.Size(854, 450);
            this.Pict.TabIndex = 0;
            this.Pict.TabStop = false;
            this.Pict.Paint += new System.Windows.Forms.PaintEventHandler(this.Pict_Paint);
            this.Pict.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pict_MouseDown);
            this.Pict.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pict_MouseMove);
            this.Pict.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pict_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRect,
            this.tsbCircle,
            this.Dawd,
            this.btnE,
            this.tsbColor,
            this.SC,
            this.txtSize,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRect
            // 
            this.tsbRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRect.Image = ((System.Drawing.Image)(resources.GetObject("tsbRect.Image")));
            this.tsbRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRect.Name = "tsbRect";
            this.tsbRect.Size = new System.Drawing.Size(23, 22);
            this.tsbRect.Text = "toolStripButton1";
            this.tsbRect.Click += new System.EventHandler(this.tsbRect_Click);
            // 
            // tsbCircle
            // 
            this.tsbCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCircle.Image = ((System.Drawing.Image)(resources.GetObject("tsbCircle.Image")));
            this.tsbCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCircle.Name = "tsbCircle";
            this.tsbCircle.Size = new System.Drawing.Size(23, 22);
            this.tsbCircle.Text = "toolStripButton1";
            this.tsbCircle.Click += new System.EventHandler(this.tsbCircle_Click);
            // 
            // Dawd
            // 
            this.Dawd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Dawd.Image = ((System.Drawing.Image)(resources.GetObject("Dawd.Image")));
            this.Dawd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dawd.Name = "Dawd";
            this.Dawd.Size = new System.Drawing.Size(23, 22);
            this.Dawd.Text = "toolStripButton1";
            this.Dawd.Click += new System.EventHandler(this.Dawd_Click);
            // 
            // btnE
            // 
            this.btnE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnE.Image = ((System.Drawing.Image)(resources.GetObject("btnE.Image")));
            this.btnE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(23, 22);
            this.btnE.Text = "btnE";
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // tsbColor
            // 
            this.tsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbColor.Image")));
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(23, 22);
            this.tsbColor.Text = "toolStripButton1";
            this.tsbColor.Click += new System.EventHandler(this.tsbColor_Click);
            // 
            // SC
            // 
            this.SC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SC.Name = "SC";
            this.SC.Size = new System.Drawing.Size(23, 22);
            this.SC.Text = "toolStripButton1";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(50, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(46, 425);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.newPenToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(43, 19);
            this.toolStripSplitButton1.Text = "Fine";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // DlgSave
            // 
            this.DlgSave.Filter = "Png|*.png|Jpg|*.jpg";
            // 
            // newPenToolStripMenuItem
            // 
            this.newPenToolStripMenuItem.Name = "newPenToolStripMenuItem";
            this.newPenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newPenToolStripMenuItem.Text = "New Pen";
            this.newPenToolStripMenuItem.Click += new System.EventHandler(this.newPenToolStripMenuItem_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Pict);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paint";
            this.Text = "Buriram Rajabhat University Paint";
            ((System.ComponentModel.ISupportInitialize)(this.Pict)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pict;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRect;
        private System.Windows.Forms.ToolStripButton tsbCircle;
        private System.Windows.Forms.ToolStripButton tsbColor;
        private System.Windows.Forms.ToolStripButton Dawd;
        private System.Windows.Forms.ToolStripButton SC;
        private System.Windows.Forms.ToolStripTextBox txtSize;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnE;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.SaveFileDialog DlgSave;
        private System.Windows.Forms.ToolStripMenuItem newPenToolStripMenuItem;
    }
}

