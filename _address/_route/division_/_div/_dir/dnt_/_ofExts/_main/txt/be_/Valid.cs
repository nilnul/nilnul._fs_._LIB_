using System;

namespace nilnul.fs._address.doc_._ofExts._main.txt.be_
{

	static public class _ValidX
	{

		static public nilnul.txt.be_.NotContain Excluded = new nilnul.txt.be_.NotContain(
			new nilnul.character_.cha.collection_.Union(
				_address._dst._denote.txt.be_._valid.cha_.Invalids.Lazy
				,
				new nilnul.character_.cha.collection_.Set('.')
			)
		);


	}
	/*extern alias obj;*/
	public class Valid :
		//doc_._noDot.txt.be_.Valid, // not same as here we can have ""

		/*obj::*/nilnul.obj.BeI1<string>, nilnul.txt.BeI
	{


		public bool be(string obj)
		{
			return _ValidX.Excluded.be(obj);
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
	}
}
