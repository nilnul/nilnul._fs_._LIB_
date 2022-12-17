using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.container.re_
{
	/// <summary>
	/// one including the other
	/// </summary>
	/// 
	[Obsolete()]
	public class Sup:ReI
	{
		

		public bool re(ContainerI1 a, ContainerI1 b)
		{
			if (nilnul.fs._address.vol.Eq.Singleton.Equals(a.vol, b.vol))
			{
				return nilnul.fs._address.route_.stem.re_.Sup.Singleton.re(
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
				return nilnul.obj.SingletonByDefault<Sup>.Instance;
			}
		}

	}
}
