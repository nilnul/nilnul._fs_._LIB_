namespace nilnul.fs.folder.division.to_
{
	static public class _FolderX
	{
		static public nilnul.fs.Folder Exe(
			fs.Folder container
			,
			nilnul.fs._address.DivisionI division
		)
		{
			return fs.Folder.FroAddress(System.IO.Path.Combine(container.ToString(), division.ToString()));
		}
		static public nilnul.fs.Folder Exe(nilnul.fs.Folder container,

			string division)

		{
			return fs.Folder.FroAddress(System.IO.Path.Combine(container.ToString(), division));
		}


	}
}
