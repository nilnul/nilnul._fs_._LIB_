using System.Text.RegularExpressions;

namespace nilnul.fs._address._route.division_._div._dir._dnt.txt.be_._valid.whole_
{
	public class Invalids
		:
		nilnul.txt.CollectionI,
		nilnul.txt.SetI
	{

		/*Do not use the following reserved names for the name of a file:

CON, PRN, AUX, NUL, 
COM1, COM2, COM3, COM4, COM5, COM6, COM7, COM8, COM9,
LPT1, LPT2, LPT3, LPT4, LPT5, LPT6, LPT7, LPT8, and LPT9. 
Also avoid these names followed immediately by an extension; for example, NUL.txt is not recommended. For more information, see Namespaces.*/
		#region these two set would throw exception when as dir name to be created in windows file manager

		public static Regex lpts = new Regex(@"^LPT[1-9]$", RegexOptions.IgnoreCase);
		public static Regex coms = new Regex(@"^COM[1-9]$", RegexOptions.IgnoreCase);
		#endregion

		public static string[] reserved = new[] {
			"CON", "PRN", "AUX", "NUL"	//all these throw exception when creating dir in windows FileManager
			,
			//"CLOCK$"	//in windows FileManager, we found this is ok when creating dir.
			
		};

		public Invalids() : base()
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

		static public Invalids Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Invalids>.Instance;
			}
		}
	}
}
