using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div.combine_
{
	[Obsolete(nameof(co_.Concat))]
	public class Concat : CombineI
	{
		public DivI eval(DivI arg, DivI arg1)
		{
			return new Div(
				dirs.co_.Concat.Singleton.op(arg.dirs,arg1.dirs)
			);
			throw new NotImplementedException();
		}


		static public Concat Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Concat>.Instance;
			}
		}



	}
}
