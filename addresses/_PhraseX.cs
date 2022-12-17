using System.Collections.Generic;

namespace nilnul.fs.addresses
{
	public static class _PhraseX
	{
		static public string ToTxt(this IEnumerable<nilnul.fs.AddressI> addresses)
		{
			return nilnul.obj.str.to_._txt.Extensions.ToTxt(addresses, nilnul.fs._addresses_.Seperator_.Default);
		}
	}
}
