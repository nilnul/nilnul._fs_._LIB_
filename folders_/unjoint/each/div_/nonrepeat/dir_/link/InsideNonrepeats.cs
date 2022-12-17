using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.unjoint.each.div_.nonrepeat.dir_.link
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
		) {
			var old = io._addDestiny_addressAssumeLink(folder);

			if (old.Key is null)
			{
				///unjoint
				///

				return new unjoint.InsideNonrepeats(io).addresses_ofAddress(folder);

			}
			else
			{
				Trace.TraceError( // link shall not cross
					$"{folder} is already processed by {old.Key}, which is linked by {old.Value}"
				);
				return new string[0];

			}

			

		}
	}
}
