using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System.IO;

namespace nilnul.fs.folder.dir_.link_
{


	public class _SymX
	{

	


	
		public static void _Create_linkParentAssumeFolder(nilnul.fs.address_.ShieldI1 parentDir, string tgt)
		{
			sym._create._DllImportX._Vod_srcParentAssumeFolder(parentDir.ToString(), tgt);
		}


		public static void _Create_linkParentAssumeFolder(nilnul.fs.address_.ShieldI1 parentDir, ShieldI1 tgt)
		{
			_Create_linkParentAssumeFolder(parentDir, tgt.ToString());
		}

		public static void _Create_linkParentAssumeFolder(nilnul.fs.address_.ShieldI parentDir, ShieldI tgt)
		{
			sym._create._DllImportX._Vod_srcParentAssumeFolder(parentDir.ToString(), tgt.ToString());
		}


		public static void _Create_linkParentAssumeFolder(
			ShieldI parent
			,
			_address.DirI dir
			,
			nilnul.fs.address_.ShieldI tgt
		)
		{
			_Create_linkParentAssumeFolder(
				new nilnul.fs.address_.shield_.BaseDir(parent, dir)
				,
				tgt
			);
		}
		public static void Create(
			Shield parent
			,
			_address.DirI dir
			,
			nilnul.fs.address_.Shield tgt
		)
		{
			_Create_linkParentAssumeFolder(
				(ShieldI)parent
				,
				dir
				,
				(ShieldI)tgt
			);
		}



		public static void Create(ShieldI parent, _address.Dir dir, nilnul.fs.address_.ShieldI tgt)
		{
			_Create_linkParentAssumeFolder(parent, (_address.DirI)(dir), tgt);
		}
		public static void Create(
			Shield parent
			,
			_address.Dir dir
			,
			nilnul.fs.address_.Shield tgt
		)
		{
			Create(
				(ShieldI)parent
				,
				dir
				,
				(ShieldI)tgt
			);
		}

		public static void Create_ofFolder_dirOfDst_ofTgt(
			DirectoryInfo parent
			,
			string dir
			,
			DirectoryInfo tgt
		)
		{
			Create(
				 (nilnul.fs.address_.Shield)(parent)
				,
				 _address.Dir.OvDst(dir)
				,
				(nilnul.fs.address_.Shield) (tgt)

			);
			;
		}
		public static void Create(ShieldI parent, _address._dst.Denote dir, nilnul.fs.address_.ShieldI tgt)
		{
			Create(parent, new _address.Dir(dir), tgt);

		}

		static public void Create_tgtAddress(
			nilnul.fs.address_.ShieldI parent,
			_address._dst.Denote name,
			string tgt)
		{
			Create(
				parent, name, nilnul.fs.address_.shield_._AddressX1.Create(tgt)
			);
		}



		public static void Create__parentAddress_dirName(string tmpSub, string v, BaseDir realDir)
		{
			Create(nilnul.fs.address_.shield_._AddressX1.Create(tmpSub), new _address._dst.Denote(v), realDir);
		}

	}
}
