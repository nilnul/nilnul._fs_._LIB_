namespace nilnul.fs.folder.vow.ee_
{
	public class VowDefault<TVow> : nilnul.obj.vow.ee_.Defaultable<nilnul.fs.FolderI, TVow>
		where TVow : VowI1, new()
	{
		public VowDefault(FolderI val) : base(val)
		{
		}
	}
}
