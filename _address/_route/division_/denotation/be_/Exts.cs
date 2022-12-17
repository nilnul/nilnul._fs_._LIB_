using System.Collections.Generic;

namespace nilnul.fs._address.document.be_
{
	public class Exts :
		nilnul.obj.Box<nilnul.fs._address.denote.be_.Exts>
		,
		BeI
	{

		public Exts(IEnumerable<doc_._exted.ExtI> val) : base(new denote.be_.Exts(val))
		{
		}



		public Exts(nilnul.fs._address.doc.be_.Exts val) : base(new denote.be_.Exts( val.boxed ))
		{
		}
		public Exts(IEnumerable<string> ext) : base(new nilnul.fs._address.denote.be_.Exts(ext))
		{

		}



		public bool be(DocumentI obj)
		{
			return boxed.be(obj.doc);
		}
	}
}
