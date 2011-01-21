/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 *
 * 
 * */

namespace CZBindMaker {
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using System.Drawing.Drawing2D;
	public class AmmoClips : System.Windows.Forms.Form {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.IContainer components;
        Rectangle handleRect;
        private const int AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000,
            WS_EX_LAYERED = 0x00080000;
        public const int WM_LBUTTONDOWN = 0x0201,
            WM_NCLBUTTONDOWN = 0x00A1,
            WM_CLOSE = 0x0010;
        public static readonly IntPtr HTCAPTION = (IntPtr)0x0002;
        private System.Windows.Forms.Timer _refreshTimer;
        private Color highlightDark;

        [DllImport("User32", CharSet=CharSet.Auto)]
        private static extern bool AnimateWindow(IntPtr hWnd, int time, int flags);

		public AmmoClips() {
            Color hld = Color.FromKnownColor(KnownColor.Highlight);
            byte 
                r = Convert.ToByte(hld.R-20<0?0:hld.R-20), 
                b = Convert.ToByte(hld.B-20<0?0:hld.B-20), 
                g = Convert.ToByte(hld.G-20<0?0:hld.G-20);
            highlightDark = Color.FromArgb(hld.A, r, g, b);
            handleRect = new Rectangle(new Point(0,0), new Size(20, Height));
			InitializeComponent();
		}

        public int ShowOption(IWin32Window parent, Point p) {
            Point pp = p;
            this.Location = p;
            AnimateWindow(Handle, 100, AW_ACTIVATE|AW_BLEND/*AW_VER_POSITIVE|AW_HOR_POSITIVE*/);
            Focus();
            numericUpDown1.Select();
            Update();                                               
            _refreshTimer.Start();
            this.ShowDialog(parent);
            return (int)numericUpDown1.Value;
        }
        private void Animate(object none) {
        }
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AmmoClips));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this._refreshTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of clips:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(112, 8);
            this.numericUpDown1.Maximum = new System.Decimal(new int[] {
                                                                           20,
                                                                           0,
                                                                           0,
                                                                           0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 17);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Ok);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.OkOver);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpHandler);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.OkOff);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownHandler);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(215, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 17);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Cancel);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.CancelOver);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpHandler);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.CancelOff);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownHandler);
            // 
            // _refreshTimer
            // 
            this._refreshTimer.Tick += new System.EventHandler(this.Repaint);
            // 
            // AmmoClips
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(232, 36);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AmmoClips";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Single Clips";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        private void LeaveEventHandler(object sender, System.EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, System.EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void Ok(object sender, System.EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void Cancel(object sender, System.EventArgs e) {
            numericUpDown1.Value = 0;            
            DialogResult = DialogResult.Cancel;
        }

        private void OkOver(object sender, System.EventArgs e) {
            pictureBox1.BackColor = SystemColors.Highlight;
        }

        private void OkOff(object sender, System.EventArgs e) {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void CancelOver(object sender, System.EventArgs e) {
            pictureBox2.BackColor = SystemColors.Highlight;
        }

        private void CancelOff(object sender, System.EventArgs e) {
            pictureBox2.BackColor = Color.Transparent;
        }

        protected override void WndProc(ref Message m) {
            if(m.Msg == WM_LBUTTONDOWN) {
                m.Msg = WM_NCLBUTTONDOWN;
                m.WParam = HTCAPTION;
            }
            base.WndProc (ref m);
        }
        protected override void OnPaint(PaintEventArgs e) {
            using(Pen p = new Pen(highlightDark)) {
                using(LinearGradientBrush menuOver = new LinearGradientBrush(handleRect, SystemColors.Menu, highlightDark/*SystemColors.Highlight*/, 0, true)) {
                    e.Graphics.FillRectangle(menuOver, handleRect);
                }
                e.Graphics.DrawRectangle(p, 0, 0, Width-1, Height-1);
            }
            //base.OnPaint (e);
        }
        int count = 3;
        private void Repaint(object sender, System.EventArgs e) {
            if(--count == 0) _refreshTimer.Stop();
            Update();
            Invalidate();
            numericUpDown1.Select();
        }

        private void OnMouseDownHandler(object sender, System.Windows.Forms.MouseEventArgs e) {
            Point p = ((PictureBox)sender).Location;
            ((PictureBox)sender).Location = new Point(p.X + 2, p.Y + 2);
        }

        private void OnMouseUpHandler(object sender, System.Windows.Forms.MouseEventArgs e) {
            Point p = ((PictureBox)sender).Location;
            ((PictureBox)sender).Location = new Point(p.X - 2, p.Y - 2);        
        }
    
        protected override CreateParams CreateParams {
            get {
                base.CreateParams.ExStyle |= WS_EX_LAYERED;
                return base.CreateParams;
            }
        }

	}
}
