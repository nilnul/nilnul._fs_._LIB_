using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder
{
	static public class _DstX
	{
		static public _address._route.division_._div.DstI Dst_dntAssumeExists(nilnul.fs.FolderI folder, string dnt) {
			var spear = new nilnul.fs.address_.spear_.ParentDoc(folder.address.en, dnt);
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear) )
			{
				return new _address._route.division_._div._dir.Dnt(dnt);
			}
			return _address._route.division_._div.Dir.OfDnt(dnt);
		}

		static public nilnul.fs.ILocation Location_dntAssumeExists(nilnul.fs.FolderI folder, _address._route.division_._div.DstI dnt) {
			switch (dnt)
			{
				case _address._route.division_._div.DirI dir:
					return  new nilnul.fs.folder_.ParentDir(
						folder
						,
						_address._route.division_._div.dir._RegressionsX.ToOld( dir)
					);

				case _address._route.division_._div._dir.DntI dnt1:
					return   nilnul.fs.file_._BasedX.File(
						folder
						,
						_address._route.division_._div._dir.dnt._RegressionsX.ToOldDoc( dnt1)
					);

				default:
					throw new Exception($"{dnt} must exist");
					break;
			};
		}

		static public nilnul.fs.ILocation Location_dntAssumeExists(nilnul.fs.address_.ShieldI folder, _address._route.division_._div.DstI dnt) {
			return Location_dntAssumeExists(new nilnul.fs.Folder(folder),dnt);
		}
	}
}
