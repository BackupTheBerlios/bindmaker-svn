/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 *
 * 
 * */ 

namespace CZBindMaker {
	using System;
	using System.Text.RegularExpressions;
	internal enum CommandType {
		Buy,
		Radio,
		Say,
		TeamSay,
		Unimplemented
	}
	internal class Command {
		private CommandType _type;
		private string _cmd;
		internal Command(string text) {   
			this._type = BindMap.GetType(text);
			if(this._type != CommandType.Say && this._type != CommandType.TeamSay) {
				this._cmd = text + ";";
			}else {	
				this._cmd = text.Trim();
				if(_type == CommandType.Say) this._cmd = this._cmd.Replace("say ", "").Trim();
				else this._cmd = this._cmd.Replace("say_team ", "").Trim();

			}
		}
		internal CommandType CmdType {
			get{return this._type;}
			set{this._type = value;}
		}
		internal string CommandText {
			get{return this._cmd;}
			set{this._cmd = value;}
		}
	}
}
