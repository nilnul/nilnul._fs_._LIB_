namespace nilnul.fs
{
	public class Folders :
		nilnul.Objs<nilnul.fs.FolderI>
		,
		FoldersI
	{

		public Folders(nilnul.fs.FolderI[] folders) : base(folders)
		{
		}
		public Folders() : this(new nilnul.fs.FolderI[0])
		{
		}
	}
}
