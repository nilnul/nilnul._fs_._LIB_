using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.be_._exist_
{
	[Obsolete()]
	public class Shield<TShield>
		: nilnul.fs.address_.shield._be_.ShieldI<TShield>

		where TShield:nilnul.fs.address_.ShieldI
	{
		public bool be(TShield obj)
		{
			return System.IO.Directory.Exists(obj.ToString());

		}



		static public Shield<TShield> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Shield<TShield>>.Instance;
			}
		}



	}
}
