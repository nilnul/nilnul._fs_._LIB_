using System;

namespace nilnul.fs.address.be_
{
	public class Spear : BeA, BeI
	{
		public override bool be(AddressI obj)
		{
			return nilnul.fs._address.route.be_.Open.Singleton.be(obj.route);
			//throw new NotImplementedException();
		}


		static public Spear Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Spear>' is obsolete
				return nilnul._obj.Singleton<Spear>.Instance;
#pragma warning restore CS0612 // 'Singleton<Spear>' is obsolete
			}
		}

	}
}
