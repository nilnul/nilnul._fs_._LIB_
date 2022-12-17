using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address.dir.str_;
using nilnul.fs._address.div.be_.nonEmpty;

namespace nilnul.fs._address.div_
{
	[Obsolete()]
	public class NonEmpty : nilnul.obj.str_.enumable_.Started<DirI1>
		,
		NonEmptyI
	{
		public NonEmpty(DirI1 head, IEnumerable<DirI1> boxed) : base(head, boxed)
		{
		}

		public En en => new En(this);

		public EnumableI1 dirs => new nilnul.fs._address.dir.str_.Enumable1(this.Select(x=> new Dir2( x.name.ToString())));


		static public NonEmpty Coerce(DivI1 div) {
			return new NonEmpty(div.dirs.First(), nilnul.obj.seq.Extensions.Skip(div.dirs));
		}

	}
}
