using System;

namespace nilnul.fs._address._dst.denote_._vered_
{
	[Obsolete()]
	public class Germ : nilnul.txt_._vered_.Name
	{
		public Germ(string s) : base(s)
		{
			_denote.txt.Vow.Singleton.vow(s);
		}

		static public Germ CreateByAppendingSubIfNeed(string s)
		{
			return new Germ(
				nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(s)
			);
		}
	}
}
