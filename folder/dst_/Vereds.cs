using nilnul.fs._address;
using nilnul.txt_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace nilnul.fs.folder.dst_
{
	public class Vereds
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.FolderI1 _folder
;
		public nilnul.fs.FolderI1 folder
		{
			get { return _folder; }
			set
			{
				_folder = folder;
			}
		}

		public Vereds(
			nilnul.fs.FolderI1 folder
		)
		{
			_folder = folder;
		}
		public Vereds(
			nilnul.fs.Folder1 folder
		):this((nilnul.fs.FolderI1)folder)
		{
			//_folder = folder;
		}

		public Vereds(
			DirectoryInfo folder
		) : this(
			new nilnul.fs.Folder1(folder)
		)
		{
		}
		public Vereds(
			nilnul.fs.address_.ShieldI1 folder
		) : this(
			new nilnul.fs.Folder1(folder)
		)
		{
		}

		static public Vereds OvAddress(string address)
		{
			return new Vereds(nilnul.fs.Folder1.FroAddress(
				address
				)
			);
		}


		public DirectoryInfo dirInfo
		{
			get { return new DirectoryInfo(_folder.ToString()); }
		}


		public IEnumerable<FileSystemInfo> infos(txt_._vered.Name prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix, x.Name)
			);
		}
		public IEnumerable<_address._route.division_._div.DstI> dsts(txt_._vered.Name denote)
		{
			return infos_ofNom(denote).Select(
				info=> nilnul.fs._address._route.division_._div.DstA.Of(info)
			);
			

		}

		public IEnumerable<FileSystemInfo> infos_ofNom(string prefix)
		{
			return dirInfo.EnumerateFileSystemInfos().Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix, x.Name)
			);
		}


		public IEnumerable<_address._route.division_._div.DstI> dsts_ofNom(string prefix)
		{
			return infos_ofNom(prefix).Select(
				info=> nilnul.fs._address._route.division_._div.DstA.Of(info)
			);
		}

	


	}
}
