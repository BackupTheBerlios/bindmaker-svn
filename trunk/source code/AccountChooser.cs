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
using System.Windows.Forms;

namespace CZBindMaker {	
	public delegate void SelectedAccount(string account); 
	/// <summary>
	/// Summary description for AccountChooser.
	/// </summary>
	public class AccountChooser : System.Windows.Forms.Form {
		private System.Windows.Forms.ListBox AccountList;
		private System.Windows.Forms.Button Ok;	 
		internal SelectedAccount SelectedAccountName;
        private System.Windows.Forms.ImageList _gameIcons;
        private System.Windows.Forms.ListBox Games;
        private System.ComponentModel.IContainer components;
        string[] accountNames = new string[0];

		public AccountChooser(string[] accountNames) {
			InitializeComponent();
            this.accountNames = accountNames;
		}

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.AccountList.Items.AddRange(accountNames);
            this.AccountList.SelectedIndex = 0;
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AccountChooser));
            this.AccountList = new System.Windows.Forms.ListBox();
            this.Ok = new System.Windows.Forms.Button();
            this._gameIcons = new System.Windows.Forms.ImageList(this.components);
            this.Games = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AccountList
            // 
            this.AccountList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountList.HorizontalScrollbar = true;
            this.AccountList.Location = new System.Drawing.Point(0, 0);
            this.AccountList.Name = "AccountList";
            this.AccountList.Size = new System.Drawing.Size(304, 236);
            this.AccountList.Sorted = true;
            this.AccountList.TabIndex = 0;
            this.AccountList.DoubleClick += new System.EventHandler(this.AccountList_DoubleClick);
            // 
            // Ok
            // 
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Ok.Location = new System.Drawing.Point(116, 244);
            this.Ok.Name = "Ok";
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // _gameIcons
            // 
            this._gameIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this._gameIcons.ImageSize = new System.Drawing.Size(24, 24);
            this._gameIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_gameIcons.ImageStream")));
            this._gameIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Games
            // 
            this.Games.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Games.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Games.ItemHeight = 26;
            this.Games.Location = new System.Drawing.Point(312, 0);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(296, 236);
            this.Games.TabIndex = 5;
            // 
            // AccountChooser
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.ControlBox = false;
            this.Controls.Add(this.Games);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.AccountList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 304);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(298, 304);
            this.Name = "AccountChooser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   Select an Account";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

		private void Ok_Click(object sender, System.EventArgs e) {
			try {
				this.SelectedAccountName(this.AccountList.SelectedItem.ToString());
			}catch{}
			this.DialogResult = DialogResult.OK;
		}

		private void AccountList_DoubleClick(object sender, System.EventArgs e) {
			Ok_Click(sender,e);
		}
	}
}
