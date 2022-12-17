using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.dirs
{
	[Obsolete(nameof(co_.Concat))]
	public class Combine : CombineI
	{
		public DirsI eval(DirsI arg, DirsI arg1)
		{
			return new Dirs(arg.Concat(arg1));
			throw new NotImplementedException();
		}


		static public readonly Combine Singleton = nilnul.obj.SingletonByDefault<Combine>.Instance;

		public DirsI eval(
			DirsI dirs, Dir doc
		)
		{
			return new Dirs(
				nilnul.obj.seq.convert_._AppendX.Append(dirs,
				  doc )
			);
			throw new NotImplementedException();
		}
	}
}
