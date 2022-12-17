using System;

namespace nilnul.fs._address.doc_._exted.ext_._ovAftDot.aftDot
{
	[Obsolete()]
	public class Be
		: nilnul.txt.BeI
	{


		static nilnul.txt.be_.NotContain NotContain = new nilnul.txt.be_.NotContain(_be.InvalidChaS.Singleton);

		public bool be(string obj)
		{
			return NotContain.be(obj);
			//throw new NotImplementedException();
		}


		static public Be Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Be>.Instance;
			}
		}



		static private Lazy<Be> _Lazy = new Lazy<Be>();
		static public Be Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
