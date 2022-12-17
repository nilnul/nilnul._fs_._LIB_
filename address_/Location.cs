namespace nilnul.fs.address_
{
	public class Location : nilnul.fs.address.be_.location.vow.En
	{
		public Location(AddressI val) : base(val)
		{
		}

		public static Location FroAddress(AddressI val)
		{

			if (nilnul.fs.address.be_.Spear.Singleton.be(val))
			{
				return FroAddress(
					nilnul.fs.address_.spear_._AddressX.Create(val)
				);

			}
			else
			{
				return FroShield(nilnul.fs.address_.Shield.FroAddress(val));
			}


		}
		public static Location FroAddress(nilnul.fs.address_.SpearI val)
		{



			if (nilnul.fs.address_.spear.be_.Occupied.Singleton.be(
				nilnul.fs.address_.spear_._AddressX.Create(val)
			))
			{

				return new Location(val);

			}


			return FroShield(
				nilnul.fs.address_.Shield.FroAddress(val)
			);


		}

		public static Location FroFile(nilnul.fs.address_.spear.be_.occupied.vow.En val)
		{



			return new Location(val.en);


		}
		public static Location FroFile(nilnul.fs.address_.spear_.Occupied val)
		{



			return new Location(val.en);


		}


		public static Location FroShield(nilnul.fs.address_.ShieldI val)
		{


			return FroFolder(new nilnul.fs.address_.shield_.Exist(val));

		}

		public static Location FroFolder(nilnul.fs.address_.shield.be_.exist.vow.En val)
		{


			return new Location(val.en);

		}

		public static Location FroFolder(nilnul.fs.address_.shield_.Exist val)
		{


			return new Location(val.en);

		}




		public static Location FroAddress(string val)
		{
			return FroAddress(
				AddressA.Parse(val)
			 );
		}


	}
}
