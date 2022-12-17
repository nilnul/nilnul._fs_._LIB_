using System;

namespace nilnul.fs._address.doc.be_
{
	/// <summary>
	/// Dot is regarded as with extension "";
	/// </summary>
	///
	[Obsolete()]
	public class Ext
		:
		nilnul.Box1<nilnul.fs._address.doc_._exted.ExtI>
		,
		BeI
	{

		public Ext(doc_._exted.ExtI val) : base(val)
		{
		}
		public Ext(doc_._exted.Ext val) : base(val)
		{
		}
		public Ext(string s) : this(new doc_._exted.Ext(s))
		{
		}

		static public Ext CreateByPrependDot(string x)
		{
			return new Ext($".{x}");
		}

		public bool be(string doc)
		{
			return be(new Doc(doc));
		}
		public bool be(Doc obj)
		{
			return be((DocI)obj);
		}
		public bool be(DocI obj)
		{
			return doc_._exted.ext.Eq.Singleton.Equals(
				boxed
				,
				nilnul.fs._address.doc_.exted._ExtX.Ext(obj)
			);
			//throw new NotImplementedException();
		}
	}
}
