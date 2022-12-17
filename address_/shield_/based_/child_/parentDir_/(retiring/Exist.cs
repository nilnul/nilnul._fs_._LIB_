using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shield_.baseDir_
{
	[Obsolete()]
	public class Exist : 
		nilnul.fs.address_.shield.be_.exist.vow._en_.Shield<BaseChild>

	{
		public Exist(BaseChild val) : base(val)
		{
		}

		static public implicit operator shield_.Exist(Exist me) {
			return new shield_.Exist(me.en);
		}
	}
}
