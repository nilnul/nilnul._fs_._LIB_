using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear_.newable_
{
	public class Ext1 : Creatable1
	{
		public Ext1(SpearI1 val, spear.be_.ext.Vow1 ext) : base(val)
		{

			ext.vow(val);
		}

		public Ext1(Spear1 address, spear.be_.ext.Vow1 ext) : base(address)
		{
			ext.vow(address);
		}

		public Ext1(string address, spear.be_.ext.Vow1 ext) : this(new Spear1(address),ext)
		{
		}

		public Ext1(string address, string ext):this(address, new spear.be_.ext.Vow1(ext) )
		{

		}
	}
}
