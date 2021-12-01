using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
//using Newtonsoft.Json;

namespace WinScroll
{
    public partial class WinScroll : Form
    {
        private System.Windows.Forms.Timer timer;
        private Rectangle captureRectangle;
        private Point p = new Point();

        private int leftArrow;
        private int upArrow;
        private int downArrow;
        private int rightArrow;

        private SnapLocation[] leftLocations = new SnapLocation[] { new SnapLocation(0,0,9,0) };
        private SnapLocation[] upLocations = new SnapLocation[] { new SnapLocation(9,0,3,5), new SnapLocation(6,0,6,5), new SnapLocation(6,0,3,5)};
        private SnapLocation[] downLocations = new SnapLocation[] { new SnapLocation(9,5,3,3,true), new SnapLocation(6,5,6,3,true), new SnapLocation(6,5,3,3,true) };
        private SnapLocation[] rightLocations = new SnapLocation[] { new SnapLocation(9,0,3,0) };

        public struct SnapLocation
        {
            public int x, y, width, height;
            public bool modulo;

            public SnapLocation(int c, int r, int w, int h)
            {
                x = c;
                y = r;
                width = w;
                height = h;
                modulo = false;
            }
            public SnapLocation(int c, int r, int w, int h, bool m)
            {
                x = c;
                y = r;
                width = w;
                height = h;
                modulo = m;
            }
        }

        public WinScroll()
        {
            leftArrow = "full_left".GetHashCode();
            upArrow = "upper_right".GetHashCode();
            downArrow = "lower_right".GetHashCode();
            rightArrow = "full_right".GetHashCode();

            InitializeComponent();
            Init();

            //SizeChanged += new System.EventHandler(formResize);
            Layout += new LayoutEventHandler(formResize);
            notifyIcon.DoubleClick += new System.EventHandler(windowShow);
            optionsToolStripMenuItem.Click += new System.EventHandler(windowShow);
            exitToolStripMenuItem.Click += new System.EventHandler(trayExit);

            captureX.LostFocus += new System.EventHandler(CaptureBounds);
            captureY.LostFocus += new System.EventHandler(CaptureBounds);
            captureWidth.LostFocus += new System.EventHandler(CaptureBounds);
            captureHeight.LostFocus += new System.EventHandler(CaptureBounds);

            captureCheck.CheckedChanged += new System.EventHandler(captureCheckChanged);
        }

        public void Init()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(Tick);
            timer.Interval = 10;

            captureRectangle = new Rectangle((int)captureX.Value, (int)captureY.Value, (int)captureWidth.Value, (int)captureHeight.Value);

            captureX.Value = Properties.Settings.Default.CaptureX;
            captureY.Value = Properties.Settings.Default.CaptureY;
            captureWidth.Value = Properties.Settings.Default.CaptureWidth;
            captureHeight.Value = Properties.Settings.Default.CaptureHeight;
            UpdateCaptureRect();
        }

        private void Tick(object sender, EventArgs e)
        {
            NativeMethods.GetCursorPos(out p);
            labelCoords.Text = p.X.ToString() + ", " + p.Y.ToString();
            UpdateCapture(captureCheck.Checked);
        }

        private void UpdateCapture(bool capture)
        {    
            if(capture)
            {
                NativeMethods.ClipCursor(ref captureRectangle);
                NativeMethods.MoveWindow(Handle, (int) captureX.Value, (int) captureY.Value, 400, 220, true);
            }
            else
            {
                NativeMethods.ClipCursor(IntPtr.Zero);
            }
        }

        private void CaptureBounds(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(((Control)captureX).Text))
                ((Control)captureX).Text = captureX.Value.ToString();

            if(string.IsNullOrEmpty(((Control)captureY).Text))
                ((Control)captureY).Text = captureY.Value.ToString();

            if(string.IsNullOrEmpty(((Control)captureWidth).Text))
                ((Control)captureWidth).Text = captureWidth.Value.ToString();

            if(string.IsNullOrEmpty(((Control)captureHeight).Text))
                ((Control)captureHeight).Text = captureHeight.Value.ToString();

            if(captureX.Value >= captureWidth.Value)
            {
                captureWidth.Value = captureX.Value + 1;
            }
            if(captureY.Value >= captureHeight.Value)
            {
                captureHeight.Value = captureY.Value + 1;
            }
            UpdateCaptureRect();
        }

        private void UpdateCaptureRect()
        {
            captureRectangle = new Rectangle((int)captureX.Value, (int)captureY.Value, (int)captureWidth.Value, (int)captureHeight.Value);
        }

        private void captureCheckChanged(object sender, EventArgs e)
        {
            UpdateCapture(captureCheck.Checked);
            if(captureCheck.Checked)
                timer.Start();
            else
                timer.Stop();
        }

        private void windowShow(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void trayExit(object sender, EventArgs e)
        {
            Close();
        }

        private void formResize(object sender, EventArgs e)
        {
            //Debug.WriteLine(WindowState.ToString() + ", " + Visible.ToString());
            if(WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
            //Debug.WriteLine(WindowState.ToString() + ", " + Visible.ToString());
        }

        private void RegisterHotkeys()
        {
            if(windowCheck.Checked)
            {
                Keys k = Keys.Control | Keys.Alt | Keys.Left;
                Macro.RegisterHotKey(this, k, leftArrow);

                k = Keys.Control | Keys.Alt | Keys.Up;
                Macro.RegisterHotKey(this, k, upArrow);

                k = Keys.Control | Keys.Alt | Keys.Down;
                Macro.RegisterHotKey(this, k, downArrow);

                k = Keys.Control | Keys.Alt | Keys.Right;
                Macro.RegisterHotKey(this, k, rightArrow);
            }
            else
            {
                Macro.UnregisterHotKey(this, leftArrow);
                Macro.UnregisterHotKey(this, upArrow);
                Macro.UnregisterHotKey(this, downArrow);
                Macro.UnregisterHotKey(this, rightArrow);
            }
        }

        private void ShowWindow()
        {
            WindowState = FormWindowState.Maximized;    //once again, not quite sure why this is necessary, but setting the state to normal straight away doesn't unhide correctly.
            Show();
            BringToFront();
            TopMost = true;     //ensure we're  right at the front!
            TopMost = false;    //don't stay in front though, that'd be rude.
            Activate();         //and make sure we're focused after we've been called.
            WindowState = FormWindowState.Normal;
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.CaptureX = captureX.Value;
            Properties.Settings.Default.CaptureY = captureY.Value;
            Properties.Settings.Default.CaptureWidth = captureWidth.Value;
            Properties.Settings.Default.CaptureHeight = captureHeight.Value;
            Properties.Settings.Default.Save();
        }
    }
}
