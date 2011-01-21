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
	using Microsoft.Win32;
	internal class ConfigSearch {
		private RegistryKey _modInstallPath;
		private string _path;
		private bool _regFound;
		private AccountsCollection _accounts;
		internal ConfigSearch() {
			this._accounts = new AccountsCollection();
			_modInstallPath = Registry.CurrentUser.CreateSubKey(@"Software\Valve\Steam");
			string[] keys = _modInstallPath.GetValueNames();
			foreach(string s in keys) {
				try {
					if(s.ToLower() == "modinstallpath") {
						_path = _modInstallPath.GetValue(s, "BLANK").ToString();
						_path = Path.GetDirectoryName(_path);
						if(_path != "BLANK") {
							_regFound = true;
							string acctPath = Path.GetDirectoryName(_path);
							if(Directory.Exists(acctPath)) {
								foreach(string s1 in Directory.GetDirectories(acctPath)) {
                                    string fname = Path.GetFileName(s1.ToLower());
                                    if(fname != "sourcemods" && fname != "common")
									    this._accounts.AddAccount(Path.GetFileName(s1), s1);
								}
                                _regFound = _accounts.Count > 0;
							}else {
								_regFound = false;
							}
						}else {
							_regFound = false;
						}
						break;
					}
				}catch {
					continue;
				}
			}
			_modInstallPath.Close();
		}
		internal AccountsCollection Accounts {
			get{return this._accounts;}
		}
		internal bool KeyFound {
			get{return this._regFound;}
		}
	}
}
