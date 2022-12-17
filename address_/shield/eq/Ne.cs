using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.eq
{
	public class Ne:nilnul.obj.eq.Ne<ShieldI, shield.Eq>
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
