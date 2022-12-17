namespace nilnul.fs._address._route.division_._div._dir.dnt_._vered
{
	public class Nom : nilnul.txt_._vered.Name
	{
		public Nom(string s) : base(s)
		{
			_address._route.division_._div._dir._dnt.txt.Vow.Singleton.vow(s);
		}

		static public Nom CreateByAppendingSubIfNeed(string s)
		{
			if (s=="")
			{
				s = "__";
			}
			return new Nom(
				nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(s)
			);
		}
	}
}
