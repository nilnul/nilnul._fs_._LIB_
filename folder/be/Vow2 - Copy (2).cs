using System;

namespace nilnul.fs.folder.be
{
	[Obsolete()]

	public class Vow2<TBe>
		: nilnul.obj.be.Vow2<nilnul.fs.FolderI, TBe>
		,
		nilnul.fs.folder.VowI1
		where TBe : nilnul.fs.folder.BeI, new()
	{
	}
}
