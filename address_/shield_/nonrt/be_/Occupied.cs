using System;

namespace nilnul.fs.address_.shield_.nonRt.be_
{
	/// <summary>
	/// creatable
	/// </summary>
	public class Occupied : BeI
	{
		public bool be(NonRtI obj)
		{
			return nilnul.fs.address_.spear.be_.Occupied.Singleton.be(cast_._SpearX.Spear(obj));
			//throw new NotImplementedException();
		}


		static public Occupied Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Occupied>.Instance;
			}
		}

		public bool be(ShieldI obj)
		{
			return be(new NonRt(obj) );
			throw new NotImplementedException();
		}
	}
}
