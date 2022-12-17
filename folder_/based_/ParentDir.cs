using nilnul.fs._address;
using nilnul.fs.address_;
using System;
using System.IO;

namespace nilnul.fs.folder_.based_
{


	/// <summary>
	/// a parent and a dir to form a folder
	/// </summary>
	/// 
	public class Child :
		nilnul.fs.address_.shield_.based_.child_.Exist
		,
		FolderI1

	{
		public Child(address_.shield_.based_.Child val) : base(val)
		{
		}

		public Child(address_.ShieldI1 shield, _address._route.division_._div.DirI dir) : this(
			new address_.shield_.based_.Child(shield, dir)
		)
		{
		}

		public Child(address_.ShieldI1 shield, _address._route.division_._div.Dir dir) : this(
			shield, (_address._route.division_._div.DirI)dir
		)
		{
		}

		public Child(address_.ShieldI1 shield, _address._route.division_._div._dir.Dnt doc) : this(
			new address_.shield_.based_.Child(shield, doc)
		)
		{
		}

		public Child(DirectoryInfo directoryInfo, _address._route.division_._div.DirI dir) : this((nilnul.fs.address_.Shield1)directoryInfo, dir)
		{
		}

		
		static public Child Of(FolderI1 folder) 
		{
			return folder switch {
				 Child parentDir =>parentDir
				,
				_=>new Child( nilnul.fs.address_.shield_.based_.Child._Of(folder.address.ee) )
			};
 
		}
		public Child(ShieldI1 parent, _address._route.division_._div._dir.DntI newName) : this(parent, new _address._route.division_._div.Dir(newName))
		{
		}
		public Child(address_.shield_.Exist1 address1, _address._route.division_._div.DirI dir) : this(address1.ee, dir)
		{
		}


		public Child(FolderI1 parentDir, _address._route.division_._div.DirI dir) : this(parentDir.address, dir)
		{
		}

		static public Child _OvAddress(string folder)
		{
			return new Child(
				nilnul.fs.address_.shield_.based_.Child.OfAddress(folder)
			);
		}


		[Obsolete(nameof(Of))]
		static public Child Ov(nilnul.fs.address_.ShieldI1 folder)
		{
			return new Child(
				nilnul.fs.address_.shield_.based_.Child._Of(folder)
			);
		}

		static public Child Of(nilnul.fs.address_.ShieldI1 folder)
		{
			return new Child(
				nilnul.fs.address_.shield_.based_.Child._Of(folder)
			);
		}


		public static Child _OvDenote(ShieldI1 route, string newName)
		{
			return new Child(
				 route
				 ,
				 new nilnul.fs._address._route.division_._div._dir.Dnt(newName)
			);
		}

		public nilnul.fs.address_.shield_.Exist1 address => this;

		static public Child OvParentShield_ChildDenote(string containerAddress, string divDivision)
		{
			return new Child(
				 nilnul.fs.address_.Shield1.Parse(containerAddress)
				 ,
				 new nilnul.fs._address._route.division_._div._dir.Dnt(divDivision)
			);
		}

		static public Child OvParentAddress_ChildDenote(string containerAddress, string divDivision)
		{
			return new Child(
				 nilnul.fs.address_.shield.op_.of_._AddressX.Create(containerAddress)
				 ,
				 nilnul.fs._address._route.division_._div.dir.op_.of_._DstX.CreateFroDst(divDivision)
			);
		}



	}
}
