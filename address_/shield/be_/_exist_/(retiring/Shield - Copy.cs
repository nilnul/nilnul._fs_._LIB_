using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.be_._exist_
{
	public class Shield1<TShield>
		: nilnul.fs.address_.shield._be_.ShieldI1<TShield>

		where TShield:nilnul.fs.address_.ShieldI1
	{
		public bool be(TShield obj)
		{
			return System.IO.Directory.Exists(obj.ToString());

		}



		static public Shield1<TShield> Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Shield1<TShield>>.Instance;
			}
		}



	}
}
