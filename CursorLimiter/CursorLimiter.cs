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

namespace CursorLimiter
{
    public partial class CursorLimiter : Form
    {
        private System.Windows.Forms.Timer timer;
        private Rectangle captureRectangle;
        private Point p = new Point();
        private int captureWidth = 0;
        private int captureHeight = 0;

        public CursorLimiter()
        {
            InitializeComponent();
            Init();

            Layout += new LayoutEventHandler(formResize);
            notifyIcon.DoubleClick += new System.EventHandler(windowShow);
            optionsToolStripMenuItem.Click += new System.EventHandler(windowShow);
            exitToolStripMenuItem.Click += new System.EventHandler(trayExit);

            WindowState = FormWindowState.Minimized;
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

            captureWidth = Convert.ToInt32(widthConfig);
            captureHeight = Convert.ToInt32(heigthConfig);

            captureRectangle = new Rectangle(0, 0, captureWidth, captureHeight);
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
            NativeMethods.MoveWindow(Handle, 0, 0, 100, 30, true);
        }

        private void CaptureBounds(object sender, EventArgs e)
        {
            UpdateCaptureRect();
        }

        private void UpdateCaptureRect()
        {
            captureRectangle = new Rectangle(0, 0, captureWidth, captureHeight);
        }

        private void windowShow(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void trayExit(object sender, EventArgs e)
        {
            Close();
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

        private void formResize(object sender, EventArgs e)
        {
            //Debug.WriteLine(WindowState.ToString() + ", " + Visible.ToString());
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
            //Debug.WriteLine(WindowState.ToString() + ", " + Visible.ToString());
        }
    }
}
