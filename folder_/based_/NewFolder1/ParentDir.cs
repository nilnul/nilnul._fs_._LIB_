using nilnul.fs._address;
using nilnul.fs.address_;
using System;
using System.IO;

namespace nilnul.fs.folder_
{


	/// <summary>
	/// a parent and a dir to form a folder
	/// </summary>
	///
	[Obsolete()]
	public class ParentDir :
		nilnul.fs.address_.shield_.parentDir_.Exist
		,
		FolderI

	{
		public ParentDir(address_.shield_.BaseDir val) : base(val)
		{
		}

		public ParentDir(address_.ShieldI shield, _address.DirI dir) : this(
			new address_.shield_.BaseDir(shield, dir)
		)
		{
		}

		public ParentDir(address_.ShieldI shield, _address.Dir dir) : this(
			shield, (DirI)dir
		)
		{
		}

		public ParentDir(address_.ShieldI shield, _address._dst.Denote doc) : this(
			new address_.shield_.BaseDir(shield, doc)
		)
		{
		}

		public ParentDir(DirectoryInfo directoryInfo, DirI dir) : this((nilnul.fs.address_.Shield)directoryInfo, dir)
		{
		}

		[Obsolete()]
		public ParentDir(FolderI folder) : this(
				nilnul.fs.address_.shield_.BaseDir._Fro(folder.address.en)
		)
		{

		}
		static public ParentDir Of(FolderI folder) 
		{
			return folder switch {
				 ParentDir parentDir =>parentDir
				,
				_=>new ParentDir( nilnul.fs.address_.shield_.BaseDir._Ov(folder.address.en) )
			};
 
		}
		public ParentDir(ShieldI parent, DocI newName) : this(parent, new Dir(newName))
		{
		}
		public ParentDir(address_.shield_.Exist address1, DirI dir) : this(address1.en, dir)
		{
		}


		public ParentDir(FolderI parentDir, DirI dir) : this(parentDir.address, dir)
		{
		}

		static public ParentDir _OvAddress(string folder)
		{
			return new ParentDir(
				nilnul.fs.address_.shield_.BaseDir.FroAddress(folder)
			);
		}


		static public ParentDir Ov(nilnul.fs.address_.ShieldI folder)
		{
			return new ParentDir(
				nilnul.fs.address_.shield_.BaseDir._Ov(folder)
			);
		}


		public static ParentDir _OvDenote(ShieldI route, string newName)
		{
			return new ParentDir(
				 route
				 ,
				 new nilnul.fs._address._dst.Denote(newName)
			);
		}

		public nilnul.fs.address_.shield_.Exist address => this;

		static public ParentDir OvParentShield_ChildDenote(string containerAddress, string divDivision)
		{
			return new ParentDir(
				 nilnul.fs.address_.Shield.Parse(containerAddress)
				 ,
				 new nilnul.fs._address._dst.Denote(divDivision)
			);
		}

		static public ParentDir OvParentAddress_ChildDenote(string containerAddress, string divDivision)
		{
			return new ParentDir(
				 nilnul.fs.address_.shield_._AddressX1.Create(containerAddress)
				 ,
				 nilnul.fs._address.dir_._DstX.CreateFroDst(divDivision)
			);
		}



	}
}
