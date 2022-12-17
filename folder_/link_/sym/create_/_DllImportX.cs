using nilnul.fs.address_;
using System;
using System.Runtime.InteropServices;

namespace nilnul.fs.folder_.link_.sym.create_
{
	static public class _DllImportX
	{
		
		

	



		public static void Vod(nilnul.fs.address_.shield_.based_.Child parentDir, string tgt)
		{
			//ensure parent
			nilnul.fs.folder.create._EnsureX.Vod(parentDir.parent);

			nilnul.fs.folder.dir_.link_._SymX._Create_linkParentAssumeFolder(parentDir, tgt);

			//_Folder(parentDir.ToString(), tgt.ToString());
		}

		public static void Vod(nilnul.fs.address_.shield_.based_.Child parentDir, nilnul.fs.address_.ShieldI1 tgt)
		{
			Vod(parentDir, tgt.ToString());
		}



		public static void Vod(nilnul.fs.address_.ShieldI1 parentDir, ShieldI1 tgt)
		{
			Vod(
				 nilnul.fs.address_.shield_.based_.Child._Of(parentDir),tgt
			);
			//_Folder(parentDir.ToString(), tgt.ToString());
		}

		public static void Vod(nilnul.fs.address_.ShieldI1 parentDir, string tgt)
		{
			Vod(
				 nilnul.fs.address_.shield_.based_.Child._Of(parentDir),tgt
			);
			//_Folder(parentDir.ToString(), tgt.ToString());
		}


		public static void Vod_linkOfAddress(string link, string folder)
		{
			Vod(
				nilnul.fs.address_.shield.op_.of_._AddressX.Create(link)
				,
				folder
			);
		}
		public static void Vod(nilnul.fs.address_.ShieldI link, string target)
		{
			Vod_linkOfAddress(link.ToString(), target);
			//throw new NotImplementedException();
		}
		public static void Vod(nilnul.fs.address_.ShieldI parentDir, ShieldI tgt)
		{

			Vod_linkOfAddress(parentDir.ToString(), tgt.ToString());
		}



	}
}
