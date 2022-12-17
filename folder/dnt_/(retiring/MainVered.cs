using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.slider.to;
using nilnul.txt;
using nilnul.str;
using nilnul.str_.started;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.fs.folder.dst_
{
	[Obsolete(nameof(nilnul.fs.folder.denote_.MainVered))]
	public class MainVered
	//	: 
	//nilnul.win.storage.address.be.en_.Folder
	{

		public nilnul.fs.FolderI3 _parent
;
		public nilnul.fs.FolderI3 parent
		{
			get { return _parent; }
			set
			{
				_parent = parent;
			}
		}

		public MainVered(
			nilnul.fs.FolderI3 folder
		)
		{
			_parent = folder;
		}

		public MainVered(
			nilnul.fs.address_.ShieldI1 parent
		):this(
			new nilnul.fs.Folder2(parent)
		)
		{

		}

		static public MainVered OvAddress(string address) {
			return new MainVered(nilnul.fs.folder_._AddressX1.Create(
				address
				)
			);
		}



		public DirectoryInfo	parentAsInfo
		{
			get { return new DirectoryInfo(_parent.ToString()); }
		}




		public nilnul.Num nextVer(nilnul.txt_._nameVer_.Name prefix,nilnul.fs._address._doc.Ext ext)
		{
			var s = parentAsInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Select(x=>nilnul.fs._address.doc_.MainExt.Parse(x) )
			.Where(
				
				x=>
				nilnul.fs._address._doc.ext.Eq.Singleton.Equals(
					x.ext
					,
				//.EndsWith($".{ext}")
					ext
				)
			)
			.Select(
				x=> nilnul.txt_.NameVer.Parse( x.main.ToString())//.Substring(0, x.Length -$".{ext}".Length)	
			)
			.Where(
				x=>  x.name.ToString() == prefix 
				//x=>nilnul.txt_.vered.be_._NamedAsX.Be(prefix,x.ToString()) 
			)
			//.Select(
			//	x => nilnul.txt.Versioned1.Parse(x)
			//)
			.Select(x =>  new nilnul.Num( x.version));
			if (s.Any())
			{
				return nilnul.nums_.started._MaxX._Eval( s)  + (nilnul.Num)1;
			}
			return (nilnul.Num)0;
		}


		public nilnul.Num nextVer(string prefix,string ext)
		{
			return nextVer( nilnul.txt_.NameVer.Parse(prefix).name,ext);
			//var s = parentAsInfo.EnumerateFileSystemInfos().Select(
			//	x => x.Name
			//)
			//.Where(x=> x.EndsWith($".{ext}") )
			//.Select(
			//	x=>x.Substring(0, x.Length -$".{ext}".Length)	
			//)
			//.Where(
			//	x=>nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix,x) 
			//)
			//.Select(
			//	x => nilnul.txt.Versioned1.Parse(x)
			//)
			//.Select(x =>  new nilnul.Num( x.version));
			//if (s.Any())
			//{
			//	return nilnul.nums_.started._MaxX._Eval( s)  + (nilnul.Num)1;
			//}
			//return (nilnul.Num)0;
		}

		public nilnul.Num nextVer(nilnul.txt_._nameVer_.Name prefix,string ext)
		{

			return nextVer(prefix, new nilnul.fs._address._doc.Ext(ext));
			//var s = parentAsInfo.EnumerateFileSystemInfos().Select(
			//	x => x.Name
			//)
			//.Where(x=> x.EndsWith($".{ext}") )
			//.Select(
			//	x=>x.Substring(0, x.Length -$".{ext}".Length)	
			//)
			//.Where(
			//	x=>nilnul.txt_._versioned.txt.be_.VersionedWithPrefix.Be(prefix,x) 
			//)
			//.Select(
			//	x => nilnul.txt.Versioned1.Parse(x)
			//)
			//.Select(x =>  new nilnul.Num( x.version));
			//if (s.Any())
			//{
			//	return nilnul.nums_.started._MaxX._Eval( s)  + (nilnul.Num)1;
			//}
			//return (nilnul.Num)0;
		}
		public string next(nilnul.txt_._nameVer_.Name vered,nilnul.fs._address._doc.Ext ext)
		{
			return $"{vered}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(vered,ext))}{ext}";
		}


		public string nextDst(nilnul.txt_.NameVer vered,nilnul.fs._address._doc.Ext ext)
		{
			return nextDst(vered.name,ext);
		}


		public string nextDst(nilnul.txt_.NameVer vered,string ext)
		{
			return nextDst( vered, new nilnul.fs._address._doc.Ext(ext));
			//return $"{vered.name}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(vered.name,ext))}.{ext}";
		}


		public string nextDst(string prefix,string ext)
		{
			return nextDst( nilnul.txt_.NameVer.Parse(prefix),ext);
			//return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(nextVer(prefix,ext))}.{ext}";
		}



	

		public string nextAddress(string prefix,string ext)
		{
			return $"{_parent}{System.IO.Path.DirectorySeparatorChar}{nextDst(prefix,ext)}";
		}



	}
}
