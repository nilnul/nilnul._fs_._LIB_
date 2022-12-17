namespace nilnul.fs.file0Folder
{


	static public class _CheckByBreakX
	{
		static public nilnul.fs.File0FolderI File0Folder(nilnul.fs.File0FolderI address)
		{
			switch (address)
			{
				case nilnul.fs.FileI shield:
					return shield;
				case nilnul.fs.FolderI spear:
					return spear;
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}




	}

}
