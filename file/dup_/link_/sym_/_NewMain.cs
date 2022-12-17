using nilnul.fs.address_;
using nilnul.fs.address_.spear_;
using System;
using System.IO;

namespace nilnul.fs.file.dup_.link_.sym_
{
	/// <summary>
	/// docSame
	/// </summary>
	static public class _NewMainIntoTargetX
	{

		static public void Vod(nilnul.fs.FileI src, nilnul.fs.address_.ShieldI dstParent, nilnul.fs._address.doc_._exted.MainI newMain)
		{

			nilnul.fs.file_.link_.sym.create_._ExtSameX.Create(
				dstParent
				,
				newMain
				
				,
				src.file.en
			);
		}

		public static void Vod(FileI src, FolderI dstParent, nilnul.fs._address.doc_._exted.Main v)
		{
			Vod(
				src,
				dstParent.address.en
				,
				(nilnul.fs._address.doc_._exted.MainI)v
			);
		}
		public static void Vod(FileI src, FolderI dstParent, string v)
		{
			Vod(
				src,dstParent, new nilnul.fs._address.doc_._exted.Main(v)
			);
		}

		public static void Void(
			ParentDoc entity
			,
			nilnul.fs.FolderI linkParent
			, nilnul.fs._address.doc_._exted.MainI newMain
		)
		{
			Vod(
							new nilnul.fs.File(
								entity
							)
							,
							linkParent.address.en
							,newMain
						);
		}

		public static void Void(FileInfo spear, FolderI target, nilnul.fs._address.doc_._exted.MainI newMain)
		{

			Void(
				new ParentDoc(spear)
				,
				target,newMain
			);

		}

		public static void Void(
			SpearI spear
			,

			FolderI linkParent
			, nilnul.fs._address.doc_._exted.MainI newMain
		)
		{
			Void(
				new ParentDoc(spear)
				,
				linkParent
				,newMain
			);

		}

		public static void Void(
			SpearI spear,
			Folder linkParent
			, nilnul.fs._address.doc_._exted.MainI newMain

		)
		{
			Void(
				new ParentDoc(spear)
				,
				(nilnul.fs.FolderI)linkParent
				,newMain
			);



		}


		public static void Void_targetFolderAddress(
			nilnul.fs.address_.SpearI entity
			,
			string linkParent
			, nilnul.fs._address.doc_._exted.MainI newMain
		)
		{
			Void(
				(entity)
				,
				nilnul.fs.Folder.FroAddress(linkParent)
				,newMain
			);
		}

		public static void Void_targetFolderAddress(
			string entity
			,
			string linkParent
			, nilnul.fs._address.doc_._exted.MainI newMain
		)
		{
			Void_targetFolderAddress(
				nilnul.fs.address_.spear_._AddressX.Create(entity)
				,
				(linkParent)
				,newMain
			);

		}
	}
}
