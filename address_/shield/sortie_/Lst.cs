using System.Collections;
using System.Collections.Generic;
using nilnul.fs.address_.shield.str_;
using nilnul.obj.str.be_.distinct.vow;

namespace nilnul.fs.address_.shield.sortie_
{
	public class Lst
		: nilnul.obj.Box<shield.str_.Lst>
		,
		nilnul.fs.address_.shield.SortieI
		,
		System.Collections.Generic.ICollection<nilnul.fs.address_.ShieldI>
	{
		public Lst() : base(new str_.Lst())
		{

		}
		public Lst(IEnumerable<nilnul.fs.address_.ShieldI> val) : this(

		)
		{
			val.ForEach(x => this.Add(x));

		}
		public Lst(str_.Lst val) : this((IEnumerable<nilnul.fs.address_.ShieldI>)val)
		{
		}

		public En<ShieldI> str => new En<ShieldI>(nilnul.fs.address_.shield.Eq.Singleton, (this.boxed));

		public int Count => boxed.Count;

		public bool IsReadOnly => false;

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

		public void Add(ShieldI item)
		{
			_Absorb(this.boxed, item);
		}

		public void AddRange(IEnumerable<ShieldI> shields)
		{
			shields.ForEach(
				x => Add(x)
			);

		}

		public void Clear()
		{
			this.boxed.Clear();
		}

		public bool Contains(ShieldI item)
		{
			return this.boxed.contain(item);
		}

		public void CopyTo(ShieldI[] array, int arrayIndex)
		{
			this.boxed.CopyTo(array, arrayIndex);
		}

		public IEnumerator<ShieldI> GetEnumerator()
		{
			return this.boxed.GetEnumerator();

		}

		public bool Remove(ShieldI item)
		{
			return this.boxed.RemoveAll(
				x => nilnul.fs.address_.shield.Eq.Singleton.Equals(x, item)
			) > 0;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
