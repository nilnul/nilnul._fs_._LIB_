using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield._be_
{
	[Obsolete()]
	/*extern alias obj;*/
	public interface ShieldI<T>
		:
		/*obj::*/nilnul.obj.BeI1<T>
		where T:nilnul.fs.address_.ShieldI
	{
	}
}
