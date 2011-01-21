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
 * 
 * */

namespace CZBindMaker {					  
	using System;
	using System.Collections;
	using System.Text.RegularExpressions;
	internal class BindMap{
		private Hashtable m_bindMap;
		private Hashtable m_buyMap;
		private Hashtable m_radioMap;
		private Hashtable m_sayMap;
		private Hashtable m_keys;
		private Hashtable m_pluginMap;
		private static string m_csAliases = "alias double_flash \"flash;flash;\"";
		public static string CSAliases {
			get{return m_csAliases;}
		}

		internal BindMap(){
			if(this.m_bindMap == null){
				// bind map
				this.m_bindMap = new Hashtable(5);

				// buy items
				this.m_buyMap = new Hashtable();
				this.m_buyMap.Add("Aug (Bullpup)", "aug;");
				this.m_buyMap.Add("Sig", "sg552;");
				this.m_buyMap.Add("Auto shotty (xm1014)", "xm1014;");
				this.m_buyMap.Add("Awp (Awm / Magnum)", "awp;");
				this.m_buyMap.Add("Colt (M4A1)", "m4a1;");  
				this.m_buyMap.Add("Ak47 (cv47)", "ak47;");
				this.m_buyMap.Add("Deagle (Nighthawk)", "deagle;");
				this.m_buyMap.Add("Defuser Kit", "defuser;");
				this.m_buyMap.Add("Elites (Dualies)", "elites;");
				this.m_buyMap.Add("Famas (Clarion)", "famas;"); 
				this.m_buyMap.Add("Galil (Defender)", "galil;");
				this.m_buyMap.Add("Flash Grenade (1 grenade)", "flash;");
				this.m_buyMap.Add("Flash Grenades (2 grenades)", "double_flash;");
				this.m_buyMap.Add("Fn57", "fn57;");
				this.m_buyMap.Add("Auto Sniper [CT] (Sg550 / krieg550)", "sg550;");   
				this.m_buyMap.Add("Auto Sniper [T] (G3sg1/d3au1)", "g3sg1;");
				this.m_buyMap.Add("Glock (9x19M)", "glock;");
				this.m_buyMap.Add("Usp (km45)", "usp;");
				this.m_buyMap.Add("HE Grenade", "hegren;");
				this.m_buyMap.Add("Mac10", "mac10;");
				this.m_buyMap.Add("Mp5 Navy (smg)", "mp5;");
				this.m_buyMap.Add("Night Vision Goggles", "nvgs;");
				this.m_buyMap.Add("P228 (228compact)", "p228;");
				this.m_buyMap.Add("P90", "p90;");
				this.m_buyMap.Add("Para (m249)", "m249;");
                this.m_buyMap.Add("Primary Ammo (Full)", "primammo;");
                this.m_buyMap.Add("Primary Ammo (Single Clips)", "buyammo1;");
				this.m_buyMap.Add("Scout", "scout;");
                this.m_buyMap.Add("Secondary Ammo (Full)", "secammo;");
                this.m_buyMap.Add("Secondary Ammo (Single Clips)", "buyammo2;");
				this.m_buyMap.Add("Shield", "shield;");
				this.m_buyMap.Add("Shotgun(m3 / 12gauge)", "m3;");
				this.m_buyMap.Add("Smoke Grenade", "sgren;");
				this.m_buyMap.Add("Stop Sound Command", "stopsound;");
				this.m_buyMap.Add("Tmp", "tmp;");
				this.m_buyMap.Add("Ump45", "ump45;");
				this.m_buyMap.Add("Vest", "vest;");
				this.m_buyMap.Add("Vest & Helmet", "vesthelm;");
				// add entry to bind map
				this.m_bindMap.Add(BindType.Buy, this.m_buyMap);

				// radio commands
				this.m_radioMap = new Hashtable(21);
				this.m_radioMap.Add("Cover me", "coverme;");
				this.m_radioMap.Add("You take the point", "takepoint;");
				this.m_radioMap.Add("Hold this position", "holdpos;");
				this.m_radioMap.Add("Re-group team", "regroup;");
				this.m_radioMap.Add("Follow me", "followme;");
				this.m_radioMap.Add("Taking fire", "takingfire;");
				this.m_radioMap.Add("Go Go Go", "go;");
				this.m_radioMap.Add("Fall back", "fallback;");
				this.m_radioMap.Add("Stick together team", "sticktog;");
				this.m_radioMap.Add("Get in position", "getinpos;");
				this.m_radioMap.Add("Storm the front", "stormfront;");
				this.m_radioMap.Add("Report in team", "report;");
				this.m_radioMap.Add("Roger that/ Affirmative", "roger;");
				this.m_radioMap.Add("Enemy spotted", "enemyspot;");
				this.m_radioMap.Add("Need backup", "needbackup;");
				this.m_radioMap.Add("Sector clear", "sectorclear;");
				this.m_radioMap.Add("I'm in position", "inposition;");
				this.m_radioMap.Add("Reporting in", "reportingin;");
				this.m_radioMap.Add("Get out of there", "getout;");
				this.m_radioMap.Add("Negative", "negative;");
				this.m_radioMap.Add("Enemy down", "enemydown;");
				// add entry to bind map
				this.m_bindMap.Add(BindType.Radio, this.m_radioMap);

				// say menu
				this.m_sayMap = new Hashtable(2);
				this.m_sayMap.Add("Say", "say ");
				this.m_sayMap.Add("Team Say", "say_team ");
//                m_sayMap.Add("","");
//                m_sayMap.Add("","");
//                m_sayMap.Add("","");
//                m_sayMap.Add("","");
//                m_sayMap.Add("","");
//                m_sayMap.Add("","");
//                m_sayMap.Add("","");
				// add entry to bind map
				this.m_bindMap.Add(BindType.Say, this.m_sayMap);

				// keyboard items
				this.m_keys = new Hashtable();
				// add entry to bind map
				this.m_bindMap.Add(BindType.Keyboard, this.m_keys);

				// plugin's
				this.m_pluginMap = new Hashtable();
				// add entry
				this.m_bindMap.Add(BindType.Plugin, this.m_pluginMap);
			}
		}   
		internal object this[BindType type, object key]{
			get{return ((Hashtable)this.m_bindMap[type])[key];}
		}
		// buy items
		internal ICollection BuyKeys {
			get{return ((Hashtable)this.m_bindMap[BindType.Buy]).Keys;}
		}
		// radio items
		internal ICollection RadioKeys {
			get{return ((Hashtable)this.m_bindMap[BindType.Radio]).Keys;}
		}
		// say items
		internal ICollection SayKeys {
			get{return ((Hashtable)this.m_bindMap[BindType.Say]).Keys;}
		}
		internal string BoundRadioKey {
			get{return 	this.m_bindMap[BindType.Radio].ToString();}
		}

