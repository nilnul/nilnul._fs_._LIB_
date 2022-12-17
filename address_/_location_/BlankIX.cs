namespace nilnul.fs.address_._location_
{
	static public class BlankIX
	{


		public static _location_.BlankI FroAddress(AddressI val)
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
		public static _location_.BlankI FroAddress(nilnul.fs.address_.SpearI val)
		{

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(
				nilnul.fs.address_.spear_._AddressX.Create(val)
			))
			{

				return new nilnul.fs.address_.spear_.Occupied(val);

			}


			return FroShield(
				nilnul.fs.address_.Shield.FroAddress(val)
			);


		}

		public static _location_.BlankI FroFile(nilnul.fs.address_.spear.be_.occupied.vow.En val)
		{



			return new spear_.Occupied(val.en);


		}
		//public static _location_.BlankI FroFile(nilnul.fs.address_.spear_.Exist val)
		//{



		//	return new BlankX(val.en);


		//}


		public static _location_.BlankI FroShield(nilnul.fs.address_.ShieldI val)
		{


			return new nilnul.fs.address_.shield_.Exist(val);

		}

		public static _location_.BlankI FroFolder(nilnul.fs.address_.shield.be_.exist.vow.En val)
		{


			return new shield_.Exist(val.en);

		}

		//public static BlankX FroFolder(nilnul.fs.address_.shield_.Exist1 val)
		//{


		//	return new BlankX(val.en);

		//}




		public static _location_.BlankI FroAddress(string val)
		{
			return FroAddress(
				AddressA.Parse(val)
			 );
		}


	}
}
