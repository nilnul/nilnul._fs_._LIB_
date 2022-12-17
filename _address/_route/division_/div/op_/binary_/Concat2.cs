using System.Linq;

namespace nilnul.fs._address._route.division_.div.op_.binary_
{

	public class Concat : BinaryI
	{
		public DivI op(DivI arg, DivI arg1)
		{
			return new Div(
				
				(arg.Concat(arg1))
			);
			//throw new NotImplementedException();
		}


		public DivI op(DivI arg, _route.division_._div.DirI arg1)
		{
			return op(
				arg, new Div(arg1)
			);
		}
		public DivI op(_route.division_._div. DirI arg, DivI arg1)
		{
			return op(
				new Div(arg), arg1
			);
		}

		public DivI op(_route.division_._div. DirI arg,_route.division_._div. DirI arg1)
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

		public DivI op(DivI div, _route.division_._div._dir.DntI doc)
		{
			return op(
				div,
				new _address._route.division_._div.Dir(doc)

			);
		}


		static public Concat Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Concat>.Instance;
			}
		}
		static public Concat Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Concat>.Instance;
			}
		}




	}
}
