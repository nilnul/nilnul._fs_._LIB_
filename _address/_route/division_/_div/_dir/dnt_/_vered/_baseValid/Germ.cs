using System;

namespace nilnul.fs._address._dst.denote_._vered
{
	[Obsolete(nameof(_address._route.division_._div._dir.dnt_._vered.Nom))]
	//			nilnul.fs._address._route.division_._div.dnt_._vered
	public class Germ : nilnul.txt_._vered.Name
	{
		public Germ(string s) : base(s)
		{
			_denote.txt.Vow.Singleton.vow(s);
		}

		static public Germ CreateByAppendingSubIfNeed(string s)
		{
			if (s=="")
			{
				s = "__";
			}
			return new Germ(
				nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(s)
			);
		}
	}
}
