using System;

namespace nilnul.fs.address.be_
{
	public class Shield : BeA, BeI,BeI1
	{
		public override bool be(AddressI obj)
		{
			return nilnul.fs._address.route.be_.Closed.Singleton.be(obj.route);

			//throw new NotImplementedException();
		}


		public  bool be(AddressI1 obj)
		{
			return nilnul.fs._address.route.be_.Closed.Singleton.be(obj.route);

			//throw new NotImplementedException();
		}


		static public Shield Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Shield>.Instance;
			}
		}

	}
}
