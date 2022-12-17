using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear_.newable_
{
	[Obsolete()]
	public class Ext : Creatable
	{
		public Ext(SpearI val, spear.be_.ext.Vow ext) : base(val)
		{

			ext.vow(val);
		}

		public Ext(Spear address, spear.be_.ext.Vow ext) : base(address)
		{
			ext.vow(address);
		}

		public Ext(string address, spear.be_.ext.Vow ext) : this(new Spear(address),ext)
		{
		}

		public Ext(string address, string ext):this(address, new spear.be_.ext.Vow(ext) )
		{

		}
	}
}
