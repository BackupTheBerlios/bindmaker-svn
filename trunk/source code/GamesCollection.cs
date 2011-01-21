/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 *
 * 
 * */ 

namespace CZBindMaker {
	using System;
	using System.IO;
	using System.Collections;
	using System.Text.RegularExpressions;
	internal enum ConfigType {
		Auto,
		Config,
		Czbm,
		User,
        Compatibility,
        Clips
	}
	internal class GamesCollection {
		private Hashtable _gamePaths;
		private Games _games;
		internal GamesCollection() {
			this._gamePaths = new Hashtable();
		}
		internal void AddPath(string path) {
			if(Regex.Match(path, @"counter-strike", RegexOptions.IgnoreCase|RegexOptions.ExplicitCapture).Success) {
				_games |= Games.CS;
				this._gamePaths.Add(Games.CS, path);
			}
			if(Regex.Match(path, @"condition zero", RegexOptions.IgnoreCase|RegexOptions.ExplicitCapture).Success) {
				_games |= Games.CZ;                 				
				this._gamePaths.Add(Games.CZ, path);
            } 
            if(Regex.Match(path, @"counter-strike\ssource", RegexOptions.IgnoreCase|RegexOptions.ExplicitCapture).Success) {
                _games |= Games.CSS;                 				
                this._gamePaths.Add(Games.CSS, Path.Combine(path, "cfg"));
            }
		}
		internal void AddPath(Games game, string path) {
			this._games |= game;
			this._gamePaths.Add(game, path);
		}
		internal Games GamesListed {
			get{return this._games;}
		}
		internal string CsPath {
			get{
				if(_gamePaths.ContainsKey(Games.CS)) {
					return _gamePaths[Games.CS].ToString();
				}else {
					return "";
				}
			}
		}
		internal string CzPath {
			get{
				if(_gamePaths.ContainsKey(Games.CZ)) {
					return _gamePaths[Games.CZ].ToString();
				}else {
					return "";
				}
			}
		}
        internal string CssPath {
            get {
                if(_gamePaths.ContainsKey(Games.CSS)) {
                    return _gamePaths[Games.CSS].ToString();
                }else {
                    return "";
                }
            }
        }
		internal string GetConfigPath(Games game, ConfigType type) {
			switch((int)type) {
				case 0:
					if(game == Games.CS) {
						return Path.Combine(this.CsPath, "autoexec.cfg");
                    }else if(game == Games.CSS) {
                        return Path.Combine(this.CssPath, "autoexec.cfg");
                    }else {
						return Path.Combine(this.CzPath, "autoexec.cfg");
					}
				case 1:	  
					if(game == Games.CS) {
						return Path.Combine(this.CsPath, "config.cfg");
                    }else if(game == Games.CSS) {
                        return Path.Combine(this.CssPath, "config.cfg");
                    }else {	
						return Path.Combine(this.CzPath, "config.cfg");
					}
				case 2:	  
					if(game == Games.CS) {
						return Path.Combine(this.CsPath, "czbind.cfg");
                    }else if(game == Games.CSS) {
                        return Path.Combine(this.CssPath, "czbind.cfg");
                    }else {	
						return Path.Combine(this.CzPath, "czbind.cfg");
					}
				case 3:	
					if(game == Games.CS) {   
						return Path.Combine(this.CsPath, "userconfig.cfg");
                    }else if(game == Games.CSS) {
                        return Path.Combine(this.CssPath, "userconfig.cfg");
                    }else {
						return Path.Combine(this.CzPath, "userconfig.cfg");
					}
                case 4:	
                    if(game == Games.CSS) {
                        return Path.Combine(this.CssPath, "compatibility.cfg");
                    }
                    break;
                case 5:
                    if(game == Games.CS) {   
                        return Path.Combine(this.CsPath, "clips.cfg");
                    }else if(game == Games.CSS) {
                        return Path.Combine(this.CssPath, "clips.cfg");
                    }else {
                        return Path.Combine(this.CzPath, "clips.cfg");
                    }
			}
			return "";
		}
	}
}
