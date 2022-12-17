using nilnul.fs._address;
using System;
using System.IO;

namespace nilnul.fs
{
	/// <summary>
	/// 
	/// </summary>
	public abstract class AddressA1
		:
		AddressI1

	{
		private nilnul.fs._address.VolI _vol;

		public nilnul.fs._address.VolI vol
		{
			get { return _vol; }
			set { _vol = value; }
		}


		public abstract nilnul.fs._address.RouteI1 route
		{
			get;
		}

		public AddressA1(
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
		public static AddressI1 Parse(string s)
		{



			var colonAddress = s.IndexOf(':');
			if (colonAddress < 0)
			{
				throw new nilnul.fs.address_.xpn_.txt_.InvalidException($@"{s} must contain a colon(:), before which is the vol");

			}
			var colonIndexPlus = colonAddress + 1;


			var vol = _address.Vol.Parse_fromTrimmed(s.Substring(0, colonIndexPlus));

			_address.RouteI1 route = _address.RouteA1.Parse(s.Substring(2));


			switch (route)
			{
				case _address.route_.StemI1 stem:
					return new address_.Shield1(vol, stem);
				case _address.route_.SprigI1 sprig:
					return new address_.Spear1(vol, sprig);
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}

		}

		public static AddressI1 Ov(FileSystemInfo fileSystemInfo)
		{
			if (fileSystemInfo is System.IO.DirectoryInfo)
			{
				return (nilnul.fs.address_.Shield1)(fileSystemInfo as System.IO.DirectoryInfo);
			}
			else if (fileSystemInfo is System.IO.FileInfo)
			{
				return (nilnul.fs.address_.Spear1)(fileSystemInfo as System.IO.FileInfo);
			}
			throw new UnexpectedTypeException();
		}

		public static AddressI1 Ov(VolI vol, RouteI1 route)
		{
			switch (route)
			{
				case nilnul.fs._address.route_.StemI1 stem:
					return new address_.Shield1(vol, stem);
				case _address.route_.SprigI1 sprig:
					return new address_.Spear1(vol, sprig);

				default:
					return Ov(
						vol
						,
						_address.RouteA1.Parse(route.ToString())
					);
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}

		public static AddressI1 OvDiskRoute(string _disk, string route)
		{
			return Ov(
				 Vol.OvDisk(_disk), nilnul.fs._address.RouteA1.Parse(route)
			);
		}
	}
}
