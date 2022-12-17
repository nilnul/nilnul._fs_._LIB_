namespace nilnul.fs._address._route.division_.denotation.be_
{
	public class Ext :
		nilnul.obj.Box1<nilnul.fs._address._route.division_._div._dir.dnt.be_.Ext>
		,

		nilnul.fs._address._route.division_.denotation.BeI
	{
		public Ext(nilnul.fs._address._route.division_._div._dir.dnt.be_.Ext val) : base(val)
		{
		}

		public Ext(nilnul.fs._address._route.division_._div._dir.dnt_._exted.ExtI val) : this(new nilnul.fs._address._route.division_._div._dir.dnt.be_.Ext(val))
		{
		}

		public Ext(nilnul.fs._address._route.division_._div._dir.dnt_._exted.Ext val) : this(new nilnul.fs._address._route.division_._div._dir.dnt.be_.Ext(val))
		{
		}

		public Ext(string ext) : this(new _address._route.division_._div._dir.dnt_._exted.Ext(ext))
		{

		}


		public bool be(nilnul.fs._address._route.division_.div.DntedI obj)
		{
			return boxed.be(obj.dnt.ToString());
		}
	}
}
