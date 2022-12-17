using System;

namespace nilnul.fs._address.doc_
{
	[Obsolete()]
	static public class _MainExtX
	{
		public const char Seperator = '.';

		static public bool Be(doc_._exted.Main main, doc_._exted.ExtI ext)
		{
			if (main.en.EndsWith("."))
			{
				if (ext.ToString() == "")
				{
					return false;
				}
			}
			return true;
		}

		static public void Vow(doc_._exted.Main main, doc_._exted.ExtI ext)
		{
			nilnul.bit.vow_.true_.Unacceptable.Singleton.vow(Be(main, ext));
		}
	}
}
