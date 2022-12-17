using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
using System;
using System.IO;

namespace nilnul.fs.file.copy_.symlink_
{
	/// <summary>
	/// docSame
	/// </summary>
	static public class _TargetParentX
	{
		public static void Void(
			ParentDoc entity
			,
			nilnul.fs.FolderI linkParent
		)
		{
			nilnul.fs.file_.link.create_.docSame_._LinkParentX.Create(linkParent, entity);
		}

		public static void Void(FileInfo spear, FolderI target)
		{

			Void(
				new ParentDoc(spear)
				,
				target
			);

		}

		public static void Void(
			SpearI spear
			,

			FolderI linkParent
		)
		{
			Void(
				new ParentDoc(spear)
				,
				linkParent
			);

		}

		public static void Void(
			SpearI spear,
			Folder linkParent

		)
		{
			Void(
				new ParentDoc(spear)
				,
				(nilnul.fs.FolderI)linkParent
			);



		}


		public static void Void_targetFolderAddress(
			nilnul.fs.address_.SpearI entity
			,
			string linkParent
		)
		{
			Void(
				(entity)
				,
				nilnul.fs.Folder.FroAddress(linkParent)
			);
		}

		public static void Void_targetFolderAddress(
			string entity
			,
			string linkParent
		)
		{
			Void_targetFolderAddress(
				nilnul.fs.address_.spear_._AddressX.Create(entity)
				,
				(linkParent)
			);

		}
	}
}
