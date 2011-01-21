/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 *
 * 
 * */ 

namespace CZBindMaker {
	using System;
	internal class Account {
		private string _accountName;
		private GamesCollection _paths;
		internal Account(string accountName) {
			this._accountName = accountName;
			this._paths = new GamesCollection();
		}
		internal void AddPath(Games game, string path) {
			this._paths.AddPath(game, path);
		}
		internal void AddPath(string path) {
			this._paths.AddPath(path);
		}
		internal string AccountName {
			get{return this._accountName;}
		}
		internal Games GamesListed {
			get{return _paths.GamesListed;}
		}
		internal GamesCollection GamePaths {
			get{return _paths;}
		}
		internal string GetConfigPath(Games game, ConfigType type) {
			return this.GamePaths.GetConfigPath(game, type);
		}
	}
}
