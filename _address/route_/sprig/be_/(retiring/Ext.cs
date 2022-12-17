using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address._doc;
using nilnul.fs._address.document.be_;

namespace nilnul.fs._address.route_.sprig.be_
{
	[Obsolete()]
	public class Ext :
		nilnul.Box1<nilnul.fs._address.document.be_.Ext>
		,
		BeI
	{
		public Ext(document.be_.Ext val) : base(val)
		{
		}

		public Ext(_doc.Ext ext):this(new document.be_.Ext(ext))
		{
		}

		

	

		public bool be(SprigI2 obj)
		{
			return boxed.be(obj.document);
			//throw new NotImplementedException();
		}
	}
}
