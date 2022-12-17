using nilnul.obj.str_;
using System.Collections.Generic;
using D = nilnul.fs._address._route.division_._div.DirI;

namespace nilnul.fs._address._route.division_._div.dir.str_
{
	public class Started
		:
			nilnul.obj.str_.seq.Started<nilnul.fs._address._route.division_._div.DirI>
			//nilnul.obj.str.Started<nilnul.fs._address._route.division_._div.DirI>
	{
		public Started(IEnumerable<nilnul.fs._address._route.division_._div.DirI> boxed) : base(boxed)
		{
		}

		public Started(params nilnul.fs._address._route.division_._div.DirI[] boxed) : base(boxed)
		{
		}



		public Started(nilnul.fs._address._route.division_._div.DirI head, dir.StrI2 tail) : base(head, tail)
		{
		}

		public Started(D head, SeqI<D> boxed) : base(head, boxed)
		{
		}

		public Started(D head, IEnumerable<D> boxed) : base(head, boxed)
		{
		}


	}
}
