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
	enum BindType{
		Buy,
		Radio,
		Say,
		Keyboard,
		Plugin
	}
	public enum EventType {
		Read,
		Write,
		Add,
		Remove,
		Update,
		Error
	}
	internal enum Paths {
		Config,
		Bind,
		Auto,
		User,
		Misc
	}
	[Flags]
	internal enum InstalledGames {
		HL		= 0x000000,
		CS		= 0x000002,
		CZ		= 0x000004,
		CSS		= 0x000008, 
		DOD		= 0x000016,
		TFC		= 0x000032,
		OF		= 0x000064,
		DC		= 0x000128,
		HL2		= 0x000256
	}
}
