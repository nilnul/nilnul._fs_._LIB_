using System;
using System.Text.RegularExpressions;

namespace nilnul.fs._address._dst._denote.txt.be_._valid
{
	[Obsolete()]
	public class InvalidNames
		:
		nilnul.txt.CollectionI,
		nilnul.txt.SetI
	{

		/*Do not use the following reserved names for the name of a file:

CON, PRN, AUX, NUL, 
COM1, COM2, COM3, COM4, COM5, COM6, COM7, COM8, COM9,
LPT1, LPT2, LPT3, LPT4, LPT5, LPT6, LPT7, LPT8, and LPT9. 
Also avoid these names followed immediately by an extension; for example, NUL.txt is not recommended. For more information, see Namespaces.*/

		public static Regex lpts = new Regex(@"^LPT[1-9]$", RegexOptions.IgnoreCase);
		public static Regex coms = new Regex(@"^COM[1-9]$", RegexOptions.IgnoreCase);
		public static string[] reserved = new[] {
			"CON", "PRN", "AUX", "NUL", "CLOCK$",
		};

		public InvalidNames() : base()
		{

		}

		public bool contains(string element)
		{
			return contain(element);
			//throw new NotImplementedException();
		}

		public bool contain(string element)
		{
			return lpts.IsMatch(element)
				||
				coms.IsMatch(element)
				||
				nilnul.txt.set.be_._ContainX.Contain_caseInsensitive(reserved, element)
				||
				(element == "." || element == ".." || element == "")
				;
		}

		static public InvalidNames Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<InvalidNames>.Instance;
			}
		}
	}
}
