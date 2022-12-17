using nilnul.obj;
using System;
using System.Collections.Generic;

namespace nilnul.fs.folders.be
{
	public class VowOfSeq
		:
		nilnul.obj.be.Vow4<IEnumerable<nilnul.fs.FolderI>>
		,
		nilnul.fs.folders.VowOfSeqI

	{
		public VowOfSeq(BeI1<IEnumerable<FolderI>> be) : base(be)
		{
		}

		public VowOfSeq(Predicate<IEnumerable<FolderI>> predicate) : base(predicate)
		{
		}

		public VowOfSeq(Func<IEnumerable<FolderI>, bool> func) : base(func)
		{
		}
	}
}
