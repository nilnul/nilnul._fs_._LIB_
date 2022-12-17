using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.spear
{
	/// <summary>
	/// tgt is itself if it's not occupied.
	/// is the tgt if it's occupied
	/// </summary>
	static public class _TgtX
	{


		static public string Tgt(SpearI shield)
		{
			if (
				nilnul.fs.address_.spear.be_.Occupied.Singleton.be(shield)
			)
			{

				return nilnul.fs.location._TgtX.TgtAsTxt(shield);
			}
			return shield.ToString();

		}



	}


}
