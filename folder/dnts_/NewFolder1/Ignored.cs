using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.denotes_
{
	[Obsolete()]
	static public class _IgnoredX
	{
		
		
		static public IEnumerable<string> FroIgnoreDoc(nilnul.fs.FolderI folder, _address.DocI doc=null)
		{
			doc = doc ?? dnts_._ignored.SettingsX.Doc;
			var spear = new nilnul.fs.address_.spear_.ParentDoc(folder.address.en, doc);

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				return nilnul.obj.str_.seq.op_.unary_._AppendX.Append(
					nilnul.fs.file.blob_.txt_.lines._AsSeqX.NoWhite_Trim(spear.ToString())
					, doc.ToString()
				);
			}
			return new string[] { doc.ToString()};
		}


		static public IEnumerable<string> FroIgnoreDoc(nilnul.fs.Folder folder, _address.DocI doc)
		{
			return FroIgnoreDoc((FolderI)folder, doc);
		}

		static public IEnumerable<string> FroIgnoreDoc(DirectoryInfo folder, _address.DocI doc)
		{
			return FroIgnoreDoc( new nilnul.fs.Folder(folder),doc);
		}

		//static public nilnul.fs._address._dst.denote.Set Set_froIgnoreDoc(DirectoryInfo folder, _address._route.division_._div._dir.DntI  doc)
		//{
		//	return new nilnul.fs._address._dst.denote.Set( FroIgnoreDoc( (folder),doc) );
		//}

		static public nilnul.fs._address._dst.denote.Set Set_froIgnoreDoc(DirectoryInfo folder, _address.DocI doc)
		{
			return new nilnul.fs._address._dst.denote.Set( FroIgnoreDoc( (folder),doc) );
		}

		static public nilnul.fs._address._dst.denote.Set Set_froIgnoreDoc(nilnul.fs.FolderI folder, _address.DocI doc=null)
		{
			return new nilnul.fs._address._dst.denote.Set( FroIgnoreDoc( folder,doc) );
		}

		static public IEnumerable<string> FroIgnoreDoc(nilnul.fs.FolderI folder,_address.Doc doc)
		{
			return FroIgnoreDoc(folder, (_address.DocI)(doc) );
		}
		static public IEnumerable<string> FroIgnoreDoc(nilnul.fs.FolderI folder,string doc=null)
		{
			return FroIgnoreDoc(folder, new _address.Doc(doc?? dnts_._ignored.SettingsX.DefaultIgnoreDoc) );
		}

	}
}
