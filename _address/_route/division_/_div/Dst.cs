using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address
{
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	/// 
	[Obsolete()]
	public class Dst:
		_dst.name.be_.Valid.En
		,
		DstI
	{


		public Dst(string s)
			:base(s)
		{

		}

		[Obsolete()]

		static public Dst Parse(string x)
		{
			return new Dst(
					x.Substring(0, x.Length - 1)
			);
		}

		




	}
}
