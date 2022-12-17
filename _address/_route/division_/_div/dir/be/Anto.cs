using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dir.be
{
	public class Anto
		: nilnul.obj.be.Anto<_address.DirI>
		,
		_address.dir.BeI
	{
		public Anto(nilnul.obj.BeI1<DirI> be) : base(be)
		{
		}
	}
}
