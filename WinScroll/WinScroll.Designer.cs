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
            this.options = new System.Windows.Forms.GroupBox();
            this.windowCheck = new System.Windows.Forms.CheckBox();
            this.startupCheck = new System.Windows.Forms.CheckBox();
            this.trayCheck = new System.Windows.Forms.CheckBox();
            this.captureCheck = new System.Windows.Forms.CheckBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cursor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelCoords = new System.Windows.Forms.Label();
            this.captureHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.captureWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.captureY = new System.Windows.Forms.NumericUpDown();
            this.captureX = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.options.SuspendLayout();
            this.cursor.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureX)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // options
            // 
            this.options.Controls.Add(this.windowCheck);
            this.options.Controls.Add(this.startupCheck);
            this.options.Controls.Add(this.trayCheck);
            this.options.Controls.Add(this.captureCheck);
            this.options.Location = new System.Drawing.Point(16, 15);
            this.options.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.options.Name = "options";
            this.options.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.options.Size = new System.Drawing.Size(171, 138);
            this.options.TabIndex = 0;
            this.options.TabStop = false;
            this.options.Text = "Options";
            // 
            // windowCheck
            // 
            this.windowCheck.AutoSize = true;
            this.windowCheck.Location = new System.Drawing.Point(8, 108);
            this.windowCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.windowCheck.Name = "windowCheck";
            this.windowCheck.Size = new System.Drawing.Size(136, 21);
            this.windowCheck.TabIndex = 3;
            this.windowCheck.Text = "Enable snapping";
            this.tooltip.SetToolTip(this.windowCheck, "Enable window snapping hotkeys.");
            this.windowCheck.UseVisualStyleBackColor = true;
            // 
            // startupCheck
            // 
            this.startupCheck.AutoSize = true;
            this.startupCheck.Location = new System.Drawing.Point(8, 52);
            this.startupCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startupCheck.Name = "startupCheck";
            this.startupCheck.Size = new System.Drawing.Size(124, 21);
            this.startupCheck.TabIndex = 1;
            this.startupCheck.Text = "Run on startup";
            this.tooltip.SetToolTip(this.startupCheck, "Start WinScroll automatically on startup.");
            this.startupCheck.UseVisualStyleBackColor = true;
            // 
            // trayCheck
            // 
            this.trayCheck.AutoSize = true;
            this.trayCheck.Location = new System.Drawing.Point(8, 23);
            this.trayCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trayCheck.Name = "trayCheck";
            this.trayCheck.Size = new System.Drawing.Size(117, 21);
            this.trayCheck.TabIndex = 0;
            this.trayCheck.Text = "Hide tray icon";
            this.tooltip.SetToolTip(this.trayCheck, "Hide the icon in the tray area.");
            this.trayCheck.UseVisualStyleBackColor = true;
            // 
            // captureCheck
            // 
            this.captureCheck.AutoSize = true;
            this.captureCheck.Location = new System.Drawing.Point(8, 80);
            this.captureCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.captureCheck.Name = "captureCheck";
            this.captureCheck.Size = new System.Drawing.Size(126, 21);
            this.captureCheck.TabIndex = 2;
            this.captureCheck.Text = "Enable capture";
            this.tooltip.SetToolTip(this.captureCheck, "Prevent the cursor from leaving the specified area.");
            this.captureCheck.UseVisualStyleBackColor = true;
            // 
            // cursor
            // 
            this.cursor.Controls.Add(this.tableLayoutPanel);
            this.cursor.Controls.Add(this.captureHeight);
            this.cursor.Controls.Add(this.label4);
            this.cursor.Controls.Add(this.captureWidth);
            this.cursor.Controls.Add(this.label3);
            this.cursor.Controls.Add(this.label2);
            this.cursor.Controls.Add(this.label1);
            this.cursor.Controls.Add(this.captureY);
            this.cursor.Controls.Add(this.captureX);
            this.cursor.Location = new System.Drawing.Point(195, 15);
            this.cursor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cursor.Name = "cursor";
            this.cursor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cursor.Size = new System.Drawing.Size(301, 196);
            this.cursor.TabIndex = 2;
            this.cursor.TabStop = false;
            this.cursor.Text = "Cursor Capture";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelCoords, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(217, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(76, 21);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCoords.Location = new System.Drawing.Point(21, 0);
            this.labelCoords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(51, 21);
            this.labelCoords.TabIndex = 9;
            this.labelCoords.Text = "coords";
            // 
            // captureHeight
            // 
            this.captureHeight.Location = new System.Drawing.Point(200, 57);
            this.captureHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.captureHeight.Size = new System.Drawing.Size(93, 22);
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
            this.label4.Location = new System.Drawing.Point(145, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height";
            // 
            // captureWidth
            // 
            this.captureWidth.Location = new System.Drawing.Point(200, 23);
            this.captureWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.captureWidth.Size = new System.Drawing.Size(93, 22);
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
            this.label3.Location = new System.Drawing.Point(145, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // captureY
            // 
            this.captureY.Location = new System.Drawing.Point(35, 57);
            this.captureY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.captureY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.captureY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.captureY.Name = "captureY";
            this.captureY.Size = new System.Drawing.Size(93, 22);
            this.captureY.TabIndex = 2;
            // 
            // captureX
            // 
            this.captureX.Location = new System.Drawing.Point(35, 23);
            this.captureX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.captureX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.captureX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.captureX.Name = "captureX";
            this.captureX.Size = new System.Drawing.Size(93, 22);
            this.captureX.TabIndex = 1;
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
            this.Controls.Add(this.options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "WinScroll";
            this.ShowInTaskbar = false;
            this.Text = "WinScroll";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.options.ResumeLayout(false);
            this.options.PerformLayout();
            this.cursor.ResumeLayout(false);
            this.cursor.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.captureHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureX)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox options;
        private System.Windows.Forms.CheckBox startupCheck;
        private System.Windows.Forms.CheckBox trayCheck;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.GroupBox cursor;
        private System.Windows.Forms.CheckBox captureCheck;
        private System.Windows.Forms.NumericUpDown captureHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown captureWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown captureY;
        private System.Windows.Forms.NumericUpDown captureX;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox windowCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}

