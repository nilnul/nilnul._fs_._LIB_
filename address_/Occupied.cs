using nilnul.fs._address;

namespace nilnul.fs.address_
{
	public class Occupied : nilnul.fs.address.be_.occupied.vow.Ee
		,nilnul.fs.AddressI
	{
		public Occupied(AddressI val) : base(val)
		{
		}

		public VolI vol => ee.vol;

		public RouteI route => ee.route;

		public static Occupied Fro(AddressI val)
		{

			if (nilnul.fs.address.be_.Spear.Singleton.be(val))
			{
				return Fro(
					nilnul.fs.address_.spear_._AddressX.Create(val)
				);

			}
			else
			{
				return Fro(nilnul.fs.address_.Shield.FroAddress(val));
			}


		}
		public static Occupied Fro(nilnul.fs.address_.SpearI val)
		{



			if (nilnul.fs.address_.spear.be_.Occupied.Singleton.be(
				nilnul.fs.address_.spear_._AddressX.Create(val)
			))
			{

				return new Occupied(val);

			}


			return Fro(
				nilnul.fs.address_.Shield.FroAddress(val)
			);


		}

		public static Occupied Fro(nilnul.fs.address_.spear.be_.occupied.vow.En val)
		{



			return new Occupied(val.en);


		}
		public static Occupied Fro(nilnul.fs.address_.spear_.Occupied val)
		{



			return new Occupied(val.en);


		}


		public static Occupied Fro(nilnul.fs.address_.ShieldI val)
		{


			return Fro(new nilnul.fs.address_.shield_.Exist(val));

		}

		public static Occupied Fro(nilnul.fs.address_.shield.be_.exist.vow.En val)
		{


			return new Occupied(val.en);

		}

		public static Occupied Fro(nilnul.fs.address_.shield_.Exist val)
		{


			return new Occupied(val.en);

		}




		public static Occupied FroAddress(string val)
		{
			return Fro(
				AddressA.Parse(val)
			 );
		}


	}
}
