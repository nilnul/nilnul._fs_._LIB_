namespace nilnul.fs._address.route_.sprig.be_
{
	public class Exts :
		nilnul.Box1<nilnul.fs._address.document.be_.Exts>
		,
		BeI
	{
		public Exts(document.be_.Exts val) : base(val)
		{
		}




		public Exts(params string[] extWithDot) : base(new document.be_.Exts(extWithDot))
		{

		}

		public Exts(nilnul.fs._address.denote_._exted.ext.Set set ):base(new document.be_.Exts(set))
		{

		}

		public bool be(SprigI obj)
		{
			return boxed.be(obj.document);
			//throw new NotImplementedException();
		}
	}
}
