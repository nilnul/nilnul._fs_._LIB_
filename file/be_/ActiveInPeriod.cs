using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.time_.datetime;

namespace nilnul.fs.file.be_
{
	static public class _ActiveInPeriodX
	{
		
		

	}

	public class ActiveInPeriod :
		nilnul.obj.Box<
			nilnul.time_.datetime.Bound
		>,
		nilnul.fs.file.BeI
	{
		public ActiveInPeriod(Bound val) : base(val)
		{
		}

		public ActiveInPeriod(string start, string end):this(
			 Bound.CreateClose(DateTime.Parse(start), DateTime.Parse(end))
			)
		{

		}

		public bool be(FileI obj)
		{
			var fileAddress = obj.file.en.ToString();
			var time = System.IO.File.GetCreationTime(fileAddress);

			var mtime = System.IO.File.GetLastWriteTime(fileAddress);
			var atime = System.IO.File.GetLastAccessTime(fileAddress);

			var times = new[] {time,mtime,atime };

			return times.Any(
				t=> boxed.contain(t)
			);
		
		}

	}
}