		internal bool ContainsKey(BindType type, object value) {
			return ((Hashtable)this.m_bindMap[type]).ContainsKey(value);
		}
		internal bool ContainsKey(object value) {
			bool flag1 = this.ContainsKey(BindType.Buy, value);
			bool flag2 = this.ContainsKey(BindType.Radio, value);
			if(flag1 || flag2) return true;
			else return false;
		}
		internal bool ContainsValue(BindType type, object value) {
			return ((Hashtable)this.m_bindMap[type]).ContainsValue(value);
		}
		internal bool ContainsValue(object value) {
			bool flag1 = this.ContainsValue(BindType.Buy, value);
			bool flag2 = this.ContainsValue(BindType.Radio, value);
			if(flag1 || flag2) return true;
			else return false;
		}
		internal object GetKey(object value) {
			string val = value.ToString();
			if(val[val.Length-1] != ';') {
				value = val+";";
			}
			if(((Hashtable)this.m_bindMap[BindType.Buy]).ContainsValue(value)) {
				IDictionaryEnumerator enm = ((Hashtable)this.m_bindMap[BindType.Buy]).GetEnumerator();
				while(enm.MoveNext()) {
					if(enm.Value.ToString().ToLower() == value.ToString().ToLower()) {
						return enm.Key;
                    }
				}
			}
			if(((Hashtable)this.m_bindMap[BindType.Radio]).ContainsValue(value)) {
				IDictionaryEnumerator enm = ((Hashtable)this.m_bindMap[BindType.Radio]).GetEnumerator();
				while(enm.MoveNext()) {
					if(enm.Value.ToString().ToLower() == value.ToString().ToLower()) {
						return enm.Key;
					}
				}
			}
			return value;
		}
		internal object GetValue(object key) {
			if(((Hashtable)this.m_bindMap[BindType.Buy]).ContainsKey(key)) {
				IDictionaryEnumerator enm = ((Hashtable)this.m_bindMap[BindType.Buy]).GetEnumerator();
				while(enm.MoveNext()) {
					if(enm.Key.ToString().ToLower() == key.ToString().ToLower()) {
						return enm.Value;
					}
				}
			}
			if(((Hashtable)this.m_bindMap[BindType.Radio]).ContainsKey(key)) {
				IDictionaryEnumerator enm = ((Hashtable)this.m_bindMap[BindType.Radio]).GetEnumerator();
				while(enm.MoveNext()) {
					if(enm.Key.ToString().ToLower() == key.ToString().ToLower()) {
						return enm.Value;
					}
				}
			}
			return key;
		}

