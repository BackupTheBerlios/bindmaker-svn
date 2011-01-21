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
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CZBindMaker {
    public partial class Docs : Form {
        static string docsPath = Path.Combine( Path.GetDirectoryName( Assembly.GetExecutingAssembly( ).Location ), "documentation" );
        static string indexPath = Path.Combine( docsPath, "index.html" );

        protected override void OnLoad( EventArgs e ) {
            base.OnLoad( e );
            if ( Directory.Exists( docsPath ) ) {
                if ( File.Exists( indexPath ) ) {
                    Uri indexUri = new Uri( indexPath );
                    webBrowser1.Navigate( indexUri );
                } else {
                    DisplayMissingDocsMessage( );
                }
            } else {
                DisplayMissingDocsMessage( );
            }
            ResizeUrlCombobox( );
        }

        private void DisplayMissingDocsMessage( ) {
            MessageBox.Show( this, "Missing documentation files.\r\nReinstall to resolve this issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
        public Docs( ) {
            InitializeComponent( );
        }

        private void back_Click( object sender, EventArgs e ) {
            webBrowser1.GoBack( );
        }

        private void forward_Click( object sender, EventArgs e ) {
            webBrowser1.GoForward( );
        }

        private void go_Click( object sender, EventArgs e ) {
            if ( ValidateUrl( ) ) {
                webBrowser1.Navigate( new Uri( urlCombobox.Text ) );
            }
        }

        private bool ValidateUrl( ) {
            bool isValid = false;
            try { new Uri( urlCombobox.Text ); isValid = true; } catch { }
            return isValid;
        }

        private void webBrowser1_Navigated( object sender, WebBrowserNavigatedEventArgs e ) {
            urlCombobox.Text = e.Url.ToString( );
        }

        private void toolStripButton1_Click( object sender, EventArgs e ) {
            webBrowser1.Navigate( new Uri( indexPath ) );
        }

        private void HandleResizeEnd( object sender, EventArgs e ) {
            ResizeUrlCombobox( );
        }

        private void ResizeUrlCombobox( ) {
            int width = (Width - 24 * 5);// 4 buttons @ 23 pixels a piece.
            urlCombobox.Size = new Size( width, urlCombobox.Size.Height );
        }

        private void HandleKeyUp( object sender, KeyEventArgs e ) {
            if ( e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return && ValidateUrl( ) ) {
                webBrowser1.Navigate( urlCombobox.Text );
            }
        }
    }
}
