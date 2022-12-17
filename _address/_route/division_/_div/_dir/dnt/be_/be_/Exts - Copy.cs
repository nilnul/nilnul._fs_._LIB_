using System;
using System.Collections.Generic;

namespace nilnul.fs._address.doc.be_
{
	/// <summary>
	/// Dot is regarded as with extension "";
	/// </summary>
	///
	[Obsolete(nameof(denote.be_.Exts))]
	public class Exts
		:
		nilnul.Box1<nilnul.fs._address.doc_._exted.ext.Set>
		,
		BeI
	{


		public Exts(IEnumerable<doc_._exted.ExtI> val) : base(new doc_._exted.ext.Set(val))
		{
		}

		public Exts(IEnumerable<string> s) : base(new doc_._exted.ext.Set(s))
		{
		}

		public Exts(params string[] s) : this((IEnumerable<string>)s)
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
	}
}
