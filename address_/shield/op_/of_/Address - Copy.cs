using System;
using System.IO;

namespace nilnul.fs.address_.shield_
{
	[Obsolete()]
	static public class _AddressX1
	{


#pragma warning disable CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		static public Shield Create(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
#pragma warning restore CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		{
			return Create(s.processed);
		}


		static public Shield Create(AddressI address)
		{
			return new Shield(
				address.vol
				,
				fs._address.route_.stem_._RouteX2.Fro(
					address.route
				)
			);
		}




		static public Shield Create(DirectoryInfo address)
		{
			return Create(address.FullName);
		}

		static public Shield Create(string address)
		{
			return Create(nilnul.fs.AddressA.Parse(address));
		}


		static public string Txt(string _address)
		{
			return nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(_address) ? _address : _address + System.IO.Path.DirectorySeparatorChar;
		}


	}
}
