using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div.co_
{
	[Obsolete()]
	public class Concat1 : CoI1
	{
		public DivI1 op(DivI1 arg, DivI1 arg1)
		{
			return new Div1(
				new dir.str_.Enumable
				(arg.dirs.Concat(arg1.dirs))
			);
			//throw new NotImplementedException();
		}

		public DivI1 op(DivI1 arg, DirI1 arg1)
		{
			return op(
				arg, new Div1( arg1)
			);
			//throw new NotImplementedException();
		}

		



		static public Concat1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Concat1>.Instance;
			}
		}

		

		public DivI1 op(DivI1 div, DocI doc)
		{
			return op(
				div,
				new _address.Dir1(doc)

			);
			throw new NotImplementedException();
		}
	}
}
