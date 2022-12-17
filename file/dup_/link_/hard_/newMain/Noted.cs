using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
using System;
using System.IO;

namespace nilnul.fs.file.copy_.link_.hard_.newMain
{


	/// <summary>
	/// docSame
	/// </summary>
	static public class _NotedX
	{
		static public string __CreateNewMain(nilnul.fs._address.doc_._exted.MainI main) {
			return main + "(hardlinked)";
		}

		static public void Vod(nilnul.fs.FileI src, nilnul.fs.FolderI dstParent)
		{

			hard_._NewMainIntoTargetX.Vod(
				src
				,
				dstParent
				,
				nilnul.fs.address_.spear._DocMainX.Main(src.file.en) + "(hardlinked)"
			);
		}

		public static void Vod(FileInfo spear, FolderI target)
		{
			Vod(
				new nilnul.fs.File(spear),target
			);

		}

		public static void Void(
			ParentDoc entity
			,
			nilnul.fs.FolderI linkParent
		)
		{
			Vod(
							new nilnul.fs.File(
								entity
							)
							,
							linkParent
						);
		}

		public static void Void(FileInfo spear, FolderI target
			)
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
