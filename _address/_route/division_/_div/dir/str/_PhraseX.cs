using System;
using System.Linq;

namespace nilnul.fs._address.dir.str
{
	static public class _PhraseX
	{


		[Obsolete(nameof(Div))]
		public static string ToTxt(DirI[] dirs)
		{

			return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate(
							dirs.Select(x =>
								(x).ToString()
							)
						);
			throw new NotImplementedException();
		}

		//[Obsolete(nameof(Div))]
		//static public string ToTxt(DstsI dsts)
		//{
		//	return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate(
		//		dsts.Select(x =>
		//			Dir.ToTxt(x)
		//		)
		//	);
		//}
	}
}
