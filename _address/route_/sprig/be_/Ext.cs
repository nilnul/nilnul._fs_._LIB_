namespace nilnul.fs._address.route_.sprig.be_
{
	public class Ext1 :
		nilnul.obj.Box1<nilnul.fs._address._route.division_.denotation.be_.Ext>
		,
		BeI1
	{
		public Ext1(_route.division_.denotation.be_.Ext val) : base(val)
		{
		}
		public Ext1(_route.division_._div._dir.dnt_._exted.Ext val) : this(new _route.division_.denotation.be_.Ext(val) )
		{
		}

	
		public Ext1(_route.division_._div._dir.dnt_._exted.ExtI ext) : this(new _route.division_.denotation.be_.Ext(ext))
		{
		}


		public Ext1(string extWithDot) : this(new _route.division_._div._dir.dnt_._exted.Ext(extWithDot))
		{

		}

		public bool be(SprigI1 obj)
		{
			return boxed.be(obj.denotation);
			//throw new NotImplementedException();
		}
	}
}
