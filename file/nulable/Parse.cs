using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file.nulable
{
	static public class _OvAddressX
	{
		static public nilnul.fs.File NulIfAddressXpn(string address) {

			var a = nilnul.fs.address_.spear.nulable.parse_._Nul4xpnX.SpearNulable(address);
			return a is null ? null : new File(a);

		}
		static public nilnul.fs.File NulIfXpn(string address) {

			try
			{
				return NulIfAddressXpn(address);
			}
			catch (Exception)
			{

				return null;
			};

		}


	}
}
