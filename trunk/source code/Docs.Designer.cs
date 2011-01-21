namespace CZBindMaker {
    partial class Docs {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Docs ) );
            this.webBrowser1 = new System.Windows.Forms.WebBrowser( );
            this.toolStrip1 = new System.Windows.Forms.ToolStrip( );
            this.back = new System.Windows.Forms.ToolStripButton( );
            this.forward = new System.Windows.Forms.ToolStripButton( );
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton( );
            this.urlCombobox = new System.Windows.Forms.ToolStripComboBox( );
            this.go = new System.Windows.Forms.ToolStripButton( );
            this.toolStrip1.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point( 0, 25 );
            this.webBrowser1.MinimumSize = new System.Drawing.Size( 20, 20 );
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size( 1054, 592 );
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler( this.webBrowser1_Navigated );
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.back,
            this.forward,
            this.toolStripButton1,
            this.urlCombobox,
            this.go} );
            this.toolStrip1.Location = new System.Drawing.Point( 0, 0 );
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size( 1054, 25 );
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // back
            // 
            this.back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.back.Image = global::CZBindMaker.Properties.Resources.DataContainer_MovePreviousHS;
            this.back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size( 23, 22 );
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler( this.back_Click );
            // 
            // forward
            // 
            this.forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forward.Image = global::CZBindMaker.Properties.Resources.DataContainer_MoveNextHS;
            this.forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size( 23, 22 );
            this.forward.Text = "Forward";
            this.forward.Click += new System.EventHandler( this.forward_Click );
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CZBindMaker.Properties.Resources.HomeHS;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size( 23, 22 );
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler( this.toolStripButton1_Click );
            // 
            // urlCombobox
            // 
            this.urlCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.urlCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.urlCombobox.Name = "urlCombobox";
            this.urlCombobox.Size = new System.Drawing.Size( 800, 25 );
            this.urlCombobox.KeyUp += new System.Windows.Forms.KeyEventHandler( this.HandleKeyUp );
            // 
            // go
            // 
            this.go.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.go.Image = global::CZBindMaker.Properties.Resources.GoLtrHS;
            this.go.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size( 23, 22 );
            this.go.Text = "toolStripButton3";
            this.go.Click += new System.EventHandler( this.go_Click );
            // 
            // Docs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 1054, 617 );
            this.Controls.Add( this.webBrowser1 );
            this.Controls.Add( this.toolStrip1 );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "Docs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CodeZulu Bind Maker Documentation";
            this.MaximizedBoundsChanged += new System.EventHandler( this.HandleResizeEnd );
            this.MaximumSizeChanged += new System.EventHandler( this.HandleResizeEnd );
            this.MinimumSizeChanged += new System.EventHandler( this.HandleResizeEnd );
            this.ResizeBegin += new System.EventHandler( this.HandleResizeEnd );
            this.ResizeEnd += new System.EventHandler( this.HandleResizeEnd );
            this.SizeChanged += new System.EventHandler( this.HandleResizeEnd );
            this.Resize += new System.EventHandler( this.HandleResizeEnd );
            this.toolStrip1.ResumeLayout( false );
            this.toolStrip1.PerformLayout( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton back;
        private System.Windows.Forms.ToolStripButton forward;
        private System.Windows.Forms.ToolStripComboBox urlCombobox;
        private System.Windows.Forms.ToolStripButton go;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}