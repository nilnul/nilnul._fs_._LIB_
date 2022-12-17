using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs._address.dsts_
{
	public class Started : nilnul.objs_.Started2<DstI, DstsI>

	{
		public Started(DstI head, DstsI tail) : base(head, tail)
		{

		}

		public static Started CreateFroDsts(IEnumerable<DstI> dsts)
		{
			return new Started(
				dsts.First()
				,
				new Dsts(
					dsts.Skip(1)
				)
			);
		}

		public override string ToString()
		{
			return string.Join(System.IO.Path.DirectorySeparatorChar.ToString(), this);
		}

		static public Started Parse(string path)
		{
			var stem = Div.Parse(path);
			return new Started(
				stem.dirs.First()
				,
				new Dsts(stem.dirs.Skip(1))
			);
		}

		public static Started CreateFroDsts(IEnumerable<string> enumerable)
		{

			return CreateFroDsts(enumerable.Select(x => nilnul.fs._address.DstA.Parse(x)));

			throw new NotImplementedException();
		}
	}
}