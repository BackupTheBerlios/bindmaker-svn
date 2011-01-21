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
 * If you need further support for this program you may visit
 * http://www.bindmaker.org/ and post in the forums there for help.
 *
 *
 * 
 * */

namespace CZBindMaker {
    using System;
    using System.IO;
    using System.Web;
    using System.Drawing;
    using System.Reflection;
    using System.Collections;
    using System.Diagnostics;
    using System.Windows.Forms;
    using System.Text.RegularExpressions;
    using Microsoft.Win32;
    using System.Globalization;
    /// <summary>
    /// CZ Bind Maker is a utility to configure binds for CS 1.6
    /// </summary>
    public partial class CZBindMakerMainForm : Form {

        private string _clipsFilePath;
        private readonly Point _currentPoint = Point.Empty;
        private Account _account;
        private string _tempAccountUsage;
        private string _crosshairSizeValue;
        private string _crosshairColor;
        private int _crosshairSolid;
        private readonly string _helpFile;
        private BindingSequence _sequence;
        private string _pendingEdit;
        private ArrayList _bindItems;
        private BindMap _bindMap;
        private Games _game = Games.None;
        private string _oldRadioCommand = "";
        private int _sayIndexOfRemoved = -1;
        private string _option = "";
        public static string applicationVersion;
        public static string _configTransferPath;
        public string _autoFilePath = "";
        private string _configFilePath = "";
        private string _bindFilePath = "";
        private string _userFilePath = "";
        private StreamWriter _writer;
        private StreamReader _reader;
        private string _configFileContents;
        private string _binFileContents;
        private string _userFileContents;
        private string _consoleColor;
        private readonly RegistryKey _rKey = Registry.LocalMachine.CreateSubKey( @"SOFTWARE\Valve\Steam" );
        private readonly RegistryKey _rate = Registry.CurrentUser.CreateSubKey( @"SOFTWARE\Valve\Steam" );

        /// <summary>
        /// Default constructor for CZ Bind Maker Application
        /// </summary>
        public CZBindMakerMainForm( ) {
            #region
            _crosshairSizeValue = "auto";
            _crosshairSolid = 0;
            _crosshairColor = "255 128 0";
            Visible = false;
            _pendingEdit = "";
            _helpFile = "file:///" + HttpUtility.HtmlEncode( Path.Combine( Path.GetDirectoryName( Assembly.GetExecutingAssembly( ).Location ), @"Documentation/index.html" ) );

            Version v = Assembly.GetExecutingAssembly( ).GetName( ).Version;
            applicationVersion = v.ToString( );

            Application.DoEvents( );

            // CREATE A SPLASH SCREEN
            CZSplash s = new CZSplash( );
            s.ShowSplash( );


            // INITIALIZE FORM
            s.Action = "Initializing Components";
            InitializeComponent( );

            // sort our radio commands
            radioCommandsToolStripComboBox.Sorted = true;
            sayTeamSayComboBox.SelectedIndex = 0;

            // LOAD THE PATHS TO THE CONFIG FILES
            s.Action = "Loading Data";
            InitializeData( );
            s.Dispose( );
            s = null;
            Visible = true;
            #endregion
        }

        private void UpdateTitle( ) {
            Text = String.Format( "    Code Zulu Bind Maker {0} --  [ {1} ]", applicationVersion, ( _game == Games.CS ? "Counter-Strike 1.6" : ( ( _game == Games.CSS ? "Counter-Strike: Source" : "Condition Zero" ) ) ) );
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            #region
            if ( disposing ) {
                if ( components != null ) {
                    components.Dispose( );
                }
            }
            try {
                _rKey.Close( );
                _rate.Close( );
            } catch { }
            base.Dispose( disposing );
            #endregion
        }


        private bool PromptForConfigLocation( ) {
            MessageBox.Show( "Bind Maker failed to find the Game Directory!\n\nYou will need to browse to your game directory \nand locate the config.cfg file yourself.\t\n\nUsual Locations:\t\n\t (steam apps)\\(account name)\\counter-strike\\cstrike\t\n\t (steam apps)\\(account name)\\condition zero\\czero\t\n\t (steam apps)\\(account name)\\counter-strike source\\cstrike\\cfg\t\t", "Could not find a game directory", MessageBoxButtons.OK, MessageBoxIcon.Information );
            //IF NONE FOUND OPEN DIALOG AND GET USER SETTINGS
            if ( _configFileFinder.ShowDialog( this ) == DialogResult.OK ) {
                _configFilePath = _configFileFinder.FileName;
                _bindFilePath = Regex.Replace( _configFilePath, @"config.cfg", "czbind.cfg", RegexOptions.IgnoreCase );
                _userFilePath = Regex.Replace( _configFilePath, @"config.cfg", "userconfig.cfg", RegexOptions.IgnoreCase );
                _autoFilePath = Regex.Replace( _configFilePath, @"config.cfg", "autoexec.cfg", RegexOptions.IgnoreCase );
                _clipsFilePath = Regex.Replace( _configFilePath, @"config.cfg", "clips.cfg", RegexOptions.IgnoreCase );
                _configFileContents = "";
                _binFileContents = "";
                _userFileContents = "";
                return true;
            }
                // CASE: USER HIT CANCEL ON THE CONFIGURATION DIALOG
            else {
                _configFilePath = "";
                _bindFilePath = "";
                _userFilePath = "";
                _autoFilePath = "";
                _clipsFilePath = "";
                return false;
            }
        }

        private void UpdateAccountName( string account ) {
            _tempAccountUsage = account;
        }

