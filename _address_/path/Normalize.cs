using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_.path
{
	public class Normalize
	{
		static public IEnumerable<_path.Dst> ToDsts(Path sprig) {
			foreach (var item in sprig.stem.dirs.ed)
			{
				yield return item;
			}
			if (sprig.tip.val is nilnul.obj._opt_.val_.OneI)
			{
				yield return (sprig.tip.val as nilnul.obj._opt_.val_.One<_path.Dst>).val;
			}
		}
	}
}
