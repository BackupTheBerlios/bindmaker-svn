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
	public class TempBindItemEditor : System.Windows.Forms.Form {
		private System.Windows.Forms.RichTextBox _script;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
		private System.ComponentModel.Container components = null;
		public delegate void UpdateBindHandler(string bind);
		public event UpdateBindHandler UpdateParent;
		protected virtual void OnUpdateParent(string bind) {
			try {
				this.UpdateParent(bind);
			}catch {}
		}
		public TempBindItemEditor(string script) {
			InitializeComponent();
			this._script.Text = script;
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
			this._script = new System.Windows.Forms.RichTextBox();
			this._ok = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _script
			// 
			this._script.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this._script.DetectUrls = false;
			this._script.Location = new System.Drawing.Point(0, 0);
			this._script.Name = "_script";
			this._script.Size = new System.Drawing.Size(359, 192);
			this._script.TabIndex = 0;
			this._script.Text = "";
			this._script.WordWrap = false;
			// 
			// _ok
			// 
			this._ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._ok.Location = new System.Drawing.Point(103, 200);
			this._ok.Name = "_ok";
			this._ok.TabIndex = 1;
			this._ok.Text = "OK";
			this._ok.Click += new System.EventHandler(this._ok_Click);
			// 
			// _cancel
			// 
			this._cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._cancel.Location = new System.Drawing.Point(183, 200);
			this._cancel.Name = "_cancel";
			this._cancel.TabIndex = 2;
			this._cancel.Text = "Cancel";
			// 
			// TempBindItemEditor
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this._cancel;
			this.ClientSize = new System.Drawing.Size(360, 230);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this._script);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(184, 152);
			this.Name = "TempBindItemEditor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Bind Item Editor";
			this.ResumeLayout(false);

		}

		private void _ok_Click(object sender, System.EventArgs e) {
			if(this._script.Lines.Length > 0) {
				foreach(string s in this._script.Lines) {
					this.OnUpdateParent(s);
				}
				this.DialogResult = DialogResult.OK;
				return;
			}else 
				this.OnUpdateParent("");
				this.DialogResult = DialogResult.Cancel;
		}
	}
}
