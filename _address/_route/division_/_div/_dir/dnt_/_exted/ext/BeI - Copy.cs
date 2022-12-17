using System;

namespace nilnul.fs._address.doc_._exted.ext
{

	[Obsolete()]
	public interface BeI : nilnul.obj.BeI1<ExtI>
	{
	}

	[Obsolete()]
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
