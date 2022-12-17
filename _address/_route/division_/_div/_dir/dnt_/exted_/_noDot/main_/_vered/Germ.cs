namespace nilnul.fs._address.doc_.exted_._noDot.main_._vered
{
	public class Name : nilnul.txt_._vered.Name
	{
		public Name(string s) : base(s)
		{
			_noDot._main.txt.be.Vow.Singleton.vow(s);
		}

		static public Name CreateByAppendingSubIfNeed(string s)
		{
			return new Name(
				nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(s)
			);
		}
	}
}
