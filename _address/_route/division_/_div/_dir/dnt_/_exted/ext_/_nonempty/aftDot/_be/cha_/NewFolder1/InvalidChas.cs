using System;

namespace nilnul.fs._address.doc_._exted.ext_._ovAftDot.aftDot._be
{

	[Obsolete()]
	public class InvalidChaS : nilnul.character_.cha.CollectionI
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
			return _dst._denote.txt.be_._valid.cha_.Invalids.Lazy.contain(element)
				||
				element == '.';

		}

		static public InvalidChaS Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<InvalidChaS>.Instance;
			}
		}

	}
}
