namespace nilnul.fs.location_
{
	public class File0Folder : nilnul.obj.Box_pub<nilnul.fs._location_.BlankI>,File0FolderI
	{
		public File0Folder(nilnul.fs.FileI val) : base(val)
		{
		}
		public File0Folder(nilnul.fs.FolderI val) : base(val)
		{
		}
		public bool beFile
		{
			get
			{
				return boxed is nilnul.fs.FileI;
			}
		}
		public bool beFolder
		{
			get
			{
				return !beFile;
			}
		}

		public nilnul.fs.FileI coerceFile()
		{
			return (nilnul.fs.FileI)(this.boxed);
		}
		public nilnul.fs.FolderI coerceFolder()
		{
			return (nilnul.fs.FolderI)(this.boxed);
		}

		static public File0Folder Ov(nilnul.fs._location_.BlankI location)
		{
			var t = File0FolderA.Parse(location);
			switch (t)
			{
				case nilnul.fs.FileI file:
					return new File0Folder(file);
				case nilnul.fs.Folder folder:
					return new File0Folder(folder);
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}


	}
}
