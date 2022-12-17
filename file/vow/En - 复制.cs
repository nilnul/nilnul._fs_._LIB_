namespace nilnul.fs.file.vow
{
	public class Ee<TVow> : nilnul.obj.vow.ee_.Defaultable<FileI, TVow>
		where TVow : nilnul.fs.file.VowI, new()
	{
		public Ee(FileI val) : base(val)
		{
		}
		public Ee(nilnul.fs.address_.SpearI spear):this(new nilnul.fs.File(spear))
		{

		}
		public Ee(string s):this(new nilnul.fs.address_.Spear(s))
		{

		}
	}
}
