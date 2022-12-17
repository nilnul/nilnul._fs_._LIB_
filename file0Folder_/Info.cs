namespace nilnul.fs.file0Folder_
{


	static public class _InfoX
	{





		static public nilnul.fs.File0FolderI File0Folder(System.IO.FileSystemInfo fileSystemInfo)
		{
			switch (fileSystemInfo)
			{
				case System.IO.FileInfo fileInfo:
					return new nilnul.fs.File(fileInfo);
				case System.IO.DirectoryInfo dirInfo:
					return new nilnul.fs.Folder(dirInfo);
				default:
					throw new UnexpectedTypeException();
#pragma warning disable CS0162 // Unreachable code detected
					break;
#pragma warning restore CS0162 // Unreachable code detected
			}
		}


	}

}
