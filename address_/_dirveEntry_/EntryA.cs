using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_._driveEntry_
{
	public abstract class EntryA:EntryI
	{

		public static EntryA Parse(string entry) {

			var dsts = entry.Split(nilnul.characters_.DirSeperator.Chars).Skip(1);

			var container= new entry_.Container(
					dsts.Take(dsts.Count() -1).Select(x=> new nilnul.fs._address.Dst(x))
				);



			if (dsts.Last() =="")
			{
				return container;
			}

			return new entry_.container.dst.Element(
				container
				,
				new nilnul.fs._address.Dst(
					dsts.Last()
				)
			);


		}

	}
}
