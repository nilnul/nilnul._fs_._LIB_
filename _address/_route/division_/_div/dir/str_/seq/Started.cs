using nilnul.obj.str_;
using System;
using System.Collections.Generic;

namespace nilnul.fs._address.dir.str_.seq
{
	[Obsolete()]
	public class Started : nilnul.obj.str_.seq.Started<nilnul.fs._address.DirI>
	{
		public Started(IEnumerable<DirI> boxed) : base(boxed)
		{
		}

		public Started(params DirI[] boxed) : base(boxed)
		{
		}



		public Started(DirI head, Seq tail) : base(head, tail)
		{
		}

		public Started(DirI head, SeqI<DirI> boxed) : base(head, boxed)
		{
		}

		public Started(DirI head, IEnumerable<DirI> boxed) : base(head, boxed)
		{
		}


	}
}
