using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.dirs_
{
#pragma warning disable CS0612 // 'DirsI' is obsolete
	public class Started : nilnul.objs_.Started2<DirI, DirsI>
#pragma warning restore CS0612 // 'DirsI' is obsolete


	{
#pragma warning disable CS0612 // 'DirsI' is obsolete
		public Started(DirI head, DirsI tail) : base(head, tail)
#pragma warning restore CS0612 // 'DirsI' is obsolete
		{

		}

		public static Started CreateFroDsts(IEnumerable<DirI> dsts)
		{
			return new Started(
				dsts.First()
				,
#pragma warning disable CS0612 // 'Dirs' is obsolete
				new Dirs(
#pragma warning restore CS0612 // 'Dirs' is obsolete
					dsts.Skip(1).ToArray()
				)
			);
		}

		public override string ToString()
		{
#pragma warning disable CS0618 // '_PhraseX.ToTxt(DirI[])' is obsolete: 'Div'
			return dir.str._PhraseX.ToTxt(this.toArr());
#pragma warning restore CS0618 // '_PhraseX.ToTxt(DirI[])' is obsolete: 'Div'
		}


	}
}