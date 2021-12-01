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
using System.Xml;
//using Newtonsoft.Json;

namespace WinScroll
{
    public partial class WinScroll : Form
    {
        private System.Windows.Forms.Timer timer;
        private Rectangle captureRectangle;
        private Point p = new Point();

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
            InitializeComponent();
            Init();

            //SizeChanged += new System.EventHandler(formResize);
            Layout += new LayoutEventHandler(formResize);
            notifyIcon.DoubleClick += new System.EventHandler(windowShow);
            optionsToolStripMenuItem.Click += new System.EventHandler(windowShow);
            exitToolStripMenuItem.Click += new System.EventHandler(trayExit);

            captureWidth.LostFocus += new System.EventHandler(CaptureBounds);
            captureHeight.LostFocus += new System.EventHandler(CaptureBounds);
        }

        public void Init()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(Tick);
            timer.Interval = 10;
            timer.Start();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("../../config.xml");

            XmlNode config = xmlDocument.FirstChild.NextSibling;
            string widthConfig = config.FirstChild.InnerText;
            string heigthConfig = config.FirstChild.NextSibling.InnerText;

            captureWidth.Value = Convert.ToDecimal(widthConfig);
            captureHeight.Value = Convert.ToDecimal(heigthConfig);

            captureRectangle = new Rectangle(0, 0, (int)captureWidth.Value, (int)captureHeight.Value);
            UpdateCaptureRect();
        }

        private void Tick(object sender, EventArgs e)
        {
            NativeMethods.GetCursorPos(out p);
            labelCoords.Text = p.X.ToString() + ", " + p.Y.ToString();
            UpdateCapture();
        }

        private void UpdateCapture()
        {    
            NativeMethods.ClipCursor(ref captureRectangle);
            NativeMethods.MoveWindow(Handle, 0, 0, 400, 220, true);
        }

        private void CaptureBounds(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(((Control)captureWidth).Text))
                ((Control)captureWidth).Text = captureWidth.Value.ToString();

            if(string.IsNullOrEmpty(((Control)captureHeight).Text))
                ((Control)captureHeight).Text = captureHeight.Value.ToString();

            UpdateCaptureRect();
        }

        private void UpdateCaptureRect()
        {
            captureRectangle = new Rectangle(0, 0, (int)captureWidth.Value, (int)captureHeight.Value);
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

        protected override void OnClosed(EventArgs e)
        {
            timer.Stop();
            base.OnClosed(e);
        }
    }
}
