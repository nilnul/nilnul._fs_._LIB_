using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address
{
	/*extern alias obj;*/
	/// <summary>
	/// a file or folder in a folder. This is useful to hold the information of the last segment of a path.
	/// </summary>
	/// 
	[Obsolete()]
	public class Dirs
		:
		nilnul.objs_.enumerable_.enum2Arr_.BoxEnumerable<DirI>
		, DirsI


	{


		public Dirs(IEnumerable<DirI> dirs) : base(dirs)
		{
		}


		public Dirs() : this(new Dir[0])
		{

		}

		public Dirs(IEnumerable<DstI> dsts)
			: this(dsts.Select(dst => new Dir(dst)))
		{


		}

		public Dirs(IEnumerable<Dir> enumerable) : base(enumerable)
		{
		}

		public override string ToString()
		{
			return nilnul.txt.accumulate_.join_.fs_.Path.Singleton.accumulate(
				enumerable.Select(x =>
					(x).ToString()
				)
			);
		}




	}
}
