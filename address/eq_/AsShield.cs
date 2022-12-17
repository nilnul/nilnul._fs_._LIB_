using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.eq_
{
	public class AsShield : EqI //, IEqualityComparer<nilnul.fs.AddressI>
	{
		public bool Equals(AddressI x, AddressI y)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.Equals(
				nilnul.fs.address_.Shield.Ov(x)

				,
				nilnul.fs.address_.Shield.Ov(y)
			);

		}

		public int GetHashCode(AddressI obj)
		{
			return nilnul.fs.address_.shield.Eq.Singleton.GetHashCode(
				nilnul.fs.address_.Shield.Ov(obj)

			);


		}


		static public AsShield Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<AsShield>.Instance;
			}
		}

	}
}
