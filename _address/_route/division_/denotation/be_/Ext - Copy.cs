using System;

namespace nilnul.fs._address.document.be_
{
	[Obsolete()]
	public class Ext :
		nilnul.obj.Box<nilnul.fs._address.doc.be_.Ext>
		,
		BeI
	{

		public Ext(doc_._exted.ExtI val) : this(new nilnul.fs._address.doc.be_.Ext(val))
		{
		}

		public Ext(doc_._exted.Ext val) : this(new nilnul.fs._address.doc.be_.Ext(val))
		{
		}

		public Ext(nilnul.fs._address.doc.be_.Ext val) : base(val)
		{
		}
		public Ext(string ext) : this(new doc_._exted.Ext(ext))
		{

		}


		public bool be(DocumentI obj)
		{
			return boxed.be(obj.doc.ToString());
		}
	}
}
