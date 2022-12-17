using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.co_.disjoint._delta
{
	public class _RetX
	{
		static public IEnumerable<string> Phrase(
			(
				(_address.division.Set, _address.division.Set)
				,
				nilnul.fs._address.document.Set
			) ret
		) {
			foreach (var item in ret.Item1.Item1)
			{
				yield return item.ToString();
			}
			yield return null;
			foreach (var item in ret.Item1.Item2)
			{
				yield return item.ToString();
			}
			yield return null;

			foreach (var item in ret.Item2)
			{
				yield return item.ToString();
			}


			
		}
	}
}
