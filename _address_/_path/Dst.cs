using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path
{
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	public class Dst:
		_dst.name.be_.valid.vow.Ed
		,
		DstI
	{


		public Dst(string s)
			:base(s)
		{

		}

		public string toTxt_endWithSepeartor() {
			return $"{ this }{_SeperatorX.Seperator}";
		}



	}
}
