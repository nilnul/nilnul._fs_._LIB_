namespace nilnul.fs.folders.be
{
	public class Vow<T>
		:
#pragma warning disable CS0612 // 'Vow1<FoldersI, T>' is obsolete
		nilnul.obj.be.Vow1<nilnul.fs.FoldersI, T>
#pragma warning restore CS0612 // 'Vow1<FoldersI, T>' is obsolete
		,
		nilnul.fs.folders.VowI
		where T : BeI, new()
	{
	}
}
