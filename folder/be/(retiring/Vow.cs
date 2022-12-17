using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be
{
	[Obsolete()]
	public class Vow1<TBe>
		:nilnul.obj.be.Vow1<nilnul.fs.FolderI1, TBe >
		,
		nilnul.fs.folder.VowI1
		where TBe :nilnul.fs.folder.BeI1,new()
	{
	}
}
