using System.Collections.Generic;

namespace nilnul.fs.address_.shields_.disjoint_
{
	static public class _ListX
	{

		static public void _Absorb(List<nilnul.fs.address_.ShieldI> _disjoint,
			IEnumerable<
			nilnul.fs.address_.ShieldI> candidates)
		{
			candidates.ForEach(
				x => _Absorb(_disjoint, x)
			);

		}


		static public void _Absorb(List<nilnul.fs.address_.Shield> _disjoint,
			IEnumerable<
			nilnul.fs.address_.Shield> candidates)
		{


			candidates.ForEach(
				x => _Absorb(_disjoint, x)
			);

		}

		static public void _Absorb(
			List<nilnul.fs.address_.ShieldI> _disjoint
			,
			nilnul.fs.address_.ShieldI candidate
		)
		{
			///all those that are not sub of candidate.
			_disjoint.RemoveAll(x => nilnul.fs.address_.shield.re_.Sub.Singleton.re(x, candidate));


			if (nilnul.obj.seq.be_._NoneX.None(_disjoint, x => nilnul.fs.address_.shield.re_.Sup.Singleton.re(x, candidate)))
			{
				_disjoint.Add(candidate);
			}
		}

		static public void _Absorb(
			List<nilnul.fs.address_.Shield> _disjoint
			,
			nilnul.fs.address_.Shield candidate
		)
		{
			///all those that are not sub of candidate.
			_disjoint.RemoveAll(x => nilnul.fs.address_.shield.re_.Sub.Singleton.re(x, candidate));

			if (nilnul.obj.seq.be_._NoneX.None(_disjoint, x => nilnul.fs.address_.shield.re_.Sup.Singleton.re(x, candidate)))
			{
				_disjoint.Add(candidate);
			}
		}
	}
}
