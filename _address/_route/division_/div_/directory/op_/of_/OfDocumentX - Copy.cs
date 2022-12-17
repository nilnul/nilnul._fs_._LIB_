using System;
using System.Linq;

namespace nilnul.fs._address.directory_
{
	[Obsolete()]
	public static class _DocumentX
	{
		public static Directory Exe(DocumentI document)
		{
			return new Directory(
				document.div.dirs.Concat(
					new DirI[] {
						new Dir(
							document.doc
						)

					}
				)
			);
		}
		public static Directory Parse(string txt)
		{
			nilnul.character_.cha.vow_.fs_.DirSep.Singleton.vow(txt.Last());

			return Exe(
				_address.Document.Parse(
					txt.Substring(0, txt.Length - 1)
				)
			);

		}
	}
}