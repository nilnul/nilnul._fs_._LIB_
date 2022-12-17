using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dir.str_
{
	public interface SeqI:nilnul.fs._address.dir.StrI1, IEnumerable<nilnul.fs._address.DirI>
		//,		nilnul.obj.str_.EnumableI1
	{
	}
	public class Seq :
		nilnul.obj.Box<IEnumerable<nilnul.fs._address.DirI>>
		,
		SeqI
	{
		public Seq():this( new DirI[0])
		{

		}
		public Seq(IEnumerable<DirI> val) : base(val)
		{
		}

		public IEnumerator<DirI> GetEnumerator()
		{
			return boxed.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
