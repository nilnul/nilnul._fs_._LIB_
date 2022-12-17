using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div.co_
{
	[Obsolete()]
	public class Concat2 : CoI2
	{
		public DivI op(DivI arg, DivI arg1)
		{
			return new Div(
				new dir.str_.Enumable1
				(arg.dirs.Concat(arg1.dirs))
			);
			//throw new NotImplementedException();
		}

		public DivI op(DivI arg, DirI arg1)
		{
			return op(
				arg, new Div( arg1)
			);
			//throw new NotImplementedException();
		}

		



		static public Concat2 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Concat2>.Instance;
			}
		}

		

		public DivI op(DivI div, DocI1 doc)
		{
			return op(
				div,
				new _address.Dir(doc)

			);
			throw new NotImplementedException();
		}
	}
}
