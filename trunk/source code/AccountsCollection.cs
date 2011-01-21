/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 * 
 * */ 

namespace CZBindMaker {
	using System;
	using System.IO;
	using System.Collections;
	[Flags]
	public enum Games {
		None = 0,
		CS = 1,
		CZ = 2,
		CSS = 4
	}
	internal class AccountsCollection : ICollection {
		private Hashtable _accounts;
		private ArrayList _acctOrder;
		internal AccountsCollection() {
			_accounts = new Hashtable();
			_acctOrder = new ArrayList();
		}
		/// <summary>
		/// Creates a new account
		/// </summary>
		/// <param name="accountName">the account name</param>
		internal void AddAccount(string accountName) {
			if(!_accounts.Contains(accountName)) {
				_accounts.Add(accountName, new Account(accountName));
				_acctOrder.Add(accountName);
			}
		}
		/// <summary>
		/// Adds and sets up an account
		/// </summary>
		/// <param name="accountName">the name of the account</param>
		/// <param name="acctPath">the path to the account name. ex: C:\Program Files\Steam\SteamApps\myaccountName</param>
		internal void AddAccount(string accountName, string acctPath) {
			this.AddAccount(accountName);
			string csPath = "", czPath = "", cssPath = "";
			bool csFound = false, czFound = false, cssFound = false;
			string[] dirs = Directory.GetDirectories(acctPath, "*");
			foreach(string s in dirs) {
				if(Path.Combine(acctPath, s).ToLower() == Path.Combine(acctPath.ToLower(), "counter-strike")){
					csPath = Path.Combine(acctPath, s);
					string[] dir2 = Directory.GetDirectories(csPath, "cstrike*");
					foreach(string s2 in dir2) {
						string dir = Path.GetFileName(s2);
						bool dirLength = dir.Length >= 7;
						bool isCstrike = false;
						if(dirLength)
							isCstrike = dir.Substring(0, 7).ToLower() == "cstrike";
						if(isCstrike && File.Exists(Path.Combine(s2, "config.cfg"))) {
							csFound = true;
							csPath = s2;
							break;
						}
					}
				}
                if(Path.Combine(acctPath, s).ToLower() == Path.Combine(acctPath.ToLower(), "counter-strike source")){
                    cssPath = Path.Combine(acctPath, s);
                    string[] dir2 = Directory.GetDirectories(cssPath, "cstrike*");
                    foreach(string s2 in dir2) {
                        string dir = Path.GetFileName(s2);
                        bool dirLength = dir.Length >= 7;
                        bool isCstrike = false;
                        if(dirLength)
                            isCstrike = dir.Substring(0, 7).ToLower() == "cstrike";
                        if(isCstrike && File.Exists(Path.Combine(Path.Combine(s2, "cfg"), "config.cfg"))) {
                            cssFound = true;
                            cssPath = Path.Combine(s2, "cfg");
                            break;
                        }
                    }
                }
				if(Path.Combine(acctPath, s).ToLower() == Path.Combine(acctPath.ToLower(), "condition zero")){
					csPath = Path.Combine(acctPath, s);
					string[] dir2 = Directory.GetDirectories(csPath, "czero*");
					foreach(string s2 in dir2) {
						string dir = Path.GetFileName(s2);
						bool dirLength = dir.Length >= 5;
						bool isCzero = false;
						if(dirLength)
							isCzero = dir.Substring(0, 5).ToLower() == "czero";
						if(isCzero && File.Exists(Path.Combine(s2, "config.cfg"))) {
							czFound = true;
							czPath = s2;
							break;
						}
					}
				}
				if(csFound) {
					((Account)_accounts[accountName]).AddPath(Games.CS, csPath);
					csFound = false;
				}                
                if(cssFound) {
                    ((Account)_accounts[accountName]).AddPath(Games.CSS, cssPath);
                    cssFound = false;
                }
				if(czFound) {
					((Account)_accounts[accountName]).AddPath(Games.CZ, czPath);
					czFound = false;
				}
			}
		}
		internal void AddPath(string accountName, Games game, string pathToConfig) {
			if(_accounts.ContainsKey(accountName)) {
				((Account)_accounts[accountName]).AddPath(game, pathToConfig);
			}

		}
		/// <summary>
		/// Gets an account by index
		/// </summary>
		internal Account this[int index] {
			get{
				if(_acctOrder.Count >= index) {
					string id = _acctOrder[index].ToString();
					if(_accounts.ContainsKey(id)) {
						return ((Account)_accounts[id]);
					}else {
						throw new IndexOutOfRangeException();
					}
				}else {
					throw new IndexOutOfRangeException();
				}
			}
		}  
		/// <summary>
		/// Gets an account by name
		/// </summary>
		internal Account this[string accountName] {
			get{
				if(_accounts.ContainsKey(accountName)) {
					return ((Account)_accounts[accountName]);
				}else {
					throw new IndexOutOfRangeException();
				}
			}
		}
		/// <summary>
		/// gets a game path for a specific account name & game
		/// </summary>
		internal string this[string accountName, Games game] {
			get{
				if(game == Games.CS) {
					if(_accounts.ContainsKey(accountName)) {
						return ((Account)_accounts[accountName]).GamePaths.CsPath;
					}else   
						throw new IndexOutOfRangeException();
				}else if(game == Games.CZ) {
					if(_accounts.ContainsKey(accountName)) {
						return ((Account)_accounts[accountName]).GamePaths.CzPath;
					}else   
						throw new IndexOutOfRangeException();
                }else if(game == Games.CSS) {
                    if(_accounts.ContainsKey(accountName)) {
                        return ((Account)_accounts[accountName]).GamePaths.CssPath;
                    }else   
                        throw new IndexOutOfRangeException();
                }else
					throw new IndexOutOfRangeException();
			}
		}


		public bool IsSynchronized {
			get {
				return _accounts.IsSynchronized;
			}
		}

		public int Count {
			get {
				return _accounts.Count;
			}
		}

		public void CopyTo(Array array, int index) {
			this._accounts.CopyTo(array, index);
		}

		public object SyncRoot {
			get {
				return _accounts.SyncRoot;
			}
		}

		public IEnumerator GetEnumerator() {
			return this._accounts.GetEnumerator();
		}

	}
}
