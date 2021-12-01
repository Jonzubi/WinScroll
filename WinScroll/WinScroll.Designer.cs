namespace WinScroll
{
    partial class WinScroll
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinScroll));
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cursor = new System.Windows.Forms.GroupBox();
            this.labelCoords = new System.Windows.Forms.Label();
            this.captureHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.captureWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureWidth)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cursor
            // 
            this.cursor.Controls.Add(this.labelCoords);
            this.cursor.Controls.Add(this.captureHeight);
            this.cursor.Controls.Add(this.label4);
            this.cursor.Controls.Add(this.captureWidth);
            this.cursor.Controls.Add(this.label3);
            this.cursor.Location = new System.Drawing.Point(13, 15);
            this.cursor.Margin = new System.Windows.Forms.Padding(4);
            this.cursor.Name = "cursor";
            this.cursor.Padding = new System.Windows.Forms.Padding(4);
            this.cursor.Size = new System.Drawing.Size(483, 196);
            this.cursor.TabIndex = 2;
            this.cursor.TabStop = false;
            this.cursor.Text = "Cursor Capture";
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Location = new System.Drawing.Point(235, 30);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(30, 17);
            this.labelCoords.TabIndex = 9;
            this.labelCoords.Text = "x: 0";
            // 
            // captureHeight
            // 
            this.captureHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureHeight.Location = new System.Drawing.Point(253, 105);
            this.captureHeight.Margin = new System.Windows.Forms.Padding(4);
            this.captureHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.captureHeight.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.captureHeight.Name = "captureHeight";
            this.captureHeight.Size = new System.Drawing.Size(222, 26);
            this.captureHeight.TabIndex = 8;
            this.captureHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height";
            // 
            // captureWidth
            // 
            this.captureWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureWidth.Location = new System.Drawing.Point(8, 105);
            this.captureWidth.Margin = new System.Windows.Forms.Padding(4);
            this.captureWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.captureWidth.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.captureWidth.Name = "captureWidth";
            this.captureWidth.Size = new System.Drawing.Size(237, 26);
            this.captureWidth.TabIndex = 6;
            this.captureWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WinScroll";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(131, 58);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // WinScroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 224);
            this.Controls.Add(this.cursor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WinScroll";
            this.ShowInTaskbar = false;
            this.Text = "WinScroll";
            this.cursor.ResumeLayout(false);
            this.cursor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureWidth)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.GroupBox cursor;
        private System.Windows.Forms.NumericUpDown captureHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown captureWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelCoords;
    }
}

