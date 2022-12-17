using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders.vow.ee_
{
	public class VowDefault<TVow>
		: folders.vow.EeOfSeq

	where TVow : nilnul.fs.folders.VowOfSeqI, new()

	{
		public VowDefault(IEnumerable<FolderI> val)
			: base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}

		
	}
}
