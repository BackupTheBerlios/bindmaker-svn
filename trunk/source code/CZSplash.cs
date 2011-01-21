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
 * 
 * */

using System;
using System.Runtime.InteropServices;

namespace CZBindMaker
{
	/// <summary>
	/// Summary description for CZSplash.
	/// </summary>
	public class CZSplash : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label by;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label m_action;
		private System.Windows.Forms.Label version;
        private System.Windows.Forms.ProgressBar progressBar1;
        private const int AW_BLEND = 0x00080000, AW_ACTIVATE = 0x00020000;
        private System.ComponentModel.Container components = null;
        private string _currentAction;
        
        [DllImport("User32", CharSet=CharSet.Auto)]
        private static extern bool AnimateWindow(IntPtr hWnd, int time, int flags);

		public CZSplash()
		{
			InitializeComponent();
			this.version.Text = "Version "+CZBindMaker.CZBindMakerMainForm.applicationVersion;
		}
        public void ShowSplash() {           
            m_action.Text = _currentAction;  
            Update();
            AnimateWindow(Handle, 450, AW_BLEND|AW_ACTIVATE);
            Show();                         
            Update();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( CZSplash ) );
            this.by = new System.Windows.Forms.Label( );
            this.version = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.m_action = new System.Windows.Forms.Label( );
            this.progressBar1 = new System.Windows.Forms.ProgressBar( );
            this.SuspendLayout( );
            // 
            // by
            // 
            this.by.BackColor = System.Drawing.Color.Transparent;
            this.by.ForeColor = System.Drawing.Color.White;
            this.by.Location = new System.Drawing.Point( 184, 164 );
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size( 160, 16 );
            this.by.TabIndex = 0;
            this.by.Text = "© 2003-2011 NullFX Software";
            this.by.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // version
            // 
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point( 16, 136 );
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size( 496, 16 );
            this.version.TabIndex = 1;
            this.version.Text = "Version Information";
            this.version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point( 164, 192 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 200, 16 );
            this.label2.TabIndex = 2;
            this.label2.Text = "Splash Screen By Casey York © 2003";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // m_action
            // 
            this.m_action.BackColor = System.Drawing.Color.Transparent;
            this.m_action.ForeColor = System.Drawing.Color.White;
            this.m_action.Location = new System.Drawing.Point( 144, 56 );
            this.m_action.Name = "m_action";
            this.m_action.Size = new System.Drawing.Size( 240, 16 );
            this.m_action.TabIndex = 3;
            this.m_action.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point( 201, 72 );
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size( 126, 10 );
            this.progressBar1.Step = 34;
            this.progressBar1.TabIndex = 4;
            // 
            // CZSplash
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ( (System.Drawing.Image)( resources.GetObject( "$this.BackgroundImage" ) ) );
            this.ClientSize = new System.Drawing.Size( 528, 224 );
            this.ControlBox = false;
            this.Controls.Add( this.m_action );
            this.Controls.Add( this.progressBar1 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.version );
            this.Controls.Add( this.by );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "CZSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Zulu Bind Maker";
            this.ResumeLayout( false );

        }
		#endregion

		public string Action
		{
			set
			{
				this.m_action.Text = _currentAction = value;
				this.progressBar1.PerformStep();
				this.Refresh();
			}
		}
	}
}
