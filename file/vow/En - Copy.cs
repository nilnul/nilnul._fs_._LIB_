namespace nilnul.fs.file.vow
{
	public class En<TVow> : nilnul.obj.vow.En<FileI, TVow>
		where TVow : nilnul.fs.file.VowI, new()
	{
		public En(FileI val) : base(val)
		{
		}
	}
}
