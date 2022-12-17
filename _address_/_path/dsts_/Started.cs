using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path.dsts_
{
	public class Started :  nilnul.objs_.Started1<DstI, _path.DstsI1 >

	{
		public Started(DstI head, DstsI1 tail) : base(head, tail)
		{

		}

		public override string ToString()
		{
			return string.Join(System.IO.Path.DirectorySeparatorChar.ToString(), this);
		}

		static public Started Parse(string path) {
			var stem= _path_.Stem.Parse(path);
			return new Started(
				stem.dirs.First()
				,
				new _path.Dsts1(  stem.dirs.Skip(1))
			);
		}
	}
}