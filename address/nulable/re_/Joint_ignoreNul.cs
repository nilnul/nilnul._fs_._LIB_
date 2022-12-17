using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address.nulable.re_
{
	/// <summary>
	/// ignore whitespace lines
	/// </summary>
	public class Joint_ignoreNul
		:nilnul.fs.address.nulable.ReI
	{

	

		public bool re(AddressI a, AddressI b)
		{

			if (a is null)
			{
				return false;
			}
			if (b is null)
			{
				return false;
			}

			return nilnul.fs.address.re_.Joint.Singleton.re(
				a, b
			);

		}

		public bool _re_ofTrimmed(string a, string b)
		{
			

			return re(
				nilnul.fs.address.nulable._ParseX._Parse_assumeEmpty0address(
					a
				),
				nilnul.fs.address.nulable._ParseX._Parse_assumeEmpty0address(
					b
				)
			);

		}

		static public Joint_ignoreNul Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Joint_ignoreNul>.Instance;
			}
		}

	}
}
