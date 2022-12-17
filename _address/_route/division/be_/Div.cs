using System;

namespace nilnul.fs._address.division.be_
{
	[Obsolete(nameof(_route.division.be_))]
	public class Div : BeI
	{
		public bool _be(DivisionI division)
		{
			if (division is _address.Div)
			{
				return true;
			}
			if (division is _address.Document)
			{
				return false;
			}
			throw new UnexpectedTypeException();


		}

	



		public bool be(DivisionI division)
		{

			if (division is _address.Div || division is _address.Document)
			{
				return _be(division);
			}
			else
			{
				return _be(
					DivisionA.Parse(division.ToString())
				);

			}



		}





		static public Div Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Div>.Instance;
			}
		}

	}
}
