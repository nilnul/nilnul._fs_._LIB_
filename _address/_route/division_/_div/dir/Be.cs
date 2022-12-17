using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dir
{
	public interface BeI: nilnul.obj.BeI1<_address.DirI>
	{

	}
	static public class BeX
	{
		static public bool Be_ofDst(this BeI be, string s) {
			return be.be(
				_address.Dir.OvDst(s)
			);
		}

		static public bool Be_ofDnt(this BeI be, string s) {
			return be.be(
				_address.Dir.OvDenote(s)
			);
		}

		static public bool Be(this BeI be, _address.DstI s) {
			return be.be(
				new _address.Dir(s)
			);
		}
		static public bool Be(this BeI be, _address.IDnt s) {
			return be.be(
				new _address.Dir(s)
			);
		}



	}
}
