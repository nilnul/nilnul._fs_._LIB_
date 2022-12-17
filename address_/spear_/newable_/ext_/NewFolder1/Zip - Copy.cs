using nilnul.fs.address_.spear.be_.ext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear_.newable_.ext_
{
	[Obsolete()]
	public class Zip : spear_.newable_.Ext
	{
		public Zip(SpearI val) : base(val, new spear.be_.ext.Vow( ".zip" ))
		{
		}

		public Zip(Spear address) : base(address,  new spear.be_.ext.Vow(".zip"))
		{
		}

		

		public Zip(string address) : base(address, ".zip")
		{
		}
	}
}
