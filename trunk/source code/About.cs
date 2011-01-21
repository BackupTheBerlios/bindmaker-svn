/* 
 * CZ Bind Maker
 * 
 * By: Steven Whitley (aka [CZ] Qw4z0)
 * 
 * CZ Bind Maker is a key Bind utility for Counter-Strike 1.6
 * and is distributed under the GNU Public License.
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details. 
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 * 
 * */


using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace CZBindMaker
{
	/// <summary>
	/// About CZ Bind Maker
	/// </summary>
	public class About : Form
	{
        private readonly string m_version = Application.ProductVersion;
		private Button button1;
		private PictureBox pictureBox1;
		private Label label2;
		private RichTextBox richTextBox1;
		private Label label1;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>

        private readonly System.ComponentModel.Container components = null;

		public About()
		{
			InitializeComponent();	
			
			this.label1.Text = "Version "+CZBindMaker.CZBindMakerMainForm.applicationVersion;
            Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("CZBindMaker.about.rtf");
			richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText);
            s.Close();
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(About));
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(224, 360);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ok";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(432, 352);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 32);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(16, 328);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(480, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "CZ Bind Maker is Free Software, If You use it and like it, show your support and " +
				"donate.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(488, 304);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			this.richTextBox1.MouseEnter += new System.EventHandler(this.richTextBox1_MouseEnter);
			this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 368);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Version Information";
			// 
			// About
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(506, 392);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "   About CZ Bind Maker";
			this.ResumeLayout(false);

		}
		#endregion
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.paypal.com/xclick/business=donations%40bindmaker.org&item_name=CZ+Bind+Maker+Donation&no_note=1&tax=0&currency_code=USD");
		}

		private void pictureBox3_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.bindmaker.org");
		}

		private void richTextBox1_MouseEnter(object sender, System.EventArgs e)
		{
			this.richTextBox1.Focus();
		}

        private void richTextBox1_LinkClicked( object sender, LinkClickedEventArgs e ) {
            System.Diagnostics.Process.Start( e.LinkText );
        }
	}
}
