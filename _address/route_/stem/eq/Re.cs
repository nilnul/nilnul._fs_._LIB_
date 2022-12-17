using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.route_.stem.eq
{
	public class Ne:nilnul.obj.eq.Ne<StemI, stem.Eq>
	{

		static public Ne Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Ne>.Instance;
			}
		}

	}
}
