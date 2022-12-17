using nilnul.fs.address_;

namespace nilnul.fs.file.move.softLinkRemain_
{
	static public class _TargetFolderX
	{
		public static void Void(
			nilnul.fs.FileI src
			,
			nilnul.fs.address_.ShieldI target
		)
		{
			var srcParentDoc = new nilnul.fs.address_.spear_.ParentDoc(src.file.en);
			var dst = new nilnul.fs.address_.spear_.ParentDoc(target, srcParentDoc.doc);

			_SoftLinkRemainX.Void(src, dst);
		}

		public static void Void_targetParentIsAddress(SpearI src, string targetParent)
		{
			Void(
				src
				,
				nilnul.fs.address_.shield_._AddressX1.Create(targetParent)
			);

		}

		private static void Void(SpearI src, Shield target)
		{
			Void(
				new nilnul.fs.File(src)
				,
				target
			);

		}

		public static void Void(Spear spear1, ShieldI target)
		{
			Void(
				new nilnul.fs.File(spear1)
				,
				target
			);

		}

		public static void Void(
			string src
			,
			nilnul.fs.address_.ShieldI target
		)
		{
			Void(
				new nilnul.fs.address_.Spear(src)
				,
				target
			);
		}

		public static void Void_targetParentIsAddress(
			string src
			, string targetParent
		)
		{
			Void(
				src
				,
				nilnul.fs.address_.shield_._AddressX1.Create(targetParent)
			);
		}


	}
}
