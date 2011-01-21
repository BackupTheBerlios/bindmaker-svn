/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 *
 * 
 * */

namespace CZBindMaker {
    using System;
    using System.Collections;
    using System.IO;
    using System.Windows.Forms;
    using ICSharpCode.SharpZipLib.Checksums;
    using ICSharpCode.SharpZipLib.Zip;
	public class ExportDialog : System.Windows.Forms.Form {
		private System.Windows.Forms.TrackBar _compression;
		private System.Windows.Forms.TextBox _cLevel;
		private System.Windows.Forms.SaveFileDialog _saveFileAs;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label _cLevelLabel;
		private ArrayList _files;
		private System.Windows.Forms.FolderBrowserDialog _saveFilesAt;
		private System.Windows.Forms.TextBox _fileNameOrPath;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button _browse;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Label _saveAsLabel;
		private System.Windows.Forms.Panel _bottom;
		private System.Windows.Forms.Panel _middle;
		private System.Windows.Forms.Panel _top;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _backup;
		private bool _compress;

		public ExportDialog(ArrayList files, bool useCompression) {
			InitializeComponent();
			this._files = files;
			if(!useCompression) {
				this._middle.Visible = false;
				this.Height = 150;
				this._compress = false;
				this.Text += " - Non-Compressed";
				this._saveAsLabel.Text = "Destination";
			}else {
				this.Text += " - Using Compression";
				this._compress = true;
			}
			this.progressBar1.Maximum = files.Count;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ExportDialog));
			this._saveAsLabel = new System.Windows.Forms.Label();
			this._fileNameOrPath = new System.Windows.Forms.TextBox();
			this._browse = new System.Windows.Forms.Button();
			this._cLevelLabel = new System.Windows.Forms.Label();
			this._compression = new System.Windows.Forms.TrackBar();
			this._cLevel = new System.Windows.Forms.TextBox();
			this._saveFileAs = new System.Windows.Forms.SaveFileDialog();
			this._saveFilesAt = new System.Windows.Forms.FolderBrowserDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this._ok = new System.Windows.Forms.Button();
			this._bottom = new System.Windows.Forms.Panel();
			this._backup = new System.Windows.Forms.Button();
			this._middle = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._top = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this._compression)).BeginInit();
			this._bottom.SuspendLayout();
			this._middle.SuspendLayout();
			this._top.SuspendLayout();
			this.SuspendLayout();
			// 
			// _saveAsLabel
			// 
			this._saveAsLabel.Location = new System.Drawing.Point(8, 8);
			this._saveAsLabel.Name = "_saveAsLabel";
			this._saveAsLabel.Size = new System.Drawing.Size(72, 16);
			this._saveAsLabel.TabIndex = 0;
			this._saveAsLabel.Text = "Save File As";
			this._saveAsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _fileNameOrPath
			// 
			this._fileNameOrPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._fileNameOrPath.Enabled = false;
			this._fileNameOrPath.Location = new System.Drawing.Point(88, 8);
			this._fileNameOrPath.Name = "_fileNameOrPath";
			this._fileNameOrPath.Size = new System.Drawing.Size(336, 20);
			this._fileNameOrPath.TabIndex = 1;
			this._fileNameOrPath.Text = "";
			// 
			// _browse
			// 
			this._browse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._browse.Location = new System.Drawing.Point(432, 8);
			this._browse.Name = "_browse";
			this._browse.Size = new System.Drawing.Size(64, 20);
			this._browse.TabIndex = 2;
			this._browse.Text = "Browse";
			this._browse.Click += new System.EventHandler(this.button1_Click);
			// 
			// _cLevelLabel
			// 
			this._cLevelLabel.Location = new System.Drawing.Point(8, 24);
			this._cLevelLabel.Name = "_cLevelLabel";
			this._cLevelLabel.Size = new System.Drawing.Size(104, 16);
			this._cLevelLabel.TabIndex = 3;
			this._cLevelLabel.Text = "Compression Level";
			this._cLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _compression
			// 
			this._compression.Location = new System.Drawing.Point(104, 24);
			this._compression.Minimum = 1;
			this._compression.Name = "_compression";
			this._compression.Size = new System.Drawing.Size(352, 45);
			this._compression.TabIndex = 4;
			this._compression.Value = 7;
			this._compression.ValueChanged += new System.EventHandler(this._compression_ValueChanged);
			// 
			// _cLevel
			// 
			this._cLevel.BackColor = System.Drawing.SystemColors.Window;
			this._cLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._cLevel.Location = new System.Drawing.Point(464, 24);
			this._cLevel.Name = "_cLevel";
			this._cLevel.ReadOnly = true;
			this._cLevel.Size = new System.Drawing.Size(24, 20);
			this._cLevel.TabIndex = 5;
			this._cLevel.Text = "7";
			// 
			// _saveFileAs
			// 
			this._saveFileAs.Filter = "Zip File (*.zip) |*.zip";
			this._saveFileAs.Title = "Save Your Exported Game Settings As:";
			// 
			// _saveFilesAt
			// 
			this._saveFilesAt.Description = "Choose the location to back your files up at";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(8, 32);
			this.progressBar1.Maximum = 4;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(488, 16);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Progress";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _ok
			// 
			this._ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._ok.Location = new System.Drawing.Point(424, 64);
			this._ok.Name = "_ok";
			this._ok.TabIndex = 9;
			this._ok.Text = "Close";
			this._ok.Click += new System.EventHandler(this._ok_Click);
			// 
			// _bottom
			// 
			this._bottom.Controls.Add(this._backup);
			this._bottom.Controls.Add(this._ok);
			this._bottom.Controls.Add(this.label2);
			this._bottom.Controls.Add(this.progressBar1);
			this._bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this._bottom.Location = new System.Drawing.Point(0, 88);
			this._bottom.Name = "_bottom";
			this._bottom.Size = new System.Drawing.Size(512, 96);
			this._bottom.TabIndex = 10;
			// 
			// _backup
			// 
			this._backup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._backup.Location = new System.Drawing.Point(8, 64);
			this._backup.Name = "_backup";
			this._backup.TabIndex = 10;
			this._backup.Text = "Backup";
			this._backup.Click += new System.EventHandler(this._backup_Click);
			// 
			// _middle
			// 
			this._middle.Controls.Add(this._compression);
			this._middle.Controls.Add(this._cLevel);
			this._middle.Controls.Add(this._cLevelLabel);
			this._middle.Controls.Add(this.label3);
			this._middle.Controls.Add(this.label1);
			this._middle.Dock = System.Windows.Forms.DockStyle.Fill;
			this._middle.Location = new System.Drawing.Point(0, 32);
			this._middle.Name = "_middle";
			this._middle.Size = new System.Drawing.Size(512, 56);
			this._middle.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(352, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Highest";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(112, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Lowest";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _top
			// 
			this._top.Controls.Add(this._saveAsLabel);
			this._top.Controls.Add(this._browse);
			this._top.Controls.Add(this._fileNameOrPath);
			this._top.Dock = System.Windows.Forms.DockStyle.Top;
			this._top.Location = new System.Drawing.Point(0, 0);
			this._top.Name = "_top";
			this._top.Size = new System.Drawing.Size(512, 32);
			this._top.TabIndex = 12;
			// 
			// ExportDialog
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 184);
			this.Controls.Add(this._middle);
			this.Controls.Add(this._top);
			this.Controls.Add(this._bottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(518, 208);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(518, 150);
			this.Name = "ExportDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "   Export Game Setting Files";
			((System.ComponentModel.ISupportInitialize)(this._compression)).EndInit();
			this._bottom.ResumeLayout(false);
			this._middle.ResumeLayout(false);
			this._top.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private void _compression_ValueChanged(object sender, System.EventArgs e) {
			this._cLevel.Text = this._compression.Value.ToString();
		}

		private void button1_Click(object sender, System.EventArgs e) {
			if(this._compress) {
				if(this._saveFileAs.ShowDialog(this) == DialogResult.OK) {
					this._fileNameOrPath.Text = this._saveFileAs.FileName;
				}
			}else {
				if(this._saveFilesAt.ShowDialog(this) == DialogResult.OK) {
					this._fileNameOrPath.Text = this._saveFilesAt.SelectedPath;
				}
			}
		}

		private void _ok_Click(object sender, System.EventArgs e) {
			this.DialogResult = DialogResult.OK;
		}

		private void _backup_Click(object sender, System.EventArgs e) {
			if(this._fileNameOrPath.Text.Length > 0) {
				if(this._compress) {
					string zipFilePath = this._fileNameOrPath.Text;
					if(!Directory.Exists(Path.GetDirectoryName(zipFilePath))) {
						try {
							Directory.CreateDirectory(Path.GetDirectoryName(zipFilePath));
						}catch {
							MessageBox.Show(this, "You must select a valid path to backup your files to\t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
					this._fileNameOrPath.Text = zipFilePath;
					Crc32 crc = new Crc32();
					ZipOutputStream zipOutput = new ZipOutputStream(File.Create(zipFilePath));
					zipOutput.SetLevel(this._compression.Value - 1);
					foreach(string file in this._files) {
						FileStream fs = File.OpenRead(file);
						byte[] buffer = new byte[fs.Length];
						fs.Read(buffer, 0, buffer.Length);
						ZipEntry entry = new ZipEntry(Path.GetFileName(file));
						entry.Comment = "CZ Bind Maker Backup File";
						entry.DateTime = DateTime.Now;
						entry.Size = fs.Length;
						fs.Close();
						crc.Reset();
						crc.Update(buffer);
						entry.Crc  = crc.Value;
						zipOutput.PutNextEntry(entry);
						zipOutput.Write(buffer, 0, buffer.Length);
						this.progressBar1.PerformStep();
					}
					zipOutput.Finish();
					zipOutput.Close();
					this._backup.Enabled = false;
				}else {
					string filePath = this._fileNameOrPath.Text;
					if(!Directory.Exists(Path.GetDirectoryName(filePath))) {
						try {
							Directory.CreateDirectory(Path.GetDirectoryName(filePath));
						}catch {
							MessageBox.Show(this, "You must melect a valid path to backup your files to\t", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}
					foreach(string file in this._files) {
						string destination = Path.Combine(filePath, Path.GetFileName(file));
						if(File.Exists(destination)) {
							if(MessageBox.Show(this, String.Format("File:\n{0}\t\nAlready Exists.\n\nDo you wish to overwrite it?", destination), "Overwrite File?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
								File.Delete(destination);
							}else {
								this.progressBar1.PerformStep();
								continue;
							}
						}
						File.Copy(file, destination);
						this.progressBar1.PerformStep();
					}
					this._backup.Enabled = false;
				}
			}
		}
	}
}
