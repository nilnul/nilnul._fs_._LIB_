using System;

namespace nilnul.fs._address.doc_._exted._ext.txt
{
	[Obsolete()]
	public class Be : nilnul.txt.BeI
	{
		static public bool Be_(string x)
		{

			if (x == "")
			{
				return true;
			}
			else
			{
				//nilnul.bit.vow_.true_.Unacceptable.Singleton.vow( );

				return x.StartsWith(".") && ext_._ovAftDot.aftDot.Be.Singleton.be(x.Substring(1));
			}

		}

		public bool be(string obj)
		{
			return Be_(obj);
		}


		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}

	}
}
