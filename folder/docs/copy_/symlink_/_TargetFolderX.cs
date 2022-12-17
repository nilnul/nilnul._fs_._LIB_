using nilnul.fs.address_;

namespace nilnul.fs.folder.docs.copy_.symlink_
{
	static public class _TargetParentX
	{
		public static void Void(
			nilnul.fs.FolderI src
			,
			nilnul.fs.FolderI target

		)
		{
			nilnul.fs.folder._DocsX.Spears(src).ForEach(spear =>
			{
				nilnul.fs.file.copy_.symlink_._TargetParentX.Void(spear, target);

			});
		}

		public static void Void(
			ShieldI src,
			Folder tgt
		)
		{
			Void(
				new nilnul.fs.Folder(src)
				,
				(FolderI)tgt
			);


		}


		public static void Void_targetFolderAddress(
			nilnul.fs.address_.ShieldI src
			,
			string tgt
		)
		{
			Void(
				(src)
				,
				nilnul.fs.Folder.FroAddress(tgt)
			);
		}

		public static void Void_ofAddresses(
			string src
			,
			string tgt
		)
		{
			Void_targetFolderAddress(
				nilnul.fs.address_.shield_._AddressX1.Create(src)
				,
				(tgt)
			);
		}
	}
}
