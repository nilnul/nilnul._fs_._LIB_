using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dir.str_
{
	[Obsolete()]
	public interface EnumableI:nilnul.fs._address.dir.StrI, IEnumerable<nilnul.fs._address.DirI1>
		//,		nilnul.obj.str_.EnumableI1
	{
	}
	[Obsolete()]

	public class Enumable :
		nilnul.obj.Box<IEnumerable<nilnul.fs._address.DirI1>>
		,
		EnumableI
	{
		public Enumable():this( new DirI1[0])
		{

		}
		public Enumable(IEnumerable<DirI1> val) : base(val)
		{
		}

		public IEnumerator<DirI1> GetEnumerator()
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
