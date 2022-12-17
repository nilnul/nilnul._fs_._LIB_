using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.addresses_.disjoint_
{
	/// <summary>
	/// the ending slash will be taken into account. the shortest one wins and stays
	/// </summary>
	public class EndMatters:
		nilnul.obj.Box1< List<nilnul.fs.AddressI>>
		,
		IEnumerable<nilnul.fs.AddressI>
	{
		public EndMatters() : base(new List<AddressI>())
		{
		}

		//public Disjoint(List<AddressI> _disjoint) : this(
		//)
		//{
		//	disjoint_._ListX._Absorb(this.boxed, _disjoint);
		//}


		public EndMatters(IEnumerable<AddressI> _disjoint) : this(
			//_disjoint.ToList()
		)
		{
			disjoint_.endMatters_._ListX._Absorb(this.boxed, _disjoint);

		}



		public EndMatters(IEnumerable<string> folders) : this(
			folders.Select(x => nilnul.fs.address_.Shield.Parse(x))
		   )
		{

		}


		public void Add(nilnul.fs.AddressI shield) {
			disjoint_.endMatters_._ListX._Absorb(this.boxed, shield);
		}

		public void Add(IEnumerable< nilnul.fs.AddressI> shield) {
			disjoint_.endMatters_._ListX._Absorb(this.boxed, shield);
		}

		public IEnumerator<AddressI> GetEnumerator()
		{
			return boxed.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new System.NotImplementedException();
		}
	}
}
