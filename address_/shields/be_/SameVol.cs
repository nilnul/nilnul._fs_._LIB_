using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shields.be_
{
	/// <summary>
	/// determine whether an array of folders are disjoint (any in/inc relations)
	/// the set is empty or sameVol
	/// </summary>
	static public class _SameVolSubsetX
	{
		static public bool Be(IEnumerable<nilnul.fs.address_.ShieldI> folders)
		{
			if (nilnul.obj.seq.be_._NoneX.None(folders))
			{
				return true;
			}
			return _Be(folders.First(), nilnul.obj.seq_.headed._TailX._Tail(folders));
		}


		static public bool Be(nilnul.objs_.EnumerableI<nilnul.fs.address_.ShieldI> folders)
		{
			return Be((IEnumerable<ShieldI>)folders);
		}

		static public bool Be(ShieldI[] folders)
		{
			return Be((IEnumerable<ShieldI>)folders);
			//throw new NotImplementedException();
		}


		static bool _Be(
			nilnul.fs.address_.ShieldI folder, IEnumerable<nilnul.fs.address_.ShieldI> _remaining
		)
		{
			return _remaining.All(
				element => nilnul.fs.address_.shield.re_.equiv_._SameVolX.Re(element, folder)
			);
		}




	}

}
