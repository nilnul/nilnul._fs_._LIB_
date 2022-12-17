using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.addresses_
{
	/// <summary>
	/// end slash doesnot matter
	/// </summary>
	public class Disjoint:
		nilnul.obj.Box_pub< List<nilnul.fs.AddressI>>
	{
		public Disjoint() : base(new List<AddressI>())
		{
		}

		//public Disjoint(List<AddressI> _disjoint) : this(
		//)
		//{
		//	disjoint_._ListX._Absorb(this.boxed, _disjoint);
		//}

		[Obsolete("as ctor, it shall only vow it. the absorption shall be implemented in an explicit named method")]
		public Disjoint(IEnumerable<AddressI> _disjoint) : this(
			//_disjoint.ToList()
		)
		{
			disjoint_._ListX._Absorb(this.boxed, _disjoint);

		}



		public Disjoint(IEnumerable<string> folders) : this(
			folders.Select(x => nilnul.fs.address_.Shield.Parse(x))
		   )
		{

		}


		public void Add(nilnul.fs.AddressI shield) {
			disjoint_._ListX._Absorb(this.boxed, shield);
		}

		public void Add(IEnumerable< nilnul.fs.AddressI> shield) {
			disjoint_._ListX._Absorb(this.boxed, shield);
		}


	}
}
