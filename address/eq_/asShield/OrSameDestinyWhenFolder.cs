using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.eq_.asShield
{
	public class OrSameDestinyWhenFolder : EqI //, IEqualityComparer<nilnul.fs.AddressI>
	{
		public bool Equals(AddressI x, AddressI y)
		{
			var shieldEq=nilnul.fs.address.eq_.AsShield.Singleton.Equals(
				(x)

				,
				(y)
			);
			if (shieldEq )
			{
				return shieldEq;
			}

			if (
				nilnul.fs.address.be_.Folder.Singleton.be(x)
				&&
				nilnul.fs.address.be_.Folder.Singleton.be(y)
			)
			{
				return nilnul.fs.folder.eq_.TargetSame.Singleton.Equals(
					new nilnul.fs.Folder(x)
					,
					new nilnul.fs.Folder(y)

				);
			}

			return false;



		}

		public int GetHashCode(AddressI obj)
		{
			return 0;


		}


		static public OrSameDestinyWhenFolder Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<OrSameDestinyWhenFolder>.Instance;
			}
		}

	}
}
