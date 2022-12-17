using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dst_.vered_
{
	public class _NextX
	{
		static public nilnul.Num Num(DirectoryInfo dirInfo, string prefix)
		{
			var s = dirInfo.EnumerateFileSystemInfos().Select(
				x => x.Name
			)
			.Where(
				x => nilnul.txt_.vered.be_._NamedAsX.Be(prefix, x)
			)
			.Select(
				x => nilnul.txt.Versioned1.Parse(x)
			)
			.Select(x => (nilnul.Num)x.version.val);
			if (s.Any())
			{
				return nilnul.nums_.started._MaxX._Eval(s) + (nilnul.Num)1;
			}
			return (nilnul.Num)0;
		}
		private static Num Num(nilnul.fs.FolderI3 parent, string prefix)
		{
			return Num(nilnul.fs.folder.to_.DirInfo.Singleton.to(parent),prefix);
		}



		static public string Name(DirectoryInfo dirInfo,string prefix)
		{
			return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(Num(dirInfo,prefix))}";
		}
		public static string Name(FolderI3 parent, string prefix)
		{
			return $"{prefix}{nilnul.txt_.num_.radix_.Dec.Singleton.toTxt_zeroEmpty(Num(parent,prefix))}";
		
		}


		static public string Address(nilnul.fs.FolderI3 parent, string prefix)
		{
			return $"{parent}{System.IO.Path.DirectorySeparatorChar}{Name(parent, prefix)}";
		}


		static public DirectoryInfo CreateFolder_retInfo(nilnul.fs.FolderI3 parent, string prefix)
		{
			return System.IO.Directory.CreateDirectory(
				Address(parent,prefix)
			);
		}

	}

}
