using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address._doc;
using nilnul.fs._address.route_.sprig.be_;

namespace nilnul.fs.address_.spear.be_
{
	[Obsolete()]
	public class Ext :
		nilnul.Box1<nilnul.fs._address.route_.sprig.be_.Ext>
		,
		nilnul.fs.address_.spear.BeI
	{
		public Ext(_address.route_.sprig.be_.Ext val) : base(val)
		{
		}

		public Ext(_address._doc.Ext ext):this( new _address.route_.sprig.be_.Ext(ext))
		{
		}
		//public Ext(string extWithDot):this( new _address.route_.sprig.be_.Ext(extWithDot))
		//{

		//}

		public bool be(SpearI1 obj)
		{
			return boxed.be(obj.sprig);
			//throw new NotImplementedException();
		}

	}
}
