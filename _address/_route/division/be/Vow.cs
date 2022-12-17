using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.division.be
{
	public class Vow : nilnul.obj.be.Vow4<DivisionI>, division.VowI
	{
		public Vow(BeI1<DivisionI> be) : base(be)
		{
		}

		public Vow(Predicate<DivisionI> predicate) : base(predicate)
		{
		}

		public Vow(Func<DivisionI, bool> func) : base(func)
		{
		}
	}
}
