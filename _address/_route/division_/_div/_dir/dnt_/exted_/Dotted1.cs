using nilnul.fs._address._dst;

namespace nilnul.fs._address.doc_.exted_
{
	/// <summary>
	/// name and ext
	/// </summary>
	public class Dotted
		:


		DottedOrNoI
	{


		public _address.doc_._exted.Main main;
		public doc_._exted.ext_.OvAftDot extOvAftDot;


		public Denote denote => new Denote(this.ToString());

		public Dotted(
			_address.doc_._exted.Main name,
			doc_._exted.ext_.OvAftDot extMember
		)
		{
			this.main = name;
			this.extOvAftDot = extMember;
		}



		public Dotted(string main, string ext)
			: this(
				new _address.doc_._exted.Main(main)
				 ,
				new _address.doc_._exted.ext_.OvAftDot(ext)
			)
		{

		}
		public Dotted(_address.doc_._exted.Main main, string ext)
			: this(
				main
				 ,
				new doc_._exted.ext_.OvAftDot(ext)
			)
		{

		}

		public Dotted(string docMain, doc_._exted.ext_.OvAftDot ext1) : this(new _address.doc_._exted.Main(docMain), ext1)
		{
		}

		public override string ToString()
		{
			return $"{main}{extOvAftDot}";
		}



		static public Dotted Parse(string all)
		{

			var split = all.LastIndexOf('.');
			return new Dotted(all.Substring(0, split), all.Substring(split + 1));
		}




	}
}
