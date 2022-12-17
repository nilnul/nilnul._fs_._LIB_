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
	static public  class  DstIX
		
	{
		static public DstI1 Parse(string x)
		{
			if (x.EndsWith(_address.Separator.AsTxt))
			{
				return Dir1.Parse(x);

			}

			return new Doc(
					x
			);
		}

	}
}
