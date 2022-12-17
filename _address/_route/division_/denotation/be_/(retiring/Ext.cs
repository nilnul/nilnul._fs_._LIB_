using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address._doc;
using nilnul.fs._address.doc.be_;

namespace nilnul.fs._address.document.be_
{
	static public class _ExtX
	{
		
	}
	[Obsolete()]
	public class Ext :
		nilnul.Box1<nilnul.fs._address.doc.be_.Ext1>
		,
		BeI
	{


		public Ext(_doc.Ext val) : this( new nilnul.fs._address.doc.be_.Ext1(val))
		{
		}

		public Ext(nilnul.fs._address.doc.be_.Ext1 val) : base(val)
		{
		}

		

		public bool be(DocumentI3 obj)
		{
			return boxed.be(obj.doc);
		}
	}
}
