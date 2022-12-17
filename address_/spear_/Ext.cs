using nilnul.fs._address;
using nilnul.fs._address.route_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear_
{
	public class Ext :
		nilnul.fs.address_.spear.vow.Ee
		,
		nilnul.fs.address_.SpearI
	{
		

		public Ext(SpearI val, spear.be_.ext.Vow ext) : base(val,ext)
		{

		}

		public Ext(Spear address, spear.be_.ext.Vow ext) : base(address,ext)
		{
			ext.vow(address);
		}

		public Ext(string address, spear.be_.ext.Vow ext) : this(new Spear(address),ext)
		{
		}

		public Ext(string address, string ext):this(address, new spear.be_.ext.Vow(ext) )
		{

		}

		public SprigI sprig => this.ee.sprig;

		public VolI vol => this.ee.vol;

		public RouteI route => this.sprig;
	}
}
