using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.addresses_.disjoint._lex._parse
{
	static public class _CheckX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="paddedAddressNulable">
		/// each line is either
		///		white
		///		or padded address
		/// </param>
		/// <returns></returns>
		static public string Check_eachAssumePaddedAddressNulable(
			IEnumerable<string> paddedAddressNulable
		)
		{
			var absorbedOfNulable = new List<AddressI>();


			for (int i = 0; i < paddedAddressNulable.Count(); i++)
			{
				var parsed = nilnul.fs.address.nulable.parse_._EmptyAsNulX.Parse(
					paddedAddressNulable.ElementAt(i).Trim()
				);
				for (int j = 0; j < absorbedOfNulable.Count; j++)
				{
					if (
						nilnul.fs.address.nulable.re_.Joint_ignoreNul.Singleton.re(
							parsed
							,
							absorbedOfNulable[j]
						)
					)
					{
						return $"line {j} is joint with line {i}";
					}
					else
					{
						absorbedOfNulable.Add(
							parsed
						);
					}

				}
			}
			return "";
			

		}
	}
}
