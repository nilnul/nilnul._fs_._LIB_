using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield.vow.ee_
{
	public class VowDefault1<TVow> : Ee1
		where TVow : shield.VowI2, new()
	{
		public VowDefault1(ShieldI1 val) : base(
			val
			, 
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
