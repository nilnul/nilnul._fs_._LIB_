using System.IO;

namespace nilnul.fs.address_.shield.op_.of_
{
	static public class _AddressX
	{


#pragma warning disable CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		static public Shield1 Create(nilnul.txt.op_.trim.ed_.WhiteTrimmed s)
#pragma warning restore CS0618 // 'WhiteTrimmed' is obsolete: 'Ed'
		{
			return Create(s.processed);
		}


		static public Shield1 Create(AddressI1 address)
		{
			return new Shield1(
				address.vol
				,
				fs._address.route_.stem.op_.of_._RouteX2.Fro(
					address.route
				)
			);
		}




		static public Shield1 Create(DirectoryInfo address)
		{
			return Create(address.FullName);
		}

		static public Shield1 Create(string address)
		{
			return Create(nilnul.fs.AddressA1.Parse(address));
		}


		static public string Txt(string _address)
		{
			return nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(_address) ? _address : _address + System.IO.Path.DirectorySeparatorChar;
		}


	}
}
