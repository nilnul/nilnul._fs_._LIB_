using System.Collections.Generic;

namespace nilnul.fs.address
{
	public interface EqI : IEqualityComparer<AddressI> { }

	public class Eq :EqI
	{


		public bool Equals(AddressI x, AddressI y)
		{
			return nilnul.fs._address.vol.Eq.Singleton.Equals(x.vol, y.vol)
				&&
				nilnul.fs._address.route.Eq.Singleton.Equals(x.route, y.route)
			;

		}

		public bool Equals(string x, string y)
		{
			return Equals(
				AddressA.Parse(x), AddressA.Parse(y)
			);
		}



		public int GetHashCode(AddressI obj)
		{

			return nilnul.fs._address.vol.Eq.Singleton.GetHashCode(obj.vol) & nilnul.fs._address.route.Eq.Singleton.GetHashCode(obj.route);

		}


		static public Eq Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Eq>.Instance;
			}
		}





	}
}
