using nilnul.fs.address_;
using nilnul.fs.address_.spear_;

namespace nilnul.fs.file_.link.create_.docSame_
{
	static public class _LinkParentX
	{
		public static void Create(
			nilnul.fs.FolderI linkParent
			,
			ParentDoc entity
		)
		{
			_SymlinkX.Create(
				new nilnul.fs.address_.spear_.ParentDoc(linkParent.address.en, entity.doc)
				,
				entity
			);
		}

		public static void OfTargetParentAddress(
			string linkParent
			,
			string entity
		)
		{
			Create(
				nilnul.fs.Folder.FroAddress(linkParent)
				,
				nilnul.fs.address_.spear_._AddressX.Create(entity)
			);
		}

		public static void OfTargetParentAddress(
			string linkParent
			, nilnul.fs.address_.SpearI entity
		)
		{
			Create(
				nilnul.fs.Folder.FroAddress(linkParent)
				,
				(entity)
			);
		}

		public static void Create(
			Folder linkParent
			, SpearI entity
		)
		{
			_SymlinkX.Create(
				new nilnul.fs.address_.spear_.ParentDoc(
					linkParent.address.en
					,
					entity.sprig.document.doc
				)
				,
				entity
			);

		}
	}
}
