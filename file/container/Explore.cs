using nilnul.fs.address_;

namespace nilnul.fs.file.container
{
	static public class _ExploreX
	{
		static public void Void(nilnul.fs.FileI file)
		{
			nilnul.fs.folder.explore_._ByExeSelfX.Exe(_ContainerX.Folder(file));
		}

		public static void Void(Spear spear1)
		{
			Void(new nilnul.fs.File(spear1));
		}

		static public void Void(string address)
		{
			Void(new nilnul.fs.address_.Spear(address));
		}

	}
}
