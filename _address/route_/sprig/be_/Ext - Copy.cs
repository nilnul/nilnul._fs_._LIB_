using System;

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

		public Ext(doc_._exted.Ext ext) : this(new document.be_.Ext(ext))
		{
		}
		public Ext(doc_._exted.ExtI ext) : this(new document.be_.Ext(ext))
		{
		}


		public Ext(string extWithDot) : this(new document.be_.Ext(extWithDot))
		{

		}

		public bool be(SprigI obj)
		{
			return boxed.be(obj.document);
			//throw new NotImplementedException();
		}
	}
}
