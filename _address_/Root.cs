using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace nilnul.fs._address_
{
	public class Root:RootI
	{
		private nilnul.fs._address_._root_.Vol _vol;
		public const char _charEnd = '\\';

		public nilnul.fs._address_._root_.Vol vol
		{
			get { return _vol; }
			set { _vol = value; }
		}

		public Root(nilnul.fs._address_._root_.Vol vol)
		{
			_vol = vol;
		}

		public override string ToString()
		{
			return _vol.ToString() + "\\";
		}
		static public Root Parse_trimmed(string s) {
			nilnul.obj.AssertX.True(
				s.EndsWith( _charEnd.ToString()) 
			);

			return new Root(
				nilnul.fs._address_._root_.Vol.Parse_fromTrimmed(s.Substring(0, s.Length-1 ))	
			);
		}

		static public Root Parse_trimmed_altSeperatorAllowed(string s) {
			nilnul.obj.AssertX.True(s.EndsWith( _charEnd.ToString()) || s.EndsWith( System.IO.Path.AltDirectorySeparatorChar.ToString()));

			return new Root(
				nilnul.fs._address_._root_.Vol.Parse_fromTrimmed(s.Substring(0, s.Length-1 ))	
			);
		}


	}
}
