using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir_.link_.sym.create_
{
	/// <summary>
	/// relative path
	/// note the targeted "pass" must use "\", not "/" 
	/// </summary>
	static public class _TargetShortcutX
	{
		static public void Create(
			nilnul.fs.FolderI container
			,
			nilnul.fs._address.DirI dir
			,
			nilnul.fs.address.co._traject.IShortcut shortcut
		)
		{
			nilnul.fs.folder_.link_.sym.create_._DllImportX.Vod_linkOfAddress(
				new nilnul.fs.address_.shield_.BaseDir(container.address.en, dir).ToString()
				,
				shortcut.ToString().Replace('/', '\\')

			);

			//nilnul.fs.location_.link_.sym.create_.by_._DllImportX._Folder(
			//	new nilnul.fs.address_.shield_.BaseDir(container.address.en, dir).ToString()
			//	,
			//	shortcut.ToString().Replace('/', '\\')
			//);

		}



		static public void Create_containerOfAddress_dirOfDst(string containerAddress, string dir, nilnul.fs.address.co._traject.IShortcut target)
		{
			var parentInShield = nilnul.fs.address_.Shield.FroAddress(containerAddress);

			Create(
				new nilnul.fs.Folder(parentInShield),
				nilnul.fs._address.Dir.OvDst(dir)
				,
				target
			);
		}

		static public void Create_containerOfAddress_dirOfDst_tgtOfShortcut(
			string containerAddress, string dir, string target)
		{
			var parentInShield = nilnul.fs.address_.Shield.FroAddress(containerAddress);

			Create_containerOfAddress_dirOfDst(
				containerAddress,
				(dir),
				nilnul.fs.address.co._traject.ShortcutX.Parse(target)
			);
		}


		static public void Create_containerOfAddress_dirOfDst_targetAsShieldOfAddress(
			string containerAddress, string dir, string target)
		{
			var parentInShield = nilnul.fs.address_.Shield.FroAddress(containerAddress);

			Create_containerOfAddress_dirOfDst(
				containerAddress,
				(dir),


				nilnul.fs.address_.shield.co._RelPathX.Shortcut_ofTargetIsAddress(parentInShield,
				target
				)
			);
		}


		public static void Create(
			ShieldI parent
			,
			_address.DirI dir
			,
			nilnul.fs.address_.ShieldI tgt
		)
		{
			Create(
				 nilnul.fs.folder._EnsureX.Folder(parent)
				 ,
				 dir
				 ,
				 nilnul.fs.address_.shield.co._RelPathX.Shortcut(
					parent
					,
					tgt
				)
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
			Create(
				(ShieldI)parent
				,
				dir
				,
				(ShieldI)tgt
			);
		}



		public static void Create(ShieldI parent, _address.Dir dir, nilnul.fs.address_.ShieldI tgt)
		{
			Create(parent, (_address.DirI)(dir), tgt);
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
				(nilnul.fs.address_.Shield)(tgt)

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
