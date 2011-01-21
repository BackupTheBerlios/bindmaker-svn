/*
 * Copyright © 2004 NullFX Software
 * By: Steve Whitley
 *
 * 
 * */ 

namespace CZBindMaker {
	using System;  
	using System.Collections;
	using System.Text.RegularExpressions;
	internal class CzbmUtility {
		private CzbmUtility(){}
		internal static string GetKeyFromScript(string script) {
			if(script.Length > 0) {
				bool isBind = (script.Substring(0, 4).ToLower() == "bind");
				if(isBind) {
					script = Regex.Replace(script, @"(\s+)", " ");
					script = Regex.Replace(script, @";(\s+)", ";");
					script = script.Replace("\"", "");
					string[] buffer = script.Split(' ');
					if(buffer.Length == 3) {
					}else {
					}
				}
			}else {
				return null;
			}  
			return null;
		}
		internal static ArrayList GetCommandsFromScript(string script) {
			if(script.Length > 0) {
				ArrayList items = new ArrayList();
				string[] buffer = script.Split(' ');
			}else {
				return null;
			}
			return null;
		}
	}
}
