using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address._dst.name.be_.valid;

namespace nilnul.fs._address.doc_
{
	[Obsolete()]
	public class MainExt : DocI1
	{
		private nilnul.fs._address._doc.Main _main;

		public nilnul.fs._address._doc.Main main
		{
			get { return _main; }
			set { _main = value; }
		}

		private nilnul.fs._address._doc.Ext _ext;

		public nilnul.fs._address._doc.Ext ext
		{
			get { return _ext; }
			set { _ext = value; }
		}

		public MainExt( nilnul.fs._address._doc.Main main, nilnul.fs._address._doc.Ext ext)
		{
			_main = main;
			_ext = ext;
		}

		public MainExt( nilnul.fs._address._doc.Main main):this(main, new _doc.Ext())
		{
			
		}

	

		public MainExt(string main,  nilnul.fs._address._doc.Ext ext):this( new _doc.Main(main),ext)
		{

		}

		public MainExt(nilnul.fs._address._doc.Main main,  string ext):this( main,new _doc.Ext( ext))
		{

		}

		public MainExt(string main,  string ext):this( main,new _doc.Ext( ext))
		{

		}

		static public MainExt FroMain(string main) {
			return new MainExt(
				new nilnul.fs._address._doc.Main(main)
			);
		}

		static public MainExt Fro(DottedOrNoI dottedOrNo)
		{
			switch (dottedOrNo)
			{
				case doc_.NoDot1 nodot:
					return FroMain(nodot.ToString());
					break;
				case doc_.Dotted1 dotted:
					return new MainExt(dotted.main.ToString(), dotted.ext.ToString());

					break;

				default:
					throw new UnexpectedTypeException(
						$"{nameof(DottedOrNoI)}:{dottedOrNo} is not {nameof(NoDot1)}, {nameof(Dotted1)}"
					);
					break;
			}
		}

		static public MainExt Parse(string s) {
			return Fro( DottedOrNoIX.Parse( s ));
		}
		static public MainExt Fro(nilnul.fs._address.DocI1 doc) 
		{

			return Fro( DottedOrNoIX.Fro(doc) );
		}


		public override string ToString()
		{
			return $"{_main}{_ext}";
		}

		public En name => new En(ToString());
	}

	
}