        /// <summary>
        /// Loads the user preferences for CZBindMaker if it exists.  If not, get the path info and write the file.
        /// </summary>
        private void InitializeData( ) {
            #region
            //---[ BEGIN RESOLVE PATHS AND LOAD CONFIGS ]-------------------------------------------
            #region
            bool loadConfig = false;
            _configFilePath = "";
            _bindFilePath = "";
            _userFilePath = "";
            _autoFilePath = "";
            _clipsFilePath = "";
            ConfigSearch cs = new ConfigSearch( );
            if ( cs.KeyFound ) {
                AccountsCollection acc = cs.Accounts;
                if ( acc.Count > 1 ) {
                    string[] acts = new string[acc.Count];
                    for ( int i = 0; i < acc.Count; i++ ) {
                        acts[i] = ( (Account)acc[i] ).AccountName;
                    }
                    using ( AccountChooser ac = new AccountChooser( acts ) { SelectedAccountName = UpdateAccountName } ) {
                        ac.ShowDialog( this );
                    }

                } else if ( cs.Accounts.Count == 1 ) {
                    _tempAccountUsage = ( (Account)cs.Accounts[0] ).AccountName;
                } else {
                    loadConfig = PromptForConfigLocation( );
                }
                Account act = acc[_tempAccountUsage];
                _account = act;
                Games g = Games.None;
                if ( act.GamesListed == ( Games.CS | Games.CZ | Games.CSS ) ) {
                    using ( GameSelector gs = new GameSelector( act.GamesListed ) ) {
                        gs.SelectGame += gs_SelectGame;
                        gs.ShowDialog( this );
                    }
                    if ( _option.ToLower( ) == "cs" ) {
                        g = _game = Games.CS;
                    } else if ( _option.ToLower( ) == "css" ) {
                        g = _game = Games.CSS;
                    } else if ( _option.ToLower( ) == "cz" ) {
                        g = _game = Games.CZ;
                    }
                } else if ( act.GamesListed == ( Games.CS | Games.CZ ) ) {
                    using ( GameSelector gs = new GameSelector( act.GamesListed ) ) {
                        gs.SelectGame += gs_SelectGame;
                        gs.ShowDialog( this );
                    }
                    if ( _option.ToLower( ) == "cs" ) {
                        g = _game = Games.CS;
                    } else if ( _option.ToLower( ) == "cz" ) {
                        g = _game = Games.CZ;
                    }
                } else if ( act.GamesListed == ( Games.CS | Games.CSS ) ) {
                    using ( GameSelector gs = new GameSelector( act.GamesListed ) ) {
                        gs.SelectGame += gs_SelectGame;
                        gs.ShowDialog( this );
                    }
                    if ( _option.ToLower( ) == "cs" ) {
                        g = _game = Games.CS;
                    } else if ( _option.ToLower( ) == "css" ) {
                        g = _game = Games.CSS;
                    }
                } else if ( act.GamesListed == ( Games.CSS | Games.CZ ) ) {
                    using ( GameSelector gs = new GameSelector( act.GamesListed ) ) {
                        gs.SelectGame += gs_SelectGame;
                        gs.ShowDialog( this );
                    }
                    if ( _option.ToLower( ) == "css" ) {
                        g = _game = Games.CSS;
                    } else if ( _option.ToLower( ) == "cz" ) {
                        g = _game = Games.CZ;
                    }
                } else if ( act.GamesListed == Games.CS ) {
                    g = _game = Games.CS;
                } else if ( act.GamesListed == Games.CZ ) {
                    g = _game = Games.CZ;
                } else if ( act.GamesListed == Games.CSS ) {
                    g = _game = Games.CSS;
                }
                if ( g != Games.None ) {
                    // make sure we have the compatibility file if game is css
                    if ( g == Games.CSS && !File.Exists( act.GetConfigPath( g, ConfigType.Compatibility ) ) ) {
                        Stream s = System.Reflection.Assembly.GetExecutingAssembly( ).GetManifestResourceStream( "CZBindMaker.compatibility.cfg" );
                        byte[] data = new byte[s.Length];
                        s.Read( data, 0, data.Length );
                        s.Close( );
                        FileStream fs = new FileStream( act.GetConfigPath( g, ConfigType.Compatibility ), FileMode.Create, FileAccess.Write );
                        fs.Write( data, 0, data.Length );
                        fs.Flush( );
                        fs.Close( );
                    }
                    _configFilePath = act.GetConfigPath( g, ConfigType.Config );
                    _bindFilePath = act.GetConfigPath( g, ConfigType.Czbm );
                    _userFilePath = act.GetConfigPath( g, ConfigType.User );
                    _autoFilePath = act.GetConfigPath( g, ConfigType.Auto );
                    _clipsFilePath = act.GetConfigPath( g, ConfigType.Clips );
                    loadConfig = true;
                }
                if ( _game == Games.CSS ) DisableConfigForSource( );
                else EnableConfig( );
                if ( loadConfig ) LoadConfigFile( );
            } else {
                MessageBox.Show( "Failed to find Game Directory!\n\nYou will need to browse to your game directory (cstrike or czero) \nand locate your config.cfg file yourself.\t", "Info: Could not find a game directory", MessageBoxButtons.OK, MessageBoxIcon.Information );
                //IF NONE FOUND OPEN DIALOG AND GET USER SETTINGS
                if ( _configFileFinder.ShowDialog( this ) == DialogResult.OK ) {
                    _configFilePath = _configFileFinder.FileName;
                    _bindFilePath = Regex.Replace( _configFilePath, @"config.cfg", "czbind.cfg", RegexOptions.IgnoreCase );
                    _userFilePath = Regex.Replace( _configFilePath, @"config.cfg", "userconfig.cfg", RegexOptions.IgnoreCase );
                    _autoFilePath = Regex.Replace( _configFilePath, @"config.cfg", "autoexec.cfg", RegexOptions.IgnoreCase );
                    _clipsFilePath = Regex.Replace( _configFilePath, @"config.cfg", "clips.cfg", RegexOptions.IgnoreCase );
                    loadConfig = true;
                }
                    // CASE: USER HIT CANCEL ON THE CONFIGURATION DIALOG
                 else {
                    _configFilePath = "";
                    _bindFilePath = "";
                    _userFilePath = "";
                    _autoFilePath = "";
                    loadConfig = false;
                    //MessageBox.Show("You have to select your config file before you can save your custom binds!", "Can't save without a config file",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            #endregion
            //---[ END RESOLVE PATHS AND LOAD CONFIGS ]---------------------------------------------

            //---[ BEGIN LOADING DYNAMIC DATA FROM HASH MAPS ]--------------------------------------
            #region
            #region BINDS LIST
            _bindItems = new ArrayList( );
            _bindMap = new BindMap( );
            _bindOptionsListBox.Items.Clear( );
            foreach ( string s in _bindMap.BuyKeys ) {
                _bindOptionsListBox.Items.Add( s );
            }
            #endregion
            #region RADIO COMMANDS
            radioCommandsToolStripComboBox.Items.Clear( );
            foreach ( string s in _bindMap.RadioKeys ) {
                radioCommandsToolStripComboBox.Items.Add( s );
            }
            #endregion
            #region SAY/TEAM SAY
            sayTeamSayComboBox.Items.Clear( );
            sayTeamSayComboBox.Items.Add( "- Choose -" );
            foreach ( string s in _bindMap.SayKeys ) {
                sayTeamSayComboBox.Items.Add( s );
            }
            sayTeamSayComboBox.SelectedIndex = 0;
            #endregion
            #region CONSOLE SIZE COMBOBOX
            _crosshairSize.SelectedIndex = 0;
            #endregion
            #endregion
            //---[ END LOADING DYNAMIC DATA FROM HASH MAPS ]----------------------------------------
            UpdateTitle( );
            #endregion
        }
        /// <summary>
        /// Load the Config.cfg file from a file dialog box
        /// </summary>
        /// <param name="path">The Config File Path</param>
        /// <param name="init">
        /// Is this the initial loading of the document? If so, It will check
        /// to make sure that the <b>exec czbind.cfg</b> is included in the 
        /// <b>config.cfg</b>.  Not needed if the config file is reloaded during 
        /// runtime.
        /// </param>
        private void LoadConfigFile( ) {
            #region
            try {
                _currentBindListBox.Items.Clear( );
            } catch { }
            string temp;
            string[] split;
            bool contFlag = true;
            // READ THE CONTENTS OF THE CONFIG FILE INTO THE CONFIGFILECONTENTS STRING
            #region DONE
            try {
                if ( !File.Exists( Regex.Replace( _configFilePath, "config.cfg", "config_backup.cfg" ) ) )
                    File.Copy( _configFilePath, Regex.Replace( _configFilePath, "config.cfg", "config_backup.cfg" ) );
                _reader = new StreamReader( _configFilePath );
                _configFileContents = _reader.ReadToEnd( );
                _reader.DiscardBufferedData( );
                _reader.Close( );
                _reader = null;
            } catch ( Exception e ) {
                e.ToString( );
                contFlag = false;
            }
            #endregion

            // READ THE CONTENTS OF THE USERCONFIG FILE INTO THE CONFIGFILECONTENTS STRING
            #region DONE
            try {
                _reader = new StreamReader( _userFilePath );
                _userFileContents = _reader.ReadToEnd( );
                _reader.DiscardBufferedData( );
                _reader.Close( );
                _reader = null;
            } catch ( Exception e ) {
                e.ToString( );
                _writer = new StreamWriter( _userFilePath, false );
                _writer.Write( "" );
                _writer.Flush( );
                _writer.Close( );
                _writer = null;
                _userFileContents = "";
            }
            #endregion

            // ITERATE THROUGH THE CZBIND FILE AND ADD ALL BINDS TO THE CURRENT BIND LISTBOX
            #region DONE
            try {
                _reader = new StreamReader( _bindFilePath );
                _binFileContents = _reader.ReadToEnd( );
                _reader.DiscardBufferedData( );
                _reader.Close( );
                _reader = null;
            } catch ( Exception e ) {
                e.ToString( );
                contFlag = false;
                _writer = new StreamWriter( _bindFilePath );
                _writer.Write( "" );
                _writer.Flush( );
                _writer.Close( );
                _writer = null;
            }
            #endregion

            // LOOK IN AUTOEXEC.CFG TO SEE IF OUR ALIASES ARE THERE
            #region
            if ( _autoFilePath != "" ) {
                if ( !File.Exists( _autoFilePath ) ) {
                    File.Create( _autoFilePath ).Close( );
                }
                _reader = new StreamReader( _autoFilePath, true );
                string auto = _reader.ReadToEnd( );
                _reader.Close( );
                bool detected = true;
                bool execs = false;
                if ( !Regex.Match( auto, BindMap.CSAliases, RegexOptions.Multiline ).Success ) {
                    detected = false;
                }
                if ( _game == Games.CSS && !Regex.IsMatch( auto, @"exec compatibility\.cfg", RegexOptions.Multiline ) ) {
                    execs = true;
                }
                if ( !detected | execs ) {
                    try {
                        _writer = new StreamWriter( _autoFilePath, true );
                        if ( !detected )
                            _writer.WriteLine( "\r\n\r\n// CZ Bind Maker Aliases (do not remove):\r\n{0}", BindMap.CSAliases );
                        if ( execs )
                            _writer.WriteLine( "\r\n\r\n// CZ Bind Maker Aliases (do not remove):\r\nexec compatibility.cfg" );
                        _writer.Flush( );
                        _writer.Close( );
                    } catch {
                        string title = "Error appending aliases";
                        string message = "There was an error inserting aliases into your autoexec.cfg file.\t\r\nMake sure that file is not \"Read Only\" and try again\t";
                        MessageBox.Show( this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                }
            }
            #endregion

            // IF THERE IS NO CALL TO OUR CUSTOM BIND FILE IN THE CONFIG FILE WRITE IT.
            #region DONE
            if ( !Regex.Match( _userFileContents, @"exec\sczbind.cfg\r\n" ).Success ) {
                _writer = new StreamWriter( _userFilePath, false );
                if ( Regex.Match( _userFileContents, @".+\r\n$" ).Success ) {
                    _userFileContents = "//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n// CZ BIND MAKER\r\n// © 2003-7 Steven Whitley (aka [CZ] Qw4z0)\r\n// Custom Binds For CS1.6, CS:CZ & CS:S\r\n// Last Updated On " + DateTime.Now + "\r\n//\r\n// Visit http://www.bindmaker.org For Updates\r\n//\r\n//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n\r\n"
                        + _userFileContents + "exec czbind.cfg\r\n";
                } else {
                    _userFileContents = "//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n// CZ BIND MAKER\r\n// © 2003-7 Steven Whitley (aka [CZ] Qw4z0)\r\n// Custom Binds For CS1.6, CS:CZ & CS:S\r\n// Last Updated On " + DateTime.Now + "\r\n//\r\n// Visit http://www.bindmaker.org For Updates\r\n//\r\n//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n\r\n"
                        + _userFileContents + "\r\nexec czbind.cfg\r\n";
                }
                _writer.Write( _userFileContents );
                _writer.Flush( );
                _writer.Close( );
                _writer = null;
            }
            if ( !Regex.IsMatch( _userFileContents, @"exec clips.cfg", RegexOptions.Multiline ) ) {
                if ( !File.Exists( _clipsFilePath ) ) {
                    try {
                        Stream s = System.Reflection.Assembly.GetExecutingAssembly( ).GetManifestResourceStream( "CZBindMaker.clips.cfg" );
                        byte[] data = new byte[s.Length];
                        s.Read( data, 0, data.Length );
                        s.Close( );
                        using ( FileStream fs = new FileStream( _clipsFilePath, FileMode.Create, FileAccess.Write ) ) {
                            fs.Write( data, 0, data.Length );
                            fs.Flush( );
                            fs.Close( );
                        }
                    } finally {
                    }
                }
                if ( !Regex.IsMatch( _userFileContents, @"exec clips.cfg", RegexOptions.Multiline ) ) {
                    using ( StreamWriter sw = File.AppendText( _userFilePath ) ) {
                        sw.WriteLine( "\r\n\r\n// For CZ Bind Maker (do not remove):\r\nexec clips.cfg" );
                    }
                }
            }
            #endregion

            #region
            if ( _configFileContents != "" && _game != Games.CSS ) {
                try {
                    // crosshair transparency
                    #region
                    if ( Regex.Match( _configFileContents, @"cl_crosshair_translucent\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Success ) {
                        string buffer = Regex.Match( _configFileContents, @"cl_crosshair_translucent\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Value;
                        buffer = Regex.Replace( buffer, @"cl_crosshair_translucent\s+", "" );
                        buffer = buffer.Replace( "\"", "" );
                        buffer = buffer.Replace( "\r", "" );
                        buffer = buffer.Replace( "\n", "" );
                        buffer = buffer.Trim( );
                        if ( char.IsNumber( buffer, 0 ) ) {
                            if ( buffer.ToLower( ) == "0" ) {
                                _solidCrosshair.Checked = true;
                                _crosshairSolid = 0;
                            } else {
                                _solidCrosshair.Checked = false;
                                _crosshairSolid = 1;
                            }
                        } else {
                            _solidCrosshair.Checked = false;
                        }
                    } else {
                        _solidCrosshair.Checked = false;
                        _configFileContents += "\r\ncl_crosshair_translucent \"1\"";
                        _crosshairSolid = 1;
                        WriteBinds( );
                        LoadConfigFile( );
                        return;
                    }
                    #endregion

                    // crosshair color 
                    #region
                    if ( Regex.Match( _configFileContents, @"cl_crosshair_color\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Success ) {
                        string buffer = Regex.Match( _configFileContents, @"cl_crosshair_color\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Value;
                        buffer = Regex.Replace( buffer, @"cl_crosshair_color\s+", "" );
                        buffer = buffer.Replace( "\"", "" );
                        buffer = buffer.Replace( "\r", "" );
                        buffer = buffer.Replace( "\n", "" );
                        string[] rgb = GetColorFromString( buffer.Trim( ) );
                        _crosshairColor = String.Format( "{0} {1} {2}", rgb );
                        if ( !_solidCrosshair.Checked ) {
                            _crosshairSampleImage.BackColor = Color.FromArgb( 75, Convert.ToInt32( rgb[0] ), Convert.ToInt32( rgb[1] ), Convert.ToInt32( rgb[2] ) );
                        } else {
                            _crosshairSampleImage.BackColor = Color.FromArgb( Convert.ToInt32( rgb[0] ), Convert.ToInt32( rgb[1] ), Convert.ToInt32( rgb[2] ) );
                        }
                    } else {
                        _configFileContents += "\r\ncl_crosshair_color \"50 250 50\"\r\n";
                        _crosshairColor = "50 250 50";
                        WriteBinds( );
                        LoadConfigFile( );
                        return;
                    }
                    #endregion

                    // crosshair size   
                    #region
                    if ( Regex.Match( _configFileContents, @"cl_crosshair_size\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Success ) {
                        string buffer = Regex.Match( _configFileContents, @"cl_crosshair_size\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Value;
                        buffer = Regex.Replace( buffer, @"cl_crosshair_size\s+", "" );
                        buffer = buffer.Replace( "\"", "" );
                        buffer = buffer.Replace( "\r", "" );
                        buffer = buffer.Replace( "\n", "" );
                        buffer = buffer.Trim( ).ToLower( );
                        switch ( buffer ) {
                            case "small":
                                _crosshairSampleImage.Image = _crosshairs.Images[0];
                                _crosshairSize.SelectedIndex = 1;
                                _crosshairSizeValue = buffer;
                                break;
                            case "medium":
                                _crosshairSampleImage.Image = _crosshairs.Images[1];
                                _crosshairSize.SelectedIndex = 2;
                                _crosshairSizeValue = buffer;
                                break;
                            case "large":
                                _crosshairSampleImage.Image = _crosshairs.Images[2];
                                _crosshairSize.SelectedIndex = 3;
                                _crosshairSizeValue = buffer;
                                break;
                            default:
                                _crosshairSizeValue = "auto";
                                break;
                        }
                    } else {
                        _configFileContents += "\r\ncl_crosshair_size \"auto\"";
                        _crosshairSizeValue = "auto";
                        WriteBinds( );
                        LoadConfigFile( );
                        return;
                    }
                    #endregion

                    // RATE
                    #region DONE
                    string temp_rate = "";
                    // hackish... retail CZ doesn't have the proper registry settings, so 
                    // we'll just create them anyway.
                    if ( _rate.GetValue( "Rate", "not present" ) == (object)"not present" ) {
                        _rate.SetValue( "Rate", "20000" );
                    }
                    try {
                        temp_rate = _rate == null ? "20000" : _rate.GetValue( "Rate" ).ToString( );
                    } catch ( Exception e ) {
                        e.ToString( );
                    }
                    if ( temp_rate != "" ) {
                        _rateUpDown.Value = decimal.Parse( temp_rate );
                    }
                    #endregion

                    // RADAR TYPE
                    #region
                    if ( Regex.Match( _configFileContents, @"cl_radartype\s\x22.*\x22" ).Success ) {
                        if ( Regex.Match( _configFileContents, @"cl_radartype\s\x221\x22" ).Success )
                            cl_radartype.Checked = true;
                        if ( Regex.Match( _configFileContents, @"cl_radartype\s\x220\x22" ).Success )
                            cl_radartype.Checked = false;
                    }
                    #endregion

                    // AUTO WEAPON SWITCH
                    #region DONE
                    if ( Regex.Match( _configFileContents, @"_cl_autowepswitch\s\x22.*\x22" ).Success ) {
                        if ( Regex.Match( _configFileContents, @"_cl_autowepswitch\s\x221\x22" ).Success )
                            _cl_autoweaponswitch.Checked = true;
                        if ( Regex.Match( _configFileContents, @"_cl_autowepswitch\s\x220\x22" ).Success )
                            _cl_autoweaponswitch.Checked = false;
                    }
                    #endregion

                    // RIGHT HANDED PLAYER MODEL
                    #region DONE
                    if ( Regex.Match( _configFileContents, @"cl_righthand\s\x22.*\x22" ).Success ) {
                        if ( Regex.Match( _configFileContents, @"cl_righthand\s\x221\x22" ).Success )
                            cl_righthand.Checked = true;
                        if ( Regex.Match( _configFileContents, @"cl_righthand\s\x220\x22" ).Success )
                            cl_righthand.Checked = false;
                    }
                    #endregion

                    // GET THE VALUE OF VGUI MENU OPTION
                    #region DONE
                    if ( Regex.Match( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x22.*\x22" ).Success ) {
                        if ( Regex.Match( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x221\x22" ).Success )
                            _vgui_menus.Checked = true;
                        if ( Regex.Match( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x220\x22" ).Success )
                            _vgui_menus.Checked = false;
                    }
                    #endregion

                    // GET THE CONTENTS OF THE CONSOLE COLOR
                    #region DONE
                    string[] color = GetColorFromString( Regex.Replace( Regex.Match( _configFileContents, @"con_color\s\x22.*\x22\r\n" ).Value, @"(con_color\s\x22)|(\x22\r\n)", "" ) );
                    try {
                        _consoleColor = String.Format( "{0} {1} {2}", color[0], color[1], color[2] );
                        _consoleColorSample.ForeColor = Color.FromArgb( int.Parse( color[0] ), int.Parse( color[1] ), int.Parse( color[2] ) );
                    } catch ( Exception e ) { e.ToString( ); }
                    #endregion

                    // GET THE VALUE OF THE NETGRAPH
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"net_graph\s\x22[0-3]\x22" ).Value;
                    switch ( temp ) {
                        case "net_graph \"0\"":
                            net_graph_0.Checked = true;
                            break;
                        case "net_graph \"1\"":
                            net_graph_1.Checked = true;
                            break;
                        case "net_graph \"2\"":
                            net_graph_2.Checked = true;
                            break;
                        case "net_graph \"3\"":
                            net_graph_3.Checked = true;
                            break;
                        default:
                            net_graph_0.Checked = true;
                            break;
                    }
                    #endregion

                    // GET THE VALUE OF THE NETGRAPHPOS
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"net_graphpos\s\x22[1-3]\x22" ).Value;
                    switch ( temp ) {
                        case "net_graphpos \"1\"":
                            net_grappos_1.Checked = true;
                            break;
                        case "net_graphpos \"2\"":
                            net_grappos_2.Checked = true;
                            break;
                        case "net_graphpos \"3\"":
                            net_grappos_3.Checked = true;
                            break;
                        default:
                            net_grappos_3.Checked = true;
                            break;
                    }
                    #endregion

                    // GET FRAMES PER SECOND MAX
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"fps_max\s\x22\d{1,3}\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    _fpsRange.Value = decimal.Parse( split[1] );
                    #endregion

                    // GET THE VALUE OF WEATHER CONDITIONS
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"cl_weather\s\x22.*\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    if ( split[1] == "1" )
                        cl_weather.Checked = true;
                    if ( split[1] == "0" )
                        cl_weather.Checked = false;
                    #endregion

                    // GET THE VALUE OF DYNAMIC CROSS HAIRS
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"cl_dynamiccrosshair\s\x22[0,1]\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    if ( split[1] == "1" )
                        _dynamicCrossHairs.Checked = true;
                    if ( split[1] == "0" )
                        _dynamicCrossHairs.Checked = false;
                    #endregion

                    // GET THE VALUE OF FAST SWITCH
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"hud_fastswitch\s\x22[0,1]\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    if ( split[1] == "1" )
                        hud_fastswitch.Checked = true;
                    if ( split[1] == "0" )
                        hud_fastswitch.Checked = false;
                    #endregion

                    // GET THE VALUE OF CENTER PLAYER NAMES
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"hud_centerid\s\x22[0,1]\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    if ( split[1] == "1" )
                        hud_centerID.Checked = true;
                    if ( split[1] == "0" )
                        hud_centerID.Checked = false;
                    #endregion

                    // GET THE PLAYER NAME
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"name\s\x22.+\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    _playerName.Text = split[1];
                    #endregion

                } catch ( Exception e ) {
                    // CATCH & DO SOMETHING LATER
                    e.ToString( );
                }
            }
            #endregion

            if ( _binFileContents != "" && contFlag ) {
                split = Regex.Split( _binFileContents, "\r\n" );
                foreach ( string s in split ) {
                    if ( Regex.Match( s, @"^bind\s\x22.*" ).Success )
                        _currentBindListBox.Items.Add( s );
                }
            }
            #endregion
        }
        /// <summary>
        /// Load the Config.cfg file from a file dialog box
        /// </summary>
        /// <param name="path">The Config File Path</param>
        /// <param name="init">
        /// Is this the initial loading of the document? If so, It will check
        /// to make sure that the <b>exec czbind.cfg</b> is included in the 
        /// <b>config.cfg</b>.  Not needed if the config file is reloaded during 
        /// runtime.
        /// </param>
        private void LoadConfigFileCss( ) {
            #region
            try {
                _currentBindListBox.Items.Clear( );
            } catch { }
            string temp;
            string[] split;
            bool contFlag = true;
            // READ THE CONTENTS OF THE CONFIG FILE INTO THE CONFIGFILECONTENTS STRING
            #region DONE
            try {
                if ( !File.Exists( Regex.Replace( _configFilePath, "config.cfg", "config_backup.cfg" ) ) )
                    File.Copy( _configFilePath, Regex.Replace( _configFilePath, "config.cfg", "config_backup.cfg" ) );
                _reader = new StreamReader( _configFilePath );
                _configFileContents = _reader.ReadToEnd( );
                _reader.DiscardBufferedData( );
                _reader.Close( );
                _reader = null;
            } catch ( Exception e ) {
                e.ToString( );
                contFlag = false;
            }
            #endregion

            // READ THE CONTENTS OF THE USERCONFIG FILE INTO THE CONFIGFILECONTENTS STRING
            #region DONE
            try {
                _reader = new StreamReader( _userFilePath );
                _userFileContents = _reader.ReadToEnd( );
                _reader.DiscardBufferedData( );
                _reader.Close( );
                _reader = null;
            } catch ( Exception e ) {
                e.ToString( );
                _writer = new StreamWriter( _userFilePath, false );
                _writer.Write( "" );
                _writer.Flush( );
                _writer.Close( );
                _writer = null;
                _userFileContents = "";
            }
            #endregion

            // ITERATE THROUGH THE CZBIND FILE AND ADD ALL BINDS TO THE CURRENT BIND LISTBOX
            #region DONE
            try {
                _reader = new StreamReader( _bindFilePath );
                _binFileContents = _reader.ReadToEnd( );
                _reader.DiscardBufferedData( );
                _reader.Close( );
                _reader = null;
            } catch ( Exception e ) {
                e.ToString( );
                contFlag = false;
                _writer = new StreamWriter( _bindFilePath );
                _writer.Write( "" );
                _writer.Flush( );
                _writer.Close( );
                _writer = null;
            }
            #endregion

            // LOOK IN AUTOEXEC.CFG TO SEE IF OUR ALIASES ARE THERE
            #region
            if ( _autoFilePath != "" ) {
                if ( !File.Exists( _autoFilePath ) ) {
                    File.Create( _autoFilePath ).Close( );
                }
                _reader = new StreamReader( _autoFilePath, true );
                string auto = _reader.ReadToEnd( );
                _reader.Close( );
                bool detected = true;
                bool execs = false;
                if ( !Regex.Match( auto, BindMap.CSAliases, RegexOptions.Multiline ).Success ) {
                    detected = false;
                }
                if ( _game == Games.CSS && !Regex.IsMatch( auto, @"exec compatibility\.cfg", RegexOptions.Multiline ) ) {
                    execs = true;
                }
                if ( !detected | execs ) {
                    try {
                        _writer = new StreamWriter( _autoFilePath, true );
                        if ( !detected )
                            _writer.WriteLine( "\r\n\r\n// CZ Bind Maker Aliases (do not remove):\r\n{0}", BindMap.CSAliases );
                        if ( execs )
                            _writer.WriteLine( "\r\n\r\n// CZ Bind Maker Aliases (do not remove):\r\nexec compatibility.cfg" );
                        _writer.Flush( );
                        _writer.Close( );
                    } catch {
                        string title = "Error appending aliases";
                        string message = "There was an error inserting aliases into your autoexec.cfg file.\t\r\nMake sure that file is not \"Read Only\" and try again\t";
                        MessageBox.Show( this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                }
            }
            #endregion

            // IF THERE IS NO CALL TO OUR CUSTOM BIND FILE IN THE CONFIG FILE WRITE IT.
            #region DONE
            if ( !Regex.Match( _userFileContents, @"exec\sczbind.cfg\r\n" ).Success ) {
                _writer = new StreamWriter( _userFilePath, false );
                if ( Regex.Match( _userFileContents, @".+\r\n$" ).Success ) {
                    _userFileContents = "//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n// CZ BIND MAKER\r\n// © 2003-11 Steven Whitley (aka [CZ] Qw4z0)\r\n// Custom Binds For CS1.6, CS:CZ & CS:S\r\n// Last Updated On " + DateTime.Now + "\r\n//\r\n// Visit http://www.bindmaker.org For Updates\r\n//\r\n//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n\r\n"
                        + _userFileContents + "exec czbind.cfg\r\n";
                } else {
                    _userFileContents = "//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n// CZ BIND MAKER\r\n// © 2003-11 Steven Whitley (aka [CZ] Qw4z0)\r\n// Custom Binds For CS1.6, CS:CZ & CS:S\r\n// Last Updated On " + DateTime.Now + "\r\n//\r\n// Visit http://www.bindmaker.org For Updates\r\n//\r\n//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n\r\n"
                        + _userFileContents + "\r\nexec czbind.cfg\r\n";
                }
                _writer.Write( _userFileContents );
                _writer.Flush( );
                _writer.Close( );
                _writer = null;
            }
            #endregion

            #region
            if ( _configFileContents != "" && _game != Games.CSS ) {
                try {
                    // crosshair transparency
                    #region
                    if ( Regex.Match( _configFileContents, @"cl_crosshair_translucent\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Success ) {
                        string buffer = Regex.Match( _configFileContents, @"cl_crosshair_translucent\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Value;
                        buffer = Regex.Replace( buffer, @"cl_crosshair_translucent\s+", "" );
                        buffer = buffer.Replace( "\"", "" );
                        buffer = buffer.Replace( "\r", "" );
                        buffer = buffer.Replace( "\n", "" );
                        buffer = buffer.Trim( );
                        if ( char.IsNumber( buffer, 0 ) ) {
                            if ( buffer.ToLower( ) == "0" ) {
                                _solidCrosshair.Checked = true;
                                _crosshairSolid = 0;
                            } else {
                                _solidCrosshair.Checked = false;
                                _crosshairSolid = 1;
                            }
                        } else {
                            _solidCrosshair.Checked = false;
                        }
                    } else {
                        _solidCrosshair.Checked = false;
                        _configFileContents += "\r\ncl_crosshair_translucent \"1\"";
                        _crosshairSolid = 1;
                        WriteBinds( );
                        LoadConfigFile( );
                        return;
                    }
                    #endregion

                    // crosshair color 
                    #region
                    if ( Regex.Match( _configFileContents, @"cl_crosshair_color\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Success ) {
                        string buffer = Regex.Match( _configFileContents, @"cl_crosshair_color\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Value;
                        buffer = Regex.Replace( buffer, @"cl_crosshair_color\s+", "" );
                        buffer = buffer.Replace( "\"", "" );
                        buffer = buffer.Replace( "\r", "" );
                        buffer = buffer.Replace( "\n", "" );
                        string[] rgb = GetColorFromString( buffer.Trim( ) );
                        _crosshairColor = String.Format( "{0} {1} {2}", rgb );
                        if ( !_solidCrosshair.Checked ) {
                            _crosshairSampleImage.BackColor = Color.FromArgb( 75, Convert.ToInt32( rgb[0] ), Convert.ToInt32( rgb[1] ), Convert.ToInt32( rgb[2] ) );
                        } else {
                            _crosshairSampleImage.BackColor = Color.FromArgb( Convert.ToInt32( rgb[0] ), Convert.ToInt32( rgb[1] ), Convert.ToInt32( rgb[2] ) );
                        }
                    } else {
                        _configFileContents += "\r\ncl_crosshair_color \"50 250 50\"\r\n";
                        _crosshairColor = "50 250 50";
                        WriteBinds( );
                        LoadConfigFile( );
                        return;
                    }
                    #endregion

                    // crosshair size   
                    #region
                    if ( Regex.Match( _configFileContents, @"cl_crosshair_size\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Success ) {
                        string buffer = Regex.Match( _configFileContents, @"cl_crosshair_size\s.*\r?\n?", RegexOptions.Multiline | RegexOptions.ExplicitCapture ).Value;
                        buffer = Regex.Replace( buffer, @"cl_crosshair_size\s+", "" );
                        buffer = buffer.Replace( "\"", "" );
                        buffer = buffer.Replace( "\r", "" );
                        buffer = buffer.Replace( "\n", "" );
                        buffer = buffer.Trim( ).ToLower( );
                        switch ( buffer ) {
                            case "small":
                                _crosshairSampleImage.Image = _crosshairs.Images[0];
                                _crosshairSize.SelectedIndex = 1;
                                _crosshairSizeValue = buffer;
                                break;
                            case "medium":
                                _crosshairSampleImage.Image = _crosshairs.Images[1];
                                _crosshairSize.SelectedIndex = 2;
                                _crosshairSizeValue = buffer;
                                break;
                            case "large":
                                _crosshairSampleImage.Image = _crosshairs.Images[2];
                                _crosshairSize.SelectedIndex = 3;
                                _crosshairSizeValue = buffer;
                                break;
                            default:
                                _crosshairSizeValue = "auto";
                                break;
                        }
                    } else {
                        _configFileContents += "\r\ncl_crosshair_size \"auto\"";
                        _crosshairSizeValue = "auto";
                        WriteBinds( );
                        LoadConfigFile( );
                        return;
                    }
                    #endregion

                    // RATE
                    #region DONE
                    string temp_rate = "";
                    // hackish... retail CZ doesn't have the proper registry settings, so 
                    // we'll just create them anyway.
                    if ( _rate.GetValue( "Rate", "not present" ) == (object)"not present" ) {
                        _rate.SetValue( "Rate", "20000" );
                    }
                    try {
                        temp_rate = _rate == null ? "20000" : _rate.GetValue( "Rate" ).ToString( );
                    } catch ( Exception e ) {
                        e.ToString( );
                    }
                    if ( temp_rate != "" ) {
                        _rateUpDown.Value = decimal.Parse( temp_rate );
                    }
                    #endregion

                    // RADAR TYPE
                    #region
                    if ( Regex.Match( _configFileContents, @"cl_radartype\s\x22.*\x22" ).Success ) {
                        if ( Regex.Match( _configFileContents, @"cl_radartype\s\x221\x22" ).Success )
                            cl_radartype.Checked = true;
                        if ( Regex.Match( _configFileContents, @"cl_radartype\s\x220\x22" ).Success )
                            cl_radartype.Checked = false;
                    }
                    #endregion

                    // AUTO WEAPON SWITCH
                    #region DONE
                    if ( Regex.Match( _configFileContents, @"_cl_autowepswitch\s\x22.*\x22" ).Success ) {
                        if ( Regex.Match( _configFileContents, @"_cl_autowepswitch\s\x221\x22" ).Success )
                            _cl_autoweaponswitch.Checked = true;
                        if ( Regex.Match( _configFileContents, @"_cl_autowepswitch\s\x220\x22" ).Success )
                            _cl_autoweaponswitch.Checked = false;
                    }
                    #endregion

                    // RIGHT HANDED PLAYER MODEL
                    #region DONE
                    if ( Regex.Match( _configFileContents, @"cl_righthand\s\x22.*\x22" ).Success ) {
                        if ( Regex.Match( _configFileContents, @"cl_righthand\s\x221\x22" ).Success )
                            cl_righthand.Checked = true;
                        if ( Regex.Match( _configFileContents, @"cl_righthand\s\x220\x22" ).Success )
                            cl_righthand.Checked = false;
                    }
                    #endregion

                    // GET THE VALUE OF VGUI MENU OPTION
                    #region DONE
                    if ( Regex.Match( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x22.*\x22" ).Success ) {
                        if ( Regex.Match( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x221\x22" ).Success )
                            _vgui_menus.Checked = true;
                        if ( Regex.Match( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x220\x22" ).Success )
                            _vgui_menus.Checked = false;
                    }
                    #endregion

                    // GET THE CONTENTS OF THE CONSOLE COLOR
                    #region DONE
                    string[] color = GetColorFromString( Regex.Replace( Regex.Match( _configFileContents, @"con_color\s\x22.*\x22\r\n" ).Value, @"(con_color\s\x22)|(\x22\r\n)", "" ) );
                    try {
                        _consoleColor = String.Format( "{0} {1} {2}", color[0], color[1], color[2] );
                        _consoleColorSample.ForeColor = Color.FromArgb( int.Parse( color[0] ), int.Parse( color[1] ), int.Parse( color[2] ) );
                    } catch ( Exception e ) { e.ToString( ); }
                    #endregion

                    // GET THE VALUE OF THE NETGRAPH
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"net_graph\s\x22[0-3]\x22" ).Value;
                    switch ( temp ) {
                        case "net_graph \"0\"":
                            net_graph_0.Checked = true;
                            break;
                        case "net_graph \"1\"":
                            net_graph_1.Checked = true;
                            break;
                        case "net_graph \"2\"":
                            net_graph_2.Checked = true;
                            break;
                        case "net_graph \"3\"":
                            net_graph_3.Checked = true;
                            break;
                        default:
                            net_graph_0.Checked = true;
                            break;
                    }
                    #endregion

                    // GET THE VALUE OF THE NETGRAPHPOS
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"net_graphpos\s\x22[1-3]\x22" ).Value;
                    switch ( temp ) {
                        case "net_graphpos \"1\"":
                            net_grappos_1.Checked = true;
                            break;
                        case "net_graphpos \"2\"":
                            net_grappos_2.Checked = true;
                            break;
                        case "net_graphpos \"3\"":
                            net_grappos_3.Checked = true;
                            break;
                        default:
                            net_grappos_3.Checked = true;
                            break;
                    }
                    #endregion

                    // GET FRAMES PER SECOND MAX
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"fps_max\s\x22\d{1,3}\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    _fpsRange.Value = decimal.Parse( split[1] );
                    #endregion

                    // GET THE VALUE OF WEATHER CONDITIONS
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"cl_weather\s\x22.*\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    if ( split[1] == "1" )
                        cl_weather.Checked = true;
                    if ( split[1] == "0" )
                        cl_weather.Checked = false;
                    #endregion

                    // GET THE VALUE OF DYNAMIC CROSS HAIRS
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"cl_dynamiccrosshair\s\x22[0,1]\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    if ( split[1] == "1" )
                        _dynamicCrossHairs.Checked = true;
                    if ( split[1] == "0" )
                        _dynamicCrossHairs.Checked = false;
                    #endregion

                    // GET THE VALUE OF FAST SWITCH
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"hud_fastswitch\s\x22[0,1]\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    if ( split[1] == "1" )
                        hud_fastswitch.Checked = true;
                    if ( split[1] == "0" )
                        hud_fastswitch.Checked = false;
                    #endregion

                    // GET THE VALUE OF CENTER PLAYER NAMES
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"hud_centerid\s\x22[0,1]\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    if ( split[1] == "1" )
                        hud_centerID.Checked = true;
                    if ( split[1] == "0" )
                        hud_centerID.Checked = false;
                    #endregion

                    // GET THE PLAYER NAME
                    #region DONE
                    temp = Regex.Match( _configFileContents, @"name\s\x22.+\x22" ).Value;
                    split = Regex.Split( temp, "\x22" );
                    _playerName.Text = split[1];
                    #endregion

                } catch ( Exception e ) {
                    // CATCH & DO SOMETHING LATER
                    e.ToString( );
                }
            }
            #endregion

            if ( _binFileContents != "" && contFlag ) {
                split = Regex.Split( _binFileContents, "\r\n" );
                foreach ( string s in split ) {
                    if ( Regex.Match( s, @"^bind\s\x22.*" ).Success )
                        _currentBindListBox.Items.Add( s );
                }
            }
            #endregion
        }
        /// <summary>
        /// Method used to write the buy settings to czbind.cfg
        /// </summary>
        private void WriteBinds( ) {
            #region WRITE BINDS TO CZBIND.CFG
            if ( _currentBindListBox.Items.Count >= 0 ) {
                // WRITE BINDS TO CZBIND.CFG
                #region DONE
                try {
                    if ( File.Exists( _bindFilePath ) )
                        File.Copy( _bindFilePath, _bindFilePath + ".backup", true );
                    _writer = new StreamWriter( _bindFilePath, false );
                    _writer.WriteLine( "//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n//\r\n//           CZ BIND MAKER\r\n// © 2003-11 NullFX Software / By: Steven Whitley (aka [CZ] Qw4z0)\r\n// Custom Binds For CS1.6, CS:CZ & CS:S\r\n// Last Updated On " + DateTime.Now + "\r\n//\r\n// Visit http://www.bindmaker.org \r\n//  For Updates\r\n//\r\n//~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~\r\n\r\n" );
                    for ( int i = 0; i < _currentBindListBox.Items.Count; i++ ) {
                        _writer.WriteLine( _currentBindListBox.Items[i].ToString( ) );
                    }
                    _writer.Flush( );
                    _writer.Close( );
                    _writer = null;
                } catch ( Exception e ) {
                    e.ToString( );
                    MessageBox.Show( "CZ Bind Maker Failed to write the czbind.cfg file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
                #endregion
            }
            #endregion

            #region WRITE CONFIG FILE CHANGES
            try {
                if ( _configFileContents != "" && _game != Games.CSS ) {
                    // crosshair transparency
                    #region
                    if ( _crosshairSolid != 1 & _crosshairSolid != 0 ) _crosshairSolid = 0;
                    _configFileContents = Regex.Replace( _configFileContents, @"cl_crosshair_translucent\s\x22.*\x22", "cl_crosshair_translucent \"" + _crosshairSolid.ToString( ) + "\"" );
                    #endregion

                    // crosshair color
                    #region
                    if ( !( _crosshairColor.Length > 0 ) ) _crosshairColor = "50 250 50";
                    _configFileContents = Regex.Replace( _configFileContents, @"cl_crosshair_color\s\x22.*\x22", "cl_crosshair_color \"" + _crosshairColor + "\"" );
                    #endregion

                    // crosshair size 
                    #region
                    if ( !( _crosshairSizeValue.Length > 0 ) ) _crosshairSizeValue = "auto";
                    _configFileContents = Regex.Replace( _configFileContents, @"cl_crosshair_size\s\x22.*\x22", "cl_crosshair_size \"" + _crosshairSizeValue + "\"" );
                    #endregion

                    // RATE
                    #region DONE
                    try {
                        _rate.SetValue( "Rate", _rateUpDown.Value.ToString( ) );
                        _rKey.SetValue( "Rate", _rateUpDown.Value.ToString( ) );
                    } catch ( Exception subE ) {
                        subE.ToString( );
                        MessageBox.Show( "Failed to write \"Rate\" to registry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }

                    #endregion

                    // RADAR TYPE
                    #region DONE
                    if ( cl_radartype.Checked )
                        _configFileContents = Regex.Replace( _configFileContents, @"cl_radartype\s\x22.*\x22\r\n", "cl_radartype \"1\"\r\n" );
                    if ( !cl_radartype.Checked )
                        _configFileContents = Regex.Replace( _configFileContents, @"cl_radartype\s\x22.*\x22\r\n", "cl_radartype \"0\"\r\n" );
                    #endregion

                    // AUTO WEAPON SWITCH
                    #region DONE
                    if ( _cl_autoweaponswitch.Checked )
                        _configFileContents = Regex.Replace( _configFileContents, @"_cl_autowepswitch\s\x22.*\x22\r\n", "_cl_autowepswitch \"1\"\r\n" );
                    if ( !_cl_autoweaponswitch.Checked )
                        _configFileContents = Regex.Replace( _configFileContents, @"_cl_autowepswitch\s\x22.*\x22\r\n", "_cl_autowepswitch \"0\"\r\n" );
                    #endregion

                    // RIGHT HANDED PLAYER MODEL
                    #region DONE
                    if ( cl_righthand.Checked )
                        _configFileContents = Regex.Replace( _configFileContents, @"cl_righthand\s\x22.*\x22", "cl_righthand \"1\"" );
                    if ( !cl_righthand.Checked )
                        _configFileContents = Regex.Replace( _configFileContents, @"cl_righthand\s\x22.*\x22", "cl_righthand \"0\"" );
                    #endregion

                    // VGUI
                    #region DONE
                    if ( Regex.Match( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x22.{1}\x22" ).Success ) {
                        if ( _vgui_menus.Checked )
                            _configFileContents = Regex.Replace( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x22.{1}\x22", "setinfo \"_vgui_menus\" \"1\"" );
                        if ( !_vgui_menus.Checked )
                            _configFileContents = Regex.Replace( _configFileContents, @"setinfo\s\x22_vgui_menus\x22\s\x22.{1}\x22", "setinfo \"_vgui_menus\" \"0\"" );
                    } else {
                        if ( _vgui_menus.Checked )
                            _configFileContents += "setinfo \"_vgui_menus\" \"1\"";
                        if ( !_vgui_menus.Checked )
                            _configFileContents += "setinfo \"_vgui_menus\" \"0\"";
                    }
                    #endregion

                    // RE-WRITE THE CONSOLE COLOR IN THE CONFIG FILE
                    #region DONE
                    if ( _consoleColor != null )
                        _configFileContents = Regex.Replace( _configFileContents, @"con_color\s\x22.*\x22\r\n", String.Format( "con_color \"{0}\"\r\n", _consoleColor ) );
                    //if(_consoleColor == null)
                    //	_configFileContents = Regex.Replace(_configFileContents, @"con_color\s\x22.*\x22\r\n", String.Format("con_color \"{0}\"\r\n","255 128 0"));
                    #endregion

                    // NET GRAPH
                    #region DONE
                    int netgraph = net_graph_0.Checked ? 0 : (
                        net_graph_1.Checked ? 1 : (
                        net_graph_2.Checked ? 2 : (
                        net_graph_3.Checked ? 3 : 0 ) ) );
                    _configFileContents = Regex.Replace( _configFileContents, @"net_graph\s\x22.\x22\r\n", "net_graph \"" + netgraph + "\"\r\n" );
                    #endregion

                    // NET GRAPH POSITION
                    #region DONE
                    int netgraphpos = net_grappos_1.Checked ? 1 : (
                        net_grappos_2.Checked ? 2 : (
                        net_grappos_3.Checked ? 3 : 0 ) );
                    _configFileContents = Regex.Replace( _configFileContents, @"net_graphpos\s\x22.\x22\r\n", "net_graphpos \"" + netgraphpos + "\"\r\n" );
                    #endregion

                    // FPS MAX
                    #region DONE
                    _configFileContents = Regex.Replace( _configFileContents, @"fps_max\s\x22.*\x22\r\n", "fps_max \"" + _fpsRange.Value.ToString( ) + "\"\r\n" );
                    #endregion

                    // WEATHER CONDITIONS
                    #region DONE
                    string weather = "0";
                    if ( cl_weather.Checked )
                        weather = "1";
                    _configFileContents = Regex.Replace( _configFileContents, @"cl_weather\s\x22.*\x22\r\n", "cl_weather \"" + weather + "\"\r\n" );
                    #endregion

                    // DYNAMIC CROSS HAIRS
                    #region DONE
                    string crosshairs = "0";
                    if ( _dynamicCrossHairs.Checked )
                        crosshairs = "1";
                    _configFileContents = Regex.Replace( _configFileContents, @"cl_dynamiccrosshair\s\x22.*\x22\r\n", "cl_dynamiccrosshair \"" + crosshairs + "\"\r\n" );
                    #endregion

                    // FAST SWITCH
                    #region DONE
                    string fastSwitch = "0";
                    if ( hud_fastswitch.Checked )
                        fastSwitch = "1";
                    _configFileContents = Regex.Replace( _configFileContents, @"hud_fastswitch\s\x22.*\x22\r\n", "hud_fastswitch \"" + fastSwitch + "\"\r\n" );
                    #endregion

                    // CENTER PLAYER NAMES
                    #region DONE
                    string centerName = "0";
                    if ( hud_centerID.Checked )
                        centerName = "1";
                    _configFileContents = Regex.Replace( _configFileContents, @"hud_centerid\s\x22.*\x22\r\n", "hud_centerid \"" + centerName + "\"\r\n" );
                    #endregion

                    // PLAYER NAME
                    #region DONE
                    if ( _playerName.Text != "" )
                        _configFileContents = Regex.Replace( _configFileContents, @"name\s\x22.*\x22\r\n", "name \"" + _playerName.Text + "\"\r\n" );
                    #endregion

                    // WRITE THE ABOVE CHANGES TO THE CONFIG.CFG FILE
                    #region DONE
                    _writer = new StreamWriter( _configFilePath, false );
                    _writer.Write( _configFileContents );
                    _writer.Flush( );
                    _writer.Close( );
                    _writer = null;
                    #endregion
                }
            } catch ( Exception e ) {
                e.ToString( );
                MessageBox.Show( "Could not save your configuration settings (make sure you have a valid config.cfg file)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            #endregion
        }
        /// <summary>
        /// Method Used in formatting the current bind settings list string
        /// into a fully qualified Counter-Strike 1.6 formatted key bind
        /// </summary>
        /// String from Current Bind Settings list box
        /// <param name="s">
        /// </param>
        /// <returns>
        /// Returns a fully qualified Counter-Strike 1.6 formatted key bind.
        /// </returns>
        private string FormatBind( string s ) {
            #region
            // FORMATS THE BIND INTO THE OFFICIAL
            // BIND FORMAT = bind "key" "command"
            s = s.TrimEnd( ' ' );
            string[] temp = { "" };
            string bindString = "";
            if ( Regex.Match( s, @"bind\s\x22.*\x22\s\x22.*\x22" ).Success )
                bindString = s;
            if ( s != "" && bindString != s ) {
                temp = Regex.Split( s, @"\s->\s" );
                if ( temp[1] != "" ) {
                    bindString = String.Format( "bind \"{0}\" \"{1}\"", MatchKey( temp[0] ), GetParameters(/*temp[1]*/) );
                }
            }
            return bindString;
            #endregion
        }
        /// <summary>
        /// Method used to get the fully qualified key name for each key
        /// </summary>
        /// <param name="s">String of the key inside the Current Bind Settings list box</param>
        /// <returns>The fully qualified CS1.6 key name for each key</returns>
        private static string MatchKey( string s ) {
            #region
            string key = "";
            switch ( s ) {
                case "F1 ":
                    key = s.Trim( );
                    break;
                case "F2 ":
                    key = s.Trim( );
                    break;
                case "F3 ":
                    key = s.Trim( );
                    break;
                case "F4 ":
                    key = s.Trim( );
                    break;
                case "F5 ":
                    key = s.Trim( );
                    break;
                case "F6 ":
                    key = s.Trim( );
                    break;
                case "F7 ":
                    key = s.Trim( );
                    break;
                case "F8 ":
                    key = s.Trim( );
                    break;
                case "F9 ":
                    key = s.Trim( );
                    break;
                case "F10 ":
                    key = s.Trim( );
                    break;
                case "F11 ":
                    key = s.Trim( );
                    break;
                case "F12 ":
                    key = s.Trim( );
                    break;
                case "- ":
                    key = s.Trim( );
                    break;
                case "= ":
                    key = s.Trim( );
                    break;
                case "1 ":
                    key = s.Trim( );
                    break;
                case "2 ":
                    key = s.Trim( );
                    break;
                case "3 ":
                    key = s.Trim( );
                    break;
                case "4 ":
                    key = s.Trim( );
                    break;
                case "5 ":
                    key = s.Trim( );
                    break;
                case "6 ":
                    key = s.Trim( );
                    break;
                case "7 ":
                    key = s.Trim( );
                    break;
                case "8 ":
                    key = s.Trim( );
                    break;
                case "9 ":
                    key = s.Trim( );
                    break;
                case "0 ":
                    key = s.Trim( );
                    break;
                case "Q ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "W ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "E ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "R ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "T ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "Y ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "U ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "I ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "O ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "P ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "[ ":
                    key = s.Trim( );
                    break;
                case "] ":
                    key = s.Trim( );
                    break;
                case "\\ ":
                    key = s.Trim( );
                    break;
                case "A ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "S ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "D ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "F ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "G ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "H ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "J ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "K ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "L ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "\" ":
                    key = s.Trim( );
                    break;
                case "Z ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "X ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "C ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "V ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "B ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "N ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "M ":
                    key = s.Trim( ).ToLower( );
                    break;
                case "/ ":
                    key = s.Trim( );
                    break;
                case "~ ":
                    key = "`";
                    break;
                case "< ":
                    key = ",";
                    break;
                case "> ":
                    key = ".";
                    break;
                case "* ":
                    key = "*";
                    break;
                case "; ":
                    key = "SEMICOLON";
                    break;
                case "Escape ":
                    key = "ESCAPE";
                    break;
                case "Enter ":
                    key = "ENTER";
                    break;
                case "Shift ":
                    key = "";
                    break;
                case "Caps Lock":
                    key = "CAPSLOCK";
                    break;
                case "Control ":
                    key = "CTRL";
                    break;
                case "Alt ":
                    key = "ALT";
                    break;
                case "Space ":
                    key = "SPACE";
                    break;
                case "Key Pad 1 ":
                    key = "KP_END";
                    break;
                case "Key Pad 2 ":
                    key = "KP_DOWNARROW";
                    break;
                case "Key Pad 3 ":
                    key = "KP_PGDN";
                    break;
                case "Key Pad 4 ":
                    key = "KP_LEFTARROW";
                    break;
                case "Key Pad 5 ":
                    key = "KP_5";
                    break;
                case "Key Pad 6 ":
                    key = "KP_RIGHTARROW";
                    break;
                case "Key Pad 7 ":
                    key = "KP_HOME";
                    break;
                case "Key Pad 8 ":
                    key = "KP_UPARROW";
                    break;
                case "Key Pad 9 ":
                    key = "KP_PGUP";
                    break;
                case "Key Pad 0 ":
                    key = "KP_INS";
                    break;
                case "Key Pad . ":
                    key = "KP_DEL";
                    break;
                case "Key Pad + ":
                    key = "KP_PLUS";
                    break;
                case "Key Pad - ":
                    key = "KP_MINUS";
                    break;
                case "Key Pad Enter ":
                    key = "KP_ENTER";
                    break;
                case "Key Pad / ":
                    key = "KP_SLASH";
                    break;
                case "Pause ":
                    key = "PAUSE";
                    break;
                case "Right Arrow ":
                    key = "RIGHTARROW";
                    break;
                case "Left Arrow ":
                    key = "LEFTARROW";
                    break;
                case "Down Arrow ":
                    key = "DOWNARROW";
                    break;
                case "Up Arrow ":
                    key = "UPARROW";
                    break;
                case "End ":
                    key = "END";
                    break;
                case "Delete ":
                    key = "DEL";
                    break;
                case "Page Up ":
                    key = "PGUP";
                    break;
                case "Page Down ":
                    key = "PGDN";
                    break;
                case "Home ":
                    key = "HOME";
                    break;
                case "Insert ":
                    key = "INS";
                    break;
                case "Bksp ":
                    key = "BACKSPACE";
                    break;
                case "Tab ":
                    key = "TAB";
                    break;
            }
            return key;
            #endregion
        }
        /// <summary>
        /// Returns the bind parameters in Counter-Strike 1.6 binding format
        /// </summary>
        /// <param name="s">list of buy item names as listed in the list box</param>
        /// <returns>the fully qualified buy keyword for each item.</returns>
        private string GetParameters( ) {
            string binds = "";
            if ( _bindItems.Count > 0 ) {
                foreach ( string s in _bindItems ) {
                    binds += s;
                }
            }
            return binds;
        }

        /// <summary>
        /// clears all checked items in the buy listing.  
        /// 
        /// REMEMBER IF YOU ADD ANY ITEMS TO THE LIST OF ITEMS TO BIND TO UPDATE IT HERE ALSO.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBindOptions( ) {
            #region
            if ( _pendingEdit != "" ) {
                _currentBindListBox.Items.Add( _pendingEdit );
                _pendingEdit = "";
                HandleDeselectKey( null, null );
            }
            _bindOptionsListBox.Items.Clear( );
            foreach ( string s in _bindMap.BuyKeys ) {
                _bindOptionsListBox.Items.Add( s );
            }
            radioCommandsToolStripComboBox.SelectedIndex = -1;
            sayTeamSayTextBox.Text = "";
            _bindItems.Clear( );
            sayTeamSayComboBox.SelectedIndex = 0;
            #endregion
        }

        private static string[] GetColorFromString( string buffer ) {
            string red = "";
            string blue = "";
            string green = "";
            int offset = 0;
            for ( int i = 0; i < buffer.Length; i++ ) {
                if ( Char.IsNumber( buffer[i] ) ) {
                    switch ( offset ) {
                        case 0:
                            red += buffer[i];
                            break;
                        case 1:
                            blue += buffer[i];
                            break;
                        case 2:
                            green += buffer[i];
                            break;
                    }
                } else {
                    offset++;
                }
            }
            if ( red.Length > 0 && blue.Length > 0 && green.Length > 0 ) {
                return new string[3] { red, blue, green };
            } else {
                return new string[3] { "250", "180", "0" };
            }
        }

        /// <summary>
        /// The Property which contains the string value of button which has been selected 
        /// on the keyboard layout.
        /// </summary>
        private string ButtonPressed {
            #region
            get {
                return esc.Checked ? "ESCAPE" : (
                    f1.Checked ? "F1" : (
                    f2.Checked ? "F2" : (
                    f3.Checked ? "F3" : (
                    f4.Checked ? "F4" : (
                    f5.Checked ? "F5" : (
                    f6.Checked ? "F6" : (
                    f7.Checked ? "F7" : (
                    f8.Checked ? "F8" : (
                    f9.Checked ? "F9" : (
                    f10.Checked ? "F10" : (
                    f11.Checked ? "F11" : (
                    f12.Checked ? "F12" : (
                    tilda.Checked ? "`" : (
                    one.Checked ? "1" : (
                    two.Checked ? "2" : (
                    three.Checked ? "3" : (
                    four.Checked ? "4" : (
                    five.Checked ? "5" : (
                    six.Checked ? "6" : (
                    seven.Checked ? "7" : (
                    eight.Checked ? "8" : (
                    nine.Checked ? "9" : (
                    zero.Checked ? "0" : (
                    dash.Checked ? "-" : (
                    equals.Checked ? "=" : (
                    backspace.Checked ? "BACKSPACE" : (
                    tab.Checked ? "TAB" : (
                    qkey.Checked ? "q" : (
                    wkey.Checked ? "w" : (
                    ekey.Checked ? "e" : (
                    rkey.Checked ? "r" : (
                    tkey.Checked ? "t" : (
                    ykey.Checked ? "y" : (
                    ukey.Checked ? "u" : (
                    ikey.Checked ? "i" : (
                    okey.Checked ? "o" : (
                    pkey.Checked ? "p" : (
                    open_square_brace_key.Checked ? "[" : (
                    closed_square_brace_key.Checked ? "]" : (
                    backslash.Checked ? @"\" : (
                    caps.Checked ? "CAPSLOCK" : (
                    akey.Checked ? "a" : (
                    skey.Checked ? "s" : (
                    dkey.Checked ? "d" : (
                    fkey.Checked ? "f" : (
                    gkey.Checked ? "g" : (
                    hkey.Checked ? "h" : (
                    jkey.Checked ? "j" : (
                    kkey.Checked ? "k" : (
                    lkey.Checked ? "l" : (
                    semicol.Checked ? ";" : (
                    quotes.Checked ? "'" : (
                    enter.Checked ? "ENTER" : (
                    lshift.Checked ? "SHIFT" : (
                    zkey.Checked ? "z" : (
                    xkey.Checked ? "x" : (
                    ckey.Checked ? "c" : (
                    vkey.Checked ? "v" : (
                    bkey.Checked ? "b" : (
                    nkey.Checked ? "n" : (
                    mkey.Checked ? "m" : (
                    open_tag.Checked ? "," : (
                    closed_tag.Checked ? "." : (
                    forwardslash.Checked ? "/" : (
                    rshift.Checked ? "SHIFT" : (
                    lctrl.Checked ? "CTRL" : (
                    lalt.Checked ? "ALT" : (
                    space.Checked ? "SPACE" : (
                    ralt.Checked ? "ALT" : (
                    rctrl.Checked ? "CTRL" : (
                    kp_0.Checked ? "KP_INS" : (
                    kp_dot.Checked ? "KP_DEL" : (
                    kp_rtn.Checked ? "KP_ENTER" : (
                    kp_3.Checked ? "KP_PGDN" : (
                    kp_2.Checked ? "KP_DOWNARROW" : (
                    kp_1.Checked ? "KP_END" : (
                    kp_6.Checked ? "KP_RIGHTARROW" : (
                    kp_5.Checked ? "KP_5" : (
                    kp_4.Checked ? "KP_LEFTARROW" : (
                    kp_plus.Checked ? "KP_PLUS" : (
                    kp_9.Checked ? "KP_PGUP" : (
                    kp_8.Checked ? "KP_UPARROW" : (
                    kp_7.Checked ? "KP_HOME" : (
                    kp_dash.Checked ? "KP_MINUS" : (
                    astrisk.Checked ? "*" : (
                    kp_forwardslash.Checked ? "KP_SLASH" : (
                    pause.Checked ? "PAUSE" : (
                    rightarrow.Checked ? "RIGHTARROW" : (
                    leftarrow.Checked ? "LEFTARROW" : (
                    downarrow.Checked ? "DOWNARROW" : (
                    uparrow.Checked ? "UPARROW" : (
                    pagedown.Checked ? "PGDN" : (
                    end.Checked ? "END" : (
                    del.Checked ? "DEL" : (
                    pageup.Checked ? "PGUP" : (
                    home.Checked ? "HOME" : (
                    ins.Checked ? "INS" : ""
                    ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) )
                    ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) ) )
                    ) ) ) ) ) ) ) ) ) ) ) ) ) ) );
            }
            #endregion
        }

        /// <summary>
        /// Contains the concatinated buy items which were selected
        /// </summary>
        private string BindParameters {
            #region
            get {
                string temp = "";

                for ( int i = 0; i < _bindOptionsListBox.CheckedItems.Count; i++ ) {
                    temp += _bindOptionsListBox.CheckedItems[i].ToString( );
                    if ( _bindOptionsListBox.CheckedItems.Count > 1 && i + 1 < _bindOptionsListBox.CheckedItems.Count )
                        temp += " + ";
                }

                // ADD SAY/TEAM SAY TEXT TO THE BIND LIST
                if ( sayTeamSayTextBox.Text.Trim( ) != "" ) {
                    string say = sayTeamSayComboBox.SelectedItem.ToString( ) == "Say" ? "Say: \"" : "Team Say: \"";
                    temp += " + " + say + sayTeamSayTextBox.Text + "\";";
                }
                // ADD RADIO COMMANDS TO THE BIND LIST
                if ( radioCommandsToolStripComboBox.SelectedIndex != -1 ) {
                    temp += " + Radio Command: " + radioCommandsToolStripComboBox.SelectedItem.ToString( ) + ";";
                }


                return temp + "    ";
            }
            #endregion
        }

        /// <summary>
        /// Exit the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleExitApplication( object sender, System.EventArgs e ) {
            #region
            Application.Exit( );
            #endregion
        }

        /// <summary>
        /// Event for clearing the template text on the custom bind text box when 
        /// the cursor is placed inside it.
        /// </summary>
        /// <param name="sender">sending object</param>
        /// <param name="e">event arguments</param>
        /// 
        private void CustomBind_Enter( object sender, System.EventArgs e ) {
            #region
            esc.Checked = true;
            esc.Checked = false;
            ClearBindOptions( );
            if ( _customBind.Text == "bind \"key\" \"command\"" )
                _customBind.Text = "";
            #endregion
        }

        /// <summary>
        /// Event for placing the template text back inside custom bind text box when 
        /// the cusor leaves the box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomBind_Leave( object sender, System.EventArgs e ) {
            #region
            if ( _customBind.Text == "" ) {
                _customBind.Text = "bind \"key\" \"command\"";
            }
            #endregion
        }

        /// <summary>
        /// When the choose console color button is pressed this method sets the 
        /// new console text color.
        /// </summary>
        /// <param name="sender">The object which triggered the event</param>
        /// <param name="e">The Event arguments</param>
        private void Consolecolor_Click( object sender, System.EventArgs e ) {
            #region
            if ( _consoleColor == null || _consoleColor.Length <= 0 ) {
                _consoleColor = _consoleColorSample.ForeColor.R.ToString( ) + " " +
                    _consoleColorSample.ForeColor.G.ToString( ) + " " +
                    _consoleColorSample.ForeColor.B.ToString( ) + " ";

            }
            string[] colors = _consoleColor.Split( ' ' );
            int r = Convert.ToInt32( colors[0] );
            int g = Convert.ToInt32( colors[1] );
            int b = Convert.ToInt32( colors[2] );
            _consoleColorPicker.Color = Color.FromArgb( r, g, b );
            if ( _consoleColorPicker.ShowDialog( this ) == DialogResult.OK ) {
                _consoleColor = string.Format( CultureInfo.InvariantCulture, "{0} {1} {2}", _consoleColorPicker.Color.R, _consoleColorPicker.Color.G, _consoleColorPicker.Color.B );
                _consoleColorSample.ForeColor = _consoleColorPicker.Color;
            }
            #endregion
        }

        private void HandleOpenConfigCfgInNotepad( object sender, System.EventArgs e ) {
            if ( _configFilePath != "" )
                if ( File.Exists( _configFilePath ) )
                    Process.Start( "notepad.exe", _configFilePath );
        }

        private void HandleOpenAutoexecCfgInNotepad( object sender, System.EventArgs e ) {
            if ( _configFilePath != "" ) {
                string autoexec = Regex.Replace( _configFilePath, "config.cfg", "autoexec.cfg" );
                if ( File.Exists( autoexec ) )
                    Process.Start( "notepad.exe", autoexec );
            }
        }

        private void HandleOpenUserconfigCfgInNotepad( object sender, System.EventArgs e ) {
            if ( _userFilePath != "" )
                if ( File.Exists( _userFilePath ) )
                    Process.Start( "notepad.exe", _userFilePath );
        }

        private void HandleOpenCzbindCfgInNotepad( object sender, System.EventArgs e ) {
            if ( _bindFilePath != "" )
                if ( File.Exists( _bindFilePath ) )
                    Process.Start( "notepad.exe", _bindFilePath );
        }

        private void gs_SelectGame( string selection ) {
            _option = selection;
        }

        private void HandleClearSelectedRadioCommand( object sender, System.EventArgs e ) {
            radioCommandsToolStripComboBox.SelectedIndex = -1;
            //radioCommandsToolStripComboBox.Invalidate();
            string oldCommand = "";
            if ( _oldRadioCommand != "" && _bindItems.Contains( oldCommand = _bindMap[BindType.Radio, _oldRadioCommand].ToString( ) ) ) {
                _bindItems.Remove( oldCommand );
                _oldRadioCommand = "";
            }
        }

        private void BindOptions_ListBox_MouseEnter( object sender, System.EventArgs e ) {
            if ( ( sayTeamSayTextBox.Focused && sayTeamSayTextBox.Text == "" ) | !sayTeamSayTextBox.Focused ) {
                _bindOptionsListBox.Focus( );
            }
        }

        private void CurrentBind_ListBox_MouseEnter( object sender, System.EventArgs e ) {
            _currentBindListBox.Focus( );
        }

        private void BindOptions_ListBox_ItemCheck( object sender, System.Windows.Forms.ItemCheckEventArgs e ) {
            object item = _bindMap.GetValue( ( (CheckedListBox)sender ).Items[e.Index].ToString( ) );
            if ( e.CurrentValue == CheckState.Unchecked ) {
                bool singleClip = ( item.ToString( ) == "buyammo1;" || item.ToString( ) == "buyammo2;" );
                string tempCommand = "";
                if ( singleClip ) {
                    AmmoClips ac = new AmmoClips( );
                    int numberOfClips = ac.ShowOption( this, new Point( MousePosition.X + 10, MousePosition.Y + Font.Height ) );
                    if ( numberOfClips < 1 ) {
                        e.NewValue = CheckState.Unchecked;
                        return;
                    }
                    for ( int i = 0; i < numberOfClips; i++ ) {
                        tempCommand += item.ToString( );
                    }
                    string aliasName = item.ToString( ).Replace( ";", "" ) + "_" + numberOfClips;
                    item = aliasName + ";";
                }
                if ( !_bindItems.Contains( item ) ) {
                    _bindItems.Add( item );
                } else {
                    if ( singleClip ) {
                        _bindItems.Remove( tempCommand );
                        _bindItems.Add( tempCommand );
                    } else {
                        if ( singleClip ) {
                            foreach ( string s in _bindItems ) {
                                if ( s.StartsWith( item.ToString( ) ) ) {
                                    _bindItems.Remove( s );
                                    goto add;
                                }
                            }
                        }
                        _bindItems.Remove( item );
                        add:
                        _bindItems.Add( item );
                    }
                }
            } else {//if(Regex.IsMatch(_bindItems[i].ToString(), string.Format(".*{0}.*", item.ToString()))/*_bindItems.Contains(item)*/) {
                string t = item.ToString( ).Replace( ";", "" );
                for ( int i = 0; i < _bindItems.Count; i++ ) {
                    if ( Regex.IsMatch( _bindItems[i].ToString( ), string.Format( ".*{0}.*", t ) ) ) {
                        _bindItems.RemoveAt( i );
                    }
                }
                _bindItems.Remove( t );
            }
        }

        private void DisableSayText( ) {
            bool a = sayTeamSayTextBox.Text != "";
            bool b = sayTeamSayTextBox.Enabled;
            sayTeamSayTextBox.Enabled = false;
            sayTeamSayComboBox.Enabled = false;
            _enableSayItem.Invalidate( );
            if ( a && b ) {
                string output = sayTeamSayTextBox.Text.Replace( "\"", "" ).Trim( );
                string sayText = String.Format( "{0} {1};", _bindMap[BindType.Say, sayTeamSayComboBox.SelectedItem.ToString( )].ToString( ).Trim( ), output );
                _bindItems.Add( sayText );
            }
        }

        private void EnableSayText( ) {
            string sayText = String.Format( "{0} {1};", _bindMap[BindType.Say, sayTeamSayComboBox.SelectedItem.ToString( )], sayTeamSayTextBox.Text );
            _bindItems.Remove( sayText );
            sayTeamSayTextBox.Enabled = true;
            sayTeamSayComboBox.Enabled = true;
            _enableSayItem.Invalidate( );
            //sayTeamSayTextBox.Text = "";
        }

        private void HandleRadioCommandSelectionChanged( object sender, EventArgs e ) {
            if ( sender is ToolStripComboBox ) {
                if ( ( (ToolStripComboBox)sender ).SelectedIndex != -1 ) {
                    string oldCommand = "";
                    if ( _oldRadioCommand != "" && _bindItems.Contains( oldCommand = _bindMap[BindType.Radio, _oldRadioCommand].ToString( ) ) ) {
                        _bindItems.Remove( oldCommand );
                    }
                    _oldRadioCommand = ( (ToolStripComboBox)sender ).SelectedItem.ToString( );
                    string commandText = _bindMap[BindType.Radio, _oldRadioCommand].ToString( );
                    _bindItems.Add( commandText );
                }
            }
        }

        private void HandleUpdateOrderedBindsList( ArrayList list ) {
            _bindItems = list;
        }

        private void TempEditSolution( ) {
            int index = _currentBindListBox.SelectedIndex;
            if ( index > -1 ) {
                string script = _currentBindListBox.Items[index].ToString( );
                _pendingEdit = script;
                _currentBindListBox.Items.Remove( script );

                TempBindItemEditor temp = new TempBindItemEditor( script );
                temp.UpdateParent += new CZBindMaker.TempBindItemEditor.UpdateBindHandler( temp_UpdateParent );
                if ( temp.ShowDialog( this ) != DialogResult.OK ) {
                    _currentBindListBox.Items.Add( _pendingEdit );
                    _pendingEdit = "";
                } else {
                    _pendingEdit = "";
                }
                temp.Close( );
            }
        }

        private void EditBinds( ) {
            // make sure something is selected
            int index = _currentBindListBox.SelectedIndex;
            // validate that we've selected something
            if ( index > -1 ) {
                undoStripButton.Enabled = true;
                undoToolStripMenuItem.Enabled = true;
                ClearBindOptions( );
                string script = _currentBindListBox.Items[index].ToString( );
                _pendingEdit = script;
                // make sure we dont have an empty string
                if ( script.Length > 0 ) {
                    bool isBind = ( script.Substring( 0, 4 ).ToLower( ) == "bind" );
                    if ( isBind ) {
                        _currentBindListBox.Items.Remove( script );
                        script = Regex.Replace( script, @"(\s+)", " " );
                        script = Regex.Replace( script, @";(\s+)", ";" );
                        script = script.Replace( "\"", "" );
                        string[] keyBuffer = script.Split( ' ' );
                        string key = keyBuffer[1];
                        int lengthToParts = key.Length + 5;
                        string cmds = script.Substring( lengthToParts, script.Length - lengthToParts ).Trim( );
                        ArrayList cmdList = _bindMap.GetCommandsList( cmds );
                        int n = 0;
                        foreach ( Command c in cmdList ) {
                            switch ( c.CmdType ) {
                                case CommandType.Buy:
                                    string commandKey = _bindMap.GetKey( c.CommandText ).ToString( );
                                    if ( _bindOptionsListBox.Items.Contains( commandKey ) ) {
                                        n = _bindOptionsListBox.Items.IndexOf( commandKey );
                                        _bindOptionsListBox.SetItemChecked( n, true );
                                    } else goto case CommandType.Unimplemented;
                                    break;
                                case CommandType.Radio:
                                    n = radioCommandsToolStripComboBox.Items.IndexOf( _bindMap.GetKey( c.CommandText ) );
                                    radioCommandsToolStripComboBox.SelectedIndex = n;
                                    HandleRadioCommandSelectionChanged( radioCommandsToolStripComboBox, new EventArgs( ) );
                                    break;
                                case CommandType.Say:
                                    sayTeamSayComboBox.SelectedIndex = 1;
                                    sayTeamSayTextBox.Text = c.CommandText;
                                    HandleSayTeamSayCommandAdd( null, null );
                                    sayTeamSayTextBox.Enabled = false;
                                    sayTeamSayComboBox.Enabled = false;
                                    break;
                                case CommandType.TeamSay:
                                    sayTeamSayComboBox.SelectedIndex = 2;
                                    sayTeamSayTextBox.Text = c.CommandText;
                                    HandleSayTeamSayCommandAdd( null, null );
                                    sayTeamSayTextBox.Enabled = false;
                                    sayTeamSayComboBox.Enabled = false;
                                    break;
                                case CommandType.Unimplemented:
                                    _bindOptionsListBox.Items.Add( c.CommandText );
                                    int ndex = _bindOptionsListBox.Items.IndexOf( c.CommandText );
                                    _bindOptionsListBox.SetItemChecked( ndex, true );
                                    break;
                            }
                        }
                        DepressButtonBasedOnScriptValue( key );
                        addBindToolBarButton.Text = "&Commit Edit";
                        _mainTabControl.SelectedIndex = 0;
                    } else {
                        undoToolStripMenuItem.Enabled = false;
                        undoStripButton.Enabled = false;
                        TempEditSolution( );
                    }
                }
            }
        }

        private void HandleTabPageSwitch( object sender, EventArgs e ) {
            if ( _game == Games.CSS && _mainTabControl.SelectedIndex == 1 ) {
                config_tabPage.Invalidate( );
            }
            if ( _mainTabControl.SelectedIndex == 0 ) {
                _showOrder.Visible = true;
                //_mainTabControl.Size		= new Size(392, 300);
                _mainTabControl.Location = new Point( 4, 33 );
            } else {
                _showOrder.Visible = false;
                //_mainTabControl.Size		= new Size(392, 332);
                _mainTabControl.Location = new Point( 4, 0 );
            }
        }

        private bool DepressButtonBasedOnScriptValue( string bindKeyText ) {
            bool keyfound = false;
            switch ( bindKeyText ) {
                #region key mapping
                case "INS":
                    ins.Checked = true;
                    keyfound = true;
                    break;
                case "ESCAPE":
                    esc.Checked = true;
                    keyfound = true;
                    break;
                case "F1":
                    f1.Checked = true;
                    keyfound = true;
                    break;
                case "F2":
                    f2.Checked = true;
                    keyfound = true;
                    break;
                case "F3":
                    f3.Checked = true;
                    keyfound = true;
                    break;
                case "F4":
                    f4.Checked = true;
                    keyfound = true;
                    break;
                case "F5":
                    f5.Checked = true;
                    keyfound = true;
                    break;
                case "F6":
                    f6.Checked = true;
                    keyfound = true;
                    break;
                case "F7":
                    f7.Checked = true;
                    keyfound = true;
                    break;
                case "F8":
                    f8.Checked = true;
                    keyfound = true;
                    break;
                case "F9":
                    f9.Checked = true;
                    keyfound = true;
                    break;
                case "F10":
                    f10.Checked = true;
                    keyfound = true;
                    break;
                case "F11":
                    f11.Checked = true;
                    keyfound = true;
                    break;
                case "F12":
                    f12.Checked = true;
                    keyfound = true;
                    break;
                case "`":
                    tilda.Checked = true;
                    keyfound = true;
                    break;
                case "1":
                    one.Checked = true;
                    keyfound = true;
                    break;
                case "2":
                    two.Checked = true;
                    keyfound = true;
                    break;
                case "3":
                    three.Checked = true;
                    keyfound = true;
                    break;
                case "4":
                    four.Checked = true;
                    keyfound = true;
                    break;
                case "5":
                    five.Checked = true;
                    keyfound = true;
                    break;
                case "6":
                    six.Checked = true;
                    keyfound = true;
                    break;
                case "7":
                    seven.Checked = true;
                    keyfound = true;
                    break;
                case "8":
                    eight.Checked = true;
                    keyfound = true;
                    break;
                case "9":
                    nine.Checked = true;
                    keyfound = true;
                    break;
                case "0":
                    zero.Checked = true;
                    keyfound = true;
                    break;
                case "-":
                    dash.Checked = true;
                    keyfound = true;
                    break;
                case "=":
                    equals.Checked = true;
                    keyfound = true;
                    break;
                case "BACKSPACE":
                    backspace.Checked = true;
                    keyfound = true;
                    break;
                case "TAB":
                    tab.Checked = true;
                    keyfound = true;
                    break;
                case "q":
                    qkey.Checked = true;
                    keyfound = true;
                    break;
                case "w":
                    wkey.Checked = true;
                    keyfound = true;
                    break;
                case "e":
                    ekey.Checked = true;
                    keyfound = true;
                    break;
                case "r":
                    rkey.Checked = true;
                    keyfound = true;
                    break;
                case "t":
                    tkey.Checked = true;
                    keyfound = true;
                    break;
                case "y":
                    ykey.Checked = true;
                    keyfound = true;
                    break;
                case "u":
                    ukey.Checked = true;
                    keyfound = true;
                    break;
                case "i":
                    ikey.Checked = true;
                    keyfound = true;
                    break;
                case "o":
                    okey.Checked = true;
                    keyfound = true;
                    break;
                case "p":
                    pkey.Checked = true;
                    keyfound = true;
                    break;
                case "[":
                    open_square_brace_key.Checked = true;
                    keyfound = true;
                    break;
                case "]":
                    closed_square_brace_key.Checked = true;
                    keyfound = true;
                    break;
                case @"\":
                    backslash.Checked = true;
                    keyfound = true;
                    break;
                case "CAPSLOCK":
                    caps.Checked = true;
                    keyfound = true;
                    break;
                case "a":
                    akey.Checked = true;
                    keyfound = true;
                    break;
                case "s":
                    skey.Checked = true;
                    keyfound = true;
                    break;
                case "d":
                    dkey.Checked = true;
                    keyfound = true;
                    break;
                case "f":
                    fkey.Checked = true;
                    keyfound = true;
                    break;
                case "g":
                    gkey.Checked = true;
                    keyfound = true;
                    break;
                case "h":
                    hkey.Checked = true;
                    keyfound = true;
                    break;
                case "j":
                    jkey.Checked = true;
                    keyfound = true;
                    break;
                case "k":
                    kkey.Checked = true;
                    keyfound = true;
                    break;
                case "l":
                    lkey.Checked = true;
                    keyfound = true;
                    break;
                case ";":
                    semicol.Checked = true;
                    keyfound = true;
                    break;
                case "'":
                    quotes.Checked = true;
                    keyfound = true;
                    break;
                case "ENTER":
                    enter.Checked = true;
                    keyfound = true;
                    break;
                case "SHIFT":
                    lshift.Checked = true;
                    keyfound = true;
                    break;
                case "z":
                    zkey.Checked = true;
                    keyfound = true;
                    break;
                case "x":
                    xkey.Checked = true;
                    keyfound = true;
                    break;
                case "c":
                    ckey.Checked = true;
                    keyfound = true;
                    break;
                case "v":
                    vkey.Checked = true;
                    keyfound = true;
                    break;
                case "b":
                    bkey.Checked = true;
                    keyfound = true;
                    break;
                case "n":
                    nkey.Checked = true;
                    keyfound = true;
                    break;
                case "m":
                    mkey.Checked = true;
                    keyfound = true;
                    break;
                case ",":
                    open_tag.Checked = true;
                    keyfound = true;
                    break;
                case ".":
                    closed_tag.Checked = true;
                    keyfound = true;
                    break;
                case "/":
                    forwardslash.Checked = true;
                    keyfound = true;
                    break;
                case "CTRL":
                    lctrl.Checked = true;
                    keyfound = true;
                    break;
                case "ALT":
                    lalt.Checked = true;
                    keyfound = true;
                    break;
                case "SPACE":
                    space.Checked = true;
                    keyfound = true;
                    break;
                case "KP_INS":
                    kp_0.Checked = true;
                    keyfound = true;
                    break;
                case "KP_DEL":
                    kp_dot.Checked = true;
                    keyfound = true;
                    break;
                case "KP_ENTER":
                    kp_rtn.Checked = true;
                    keyfound = true;
                    break;
                case "KP_PGDN":
                    kp_3.Checked = true;
                    keyfound = true;
                    break;
                case "KP_DOWNARROW":
                    kp_2.Checked = true;
                    keyfound = true;
                    break;
                case "KP_END":
                    kp_1.Checked = true;
                    keyfound = true;
                    break;
                case "KP_RIGHTARROW":
                    kp_6.Checked = true;
                    keyfound = true;
                    break;
                case "KP_5":
                    kp_5.Checked = true;
                    keyfound = true;
                    break;
                case "KP_LEFTARROW":
                    kp_4.Checked = true;
                    keyfound = true;
                    break;
                case "KP_PLUS":
                    kp_plus.Checked = true;
                    keyfound = true;
                    break;
                case "KP_PGUP":
                    kp_9.Checked = true;
                    keyfound = true;
                    break;
                case "KP_UPARROW":
                    kp_8.Checked = true;
                    keyfound = true;
                    break;
                case "KP_HOME":
                    kp_7.Checked = true;
                    keyfound = true;
                    break;
                case "KP_MINUS":
                    kp_dash.Checked = true;
                    keyfound = true;
                    break;
                case "*":
                    astrisk.Checked = true;
                    keyfound = true;
                    break;
                case "KP_SLASH":
                    kp_forwardslash.Checked = true;
                    keyfound = true;
                    break;
                case "PAUSE":
                    pause.Checked = true;
                    keyfound = true;
                    break;
                case "RIGHTARROW":
                    rightarrow.Checked = true;
                    keyfound = true;
                    break;
                case "LEFTARROW":
                    leftarrow.Checked = true;
                    keyfound = true;
                    break;
                case "DOWNARROW":
                    downarrow.Checked = true;
                    keyfound = true;
                    break;
                case "UPARROW":
                    uparrow.Checked = true;
                    keyfound = true;
                    break;
                case "PGDN":
                    pagedown.Checked = true;
                    keyfound = true;
                    break;
                case "END":
                    end.Checked = true;
                    keyfound = true;
                    break;
                case "DEL":
                    del.Checked = true;
                    keyfound = true;
                    break;
                case "PGUP":
                    pageup.Checked = true;
                    keyfound = true;
                    break;
                case "HOME":
                    home.Checked = true;
                    keyfound = true;
                    break;
                default:
                    keyfound = false;
                    break;
                #endregion
            }
            return keyfound;
        }

        private void temp_UpdateParent( string bind ) {
            if ( bind.Length > 0 ) {
                _currentBindListBox.Items.Add( bind );
            }
        }

        private void HandleSayTeamSayCommandAdd( object sender, EventArgs e ) {
            _enableSayItem.Checked = !_enableSayItem.Checked;
            if ( _enableSayItem.CheckState == CheckState.Unchecked ) {
                int idx = GetSayTeamSayCommandIndex( );
                if ( idx == -1 ) throw new InvalidOperationException( "ERROR" );
                _sayIndexOfRemoved = idx;
                _bindItems.RemoveAt( idx );
                EnableSayText( );
            } else {
                if ( sayTeamSayTextBox.Text == "" ) {
                    MessageBox.Show( this, "You must enter text into the textbox before a \"Say\" or \"Team Say\" item can be bound\t", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    _enableSayItem.CheckState = CheckState.Unchecked;
                    return;
                }
                if ( _sayIndexOfRemoved > -1 ) {
                    int n = sayTeamSayComboBox.SelectedIndex;
                    string sayItem = null;
                    if ( n == 1 ) sayItem = "say";
                    if ( n == 2 ) sayItem = "say_team";
                    if ( string.IsNullOrEmpty( sayItem ) ) throw new InvalidOperationException( "ERROR" );
                    string sayText = String.Format( "{0} {1};", sayItem, sayTeamSayTextBox.Text );
                    _bindItems.Add( sayText );
                    _sayIndexOfRemoved = -1;
                    sayTeamSayTextBox.Enabled = false;
                    sayTeamSayComboBox.Enabled = false;
                }
                DisableSayText( );
            }
        }

        private int GetSayTeamSayCommandIndex( ) {
            int idx = -1;
            foreach ( string s in _bindItems ) {
                if ( s.StartsWith( "say " ) || s.StartsWith( "say_team " ) ) {
                    idx = _bindItems.IndexOf( s );
                    break;
                }
            }
            return idx;
        }

        private void HandleCustomBindKeyPress( object sender, KeyEventArgs e ) {
            if ( e.KeyCode == Keys.Enter | e.KeyCode == Keys.Return ) {
                HandleAddEditBind( addBindToolBarButton, new EventArgs( ) );
            }
        }

        private void HandleBindItemsKeyPress( object sender, KeyPressEventArgs e ) {
            e.Handled = true;
        }

        private void HandleBindItemsKeyDown( object sender, KeyEventArgs e ) {
            e.Handled = true;
        }

        private void HandleBindItemsKeyUp( object sender, KeyEventArgs e ) {
            e.Handled = true;
        }

        private void HandleEditCrosshairColor( object sender, EventArgs e ) {
            Color c = _crosshairSampleImage.BackColor;
            if ( !_solidCrosshair.Checked ) {
                c = Color.FromArgb( 75, Convert.ToInt32( c.R ), Convert.ToInt32( c.G ), Convert.ToInt32( c.B ) );
            } else {
                c = Color.FromArgb( 255, Convert.ToInt32( c.R ), Convert.ToInt32( c.G ), Convert.ToInt32( c.B ) );
            }
            _consoleColorPicker.Color = c;
            _consoleColorPicker.ShowDialog( this );
            Color d = _consoleColorPicker.Color;
            if ( !_solidCrosshair.Checked ) {
                d = Color.FromArgb( 75, Convert.ToInt32( d.R ), Convert.ToInt32( d.G ), Convert.ToInt32( d.B ) );
            } else {
                d = Color.FromArgb( 255, Convert.ToInt32( d.R ), Convert.ToInt32( d.G ), Convert.ToInt32( d.B ) );
            }
            _crosshairSampleImage.BackColor = d;
            _crosshairColor = String.Format( CultureInfo.InvariantCulture, "{0} {1} {2}", _crosshairSampleImage.BackColor.R, _crosshairSampleImage.BackColor.G, _crosshairSampleImage.BackColor.B );
        }

        private void HandleCrosshairSizeChange( object sender, EventArgs e ) {
            string s = ( (ComboBox)sender ).Text.ToLower( );
            switch ( s ) {
                case "auto-size":
                    _crosshairSizeValue = "auto";
                    break;
                case "small":
                    _crosshairSampleImage.Image = _crosshairs.Images[0];
                    _crosshairSizeValue = s;
                    break;
                case "medium":
                    _crosshairSampleImage.Image = _crosshairs.Images[1];
                    _crosshairSizeValue = s;
                    break;
                case "large":
                    _crosshairSampleImage.Image = _crosshairs.Images[2];
                    _crosshairSizeValue = s;
                    break;
            }
        }

        private void HandleSolidCrosshairsChange( object sender, EventArgs e ) {
            Color d = _crosshairSampleImage.BackColor;
            if ( !_solidCrosshair.Checked ) {
                d = Color.FromArgb( 75, Convert.ToInt32( d.R ), Convert.ToInt32( d.G ), Convert.ToInt32( d.B ) );
                _crosshairSolid = 1;
            } else {
                d = Color.FromArgb( 255, Convert.ToInt32( d.R ), Convert.ToInt32( d.G ), Convert.ToInt32( d.B ) );
                _crosshairSolid = 0;
            }
            _crosshairSampleImage.BackColor = d;
        }
        
        private void DisableConfigForSource( ) {
            foreach ( Control c in config_tabPage.Controls ) {
                c.Visible = false;
            }
            if ( _mainTabControl.SelectedIndex == 0 ) {
                _showOrder.Visible = true;
                //_mainTabControl.Size		= new Size(392, 300);
                _mainTabControl.Location = new Point( 0, 33 );
            } else {
                _showOrder.Visible = false;
                //_mainTabControl.Size		= new Size(392, 332);
                _mainTabControl.Location = new Point( 0, 0 );
            }
            config_tabPage.Invalidate( );
        }

        private void EnableConfig( ) {

            foreach ( Control c in config_tabPage.Controls ) {
                c.Visible = true;
            }
            if ( _mainTabControl.SelectedIndex == 0 ) {
                _showOrder.Visible = true;
                //_mainTabControl.Size		= new Size(392, 300);
                _mainTabControl.Location = new Point( 0, 33 );
            } else {
                _showOrder.Visible = false;
                //_mainTabControl.Size		= new Size(392, 332);
                _mainTabControl.Location = new Point( 0, 0 );
            }
            config_tabPage.Invalidate( );
        }

        private void HandleDrawOnTabPage( object sender, PaintEventArgs e ) {
            if ( _game == Games.CSS ) {
                Size panel = config_tabPage.Size;
                int xmid = panel.Width / 2;
                int ymid = panel.Height / 2;
                string message =
@"Configuration settings have been disabled for 
Counter-Strike: Source.  I don't play CS 
much anymore so I haven't updated the app
in a while.  Maybe if I get bored in the future
I'll update this to support source.

--
Steve ""[CZ] Qw4z0"" Whitley";

                StringFormat format = new StringFormat( );
                format.Alignment = StringAlignment.Near;
                Font f = new Font( Font.Name, 10 );
                SizeF strSize = e.Graphics.MeasureString( message, f );
                int xLoc = xmid - (int)Math.Round( ( strSize.Width / 2 ), 0 );
                int yLoc = ymid - (int)Math.Round( ( strSize.Height / 2 ), 0 );
                e.Graphics.DrawString( message, f, SystemBrushes.ControlText, xLoc, yLoc, format );
            }
        }

        private void HandleSayTeamSayEnabled( object sender, EventArgs e ) {
            sayTeamSayTextBox.Enabled = sayTeamSayComboBox.SelectedIndex > 0;
        }

        private void HandleShowAbout( object sender, EventArgs e ) {
            using ( About a = new About( ) ) {
                a.ShowDialog( this );
            }
        }

        private void HandleViewWebsite( object sender, EventArgs e ) {
            Process.Start( "http://www.bindmaker.org" );
        }

        private void HandleSubmitFeedback( object sender, EventArgs e ) {
            using ( Feedback f = new Feedback( _account ) ) {
                f.ShowDialog( this );
            }
        }

        private void HandleViewDocumentation( object sender, EventArgs e ) {
            using ( Docs d = new Docs( ) ) {
                d.ShowDialog( this );
            }
        }

        private void HandleExportCompressedFiles( object sender, EventArgs e ) {
            ArrayList list = new ArrayList( );
            if ( File.Exists( _autoFilePath ) ) list.Add( _autoFilePath );
            if ( File.Exists( _configFilePath ) ) list.Add( _configFilePath );
            if ( File.Exists( _bindFilePath ) ) list.Add( _bindFilePath );
            if ( File.Exists( _userFilePath ) ) list.Add( _userFilePath );
            ExportDialog ed = new ExportDialog( list, true );
            ed.ShowDialog( this );
        }

        private void HandleExportAllFiles( object sender, EventArgs e ) {
            ArrayList list = new ArrayList( );
            if ( File.Exists( _autoFilePath ) ) list.Add( _autoFilePath );
            if ( File.Exists( _configFilePath ) ) list.Add( _configFilePath );
            if ( File.Exists( _bindFilePath ) ) list.Add( _bindFilePath );
            if ( File.Exists( _userFilePath ) ) list.Add( _userFilePath );
            ExportDialog ed = new ExportDialog( list, false );
            ed.ShowDialog( this );
        }

        private void HandleAddEditBind( object sender, EventArgs e ) {
            bool isCustomBind = _customBind.Text != "bind \"key\" \"command\"";
            if ( isCustomBind ) {
                // ADD BIND DIRECTLY TO THE CURRENT BIND SETTINGS                
                _currentBindListBox.Items.Add( _customBind.Text );
                _customBind.Clear( );
            } else {
                bool configSave = _bindItems.Count <= 0 && radioCommandsToolStripComboBox.SelectedIndex == -1 && ButtonPressed == "";
                bool bindNoKey = ( _bindItems.Count > 0 | radioCommandsToolStripComboBox.SelectedIndex > -1 | !sayTeamSayTextBox.Enabled ) && ButtonPressed == "";
                bool keyNoBind = ButtonPressed != "" && ( _bindItems.Count <= 0 && radioCommandsToolStripComboBox.SelectedIndex == -1 && sayTeamSayTextBox.Enabled );
                if ( configSave ) {
                    // bleh
                }
                if ( sayTeamSayTextBox.Text != "" & _enableSayItem.CheckState == CheckState.Unchecked ) {
                    DialogResult dr = MessageBox.Show( this, "You have text in your \"Say\" / \"Team Say\" textbox,\t\nbut have not selected to include it in your script.\n(its checkbox is unchecked)\n\npressing \"Yes\" will take you back to edit mode,\nwhere you can check the item order of your script\nand make any necessary changes to it.  you will \nthen need to hit \"Add Binds\" again to commit the \nchange.\n\nDo you wish to go back and make this change?\t", "Confirm this Operation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question );
                    if ( dr == DialogResult.Yes | dr == DialogResult.Cancel ) {
                        return;
                    } else {
                        //sayTeamSayTextBox.Text = "";
                    }
                }
                if ( bindNoKey ) {
                    MessageBox.Show( "You Must First Select A Key To Bind!", "Error, No Button Selected", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }
                if ( keyNoBind ) {
                    MessageBox.Show( "You Must Select an Item/Items To bind To This Key", "Error No Items Selected", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;

                }

                if ( _pendingEdit != "" ) {
                    _currentBindListBox.Items.Add( String.Format( "bind \"{0}\" \"{1}\"", ButtonPressed, GetParameters( ) ) );
                    _pendingEdit = "";
                    goto clear;
                }



                // ADD SELECTED ITEMS AND KEYS TO THE CURRENT BIND SETTINGS LIST
                if ( _bindItems.Count > 0 && ButtonPressed != "" && BindParameters != "" || radioCommandsToolStripComboBox.SelectedIndex != -1 || sayTeamSayTextBox.Text != "" ) {
                    // IF THE KEY BEING SUBMITTED FOR BINDING IS NOT ALREADY IN THE CURRENT 
                    // BIND SETTINGS LIST, INDEX WILL CONTAIN -1.  OTHERWISE IT WILL CONTAIN
                    // THE INDEX OF THE DUPLICATE KEY.
                    string button = ButtonPressed;
                    string search = String.Format( "bind \"{0}\"", button );
                    string bind = String.Format( "bind \"{0}\" \"{1}\"", button, GetParameters( ) );
                    int index = _currentBindListBox.FindString( search );
                    if ( index == -1 ) {
                        _currentBindListBox.Items.Add( bind );
                        // CLEAR CHECKED ITEMS AND PRESSED BUTTONS
                    }
                    // IF THE KEY IS A DUPLICATE, ASK IF THEY WANT TO REPLACE THE BIND
                    if ( index != -1 ) {
                        bool replace = false;
                        // IF YES, THEN INSERT IT AT INDEX'S POSITION
                        if ( ButtonPressed != "" && MessageBox.Show( "A Bind For This Key Already Exists!\nDo You Wish To Replace It?", "Duplicate Key Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation ) == DialogResult.Yes ) {
                            _currentBindListBox.Items[index] = bind;
                            replace = true;
                        }
                        if ( replace ) {
                            // CLEAR CHECKED ITEMS AND PRESSED BUTTONS
                            _pendingEdit = "";
                            goto clear;
                        }
                    }
                }
                _pendingEdit = "";
                clear:
                ClearBindOptions( );
                esc.Checked = true;
                esc.Checked = false;
                sayTeamSayTextBox.Enabled = false;
                sayTeamSayComboBox.Enabled = true;
                if ( _enableSayItem.Checked ) {
                    _enableSayItem.Checked = false;
                }
                sayTeamSayTextBox.Text = "";
                undoStripButton.Enabled = false;
                undoToolStripMenuItem.Enabled = false;
                addBindToolBarButton.Text = "Add &Bind";
            }
        }

        private void HandleDeleteBind( object sender, EventArgs e ) {
            #region
            _currentBindListBox.Items.Remove( _currentBindListBox.SelectedItem );
            //Save_Click(sender, e);
            #endregion
        }

        private void HandleSaveConfigs( object sender, EventArgs e ) {
            #region
            if ( _bindFilePath == "" && _configFilePath == "" || _bindFilePath == "" )
                PromptForConfigLocation( );

            if ( _currentBindListBox.Items.Count >= 0 && _bindFilePath != "" ) {
                WriteBinds( );
                _currentBindListBox.Items.Clear( );
                LoadConfigFile( );
            }
            #endregion
        }

        private void HandleUndoAction( object sender, EventArgs e ) {
            HandleDeselectBindItems( sender, e );
            HandleDeselectKey( sender, e );
            undoStripButton.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            _sayIndexOfRemoved = -1;
            addBindToolBarButton.Text = "Add &Bind";
        }

        private void HandleEditInBindmaker( object sender, EventArgs e ) {
            EditBinds( );
        }

        private void HandleEditAsText( object sender, EventArgs e ) {
            TempEditSolution( );
        }

        private void HandleDeselectKey( object sender, EventArgs e ) {
            #region
            if ( _pendingEdit != "" ) {
                _currentBindListBox.Items.Add( _pendingEdit );
                _pendingEdit = "";
                HandleDeselectKey( null, null );
            }
            esc.Checked = true;
            esc.Checked = false;
            #endregion
        }

        private void HandleDisplayTooltips( object sender, EventArgs e ) {
            #region DONE
            if ( _toolTip.Active == true ) {
                displayToolStripMenuItem.Checked = false;
                _toolTip.Active = false;
            } else {
                displayToolStripMenuItem.Checked = true;
                _toolTip.Active = true;
            }
            #endregion
        }

        private void HandleChangeGame( object sender, EventArgs e ) {
            #region
            InitializeData( );
            LoadConfigFile( );
            #endregion
        }

        private void HandleDeselectBindItems( object sender, EventArgs e ) {
            #region CLEAR BIND OPTIONS
            ClearBindOptions( );
            _bindItems.Clear( );
            if ( _enableSayItem.CheckState == CheckState.Checked ) {
                _enableSayItem.CheckState = CheckState.Unchecked;
                sayTeamSayComboBox.SelectedIndex = 0;
                sayTeamSayComboBox.Enabled = true;
                sayTeamSayTextBox.Text = "";
            }
            #endregion
        }

        private void HandleEditItemSequences( object sender, EventArgs e ) {
            if ( _bindItems.Count > 0 ) {
                _sequence = new BindingSequence( _bindItems, false );
                _sequence.UpdateOrderedBindsList += HandleUpdateOrderedBindsList;
                _sequence.ShowDialog( this );
                _sequence.Close( );
                _sequence.Dispose( );
            } else {
                MessageBox.Show( this, "You must select some items first\t", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void HandleClearSayTeamSay( object sender, EventArgs e ) {
            if ( _enableSayItem.Checked ) {
                int idx = GetSayTeamSayCommandIndex( );
                _bindItems.RemoveAt( idx );
                _sayIndexOfRemoved = idx;
            }
            _enableSayItem.Checked = false;
            sayTeamSayTextBox.Text = "";
            sayTeamSayTextBox.Enabled = false;
            sayTeamSayComboBox.SelectedIndex = 0;
            sayTeamSayComboBox.Enabled = true;
        }

        private void HandleEnableDisableSayTeamSay( object sender, EventArgs e ) {
            _enableSayItem.Image = _enableSayItem.Checked ? global::CZBindMaker.Properties.Resources.selected : global::CZBindMaker.Properties.Resources.select;
        }

        protected override void WndProc( ref Message m ) {
            if ( m.Msg == NativeMethods.WM_SHOWME ) {
                ShowMe( );
            }
            base.WndProc( ref m );
        }

        private void ShowMe( ) {
            if ( WindowState == FormWindowState.Minimized ) {
                WindowState = FormWindowState.Normal;
            }
            bool top = TopMost;
            TopMost = true;
            TopMost = top;
        }
    }
}
