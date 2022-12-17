using nilnul.fs._address.dir.str_;
using nilnul.fs._address.div.be_.nonEmpty;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.div_
{
	public class NonEmpty : nilnul.obj.str_.enumable_.Started<DirI>
		,
		NonEmptyI
	{
		public NonEmpty(DirI head, IEnumerable<DirI> boxed) : base(head, boxed)
		{
		}

		public En en => new En(this);

		public SeqI dirs => new nilnul.fs._address.dir.str_.Seq(this.Select(x => new Dir(x.denote)));


		static public NonEmpty Coerce(DivI div)
		{
			return new NonEmpty(div.dirs.First(), nilnul.obj.seq.Extensions.Skip(div.dirs));
		}

	}
}
