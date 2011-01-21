using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CZBindMaker {
    partial class CZBindMakerMainForm {

        private void InitializeComponent( ) {
            this.components = new System.ComponentModel.Container( );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( CZBindMakerMainForm ) );
            this._configFileFinder = new System.Windows.Forms.OpenFileDialog( );
            this._consoleColorPicker = new System.Windows.Forms.ColorDialog( );
            this._toolTip = new System.Windows.Forms.ToolTip( this.components );
            this._rateUpDown = new System.Windows.Forms.NumericUpDown( );
            this._networkRateLabel = new System.Windows.Forms.Label( );
            this.cl_righthand = new System.Windows.Forms.CheckBox( );
            this._cl_autoweaponswitch = new System.Windows.Forms.CheckBox( );
            this._vgui_menus = new System.Windows.Forms.CheckBox( );
            this.net_grappos_2 = new System.Windows.Forms.RadioButton( );
            this.net_grappos_1 = new System.Windows.Forms.RadioButton( );
            this.net_grappos_3 = new System.Windows.Forms.RadioButton( );
            this._fpsRange = new System.Windows.Forms.NumericUpDown( );
            this.cl_weather = new System.Windows.Forms.CheckBox( );
            this.hud_fastswitch = new System.Windows.Forms.CheckBox( );
            this.hud_centerID = new System.Windows.Forms.CheckBox( );
            this.net_graph_0 = new System.Windows.Forms.RadioButton( );
            this.net_graph_3 = new System.Windows.Forms.RadioButton( );
            this.net_graph_2 = new System.Windows.Forms.RadioButton( );
            this.net_graph_1 = new System.Windows.Forms.RadioButton( );
            this._dynamicCrossHairs = new System.Windows.Forms.CheckBox( );
            this._frameRateLabel = new System.Windows.Forms.Label( );
            this._playerName = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this._consoleColorButton = new System.Windows.Forms.Button( );
            this._consoleColorSample = new System.Windows.Forms.Label( );
            this._currentBindListBox = new System.Windows.Forms.ListBox( );
            this.currentBindContextMenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator( );
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator( );
            this.editBindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.inBindmakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.asTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.groupBox1 = new System.Windows.Forms.GroupBox( );
            this.keyboardContextMenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.addBindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.deselectKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.unuseableButton6 = new System.Windows.Forms.RadioButton( );
            this.unuseableButton5 = new System.Windows.Forms.RadioButton( );
            this.unuseableButton4 = new System.Windows.Forms.RadioButton( );
            this.unuseableButton3 = new System.Windows.Forms.RadioButton( );
            this.unuseableButton2 = new System.Windows.Forms.RadioButton( );
            this.unuseableButton1 = new System.Windows.Forms.RadioButton( );
            this.kp_0 = new System.Windows.Forms.RadioButton( );
            this.kp_dot = new System.Windows.Forms.RadioButton( );
            this.kp_rtn = new System.Windows.Forms.RadioButton( );
            this.kp_3 = new System.Windows.Forms.RadioButton( );
            this.kp_2 = new System.Windows.Forms.RadioButton( );
            this.kp_1 = new System.Windows.Forms.RadioButton( );
            this.kp_6 = new System.Windows.Forms.RadioButton( );
            this.kp_5 = new System.Windows.Forms.RadioButton( );
            this.kp_4 = new System.Windows.Forms.RadioButton( );
            this.kp_plus = new System.Windows.Forms.RadioButton( );
            this.kp_9 = new System.Windows.Forms.RadioButton( );
            this.kp_8 = new System.Windows.Forms.RadioButton( );
            this.kp_7 = new System.Windows.Forms.RadioButton( );
            this.kp_dash = new System.Windows.Forms.RadioButton( );
            this.astrisk = new System.Windows.Forms.RadioButton( );
            this.kp_forwardslash = new System.Windows.Forms.RadioButton( );
            this.pause = new System.Windows.Forms.RadioButton( );
            this.rightarrow = new System.Windows.Forms.RadioButton( );
            this.leftarrow = new System.Windows.Forms.RadioButton( );
            this.downarrow = new System.Windows.Forms.RadioButton( );
            this.uparrow = new System.Windows.Forms.RadioButton( );
            this.pagedown = new System.Windows.Forms.RadioButton( );
            this.end = new System.Windows.Forms.RadioButton( );
            this.del = new System.Windows.Forms.RadioButton( );
            this.pageup = new System.Windows.Forms.RadioButton( );
            this.home = new System.Windows.Forms.RadioButton( );
            this.ins = new System.Windows.Forms.RadioButton( );
            this.rctrl = new System.Windows.Forms.RadioButton( );
            this.ralt = new System.Windows.Forms.RadioButton( );
            this.space = new System.Windows.Forms.RadioButton( );
            this.lalt = new System.Windows.Forms.RadioButton( );
            this.lctrl = new System.Windows.Forms.RadioButton( );
            this.rshift = new System.Windows.Forms.RadioButton( );
            this.forwardslash = new System.Windows.Forms.RadioButton( );
            this.closed_tag = new System.Windows.Forms.RadioButton( );
            this.open_tag = new System.Windows.Forms.RadioButton( );
            this.mkey = new System.Windows.Forms.RadioButton( );
            this.nkey = new System.Windows.Forms.RadioButton( );
            this.bkey = new System.Windows.Forms.RadioButton( );
            this.vkey = new System.Windows.Forms.RadioButton( );
            this.ckey = new System.Windows.Forms.RadioButton( );
            this.xkey = new System.Windows.Forms.RadioButton( );
            this.zkey = new System.Windows.Forms.RadioButton( );
            this.lshift = new System.Windows.Forms.RadioButton( );
            this.enter = new System.Windows.Forms.RadioButton( );
            this.quotes = new System.Windows.Forms.RadioButton( );
            this.semicol = new System.Windows.Forms.RadioButton( );
            this.lkey = new System.Windows.Forms.RadioButton( );
            this.kkey = new System.Windows.Forms.RadioButton( );
            this.jkey = new System.Windows.Forms.RadioButton( );
            this.hkey = new System.Windows.Forms.RadioButton( );
            this.gkey = new System.Windows.Forms.RadioButton( );
            this.fkey = new System.Windows.Forms.RadioButton( );
            this.dkey = new System.Windows.Forms.RadioButton( );
            this.skey = new System.Windows.Forms.RadioButton( );
            this.akey = new System.Windows.Forms.RadioButton( );
            this.caps = new System.Windows.Forms.RadioButton( );
            this.backslash = new System.Windows.Forms.RadioButton( );
            this.closed_square_brace_key = new System.Windows.Forms.RadioButton( );
            this.open_square_brace_key = new System.Windows.Forms.RadioButton( );
            this.pkey = new System.Windows.Forms.RadioButton( );
            this.okey = new System.Windows.Forms.RadioButton( );
            this.ikey = new System.Windows.Forms.RadioButton( );
            this.ukey = new System.Windows.Forms.RadioButton( );
            this.ykey = new System.Windows.Forms.RadioButton( );
            this.tkey = new System.Windows.Forms.RadioButton( );
            this.rkey = new System.Windows.Forms.RadioButton( );
            this.ekey = new System.Windows.Forms.RadioButton( );
            this.wkey = new System.Windows.Forms.RadioButton( );
            this.qkey = new System.Windows.Forms.RadioButton( );
            this.tab = new System.Windows.Forms.RadioButton( );
            this.backspace = new System.Windows.Forms.RadioButton( );
            this.equals = new System.Windows.Forms.RadioButton( );
            this.dash = new System.Windows.Forms.RadioButton( );
            this.zero = new System.Windows.Forms.RadioButton( );
            this.nine = new System.Windows.Forms.RadioButton( );
            this.eight = new System.Windows.Forms.RadioButton( );
            this.seven = new System.Windows.Forms.RadioButton( );
            this.six = new System.Windows.Forms.RadioButton( );
            this.five = new System.Windows.Forms.RadioButton( );
            this.four = new System.Windows.Forms.RadioButton( );
            this.three = new System.Windows.Forms.RadioButton( );
            this.two = new System.Windows.Forms.RadioButton( );
            this.one = new System.Windows.Forms.RadioButton( );
            this.tilda = new System.Windows.Forms.RadioButton( );
            this.f12 = new System.Windows.Forms.RadioButton( );
            this.f11 = new System.Windows.Forms.RadioButton( );
            this.f10 = new System.Windows.Forms.RadioButton( );
            this.f9 = new System.Windows.Forms.RadioButton( );
            this.f8 = new System.Windows.Forms.RadioButton( );
            this.f7 = new System.Windows.Forms.RadioButton( );
            this.f6 = new System.Windows.Forms.RadioButton( );
            this.f5 = new System.Windows.Forms.RadioButton( );
            this.f4 = new System.Windows.Forms.RadioButton( );
            this.f3 = new System.Windows.Forms.RadioButton( );
            this.f2 = new System.Windows.Forms.RadioButton( );
            this.f1 = new System.Windows.Forms.RadioButton( );
            this.esc = new System.Windows.Forms.RadioButton( );
            this._logoPictureBox = new System.Windows.Forms.PictureBox( );
            this.binds_tabPage = new System.Windows.Forms.TabPage( );
            this._bindOptionsListBox = new System.Windows.Forms.CheckedListBox( );
            this.bindOptionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.addBindToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem( );
            this.uncheckItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator( );
            this.editItemsSequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStrip3 = new System.Windows.Forms.ToolStrip( );
            this._enableSayItem = new System.Windows.Forms.ToolStripButton( );
            this.sayTeamSayComboBox = new System.Windows.Forms.ToolStripComboBox( );
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel( );
            this.sayTeamSayTextBox = new System.Windows.Forms.ToolStripTextBox( );
            this.removeSayTeamSayToolStripButton = new System.Windows.Forms.ToolStripButton( );
            this.config_tabPage = new System.Windows.Forms.TabPage( );
            this._crosshairSize = new System.Windows.Forms.ComboBox( );
            this._crosshairSizeLabel = new System.Windows.Forms.Label( );
            this._solidCrosshair = new System.Windows.Forms.CheckBox( );
            this._editCrosshairColor = new System.Windows.Forms.Button( );
            this._crosshairSampleImage = new System.Windows.Forms.PictureBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.cl_radartype = new System.Windows.Forms.CheckBox( );
            this.groupBox3 = new System.Windows.Forms.GroupBox( );
            this.net_graph_GroupBox = new System.Windows.Forms.GroupBox( );
            this._customBind = new System.Windows.Forms.TextBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this._showOrder = new System.Windows.Forms.Button( );
            this._mainTabControl = new Dotnetrix.Controls.TabControlEX( );
            this._contextImageList = new System.Windows.Forms.ImageList( this.components );
            this.groupBox2 = new System.Windows.Forms.GroupBox( );
            this._crosshairs = new System.Windows.Forms.ImageList( this.components );
            this._exportAs = new System.Windows.Forms.FolderBrowserDialog( );
            this.menuStrip1 = new System.Windows.Forms.MenuStrip( );
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator( );
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.compressedFileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.exportAllConfigsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator( );
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator( );
            this.notepadMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.configcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.autoexeccfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.userconfigcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.czbindcfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator( );
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator( );
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.panel1 = new System.Windows.Forms.Panel( );
            this.panel2 = new System.Windows.Forms.Panel( );
            this.panel3 = new System.Windows.Forms.Panel( );
            this.toolStrip2 = new System.Windows.Forms.ToolStrip( );
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel( );
            this.radioCommandsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox( );
            this.clearRadioCommandsToolStripButton = new System.Windows.Forms.ToolStripButton( );
            this.toolStrip1 = new System.Windows.Forms.ToolStrip( );
            this.addBindToolBarButton = new System.Windows.Forms.ToolStripButton( );
            this.deleteBindToolBarButton = new System.Windows.Forms.ToolStripButton( );
            this.saveButton = new System.Windows.Forms.ToolStripButton( );
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator( );
            this.undoStripButton = new System.Windows.Forms.ToolStripButton( );
            this.redoStripButton = new System.Windows.Forms.ToolStripButton( );
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer( );
            this.splitter1 = new System.Windows.Forms.Splitter( );
            ( (System.ComponentModel.ISupportInitialize)( this._rateUpDown ) ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)( this._fpsRange ) ).BeginInit( );
            this.currentBindContextMenuStrip.SuspendLayout( );
            this.groupBox1.SuspendLayout( );
            this.keyboardContextMenuStrip.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)( this._logoPictureBox ) ).BeginInit( );
            this.binds_tabPage.SuspendLayout( );
            this.bindOptionsContextMenuStrip.SuspendLayout( );
            this.toolStrip3.SuspendLayout( );
            this.config_tabPage.SuspendLayout( );
            ( (System.ComponentModel.ISupportInitialize)( this._crosshairSampleImage ) ).BeginInit( );
            this.groupBox3.SuspendLayout( );
            this.net_graph_GroupBox.SuspendLayout( );
            this._mainTabControl.SuspendLayout( );
            this.groupBox2.SuspendLayout( );
            this.menuStrip1.SuspendLayout( );
            this.panel1.SuspendLayout( );
            this.panel2.SuspendLayout( );
            this.panel3.SuspendLayout( );
            this.toolStrip2.SuspendLayout( );
            this.toolStrip1.SuspendLayout( );
            this.toolStripContainer1.ContentPanel.SuspendLayout( );
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout( );
            this.toolStripContainer1.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // _configFileFinder
            // 
            this._configFileFinder.FileName = "config.cfg";
            this._configFileFinder.Filter = "Config files | *.cfg";
            this._configFileFinder.Title = " Locate Your Counter-Strike Config.cfg File";
            // 
            // _consoleColorPicker
            // 
            this._consoleColorPicker.AnyColor = true;
            this._consoleColorPicker.Color = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );
            this._consoleColorPicker.FullOpen = true;
            // 
            // _rateUpDown
            // 
            this._rateUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._rateUpDown.Location = new System.Drawing.Point( 320, 208 );
            this._rateUpDown.Maximum = new decimal( new int[] {
            20000000,
            0,
            0,
            0} );
            this._rateUpDown.Name = "_rateUpDown";
            this._rateUpDown.Size = new System.Drawing.Size( 56, 20 );
            this._rateUpDown.TabIndex = 63;
            this._toolTip.SetToolTip( this._rateUpDown, "Sets the rate at which you send and recieve information to and from the server" );
            this._rateUpDown.Value = new decimal( new int[] {
            2500,
            0,
            0,
            0} );
            // 
            // _networkRateLabel
            // 
            this._networkRateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._networkRateLabel.Location = new System.Drawing.Point( 237, 208 );
            this._networkRateLabel.Name = "_networkRateLabel";
            this._networkRateLabel.Size = new System.Drawing.Size( 80, 16 );
            this._networkRateLabel.TabIndex = 62;
            this._networkRateLabel.Text = "Network Rate";
            this._networkRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._toolTip.SetToolTip( this._networkRateLabel, "Sets the rate at which you send and recieve information to and from the server" );
            // 
            // cl_righthand
            // 
            this.cl_righthand.Checked = true;
            this.cl_righthand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cl_righthand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cl_righthand.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cl_righthand.Location = new System.Drawing.Point( 16, 240 );
            this.cl_righthand.Name = "cl_righthand";
            this.cl_righthand.Size = new System.Drawing.Size( 160, 16 );
            this.cl_righthand.TabIndex = 61;
            this.cl_righthand.Text = "Right Handed Player Model";
            this._toolTip.SetToolTip( this.cl_righthand, "Uncheck to use a left handed model" );
            // 
            // _cl_autoweaponswitch
            // 
            this._cl_autoweaponswitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cl_autoweaponswitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._cl_autoweaponswitch.Location = new System.Drawing.Point( 16, 208 );
            this._cl_autoweaponswitch.Name = "_cl_autoweaponswitch";
            this._cl_autoweaponswitch.Size = new System.Drawing.Size( 152, 16 );
            this._cl_autoweaponswitch.TabIndex = 60;
            this._cl_autoweaponswitch.Text = "Use Auto-Weapon Switch";
            this._toolTip.SetToolTip( this._cl_autoweaponswitch, "This will automatically switch to weapons that you pick up \nwhich are greater tha" +
                    "n weapons you currently have" );
            // 
            // _vgui_menus
            // 
            this._vgui_menus.Checked = true;
            this._vgui_menus.CheckState = System.Windows.Forms.CheckState.Checked;
            this._vgui_menus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._vgui_menus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._vgui_menus.Location = new System.Drawing.Point( 16, 224 );
            this._vgui_menus.Name = "_vgui_menus";
            this._vgui_menus.Size = new System.Drawing.Size( 72, 16 );
            this._vgui_menus.TabIndex = 59;
            this._vgui_menus.Text = "Use vGui";
            this._toolTip.SetToolTip( this._vgui_menus, "Uncheck to use old text menus" );
            // 
            // net_grappos_2
            // 
            this.net_grappos_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.net_grappos_2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.net_grappos_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.net_grappos_2.Location = new System.Drawing.Point( 69, 16 );
            this.net_grappos_2.Name = "net_grappos_2";
            this.net_grappos_2.Size = new System.Drawing.Size( 56, 18 );
            this.net_grappos_2.TabIndex = 2;
            this.net_grappos_2.Text = "Middle";
            this.net_grappos_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._toolTip.SetToolTip( this.net_grappos_2, "The Net Graph will be positioned at the bottom middle of the screen" );
            // 
            // net_grappos_1
            // 
            this.net_grappos_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.net_grappos_1.Checked = true;
            this.net_grappos_1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.net_grappos_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.net_grappos_1.Location = new System.Drawing.Point( 128, 16 );
            this.net_grappos_1.Name = "net_grappos_1";
            this.net_grappos_1.Size = new System.Drawing.Size( 56, 18 );
            this.net_grappos_1.TabIndex = 1;
            this.net_grappos_1.TabStop = true;
            this.net_grappos_1.Text = "Right";
            this.net_grappos_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._toolTip.SetToolTip( this.net_grappos_1, "The Net Graph will be positioned at the bottom right hand corner of the screen" );
            // 
            // net_grappos_3
            // 
            this.net_grappos_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.net_grappos_3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.net_grappos_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.net_grappos_3.Location = new System.Drawing.Point( 10, 16 );
            this.net_grappos_3.Name = "net_grappos_3";
            this.net_grappos_3.Size = new System.Drawing.Size( 56, 18 );
            this.net_grappos_3.TabIndex = 0;
            this.net_grappos_3.Text = "Left";
            this.net_grappos_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._toolTip.SetToolTip( this.net_grappos_3, "The Net Graph will be positioned at the bottom left hand corner of the screen" );
            // 
            // _fpsRange
            // 
            this._fpsRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._fpsRange.Location = new System.Drawing.Point( 320, 184 );
            this._fpsRange.Maximum = new decimal( new int[] {
            200000,
            0,
            0,
            0} );
            this._fpsRange.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            0} );
            this._fpsRange.Name = "_fpsRange";
            this._fpsRange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._fpsRange.Size = new System.Drawing.Size( 56, 20 );
            this._fpsRange.TabIndex = 52;
            this._toolTip.SetToolTip( this._fpsRange, "Sets the maximum viewable frames per second" );
            this._fpsRange.Value = new decimal( new int[] {
            100,
            0,
            0,
            0} );
            // 
            // cl_weather
            // 
            this.cl_weather.Checked = true;
            this.cl_weather.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cl_weather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cl_weather.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cl_weather.Location = new System.Drawing.Point( 16, 144 );
            this.cl_weather.Name = "cl_weather";
            this.cl_weather.Size = new System.Drawing.Size( 152, 16 );
            this.cl_weather.TabIndex = 57;
            this.cl_weather.Text = "Show the Maps\' Weather";
            this._toolTip.SetToolTip( this.cl_weather, "This Allows you to toggle the current maps weather conditions on or off\nEX: de_az" +
                    "tec\'s fog and rain" );
            // 
            // hud_fastswitch
            // 
            this.hud_fastswitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hud_fastswitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hud_fastswitch.Location = new System.Drawing.Point( 16, 176 );
            this.hud_fastswitch.Name = "hud_fastswitch";
            this.hud_fastswitch.Size = new System.Drawing.Size( 136, 16 );
            this.hud_fastswitch.TabIndex = 56;
            this.hud_fastswitch.Text = "Use Fast Switch";
            this._toolTip.SetToolTip( this.hud_fastswitch, "Scrolling through inventory causes the item to be selected" );
            // 
            // hud_centerID
            // 
            this.hud_centerID.Checked = true;
            this.hud_centerID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hud_centerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hud_centerID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hud_centerID.Location = new System.Drawing.Point( 16, 192 );
            this.hud_centerID.Name = "hud_centerID";
            this.hud_centerID.Size = new System.Drawing.Size( 184, 16 );
            this.hud_centerID.TabIndex = 55;
            this.hud_centerID.Text = "Center Player Names on Screen";
            this._toolTip.SetToolTip( this.hud_centerID, "puts the players name near crosshairs if selected\nOtherwise it will be located at" +
                    " the bottom of the screen" );
            // 
            // net_graph_0
            // 
            this.net_graph_0.Checked = true;
            this.net_graph_0.Image = ( (System.Drawing.Image)( resources.GetObject( "net_graph_0.Image" ) ) );
            this.net_graph_0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.net_graph_0.Location = new System.Drawing.Point( 10, 16 );
            this.net_graph_0.Name = "net_graph_0";
            this.net_graph_0.Size = new System.Drawing.Size( 37, 48 );
            this.net_graph_0.TabIndex = 3;
            this.net_graph_0.TabStop = true;
            this.net_graph_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._toolTip.SetToolTip( this.net_graph_0, "Select No Net Graph" );
            // 
            // net_graph_3
            // 
            this.net_graph_3.BackColor = System.Drawing.SystemColors.Control;
            this.net_graph_3.Image = ( (System.Drawing.Image)( resources.GetObject( "net_graph_3.Image" ) ) );
            this.net_graph_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.net_graph_3.Location = new System.Drawing.Point( 256, 16 );
            this.net_graph_3.Name = "net_graph_3";
            this.net_graph_3.Size = new System.Drawing.Size( 87, 48 );
            this.net_graph_3.TabIndex = 2;
            this._toolTip.SetToolTip( this.net_graph_3, "The Net Graph will look like this" );
            this.net_graph_3.UseVisualStyleBackColor = false;
            // 
            // net_graph_2
            // 
            this.net_graph_2.BackColor = System.Drawing.SystemColors.Control;
            this.net_graph_2.Image = ( (System.Drawing.Image)( resources.GetObject( "net_graph_2.Image" ) ) );
            this.net_graph_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.net_graph_2.Location = new System.Drawing.Point( 160, 16 );
            this.net_graph_2.Name = "net_graph_2";
            this.net_graph_2.Size = new System.Drawing.Size( 85, 48 );
            this.net_graph_2.TabIndex = 1;
            this._toolTip.SetToolTip( this.net_graph_2, "The Net Graph will look like this" );
            this.net_graph_2.UseVisualStyleBackColor = false;
            // 
            // net_graph_1
            // 
            this.net_graph_1.BackColor = System.Drawing.SystemColors.Control;
            this.net_graph_1.Image = ( (System.Drawing.Image)( resources.GetObject( "net_graph_1.Image" ) ) );
            this.net_graph_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.net_graph_1.Location = new System.Drawing.Point( 56, 16 );
            this.net_graph_1.Name = "net_graph_1";
            this.net_graph_1.Size = new System.Drawing.Size( 91, 48 );
            this.net_graph_1.TabIndex = 0;
            this._toolTip.SetToolTip( this.net_graph_1, "The Net Graph will look like this" );
            this.net_graph_1.UseVisualStyleBackColor = false;
            // 
            // _dynamicCrossHairs
            // 
            this._dynamicCrossHairs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._dynamicCrossHairs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._dynamicCrossHairs.Location = new System.Drawing.Point( 16, 160 );
            this._dynamicCrossHairs.Name = "_dynamicCrossHairs";
            this._dynamicCrossHairs.Size = new System.Drawing.Size( 152, 16 );
            this._dynamicCrossHairs.TabIndex = 53;
            this._dynamicCrossHairs.Text = "Use Dynamic Cross Hair";
            this._toolTip.SetToolTip( this._dynamicCrossHairs, "Toggles the use of a dynamic crosshair.\n(crosshair will shrink/expand when runnin" +
                    "g if enabled)" );
            // 
            // _frameRateLabel
            // 
            this._frameRateLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._frameRateLabel.Location = new System.Drawing.Point( 224, 184 );
            this._frameRateLabel.Name = "_frameRateLabel";
            this._frameRateLabel.Size = new System.Drawing.Size( 96, 16 );
            this._frameRateLabel.TabIndex = 51;
            this._frameRateLabel.Text = "Max Frame Rate";
            this._frameRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._toolTip.SetToolTip( this._frameRateLabel, "Sets the maximum viewable frames per second" );
            // 
            // _playerName
            // 
            this._playerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._playerName.Font = new System.Drawing.Font( "Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World );
            this._playerName.Location = new System.Drawing.Point( 80, 8 );
            this._playerName.Name = "_playerName";
            this._playerName.Size = new System.Drawing.Size( 296, 21 );
            this._playerName.TabIndex = 50;
            this._toolTip.SetToolTip( this._playerName, "Set Your User/Player Name" );
            // 
            // label1
            // 
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point( 16, 8 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 64, 16 );
            this.label1.TabIndex = 49;
            this.label1.Text = "User Name";
            this._toolTip.SetToolTip( this.label1, "Set Your User/Player Name" );
            // 
            // _consoleColorButton
            // 
            this._consoleColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._consoleColorButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._consoleColorButton.Location = new System.Drawing.Point( 280, 32 );
            this._consoleColorButton.Name = "_consoleColorButton";
            this._consoleColorButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._consoleColorButton.Size = new System.Drawing.Size( 96, 24 );
            this._consoleColorButton.TabIndex = 48;
            this._consoleColorButton.Text = "Edit Text Color";
            this._toolTip.SetToolTip( this._consoleColorButton, "Click here to change the color of your in game text" );
            this._consoleColorButton.Click += new System.EventHandler( this.Consolecolor_Click );
            // 
            // _consoleColorSample
            // 
            this._consoleColorSample.BackColor = System.Drawing.Color.Black;
            this._consoleColorSample.Font = new System.Drawing.Font( "Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World );
            this._consoleColorSample.ForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ), ( (int)( ( (byte)( 0 ) ) ) ) );
            this._consoleColorSample.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._consoleColorSample.Location = new System.Drawing.Point( 16, 32 );
            this._consoleColorSample.Name = "_consoleColorSample";
            this._consoleColorSample.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._consoleColorSample.Size = new System.Drawing.Size( 256, 24 );
            this._consoleColorSample.TabIndex = 47;
            this._consoleColorSample.Text = "    Sample In-Game Text Color";
            this._consoleColorSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._toolTip.SetToolTip( this._consoleColorSample, "This is a sample of your in game text color" );
            // 
            // _currentBindListBox
            // 
            this._currentBindListBox.BackColor = System.Drawing.Color.White;
            this._currentBindListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._currentBindListBox.ContextMenuStrip = this.currentBindContextMenuStrip;
            this._currentBindListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._currentBindListBox.ForeColor = System.Drawing.Color.Black;
            this._currentBindListBox.HorizontalScrollbar = true;
            this._currentBindListBox.Location = new System.Drawing.Point( 3, 16 );
            this._currentBindListBox.Name = "_currentBindListBox";
            this._currentBindListBox.Size = new System.Drawing.Size( 368, 300 );
            this._currentBindListBox.Sorted = true;
            this._currentBindListBox.TabIndex = 0;
            this._currentBindListBox.Tag = "Current Bind Settings";
            this._toolTip.SetToolTip( this._currentBindListBox, "This is all of your current custom binds" );
            this._currentBindListBox.MouseEnter += new System.EventHandler( this.CurrentBind_ListBox_MouseEnter );
            // 
            // currentBindContextMenuStrip
            // 
            this.currentBindContextMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.editBindToolStripMenuItem} );
            this.currentBindContextMenuStrip.Name = "currentBindContextMenuStrip";
            this.currentBindContextMenuStrip.Size = new System.Drawing.Size( 144, 82 );
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "deleteToolStripMenuItem.Image" ) ) );
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size( 143, 22 );
            this.deleteToolStripMenuItem.Text = "Delete Bind";
            this.deleteToolStripMenuItem.Click += new System.EventHandler( this.HandleDeleteBind );
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size( 140, 6 );
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "saveSettingsToolStripMenuItem.Image" ) ) );
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size( 143, 22 );
            this.saveSettingsToolStripMenuItem.Text = "Save Settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler( this.HandleSaveConfigs );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 140, 6 );
            // 
            // editBindToolStripMenuItem
            // 
            this.editBindToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.inBindmakerToolStripMenuItem,
            this.asTextToolStripMenuItem} );
            this.editBindToolStripMenuItem.Name = "editBindToolStripMenuItem";
            this.editBindToolStripMenuItem.Size = new System.Drawing.Size( 143, 22 );
            this.editBindToolStripMenuItem.Text = "Edit Bind";
            // 
            // inBindmakerToolStripMenuItem
            // 
            this.inBindmakerToolStripMenuItem.Name = "inBindmakerToolStripMenuItem";
            this.inBindmakerToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
            this.inBindmakerToolStripMenuItem.Text = "In Bind Maker";
            this.inBindmakerToolStripMenuItem.Click += new System.EventHandler( this.HandleEditInBindmaker );
            // 
            // asTextToolStripMenuItem
            // 
            this.asTextToolStripMenuItem.Name = "asTextToolStripMenuItem";
            this.asTextToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
            this.asTextToolStripMenuItem.Text = "As Text";
            this.asTextToolStripMenuItem.Click += new System.EventHandler( this.HandleEditAsText );
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.ContextMenuStrip = this.keyboardContextMenuStrip;
            this.groupBox1.Controls.Add( this.unuseableButton6 );
            this.groupBox1.Controls.Add( this.unuseableButton5 );
            this.groupBox1.Controls.Add( this.unuseableButton4 );
            this.groupBox1.Controls.Add( this.unuseableButton3 );
            this.groupBox1.Controls.Add( this.unuseableButton2 );
            this.groupBox1.Controls.Add( this.unuseableButton1 );
            this.groupBox1.Controls.Add( this.kp_0 );
            this.groupBox1.Controls.Add( this.kp_dot );
            this.groupBox1.Controls.Add( this.kp_rtn );
            this.groupBox1.Controls.Add( this.kp_3 );
            this.groupBox1.Controls.Add( this.kp_2 );
            this.groupBox1.Controls.Add( this.kp_1 );
            this.groupBox1.Controls.Add( this.kp_6 );
            this.groupBox1.Controls.Add( this.kp_5 );
            this.groupBox1.Controls.Add( this.kp_4 );
            this.groupBox1.Controls.Add( this.kp_plus );
            this.groupBox1.Controls.Add( this.kp_9 );
            this.groupBox1.Controls.Add( this.kp_8 );
            this.groupBox1.Controls.Add( this.kp_7 );
            this.groupBox1.Controls.Add( this.kp_dash );
            this.groupBox1.Controls.Add( this.astrisk );
            this.groupBox1.Controls.Add( this.kp_forwardslash );
            this.groupBox1.Controls.Add( this.pause );
            this.groupBox1.Controls.Add( this.rightarrow );
            this.groupBox1.Controls.Add( this.leftarrow );
            this.groupBox1.Controls.Add( this.downarrow );
            this.groupBox1.Controls.Add( this.uparrow );
            this.groupBox1.Controls.Add( this.pagedown );
            this.groupBox1.Controls.Add( this.end );
            this.groupBox1.Controls.Add( this.del );
            this.groupBox1.Controls.Add( this.pageup );
            this.groupBox1.Controls.Add( this.home );
            this.groupBox1.Controls.Add( this.ins );
            this.groupBox1.Controls.Add( this.rctrl );
            this.groupBox1.Controls.Add( this.ralt );
            this.groupBox1.Controls.Add( this.space );
            this.groupBox1.Controls.Add( this.lalt );
            this.groupBox1.Controls.Add( this.lctrl );
            this.groupBox1.Controls.Add( this.rshift );
            this.groupBox1.Controls.Add( this.forwardslash );
            this.groupBox1.Controls.Add( this.closed_tag );
            this.groupBox1.Controls.Add( this.open_tag );
            this.groupBox1.Controls.Add( this.mkey );
            this.groupBox1.Controls.Add( this.nkey );
            this.groupBox1.Controls.Add( this.bkey );
            this.groupBox1.Controls.Add( this.vkey );
            this.groupBox1.Controls.Add( this.ckey );
            this.groupBox1.Controls.Add( this.xkey );
            this.groupBox1.Controls.Add( this.zkey );
            this.groupBox1.Controls.Add( this.lshift );
            this.groupBox1.Controls.Add( this.enter );
            this.groupBox1.Controls.Add( this.quotes );
            this.groupBox1.Controls.Add( this.semicol );
            this.groupBox1.Controls.Add( this.lkey );
            this.groupBox1.Controls.Add( this.kkey );
            this.groupBox1.Controls.Add( this.jkey );
            this.groupBox1.Controls.Add( this.hkey );
            this.groupBox1.Controls.Add( this.gkey );
            this.groupBox1.Controls.Add( this.fkey );
            this.groupBox1.Controls.Add( this.dkey );
            this.groupBox1.Controls.Add( this.skey );
            this.groupBox1.Controls.Add( this.akey );
            this.groupBox1.Controls.Add( this.caps );
            this.groupBox1.Controls.Add( this.backslash );
            this.groupBox1.Controls.Add( this.closed_square_brace_key );
            this.groupBox1.Controls.Add( this.open_square_brace_key );
            this.groupBox1.Controls.Add( this.pkey );
            this.groupBox1.Controls.Add( this.okey );
            this.groupBox1.Controls.Add( this.ikey );
            this.groupBox1.Controls.Add( this.ukey );
            this.groupBox1.Controls.Add( this.ykey );
            this.groupBox1.Controls.Add( this.tkey );
            this.groupBox1.Controls.Add( this.rkey );
            this.groupBox1.Controls.Add( this.ekey );
            this.groupBox1.Controls.Add( this.wkey );
            this.groupBox1.Controls.Add( this.qkey );
            this.groupBox1.Controls.Add( this.tab );
            this.groupBox1.Controls.Add( this.backspace );
            this.groupBox1.Controls.Add( this.equals );
            this.groupBox1.Controls.Add( this.dash );
            this.groupBox1.Controls.Add( this.zero );
            this.groupBox1.Controls.Add( this.nine );
            this.groupBox1.Controls.Add( this.eight );
            this.groupBox1.Controls.Add( this.seven );
            this.groupBox1.Controls.Add( this.six );
            this.groupBox1.Controls.Add( this.five );
            this.groupBox1.Controls.Add( this.four );
            this.groupBox1.Controls.Add( this.three );
            this.groupBox1.Controls.Add( this.two );
            this.groupBox1.Controls.Add( this.one );
            this.groupBox1.Controls.Add( this.tilda );
            this.groupBox1.Controls.Add( this.f12 );
            this.groupBox1.Controls.Add( this.f11 );
            this.groupBox1.Controls.Add( this.f10 );
            this.groupBox1.Controls.Add( this.f9 );
            this.groupBox1.Controls.Add( this.f8 );
            this.groupBox1.Controls.Add( this.f7 );
            this.groupBox1.Controls.Add( this.f6 );
            this.groupBox1.Controls.Add( this.f5 );
            this.groupBox1.Controls.Add( this.f4 );
            this.groupBox1.Controls.Add( this.f3 );
            this.groupBox1.Controls.Add( this.f2 );
            this.groupBox1.Controls.Add( this.f1 );
            this.groupBox1.Controls.Add( this.esc );
            this.groupBox1.Controls.Add( this._logoPictureBox );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point( 0, 362 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size( 784, 244 );
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keyboard Layout";
            this._toolTip.SetToolTip( this.groupBox1, "Select keys to bind" );
            // 
            // keyboardContextMenuStrip
            // 
            this.keyboardContextMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.addBindToolStripMenuItem,
            this.deselectKeyToolStripMenuItem} );
            this.keyboardContextMenuStrip.Name = "keyboardContextMenuStrip";
            this.keyboardContextMenuStrip.Size = new System.Drawing.Size( 141, 48 );
            // 
            // addBindToolStripMenuItem
            // 
            this.addBindToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "addBindToolStripMenuItem.Image" ) ) );
            this.addBindToolStripMenuItem.Name = "addBindToolStripMenuItem";
            this.addBindToolStripMenuItem.Size = new System.Drawing.Size( 140, 22 );
            this.addBindToolStripMenuItem.Text = "Add Bind";
            this.addBindToolStripMenuItem.Click += new System.EventHandler( this.HandleAddEditBind );
            // 
            // deselectKeyToolStripMenuItem
            // 
            this.deselectKeyToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "deselectKeyToolStripMenuItem.Image" ) ) );
            this.deselectKeyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deselectKeyToolStripMenuItem.Name = "deselectKeyToolStripMenuItem";
            this.deselectKeyToolStripMenuItem.Size = new System.Drawing.Size( 140, 22 );
            this.deselectKeyToolStripMenuItem.Text = "Deselect Key";
            this.deselectKeyToolStripMenuItem.Click += new System.EventHandler( this.HandleDeselectKey );
            // 
            // unuseableButton6
            // 
            this.unuseableButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.unuseableButton6.Enabled = false;
            this.unuseableButton6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.unuseableButton6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unuseableButton6.Location = new System.Drawing.Point( 552, 24 );
            this.unuseableButton6.Name = "unuseableButton6";
            this.unuseableButton6.Size = new System.Drawing.Size( 32, 32 );
            this.unuseableButton6.TabIndex = 105;
            this.unuseableButton6.Text = "S/L";
            this.unuseableButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unuseableButton5
            // 
            this.unuseableButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.unuseableButton5.Enabled = false;
            this.unuseableButton5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.unuseableButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unuseableButton5.Location = new System.Drawing.Point( 520, 24 );
            this.unuseableButton5.Name = "unuseableButton5";
            this.unuseableButton5.Size = new System.Drawing.Size( 32, 32 );
            this.unuseableButton5.TabIndex = 104;
            this.unuseableButton5.Text = "P/S";
            this.unuseableButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unuseableButton4
            // 
            this.unuseableButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.unuseableButton4.Enabled = false;
            this.unuseableButton4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.unuseableButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unuseableButton4.Location = new System.Drawing.Point( 640, 72 );
            this.unuseableButton4.Name = "unuseableButton4";
            this.unuseableButton4.Size = new System.Drawing.Size( 32, 32 );
            this.unuseableButton4.TabIndex = 103;
            this.unuseableButton4.Text = "Num";
            this.unuseableButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unuseableButton3
            // 
            this.unuseableButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.unuseableButton3.Enabled = false;
            this.unuseableButton3.Image = ( (System.Drawing.Image)( resources.GetObject( "unuseableButton3.Image" ) ) );
            this.unuseableButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unuseableButton3.Location = new System.Drawing.Point( 400, 200 );
            this.unuseableButton3.Name = "unuseableButton3";
            this.unuseableButton3.Size = new System.Drawing.Size( 32, 32 );
            this.unuseableButton3.TabIndex = 102;
            this.unuseableButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unuseableButton2
            // 
            this.unuseableButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.unuseableButton2.Enabled = false;
            this.unuseableButton2.Image = ( (System.Drawing.Image)( resources.GetObject( "unuseableButton2.Image" ) ) );
            this.unuseableButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unuseableButton2.Location = new System.Drawing.Point( 368, 200 );
            this.unuseableButton2.Name = "unuseableButton2";
            this.unuseableButton2.Size = new System.Drawing.Size( 32, 32 );
            this.unuseableButton2.TabIndex = 101;
            this.unuseableButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unuseableButton1
            // 
            this.unuseableButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.unuseableButton1.Enabled = false;
            this.unuseableButton1.Image = ( (System.Drawing.Image)( resources.GetObject( "unuseableButton1.Image" ) ) );
            this.unuseableButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unuseableButton1.Location = new System.Drawing.Point( 72, 200 );
            this.unuseableButton1.Name = "unuseableButton1";
            this.unuseableButton1.Size = new System.Drawing.Size( 32, 32 );
            this.unuseableButton1.TabIndex = 100;
            this.unuseableButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_0
            // 
            this.kp_0.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_0.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_0.Location = new System.Drawing.Point( 640, 200 );
            this.kp_0.Name = "kp_0";
            this.kp_0.Size = new System.Drawing.Size( 64, 32 );
            this.kp_0.TabIndex = 98;
            this.kp_0.Text = "0";
            this.kp_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_dot
            // 
            this.kp_dot.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_dot.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_dot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_dot.Location = new System.Drawing.Point( 704, 200 );
            this.kp_dot.Name = "kp_dot";
            this.kp_dot.Size = new System.Drawing.Size( 32, 32 );
            this.kp_dot.TabIndex = 97;
            this.kp_dot.Text = ".";
            this.kp_dot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_rtn
            // 
            this.kp_rtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_rtn.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_rtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_rtn.Location = new System.Drawing.Point( 736, 168 );
            this.kp_rtn.Name = "kp_rtn";
            this.kp_rtn.Size = new System.Drawing.Size( 32, 64 );
            this.kp_rtn.TabIndex = 95;
            this.kp_rtn.Text = "Rtn";
            this.kp_rtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_3
            // 
            this.kp_3.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_3.Location = new System.Drawing.Point( 704, 168 );
            this.kp_3.Name = "kp_3";
            this.kp_3.Size = new System.Drawing.Size( 32, 32 );
            this.kp_3.TabIndex = 94;
            this.kp_3.Text = "3";
            this.kp_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_2
            // 
            this.kp_2.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_2.Location = new System.Drawing.Point( 672, 168 );
            this.kp_2.Name = "kp_2";
            this.kp_2.Size = new System.Drawing.Size( 32, 32 );
            this.kp_2.TabIndex = 93;
            this.kp_2.Text = "2";
            this.kp_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_1
            // 
            this.kp_1.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_1.Location = new System.Drawing.Point( 640, 168 );
            this.kp_1.Name = "kp_1";
            this.kp_1.Size = new System.Drawing.Size( 32, 32 );
            this.kp_1.TabIndex = 92;
            this.kp_1.Text = "1";
            this.kp_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_6
            // 
            this.kp_6.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_6.Location = new System.Drawing.Point( 704, 136 );
            this.kp_6.Name = "kp_6";
            this.kp_6.Size = new System.Drawing.Size( 32, 32 );
            this.kp_6.TabIndex = 91;
            this.kp_6.Text = "6";
            this.kp_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_5
            // 
            this.kp_5.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_5.Location = new System.Drawing.Point( 672, 136 );
            this.kp_5.Name = "kp_5";
            this.kp_5.Size = new System.Drawing.Size( 32, 32 );
            this.kp_5.TabIndex = 90;
            this.kp_5.Text = "5";
            this.kp_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_4
            // 
            this.kp_4.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_4.Location = new System.Drawing.Point( 640, 136 );
            this.kp_4.Name = "kp_4";
            this.kp_4.Size = new System.Drawing.Size( 32, 32 );
            this.kp_4.TabIndex = 89;
            this.kp_4.Text = "4";
            this.kp_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_plus
            // 
            this.kp_plus.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_plus.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_plus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_plus.Location = new System.Drawing.Point( 736, 104 );
            this.kp_plus.Name = "kp_plus";
            this.kp_plus.Size = new System.Drawing.Size( 32, 64 );
            this.kp_plus.TabIndex = 88;
            this.kp_plus.Text = "+";
            this.kp_plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_9
            // 
            this.kp_9.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_9.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_9.Location = new System.Drawing.Point( 704, 104 );
            this.kp_9.Name = "kp_9";
            this.kp_9.Size = new System.Drawing.Size( 32, 32 );
            this.kp_9.TabIndex = 87;
            this.kp_9.Text = "9";
            this.kp_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_8
            // 
            this.kp_8.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_8.Location = new System.Drawing.Point( 672, 104 );
            this.kp_8.Name = "kp_8";
            this.kp_8.Size = new System.Drawing.Size( 32, 32 );
            this.kp_8.TabIndex = 86;
            this.kp_8.Text = "8";
            this.kp_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_7
            // 
            this.kp_7.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_7.Location = new System.Drawing.Point( 640, 104 );
            this.kp_7.Name = "kp_7";
            this.kp_7.Size = new System.Drawing.Size( 32, 32 );
            this.kp_7.TabIndex = 85;
            this.kp_7.Text = "7";
            this.kp_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_dash
            // 
            this.kp_dash.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_dash.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_dash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_dash.Location = new System.Drawing.Point( 736, 72 );
            this.kp_dash.Name = "kp_dash";
            this.kp_dash.Size = new System.Drawing.Size( 32, 32 );
            this.kp_dash.TabIndex = 84;
            this.kp_dash.Text = "-";
            this.kp_dash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // astrisk
            // 
            this.astrisk.Appearance = System.Windows.Forms.Appearance.Button;
            this.astrisk.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.astrisk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.astrisk.Location = new System.Drawing.Point( 704, 72 );
            this.astrisk.Name = "astrisk";
            this.astrisk.Size = new System.Drawing.Size( 32, 32 );
            this.astrisk.TabIndex = 83;
            this.astrisk.Text = "*";
            this.astrisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kp_forwardslash
            // 
            this.kp_forwardslash.Appearance = System.Windows.Forms.Appearance.Button;
            this.kp_forwardslash.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.kp_forwardslash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kp_forwardslash.Location = new System.Drawing.Point( 672, 72 );
            this.kp_forwardslash.Name = "kp_forwardslash";
            this.kp_forwardslash.Size = new System.Drawing.Size( 32, 32 );
            this.kp_forwardslash.TabIndex = 82;
            this.kp_forwardslash.Text = "/";
            this.kp_forwardslash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pause
            // 
            this.pause.Appearance = System.Windows.Forms.Appearance.Button;
            this.pause.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.pause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pause.Location = new System.Drawing.Point( 584, 24 );
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size( 32, 32 );
            this.pause.TabIndex = 81;
            this.pause.Text = "Pse";
            this.pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightarrow
            // 
            this.rightarrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rightarrow.Image = ( (System.Drawing.Image)( resources.GetObject( "rightarrow.Image" ) ) );
            this.rightarrow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rightarrow.Location = new System.Drawing.Point( 584, 200 );
            this.rightarrow.Name = "rightarrow";
            this.rightarrow.Size = new System.Drawing.Size( 32, 32 );
            this.rightarrow.TabIndex = 80;
            this.rightarrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftarrow
            // 
            this.leftarrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.leftarrow.Image = ( (System.Drawing.Image)( resources.GetObject( "leftarrow.Image" ) ) );
            this.leftarrow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.leftarrow.Location = new System.Drawing.Point( 520, 200 );
            this.leftarrow.Name = "leftarrow";
            this.leftarrow.Size = new System.Drawing.Size( 32, 32 );
            this.leftarrow.TabIndex = 79;
            this.leftarrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downarrow
            // 
            this.downarrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.downarrow.Image = ( (System.Drawing.Image)( resources.GetObject( "downarrow.Image" ) ) );
            this.downarrow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.downarrow.Location = new System.Drawing.Point( 552, 200 );
            this.downarrow.Name = "downarrow";
            this.downarrow.Size = new System.Drawing.Size( 32, 32 );
            this.downarrow.TabIndex = 78;
            this.downarrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uparrow
            // 
            this.uparrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.uparrow.Image = ( (System.Drawing.Image)( resources.GetObject( "uparrow.Image" ) ) );
            this.uparrow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uparrow.Location = new System.Drawing.Point( 552, 168 );
            this.uparrow.Name = "uparrow";
            this.uparrow.Size = new System.Drawing.Size( 32, 32 );
            this.uparrow.TabIndex = 77;
            this.uparrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagedown
            // 
            this.pagedown.Appearance = System.Windows.Forms.Appearance.Button;
            this.pagedown.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.pagedown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pagedown.Location = new System.Drawing.Point( 584, 104 );
            this.pagedown.Name = "pagedown";
            this.pagedown.Size = new System.Drawing.Size( 32, 32 );
            this.pagedown.TabIndex = 76;
            this.pagedown.Text = "PD";
            this.pagedown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end
            // 
            this.end.Appearance = System.Windows.Forms.Appearance.Button;
            this.end.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.end.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.end.Location = new System.Drawing.Point( 552, 104 );
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size( 32, 32 );
            this.end.TabIndex = 75;
            this.end.Text = "End";
            this.end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // del
            // 
            this.del.Appearance = System.Windows.Forms.Appearance.Button;
            this.del.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.del.Location = new System.Drawing.Point( 520, 104 );
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size( 32, 32 );
            this.del.TabIndex = 74;
            this.del.Text = "Del";
            this.del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageup
            // 
            this.pageup.Appearance = System.Windows.Forms.Appearance.Button;
            this.pageup.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.pageup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pageup.Location = new System.Drawing.Point( 584, 72 );
            this.pageup.Name = "pageup";
            this.pageup.Size = new System.Drawing.Size( 32, 32 );
            this.pageup.TabIndex = 73;
            this.pageup.Text = "PU";
            this.pageup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            this.home.Appearance = System.Windows.Forms.Appearance.Button;
            this.home.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.home.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.home.Location = new System.Drawing.Point( 552, 72 );
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size( 32, 32 );
            this.home.TabIndex = 72;
            this.home.Text = "Hm";
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ins
            // 
            this.ins.Appearance = System.Windows.Forms.Appearance.Button;
            this.ins.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.ins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ins.Location = new System.Drawing.Point( 520, 72 );
            this.ins.Name = "ins";
            this.ins.Size = new System.Drawing.Size( 32, 32 );
            this.ins.TabIndex = 71;
            this.ins.Text = "Ins";
            this.ins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rctrl
            // 
            this.rctrl.Appearance = System.Windows.Forms.Appearance.Button;
            this.rctrl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rctrl.Location = new System.Drawing.Point( 432, 200 );
            this.rctrl.Name = "rctrl";
            this.rctrl.Size = new System.Drawing.Size( 64, 32 );
            this.rctrl.TabIndex = 70;
            this.rctrl.Text = "Ctrl";
            this.rctrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ralt
            // 
            this.ralt.Appearance = System.Windows.Forms.Appearance.Button;
            this.ralt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ralt.Location = new System.Drawing.Point( 328, 200 );
            this.ralt.Name = "ralt";
            this.ralt.Size = new System.Drawing.Size( 40, 32 );
            this.ralt.TabIndex = 69;
            this.ralt.Text = "Alt";
            this.ralt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // space
            // 
            this.space.Appearance = System.Windows.Forms.Appearance.Button;
            this.space.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.space.Location = new System.Drawing.Point( 144, 200 );
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size( 184, 32 );
            this.space.TabIndex = 68;
            this.space.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lalt
            // 
            this.lalt.Appearance = System.Windows.Forms.Appearance.Button;
            this.lalt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lalt.Location = new System.Drawing.Point( 104, 200 );
            this.lalt.Name = "lalt";
            this.lalt.Size = new System.Drawing.Size( 40, 32 );
            this.lalt.TabIndex = 67;
            this.lalt.Text = "Alt";
            this.lalt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lctrl
            // 
            this.lctrl.Appearance = System.Windows.Forms.Appearance.Button;
            this.lctrl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lctrl.Location = new System.Drawing.Point( 16, 200 );
            this.lctrl.Name = "lctrl";
            this.lctrl.Size = new System.Drawing.Size( 56, 32 );
            this.lctrl.TabIndex = 66;
            this.lctrl.Text = "Ctrl";
            this.lctrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rshift
            // 
            this.rshift.Appearance = System.Windows.Forms.Appearance.Button;
            this.rshift.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rshift.Location = new System.Drawing.Point( 408, 168 );
            this.rshift.Name = "rshift";
            this.rshift.Size = new System.Drawing.Size( 88, 32 );
            this.rshift.TabIndex = 65;
            this.rshift.Text = "Shift";
            this.rshift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forwardslash
            // 
            this.forwardslash.Appearance = System.Windows.Forms.Appearance.Button;
            this.forwardslash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.forwardslash.Location = new System.Drawing.Point( 376, 168 );
            this.forwardslash.Name = "forwardslash";
            this.forwardslash.Size = new System.Drawing.Size( 32, 32 );
            this.forwardslash.TabIndex = 64;
            this.forwardslash.Text = "/";
            this.forwardslash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closed_tag
            // 
            this.closed_tag.Appearance = System.Windows.Forms.Appearance.Button;
            this.closed_tag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closed_tag.Location = new System.Drawing.Point( 344, 168 );
            this.closed_tag.Name = "closed_tag";
            this.closed_tag.Size = new System.Drawing.Size( 32, 32 );
            this.closed_tag.TabIndex = 63;
            this.closed_tag.Text = ">";
            this.closed_tag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // open_tag
            // 
            this.open_tag.Appearance = System.Windows.Forms.Appearance.Button;
            this.open_tag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.open_tag.Location = new System.Drawing.Point( 312, 168 );
            this.open_tag.Name = "open_tag";
            this.open_tag.Size = new System.Drawing.Size( 32, 32 );
            this.open_tag.TabIndex = 62;
            this.open_tag.Text = "<";
            this.open_tag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mkey
            // 
            this.mkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.mkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mkey.Location = new System.Drawing.Point( 280, 168 );
            this.mkey.Name = "mkey";
            this.mkey.Size = new System.Drawing.Size( 32, 32 );
            this.mkey.TabIndex = 61;
            this.mkey.Text = "M";
            this.mkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nkey
            // 
            this.nkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.nkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nkey.Location = new System.Drawing.Point( 248, 168 );
            this.nkey.Name = "nkey";
            this.nkey.Size = new System.Drawing.Size( 32, 32 );
            this.nkey.TabIndex = 60;
            this.nkey.Text = "N";
            this.nkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bkey
            // 
            this.bkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.bkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bkey.Location = new System.Drawing.Point( 216, 168 );
            this.bkey.Name = "bkey";
            this.bkey.Size = new System.Drawing.Size( 32, 32 );
            this.bkey.TabIndex = 59;
            this.bkey.Text = "B";
            this.bkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vkey
            // 
            this.vkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.vkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vkey.Location = new System.Drawing.Point( 184, 168 );
            this.vkey.Name = "vkey";
            this.vkey.Size = new System.Drawing.Size( 32, 32 );
            this.vkey.TabIndex = 58;
            this.vkey.Text = "V";
            this.vkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckey
            // 
            this.ckey.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ckey.Location = new System.Drawing.Point( 152, 168 );
            this.ckey.Name = "ckey";
            this.ckey.Size = new System.Drawing.Size( 32, 32 );
            this.ckey.TabIndex = 57;
            this.ckey.Text = "C";
            this.ckey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xkey
            // 
            this.xkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.xkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xkey.Location = new System.Drawing.Point( 120, 168 );
            this.xkey.Name = "xkey";
            this.xkey.Size = new System.Drawing.Size( 32, 32 );
            this.xkey.TabIndex = 56;
            this.xkey.Text = "X";
            this.xkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zkey
            // 
            this.zkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.zkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zkey.Location = new System.Drawing.Point( 88, 168 );
            this.zkey.Name = "zkey";
            this.zkey.Size = new System.Drawing.Size( 32, 32 );
            this.zkey.TabIndex = 55;
            this.zkey.Text = "Z";
            this.zkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lshift
            // 
            this.lshift.Appearance = System.Windows.Forms.Appearance.Button;
            this.lshift.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lshift.Location = new System.Drawing.Point( 16, 168 );
            this.lshift.Name = "lshift";
            this.lshift.Size = new System.Drawing.Size( 72, 32 );
            this.lshift.TabIndex = 54;
            this.lshift.Text = "Shift";
            this.lshift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enter
            // 
            this.enter.Appearance = System.Windows.Forms.Appearance.Button;
            this.enter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enter.Location = new System.Drawing.Point( 424, 136 );
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size( 72, 32 );
            this.enter.TabIndex = 53;
            this.enter.Text = "Enter";
            this.enter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotes
            // 
            this.quotes.Appearance = System.Windows.Forms.Appearance.Button;
            this.quotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.quotes.Location = new System.Drawing.Point( 392, 136 );
            this.quotes.Name = "quotes";
            this.quotes.Size = new System.Drawing.Size( 32, 32 );
            this.quotes.TabIndex = 52;
            this.quotes.Text = "\"";
            this.quotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semicol
            // 
            this.semicol.Appearance = System.Windows.Forms.Appearance.Button;
            this.semicol.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F );
            this.semicol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.semicol.Location = new System.Drawing.Point( 360, 136 );
            this.semicol.Name = "semicol";
            this.semicol.Size = new System.Drawing.Size( 32, 32 );
            this.semicol.TabIndex = 51;
            this.semicol.Text = ";";
            this.semicol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lkey
            // 
            this.lkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.lkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lkey.Location = new System.Drawing.Point( 328, 136 );
            this.lkey.Name = "lkey";
            this.lkey.Size = new System.Drawing.Size( 32, 32 );
            this.lkey.TabIndex = 50;
            this.lkey.Text = "L";
            this.lkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kkey
            // 
            this.kkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.kkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kkey.Location = new System.Drawing.Point( 296, 136 );
            this.kkey.Name = "kkey";
            this.kkey.Size = new System.Drawing.Size( 32, 32 );
            this.kkey.TabIndex = 49;
            this.kkey.Text = "K";
            this.kkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jkey
            // 
            this.jkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.jkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.jkey.Location = new System.Drawing.Point( 264, 136 );
            this.jkey.Name = "jkey";
            this.jkey.Size = new System.Drawing.Size( 32, 32 );
            this.jkey.TabIndex = 48;
            this.jkey.Text = "J";
            this.jkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hkey
            // 
            this.hkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.hkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hkey.Location = new System.Drawing.Point( 232, 136 );
            this.hkey.Name = "hkey";
            this.hkey.Size = new System.Drawing.Size( 32, 32 );
            this.hkey.TabIndex = 47;
            this.hkey.Text = "H";
            this.hkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gkey
            // 
            this.gkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.gkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gkey.Location = new System.Drawing.Point( 200, 136 );
            this.gkey.Name = "gkey";
            this.gkey.Size = new System.Drawing.Size( 32, 32 );
            this.gkey.TabIndex = 46;
            this.gkey.Text = "G";
            this.gkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fkey
            // 
            this.fkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.fkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fkey.Location = new System.Drawing.Point( 168, 136 );
            this.fkey.Name = "fkey";
            this.fkey.Size = new System.Drawing.Size( 32, 32 );
            this.fkey.TabIndex = 45;
            this.fkey.Text = "F";
            this.fkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dkey
            // 
            this.dkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.dkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dkey.Location = new System.Drawing.Point( 136, 136 );
            this.dkey.Name = "dkey";
            this.dkey.Size = new System.Drawing.Size( 32, 32 );
            this.dkey.TabIndex = 44;
            this.dkey.Text = "D";
            this.dkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skey
            // 
            this.skey.Appearance = System.Windows.Forms.Appearance.Button;
            this.skey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.skey.Location = new System.Drawing.Point( 104, 136 );
            this.skey.Name = "skey";
            this.skey.Size = new System.Drawing.Size( 32, 32 );
            this.skey.TabIndex = 43;
            this.skey.Text = "S";
            this.skey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // akey
            // 
            this.akey.Appearance = System.Windows.Forms.Appearance.Button;
            this.akey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.akey.Location = new System.Drawing.Point( 72, 136 );
            this.akey.Name = "akey";
            this.akey.Size = new System.Drawing.Size( 32, 32 );
            this.akey.TabIndex = 42;
            this.akey.Text = "A";
            this.akey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // caps
            // 
            this.caps.Appearance = System.Windows.Forms.Appearance.Button;
            this.caps.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.caps.Location = new System.Drawing.Point( 16, 136 );
            this.caps.Name = "caps";
            this.caps.Size = new System.Drawing.Size( 56, 32 );
            this.caps.TabIndex = 41;
            this.caps.Text = "Caps";
            this.caps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backslash
            // 
            this.backslash.Appearance = System.Windows.Forms.Appearance.Button;
            this.backslash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backslash.Location = new System.Drawing.Point( 448, 104 );
            this.backslash.Name = "backslash";
            this.backslash.Size = new System.Drawing.Size( 48, 32 );
            this.backslash.TabIndex = 40;
            this.backslash.Text = "\\";
            this.backslash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closed_square_brace_key
            // 
            this.closed_square_brace_key.Appearance = System.Windows.Forms.Appearance.Button;
            this.closed_square_brace_key.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closed_square_brace_key.Location = new System.Drawing.Point( 416, 104 );
            this.closed_square_brace_key.Name = "closed_square_brace_key";
            this.closed_square_brace_key.Size = new System.Drawing.Size( 32, 32 );
            this.closed_square_brace_key.TabIndex = 39;
            this.closed_square_brace_key.Text = "]";
            this.closed_square_brace_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // open_square_brace_key
            // 
            this.open_square_brace_key.Appearance = System.Windows.Forms.Appearance.Button;
            this.open_square_brace_key.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.open_square_brace_key.Location = new System.Drawing.Point( 384, 104 );
            this.open_square_brace_key.Name = "open_square_brace_key";
            this.open_square_brace_key.Size = new System.Drawing.Size( 32, 32 );
            this.open_square_brace_key.TabIndex = 38;
            this.open_square_brace_key.Text = "[";
            this.open_square_brace_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pkey
            // 
            this.pkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.pkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pkey.Location = new System.Drawing.Point( 352, 104 );
            this.pkey.Name = "pkey";
            this.pkey.Size = new System.Drawing.Size( 32, 32 );
            this.pkey.TabIndex = 37;
            this.pkey.Text = "P";
            this.pkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okey
            // 
            this.okey.Appearance = System.Windows.Forms.Appearance.Button;
            this.okey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.okey.Location = new System.Drawing.Point( 320, 104 );
            this.okey.Name = "okey";
            this.okey.Size = new System.Drawing.Size( 32, 32 );
            this.okey.TabIndex = 36;
            this.okey.Text = "O";
            this.okey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ikey
            // 
            this.ikey.Appearance = System.Windows.Forms.Appearance.Button;
            this.ikey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ikey.Location = new System.Drawing.Point( 288, 104 );
            this.ikey.Name = "ikey";
            this.ikey.Size = new System.Drawing.Size( 32, 32 );
            this.ikey.TabIndex = 35;
            this.ikey.Text = "I";
            this.ikey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ukey
            // 
            this.ukey.Appearance = System.Windows.Forms.Appearance.Button;
            this.ukey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ukey.Location = new System.Drawing.Point( 256, 104 );
            this.ukey.Name = "ukey";
            this.ukey.Size = new System.Drawing.Size( 32, 32 );
            this.ukey.TabIndex = 34;
            this.ukey.Text = "U";
            this.ukey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ykey
            // 
            this.ykey.Appearance = System.Windows.Forms.Appearance.Button;
            this.ykey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ykey.Location = new System.Drawing.Point( 224, 104 );
            this.ykey.Name = "ykey";
            this.ykey.Size = new System.Drawing.Size( 32, 32 );
            this.ykey.TabIndex = 33;
            this.ykey.Text = "Y";
            this.ykey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tkey
            // 
            this.tkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.tkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tkey.Location = new System.Drawing.Point( 192, 104 );
            this.tkey.Name = "tkey";
            this.tkey.Size = new System.Drawing.Size( 32, 32 );
            this.tkey.TabIndex = 32;
            this.tkey.Text = "T";
            this.tkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rkey
            // 
            this.rkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.rkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rkey.Location = new System.Drawing.Point( 160, 104 );
            this.rkey.Name = "rkey";
            this.rkey.Size = new System.Drawing.Size( 32, 32 );
            this.rkey.TabIndex = 31;
            this.rkey.Text = "R";
            this.rkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ekey
            // 
            this.ekey.Appearance = System.Windows.Forms.Appearance.Button;
            this.ekey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ekey.Location = new System.Drawing.Point( 128, 104 );
            this.ekey.Name = "ekey";
            this.ekey.Size = new System.Drawing.Size( 32, 32 );
            this.ekey.TabIndex = 30;
            this.ekey.Text = "E";
            this.ekey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wkey
            // 
            this.wkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.wkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wkey.Location = new System.Drawing.Point( 96, 104 );
            this.wkey.Name = "wkey";
            this.wkey.Size = new System.Drawing.Size( 32, 32 );
            this.wkey.TabIndex = 29;
            this.wkey.Text = "W";
            this.wkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qkey
            // 
            this.qkey.Appearance = System.Windows.Forms.Appearance.Button;
            this.qkey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.qkey.Location = new System.Drawing.Point( 64, 104 );
            this.qkey.Name = "qkey";
            this.qkey.Size = new System.Drawing.Size( 32, 32 );
            this.qkey.TabIndex = 28;
            this.qkey.Text = "Q";
            this.qkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab
            // 
            this.tab.Appearance = System.Windows.Forms.Appearance.Button;
            this.tab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab.Location = new System.Drawing.Point( 16, 104 );
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size( 48, 32 );
            this.tab.TabIndex = 27;
            this.tab.Text = "Tab";
            this.tab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backspace
            // 
            this.backspace.Appearance = System.Windows.Forms.Appearance.Button;
            this.backspace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backspace.Location = new System.Drawing.Point( 432, 72 );
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size( 64, 32 );
            this.backspace.TabIndex = 26;
            this.backspace.Text = "<- Bksp";
            this.backspace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equals
            // 
            this.equals.Appearance = System.Windows.Forms.Appearance.Button;
            this.equals.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.equals.Location = new System.Drawing.Point( 400, 72 );
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size( 32, 32 );
            this.equals.TabIndex = 25;
            this.equals.Text = "=";
            this.equals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dash
            // 
            this.dash.Appearance = System.Windows.Forms.Appearance.Button;
            this.dash.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F );
            this.dash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dash.Location = new System.Drawing.Point( 368, 72 );
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size( 32, 32 );
            this.dash.TabIndex = 24;
            this.dash.Text = "-";
            this.dash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zero
            // 
            this.zero.Appearance = System.Windows.Forms.Appearance.Button;
            this.zero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.zero.Location = new System.Drawing.Point( 336, 72 );
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size( 32, 32 );
            this.zero.TabIndex = 23;
            this.zero.Text = "0";
            this.zero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nine
            // 
            this.nine.Appearance = System.Windows.Forms.Appearance.Button;
            this.nine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nine.Location = new System.Drawing.Point( 304, 72 );
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size( 32, 32 );
            this.nine.TabIndex = 22;
            this.nine.Text = "9";
            this.nine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eight
            // 
            this.eight.Appearance = System.Windows.Forms.Appearance.Button;
            this.eight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.eight.Location = new System.Drawing.Point( 272, 72 );
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size( 32, 32 );
            this.eight.TabIndex = 21;
            this.eight.Text = "8";
            this.eight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seven
            // 
            this.seven.Appearance = System.Windows.Forms.Appearance.Button;
            this.seven.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.seven.Location = new System.Drawing.Point( 240, 72 );
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size( 32, 32 );
            this.seven.TabIndex = 20;
            this.seven.Text = "7";
            this.seven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // six
            // 
            this.six.Appearance = System.Windows.Forms.Appearance.Button;
            this.six.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.six.Location = new System.Drawing.Point( 208, 72 );
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size( 32, 32 );
            this.six.TabIndex = 19;
            this.six.Text = "6";
            this.six.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // five
            // 
            this.five.Appearance = System.Windows.Forms.Appearance.Button;
            this.five.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.five.Location = new System.Drawing.Point( 176, 72 );
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size( 32, 32 );
            this.five.TabIndex = 18;
            this.five.Text = "5";
            this.five.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // four
            // 
            this.four.Appearance = System.Windows.Forms.Appearance.Button;
            this.four.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.four.Location = new System.Drawing.Point( 144, 72 );
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size( 32, 32 );
            this.four.TabIndex = 17;
            this.four.Text = "4";
            this.four.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // three
            // 
            this.three.Appearance = System.Windows.Forms.Appearance.Button;
            this.three.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.three.Location = new System.Drawing.Point( 112, 72 );
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size( 32, 32 );
            this.three.TabIndex = 16;
            this.three.Text = "3";
            this.three.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // two
            // 
            this.two.Appearance = System.Windows.Forms.Appearance.Button;
            this.two.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.two.Location = new System.Drawing.Point( 80, 72 );
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size( 32, 32 );
            this.two.TabIndex = 15;
            this.two.Text = "2";
            this.two.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // one
            // 
            this.one.Appearance = System.Windows.Forms.Appearance.Button;
            this.one.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.one.Location = new System.Drawing.Point( 48, 72 );
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size( 32, 32 );
            this.one.TabIndex = 14;
            this.one.Text = "1";
            this.one.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tilda
            // 
            this.tilda.Appearance = System.Windows.Forms.Appearance.Button;
            this.tilda.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9F );
            this.tilda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tilda.Location = new System.Drawing.Point( 16, 72 );
            this.tilda.Name = "tilda";
            this.tilda.Size = new System.Drawing.Size( 32, 32 );
            this.tilda.TabIndex = 13;
            this.tilda.Text = "~";
            this.tilda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f12
            // 
            this.f12.Appearance = System.Windows.Forms.Appearance.Button;
            this.f12.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f12.Location = new System.Drawing.Point( 464, 24 );
            this.f12.Name = "f12";
            this.f12.Size = new System.Drawing.Size( 32, 32 );
            this.f12.TabIndex = 12;
            this.f12.Text = "F12";
            this.f12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f11
            // 
            this.f11.Appearance = System.Windows.Forms.Appearance.Button;
            this.f11.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f11.Location = new System.Drawing.Point( 432, 24 );
            this.f11.Name = "f11";
            this.f11.Size = new System.Drawing.Size( 32, 32 );
            this.f11.TabIndex = 11;
            this.f11.Text = "F11";
            this.f11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f10
            // 
            this.f10.Appearance = System.Windows.Forms.Appearance.Button;
            this.f10.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f10.Location = new System.Drawing.Point( 400, 24 );
            this.f10.Name = "f10";
            this.f10.Size = new System.Drawing.Size( 32, 32 );
            this.f10.TabIndex = 10;
            this.f10.Text = "F10";
            this.f10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f9
            // 
            this.f9.Appearance = System.Windows.Forms.Appearance.Button;
            this.f9.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f9.Location = new System.Drawing.Point( 368, 24 );
            this.f9.Name = "f9";
            this.f9.Size = new System.Drawing.Size( 32, 32 );
            this.f9.TabIndex = 9;
            this.f9.Text = "F9";
            this.f9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f8
            // 
            this.f8.Appearance = System.Windows.Forms.Appearance.Button;
            this.f8.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f8.Location = new System.Drawing.Point( 320, 24 );
            this.f8.Name = "f8";
            this.f8.Size = new System.Drawing.Size( 32, 32 );
            this.f8.TabIndex = 8;
            this.f8.Text = "F8";
            this.f8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f7
            // 
            this.f7.Appearance = System.Windows.Forms.Appearance.Button;
            this.f7.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f7.Location = new System.Drawing.Point( 288, 24 );
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size( 32, 32 );
            this.f7.TabIndex = 7;
            this.f7.Text = "F7";
            this.f7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f6
            // 
            this.f6.Appearance = System.Windows.Forms.Appearance.Button;
            this.f6.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f6.Location = new System.Drawing.Point( 256, 24 );
            this.f6.Name = "f6";
            this.f6.Size = new System.Drawing.Size( 32, 32 );
            this.f6.TabIndex = 6;
            this.f6.Text = "F6";
            this.f6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f5
            // 
            this.f5.Appearance = System.Windows.Forms.Appearance.Button;
            this.f5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f5.Location = new System.Drawing.Point( 224, 24 );
            this.f5.Name = "f5";
            this.f5.Size = new System.Drawing.Size( 32, 32 );
            this.f5.TabIndex = 5;
            this.f5.Text = "F5";
            this.f5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f4
            // 
            this.f4.Appearance = System.Windows.Forms.Appearance.Button;
            this.f4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f4.Location = new System.Drawing.Point( 176, 24 );
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size( 32, 32 );
            this.f4.TabIndex = 4;
            this.f4.Text = "F4";
            this.f4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f3
            // 
            this.f3.Appearance = System.Windows.Forms.Appearance.Button;
            this.f3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f3.Location = new System.Drawing.Point( 144, 24 );
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size( 32, 32 );
            this.f3.TabIndex = 3;
            this.f3.Text = "F3";
            this.f3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f2
            // 
            this.f2.Appearance = System.Windows.Forms.Appearance.Button;
            this.f2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f2.Location = new System.Drawing.Point( 112, 24 );
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size( 32, 32 );
            this.f2.TabIndex = 2;
            this.f2.Text = "F2";
            this.f2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f1
            // 
            this.f1.Appearance = System.Windows.Forms.Appearance.Button;
            this.f1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.f1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.f1.Location = new System.Drawing.Point( 80, 24 );
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size( 32, 32 );
            this.f1.TabIndex = 1;
            this.f1.Text = "F1";
            this.f1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // esc
            // 
            this.esc.Appearance = System.Windows.Forms.Appearance.Button;
            this.esc.Font = new System.Drawing.Font( "Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.esc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.esc.Location = new System.Drawing.Point( 16, 24 );
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size( 32, 32 );
            this.esc.TabIndex = 0;
            this.esc.Text = "Esc";
            this.esc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _logoPictureBox
            // 
            this._logoPictureBox.BackgroundImage = ( (System.Drawing.Image)( resources.GetObject( "_logoPictureBox.BackgroundImage" ) ) );
            this._logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this._logoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._logoPictureBox.Location = new System.Drawing.Point( 639, 24 );
            this._logoPictureBox.Name = "_logoPictureBox";
            this._logoPictureBox.Size = new System.Drawing.Size( 130, 34 );
            this._logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._logoPictureBox.TabIndex = 99;
            this._logoPictureBox.TabStop = false;
            this._toolTip.SetToolTip( this._logoPictureBox, "Visit Bind Maker Website" );
            this._logoPictureBox.Click += new System.EventHandler( this.HandleViewDocumentation );
            // 
            // binds_tabPage
            // 
            this.binds_tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.binds_tabPage.Controls.Add( this._bindOptionsListBox );
            this.binds_tabPage.Controls.Add( this.toolStrip3 );
            this.binds_tabPage.ImageIndex = 2;
            this.binds_tabPage.Location = new System.Drawing.Point( 4, 4 );
            this.binds_tabPage.Name = "binds_tabPage";
            this.binds_tabPage.Size = new System.Drawing.Size( 388, 306 );
            this.binds_tabPage.TabIndex = 0;
            this.binds_tabPage.Text = "Buy Scripting";
            this._toolTip.SetToolTip( this.binds_tabPage, "Create Cusom Buy Scripts" );
            // 
            // _bindOptionsListBox
            // 
            this._bindOptionsListBox.BackColor = System.Drawing.SystemColors.Control;
            this._bindOptionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._bindOptionsListBox.CheckOnClick = true;
            this._bindOptionsListBox.ColumnWidth = 220;
            this._bindOptionsListBox.ContextMenuStrip = this.bindOptionsContextMenuStrip;
            this._bindOptionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bindOptionsListBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this._bindOptionsListBox.Location = new System.Drawing.Point( 0, 23 );
            this._bindOptionsListBox.Name = "_bindOptionsListBox";
            this._bindOptionsListBox.Size = new System.Drawing.Size( 388, 283 );
            this._bindOptionsListBox.Sorted = true;
            this._bindOptionsListBox.TabIndex = 0;
            this._bindOptionsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler( this.BindOptions_ListBox_ItemCheck );
            this._bindOptionsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler( this.HandleBindItemsKeyDown );
            this._bindOptionsListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.HandleBindItemsKeyPress );
            this._bindOptionsListBox.KeyUp += new System.Windows.Forms.KeyEventHandler( this.HandleBindItemsKeyUp );
            this._bindOptionsListBox.MouseEnter += new System.EventHandler( this.BindOptions_ListBox_MouseEnter );
            // 
            // bindOptionsContextMenuStrip
            // 
            this.bindOptionsContextMenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.addBindToolStripMenuItem1,
            this.uncheckItemsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.editItemsSequenceToolStripMenuItem} );
            this.bindOptionsContextMenuStrip.Name = "bindOptionsContextMenuStrip";
            this.bindOptionsContextMenuStrip.Size = new System.Drawing.Size( 181, 76 );
            // 
            // addBindToolStripMenuItem1
            // 
            this.addBindToolStripMenuItem1.Image = ( (System.Drawing.Image)( resources.GetObject( "addBindToolStripMenuItem1.Image" ) ) );
            this.addBindToolStripMenuItem1.Name = "addBindToolStripMenuItem1";
            this.addBindToolStripMenuItem1.Size = new System.Drawing.Size( 180, 22 );
            this.addBindToolStripMenuItem1.Text = "Add Bind";
            this.addBindToolStripMenuItem1.Click += new System.EventHandler( this.HandleAddEditBind );
            // 
            // uncheckItemsToolStripMenuItem
            // 
            this.uncheckItemsToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "uncheckItemsToolStripMenuItem.Image" ) ) );
            this.uncheckItemsToolStripMenuItem.Name = "uncheckItemsToolStripMenuItem";
            this.uncheckItemsToolStripMenuItem.Size = new System.Drawing.Size( 180, 22 );
            this.uncheckItemsToolStripMenuItem.Text = "Uncheck Items";
            this.uncheckItemsToolStripMenuItem.Click += new System.EventHandler( this.HandleDeselectBindItems );
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size( 177, 6 );
            // 
            // editItemsSequenceToolStripMenuItem
            // 
            this.editItemsSequenceToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "editItemsSequenceToolStripMenuItem.Image" ) ) );
            this.editItemsSequenceToolStripMenuItem.Name = "editItemsSequenceToolStripMenuItem";
            this.editItemsSequenceToolStripMenuItem.Size = new System.Drawing.Size( 180, 22 );
            this.editItemsSequenceToolStripMenuItem.Text = "Edit Items Sequence";
            this.editItemsSequenceToolStripMenuItem.Click += new System.EventHandler( this.HandleEditItemSequences );
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripMargin = new System.Windows.Forms.Padding( 0 );
            this.toolStrip3.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this._enableSayItem,
            this.sayTeamSayComboBox,
            this.toolStripLabel1,
            this.sayTeamSayTextBox,
            this.removeSayTeamSayToolStripButton} );
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip3.Location = new System.Drawing.Point( 0, 0 );
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size( 388, 23 );
            this.toolStrip3.Stretch = true;
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // _enableSayItem
            // 
            this._enableSayItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._enableSayItem.Image = global::CZBindMaker.Properties.Resources.select;
            this._enableSayItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._enableSayItem.Name = "_enableSayItem";
            this._enableSayItem.Size = new System.Drawing.Size( 23, 20 );
            this._enableSayItem.Text = "toolStripButton7";
            this._enableSayItem.ToolTipText = "Add the say / team say item to your bind list";
            this._enableSayItem.CheckedChanged += new System.EventHandler( this.HandleEnableDisableSayTeamSay );
            this._enableSayItem.Click += new System.EventHandler( this.HandleSayTeamSayCommandAdd );
            // 
            // sayTeamSayComboBox
            // 
            this.sayTeamSayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sayTeamSayComboBox.Items.AddRange( new object[] {
            "- Chat -",
            "Say",
            "Team Say"} );
            this.sayTeamSayComboBox.Name = "sayTeamSayComboBox";
            this.sayTeamSayComboBox.Size = new System.Drawing.Size( 95, 23 );
            this.sayTeamSayComboBox.ToolTipText = "Choose your say / team say selection";
            this.sayTeamSayComboBox.SelectedIndexChanged += new System.EventHandler( this.HandleSayTeamSayEnabled );
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size( 10, 15 );
            this.toolStripLabel1.Text = " ";
            // 
            // sayTeamSayTextBox
            // 
            this.sayTeamSayTextBox.Name = "sayTeamSayTextBox";
            this.sayTeamSayTextBox.Size = new System.Drawing.Size( 200, 23 );
            this.sayTeamSayTextBox.ToolTipText = "Enter the text to say / team say here";
            // 
            // removeSayTeamSayToolStripButton
            // 
            this.removeSayTeamSayToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeSayTeamSayToolStripButton.Image = ( (System.Drawing.Image)( resources.GetObject( "removeSayTeamSayToolStripButton.Image" ) ) );
            this.removeSayTeamSayToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeSayTeamSayToolStripButton.Name = "removeSayTeamSayToolStripButton";
            this.removeSayTeamSayToolStripButton.Size = new System.Drawing.Size( 23, 20 );
            this.removeSayTeamSayToolStripButton.ToolTipText = "Remove the say / team say command from your bind list";
            this.removeSayTeamSayToolStripButton.Click += new System.EventHandler( this.HandleClearSayTeamSay );
            // 
            // config_tabPage
            // 
            this.config_tabPage.Controls.Add( this._crosshairSize );
            this.config_tabPage.Controls.Add( this._crosshairSizeLabel );
            this.config_tabPage.Controls.Add( this._solidCrosshair );
            this.config_tabPage.Controls.Add( this._editCrosshairColor );
            this.config_tabPage.Controls.Add( this._crosshairSampleImage );
            this.config_tabPage.Controls.Add( this._fpsRange );
            this.config_tabPage.Controls.Add( this._frameRateLabel );
            this.config_tabPage.Controls.Add( this.label3 );
            this.config_tabPage.Controls.Add( this.cl_radartype );
            this.config_tabPage.Controls.Add( this._rateUpDown );
            this.config_tabPage.Controls.Add( this._networkRateLabel );
            this.config_tabPage.Controls.Add( this.cl_righthand );
            this.config_tabPage.Controls.Add( this._cl_autoweaponswitch );
            this.config_tabPage.Controls.Add( this._vgui_menus );
            this.config_tabPage.Controls.Add( this.groupBox3 );
            this.config_tabPage.Controls.Add( this.cl_weather );
            this.config_tabPage.Controls.Add( this.hud_fastswitch );
            this.config_tabPage.Controls.Add( this.hud_centerID );
            this.config_tabPage.Controls.Add( this.net_graph_GroupBox );
            this.config_tabPage.Controls.Add( this._dynamicCrossHairs );
            this.config_tabPage.Controls.Add( this._playerName );
            this.config_tabPage.Controls.Add( this.label1 );
            this.config_tabPage.Controls.Add( this._consoleColorButton );
            this.config_tabPage.Controls.Add( this._consoleColorSample );
            this.config_tabPage.ImageIndex = 0;
            this.config_tabPage.Location = new System.Drawing.Point( 4, 4 );
            this.config_tabPage.Name = "config_tabPage";
            this.config_tabPage.Size = new System.Drawing.Size( 388, 306 );
            this.config_tabPage.TabIndex = 1;
            this.config_tabPage.Text = "Config Editor";
            this._toolTip.SetToolTip( this.config_tabPage, "Edit your config file settings" );
            this.config_tabPage.Visible = false;
            this.config_tabPage.Paint += new System.Windows.Forms.PaintEventHandler( this.HandleDrawOnTabPage );
            // 
            // _crosshairSize
            // 
            this._crosshairSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._crosshairSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this._crosshairSize.ItemHeight = 13;
            this._crosshairSize.Items.AddRange( new object[] {
            "Auto-Size",
            "Small",
            "Medium",
            "Large"} );
            this._crosshairSize.Location = new System.Drawing.Point( 256, 277 );
            this._crosshairSize.Name = "_crosshairSize";
            this._crosshairSize.Size = new System.Drawing.Size( 120, 21 );
            this._crosshairSize.TabIndex = 70;
            this._toolTip.SetToolTip( this._crosshairSize, "Select your crosshair size" );
            this._crosshairSize.SelectionChangeCommitted += new System.EventHandler( this.HandleCrosshairSizeChange );
            // 
            // _crosshairSizeLabel
            // 
            this._crosshairSizeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._crosshairSizeLabel.Location = new System.Drawing.Point( 256, 264 );
            this._crosshairSizeLabel.Name = "_crosshairSizeLabel";
            this._crosshairSizeLabel.Size = new System.Drawing.Size( 112, 16 );
            this._crosshairSizeLabel.TabIndex = 69;
            this._crosshairSizeLabel.Text = "Crosshair Size";
            this._toolTip.SetToolTip( this._crosshairSizeLabel, "Select your crosshair size" );
            // 
            // _solidCrosshair
            // 
            this._solidCrosshair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._solidCrosshair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._solidCrosshair.Location = new System.Drawing.Point( 16, 272 );
            this._solidCrosshair.Name = "_solidCrosshair";
            this._solidCrosshair.Size = new System.Drawing.Size( 152, 16 );
            this._solidCrosshair.TabIndex = 68;
            this._solidCrosshair.Text = "Solid Crosshair";
            this._toolTip.SetToolTip( this._solidCrosshair, "Uncheck to use a transparent style crosshair" );
            this._solidCrosshair.CheckStateChanged += new System.EventHandler( this.HandleSolidCrosshairsChange );
            // 
            // _editCrosshairColor
            // 
            this._editCrosshairColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._editCrosshairColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._editCrosshairColor.Location = new System.Drawing.Point( 256, 236 );
            this._editCrosshairColor.Name = "_editCrosshairColor";
            this._editCrosshairColor.Size = new System.Drawing.Size( 120, 22 );
            this._editCrosshairColor.TabIndex = 67;
            this._editCrosshairColor.Text = "Edit Crosshair Color";
            this._toolTip.SetToolTip( this._editCrosshairColor, "Click here to change your cross hair color" );
            this._editCrosshairColor.Click += new System.EventHandler( this.HandleEditCrosshairColor );
            // 
            // _crosshairSampleImage
            // 
            this._crosshairSampleImage.BackColor = System.Drawing.Color.Gold;
            this._crosshairSampleImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._crosshairSampleImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this._crosshairSampleImage.Image = ( (System.Drawing.Image)( resources.GetObject( "_crosshairSampleImage.Image" ) ) );
            this._crosshairSampleImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._crosshairSampleImage.Location = new System.Drawing.Point( 184, 236 );
            this._crosshairSampleImage.Name = "_crosshairSampleImage";
            this._crosshairSampleImage.Size = new System.Drawing.Size( 62, 62 );
            this._crosshairSampleImage.TabIndex = 66;
            this._crosshairSampleImage.TabStop = false;
            this._toolTip.SetToolTip( this._crosshairSampleImage, "Sample of what your crosshair will look like" );
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font( "Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World );
            this.label3.ForeColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 63 ) ) ) ), ( (int)( ( (byte)( 63 ) ) ) ) );
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point( 16, 32 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 56, 23 );
            this.label3.TabIndex = 65;
            this.label3.Text = "Player:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._toolTip.SetToolTip( this.label3, "This is a sample of your in game text color" );
            // 
            // cl_radartype
            // 
            this.cl_radartype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cl_radartype.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cl_radartype.Location = new System.Drawing.Point( 16, 256 );
            this.cl_radartype.Name = "cl_radartype";
            this.cl_radartype.Size = new System.Drawing.Size( 152, 16 );
            this.cl_radartype.TabIndex = 64;
            this.cl_radartype.Text = "Solid Style Radar";
            this._toolTip.SetToolTip( this.cl_radartype, "Uncheck to use a transparent style radar" );
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add( this.net_grappos_2 );
            this.groupBox3.Controls.Add( this.net_grappos_1 );
            this.groupBox3.Controls.Add( this.net_grappos_3 );
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point( 184, 136 );
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size( 192, 40 );
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Net Graph Location";
            // 
            // net_graph_GroupBox
            // 
            this.net_graph_GroupBox.Controls.Add( this.net_graph_0 );
            this.net_graph_GroupBox.Controls.Add( this.net_graph_3 );
            this.net_graph_GroupBox.Controls.Add( this.net_graph_2 );
            this.net_graph_GroupBox.Controls.Add( this.net_graph_1 );
            this.net_graph_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.net_graph_GroupBox.Location = new System.Drawing.Point( 16, 61 );
            this.net_graph_GroupBox.Name = "net_graph_GroupBox";
            this.net_graph_GroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.net_graph_GroupBox.Size = new System.Drawing.Size( 360, 72 );
            this.net_graph_GroupBox.TabIndex = 54;
            this.net_graph_GroupBox.TabStop = false;
            this.net_graph_GroupBox.Text = "Net Graph (Shows Resources In-Game)";
            // 
            // _customBind
            // 
            this._customBind.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._customBind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._customBind.Location = new System.Drawing.Point( 111, 5 );
            this._customBind.Name = "_customBind";
            this._customBind.Size = new System.Drawing.Size( 261, 20 );
            this._customBind.TabIndex = 40;
            this._customBind.Text = "bind \"key\" \"command\"";
            this._toolTip.SetToolTip( this._customBind, "Click to enter custom binds" );
            this._customBind.Enter += new System.EventHandler( this.CustomBind_Enter );
            this._customBind.KeyUp += new System.Windows.Forms.KeyEventHandler( this.HandleCustomBindKeyPress );
            this._customBind.Leave += new System.EventHandler( this.CustomBind_Leave );
            // 
            // label2
            // 
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point( 9, 7 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 96, 16 );
            this.label2.TabIndex = 39;
            this.label2.Text = "Add Custom Bind:";
            this._toolTip.SetToolTip( this.label2, "Create custom binds and aliases" );
            // 
            // _showOrder
            // 
            this._showOrder.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this._showOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._showOrder.Location = new System.Drawing.Point( 275, 314 );
            this._showOrder.Name = "_showOrder";
            this._showOrder.Size = new System.Drawing.Size( 120, 22 );
            this._showOrder.TabIndex = 45;
            this._showOrder.Text = "Edit Item Sequence";
            this._toolTip.SetToolTip( this._showOrder, "This will allow you to edit the order in which your items selected above are writ" +
                    "ten in your script" );
            this._showOrder.Click += new System.EventHandler( this.HandleEditItemSequences );
            // 
            // _mainTabControl
            // 
            this._mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this._mainTabControl.Appearance = Dotnetrix.Controls.TabControlEX.TabAppearanceEX.Bevel;
            this._mainTabControl.Controls.Add( this.binds_tabPage );
            this._mainTabControl.Controls.Add( this.config_tabPage );
            this._mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTabControl.HotTrack = true;
            this._mainTabControl.ImageList = this._contextImageList;
            this._mainTabControl.ItemSize = new System.Drawing.Size( 96, 19 );
            this._mainTabControl.Location = new System.Drawing.Point( 2, 2 );
            this._mainTabControl.Name = "_mainTabControl";
            this._mainTabControl.SelectedIndex = 0;
            this._mainTabControl.Size = new System.Drawing.Size( 396, 333 );
            this._mainTabControl.TabIndex = 36;
            this._mainTabControl.SelectedIndexChanged += new System.EventHandler( this.HandleTabPageSwitch );
            // 
            // _contextImageList
            // 
            this._contextImageList.ImageStream = ( (System.Windows.Forms.ImageListStreamer)( resources.GetObject( "_contextImageList.ImageStream" ) ) );
            this._contextImageList.TransparentColor = System.Drawing.Color.Transparent;
            this._contextImageList.Images.SetKeyName( 0, "" );
            this._contextImageList.Images.SetKeyName( 1, "" );
            this._contextImageList.Images.SetKeyName( 2, "" );
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.groupBox2.Controls.Add( this._currentBindListBox );
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point( 3, 37 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 374, 319 );
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "Shows ";
            this.groupBox2.Text = "Current Bind Settings";
            // 
            // _crosshairs
            // 
            this._crosshairs.ImageStream = ( (System.Windows.Forms.ImageListStreamer)( resources.GetObject( "_crosshairs.ImageStream" ) ) );
            this._crosshairs.TransparentColor = System.Drawing.Color.Transparent;
            this._crosshairs.Images.SetKeyName( 0, "" );
            this._crosshairs.Images.SetKeyName( 1, "" );
            this._crosshairs.Images.SetKeyName( 2, "" );
            // 
            // _exportAs
            // 
            this._exportAs.SelectedPath = "Select a Folder to Export Your Game Settings To";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem} );
            this.menuStrip1.Location = new System.Drawing.Point( 0, 0 );
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size( 784, 24 );
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem} );
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "openToolStripMenuItem.Image" ) ) );
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O ) ) );
            this.openToolStripMenuItem.Size = new System.Drawing.Size( 146, 22 );
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler( this.HandleChangeGame );
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size( 143, 6 );
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "saveToolStripMenuItem.Image" ) ) );
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S ) ) );
            this.saveToolStripMenuItem.Size = new System.Drawing.Size( 146, 22 );
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler( this.HandleSaveConfigs );
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.compressedFileStripMenuItem,
            this.exportAllConfigsToolStripMenuItem} );
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size( 146, 22 );
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // compressedFileStripMenuItem
            // 
            this.compressedFileStripMenuItem.Name = "compressedFileStripMenuItem";
            this.compressedFileStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.compressedFileStripMenuItem.Text = "Co&mpressed File";
            this.compressedFileStripMenuItem.Click += new System.EventHandler( this.HandleExportCompressedFiles );
            // 
            // exportAllConfigsToolStripMenuItem
            // 
            this.exportAllConfigsToolStripMenuItem.Name = "exportAllConfigsToolStripMenuItem";
            this.exportAllConfigsToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.exportAllConfigsToolStripMenuItem.Text = "Export &All Configs";
            this.exportAllConfigsToolStripMenuItem.Click += new System.EventHandler( this.HandleExportAllFiles );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 143, 6 );
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size( 146, 22 );
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler( this.HandleExitApplication );
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator4,
            this.displayToolStripMenuItem,
            this.toolStripSeparator3,
            this.notepadMenuItem} );
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size( 39, 20 );
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z ) ) );
            this.undoToolStripMenuItem.Size = new System.Drawing.Size( 186, 22 );
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler( this.HandleUndoAction );
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y ) ) );
            this.redoToolStripMenuItem.Size = new System.Drawing.Size( 186, 22 );
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size( 183, 6 );
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Checked = true;
            this.displayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayToolStripMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "displayToolStripMenuItem.Image" ) ) );
            this.displayToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H ) ) );
            this.displayToolStripMenuItem.Size = new System.Drawing.Size( 186, 22 );
            this.displayToolStripMenuItem.Text = "Display Hints";
            this.displayToolStripMenuItem.Click += new System.EventHandler( this.HandleDisplayTooltips );
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 183, 6 );
            // 
            // notepadMenuItem
            // 
            this.notepadMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.configcfgToolStripMenuItem,
            this.autoexeccfgToolStripMenuItem,
            this.userconfigcfgToolStripMenuItem,
            this.czbindcfgToolStripMenuItem} );
            this.notepadMenuItem.Image = ( (System.Drawing.Image)( resources.GetObject( "notepadMenuItem.Image" ) ) );
            this.notepadMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.notepadMenuItem.Name = "notepadMenuItem";
            this.notepadMenuItem.Size = new System.Drawing.Size( 186, 22 );
            this.notepadMenuItem.Text = "&Notepad";
            // 
            // configcfgToolStripMenuItem
            // 
            this.configcfgToolStripMenuItem.Name = "configcfgToolStripMenuItem";
            this.configcfgToolStripMenuItem.Size = new System.Drawing.Size( 150, 22 );
            this.configcfgToolStripMenuItem.Text = "config.cfg";
            this.configcfgToolStripMenuItem.Click += new System.EventHandler( this.HandleOpenConfigCfgInNotepad );
            // 
            // autoexeccfgToolStripMenuItem
            // 
            this.autoexeccfgToolStripMenuItem.Name = "autoexeccfgToolStripMenuItem";
            this.autoexeccfgToolStripMenuItem.Size = new System.Drawing.Size( 150, 22 );
            this.autoexeccfgToolStripMenuItem.Text = "autoexec.cfg";
            this.autoexeccfgToolStripMenuItem.Click += new System.EventHandler( this.HandleOpenAutoexecCfgInNotepad );
            // 
            // userconfigcfgToolStripMenuItem
            // 
            this.userconfigcfgToolStripMenuItem.Name = "userconfigcfgToolStripMenuItem";
            this.userconfigcfgToolStripMenuItem.Size = new System.Drawing.Size( 150, 22 );
            this.userconfigcfgToolStripMenuItem.Text = "userconfig.cfg";
            this.userconfigcfgToolStripMenuItem.Click += new System.EventHandler( this.HandleOpenUserconfigCfgInNotepad );
            // 
            // czbindcfgToolStripMenuItem
            // 
            this.czbindcfgToolStripMenuItem.Name = "czbindcfgToolStripMenuItem";
            this.czbindcfgToolStripMenuItem.Size = new System.Drawing.Size( 150, 22 );
            this.czbindcfgToolStripMenuItem.Text = "czbind.cfg";
            this.czbindcfgToolStripMenuItem.Click += new System.EventHandler( this.HandleOpenCzbindCfgInNotepad );
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.websiteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.feedbackToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem} );
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size( 157, 22 );
            this.indexToolStripMenuItem.Text = "&Documentation";
            this.indexToolStripMenuItem.Click += new System.EventHandler( this.HandleViewDocumentation );
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size( 157, 22 );
            this.websiteToolStripMenuItem.Text = "&Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler( this.HandleViewWebsite );
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size( 154, 6 );
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size( 157, 22 );
            this.feedbackToolStripMenuItem.Text = "F&eedback";
            this.feedbackToolStripMenuItem.Visible = false;
            this.feedbackToolStripMenuItem.Click += new System.EventHandler( this.HandleSubmitFeedback );
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size( 154, 6 );
            this.toolStripSeparator5.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size( 157, 22 );
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler( this.HandleShowAbout );
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.label2 );
            this.panel1.Controls.Add( this.groupBox2 );
            this.panel1.Controls.Add( this._customBind );
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point( 0, 0 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 380, 362 );
            this.panel1.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Controls.Add( this.panel3 );
            this.panel2.Controls.Add( this.toolStrip2 );
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point( 384, 0 );
            this.panel2.MinimumSize = new System.Drawing.Size( 400, 362 );
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size( 400, 362 );
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Controls.Add( this._showOrder );
            this.panel3.Controls.Add( this._mainTabControl );
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point( 0, 25 );
            this.panel3.MinimumSize = new System.Drawing.Size( 350, 336 );
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding( 2 );
            this.panel3.Size = new System.Drawing.Size( 400, 337 );
            this.panel3.TabIndex = 47;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.radioCommandsToolStripComboBox,
            this.clearRadioCommandsToolStripButton} );
            this.toolStrip2.Location = new System.Drawing.Point( 0, 0 );
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size( 400, 25 );
            this.toolStrip2.TabIndex = 48;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size( 102, 22 );
            this.toolStripLabel2.Text = "Radio Commands";
            // 
            // radioCommandsToolStripComboBox
            // 
            this.radioCommandsToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.radioCommandsToolStripComboBox.Name = "radioCommandsToolStripComboBox";
            this.radioCommandsToolStripComboBox.Size = new System.Drawing.Size( 175, 25 );
            this.radioCommandsToolStripComboBox.SelectedIndexChanged += new System.EventHandler( this.HandleRadioCommandSelectionChanged );
            // 
            // clearRadioCommandsToolStripButton
            // 
            this.clearRadioCommandsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearRadioCommandsToolStripButton.Image = ( (System.Drawing.Image)( resources.GetObject( "clearRadioCommandsToolStripButton.Image" ) ) );
            this.clearRadioCommandsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearRadioCommandsToolStripButton.Name = "clearRadioCommandsToolStripButton";
            this.clearRadioCommandsToolStripButton.Size = new System.Drawing.Size( 23, 22 );
            this.clearRadioCommandsToolStripButton.ToolTipText = "Clear the radio command";
            this.clearRadioCommandsToolStripButton.Click += new System.EventHandler( this.HandleClearSelectedRadioCommand );
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.addBindToolBarButton,
            this.deleteBindToolBarButton,
            this.saveButton,
            this.toolStripSeparator6,
            this.undoStripButton,
            this.redoStripButton} );
            this.toolStrip1.Location = new System.Drawing.Point( 3, 24 );
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size( 387, 25 );
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addBindToolBarButton
            // 
            this.addBindToolBarButton.Image = ( (System.Drawing.Image)( resources.GetObject( "addBindToolBarButton.Image" ) ) );
            this.addBindToolBarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBindToolBarButton.Name = "addBindToolBarButton";
            this.addBindToolBarButton.Size = new System.Drawing.Size( 76, 22 );
            this.addBindToolBarButton.Text = "Add &Bind";
            this.addBindToolBarButton.Click += new System.EventHandler( this.HandleAddEditBind );
            // 
            // deleteBindToolBarButton
            // 
            this.deleteBindToolBarButton.Image = ( (System.Drawing.Image)( resources.GetObject( "deleteBindToolBarButton.Image" ) ) );
            this.deleteBindToolBarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBindToolBarButton.Name = "deleteBindToolBarButton";
            this.deleteBindToolBarButton.Size = new System.Drawing.Size( 87, 22 );
            this.deleteBindToolBarButton.Text = "&Delete Bind";
            this.deleteBindToolBarButton.Click += new System.EventHandler( this.HandleDeleteBind );
            // 
            // saveButton
            // 
            this.saveButton.Image = ( (System.Drawing.Image)( resources.GetObject( "saveButton.Image" ) ) );
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size( 96, 22 );
            this.saveButton.Text = "&Save Settings";
            this.saveButton.Click += new System.EventHandler( this.HandleSaveConfigs );
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size( 6, 25 );
            // 
            // undoStripButton
            // 
            this.undoStripButton.Enabled = false;
            this.undoStripButton.Image = ( (System.Drawing.Image)( resources.GetObject( "undoStripButton.Image" ) ) );
            this.undoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoStripButton.Name = "undoStripButton";
            this.undoStripButton.Size = new System.Drawing.Size( 56, 22 );
            this.undoStripButton.Text = "Undo";
            this.undoStripButton.Click += new System.EventHandler( this.HandleUndoAction );
            // 
            // redoStripButton
            // 
            this.redoStripButton.Enabled = false;
            this.redoStripButton.Image = ( (System.Drawing.Image)( resources.GetObject( "redoStripButton.Image" ) ) );
            this.redoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoStripButton.Name = "redoStripButton";
            this.redoStripButton.Size = new System.Drawing.Size( 54, 22 );
            this.redoStripButton.Text = "Redo";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add( this.panel1 );
            this.toolStripContainer1.ContentPanel.Controls.Add( this.splitter1 );
            this.toolStripContainer1.ContentPanel.Controls.Add( this.panel2 );
            this.toolStripContainer1.ContentPanel.Controls.Add( this.groupBox1 );
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size( 784, 606 );
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point( 0, 0 );
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size( 784, 655 );
            this.toolStripContainer1.TabIndex = 35;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add( this.menuStrip1 );
            this.toolStripContainer1.TopToolStripPanel.Controls.Add( this.toolStrip1 );
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point( 380, 0 );
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size( 4, 362 );
            this.splitter1.TabIndex = 50;
            this.splitter1.TabStop = false;
            // 
            // CZBindMakerMainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
            this.ClientSize = new System.Drawing.Size( 784, 655 );
            this.Controls.Add( this.toolStripContainer1 );
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size( 800, 691 );
            this.Name = "CZBindMakerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   CodeZulu Bind Maker";
            ( (System.ComponentModel.ISupportInitialize)( this._rateUpDown ) ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)( this._fpsRange ) ).EndInit( );
            this.currentBindContextMenuStrip.ResumeLayout( false );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout( );
            this.keyboardContextMenuStrip.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this._logoPictureBox ) ).EndInit( );
            this.binds_tabPage.ResumeLayout( false );
            this.binds_tabPage.PerformLayout( );
            this.bindOptionsContextMenuStrip.ResumeLayout( false );
            this.toolStrip3.ResumeLayout( false );
            this.toolStrip3.PerformLayout( );
            this.config_tabPage.ResumeLayout( false );
            this.config_tabPage.PerformLayout( );
            ( (System.ComponentModel.ISupportInitialize)( this._crosshairSampleImage ) ).EndInit( );
            this.groupBox3.ResumeLayout( false );
            this.net_graph_GroupBox.ResumeLayout( false );
            this._mainTabControl.ResumeLayout( false );
            this.groupBox2.ResumeLayout( false );
            this.menuStrip1.ResumeLayout( false );
            this.menuStrip1.PerformLayout( );
            this.panel1.ResumeLayout( false );
            this.panel1.PerformLayout( );
            this.panel2.ResumeLayout( false );
            this.panel2.PerformLayout( );
            this.panel3.ResumeLayout( false );
            this.toolStrip2.ResumeLayout( false );
            this.toolStrip2.PerformLayout( );
            this.toolStrip1.ResumeLayout( false );
            this.toolStrip1.PerformLayout( );
            this.toolStripContainer1.ContentPanel.ResumeLayout( false );
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout( false );
            this.toolStripContainer1.TopToolStripPanel.PerformLayout( );
            this.toolStripContainer1.ResumeLayout( false );
            this.toolStripContainer1.PerformLayout( );
            this.ResumeLayout( false );

        }

        private System.Resources.ResourceManager _resources = new System.Resources.ResourceManager( typeof( CZBindMakerMainForm ) );
        private Dotnetrix.Controls.TabControlEX _mainTabControl;
        private System.Windows.Forms.TabPage binds_tabPage;
        private System.Windows.Forms.CheckedListBox _bindOptionsListBox;
        private System.Windows.Forms.TabPage config_tabPage;
        private System.Windows.Forms.NumericUpDown _rateUpDown;
        private System.Windows.Forms.CheckBox cl_righthand;
        private System.Windows.Forms.CheckBox _cl_autoweaponswitch;
        private System.Windows.Forms.CheckBox _vgui_menus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton net_grappos_2;
        private System.Windows.Forms.RadioButton net_grappos_1;
        private System.Windows.Forms.RadioButton net_grappos_3;
        private System.Windows.Forms.NumericUpDown _fpsRange;
        private System.Windows.Forms.CheckBox cl_weather;
        private System.Windows.Forms.CheckBox hud_fastswitch;
        private System.Windows.Forms.CheckBox hud_centerID;
        private System.Windows.Forms.GroupBox net_graph_GroupBox;
        private System.Windows.Forms.RadioButton net_graph_0;
        private System.Windows.Forms.RadioButton net_graph_3;
        private System.Windows.Forms.RadioButton net_graph_2;
        private System.Windows.Forms.RadioButton net_graph_1;
        private System.Windows.Forms.CheckBox _dynamicCrossHairs;
        private System.Windows.Forms.TextBox _playerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _consoleColorButton;
        private System.Windows.Forms.Label _consoleColorSample;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox _currentBindListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton unuseableButton6;
        private System.Windows.Forms.RadioButton unuseableButton5;
        private System.Windows.Forms.RadioButton unuseableButton4;
        private System.Windows.Forms.RadioButton unuseableButton3;
        private System.Windows.Forms.RadioButton unuseableButton2;
        private System.Windows.Forms.RadioButton unuseableButton1;
        private System.Windows.Forms.RadioButton kp_0;
        private System.Windows.Forms.RadioButton kp_dot;
        private System.Windows.Forms.RadioButton kp_rtn;
        private System.Windows.Forms.RadioButton kp_3;
        private System.Windows.Forms.RadioButton kp_2;
        private System.Windows.Forms.RadioButton kp_1;
        private System.Windows.Forms.RadioButton kp_6;
        private System.Windows.Forms.RadioButton kp_5;
        private System.Windows.Forms.RadioButton kp_4;
        private System.Windows.Forms.RadioButton kp_plus;
        private System.Windows.Forms.RadioButton kp_9;
        private System.Windows.Forms.RadioButton kp_8;
        private System.Windows.Forms.RadioButton kp_7;
        private System.Windows.Forms.RadioButton kp_dash;
        private System.Windows.Forms.RadioButton astrisk;
        private System.Windows.Forms.RadioButton kp_forwardslash;
        private System.Windows.Forms.RadioButton pause;
        private System.Windows.Forms.RadioButton rightarrow;
        private System.Windows.Forms.RadioButton leftarrow;
        private System.Windows.Forms.RadioButton downarrow;
        private System.Windows.Forms.RadioButton uparrow;
        private System.Windows.Forms.RadioButton pagedown;
        private System.Windows.Forms.RadioButton end;
        private System.Windows.Forms.RadioButton del;
        private System.Windows.Forms.RadioButton pageup;
        private System.Windows.Forms.RadioButton home;
        private System.Windows.Forms.RadioButton ins;
        private System.Windows.Forms.RadioButton rctrl;
        private System.Windows.Forms.RadioButton ralt;
        private System.Windows.Forms.RadioButton space;
        private System.Windows.Forms.RadioButton lalt;
        private System.Windows.Forms.RadioButton lctrl;
        private System.Windows.Forms.RadioButton rshift;
        private System.Windows.Forms.RadioButton forwardslash;
        private System.Windows.Forms.RadioButton closed_tag;
        private System.Windows.Forms.RadioButton open_tag;
        private System.Windows.Forms.RadioButton mkey;
        private System.Windows.Forms.RadioButton nkey;
        private System.Windows.Forms.RadioButton bkey;
        private System.Windows.Forms.RadioButton vkey;
        private System.Windows.Forms.RadioButton ckey;
        private System.Windows.Forms.RadioButton xkey;
        private System.Windows.Forms.RadioButton zkey;
        private System.Windows.Forms.RadioButton lshift;
        private System.Windows.Forms.RadioButton enter;
        private System.Windows.Forms.RadioButton quotes;
        private System.Windows.Forms.RadioButton semicol;
        private System.Windows.Forms.RadioButton lkey;
        private System.Windows.Forms.RadioButton kkey;
        private System.Windows.Forms.RadioButton jkey;
        private System.Windows.Forms.RadioButton hkey;
        private System.Windows.Forms.RadioButton gkey;
        private System.Windows.Forms.RadioButton fkey;
        private System.Windows.Forms.RadioButton dkey;
        private System.Windows.Forms.RadioButton skey;
        private System.Windows.Forms.RadioButton akey;
        private System.Windows.Forms.RadioButton caps;
        private System.Windows.Forms.RadioButton backslash;
        private System.Windows.Forms.RadioButton closed_square_brace_key;
        private System.Windows.Forms.RadioButton open_square_brace_key;
        private System.Windows.Forms.RadioButton pkey;
        private System.Windows.Forms.RadioButton okey;
        private System.Windows.Forms.RadioButton ikey;
        private System.Windows.Forms.RadioButton ukey;
        private System.Windows.Forms.RadioButton ykey;
        private System.Windows.Forms.RadioButton tkey;
        private System.Windows.Forms.RadioButton rkey;
        private System.Windows.Forms.RadioButton ekey;
        private System.Windows.Forms.RadioButton wkey;
        private System.Windows.Forms.RadioButton qkey;
        private System.Windows.Forms.RadioButton tab;
        private System.Windows.Forms.RadioButton backspace;
        private System.Windows.Forms.RadioButton equals;
        private System.Windows.Forms.RadioButton dash;
        private System.Windows.Forms.RadioButton zero;
        private System.Windows.Forms.RadioButton nine;
        private System.Windows.Forms.RadioButton eight;
        private System.Windows.Forms.RadioButton seven;
        private System.Windows.Forms.RadioButton six;
        private System.Windows.Forms.RadioButton five;
        private System.Windows.Forms.RadioButton four;
        private System.Windows.Forms.RadioButton three;
        private System.Windows.Forms.RadioButton two;
        private System.Windows.Forms.RadioButton one;
        private System.Windows.Forms.RadioButton tilda;
        private System.Windows.Forms.RadioButton f12;
        private System.Windows.Forms.RadioButton f11;
        private System.Windows.Forms.RadioButton f10;
        private System.Windows.Forms.RadioButton f9;
        private System.Windows.Forms.RadioButton f8;
        private System.Windows.Forms.RadioButton f7;
        private System.Windows.Forms.RadioButton f6;
        private System.Windows.Forms.RadioButton f5;
        private System.Windows.Forms.RadioButton f4;
        private System.Windows.Forms.RadioButton f3;
        private System.Windows.Forms.RadioButton f2;
        private System.Windows.Forms.RadioButton f1;
        private System.Windows.Forms.RadioButton esc;
        private System.Windows.Forms.PictureBox _logoPictureBox;
        private System.Windows.Forms.TextBox _customBind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cl_radartype;
        private System.Windows.Forms.ImageList _contextImageList;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.ColorDialog _consoleColorPicker;
        private System.Windows.Forms.OpenFileDialog _configFileFinder;
        private System.Windows.Forms.Button _showOrder;
        private System.Windows.Forms.FolderBrowserDialog _exportAs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList _crosshairs;
        private System.Windows.Forms.CheckBox _solidCrosshair;
        private System.Windows.Forms.Label _crosshairSizeLabel;
        private System.Windows.Forms.ComboBox _crosshairSize;
        private System.Windows.Forms.Label _networkRateLabel;
        private System.Windows.Forms.Label _frameRateLabel;
        private System.Windows.Forms.Button _editCrosshairColor;
        private System.Windows.Forms.PictureBox _crosshairSampleImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem notepadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addBindToolBarButton;
        private System.Windows.Forms.ToolStripButton deleteBindToolBarButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton undoStripButton;
        private System.Windows.Forms.ToolStripButton redoStripButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripComboBox radioCommandsToolStripComboBox;
        private System.Windows.Forms.ToolStripButton clearRadioCommandsToolStripButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton _enableSayItem;
        private System.Windows.Forms.ToolStripTextBox sayTeamSayTextBox;
        private System.Windows.Forms.ToolStripComboBox sayTeamSayComboBox;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compressedFileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllConfigsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip currentBindContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editBindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inBindmakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip keyboardContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addBindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectKeyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip bindOptionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem addBindToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uncheckItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem editItemsSequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configcfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoexeccfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userconfigcfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czbindcfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton removeSayTeamSayToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.ComponentModel.IContainer components;
    }
}
