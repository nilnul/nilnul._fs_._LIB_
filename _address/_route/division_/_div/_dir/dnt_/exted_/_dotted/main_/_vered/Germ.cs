namespace nilnul.fs._address.doc_.exted_._dotted.main_._vered
{
	public class Name : nilnul.txt_._vered.Name
	{
		public Name(string s) : base(s)
		{
			exted_._dotted._main.txt.be.Vow.Singleton.vow(s);
		}

		static public Name CreateByAppendingSubIfNeed(string s)
		{
			return new Name(
				nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(s)
			);
		}
	}
}
