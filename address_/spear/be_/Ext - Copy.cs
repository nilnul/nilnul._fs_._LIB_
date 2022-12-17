using System;

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

		public Ext(_address.doc_._exted.ExtI ext) : this(new _address.route_.sprig.be_.Ext(ext))
		{
		}

		public Ext(_address.doc_._exted.Ext ext) : this(new _address.route_.sprig.be_.Ext(ext))
		{
		}

		public Ext(string extWithDot) : this(new _address.route_.sprig.be_.Ext(extWithDot))
		{

		}

		public bool be(SpearI obj)
		{
			return boxed.be(obj.sprig);
			//throw new NotImplementedException();
		}

	}
}
