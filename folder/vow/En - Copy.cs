using System;

namespace nilnul.fs.folder.vow
{
	[Obsolete(/*nameof(ee_.VowDefault<TVow>)*/)]
	public class En2<TVow> : nilnul.vow.En<nilnul.fs.FolderI, TVow>
		where TVow : VowI, new()
	{
		public En2(FolderI val) : base(val)
		{
		}
	}
}
