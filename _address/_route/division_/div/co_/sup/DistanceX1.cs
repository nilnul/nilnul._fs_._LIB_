using System.Linq;

namespace nilnul.fs._address.div.duo_.sup
{
	static public class _DistanceX1
	{
		static public int _Int_ofSupSub(DivI sup, DivI sub)
		{
			return sub.dirs.Count() - sup.dirs.Count();
		}
		static public uint _ofSupSub(DivI sup, DivI sub)
		{
			return (uint)_Int_ofSupSub(sup, sub);
		}
	}
}
