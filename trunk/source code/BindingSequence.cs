/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 * 
 * $Log: BindingSequence.cs,v $
 * Revision 1.4  2005/04/01 07:59:07  madhatter_oz
 * [09/12/04 ]
 *
 * * committing changes for version 1.1.5
 *
 * Revision 1.3  2004/09/13 07:35:05  madhatter_oz
 * [09/07/04 ]
 *
 * * worked on help document, fixed some bugs
 *
 * Revision 1.2  2004/08/29 05:25:29  madhatter_oz
 * [08/29/04 ]
 *
 * * Added feature that clears out current binds list if opening a new config file
 * * Modified binding sequence dialog
 * * Modified algorithm for editing binds in Current Binds List
 * * Updated changelog somewhat
 *
 * Revision 1.1  2004/08/27 07:16:50  madhatter_oz
 * [08/27/04 ]
 *
 * * Fixed some code relating to console color parsing of the config file.
 * * Added a binds sequencing dialog to let users sequence the binding commands
 * * Added algorithm for editing binds in Current Binds List
 *
 * 
 * */

namespace CZBindMaker {
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	public class BindingSequence : System.Windows.Forms.Form {
		private System.Windows.Forms.ListBox _sequence;
		private System.Windows.Forms.Button _moveUP;
		private System.Windows.Forms.Button _moveDown;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
		private System.Windows.Forms.ToolTip _toolTip;
		private BindMap _map;
		private System.Windows.Forms.Button _removeItem;
		private System.ComponentModel.IContainer components;
		internal delegate void PassThrough(ArrayList list);
		internal event PassThrough UpdateOrderedBindsList;
		protected virtual void OnUptateOrderBindsList() {
			try{
				ArrayList a = new ArrayList();
				foreach(object o in this._sequence.Items) {
					a.Add(this._map.GetValue(o));
				}
				this.UpdateOrderedBindsList(a);
			}catch{}
		}


		public BindingSequence(ArrayList items, bool showRemoveItem) {
			this._map = new BindMap();
			InitializeComponent();
			foreach(string s in items) {
				this._sequence.Items.Add(this._map.GetKey(s));
			}  
			this._removeItem.Visible = showRemoveItem;
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BindingSequence));
            this._sequence = new System.Windows.Forms.ListBox();
            this._moveUP = new System.Windows.Forms.Button();
            this._moveDown = new System.Windows.Forms.Button();
            this._ok = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._removeItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _sequence
            // 
            this._sequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this._sequence.Location = new System.Drawing.Point(16, 16);
            this._sequence.Name = "_sequence";
            this._sequence.Size = new System.Drawing.Size(320, 277);
            this._sequence.TabIndex = 0;
            this._toolTip.SetToolTip(this._sequence, "Order: Top to Bottom (Top item s first, bottom item is last)");
            // 
            // _moveUP
            // 
            this._moveUP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._moveUP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._moveUP.Location = new System.Drawing.Point(352, 16);
            this._moveUP.Name = "_moveUP";
            this._moveUP.TabIndex = 1;
            this._moveUP.Text = "Move &Up";
            this._toolTip.SetToolTip(this._moveUP, "Move an item up");
            this._moveUP.Click += new System.EventHandler(this._moveUP_Click);
            // 
            // _moveDown
            // 
            this._moveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._moveDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._moveDown.Location = new System.Drawing.Point(352, 56);
            this._moveDown.Name = "_moveDown";
            this._moveDown.TabIndex = 2;
            this._moveDown.Text = "Move &Down";
            this._toolTip.SetToolTip(this._moveDown, "Move an item down");
            this._moveDown.Click += new System.EventHandler(this._moveDown_Click);
            // 
            // _ok
            // 
            this._ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._ok.Location = new System.Drawing.Point(352, 232);
            this._ok.Name = "_ok";
            this._ok.TabIndex = 4;
            this._ok.Text = "Ok";
            this._toolTip.SetToolTip(this._ok, "Done");
            this._ok.Click += new System.EventHandler(this._ok_Click);
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cancel.Location = new System.Drawing.Point(352, 272);
            this._cancel.Name = "_cancel";
            this._cancel.TabIndex = 5;
            this._cancel.Text = "Cancel";
            this._toolTip.SetToolTip(this._cancel, "Cancel");
            // 
            // _removeItem
            // 
            this._removeItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._removeItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._removeItem.Location = new System.Drawing.Point(352, 136);
            this._removeItem.Name = "_removeItem";
            this._removeItem.TabIndex = 6;
            this._removeItem.Text = "Remove Item";
            this._toolTip.SetToolTip(this._removeItem, "Remove this item");
            this._removeItem.Visible = false;
            this._removeItem.Click += new System.EventHandler(this._removeItem_Click);
            // 
            // BindingSequence
            // 
            this.AcceptButton = this._ok;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._cancel;
            this.ClientSize = new System.Drawing.Size(442, 312);
            this.Controls.Add(this._removeItem);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._ok);
            this.Controls.Add(this._moveDown);
            this.Controls.Add(this._moveUP);
            this.Controls.Add(this._sequence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 338);
            this.Name = "BindingSequence";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Binding Sequence Editor";
            this.ResumeLayout(false);

        }

		//
		private void _moveUP_Click(object sender, System.EventArgs e) {
			int currentIndex = this._sequence.SelectedIndex;
			if(currentIndex > 0) {
				int toIndex = currentIndex-1;
				object temp = this._sequence.Items[currentIndex];
				this._sequence.Items[currentIndex] = this._sequence.Items[toIndex];
				this._sequence.Items[toIndex] = temp;
				this._sequence.SelectedIndex = toIndex;
			}
		}

		private void _moveDown_Click(object sender, System.EventArgs e) {
			int currentIndex = this._sequence.SelectedIndex;
			if(currentIndex > -1 && currentIndex < this._sequence.Items.Count-1) {
				int toIndex = currentIndex+1;
				object temp = this._sequence.Items[currentIndex];
				this._sequence.Items[currentIndex] = this._sequence.Items[toIndex];
				this._sequence.Items[toIndex] = temp;
				this._sequence.SelectedIndex = toIndex;
			}
		}

		private void _ok_Click(object sender, System.EventArgs e) {
			this.OnUptateOrderBindsList();
			this.DialogResult = DialogResult.OK;
		}

		private void _removeItem_Click(object sender, System.EventArgs e) {
			if(this._sequence.SelectedIndex > -1) {
				string message = String.Format("Are you sure you want to remove {0}?\t", this._sequence.SelectedItem.ToString());
				string caption = "Question";
				if(MessageBox.Show(this, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					try {
						this._sequence.Items.Remove(this._sequence.SelectedItem);
					}catch {
						MessageBox.Show(this, "Could not remove the item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
