namespace nilnul.fs.file.be_
{
	public class Ext :

		nilnul.Box1<nilnul.fs.address_.spear.be_.Ext>
		,
		nilnul.fs.file.BeI
	{
		public Ext(address_.spear.be_.Ext val) : base(val)
		{
		}

		public Ext(_address.doc_._exted.Ext ext) : this(new address_.spear.be_.Ext(ext))
		{
		}

		public Ext(_address.doc_._exted.ExtI ext) : this(new address_.spear.be_.Ext(ext))
		{
		}

		public Ext(string extWithDot) : this(new address_.spear.be_.Ext(extWithDot))
		{

		}

		public bool be(FileI obj)
		{
			return boxed.be(obj.file.en);
		}

		//static public Ext Ov_dotOmitable(string dotOmitable) {

		//}


	}
}
