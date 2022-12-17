using System;
using System.Linq;

namespace nilnul.fs._address.div.op_.binary_
{

	[Obsolete()]
	public class Concat : BinaryI
	{
		public DivI op(DivI arg, DivI arg1)
		{
			return new Div(
				new dir.str_.Seq
				(arg.dirs.Concat(arg1.dirs))
			);
			//throw new NotImplementedException();
		}


		public DivI op(DivI arg, DirI arg1)
		{
			return op(
				arg, new Div(arg1)
			);
		}
		public DivI op(DirI arg, DivI arg1)
		{
			return op(
				new Div(arg), arg1
			);
		}

		public DivI op(DirI arg, DirI arg1)
		{
			return op(
				new Div(arg)
				,
				arg1
			);
		}
		//public DivI op(DirectoryI arg, DirI arg1)
		//{
		//	return op(
		//		new Div(arg)
		//		,
		//		arg1
		//	);
		//}

		public DivI op(DivI div, DocI doc)
		{
			return op(
				div,
				new _address.Dir(doc)

			);
		}

		static public Concat Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Concat>.Instance;
			}
		}


	}
}
