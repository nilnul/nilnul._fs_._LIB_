using System;
using System.Linq;
using D = nilnul.fs._address._route.division_._div.DirI;

namespace nilnul.fs._address._route.division_.div_.directory.op_.of_
{
	public static class _DocumentX
	{
		public static Directory Exe(div.DntedI document)
		{
			return new Directory(
				document.div.Concat(
					new  D[] {
						new nilnul.fs._address._route.division_._div.Dir(
							document.dnt
						)

					}
				)
			);
		}
		public static Directory Parse(string txt)
		{
			nilnul.character_.cha.vow_.fs_.DirSep.Singleton.vow(txt.Last());

			return Exe(
				_address._route.division_.div.Dnted.Parse(
					txt.Substring(0, txt.Length - 1)
				)
			);

		}
	}
}