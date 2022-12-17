using System.Linq;

namespace nilnul.fs.folder.be_
{
	public class Dwelled
		: nilnul.fs.folder.BeA
	{
		public override bool be(nilnul.fs.FolderI obj)
		{
			return System.IO.Directory.EnumerateFileSystemEntries(obj.ToString()).Any();


			//throw new NotImplementedException();
		}

		public bool be_ofAddress(string obj)
		{
			return be(Folder.FroAddress(obj));


			//throw new NotImplementedException();
		}





		public static bool _Be(string selectedPath)
		{
			return Singleton.be(Folder.FroAddress(selectedPath));

			//throw new NotImplementedException();
		}


		static public Dwelled Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dwelled>.Instance;
			}
		}

	}
}
