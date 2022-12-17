using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.vow.ee_
{
	[Obsolete()]
	public class VowDefault<TVow> : Ee
		where TVow : shield.VowI1, new()
	{
		public VowDefault(ShieldI val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
