namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.be_
{
	//todo: rename to "Specific"
	/// <summary>
	/// 
	/// </summary>
	public class Ext : nilnul.obj.Box1<nilnul.fs._address._route.division_._div._dir.dnt_._exted.ExtI>
		,
		nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.BeI
	{

		public Ext(nilnul.fs._address._route.division_._div._dir.dnt_._exted.ExtI val) : base(val)
		{

		}
		public Ext(nilnul.fs._address._route.division_._div._dir.dnt_._exted.Ext val) : base(val)
		{

		}


		public Ext(string v):this(
			new nilnul.fs._address._route.division_._div._dir.dnt_._exted.Ext(v)
		)
		{
		}

		public bool be(nilnul.fs._address._route.division_._div._dir.dnt_._exted.ExtI obj)
		{
			return nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext.Eq.Singleton.Equals(boxed, obj);
			//throw new NotImplementedException();
		}

	}
}
