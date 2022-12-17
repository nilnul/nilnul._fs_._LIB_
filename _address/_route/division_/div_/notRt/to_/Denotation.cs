using System;
using System.Linq;

namespace nilnul.fs._address.div_.nonEmpty.to_
{
	public class Denotation : nilnul.obj._cast_.ParRet<NonEmptyI, _address.Denotation>
		, nonEmpty.ToI<_address.Denotation>
	{
		public _address. Denotation op(NonEmptyI input)
		{
			return to(input);
			//throw new NotImplementedException();
		}

		public _address. Denotation to(DivI div)
		{
			return op(
				 NonEmpty.Coerce(div)
			);
			//throw new NotImplementedException();
		}

		public _address.Denotation to(NonEmptyI input)
		{
			return new _address.Denotation(input.dirs.Take(input.dirs.Count() - 1), input.dirs.Last());

			//throw new NotImplementedException();
		}


		static public Denotation Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Denotation>.Instance;
			}
		}


	}
}
