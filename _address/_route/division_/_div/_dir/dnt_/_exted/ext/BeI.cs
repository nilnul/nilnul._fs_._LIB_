namespace nilnul.fs._address._route.division_._div._dir.dnt_._exted.ext
{

	public interface BeI : nilnul.obj.BeI1<ExtI>
	{
	}

	public abstract class BeA : BeI, nilnul.txt.BeI
	{
		public abstract bool be(ExtI obj);
		public virtual bool be(Ext obj)
		{
			return be((ExtI)obj);
		}

		public bool be(string x)
		{
			return be(new Ext(x));
		}
	}
}
