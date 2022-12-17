using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.be_
{
	public class Occupied
		: nilnul.fs.address_.shield.BeI1
	{
		public bool be(ShieldI obj)
		{

			if (be_.Root.Singleton.be(obj))
			{
				return nilnul.fs.address_.shield_.root.be_._ExistX.Be(obj) ;
			}

			return nilnul.fs.address_.shield_.nonRt.be_.Occupied.Singleton.be(obj);

		}


		public bool be_ofAddress(string obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}




		static public Occupied Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Occupied>.Instance;
			}
		}




	}
}
