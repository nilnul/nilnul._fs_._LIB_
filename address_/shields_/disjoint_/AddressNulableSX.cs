using System.Collections.Generic;

namespace nilnul.fs.address_.shields_.disjoint_
{
	static public class _AddressNulableSX
	{

		static public shields_.Disjoint ToDisjoint(IEnumerable<string> addressNulables)
		{
			return shields_.Disjoint.FroUnsured(
				address_.shields_._AddressNulableSX.ToShields(addressNulables)
			);
		}



	}
}
