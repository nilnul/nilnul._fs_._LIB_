using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield
{
	/// <summary>
	/// if it's not occupied, return the path; whether the path is absolute or relative? we need investigation.
	/// </summary>
	static public class _TgtX
	{


		static public string Tgt(ShieldI shield)
		{

			if (
				nilnul.fs.address_.shield.be_.Occupied.Singleton.be(shield)
			)
			{
				return nilnul.fs.location._TgtX.TgtAsTxt(shield);
			}

			return shield.ToString();
		}



	}


}
