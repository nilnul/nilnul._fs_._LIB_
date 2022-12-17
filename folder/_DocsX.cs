using nilnul.fs._address;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder
{
	static public class _DocsX
	{
		static public IEnumerable<string> Captions(DirectoryInfo folder)
		{
			return folder.EnumerateFiles().Select(x => x.Name);
		}

		[Obsolete(nameof(Captions))]
		static public IEnumerable<string> Names(DirectoryInfo folder)
		{
			return Captions(folder);
		}

		//[Obsolete(nameof(Denotes))]
		static public IEnumerable<nilnul.fs._address.DocI> Docs(nilnul.fs.FolderI folderAddress)
		{
			return Names(to_.Info.Singleton.to(folderAddress)).Select(x => new nilnul.fs._address.Doc(x));
		}

		static public IEnumerable<nilnul.fs._address._route.division_._div._dir.Dnt> Docs(nilnul.fs.FolderI1 folderAddress)
		{
			return Names(op_.to_._InfoX.To(folderAddress)).Select(x => new nilnul.fs._address._route.division_._div._dir.Dnt(x)
			);
		}

		[Obsolete(nameof(Docs))]
		static public IEnumerable<nilnul.fs._address._dst.Denote> Denotes(nilnul.fs.FolderI folderAddress)
		{
			return Captions(to_.Info.Singleton.to(folderAddress)).Select(x => new nilnul.fs._address._dst.Denote(x));
		}

		[Obsolete()]
		static public IEnumerable<nilnul.fs._address.DocI> Docs(DirectoryInfo folderAddress)
		{
			return Captions((folderAddress)).Select(x => new nilnul.fs._address.Doc(x));
		}

		static public IEnumerable<nilnul.fs._address._route.division_._div._dir.Dnt> Docs1(DirectoryInfo folderAddress)
		{
			return Captions((folderAddress)).Select(x => new nilnul.fs._address._route.division_._div._dir.Dnt(x));
		}

		public static IEnumerable<_address._dst.Denote> Denotes(DirectoryInfo folder)
		{
			return Names(folder).Select(x => new nilnul.fs._address._dst.Denote(x) );
		}

		public static IEnumerable<nilnul.fs._address.DocI> Docs(Folder folderInfo)
		{
			return Docs(
				(FolderI)folderInfo
			);
		}

		public static IEnumerable<nilnul.fs._address.DocI> Docs(ShieldI parent)
		{
			return Docs(new nilnul.fs.Folder(parent));
		}

		public static IEnumerable<string> Names(Folder folderInfo)
		{
			return Docs(
				folderInfo
			).Select(x => x.denote.en);
		}

		public static IEnumerable<string> Docs_ofAddress(string folderInfo)
		{
			return Names(
				nilnul.fs.Folder.FroAddress(folderInfo)
			);
		}

		public static IEnumerable<string> Names(FolderI folderInfo)
		{
			return Names(nilnul.fs.folder.to_._InfoX.To(folderInfo));
			//throw new NotImplementedException();
		}

		static public IEnumerable<nilnul.fs.address_.SpearI> Spears(DirectoryInfo folder)
		{
			return folder.GetFiles().Select(
				x => (nilnul.fs.address_.Spear)(x)
			);
		}

		static public IEnumerable<nilnul.fs.address_.SpearI> Spears(nilnul.fs.FolderI folder)
		{
			return Infos(folder).Select(
				x => (nilnul.fs.address_.Spear)(x)
			);
		}

		static public IEnumerable<nilnul.fs.File> Files(nilnul.fs.FolderI folder)
		{
			return Infos(folder).Select(
				x => new nilnul.fs.File(x)
			);
		}

		static public IEnumerable<nilnul.fs.address_.SpearI> Spears(nilnul.fs.Folder folder)
		{
			return Spears((FolderI)folder);
		}

		static public IEnumerable<nilnul.fs.address_.SpearI> Spears_ofAddress(string folder)
		{
			return Spears(
				nilnul.fs.Folder.FroAddress(folder)
			);
		}

		static public IEnumerable<FileInfo> Infos(DirectoryInfo folder)
		{
			return folder.GetFiles();
		}

		static public IEnumerable<string> Names_ofAddress(string folderAddress)
		{
			return Names(new DirectoryInfo(folderAddress));
		}

		static public IEnumerable<FileInfo> Infos_ofAddress(string folderAddress)
		{
			return Infos(new DirectoryInfo(folderAddress));
		}

		static public IEnumerable<FileInfo> Infos(nilnul.fs.FolderI folderAddress)
		{
			return Infos(to_.Info.Singleton.to(folderAddress));
		}
	}
}
