using System.Collections.Generic;
using System.Linq;

namespace nilnul.txt.accumulate_.join_.fs_
{
	/// <summary>
	/// usually ";"
	/// </summary>
	public class Path1 : nilnul.txt.accumulate_.Join
	{
		public Path1() : base(System.IO.Path.PathSeparator)
		{
		}

		public string accumulate(params string[] v1)
		{
			return accumulate(v1 as IEnumerable<string>);
		}

		public string accumulate(nilnul.fs._address._dst.denote.str_.SeqI _dsts)
		{
			return accumulate(_dsts.Select(x => x.en));
		}
		public string accumulate(IEnumerable<nilnul.fs._address._dst.Denote> _dsts)
		{
			return accumulate(_dsts.Select(x => x.en));
		}

#pragma warning disable CS0108 // 'Path1.Singleton' hides inherited member 'Join.Singleton'. Use the new keyword if hiding was intended.
		static public Path1 Singleton
#pragma warning restore CS0108 // 'Path1.Singleton' hides inherited member 'Join.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Path1>.Instance;
			}
		}
	}
}