		internal ArrayList GetCommandsList(string buffer) {
			ArrayList list = new ArrayList(buffer.Split(';'));
			ArrayList cmdList = new ArrayList();
			while(list.Contains("")) {
				list.Remove("");
			}
			for(int i = 0; i < list.Count; i++) {
				if(list[i].ToString().ToLower() == "flash") {
					if( i+1 < list.Count) {
						string command   = list[i+1].ToString().ToLower();
						bool isDoubleFlash = command == "flash";
						if(isDoubleFlash) {
							cmdList.Add(new Command("double_flash"));
							i++;
						}
					}
				}else {
					cmdList.Add(new Command(list[i].ToString()));
				}
			}
			return cmdList;
		}

		internal static CommandType GetType(string command) {
			if(Regex.Match(command, @"^say(_team)?\s.*$", RegexOptions.ExplicitCapture|RegexOptions.IgnoreCase).Success) {
				if(command[3] == '_') return CommandType.TeamSay;
				else return CommandType.Say;
			}
			if(Regex.Match(command, @"^coverme$|^takepoint$|^holdpos$|^regroup$|^followme$|^takingfire$|^go$|^fallback$|^sticktog$|^getinpos$|^stormfront$|^report$|^roger$|^enemyspot$|^needbackup$|^sectorclear$|^inposition$|^reportingin$|^getout$|^negative$|^enemydown$", RegexOptions.ExplicitCapture|RegexOptions.IgnoreCase).Success) {
				return CommandType.Radio;
			}
			if(Regex.Match(command, @"^aug$|^sg552$|^xm1014$|^awp$|^m4a1$|^ak47$|^deagle$|^defuser$|^elites$|^famas$|^galil$|^flash$|^double_flash$|^fn57$|^g3sg1$|^sg550$|^glock$|^usp$|^hegren$|^mac10$|^mp5$|^nvgs$|^p228$|^p90$|^m249$|^primammo$|^scout$|^secammo$|^shield$|^m3$|^sgren$|^stopsound$|^tmp$|^ump45$|^vest$|^vesthelm$", RegexOptions.ExplicitCapture|RegexOptions.IgnoreCase).Success) {
				return CommandType.Buy;
			}
			return CommandType.Unimplemented;
		}
	}
}
