using System;

namespace nilnul.fs.file.paste_
{
	static public class _AsHardLinkX
	{
		static public void Exe(nilnul.fs.FileI src, nilnul.fs.FolderI dstParent)
		{
			if (
				nilnul.fs.address_.shield.Eq.Singleton.Equals(new nilnul.fs.address_.spear_.ParentDoc(src.file.en).parent, dstParent.address.en)
			)
			{
				throw new ArgumentException($"dst parent ({dstParent}) cannot be the same as the parent of the file {src}");
			}

			nilnul.fs.file_.link_.hard._CreateX.Void(
				new nilnul.fs.address_.spear_.ParentDoc(
					dstParent.address.en
					,
					src.file.en.sprig.document.doc
				)
				,
				src
			);
		}

		static public void Void(string src, string dst)
		{
			Exe(
				new nilnul.fs.File(src)
				,
				 nilnul.fs.Folder.FroShield(dst)
			);
		}
		static public void Void_dstAddress(string src, string dst)
		{
			Exe(
				new nilnul.fs.File(src)
				,
				 nilnul.fs.Folder.FroAddress(dst)
			);
		}


	}
}
