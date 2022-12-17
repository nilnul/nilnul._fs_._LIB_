using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs
{
	/// <summary>
	/// 
	/// </summary>
	///
	[Obsolete()]
	public abstract class AddressA
		:
		AddressI

	{
		private nilnul.fs._address.VolI _vol;

		public nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			set { _vol = value; }
		}


		public abstract nilnul.fs._address.RouteI route
		{
			get;
		}

		[Obsolete()]
		public AddressA(
			nilnul.fs._address.VolI vol

		)
		{
			_vol = vol;

		}



		public override string ToString()
		{
			return $"{_vol}{route}";
		}


		/// <summary>
		/// spear or shield
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static AddressI Parse(string s)
		{



			var colonAddress = s.IndexOf(':');
			if (colonAddress < 0)
			{
				throw new nilnul.fs.address_.xpn_.txt_.InvalidException($@"{s} must contain a colon(:), before which is the vol");

			}
			var colonIndexPlus = colonAddress + 1;


			var vol = _address.Vol.Parse_fromTrimmed(s.Substring(0, colonIndexPlus));

			_address.RouteI route = _address.RouteA.Parse(s.Substring(2));


			switch (route)
			{
				case _address.route_.StemI stem:
					return new address_.Shield(vol, stem);
				case _address.route_.SprigI sprig:
					return new address_.Spear(vol, sprig);
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}

		}

		public static AddressI Ov(FileSystemInfo fileSystemInfo)
		{
			if (fileSystemInfo is System.IO.DirectoryInfo)
			{
				return (nilnul.fs.address_.Shield)(fileSystemInfo as System.IO.DirectoryInfo);
			}
			else if (fileSystemInfo is System.IO.FileInfo)
			{
				return (nilnul.fs.address_.Spear)(fileSystemInfo as System.IO.FileInfo);
			}
			throw new UnexpectedTypeException();
		}

		public static AddressI Ov(VolI vol, RouteI route)
		{
			switch (route)
			{
				case nilnul.fs._address.route_.StemI stem:
					return new address_.Shield(vol, stem);
				case _address.route_.SprigI sprig:
					return new address_.Spear(vol, sprig);

				default:
					return Ov(
						vol
						,
						_address.RouteA.Parse(route.ToString())
					);
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		public static AddressI OvDiskRoute(string _disk, string route)
		{
			return Ov(
				 Vol.OvDisk(_disk), nilnul.fs._address.RouteA.Parse(route)
			);
		}
	}
}
