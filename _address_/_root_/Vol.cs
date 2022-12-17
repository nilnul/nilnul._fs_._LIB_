using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._root_
{
	/// <summary>
	/// the logical drives inside a partion of a disk.
	/// </summary>
	public class Vol:VolI
	{
		private nilnul.character.en_.Letter _letter;

		public nilnul.character.en_.Letter  letter
		{
			get { return _letter; }
			set { _letter = value; }
		}

		public Vol(nilnul.character.en_.Letter letter)
		{
			 _letter = letter;

		}

		public override string ToString()
		{
			return _letter.ToString() + ":";
		}

		static public Vol Parse_fromTrimmed(string s) {
			nilnul.obj.aver_.True.Aver(s.EndsWith(":") );

			nilnul.obj.aver_.True.Aver(s.Length==2);

			return new Vol(
				new character.en_.Letter(s[0])	
			);

		}


	}
}
