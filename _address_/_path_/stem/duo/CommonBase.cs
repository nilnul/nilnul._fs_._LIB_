using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path_.stem.duo
{
	/// <summary>
	/// find the common part starting from the beginning.
	/// </summary>
	public class CommonBase
	{
		static public Stem Eval(Stem a,Stem b) {

			return new Stem(
				Eval_retEnumerable(a,b)
				);

		}

		static public IEnumerable<_path.Dst> Eval_retEnumerable(Stem a, Stem b) {
			var lenght = nilnul.num.set.op.Min.Eval(a.dirs.ed.Count(), b.dirs.ed.Count());

			for (int i = 0; i < lenght; i++)
			{
				if (_path.dst.Eq.Singleton.Equals( a.dirs.ed.ElementAt(i), b.dirs.ed.ElementAt(i) ) )
				{
					yield return a.dirs.ed.ElementAt(i);
				}
				else
				{
					break;
				}

			}

			
		}
	}
}
