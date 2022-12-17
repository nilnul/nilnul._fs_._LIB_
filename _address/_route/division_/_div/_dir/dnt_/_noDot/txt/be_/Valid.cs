using System;

namespace nilnul.fs._address.doc_._noDot.txt.be_
{
	/*extern alias obj;*/
	public class Valid :

		/*obj::*/nilnul.obj.BeI1<string>, nilnul.txt.BeI
	{
		//static public IEnumerable<char> chars2exclude = _address._dst._denote.txt.be_._valid.cha_.Invalids.Set.Concat(new[] { '.' });

		static public nilnul.txt.be_.NotContain Excluded = new nilnul.txt.be_.NotContain(
			new nilnul.character_.cha.collection_.Union(
				_address._dst._denote.txt.be_._valid.cha_.Invalids.Lazy
				,
				new nilnul.character_.cha.collection_.Set('.')
			)
		);

		public bool be(string obj)
		{
			return Excluded.be(obj) && obj != "";
			//throw new NotImplementedException();
		}

		static private Lazy<Valid> _Lazy = new Lazy<Valid>();
		static public Valid Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

		public class Aver : nilnul.obj.be.Aver<string, Valid>
		{

			static private Lazy<Aver> _Lazy = new Lazy<Aver>();
			static public Aver Lazy
			{
				get
				{
					return _Lazy.Value;
				}
			}
		}
	}
}
