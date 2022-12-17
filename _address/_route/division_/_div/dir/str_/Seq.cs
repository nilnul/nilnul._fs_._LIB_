using System;
using System.Collections.Generic;

namespace nilnul.fs._address.dir.str_
{
	[Obsolete()]
	public interface SeqI : nilnul.fs._address.dir.StrI1, IEnumerable<nilnul.fs._address.DirI>
	//,		nilnul.obj.str_.EnumableI1
	{
	}
	[Obsolete()]
	public class Seq :
		nilnul.obj.str_.Seq<nilnul.fs._address.DirI>
		,
		SeqI
	{
		public Seq() : this(new DirI[0])
		{

		}
		public Seq(IEnumerable<DirI> val) : base(val)
		{
		}


	}
}
