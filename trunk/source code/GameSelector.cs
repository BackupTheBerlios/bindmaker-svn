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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CZBindMaker {
	public class GameSelector : System.Windows.Forms.Form {
		private System.Windows.Forms.GroupBox m_gameGrouping;
		private string[] _gameText = {
										 "Counter-Strike",
										 "Condition Zero",
                                         "Counter-Strike Source"
									 };
		private System.Windows.Forms.Button m_select;
		private System.Windows.Forms.ListBox Games;
        private System.Windows.Forms.ImageList _gameIcons;
		private System.ComponentModel.IContainer components;
		public event GameSelection SelectGame;

		public GameSelector(Games games) {
			InitializeComponent();
			this.Games.DataSource = this._gameText;
			this.Games.SelectedIndex = 0;
            switch((int)games) {
                case 7: // cs & cz & css
                    break;
                case 6: // cz & css 
                    _gameIcons.Images.RemoveAt(0);
                    _gameText = new string[]{"Condition Zero","Counter-Strike Source"};
                    break;
                case 5: // cs & css
                    _gameIcons.Images.RemoveAt(1);
                    _gameText = new string[]{"Counter-Strike","Counter-Strike Source"};
                    break;
                case 4: // css 
                    _gameIcons.Images.RemoveAt(0); 
                    _gameIcons.Images.RemoveAt(1);
                    _gameText = new string[]{"Counter-Strike Source"};
                    break; 
                case 3: // cs & cz 
                    _gameIcons.Images.RemoveAt(2);
                    _gameText = new string[]{"Counter-Strike","Condition Zero"};
                    break;
                case 2: // cz 
                    _gameIcons.Images.RemoveAt(0);
                    _gameIcons.Images.RemoveAt(2);
                    _gameText = new string[]{"Condition Zero"};
                    break;
                case 1: // cs 
                    _gameIcons.Images.RemoveAt(1); 
                    _gameIcons.Images.RemoveAt(2);
                    _gameText = new string[]{"Counter-Strike"};
                    break;
            }
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GameSelector));
            this.m_gameGrouping = new System.Windows.Forms.GroupBox();
            this.Games = new System.Windows.Forms.ListBox();
            this.m_select = new System.Windows.Forms.Button();
            this._gameIcons = new System.Windows.Forms.ImageList(this.components);
            this.m_gameGrouping.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_gameGrouping
            // 
            this.m_gameGrouping.Controls.Add(this.Games);
            this.m_gameGrouping.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_gameGrouping.Location = new System.Drawing.Point(0, 0);
            this.m_gameGrouping.Name = "m_gameGrouping";
            this.m_gameGrouping.Size = new System.Drawing.Size(254, 176);
            this.m_gameGrouping.TabIndex = 0;
            this.m_gameGrouping.TabStop = false;
            this.m_gameGrouping.Text = "Select Which Game";
            // 
            // Games
            // 
            this.Games.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Games.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Games.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Games.ItemHeight = 26;
            this.Games.Location = new System.Drawing.Point(3, 16);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(248, 157);
            this.Games.TabIndex = 4;
            this.Games.DoubleClick += new System.EventHandler(this.m_select_Click);
            this.Games.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Games_DrawItem);
            // 
            // m_select
            // 
            this.m_select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.m_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_select.Location = new System.Drawing.Point(80, 184);
            this.m_select.Name = "m_select";
            this.m_select.TabIndex = 1;
            this.m_select.Text = "OK";
            this.m_select.Click += new System.EventHandler(this.m_select_Click);
            // 
            // _gameIcons
            // 
            this._gameIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this._gameIcons.ImageSize = new System.Drawing.Size(24, 24);
            this._gameIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_gameIcons.ImageStream")));
            this._gameIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GameSelector
            // 
            this.AcceptButton = this.m_select;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(254, 216);
            this.ControlBox = false;
            this.Controls.Add(this.m_select);
            this.Controls.Add(this.m_gameGrouping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(256, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(256, 240);
            this.Name = "GameSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Selection";
            this.TopMost = true;
            this.m_gameGrouping.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		public delegate void GameSelection(string selection);
		protected virtual void OnGameSelection(){
            int index = Games.SelectedIndex;
            string value = _gameText[index].ToLower();
			if(value == "counter-strike") {
				this.SelectGame("cs");
			}else if(value == "counter-strike source") {
				this.SelectGame("css");
            }else {
                this.SelectGame("cz");
            }
		}

		private void m_select_Click(object sender, System.EventArgs e) {
		    this.OnGameSelection();
			this.DialogResult = DialogResult.OK;
		}

        private void Games_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e) {
            if(e.Index <= _gameText.Length-1) {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);                
                e.Graphics.DrawString(this._gameText[e.Index], this.Font, SystemBrushes.HighlightText, new Point(this._gameIcons.Images[e.Index].Width + 2, e.Bounds.Y + 6));       
                e.Graphics.DrawImage(this._gameIcons.Images[e.Index], new Point(e.Bounds.X, e.Bounds.Y+1));   
                       
                if((e.State & DrawItemState.Focus)==0) {   
                    e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);                    
                    e.Graphics.DrawString(this._gameText[e.Index], this.Font, SystemBrushes.ControlText, new Point(this._gameIcons.Images[e.Index].Width + 2, e.Bounds.Y + 6));
                    e.Graphics.DrawImage(this._gameIcons.Images[e.Index], new Point(e.Bounds.X, e.Bounds.Y+1)); 
                } 
            }
		}
	}
}
