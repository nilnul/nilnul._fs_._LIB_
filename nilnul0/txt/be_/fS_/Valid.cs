
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.be_.fs_
{
	public class Valid : nilnul.txt.BeI
	{


		public bool be(string s)
		{

			if (nilnul.obj.be.Anto<string, nilnul.fs._address._dst.be_.Valid>.Singleton.be(s))
			{

				return false;

			}

			var lastDot = s.LastIndexOf(DocNameA.DOT);

			if (lastDot < 0)
			{
				return doc_._noDot.name.be_.Valid.Lazy.be(s);

			}
			else
			{
				return doc_._dotted.name.be_.Valid.Be(
					s.Substring(0, lastDot)
					,
					s.Substring(lastDot+1)
				);
			}
			//throw new NotImplementedException();

		}

		static private Lazy<Valid> _Lazy = new Lazy<Valid>();
		static public Valid Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
