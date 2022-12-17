using nilnul.fs._address._dst;
using System;

namespace nilnul.fs._address
{
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	///
	[Obsolete()]
	public abstract class DstA :
		nilnul.obj.Box<_dst.Denote>
		,
		DstI
	{
		public DstA(_dst.Denote denote) : base(denote)
		{

		}
		public DstA(DstI dst) : this(dst.denote)
		{

		}
		public Denote denote => this.boxed;

		static public DstI Parse(string x)
		{
			if (nilnul.txt.be_.fs_.EndWithDirSep.Singleton.be(x))
			{
				return Dir.Parse(x);

			}

			return new Doc(
					x
			);
		}

		static public DstI Normal(DstI dst) {
			switch (dst)
			{
				case _address.DocI doc:
					return doc;
				case _address.DirI dir:
					return dir;
				default:
					return Parse(dst.ToString());
					break;
			}
		}







	}
}
