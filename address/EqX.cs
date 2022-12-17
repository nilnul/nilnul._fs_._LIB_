using System.Collections.Generic;

namespace nilnul.fs.address
{

	static public class EqX
	{


		static public bool Eq(this nilnul.fs.address.EqI eq, AddressI x, string y)
		{
			return eq.Equals(x, nilnul.fs.AddressA.Parse(y));

		}



		static public bool Eq(this nilnul.fs.address.EqI eq, string y, AddressI x)
		{
			return Eq(eq, x, y);

		}








	}
}
