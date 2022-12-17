using nilnul.obj;
using System.Collections;
using System.Collections.Generic;

namespace nilnul.fs.folders.vow
{
	public class EeOfSeq :
		nilnul.obj.vow.Ee1<
			IEnumerable<nilnul.fs.FolderI>
		>

	{
		

		public EeOfSeq(IEnumerable<FolderI> val, VowI2<IEnumerable<FolderI>> vow) : base(val, vow)
		{
		}

		public EeOfSeq(IEnumerable<FolderI> val, nilnul.fs.folders.VowOfSeqI vow) : base(val, vow)
		{
		}
	}
}
