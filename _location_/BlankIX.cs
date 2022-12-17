namespace nilnul.fs._location_
{
	static public class BlankIX
	{


		static public _location_.BlankI Create(System.IO.FileSystemInfo fileSystemInfo)
		{

			return FroAddress(fileSystemInfo.FullName);
		}

		static public _location_.BlankI Fro(nilnul.fs.AddressI address)
		{



			return Fro(nilnul.fs.address_._location_.BlankIX.FroAddress(address));

		}

		static public _location_.BlankI Fro(nilnul.fs.address_._location_.BlankI address)
		{


			switch (address)
			{
				case nilnul.fs.address_.spear_.Occupied spear:
					return new nilnul.fs.File(spear.en);

				case nilnul.fs.address_.shield_.Exist folder:
					return new nilnul.fs.Folder(folder);

				default:
					throw new UnexpectedTypeException(
						$"{address.GetType()} of {address} is not in ({nameof(nilnul.fs.address_.spear_.Occupied)}, {nameof(nilnul.fs.address_.shield_.Exist)}  )"
					);
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}

		}



		static public _location_.BlankI FroAddress(string address)
		{
			return Fro(
				nilnul.fs.AddressA.Parse(address)
			);

		}


	}
}
