using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shields_
{
	static public class _AddressNulableSX
	{

		static public IEnumerable<NotNull2<nilnul.fs.address_.ShieldI>> ToShields(IEnumerable<NotNull2<string>> addressNulables)
		{
			return
				addressNulables.Select(x => nilnul.fs.address_.shield.nulable_._AddressNulableX.Parse(x)
				).Where(x => x != null).Select(y => new NotNull2<ShieldI>(y))
			;
		}

		static public IEnumerable<NotNull2<nilnul.fs.address_.ShieldI>> ToShields(IEnumerable<string> addressNulables)
		{
			return
				addressNulables.Select(x => nilnul.fs.address_.shield.nulable_._AddressNulableX.Parse(x)
				).Where(x => x != null).Select(y => new NotNull2<ShieldI>(y))
			;
		}




	}
}
