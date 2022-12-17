using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.unjoint.every.div_
{
	public class Nonrepeats
	{
		

			private nilnul.fs.folders_.unjoint.every.div_._nonrepeats.Io _io;

			public nilnul.fs.folders_.unjoint.every.div_._nonrepeats.Io io
			{
				get { return _io; }
				set { _io = value; }
			}
			public Nonrepeats(_nonrepeats.Io io)
			{
				_io = io;
			}

			public IEnumerable<string> addresses(

			)
			{

				return io.destinySrc.Values.SelectMany(
					f => new each.div_.Nonrepeats(io).addresses_ofAddress(f.ToString())
				);
			}


	}

}
