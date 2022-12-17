using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.div.co_
{
	[Obsolete()]
	public class Concat : CoI
	{
		public DivI op(DivI arg, DivI arg1)
		{
			return new Div(
				dirs.co_.Concat.Singleton.op(arg.dirs,arg1.dirs)
			);
			//throw new NotImplementedException();
		}

		public DivI op(DivI arg, DirI arg1)
		{
			return new Div(
				dirs.co_.Concat.Singleton.op(arg.dirs,arg1)
			);
			//throw new NotImplementedException();
		}

		public DivI op(DivI arg, DirI1 arg1)
		{
			return new Div(
				dirs.co_.Concat.Singleton.op(arg.dirs,arg1)
			);
			//throw new NotImplementedException();
		}



		static public Concat Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Concat>.Instance;
			}
		}

		

		public DivI op(DivI div, DocI doc)
		{
			return op(
				div,
				_address.div_._DocX.Fro(doc)

			);
			throw new NotImplementedException();
		}
	}
}
