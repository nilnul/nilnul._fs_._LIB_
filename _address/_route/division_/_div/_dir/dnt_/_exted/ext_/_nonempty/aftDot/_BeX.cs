using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address._doc.ext_._dotted.aftDot
{
	public class _BeX
	{
		static public bool _Be_ofNonEmpty(string _aftDot) {
			if (_aftDot.StartsWith("."))
			{
				return false;
			}
			else
			{
				return ext_._dotted.name.be_.Valid.Lazy.be(_aftDot.Substring(1));
			}
		}
	}
}
