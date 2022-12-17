using nilnul.fs._address._dst;
using System.Collections.Generic;

namespace nilnul.fs._address.denote.be_
{
	/// <summary>
	/// Dot is regarded as with extension "";
	/// </summary>
	public class Exts
		:
		nilnul.Box1<nilnul.fs._address.denote_._exted.ext.Set>
		,
		nilnul.fs._address.doc.BeI
		,
		nilnul.fs._address.denote.BeI
	{


		public Exts(IEnumerable<doc_._exted.ExtI> val) : base(new denote_._exted.ext.Set(val))
		{
		}

		public Exts(IEnumerable<string> s) : base(new denote_._exted.ext.Set(s))
		{
		}

		public Exts(params string[] s) : this((IEnumerable<string>)s)
		{

		}
		public Exts(nilnul.fs._address.denote_._exted.ext.Set set):base( (set) )
		{

		}


		//public bool be(string doc) {
		//	return be(new Doc(doc));
		//}
		public bool be(Doc obj)
		{
			return be((DocI)obj);
		}
		public bool be(DocI obj)
		{
			return boxed.Contains(

				nilnul.fs._address.doc_.exted._ExtX.Ext(obj)
			);
			//throw new NotImplementedException();
		}

		public bool be(Denote obj)
		{
			return boxed.Contains(nilnul.fs._address.denote_.exted._ExtX.Ext(obj));
		}
	}
}
