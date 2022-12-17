using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D = nilnul.fs._address._route.division_._div._dir.DntI;

namespace nilnul.fs.folder.dnts_
{
	static public class _IgnoredX
	{
		
		
		static public IEnumerable<string> FroIgnoreDoc(nilnul.fs.FolderI1 folder, D doc=null)
		{
			doc = doc ?? dnts_._ignored.SettingsX.Dnt;
			var spear = new nilnul.fs.address_.spear_.based_.Child1(folder.address.ee, doc);

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				return nilnul.obj.str_.seq.op_.unary_._AppendX.Append(
					nilnul.fs.file.blob_.txt_.lines._AsSeqX.NoWhite_Trim(spear.ToString())
					, doc.ToString()
				);
			}

			return new string[] { doc.ToString()};
		}


		static public IEnumerable<string> FroIgnoreDoc(nilnul.fs.Folder1 folder, D doc)
		{
			return FroIgnoreDoc((FolderI1)folder, doc);
		}

		static public IEnumerable<string> FroIgnoreDoc(DirectoryInfo folder, D doc)
		{
			return FroIgnoreDoc( new nilnul.fs.Folder1(folder),doc);
		}

		static public nilnul.fs._address._route.division_._div._dir.dnt.Set Set_froIgnoreDoc(DirectoryInfo folder, _address._route.division_._div._dir.DntI  doc)
		{
			return new nilnul.fs._address._route.division_._div._dir.dnt.Set( FroIgnoreDoc( (folder),doc) );
		}

		

		static public nilnul.fs._address._route.division_._div._dir.dnt.Set Set_froIgnoreDoc(nilnul.fs.FolderI1 folder, _address._route.division_._div._dir.DntI doc=null)
		{
			return new nilnul.fs._address._route.division_._div._dir.dnt.Set( FroIgnoreDoc( folder,doc) );
		}

		static public IEnumerable<string> FroIgnoreDoc(nilnul.fs.FolderI1 folder, _address._route.division_._div._dir.Dnt doc)
		{
			return FroIgnoreDoc(folder, (_address._route.division_._div._dir.DntI)(doc) );
		}
		static public IEnumerable<string> FroIgnoreDoc(nilnul.fs.FolderI1 folder,string doc=null)
		{
			return FroIgnoreDoc(folder, new _address._route.division_._div._dir.Dnt(doc?? dnts_._ignored.SettingsX.DefaultIgnoreDoc) );
		}

	}
}
