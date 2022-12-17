using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path._dst.name.be_._valid
{
	/*extern alias character;*/
	public class InvalidChars
		:
		/*character::*/nilnul.character.SetI
	{

		/// <summary>
		/// Something that a lot of people note with the Path class is that it has a method called ‘GetInvalidPathChars’, but the list doesn’t return two key values which obviously, are not allowed to be used as part of file names: ‘*’ and ‘?’.
		/// </summary>

		static public IEnumerable<char> SpecialChars =
			System.IO.Path.GetInvalidFileNameChars().Concat(System.IO.Path.GetInvalidPathChars()).Concat(new char[] {
				'\\'
				,
				'/'
				,'?'
				,
				'*'
				//,'&'	//some dir name contain &
				,'"'
				,'<'
				,'>'
				,'|'
				//,'#'	//dir c# is valid
				//,'%'	///in document, % is not allowed. but I have seen and created folder with % in its name

				//,				';' some file name contains ";"
				,
				':'


			})
			;
		


		static private Lazy<InvalidChars> _Lazy = new Lazy<InvalidChars>();
		static public InvalidChars Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

		public bool contains(char element)
		{
			return (SpecialChars.Contains(element)) ||   char.IsControl(element) && char.IsSurrogate(element);
		}
	}
}
