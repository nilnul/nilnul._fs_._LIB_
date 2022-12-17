using nilnul.fs._address._route.division_._div._dir.dnt.be;

namespace nilnul.fs._address._route.division_._div._dir.dnt.be_
{
	/// <summary>
	/// Dot is regarded as with extension "";
	/// </summary>
	public class Ext
		:
		nilnul.Box1<nilnul.fs._address._route.division_._div._dir.dnt_._exted.ExtI>
		,
		nilnul.fs._address._route.division_._div._dir.dnt.BeI
	{

		public Ext(dnt_._exted.ExtI val) : base(val)
		{
		}
		public Ext(dnt_._exted.Ext val) : base(val)
		{
		}
		public Ext(string s) : this(new dnt_._exted.Ext(s))
		{
		}
		public Ext(doc_._exted.ExtI val) : this(
			dnt_._exted.Ext.Of(
			val
			)
		)
		{
		}
		public Ext(doc_._exted.Ext val) : this((doc_._exted.ExtI) val)
		{
		}


		static public Ext CreateByPrependDot(string x)
		{
			return new Ext($".{x}");
		}
		public bool be(DntI obj)
		{
			return dnt_._exted.ext.Eq.Singleton.Equals(
				boxed
				,
				dnt_._exted._ExtX.Ext(obj)
			);

		}

		public bool be(DocI obj)
		{
			return be(dnt._RegressionsX.ToNew(obj));
			//throw new NotImplementedException();
		}
		public bool be(Doc obj)
		{
			return be((DocI)obj);
		}

		public bool be(string doc)
		{
			return this.Be(doc);
		}
	}
}
