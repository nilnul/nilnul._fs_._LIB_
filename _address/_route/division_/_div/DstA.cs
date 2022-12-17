using nilnul.fs._address._dst;
using System;
using System.IO;

namespace nilnul.fs._address._route.division_._div
{
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	/// 
	public abstract class DstA :
		nilnul.obj.Box1<_dir.Dnt>
		,
		DstI
	{
		public DstA(_dir.Dnt denote) : base(denote)
		{

		}
		public DstA(DstI dst) : this(dst.caption)
		{

		}
		public _dir.Dnt caption => this.boxed;

		static public DstI Parse(string x)
		{
			if (nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(x))
			{
				return Dir.Parse(x);

			}

			return new _dir.Dnt(
					x
			);
		}

		static public DstI Of(DstI dst) {
			switch (dst)
			{
				case _dir.DntI doc:
					return doc;
				case _div.DirI dir:
					return dir;
				default:
					return Parse(dst.ToString());
					break;
			}
		}

		public static DstI Of(FileSystemInfo info)
		{
			return info switch {
				FileInfo f=> new _dir.Dnt(f.Name)
				,
				DirectoryInfo  d=>  Dir.OfDnt(d.Name)
			};
		}
	}
}
