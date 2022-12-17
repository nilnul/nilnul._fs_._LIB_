using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_._driveEntry_
{
	/// <summary>
	/// another partion of address: 
	///		1) drive; 2)Road such as "\", "\a", "\a\", "\a\b"
	/// </summary>
	public class Drive
	{
		private char _driveLetter;

		public Drive(char driveLetter)
		{
			this._driveLetter = char.ToUpper( driveLetter);
		}

		static public Drive Parse(string x) {
			nilnul.obj.vow_.True.Vow(x.EndsWith(":"));

			nilnul.obj.vow_.True.Vow(x.Length==2);
			return new Drive(x.First());
		}

		public override string ToString()
		{
			return $"{_driveLetter}:";
		}
	}
}
