namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext_._nonempty.aftDot._be.cha_
{

	public class Invalids : nilnul.character_.cha.CollectionI
	{



		//{
		//	static public nilnul.character_.cha.Set1 Set = nilnul.character_.cha.set.op_.binary_.Union.Singleton.op(
		//		_dst._denote.txt.be_._valid.cha_.Invalids.Set
		//		,
		//		new character_.cha.Set1('.')
		//	);

		//	static public IEnumerable<char> PathInvalidsWithDot = System.IO.Path.GetInvalidPathChars().Concat(new[] { '.' });

		public bool contain(char element)
		{
			return _dir._dnt.txt.be_._valid.cha_.Invalids.Singleton.contain(element)
				||
				element == '.';

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
