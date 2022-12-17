using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs._address.route_;
using nilnul.fs._folder_;
using nilnul.fs._location_;
using nilnul.fs.address_;
using nilnul.fs.address_.container.be_.exist.vow;
using nilnul.fs.address_.shield.be_.exist._vow_;
using nilnul.fs.address_.shield_;
using nilnul.fs.address_.shield_.baseDir_;

namespace nilnul.fs.folder_
{
	/// <summary>
	/// a parent and a dir to form a folder
	/// </summary>
	/// 
	[Obsolete()]

	public class BaseDir:
		nilnul.fs.address_.shield_.baseDir_.Exist
		,
		FolderI2
		
	{
		public BaseDir(address_.shield_.BaseChild val) : base(val)
		{
		}

		public BaseDir(address_.ShieldI shield, _address.DirI1 dir):this(
			new address_.shield_.BaseChild(shield, dir)
		)
		{
		}
		public BaseDir(address_.ShieldI shield, _address.DocI doc):this(
			new address_.shield_.BaseChild(shield, doc)
		)
		{
		}

		static public   BaseDir _Fro(FolderI2 folder) {
			return new BaseDir(
				nilnul.fs.address_.shield_.BaseChild._Fro(folder.address.en)
			);
		}

		public static BaseDir FroBaseDoc(ShieldI route, string newName)
		{
			return new BaseDir(
				 route
				 ,
				 new nilnul.fs._address.Doc(newName)
			);
		}

		public nilnul.fs.address_.shield_.Exist address => this ;


		static public BaseDir FroBaseAddress_DirDst(string containerAddress, string divDivision) {
			return new BaseDir(
				 nilnul.fs.address_.shield_._AddressX.Create(containerAddress)
				 ,
				 nilnul.fs._address.dir_._DstX1.CreateFroDst(divDivision)
			);
		}

		static public BaseDir FroBaseDoc(string containerAddress, string divDivision) {
			return new BaseDir(
				 nilnul.fs.address_.Shield.Parse(containerAddress)
				 ,
				 new nilnul.fs._address.Doc(divDivision)
			);
		}


	}
}
