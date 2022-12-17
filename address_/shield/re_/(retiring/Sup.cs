using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.re_
{
	/// <summary>
	/// one including the other
	/// </summary>
	/// 
	[Obsolete()]
	public class Sup:ReI
	{
		

		public bool re(ShieldI a, ShieldI b)
		{
			if (nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol))
			{
				return nilnul.fs._address.route_.stem.re_.Sup1.Singleton.re(
					a.stem, b.stem
				);
			}

			return false;
			//throw new NotImplementedException();
		}


		static public Sup Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Sup>.Instance;
			}
		}


	}
}
