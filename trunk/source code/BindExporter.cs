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

//namespace CZBindMaker {					 
//	using System;
//	using System.IO;
//	using System.Windows.Forms;
//	using ICSharpCode.SharpZipLib.Zip;
//	internal class BindExporter {
//		private ZipOutputStream		_zipOutFile;
//		private ZipInputStream		_zipInFile;
//		private string[]			_files;
//		private bool				_compress;
//		internal BindExporter(string outputPath, bool compress, params string[] files) {
//			this._zipOutFile	= new ZipOutputStream(new FileStream(outputPath, FileMode.OpenOrCreate, FileAccess.ReadWrite));
//			this._files			= files;
//			this._compress		= compress;
//		}
//		internal void ExportFiles() {
//		}
//		internal void ImportFiles() {
//		}
//	}
//}