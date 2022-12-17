using nilnul.fs.folder.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.unjoint.each.div_.nonrepeat
{
	public class InsideNonrepeats
	{
		nilnul.fs.folders_.unjoint.every.div_._nonrepeats.Io io;

		public InsideNonrepeats(nilnul.fs.folders_.unjoint.every.div_._nonrepeats.Io io)
		{
			this.io = io;
		}

		public IEnumerable<string> addresses_ofAddress(
			string folder
		)
		{

			var dirs = nilnul.fs.folder._DirsX.Captions_ofAddress(folder);

			foreach (var dir in dirs)
			{
				var dirAddress = System.IO.Path.Combine(folder, dir.ToString());

				foreach (
					var item
					in
					new dir.InsideNonrepeats(io).addresses_ofAddress(
						dirAddress
					)
				)
				{
					yield return item;
				}
			}
			yield return folder;
		}
	}
}





