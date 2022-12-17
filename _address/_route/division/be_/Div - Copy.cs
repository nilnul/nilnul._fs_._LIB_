using System;

namespace nilnul.fs._address._route.division.be_
{
	public class Div : BeI
	{
		public bool _be(DivisionI division)
		{
			if (division is _address._route.division_.DivI)
			{
				return true;
			}
			return false;

			//if (division is _address._route.division_.IDenotation)
			//{
			//	return false;
			//}
			//throw new UnexpectedTypeException();


		}

	



		public bool be(DivisionI division)
		{

			if (division is _address._route.division_.Div || division is _address._route.division_.IDenotation)
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
