using nilnul.fs.address_;

namespace nilnul.fs.folder.documents.copy_.symlink_
{
	static public class _TargetDisjointX
	{
		public static void Void_assumeTgtDisjoint(
			nilnul.fs.FolderI src
			,
			nilnul.fs.FolderI target

		)
		{
			nilnul.fs.folder._DocumentsX.Infos(src).ForEach(spear =>
			{
				nilnul.fs.file.copy_.symlink_._TargetParentX.Void(spear, target);

			});
		}

		public static void Void_assumeTgtDisjoint(
			ShieldI src,
			Folder tgt
		)
		{
			Void_assumeTgtDisjoint(
				new nilnul.fs.Folder(src)
				,
				(FolderI)tgt
			);


		}


		public static void Void_targetAddress_assumeDisjoint(
			nilnul.fs.address_.ShieldI src
			,
			string tgt
		)
		{
			Void_assumeTgtDisjoint(
				(src)
				,
				nilnul.fs.Folder.FroAddress(tgt)
			);
		}

		public static void Void_ofAddresses_assumeDisjoint(
			string src
			,
			string tgt
		)
		{
			Void_targetAddress_assumeDisjoint(
				nilnul.fs.address_.shield_._AddressX1.Create(src)
				,
				(tgt)
			);
		}
	}
}
