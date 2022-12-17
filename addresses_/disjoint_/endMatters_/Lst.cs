using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.addresses_.disjoint_.endMatters_
{
	static public class _ListX
	{
		static public void _Absorb(
			List<nilnul.fs.AddressI> _disjoint
			,
			nilnul.fs.AddressI candidate
		)
		{
			///all those that are sub of candidate, are , removed
			var removed = _disjoint.RemoveAll(x => nilnul.fs.address.re_.sub_.EndMatters.Singleton.re(x, candidate));
			if (removed > 0)
			{
				_disjoint.Add(candidate);

			}
			else
			{
				if (
					nilnul.obj.seq.be_._NoneX.None(
						_disjoint
						,
						x => nilnul.fs.address.re_.sup_.EndMatters.Singleton.re(x, candidate)
					)
				)
				{
					_disjoint.Add(candidate);
				}

			}
			//return;

		}


		static public void _Absorb(
			List<nilnul.fs.AddressI> _disjoint,
			IEnumerable<
			nilnul.fs.AddressI> candidates)
		{
			candidates.ForEach(
				x => _Absorb(_disjoint, x)
			);

		}

		static public List<nilnul.fs.AddressI> Lst_byDelSubs(
			IEnumerable<nilnul.fs.AddressI> _disjoint
			)
		{
			var r = new List<nilnul.fs.AddressI>();
			_Absorb(r, _disjoint);
			return r;

		}

		static public List<nilnul.fs.AddressI> _Make(
			List<nilnul.fs.AddressI> _disjoint
			)
		{
			var r = new List<nilnul.fs.AddressI>();
			_Absorb(r, _disjoint);
			return r;

		}


		static public List<nilnul.fs.AddressI> Lst_byDelSubs(
			IEnumerable<string> _disjoint
		)
		{
			return Lst_byDelSubs(
				_disjoint.Select(
					a=> nilnul.fs.AddressA.Parse(a)
				)
			);

		}



	}
}
