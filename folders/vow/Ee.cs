namespace nilnul.fs.folders.vow
{
#pragma warning disable CS0612 // 'Ed<FoldersI, TVow>' is obsolete
	public class Ee<TVow> : nilnul.obj.vow.Ed<nilnul.fs.FoldersI, TVow>
#pragma warning restore CS0612 // 'Ed<FoldersI, TVow>' is obsolete
		where TVow : nilnul.fs.folders.VowI, new()
	{
		public Ee(FoldersI val) : base(val)
		{
		}
	}
}
